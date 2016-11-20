<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbout
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
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.textTitle = New System.Windows.Forms.TextBox()
        Me.textVersion = New System.Windows.Forms.TextBox()
        Me.labelVersion = New System.Windows.Forms.Label()
        Me.textDeveloper = New System.Windows.Forms.TextBox()
        Me.textLicense = New System.Windows.Forms.TextBox()
        Me.labelDeveloper = New System.Windows.Forms.Label()
        Me.labelLicense = New System.Windows.Forms.Label()
        Me.textWebsite = New System.Windows.Forms.TextBox()
        Me.labelWebste = New System.Windows.Forms.Label()
        Me.textDescription = New System.Windows.Forms.TextBox()
        Me.labelDescription = New System.Windows.Forms.Label()
        Me.labelHorizontalLine = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonClose
        '
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.buttonClose.Location = New System.Drawing.Point(12, 201)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(320, 37)
        Me.buttonClose.TabIndex = 13
        Me.buttonClose.Text = "CLOSE"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        'labelTitle
        '
        Me.labelTitle.Location = New System.Drawing.Point(12, 22)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(80, 22)
        Me.labelTitle.TabIndex = 0
        Me.labelTitle.Text = "Title:"
        Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textTitle
        '
        Me.textTitle.Location = New System.Drawing.Point(98, 22)
        Me.textTitle.MaxLength = 512
        Me.textTitle.Name = "textTitle"
        Me.textTitle.ReadOnly = True
        Me.textTitle.Size = New System.Drawing.Size(234, 22)
        Me.textTitle.TabIndex = 6
        '
        'textVersion
        '
        Me.textVersion.Location = New System.Drawing.Point(98, 50)
        Me.textVersion.MaxLength = 512
        Me.textVersion.Name = "textVersion"
        Me.textVersion.ReadOnly = True
        Me.textVersion.Size = New System.Drawing.Size(234, 22)
        Me.textVersion.TabIndex = 7
        '
        'labelVersion
        '
        Me.labelVersion.Location = New System.Drawing.Point(12, 50)
        Me.labelVersion.Name = "labelVersion"
        Me.labelVersion.Size = New System.Drawing.Size(80, 22)
        Me.labelVersion.TabIndex = 1
        Me.labelVersion.Text = "Version:"
        Me.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textDeveloper
        '
        Me.textDeveloper.Location = New System.Drawing.Point(98, 78)
        Me.textDeveloper.MaxLength = 512
        Me.textDeveloper.Name = "textDeveloper"
        Me.textDeveloper.ReadOnly = True
        Me.textDeveloper.Size = New System.Drawing.Size(234, 22)
        Me.textDeveloper.TabIndex = 8
        '
        'textLicense
        '
        Me.textLicense.Location = New System.Drawing.Point(98, 106)
        Me.textLicense.MaxLength = 512
        Me.textLicense.Name = "textLicense"
        Me.textLicense.ReadOnly = True
        Me.textLicense.Size = New System.Drawing.Size(234, 22)
        Me.textLicense.TabIndex = 9
        '
        'labelDeveloper
        '
        Me.labelDeveloper.Location = New System.Drawing.Point(12, 78)
        Me.labelDeveloper.Name = "labelDeveloper"
        Me.labelDeveloper.Size = New System.Drawing.Size(80, 22)
        Me.labelDeveloper.TabIndex = 2
        Me.labelDeveloper.Text = "Developer:"
        Me.labelDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelLicense
        '
        Me.labelLicense.Location = New System.Drawing.Point(12, 106)
        Me.labelLicense.Name = "labelLicense"
        Me.labelLicense.Size = New System.Drawing.Size(80, 22)
        Me.labelLicense.TabIndex = 3
        Me.labelLicense.Text = "License:"
        Me.labelLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textWebsite
        '
        Me.textWebsite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.textWebsite.Location = New System.Drawing.Point(98, 134)
        Me.textWebsite.MaxLength = 512
        Me.textWebsite.Name = "textWebsite"
        Me.textWebsite.ReadOnly = True
        Me.textWebsite.Size = New System.Drawing.Size(234, 22)
        Me.textWebsite.TabIndex = 10
        '
        'labelWebste
        '
        Me.labelWebste.Location = New System.Drawing.Point(12, 134)
        Me.labelWebste.Name = "labelWebste"
        Me.labelWebste.Size = New System.Drawing.Size(80, 22)
        Me.labelWebste.TabIndex = 4
        Me.labelWebste.Text = "Website:"
        Me.labelWebste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textDescription
        '
        Me.textDescription.Location = New System.Drawing.Point(98, 162)
        Me.textDescription.MaxLength = 512
        Me.textDescription.Name = "textDescription"
        Me.textDescription.ReadOnly = True
        Me.textDescription.Size = New System.Drawing.Size(234, 22)
        Me.textDescription.TabIndex = 11
        '
        'labelDescription
        '
        Me.labelDescription.Location = New System.Drawing.Point(12, 162)
        Me.labelDescription.Name = "labelDescription"
        Me.labelDescription.Size = New System.Drawing.Size(80, 22)
        Me.labelDescription.TabIndex = 5
        Me.labelDescription.Text = "Description:"
        Me.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelHorizontalLine
        '
        Me.labelHorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelHorizontalLine.Location = New System.Drawing.Point(12, 196)
        Me.labelHorizontalLine.Name = "labelHorizontalLine"
        Me.labelHorizontalLine.Size = New System.Drawing.Size(320, 2)
        Me.labelHorizontalLine.TabIndex = 12
        '
        'FormAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.buttonClose
        Me.ClientSize = New System.Drawing.Size(344, 250)
        Me.Controls.Add(Me.labelHorizontalLine)
        Me.Controls.Add(Me.labelDescription)
        Me.Controls.Add(Me.textDescription)
        Me.Controls.Add(Me.labelWebste)
        Me.Controls.Add(Me.textWebsite)
        Me.Controls.Add(Me.labelLicense)
        Me.Controls.Add(Me.labelDeveloper)
        Me.Controls.Add(Me.textLicense)
        Me.Controls.Add(Me.textDeveloper)
        Me.Controls.Add(Me.labelVersion)
        Me.Controls.Add(Me.textVersion)
        Me.Controls.Add(Me.textTitle)
        Me.Controls.Add(Me.labelTitle)
        Me.Controls.Add(Me.buttonClose)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAbout"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shollym Switcher | About"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents labelTitle As System.Windows.Forms.Label
    Friend WithEvents textTitle As System.Windows.Forms.TextBox
    Friend WithEvents textVersion As System.Windows.Forms.TextBox
    Friend WithEvents labelVersion As System.Windows.Forms.Label
    Friend WithEvents textDeveloper As System.Windows.Forms.TextBox
    Friend WithEvents textLicense As System.Windows.Forms.TextBox
    Friend WithEvents labelDeveloper As System.Windows.Forms.Label
    Friend WithEvents labelLicense As System.Windows.Forms.Label
    Friend WithEvents textWebsite As System.Windows.Forms.TextBox
    Friend WithEvents labelWebste As System.Windows.Forms.Label
    Friend WithEvents textDescription As System.Windows.Forms.TextBox
    Friend WithEvents labelDescription As System.Windows.Forms.Label
    Friend WithEvents labelHorizontalLine As System.Windows.Forms.Label
End Class
