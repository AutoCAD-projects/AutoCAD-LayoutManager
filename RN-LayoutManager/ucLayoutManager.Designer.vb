﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucLayoutManager
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTitel = New System.Windows.Forms.Label()
        Me.flowLayouts = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdRefreshList = New System.Windows.Forms.Button()
        Me.cmdPlot = New System.Windows.Forms.Button()
        Me.cmdSortDESC = New System.Windows.Forms.Button()
        Me.cmdSortASC = New System.Windows.Forms.Button()
        Me.lblCheckCount = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblTitel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.flowLayouts, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(420, 956)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblTitel
        '
        Me.lblTitel.AutoSize = True
        Me.lblTitel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTitel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitel.Location = New System.Drawing.Point(3, 3)
        Me.lblTitel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblTitel.Name = "lblTitel"
        Me.lblTitel.Size = New System.Drawing.Size(414, 17)
        Me.lblTitel.TabIndex = 1
        Me.lblTitel.Text = "RN Layout Manager"
        '
        'flowLayouts
        '
        Me.flowLayouts.AutoScroll = True
        Me.flowLayouts.AutoSize = True
        Me.flowLayouts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flowLayouts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayouts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowLayouts.Location = New System.Drawing.Point(3, 73)
        Me.flowLayouts.Name = "flowLayouts"
        Me.flowLayouts.Size = New System.Drawing.Size(414, 830)
        Me.flowLayouts.TabIndex = 0
        Me.flowLayouts.WrapContents = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdPlot)
        Me.GroupBox1.Controls.Add(Me.cmdSortDESC)
        Me.GroupBox1.Controls.Add(Me.cmdSortASC)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 20)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(420, 50)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCheckCount)
        Me.GroupBox2.Controls.Add(Me.cmdRefreshList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 906)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Size = New System.Drawing.Size(420, 50)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'cmdRefreshList
        '
        Me.cmdRefreshList.BackgroundImage = Global.RN_LayoutManager.My.Resources.Resources.icon_refresh
        Me.cmdRefreshList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdRefreshList.Location = New System.Drawing.Point(4, 11)
        Me.cmdRefreshList.Name = "cmdRefreshList"
        Me.cmdRefreshList.Size = New System.Drawing.Size(34, 34)
        Me.cmdRefreshList.TabIndex = 3
        Me.cmdRefreshList.UseVisualStyleBackColor = True
        '
        'cmdPlot
        '
        Me.cmdPlot.BackgroundImage = Global.RN_LayoutManager.My.Resources.Resources.icon_print
        Me.cmdPlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdPlot.Location = New System.Drawing.Point(84, 11)
        Me.cmdPlot.Name = "cmdPlot"
        Me.cmdPlot.Size = New System.Drawing.Size(34, 34)
        Me.cmdPlot.TabIndex = 6
        Me.cmdPlot.UseVisualStyleBackColor = True
        '
        'cmdSortDESC
        '
        Me.cmdSortDESC.BackgroundImage = Global.RN_LayoutManager.My.Resources.Resources.icon_sort_descending
        Me.cmdSortDESC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSortDESC.Location = New System.Drawing.Point(44, 11)
        Me.cmdSortDESC.Name = "cmdSortDESC"
        Me.cmdSortDESC.Size = New System.Drawing.Size(34, 34)
        Me.cmdSortDESC.TabIndex = 5
        Me.cmdSortDESC.UseVisualStyleBackColor = True
        '
        'cmdSortASC
        '
        Me.cmdSortASC.BackgroundImage = Global.RN_LayoutManager.My.Resources.Resources.icon_sort_ascending
        Me.cmdSortASC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSortASC.Location = New System.Drawing.Point(6, 11)
        Me.cmdSortASC.Name = "cmdSortASC"
        Me.cmdSortASC.Size = New System.Drawing.Size(34, 34)
        Me.cmdSortASC.TabIndex = 4
        Me.cmdSortASC.UseVisualStyleBackColor = True
        '
        'lblCheckCount
        '
        Me.lblCheckCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCheckCount.AutoSize = True
        Me.lblCheckCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCheckCount.Location = New System.Drawing.Point(326, 32)
        Me.lblCheckCount.Name = "lblCheckCount"
        Me.lblCheckCount.Size = New System.Drawing.Size(89, 13)
        Me.lblCheckCount.TabIndex = 4
        Me.lblCheckCount.Text = "lblCheckCount"
        Me.lblCheckCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ucLayoutManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ucLayoutManager"
        Me.Size = New System.Drawing.Size(420, 956)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents flowLayouts As Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblTitel As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents cmdSortDESC As Windows.Forms.Button
    Friend WithEvents cmdSortASC As Windows.Forms.Button
    Friend WithEvents cmdPlot As Windows.Forms.Button
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents cmdRefreshList As Windows.Forms.Button
    Friend WithEvents lblCheckCount As Windows.Forms.Label
End Class