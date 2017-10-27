﻿Imports System.IO
Imports System.Text
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.PlottingServices
Imports Autodesk.AutoCAD.Publishing
Public Class plotting
    Public Class MultiSheetsPdf
        Private dwgFile As String, pdfFile As String, dsdFile As String, outputDir As String
        Private sheetNum As Integer
        Private layouts As IEnumerable(Of Layout)

        Private Const LOG As String = "publish.log"

        Public Sub New(pdfFile As String, layouts As IEnumerable(Of Layout))
            Dim db As Database = HostApplicationServices.WorkingDatabase
            Me.dwgFile = db.Filename
            Me.pdfFile = pdfFile
            Me.outputDir = Path.GetDirectoryName(Me.pdfFile)
            Me.dsdFile = Path.ChangeExtension(Me.pdfFile, "dsd")
            Me.layouts = layouts
        End Sub

        Public Sub Publish()
            If TryCreateDSD() Then
                'Autodesk.AutoCAD.ApplicationServices.Application
                Dim publisher As Publisher = Autodesk.AutoCAD.ApplicationServices.Application.Publisher
                Dim plotDlg As New PlotProgressDialog(False, Me.sheetNum, True)
                publisher.PublishDsd(Me.dsdFile, plotDlg)
                plotDlg.Destroy()
                File.Delete(Me.dsdFile)
                MsgBox("PDF aanmaken is voltooid!")
            End If
        End Sub

        Private Function TryCreateDSD() As Boolean
            Using dsd As New DsdData()
                Using dsdEntries As DsdEntryCollection = CreateDsdEntryCollection(Me.layouts)
                    If dsdEntries Is Nothing OrElse dsdEntries.Count <= 0 Then
                        Return False
                    End If

                    If Not Directory.Exists(Me.outputDir) Then
                        Directory.CreateDirectory(Me.outputDir)
                    End If

                    Me.sheetNum = dsdEntries.Count

                    dsd.SetDsdEntryCollection(dsdEntries)

                    dsd.SetUnrecognizedData("PwdProtectPublishedDWF", "FALSE")
                    dsd.SetUnrecognizedData("PromptForPwd", "FALSE")
                    'dsd.SheetType = SheetType.MultiDwf
                    dsd.SheetType = SheetType.MultiPdf
                    dsd.NoOfCopies = 1
                    dsd.DestinationName = Me.pdfFile
                    dsd.IsHomogeneous = False
                    dsd.LogFilePath = Path.Combine(Me.outputDir, LOG)

                    PostProcessDSD(dsd)

                    Return True
                End Using
            End Using
        End Function

        Private Function CreateDsdEntryCollection(layouts As IEnumerable(Of Layout)) As DsdEntryCollection
            Dim entries As New DsdEntryCollection()

            For Each layout As Layout In layouts
                Dim dsdEntry As New DsdEntry()
                dsdEntry.DwgName = Me.dwgFile
                dsdEntry.Layout = layout.LayoutName
                dsdEntry.Title = Path.GetFileNameWithoutExtension(Me.dwgFile) + "-" + layout.LayoutName
                dsdEntry.Nps = layout.TabOrder.ToString()
                entries.Add(dsdEntry)
            Next
            Return entries
        End Function

        Private Sub PostProcessDSD(dsd As DsdData)
            Dim str As String, newStr As String
            Dim tmpFile As String = Path.Combine(Me.outputDir, "temp.dsd")

            dsd.WriteDsd(tmpFile)

            Using reader As New StreamReader(tmpFile, Encoding.[Default])
                Using writer As New StreamWriter(Me.dsdFile, False, Encoding.[Default])
                    While Not reader.EndOfStream
                        str = reader.ReadLine()
                        If str.Contains("Has3DDWF") Then
                            newStr = "Has3DDWF=0"
                        ElseIf str.Contains("OriginalSheetPath") Then
                            newStr = Convert.ToString("OriginalSheetPath=") & Me.dwgFile
                        ElseIf str.Contains("Type") Then
                            newStr = "Type=6"
                        ElseIf str.Contains("OUT") Then
                            newStr = Convert.ToString("OUT=") & Me.outputDir
                        ElseIf str.Contains("IncludeLayer") Then
                            newStr = "IncludeLayer=TRUE"
                        ElseIf str.Contains("PromptForDwfName") Then
                            newStr = "PromptForDwfName=FALSE"
                        ElseIf str.Contains("LogFilePath") Then
                            newStr = "LogFilePath=" + Path.Combine(Me.outputDir, LOG)
                        Else
                            newStr = str
                        End If
                        writer.WriteLine(newStr)
                    End While
                End Using
            End Using
            File.Delete(tmpFile)
        End Sub
    End Class


End Class