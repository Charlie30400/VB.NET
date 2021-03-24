<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btnCustomerSection = New System.Windows.Forms.Button()
        Me.btnEmployeeSection = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCustomerSection
        '
        Me.btnCustomerSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerSection.Location = New System.Drawing.Point(174, 47)
        Me.btnCustomerSection.Name = "btnCustomerSection"
        Me.btnCustomerSection.Size = New System.Drawing.Size(159, 34)
        Me.btnCustomerSection.TabIndex = 0
        Me.btnCustomerSection.Text = "Customer Section"
        Me.btnCustomerSection.UseVisualStyleBackColor = True
        '
        'btnEmployeeSection
        '
        Me.btnEmployeeSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeSection.Location = New System.Drawing.Point(174, 128)
        Me.btnEmployeeSection.Name = "btnEmployeeSection"
        Me.btnEmployeeSection.Size = New System.Drawing.Size(159, 29)
        Me.btnEmployeeSection.TabIndex = 1
        Me.btnEmployeeSection.Text = "Employee Section"
        Me.btnEmployeeSection.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.ForeColor = System.Drawing.Color.Red
        Me.btnLogOut.Location = New System.Drawing.Point(385, 0)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(119, 50)
        Me.btnLogOut.TabIndex = 2
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 286)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnEmployeeSection)
        Me.Controls.Add(Me.btnCustomerSection)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "frmMenu"
        Me.Text = "Menu Section"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCustomerSection As Button
    Friend WithEvents btnEmployeeSection As Button
    Friend WithEvents btnLogOut As Button
End Class
