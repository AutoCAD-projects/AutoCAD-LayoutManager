﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFilter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.radioSelectedItems = New System.Windows.Forms.RadioButton()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdSaveFilter = New System.Windows.Forms.Button()
        Me.cmdDelFilter = New System.Windows.Forms.Button()
        Me.radioVisibleItems = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'radioSelectedItems
        '
        Me.radioSelectedItems.AutoSize = True
        Me.radioSelectedItems.Location = New System.Drawing.Point(47, 35)
        Me.radioSelectedItems.Name = "radioSelectedItems"
        Me.radioSelectedItems.Size = New System.Drawing.Size(226, 17)
        Me.radioSelectedItems.TabIndex = 0
        Me.radioSelectedItems.TabStop = True
        Me.radioSelectedItems.Text = "Voeg geselecteerde items toe aan het filter"
        Me.radioSelectedItems.UseVisualStyleBackColor = True
        '
        'cmbFilter
        '
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Location = New System.Drawing.Point(47, 6)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(346, 21)
        Me.cmbFilter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filter"
        '
        'cmdSaveFilter
        '
        Me.cmdSaveFilter.Location = New System.Drawing.Point(411, 58)
        Me.cmdSaveFilter.Name = "cmdSaveFilter"
        Me.cmdSaveFilter.Size = New System.Drawing.Size(73, 21)
        Me.cmdSaveFilter.TabIndex = 3
        Me.cmdSaveFilter.Text = "Opslaan"
        Me.cmdSaveFilter.UseVisualStyleBackColor = True
        '
        'cmdDelFilter
        '
        Me.cmdDelFilter.Location = New System.Drawing.Point(411, 5)
        Me.cmdDelFilter.Name = "cmdDelFilter"
        Me.cmdDelFilter.Size = New System.Drawing.Size(73, 21)
        Me.cmdDelFilter.TabIndex = 4
        Me.cmdDelFilter.Text = "Verwijderen"
        Me.cmdDelFilter.UseVisualStyleBackColor = True
        '
        'radioVisibleItems
        '
        Me.radioVisibleItems.AutoSize = True
        Me.radioVisibleItems.Location = New System.Drawing.Point(47, 58)
        Me.radioVisibleItems.Name = "radioVisibleItems"
        Me.radioVisibleItems.Size = New System.Drawing.Size(248, 17)
        Me.radioVisibleItems.TabIndex = 5
        Me.radioVisibleItems.TabStop = True
        Me.radioVisibleItems.Text = "Voeg zichtbare items uit de lijst toe aan het filter"
        Me.radioVisibleItems.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(25, 127)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(435, 278)
        Me.TextBox1.TabIndex = 6
        '
        'frmFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 422)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.radioVisibleItems)
        Me.Controls.Add(Me.cmdDelFilter)
        Me.Controls.Add(Me.cmdSaveFilter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.radioSelectedItems)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RN LayoutManager - Filter Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radioSelectedItems As Windows.Forms.RadioButton
    Friend WithEvents cmbFilter As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents cmdSaveFilter As Windows.Forms.Button
    Friend WithEvents cmdDelFilter As Windows.Forms.Button
    Friend WithEvents radioVisibleItems As Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
End Class
