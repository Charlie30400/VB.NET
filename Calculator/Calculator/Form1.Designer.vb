<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cal
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
        Me.txt_num1 = New System.Windows.Forms.TextBox()
        Me.txt_num2 = New System.Windows.Forms.TextBox()
        Me.txt_result = New System.Windows.Forms.TextBox()
        Me.rdo_add = New System.Windows.Forms.RadioButton()
        Me.rdo_sub = New System.Windows.Forms.RadioButton()
        Me.rdo_multi = New System.Windows.Forms.RadioButton()
        Me.rdo_divi = New System.Windows.Forms.RadioButton()
        Me.lbl_val1 = New System.Windows.Forms.Label()
        Me.lbl_val2 = New System.Windows.Forms.Label()
        Me.btn_cal = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_num1
        '
        Me.txt_num1.Location = New System.Drawing.Point(262, 60)
        Me.txt_num1.Name = "txt_num1"
        Me.txt_num1.Size = New System.Drawing.Size(100, 20)
        Me.txt_num1.TabIndex = 0
        Me.txt_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_num2
        '
        Me.txt_num2.Location = New System.Drawing.Point(262, 150)
        Me.txt_num2.Name = "txt_num2"
        Me.txt_num2.Size = New System.Drawing.Size(100, 20)
        Me.txt_num2.TabIndex = 1
        Me.txt_num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_result
        '
        Me.txt_result.ForeColor = System.Drawing.Color.Teal
        Me.txt_result.Location = New System.Drawing.Point(499, 60)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.ReadOnly = True
        Me.txt_result.Size = New System.Drawing.Size(100, 20)
        Me.txt_result.TabIndex = 2
        Me.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rdo_add
        '
        Me.rdo_add.AutoSize = True
        Me.rdo_add.Location = New System.Drawing.Point(393, 60)
        Me.rdo_add.Name = "rdo_add"
        Me.rdo_add.Size = New System.Drawing.Size(56, 17)
        Me.rdo_add.TabIndex = 3
        Me.rdo_add.TabStop = True
        Me.rdo_add.Text = "Add(+)"
        Me.rdo_add.UseVisualStyleBackColor = True
        '
        'rdo_sub
        '
        Me.rdo_sub.AutoSize = True
        Me.rdo_sub.Location = New System.Drawing.Point(393, 102)
        Me.rdo_sub.Name = "rdo_sub"
        Me.rdo_sub.Size = New System.Drawing.Size(88, 17)
        Me.rdo_sub.TabIndex = 4
        Me.rdo_sub.TabStop = True
        Me.rdo_sub.Text = "Subtraction(-)"
        Me.rdo_sub.UseVisualStyleBackColor = True
        '
        'rdo_multi
        '
        Me.rdo_multi.AutoSize = True
        Me.rdo_multi.Location = New System.Drawing.Point(393, 134)
        Me.rdo_multi.Name = "rdo_multi"
        Me.rdo_multi.Size = New System.Drawing.Size(90, 17)
        Me.rdo_multi.TabIndex = 5
        Me.rdo_multi.TabStop = True
        Me.rdo_multi.Text = "Multiplicatin(*)"
        Me.rdo_multi.UseVisualStyleBackColor = True
        '
        'rdo_divi
        '
        Me.rdo_divi.AutoSize = True
        Me.rdo_divi.Location = New System.Drawing.Point(393, 170)
        Me.rdo_divi.Name = "rdo_divi"
        Me.rdo_divi.Size = New System.Drawing.Size(62, 17)
        Me.rdo_divi.TabIndex = 6
        Me.rdo_divi.TabStop = True
        Me.rdo_divi.Text = "Division"
        Me.rdo_divi.UseVisualStyleBackColor = True
        '
        'lbl_val1
        '
        Me.lbl_val1.AutoSize = True
        Me.lbl_val1.Location = New System.Drawing.Point(288, 29)
        Me.lbl_val1.Name = "lbl_val1"
        Me.lbl_val1.Size = New System.Drawing.Size(54, 13)
        Me.lbl_val1.TabIndex = 7
        Me.lbl_val1.Text = "Variable 1"
        '
        'lbl_val2
        '
        Me.lbl_val2.AutoSize = True
        Me.lbl_val2.Location = New System.Drawing.Point(288, 134)
        Me.lbl_val2.Name = "lbl_val2"
        Me.lbl_val2.Size = New System.Drawing.Size(54, 13)
        Me.lbl_val2.TabIndex = 8
        Me.lbl_val2.Text = "Variable 2"
        '
        'btn_cal
        '
        Me.btn_cal.Location = New System.Drawing.Point(291, 239)
        Me.btn_cal.Name = "btn_cal"
        Me.btn_cal.Size = New System.Drawing.Size(75, 23)
        Me.btn_cal.TabIndex = 9
        Me.btn_cal.Text = "Calculation"
        Me.btn_cal.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(497, 239)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(75, 23)
        Me.btn_del.TabIndex = 10
        Me.btn_del.Text = "Delete"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(535, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Result"
        '
        'frm_cal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 329)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_cal)
        Me.Controls.Add(Me.lbl_val2)
        Me.Controls.Add(Me.lbl_val1)
        Me.Controls.Add(Me.rdo_divi)
        Me.Controls.Add(Me.rdo_multi)
        Me.Controls.Add(Me.rdo_sub)
        Me.Controls.Add(Me.rdo_add)
        Me.Controls.Add(Me.txt_result)
        Me.Controls.Add(Me.txt_num2)
        Me.Controls.Add(Me.txt_num1)
        Me.Name = "frm_cal"
        Me.Text = "Calculation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_num1 As TextBox
    Friend WithEvents txt_num2 As TextBox
    Friend WithEvents txt_result As TextBox
    Friend WithEvents rdo_add As RadioButton
    Friend WithEvents rdo_sub As RadioButton
    Friend WithEvents rdo_multi As RadioButton
    Friend WithEvents rdo_divi As RadioButton
    Friend WithEvents lbl_val1 As Label
    Friend WithEvents lbl_val2 As Label
    Friend WithEvents btn_cal As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents Label1 As Label
End Class
