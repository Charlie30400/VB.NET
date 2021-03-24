<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployee))
        Me.lblEmployeeDataEntry = New System.Windows.Forms.Label()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientDataSet = New Company_Data_Entry.ClientDataSet()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAddressSection = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.txtTerminationDate = New System.Windows.Forms.TextBox()
        Me.txtHireDate = New System.Windows.Forms.TextBox()
        Me.lblTerminationDate = New System.Windows.Forms.Label()
        Me.lblHireDate = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.EmployeeTableAdapter = New Company_Data_Entry.ClientDataSetTableAdapters.EmployeeTableAdapter()
        Me.lblHire = New System.Windows.Forms.Label()
        Me.lblTermination = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmployeeDataEntry
        '
        Me.lblEmployeeDataEntry.AutoSize = True
        Me.lblEmployeeDataEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeDataEntry.ForeColor = System.Drawing.Color.Blue
        Me.lblEmployeeDataEntry.Location = New System.Drawing.Point(291, 33)
        Me.lblEmployeeDataEntry.Name = "lblEmployeeDataEntry"
        Me.lblEmployeeDataEntry.Size = New System.Drawing.Size(186, 24)
        Me.lblEmployeeDataEntry.TabIndex = 0
        Me.lblEmployeeDataEntry.Text = "Employee Data Entry"
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Location = New System.Drawing.Point(20, 101)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(67, 13)
        Me.lblEmployeeID.TabIndex = 1
        Me.lblEmployeeID.Text = "EmployeeID:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(48, 127)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(29, 158)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "LastName:"
        '
        'btnPrevious
        '
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.Location = New System.Drawing.Point(12, 12)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 34)
        Me.btnPrevious.TabIndex = 4
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Location = New System.Drawing.Point(138, 12)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 34)
        Me.btnNext.TabIndex = 5
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(695, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 34)
        Me.btnClose.TabIndex = 6
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.Location = New System.Drawing.Point(538, 410)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 41)
        Me.btnCreate.TabIndex = 7
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(630, 410)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 41)
        Me.btnSave.TabIndex = 8
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(713, 410)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 41)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empID", True))
        Me.txtEmployeeID.Location = New System.Drawing.Point(93, 98)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(50, 20)
        Me.txtEmployeeID.TabIndex = 10
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.ClientDataSet
        '
        'ClientDataSet
        '
        Me.ClientDataSet.DataSetName = "ClientDataSet"
        Me.ClientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empName", True))
        Me.txtName.Location = New System.Drawing.Point(92, 124)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(113, 20)
        Me.txtName.TabIndex = 11
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empLastName", True))
        Me.txtLastName.Location = New System.Drawing.Point(93, 158)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(113, 20)
        Me.txtLastName.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(307, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Address Section"
        '
        'lblAddressSection
        '
        Me.lblAddressSection.AutoSize = True
        Me.lblAddressSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressSection.ForeColor = System.Drawing.Color.Blue
        Me.lblAddressSection.Location = New System.Drawing.Point(307, 213)
        Me.lblAddressSection.Name = "lblAddressSection"
        Me.lblAddressSection.Size = New System.Drawing.Size(148, 24)
        Me.lblAddressSection.TabIndex = 14
        Me.lblAddressSection.Text = "Address Section"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(27, 270)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 15
        Me.lblAddress.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empAddress", True))
        Me.txtAddress.Location = New System.Drawing.Point(81, 267)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(610, 20)
        Me.txtAddress.TabIndex = 16
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(48, 322)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 17
        Me.lblCity.Text = "City:"
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empCity", True))
        Me.txtCity.Location = New System.Drawing.Point(81, 319)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(113, 20)
        Me.txtCity.TabIndex = 18
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(281, 322)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 19
        Me.lblState.Text = "State:"
        '
        'txtState
        '
        Me.txtState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empState", True))
        Me.txtState.Location = New System.Drawing.Point(322, 319)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(67, 20)
        Me.txtState.TabIndex = 20
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Location = New System.Drawing.Point(443, 322)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(50, 13)
        Me.lblZipCode.TabIndex = 21
        Me.lblZipCode.Text = "ZipCode:"
        '
        'txtZipCode
        '
        Me.txtZipCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empZipcode", True))
        Me.txtZipCode.Location = New System.Drawing.Point(498, 319)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(134, 20)
        Me.txtZipCode.TabIndex = 22
        '
        'cmbType
        '
        Me.cmbType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empType", True))
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"PART TIME", "FULL TIME"})
        Me.cmbType.Location = New System.Drawing.Point(584, 89)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 21)
        Me.cmbType.TabIndex = 23
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(544, 89)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 24
        Me.lblType.Text = "Type:"
        '
        'txtTerminationDate
        '
        Me.txtTerminationDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empTerminationDate", True))
        Me.txtTerminationDate.Location = New System.Drawing.Point(584, 162)
        Me.txtTerminationDate.Name = "txtTerminationDate"
        Me.txtTerminationDate.Size = New System.Drawing.Size(113, 20)
        Me.txtTerminationDate.TabIndex = 29
        '
        'txtHireDate
        '
        Me.txtHireDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empHIreDate", True))
        Me.txtHireDate.Location = New System.Drawing.Point(584, 124)
        Me.txtHireDate.Name = "txtHireDate"
        Me.txtHireDate.Size = New System.Drawing.Size(113, 20)
        Me.txtHireDate.TabIndex = 28
        '
        'lblTerminationDate
        '
        Me.lblTerminationDate.AutoSize = True
        Me.lblTerminationDate.Location = New System.Drawing.Point(495, 165)
        Me.lblTerminationDate.Name = "lblTerminationDate"
        Me.lblTerminationDate.Size = New System.Drawing.Size(88, 13)
        Me.lblTerminationDate.TabIndex = 26
        Me.lblTerminationDate.Text = "TerminationDate:"
        '
        'lblHireDate
        '
        Me.lblHireDate.AutoSize = True
        Me.lblHireDate.Location = New System.Drawing.Point(526, 127)
        Me.lblHireDate.Name = "lblHireDate"
        Me.lblHireDate.Size = New System.Drawing.Size(52, 13)
        Me.lblHireDate.TabIndex = 25
        Me.lblHireDate.Text = "HireDate:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(40, 376)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 30
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empEmail", True))
        Me.txtEmail.Location = New System.Drawing.Point(81, 369)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(246, 20)
        Me.txtEmail.TabIndex = 31
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(412, 372)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(81, 13)
        Me.lblPhoneNumber.TabIndex = 32
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empPhone", True))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(498, 369)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(134, 20)
        Me.txtPhoneNumber.TabIndex = 33
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'lblHire
        '
        Me.lblHire.AutoSize = True
        Me.lblHire.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHire.ForeColor = System.Drawing.Color.Red
        Me.lblHire.Location = New System.Drawing.Point(703, 122)
        Me.lblHire.Name = "lblHire"
        Me.lblHire.Size = New System.Drawing.Size(91, 18)
        Me.lblHire.TabIndex = 34
        Me.lblHire.Text = "Ej.(ddmmyy)"
        '
        'lblTermination
        '
        Me.lblTermination.AutoSize = True
        Me.lblTermination.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTermination.ForeColor = System.Drawing.Color.Red
        Me.lblTermination.Location = New System.Drawing.Point(703, 161)
        Me.lblTermination.Name = "lblTermination"
        Me.lblTermination.Size = New System.Drawing.Size(91, 18)
        Me.lblTermination.TabIndex = 35
        Me.lblTermination.Text = "Ej.(ddmmyy)"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.ForeColor = System.Drawing.Color.Red
        Me.lblZip.Location = New System.Drawing.Point(639, 317)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(70, 18)
        Me.lblZip.TabIndex = 36
        Me.lblZip.Text = "Ej.(xxxxx)"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.Red
        Me.lblPhone.Location = New System.Drawing.Point(639, 369)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(105, 18)
        Me.lblPhone.TabIndex = 37
        Me.lblPhone.Text = "Ej.(xxxxxxxxxx)"
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblTermination)
        Me.Controls.Add(Me.lblHire)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtTerminationDate)
        Me.Controls.Add(Me.txtHireDate)
        Me.Controls.Add(Me.lblTerminationDate)
        Me.Controls.Add(Me.lblHireDate)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.lblZipCode)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblAddressSection)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblEmployeeID)
        Me.Controls.Add(Me.lblEmployeeDataEntry)
        Me.Name = "frmEmployee"
        Me.Text = "Employee"
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmployeeDataEntry As Label
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAddressSection As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblState As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents lblZipCode As Label
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents txtTerminationDate As TextBox
    Friend WithEvents txtHireDate As TextBox
    Friend WithEvents lblTerminationDate As Label
    Friend WithEvents lblHireDate As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents ClientDataSet As ClientDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As ClientDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents lblHire As Label
    Friend WithEvents lblTermination As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblPhone As Label
End Class
