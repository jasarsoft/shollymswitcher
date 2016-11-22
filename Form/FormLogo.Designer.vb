<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogo
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
        Me.labelRecomend = New System.Windows.Forms.Label()
        Me.labelWidth = New System.Windows.Forms.Label()
        Me.labelHeight = New System.Windows.Forms.Label()
        Me.labelFormat = New System.Windows.Forms.Label()
        Me.labelX = New System.Windows.Forms.Label()
        Me.labelHorizontalLine1 = New System.Windows.Forms.Label()
        Me.labelWarning = New System.Windows.Forms.Label()
        Me.textPath = New System.Windows.Forms.TextBox()
        Me.labelHorizontalLine2 = New System.Windows.Forms.Label()
        Me.buttonSelect = New System.Windows.Forms.Button()
        Me.buttonSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelRecomend
        '
        Me.labelRecomend.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.labelRecomend.Location = New System.Drawing.Point(12, 21)
        Me.labelRecomend.Name = "labelRecomend"
        Me.labelRecomend.Size = New System.Drawing.Size(95, 21)
        Me.labelRecomend.TabIndex = 0
        Me.labelRecomend.Text = "Recommend:"
        Me.labelRecomend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelWidth
        '
        Me.labelWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.labelWidth.Location = New System.Drawing.Point(113, 21)
        Me.labelWidth.Name = "labelWidth"
        Me.labelWidth.Size = New System.Drawing.Size(60, 21)
        Me.labelWidth.TabIndex = 1
        Me.labelWidth.Text = "320"
        Me.labelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelHeight
        '
        Me.labelHeight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.labelHeight.Location = New System.Drawing.Point(197, 21)
        Me.labelHeight.Name = "labelHeight"
        Me.labelHeight.Size = New System.Drawing.Size(60, 21)
        Me.labelHeight.TabIndex = 3
        Me.labelHeight.Text = "100"
        Me.labelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelFormat
        '
        Me.labelFormat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.labelFormat.Location = New System.Drawing.Point(263, 21)
        Me.labelFormat.Name = "labelFormat"
        Me.labelFormat.Size = New System.Drawing.Size(69, 21)
        Me.labelFormat.TabIndex = 4
        Me.labelFormat.Text = "PNG"
        Me.labelFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelX
        '
        Me.labelX.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.labelX.Location = New System.Drawing.Point(179, 21)
        Me.labelX.Name = "labelX"
        Me.labelX.Size = New System.Drawing.Size(12, 21)
        Me.labelX.TabIndex = 2
        Me.labelX.Text = "x"
        Me.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelHorizontalLine1
        '
        Me.labelHorizontalLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelHorizontalLine1.Location = New System.Drawing.Point(12, 42)
        Me.labelHorizontalLine1.Name = "labelHorizontalLine1"
        Me.labelHorizontalLine1.Size = New System.Drawing.Size(320, 2)
        Me.labelHorizontalLine1.TabIndex = 5
        '
        'labelWarning
        '
        Me.labelWarning.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.labelWarning.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.labelWarning.Location = New System.Drawing.Point(12, 53)
        Me.labelWarning.Name = "labelWarning"
        Me.labelWarning.Size = New System.Drawing.Size(320, 21)
        Me.labelWarning.TabIndex = 6
        Me.labelWarning.Text = "Warning, the new logo will be replaced with the old."
        Me.labelWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'textPath
        '
        Me.textPath.Location = New System.Drawing.Point(15, 86)
        Me.textPath.MaxLength = 512
        Me.textPath.Name = "textPath"
        Me.textPath.ReadOnly = True
        Me.textPath.Size = New System.Drawing.Size(317, 22)
        Me.textPath.TabIndex = 7
        '
        'labelHorizontalLine2
        '
        Me.labelHorizontalLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelHorizontalLine2.Location = New System.Drawing.Point(12, 120)
        Me.labelHorizontalLine2.Name = "labelHorizontalLine2"
        Me.labelHorizontalLine2.Size = New System.Drawing.Size(320, 2)
        Me.labelHorizontalLine2.TabIndex = 8
        '
        'buttonSelect
        '
        Me.buttonSelect.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.buttonSelect.Location = New System.Drawing.Point(113, 125)
        Me.buttonSelect.Name = "buttonSelect"
        Me.buttonSelect.Size = New System.Drawing.Size(219, 40)
        Me.buttonSelect.TabIndex = 10
        Me.buttonSelect.Text = "SELECT LOGO"
        Me.buttonSelect.UseVisualStyleBackColor = True
        '
        'buttonSave
        '
        Me.buttonSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.buttonSave.Location = New System.Drawing.Point(12, 125)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(95, 40)
        Me.buttonSave.TabIndex = 9
        Me.buttonSave.Text = "SAVE"
        Me.buttonSave.UseVisualStyleBackColor = True
        '
        'FormLogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 177)
        Me.Controls.Add(Me.buttonSave)
        Me.Controls.Add(Me.buttonSelect)
        Me.Controls.Add(Me.labelHorizontalLine2)
        Me.Controls.Add(Me.textPath)
        Me.Controls.Add(Me.labelWarning)
        Me.Controls.Add(Me.labelHorizontalLine1)
        Me.Controls.Add(Me.labelX)
        Me.Controls.Add(Me.labelFormat)
        Me.Controls.Add(Me.labelHeight)
        Me.Controls.Add(Me.labelWidth)
        Me.Controls.Add(Me.labelRecomend)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shollym Switcher | Logo"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelRecomend As System.Windows.Forms.Label
    Friend WithEvents labelWidth As System.Windows.Forms.Label
    Friend WithEvents labelHeight As System.Windows.Forms.Label
    Friend WithEvents labelFormat As System.Windows.Forms.Label
    Friend WithEvents labelX As System.Windows.Forms.Label
    Friend WithEvents labelHorizontalLine1 As System.Windows.Forms.Label
    Friend WithEvents labelWarning As System.Windows.Forms.Label
    Friend WithEvents textPath As System.Windows.Forms.TextBox
    Friend WithEvents labelHorizontalLine2 As System.Windows.Forms.Label
    Friend WithEvents buttonSelect As System.Windows.Forms.Button
    Friend WithEvents buttonSave As System.Windows.Forms.Button
End Class
