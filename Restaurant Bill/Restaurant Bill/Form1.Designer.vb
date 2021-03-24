<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Restaurant
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
        Me.lbl_Pizza = New System.Windows.Forms.Label()
        Me.lbl_Fries = New System.Windows.Forms.Label()
        Me.lbl_Drinks = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_result3 = New System.Windows.Forms.TextBox()
        Me.txt_result2 = New System.Windows.Forms.TextBox()
        Me.txt_result1 = New System.Windows.Forms.TextBox()
        Me.Quantity = New System.Windows.Forms.ListBox()
        Me.btn_Compute = New System.Windows.Forms.Button()
        Me.btn_Quit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Pizza
        '
        Me.lbl_Pizza.AutoSize = True
        Me.lbl_Pizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pizza.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Pizza.Location = New System.Drawing.Point(12, 111)
        Me.lbl_Pizza.Name = "lbl_Pizza"
        Me.lbl_Pizza.Size = New System.Drawing.Size(264, 25)
        Me.lbl_Pizza.TabIndex = 0
        Me.lbl_Pizza.Text = "How many pizza slices?"
        '
        'lbl_Fries
        '
        Me.lbl_Fries.AutoSize = True
        Me.lbl_Fries.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Fries.Location = New System.Drawing.Point(67, 155)
        Me.lbl_Fries.Name = "lbl_Fries"
        Me.lbl_Fries.Size = New System.Drawing.Size(193, 25)
        Me.lbl_Fries.TabIndex = 1
        Me.lbl_Fries.Text = "How many Fries?"
        '
        'lbl_Drinks
        '
        Me.lbl_Drinks.AutoSize = True
        Me.lbl_Drinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Drinks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_Drinks.Location = New System.Drawing.Point(21, 192)
        Me.lbl_Drinks.Name = "lbl_Drinks"
        Me.lbl_Drinks.Size = New System.Drawing.Size(250, 25)
        Me.lbl_Drinks.TabIndex = 2
        Me.lbl_Drinks.Text = "How many soft drinks?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(262, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Restaurant Bill"
        '
        'txt_result3
        '
        Me.txt_result3.Location = New System.Drawing.Point(277, 197)
        Me.txt_result3.Name = "txt_result3"
        Me.txt_result3.Size = New System.Drawing.Size(49, 20)
        Me.txt_result3.TabIndex = 6
        '
        'txt_result2
        '
        Me.txt_result2.Location = New System.Drawing.Point(277, 155)
        Me.txt_result2.Name = "txt_result2"
        Me.txt_result2.Size = New System.Drawing.Size(49, 20)
        Me.txt_result2.TabIndex = 7
        '
        'txt_result1
        '
        Me.txt_result1.Location = New System.Drawing.Point(277, 117)
        Me.txt_result1.Name = "txt_result1"
        Me.txt_result1.Size = New System.Drawing.Size(49, 20)
        Me.txt_result1.TabIndex = 8
        '
        'Quantity
        '
        Me.Quantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Quantity.FormattingEnabled = True
        Me.Quantity.Location = New System.Drawing.Point(422, 89)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(343, 303)
        Me.Quantity.TabIndex = 9
        '
        'btn_Compute
        '
        Me.btn_Compute.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Compute.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Compute.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Compute.Location = New System.Drawing.Point(236, 280)
        Me.btn_Compute.Name = "btn_Compute"
        Me.btn_Compute.Size = New System.Drawing.Size(157, 112)
        Me.btn_Compute.TabIndex = 10
        Me.btn_Compute.Text = "Compute"
        Me.btn_Compute.UseVisualStyleBackColor = False
        '
        'btn_Quit
        '
        Me.btn_Quit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Quit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Quit.Location = New System.Drawing.Point(26, 280)
        Me.btn_Quit.Name = "btn_Quit"
        Me.btn_Quit.Size = New System.Drawing.Size(157, 112)
        Me.btn_Quit.TabIndex = 11
        Me.btn_Quit.Text = "Quit"
        Me.btn_Quit.UseVisualStyleBackColor = False
        '
        'frm_Restaurant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Quit)
        Me.Controls.Add(Me.btn_Compute)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.txt_result1)
        Me.Controls.Add(Me.txt_result2)
        Me.Controls.Add(Me.txt_result3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_Drinks)
        Me.Controls.Add(Me.lbl_Fries)
        Me.Controls.Add(Me.lbl_Pizza)
        Me.Name = "frm_Restaurant"
        Me.Text = "Restaurant Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Pizza As Label
    Friend WithEvents lbl_Fries As Label
    Friend WithEvents lbl_Drinks As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_result3 As TextBox
    Friend WithEvents txt_result2 As TextBox
    Friend WithEvents txt_result1 As TextBox
    Friend WithEvents Quantity As ListBox
    Friend WithEvents btn_Compute As Button
    Friend WithEvents btn_Quit As Button
End Class
