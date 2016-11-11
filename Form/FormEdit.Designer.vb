<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEdit
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
        Me.textOld = New System.Windows.Forms.TextBox()
        Me.labelOld = New System.Windows.Forms.Label()
        Me.textNew = New System.Windows.Forms.TextBox()
        Me.labelNew = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textOld
        '
        Me.textOld.Location = New System.Drawing.Point(113, 21)
        Me.textOld.MaxLength = 512
        Me.textOld.Name = "textOld"
        Me.textOld.ReadOnly = True
        Me.textOld.Size = New System.Drawing.Size(220, 22)
        Me.textOld.TabIndex = 0
        '
        'labelOld
        '
        Me.labelOld.Location = New System.Drawing.Point(12, 21)
        Me.labelOld.Name = "labelOld"
        Me.labelOld.Size = New System.Drawing.Size(95, 22)
        Me.labelOld.TabIndex = 1
        Me.labelOld.Text = "Old Name:"
        Me.labelOld.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textNew
        '
        Me.textNew.Location = New System.Drawing.Point(113, 58)
        Me.textNew.MaxLength = 512
        Me.textNew.Name = "textNew"
        Me.textNew.Size = New System.Drawing.Size(220, 22)
        Me.textNew.TabIndex = 2
        '
        'labelNew
        '
        Me.labelNew.Location = New System.Drawing.Point(12, 58)
        Me.labelNew.Name = "labelNew"
        Me.labelNew.Size = New System.Drawing.Size(95, 22)
        Me.labelNew.TabIndex = 3
        Me.labelNew.Text = "New Name:"
        Me.labelNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(321, 2)
        Me.Label3.TabIndex = 4
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonSave.Location = New System.Drawing.Point(113, 93)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(220, 37)
        Me.ButtonSave.TabIndex = 5
        Me.ButtonSave.Text = "SAVE EDIT"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(12, 93)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(95, 37)
        Me.ButtonClose.TabIndex = 6
        Me.ButtonClose.Text = "CLOSE"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'FormEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 142)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.labelNew)
        Me.Controls.Add(Me.textNew)
        Me.Controls.Add(Me.labelOld)
        Me.Controls.Add(Me.textOld)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEdit"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shollym Switcher | Edit"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textOld As System.Windows.Forms.TextBox
    Friend WithEvents labelOld As System.Windows.Forms.Label
    Friend WithEvents textNew As System.Windows.Forms.TextBox
    Friend WithEvents labelNew As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
End Class
