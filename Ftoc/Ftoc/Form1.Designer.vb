<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Convert
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
        Me.lbl_Fahr = New System.Windows.Forms.Label()
        Me.txt_Temp1 = New System.Windows.Forms.TextBox()
        Me.btn_Convert = New System.Windows.Forms.Button()
        Me.txt_Temp2 = New System.Windows.Forms.TextBox()
        Me.lbl_Kel = New System.Windows.Forms.Label()
        Me.Result = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lbl_Fahr
        '
        Me.lbl_Fahr.AutoSize = True
        Me.lbl_Fahr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fahr.Location = New System.Drawing.Point(144, 93)
        Me.lbl_Fahr.Name = "lbl_Fahr"
        Me.lbl_Fahr.Size = New System.Drawing.Size(215, 20)
        Me.lbl_Fahr.TabIndex = 0
        Me.lbl_Fahr.Text = "Temperature(Fahrenheit):"
        '
        'txt_Temp1
        '
        Me.txt_Temp1.Location = New System.Drawing.Point(365, 93)
        Me.txt_Temp1.Name = "txt_Temp1"
        Me.txt_Temp1.Size = New System.Drawing.Size(130, 20)
        Me.txt_Temp1.TabIndex = 2
        '
        'btn_Convert
        '
        Me.btn_Convert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Convert.Location = New System.Drawing.Point(533, 93)
        Me.btn_Convert.Name = "btn_Convert"
        Me.btn_Convert.Size = New System.Drawing.Size(133, 79)
        Me.btn_Convert.TabIndex = 4
        Me.btn_Convert.Text = "Convert To Celsius"
        Me.btn_Convert.UseVisualStyleBackColor = True
        '
        'txt_Temp2
        '
        Me.txt_Temp2.Location = New System.Drawing.Point(365, 147)
        Me.txt_Temp2.Name = "txt_Temp2"
        Me.txt_Temp2.Size = New System.Drawing.Size(130, 20)
        Me.txt_Temp2.TabIndex = 5
        '
        'lbl_Kel
        '
        Me.lbl_Kel.AutoSize = True
        Me.lbl_Kel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Kel.Location = New System.Drawing.Point(167, 145)
        Me.lbl_Kel.Name = "lbl_Kel"
        Me.lbl_Kel.Size = New System.Drawing.Size(175, 20)
        Me.lbl_Kel.TabIndex = 6
        Me.lbl_Kel.Text = "Temperature(Kelvin):"
        '
        'Result
        '
        Me.Result.FormattingEnabled = True
        Me.Result.Location = New System.Drawing.Point(171, 223)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(495, 108)
        Me.Result.TabIndex = 7
        '
        'frm_Convert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.lbl_Kel)
        Me.Controls.Add(Me.txt_Temp2)
        Me.Controls.Add(Me.btn_Convert)
        Me.Controls.Add(Me.txt_Temp1)
        Me.Controls.Add(Me.lbl_Fahr)
        Me.Name = "frm_Convert"
        Me.Text = "Convert Fahrenheit to Celsius"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Fahr As Label
    Friend WithEvents txt_Temp1 As TextBox
    Friend WithEvents btn_Convert As Button
    Friend WithEvents txt_Temp2 As TextBox
    Friend WithEvents lbl_Kel As Label
    Friend WithEvents Result As ListBox
End Class
