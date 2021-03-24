<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lucky7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lucky7))
        Me.bln_Win = New System.Windows.Forms.Button()
        Me.lbl_Quit = New System.Windows.Forms.Button()
        Me.lbl_number1 = New System.Windows.Forms.Label()
        Me.lbl_number2 = New System.Windows.Forms.Label()
        Me.lbl_number3 = New System.Windows.Forms.Label()
        Me.pic_Picture = New System.Windows.Forms.PictureBox()
        Me.lbl_LuckySeven = New System.Windows.Forms.Label()
        CType(Me.pic_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bln_Win
        '
        Me.bln_Win.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bln_Win.Location = New System.Drawing.Point(82, 52)
        Me.bln_Win.Name = "bln_Win"
        Me.bln_Win.Size = New System.Drawing.Size(75, 23)
        Me.bln_Win.TabIndex = 0
        Me.bln_Win.Text = "WIN"
        Me.bln_Win.UseVisualStyleBackColor = True
        '
        'lbl_Quit
        '
        Me.lbl_Quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Quit.Location = New System.Drawing.Point(82, 142)
        Me.lbl_Quit.Name = "lbl_Quit"
        Me.lbl_Quit.Size = New System.Drawing.Size(75, 35)
        Me.lbl_Quit.TabIndex = 1
        Me.lbl_Quit.Text = "QUIT"
        Me.lbl_Quit.UseVisualStyleBackColor = True
        '
        'lbl_number1
        '
        Me.lbl_number1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_number1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_number1.Location = New System.Drawing.Point(271, 52)
        Me.lbl_number1.Name = "lbl_number1"
        Me.lbl_number1.Size = New System.Drawing.Size(100, 23)
        Me.lbl_number1.TabIndex = 2
        '
        'lbl_number2
        '
        Me.lbl_number2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_number2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_number2.Location = New System.Drawing.Point(411, 52)
        Me.lbl_number2.Name = "lbl_number2"
        Me.lbl_number2.Size = New System.Drawing.Size(100, 23)
        Me.lbl_number2.TabIndex = 3
        '
        'lbl_number3
        '
        Me.lbl_number3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_number3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_number3.Location = New System.Drawing.Point(551, 52)
        Me.lbl_number3.Name = "lbl_number3"
        Me.lbl_number3.Size = New System.Drawing.Size(100, 23)
        Me.lbl_number3.TabIndex = 4
        '
        'pic_Picture
        '
        Me.pic_Picture.Image = CType(resources.GetObject("pic_Picture.Image"), System.Drawing.Image)
        Me.pic_Picture.Location = New System.Drawing.Point(259, 112)
        Me.pic_Picture.Name = "pic_Picture"
        Me.pic_Picture.Size = New System.Drawing.Size(392, 163)
        Me.pic_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Picture.TabIndex = 5
        Me.pic_Picture.TabStop = False
        Me.pic_Picture.Visible = False
        '
        'lbl_LuckySeven
        '
        Me.lbl_LuckySeven.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LuckySeven.Location = New System.Drawing.Point(78, 255)
        Me.lbl_LuckySeven.Name = "lbl_LuckySeven"
        Me.lbl_LuckySeven.Size = New System.Drawing.Size(60, 40)
        Me.lbl_LuckySeven.TabIndex = 6
        Me.lbl_LuckySeven.Text = "Lucky " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seven"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_LuckySeven)
        Me.Controls.Add(Me.pic_Picture)
        Me.Controls.Add(Me.lbl_number3)
        Me.Controls.Add(Me.lbl_number2)
        Me.Controls.Add(Me.lbl_number1)
        Me.Controls.Add(Me.lbl_Quit)
        Me.Controls.Add(Me.bln_Win)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bln_Win As Button
    Friend WithEvents lbl_Quit As Button
    Friend WithEvents lbl_number1 As Label
    Friend WithEvents lbl_number2 As Label
    Friend WithEvents lbl_number3 As Label
    Friend WithEvents pic_Picture As PictureBox
    Friend WithEvents lbl_LuckySeven As Label
End Class
