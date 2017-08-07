<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel1 As System.Windows.Forms.Label
        Dim First_NameLabel1 As System.Windows.Forms.Label
        Dim Last_NameLabel1 As System.Windows.Forms.Label
        Dim Phone_NumberLabel1 As System.Windows.Forms.Label
        Dim AddressLabel1 As System.Windows.Forms.Label
        Dim CityLabel1 As System.Windows.Forms.Label
        Dim StateLabel1 As System.Windows.Forms.Label
        Dim Zip_CodeLabel1 As System.Windows.Forms.Label
        Dim EmailLabel1 As System.Windows.Forms.Label
        Dim Num_Of_VisitsLabel1 As System.Windows.Forms.Label
        Dim Amount_SpentLabel1 As System.Windows.Forms.Label
        Dim Loyalty_StageLabel1 As System.Windows.Forms.Label
        Dim Loyalty_DiscountLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDatabaseDataSet = New Vignero_Customer_Database.CustomerDatabaseDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.MaskedTextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.ComboBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNumOfVisits = New System.Windows.Forms.TextBox()
        Me.txtLoyaltyDiscount = New System.Windows.Forms.TextBox()
        Me.txtLoyaltyStage = New System.Windows.Forms.TextBox()
        Me.txtAmountSpent = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.labelLoyalty = New System.Windows.Forms.Label()
        Me.labelError = New System.Windows.Forms.Label()
        Me.btnSendEmail = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CustomersDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersTableAdapter = New Vignero_Customer_Database.CustomerDatabaseDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New Vignero_Customer_Database.CustomerDatabaseDataSetTableAdapters.TableAdapterManager()
        IdLabel1 = New System.Windows.Forms.Label()
        First_NameLabel1 = New System.Windows.Forms.Label()
        Last_NameLabel1 = New System.Windows.Forms.Label()
        Phone_NumberLabel1 = New System.Windows.Forms.Label()
        AddressLabel1 = New System.Windows.Forms.Label()
        CityLabel1 = New System.Windows.Forms.Label()
        StateLabel1 = New System.Windows.Forms.Label()
        Zip_CodeLabel1 = New System.Windows.Forms.Label()
        EmailLabel1 = New System.Windows.Forms.Label()
        Num_Of_VisitsLabel1 = New System.Windows.Forms.Label()
        Amount_SpentLabel1 = New System.Windows.Forms.Label()
        Loyalty_StageLabel1 = New System.Windows.Forms.Label()
        Loyalty_DiscountLabel1 = New System.Windows.Forms.Label()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersBindingNavigator.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CustomersDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel1
        '
        IdLabel1.AutoSize = True
        IdLabel1.Location = New System.Drawing.Point(20, 34)
        IdLabel1.Name = "IdLabel1"
        IdLabel1.Size = New System.Drawing.Size(19, 13)
        IdLabel1.TabIndex = 0
        IdLabel1.Text = "Id:"
        '
        'First_NameLabel1
        '
        First_NameLabel1.AutoSize = True
        First_NameLabel1.Location = New System.Drawing.Point(20, 60)
        First_NameLabel1.Name = "First_NameLabel1"
        First_NameLabel1.Size = New System.Drawing.Size(60, 13)
        First_NameLabel1.TabIndex = 2
        First_NameLabel1.Text = "First Name:"
        '
        'Last_NameLabel1
        '
        Last_NameLabel1.AutoSize = True
        Last_NameLabel1.Location = New System.Drawing.Point(20, 86)
        Last_NameLabel1.Name = "Last_NameLabel1"
        Last_NameLabel1.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel1.TabIndex = 4
        Last_NameLabel1.Text = "Last Name:"
        '
        'Phone_NumberLabel1
        '
        Phone_NumberLabel1.AutoSize = True
        Phone_NumberLabel1.Location = New System.Drawing.Point(20, 112)
        Phone_NumberLabel1.Name = "Phone_NumberLabel1"
        Phone_NumberLabel1.Size = New System.Drawing.Size(81, 13)
        Phone_NumberLabel1.TabIndex = 6
        Phone_NumberLabel1.Text = "Phone Number:"
        '
        'AddressLabel1
        '
        AddressLabel1.AutoSize = True
        AddressLabel1.Location = New System.Drawing.Point(20, 138)
        AddressLabel1.Name = "AddressLabel1"
        AddressLabel1.Size = New System.Drawing.Size(48, 13)
        AddressLabel1.TabIndex = 8
        AddressLabel1.Text = "Address:"
        '
        'CityLabel1
        '
        CityLabel1.AutoSize = True
        CityLabel1.Location = New System.Drawing.Point(20, 164)
        CityLabel1.Name = "CityLabel1"
        CityLabel1.Size = New System.Drawing.Size(27, 13)
        CityLabel1.TabIndex = 10
        CityLabel1.Text = "City:"
        '
        'StateLabel1
        '
        StateLabel1.AutoSize = True
        StateLabel1.Location = New System.Drawing.Point(20, 190)
        StateLabel1.Name = "StateLabel1"
        StateLabel1.Size = New System.Drawing.Size(35, 13)
        StateLabel1.TabIndex = 12
        StateLabel1.Text = "State:"
        '
        'Zip_CodeLabel1
        '
        Zip_CodeLabel1.AutoSize = True
        Zip_CodeLabel1.Location = New System.Drawing.Point(20, 217)
        Zip_CodeLabel1.Name = "Zip_CodeLabel1"
        Zip_CodeLabel1.Size = New System.Drawing.Size(53, 13)
        Zip_CodeLabel1.TabIndex = 14
        Zip_CodeLabel1.Text = "Zip Code:"
        '
        'EmailLabel1
        '
        EmailLabel1.AutoSize = True
        EmailLabel1.Location = New System.Drawing.Point(20, 243)
        EmailLabel1.Name = "EmailLabel1"
        EmailLabel1.Size = New System.Drawing.Size(35, 13)
        EmailLabel1.TabIndex = 16
        EmailLabel1.Text = "Email:"
        '
        'Num_Of_VisitsLabel1
        '
        Num_Of_VisitsLabel1.AutoSize = True
        Num_Of_VisitsLabel1.Location = New System.Drawing.Point(20, 22)
        Num_Of_VisitsLabel1.Name = "Num_Of_VisitsLabel1"
        Num_Of_VisitsLabel1.Size = New System.Drawing.Size(73, 13)
        Num_Of_VisitsLabel1.TabIndex = 18
        Num_Of_VisitsLabel1.Text = "Num Of Visits:"
        '
        'Amount_SpentLabel1
        '
        Amount_SpentLabel1.AutoSize = True
        Amount_SpentLabel1.Location = New System.Drawing.Point(20, 48)
        Amount_SpentLabel1.Name = "Amount_SpentLabel1"
        Amount_SpentLabel1.Size = New System.Drawing.Size(77, 13)
        Amount_SpentLabel1.TabIndex = 20
        Amount_SpentLabel1.Text = "Amount Spent:"
        '
        'Loyalty_StageLabel1
        '
        Loyalty_StageLabel1.AutoSize = True
        Loyalty_StageLabel1.Location = New System.Drawing.Point(20, 74)
        Loyalty_StageLabel1.Name = "Loyalty_StageLabel1"
        Loyalty_StageLabel1.Size = New System.Drawing.Size(74, 13)
        Loyalty_StageLabel1.TabIndex = 22
        Loyalty_StageLabel1.Text = "Loyalty Stage:"
        '
        'Loyalty_DiscountLabel1
        '
        Loyalty_DiscountLabel1.AutoSize = True
        Loyalty_DiscountLabel1.Location = New System.Drawing.Point(20, 100)
        Loyalty_DiscountLabel1.Name = "Loyalty_DiscountLabel1"
        Loyalty_DiscountLabel1.Size = New System.Drawing.Size(88, 13)
        Loyalty_DiscountLabel1.TabIndex = 24
        Loyalty_DiscountLabel1.Text = "Loyalty Discount:"
        '
        'CustomersBindingNavigator
        '
        Me.CustomersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
        Me.CustomersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomersBindingNavigator.DeleteItem = Nothing
        Me.CustomersBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem})
        Me.CustomersBindingNavigator.Location = New System.Drawing.Point(918, 4)
        Me.CustomersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
        Me.CustomersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomersBindingNavigator.Size = New System.Drawing.Size(232, 25)
        Me.CustomersBindingNavigator.TabIndex = 0
        Me.CustomersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.CustomerDatabaseDataSet
        '
        'CustomerDatabaseDataSet
        '
        Me.CustomerDatabaseDataSet.DataSetName = "CustomerDatabaseDataSet"
        Me.CustomerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdLabel1)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(EmailLabel1)
        Me.GroupBox1.Controls.Add(First_NameLabel1)
        Me.GroupBox1.Controls.Add(Me.txtZipCode)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Zip_CodeLabel1)
        Me.GroupBox1.Controls.Add(Last_NameLabel1)
        Me.GroupBox1.Controls.Add(Me.txtState)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(StateLabel1)
        Me.GroupBox1.Controls.Add(Phone_NumberLabel1)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(CityLabel1)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(AddressLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 277)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'txtId
        '
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Id", True))
        Me.txtId.Location = New System.Drawing.Point(114, 31)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(121, 20)
        Me.txtId.TabIndex = 0
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Email", True))
        Me.txtEmail.Location = New System.Drawing.Point(114, 240)
        Me.txtEmail.MaxLength = 30
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(121, 20)
        Me.txtEmail.TabIndex = 8
        '
        'txtZipCode
        '
        Me.txtZipCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Zip_Code", True))
        Me.txtZipCode.Location = New System.Drawing.Point(114, 214)
        Me.txtZipCode.Mask = "00000"
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.PromptChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txtZipCode.Size = New System.Drawing.Size(121, 20)
        Me.txtZipCode.TabIndex = 7
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "First_Name", True))
        Me.txtFirstName.Location = New System.Drawing.Point(114, 57)
        Me.txtFirstName.MaxLength = 15
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(121, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'txtState
        '
        Me.txtState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "State", True))
        Me.txtState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtState.FormattingEnabled = True
        Me.txtState.Items.AddRange(New Object() {"N/A", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.txtState.Location = New System.Drawing.Point(114, 187)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(121, 21)
        Me.txtState.TabIndex = 6
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Last_Name", True))
        Me.txtLastName.Location = New System.Drawing.Point(114, 83)
        Me.txtLastName.MaxLength = 15
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(121, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "City", True))
        Me.txtCity.Location = New System.Drawing.Point(114, 161)
        Me.txtCity.MaxLength = 20
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(121, 20)
        Me.txtCity.TabIndex = 5
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Phone_Number", True))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(114, 109)
        Me.txtPhoneNumber.Mask = "(999) 000-0000"
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtPhoneNumber.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.txtAddress.Location = New System.Drawing.Point(114, 135)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(121, 20)
        Me.txtAddress.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNumOfVisits)
        Me.GroupBox2.Controls.Add(Me.txtLoyaltyDiscount)
        Me.GroupBox2.Controls.Add(Loyalty_DiscountLabel1)
        Me.GroupBox2.Controls.Add(Me.txtLoyaltyStage)
        Me.GroupBox2.Controls.Add(Loyalty_StageLabel1)
        Me.GroupBox2.Controls.Add(Me.txtAmountSpent)
        Me.GroupBox2.Controls.Add(Amount_SpentLabel1)
        Me.GroupBox2.Controls.Add(Num_Of_VisitsLabel1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 333)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 136)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Loyalty Details"
        '
        'txtNumOfVisits
        '
        Me.txtNumOfVisits.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Num_Of_Visits", True))
        Me.txtNumOfVisits.Location = New System.Drawing.Point(114, 19)
        Me.txtNumOfVisits.MaxLength = 4
        Me.txtNumOfVisits.Name = "txtNumOfVisits"
        Me.txtNumOfVisits.Size = New System.Drawing.Size(121, 20)
        Me.txtNumOfVisits.TabIndex = 9
        '
        'txtLoyaltyDiscount
        '
        Me.txtLoyaltyDiscount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Loyalty_Discount", True))
        Me.txtLoyaltyDiscount.Location = New System.Drawing.Point(114, 97)
        Me.txtLoyaltyDiscount.MaxLength = 3
        Me.txtLoyaltyDiscount.Name = "txtLoyaltyDiscount"
        Me.txtLoyaltyDiscount.ReadOnly = True
        Me.txtLoyaltyDiscount.Size = New System.Drawing.Size(121, 20)
        Me.txtLoyaltyDiscount.TabIndex = 12
        '
        'txtLoyaltyStage
        '
        Me.txtLoyaltyStage.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Loyalty_Stage", True))
        Me.txtLoyaltyStage.Location = New System.Drawing.Point(114, 71)
        Me.txtLoyaltyStage.MaxLength = 1
        Me.txtLoyaltyStage.Name = "txtLoyaltyStage"
        Me.txtLoyaltyStage.ReadOnly = True
        Me.txtLoyaltyStage.Size = New System.Drawing.Size(121, 20)
        Me.txtLoyaltyStage.TabIndex = 11
        '
        'txtAmountSpent
        '
        Me.txtAmountSpent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Amount_Spent", True))
        Me.txtAmountSpent.Location = New System.Drawing.Point(114, 45)
        Me.txtAmountSpent.MaxLength = 10
        Me.txtAmountSpent.Name = "txtAmountSpent"
        Me.txtAmountSpent.Size = New System.Drawing.Size(121, 20)
        Me.txtAmountSpent.TabIndex = 10
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(283, 109)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 23)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Add record to the database")
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(283, 138)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 23)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.ToolTip1.SetToolTip(Me.btnDelete, "Delete a record from the database")
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(283, 167)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(87, 23)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.ToolTip1.SetToolTip(Me.btnUpdate, "Update a record in the database")
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(283, 196)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 23)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clear text fields to add a new customer")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'labelLoyalty
        '
        Me.labelLoyalty.AutoSize = True
        Me.labelLoyalty.ForeColor = System.Drawing.Color.Green
        Me.labelLoyalty.Location = New System.Drawing.Point(12, 472)
        Me.labelLoyalty.Name = "labelLoyalty"
        Me.labelLoyalty.Size = New System.Drawing.Size(0, 13)
        Me.labelLoyalty.TabIndex = 34
        '
        'labelError
        '
        Me.labelError.AutoSize = True
        Me.labelError.ForeColor = System.Drawing.Color.Red
        Me.labelError.Location = New System.Drawing.Point(12, 16)
        Me.labelError.Name = "labelError"
        Me.labelError.Size = New System.Drawing.Size(0, 13)
        Me.labelError.TabIndex = 35
        '
        'btnSendEmail
        '
        Me.btnSendEmail.Location = New System.Drawing.Point(283, 356)
        Me.btnSendEmail.Name = "btnSendEmail"
        Me.btnSendEmail.Size = New System.Drawing.Size(87, 39)
        Me.btnSendEmail.TabIndex = 17
        Me.btnSendEmail.Text = "Send Email"
        Me.ToolTip1.SetToolTip(Me.btnSendEmail, "Send special offers to customer")
        Me.btnSendEmail.UseVisualStyleBackColor = True
        Me.btnSendEmail.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(371, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 25)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Customer Data"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(283, 398)
        Me.ProgressBar1.MarqueeAnimationSpeed = 1000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(88, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 38
        Me.ProgressBar1.Visible = False
        '
        'Timer1
        '
        '
        'CustomersDataGridView1
        '
        Me.CustomersDataGridView1.AutoGenerateColumns = False
        Me.CustomersDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomersDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.CustomersDataGridView1.DataSource = Me.CustomersBindingSource
        Me.CustomersDataGridView1.Location = New System.Drawing.Point(376, 45)
        Me.CustomersDataGridView1.Name = "CustomersDataGridView1"
        Me.CustomersDataGridView1.ShowCellErrors = False
        Me.CustomersDataGridView1.ShowRowErrors = False
        Me.CustomersDataGridView1.Size = New System.Drawing.Size(813, 478)
        Me.CustomersDataGridView1.TabIndex = 39
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Phone_Number"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Phone_Number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn6.HeaderText = "City"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "State"
        Me.DataGridViewTextBoxColumn7.HeaderText = "State"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Zip_Code"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Zip_Code"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Num_Of_Visits"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Num_Of_Visits"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Amount_Spent"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Amount_Spent"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Loyalty_Stage"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Loyalty_Stage"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Loyalty_Discount"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Loyalty_Discount"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Vignero_Customer_Database.CustomerDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 535)
        Me.Controls.Add(Me.CustomersDataGridView1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSendEmail)
        Me.Controls.Add(Me.labelError)
        Me.Controls.Add(Me.labelLoyalty)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CustomersBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Kudler Fine Foods Database"
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersBindingNavigator.ResumeLayout(False)
        Me.CustomersBindingNavigator.PerformLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CustomersDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerDatabaseDataSet As CustomerDatabaseDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As CustomerDatabaseDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As CustomerDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents labelLoyalty As Label
    Friend WithEvents labelError As Label
    Friend WithEvents btnSendEmail As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CustomersDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtPhoneNumber As MaskedTextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As ComboBox
    Friend WithEvents txtZipCode As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNumOfVisits As TextBox
    Friend WithEvents txtAmountSpent As TextBox
    Friend WithEvents txtLoyaltyStage As TextBox
    Friend WithEvents txtLoyaltyDiscount As TextBox
End Class
