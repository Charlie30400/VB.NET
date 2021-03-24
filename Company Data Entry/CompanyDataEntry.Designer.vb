<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompanyDataEntry
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompanyDataEntry))
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.InformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientDataSet = New Company_Data_Entry.ClientDataSet()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOwnerName = New System.Windows.Forms.TextBox()
        Me.lblOwnerName = New System.Windows.Forms.Label()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.txtCompanyID = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblCompanyID = New System.Windows.Forms.Label()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblCompanyDataEntry = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.InformationTableAdapter = New Company_Data_Entry.ClientDataSetTableAdapters.InformationTableAdapter()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        CType(Me.InformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "Phone Number", True))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(498, 347)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(134, 20)
        Me.txtPhoneNumber.TabIndex = 66
        '
        'InformationBindingSource
        '
        Me.InformationBindingSource.DataMember = "Information"
        Me.InformationBindingSource.DataSource = Me.ClientDataSet
        '
        'ClientDataSet
        '
        Me.ClientDataSet.DataSetName = "ClientDataSet"
        Me.ClientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(411, 347)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Phone Number:"
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "Email", True))
        Me.txtEmail.Location = New System.Drawing.Point(81, 344)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(246, 20)
        Me.txtEmail.TabIndex = 64
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(48, 347)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Email:"
        '
        'txtOwnerName
        '
        Me.txtOwnerName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "Owner Name", True))
        Me.txtOwnerName.Location = New System.Drawing.Point(92, 174)
        Me.txtOwnerName.Name = "txtOwnerName"
        Me.txtOwnerName.Size = New System.Drawing.Size(141, 20)
        Me.txtOwnerName.TabIndex = 61
        '
        'lblOwnerName
        '
        Me.lblOwnerName.AutoSize = True
        Me.lblOwnerName.Location = New System.Drawing.Point(9, 178)
        Me.lblOwnerName.Name = "lblOwnerName"
        Me.lblOwnerName.Size = New System.Drawing.Size(69, 13)
        Me.lblOwnerName.TabIndex = 59
        Me.lblOwnerName.Text = "OwnerName:"
        '
        'txtZipCode
        '
        Me.txtZipCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "Zip Code", True))
        Me.txtZipCode.Location = New System.Drawing.Point(498, 300)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(134, 20)
        Me.txtZipCode.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(442, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "ZipCode:"
        '
        'txtState
        '
        Me.txtState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "State", True))
        Me.txtState.Location = New System.Drawing.Point(324, 300)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(67, 20)
        Me.txtState.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(292, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "State:"
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "City", True))
        Me.txtCity.Location = New System.Drawing.Point(81, 300)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(113, 20)
        Me.txtCity.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "City:"
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "Address", True))
        Me.txtAddress.Location = New System.Drawing.Point(81, 261)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(610, 20)
        Me.txtAddress.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(307, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 24)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Address Section"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(307, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 24)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Address Section"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "Company Name", True))
        Me.txtCompanyName.Location = New System.Drawing.Point(92, 148)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(140, 20)
        Me.txtCompanyName.TabIndex = 46
        '
        'txtCompanyID
        '
        Me.txtCompanyID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "client_Id", True))
        Me.txtCompanyID.Location = New System.Drawing.Point(98, 85)
        Me.txtCompanyID.Name = "txtCompanyID"
        Me.txtCompanyID.Size = New System.Drawing.Size(113, 20)
        Me.txtCompanyID.TabIndex = 45
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(713, 410)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 35)
        Me.btnDelete.TabIndex = 43
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(630, 410)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 35)
        Me.btnSave.TabIndex = 42
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.Location = New System.Drawing.Point(538, 410)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 35)
        Me.btnCreate.TabIndex = 41
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(695, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 45)
        Me.btnClose.TabIndex = 40
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Location = New System.Drawing.Point(138, 6)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 45)
        Me.btnNext.TabIndex = 39
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.Location = New System.Drawing.Point(12, 6)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 45)
        Me.btnPrevious.TabIndex = 38
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'lblCompanyID
        '
        Me.lblCompanyID.AutoSize = True
        Me.lblCompanyID.Location = New System.Drawing.Point(27, 88)
        Me.lblCompanyID.Name = "lblCompanyID"
        Me.lblCompanyID.Size = New System.Drawing.Size(65, 13)
        Me.lblCompanyID.TabIndex = 37
        Me.lblCompanyID.Text = "CompanyID:"
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Location = New System.Drawing.Point(5, 152)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(82, 13)
        Me.lblCompanyName.TabIndex = 36
        Me.lblCompanyName.Text = "CompanyName:"
        '
        'lblCompanyDataEntry
        '
        Me.lblCompanyDataEntry.AutoSize = True
        Me.lblCompanyDataEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyDataEntry.ForeColor = System.Drawing.Color.Blue
        Me.lblCompanyDataEntry.Location = New System.Drawing.Point(291, 27)
        Me.lblCompanyDataEntry.Name = "lblCompanyDataEntry"
        Me.lblCompanyDataEntry.Size = New System.Drawing.Size(181, 24)
        Me.lblCompanyDataEntry.TabIndex = 34
        Me.lblCompanyDataEntry.Text = "Company Data Entry"
        '
        'txtEmpID
        '
        Me.txtEmpID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformationBindingSource, "empID", True))
        Me.txtEmpID.Location = New System.Drawing.Point(98, 115)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(50, 20)
        Me.txtEmpID.TabIndex = 68
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Location = New System.Drawing.Point(20, 118)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(67, 13)
        Me.lblEmployeeID.TabIndex = 67
        Me.lblEmployeeID.Text = "EmployeeID:"
        '
        'InformationTableAdapter
        '
        Me.InformationTableAdapter.ClearBeforeFill = True
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.Color.Red
        Me.lblCompany.Location = New System.Drawing.Point(217, 88)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(15, 20)
        Me.lblCompany.TabIndex = 69
        Me.lblCompany.Text = "*"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.ForeColor = System.Drawing.Color.Red
        Me.lblZip.Location = New System.Drawing.Point(638, 303)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(72, 20)
        Me.lblZip.TabIndex = 70
        Me.lblZip.Text = "Ej.(xxxxx)"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.Red
        Me.lblPhone.Location = New System.Drawing.Point(638, 344)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(100, 20)
        Me.lblPhone.TabIndex = 71
        Me.lblPhone.Text = "Ej.(xxxxxxxxx)"
        '
        'frmCompanyDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.lblEmployeeID)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtOwnerName)
        Me.Controls.Add(Me.lblOwnerName)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.txtCompanyID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblCompanyID)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.lblCompanyDataEntry)
        Me.Name = "frmCompanyDataEntry"
        Me.Text = "CompanyDataEntry"
        CType(Me.InformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtOwnerName As TextBox
    Friend WithEvents lblOwnerName As Label
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents txtCompanyID As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblCompanyID As Label
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents lblCompanyDataEntry As Label
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents ClientDataSet As ClientDataSet
    Friend WithEvents InformationBindingSource As BindingSource
    Friend WithEvents InformationTableAdapter As ClientDataSetTableAdapters.InformationTableAdapter
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblPhone As Label
End Class
