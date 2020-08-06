<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_POS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_POS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_POSSearch = New Software_Engineering.Watermark()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmb_POSSort = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_POSCustomerCNo = New Software_Engineering.Watermark()
        Me.txt_POSCustomerName = New Software_Engineering.Watermark()
        Me.txt_POSCustomerAddress = New Software_Engineering.Watermark()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_POSTime = New System.Windows.Forms.Label()
        Me.lbl_POSDate = New System.Windows.Forms.Label()
        Me.lbl_POSUser = New System.Windows.Forms.Label()
        Me.lbl_POSUserType = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_POSTotal = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lbl_POSVat = New System.Windows.Forms.Label()
        Me.lbl_POSChange = New System.Windows.Forms.Label()
        Me.txt_POSTendered = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dgv_POSProList = New System.Windows.Forms.DataGridView()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgv_POSRecieveList = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_Oid = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgv_POSProList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_POSRecieveList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(311, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1044, 84)
        Me.Panel1.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(582, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(423, 61)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "POINT OF SALE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(37, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(211, 24)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "General Merchandise"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bradley Hand ITC", 39.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(13, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(262, 66)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Kasadpan"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txt_POSSearch)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.cmb_POSSort)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(12, 114)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(575, 96)
        Me.Panel2.TabIndex = 62
        '
        'txt_POSSearch
        '
        Me.txt_POSSearch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POSSearch.Location = New System.Drawing.Point(85, 43)
        Me.txt_POSSearch.Name = "txt_POSSearch"
        Me.txt_POSSearch.Size = New System.Drawing.Size(248, 31)
        Me.txt_POSSearch.TabIndex = 104
        Me.txt_POSSearch.WatermarkColor = System.Drawing.Color.Gray
        Me.txt_POSSearch.WatermarkText = "Search Product"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(39, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 29)
        Me.PictureBox1.TabIndex = 103
        Me.PictureBox1.TabStop = False
        '
        'cmb_POSSort
        '
        Me.cmb_POSSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_POSSort.FormattingEnabled = True
        Me.cmb_POSSort.Items.AddRange(New Object() {"", "Name", "Brand"})
        Me.cmb_POSSort.Location = New System.Drawing.Point(427, 48)
        Me.cmb_POSSort.Name = "cmb_POSSort"
        Me.cmb_POSSort.Size = New System.Drawing.Size(134, 28)
        Me.cmb_POSSort.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(449, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Sort By"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(590, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 66)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 24)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Product List"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(667, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 24)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Product Order"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_POSCustomerCNo)
        Me.GroupBox1.Controls.Add(Me.txt_POSCustomerName)
        Me.GroupBox1.Controls.Add(Me.txt_POSCustomerAddress)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(671, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 102)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'txt_POSCustomerCNo
        '
        Me.txt_POSCustomerCNo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POSCustomerCNo.Location = New System.Drawing.Point(442, 19)
        Me.txt_POSCustomerCNo.Name = "txt_POSCustomerCNo"
        Me.txt_POSCustomerCNo.Size = New System.Drawing.Size(218, 31)
        Me.txt_POSCustomerCNo.TabIndex = 108
        Me.txt_POSCustomerCNo.WatermarkColor = System.Drawing.Color.Gray
        Me.txt_POSCustomerCNo.WatermarkText = "Enter Contact #"
        '
        'txt_POSCustomerName
        '
        Me.txt_POSCustomerName.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POSCustomerName.Location = New System.Drawing.Point(108, 19)
        Me.txt_POSCustomerName.Name = "txt_POSCustomerName"
        Me.txt_POSCustomerName.Size = New System.Drawing.Size(218, 31)
        Me.txt_POSCustomerName.TabIndex = 107
        Me.txt_POSCustomerName.WatermarkColor = System.Drawing.Color.Gray
        Me.txt_POSCustomerName.WatermarkText = "Enter Customer Name"
        '
        'txt_POSCustomerAddress
        '
        Me.txt_POSCustomerAddress.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POSCustomerAddress.Location = New System.Drawing.Point(108, 56)
        Me.txt_POSCustomerAddress.Name = "txt_POSCustomerAddress"
        Me.txt_POSCustomerAddress.Size = New System.Drawing.Size(552, 31)
        Me.txt_POSCustomerAddress.TabIndex = 106
        Me.txt_POSCustomerAddress.WatermarkColor = System.Drawing.Color.Gray
        Me.txt_POSCustomerAddress.WatermarkText = "Enter Customer's Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(347, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 20)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Contact No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Full Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Address"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1262, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 57)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Yellow
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1262, 341)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 57)
        Me.Button3.TabIndex = 70
        Me.Button3.Text = "Clear Items"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Yellow
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1262, 451)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 57)
        Me.Button4.TabIndex = 71
        Me.Button4.Text = "Change Quantity"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Yellow
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.Location = New System.Drawing.Point(1262, 545)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(86, 57)
        Me.Button6.TabIndex = 73
        Me.Button6.Text = "Home"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lbl_POSTime)
        Me.Panel3.Controls.Add(Me.lbl_POSDate)
        Me.Panel3.Controls.Add(Me.lbl_POSUser)
        Me.Panel3.Controls.Add(Me.lbl_POSUserType)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Location = New System.Drawing.Point(12, 642)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(575, 83)
        Me.Panel3.TabIndex = 74
        '
        'lbl_POSTime
        '
        Me.lbl_POSTime.AutoSize = True
        Me.lbl_POSTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_POSTime.Location = New System.Drawing.Point(449, 46)
        Me.lbl_POSTime.Name = "lbl_POSTime"
        Me.lbl_POSTime.Size = New System.Drawing.Size(66, 24)
        Me.lbl_POSTime.TabIndex = 74
        Me.lbl_POSTime.Text = "Label2"
        '
        'lbl_POSDate
        '
        Me.lbl_POSDate.AutoSize = True
        Me.lbl_POSDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_POSDate.Location = New System.Drawing.Point(67, 46)
        Me.lbl_POSDate.Name = "lbl_POSDate"
        Me.lbl_POSDate.Size = New System.Drawing.Size(66, 24)
        Me.lbl_POSDate.TabIndex = 73
        Me.lbl_POSDate.Text = "Label2"
        '
        'lbl_POSUser
        '
        Me.lbl_POSUser.AutoSize = True
        Me.lbl_POSUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_POSUser.Location = New System.Drawing.Point(66, 9)
        Me.lbl_POSUser.Name = "lbl_POSUser"
        Me.lbl_POSUser.Size = New System.Drawing.Size(117, 20)
        Me.lbl_POSUser.TabIndex = 68
        Me.lbl_POSUser.Text = "Atchup_Mendz"
        '
        'lbl_POSUserType
        '
        Me.lbl_POSUserType.AutoSize = True
        Me.lbl_POSUserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_POSUserType.Location = New System.Drawing.Point(449, 9)
        Me.lbl_POSUserType.Name = "lbl_POSUserType"
        Me.lbl_POSUserType.Size = New System.Drawing.Size(54, 20)
        Me.lbl_POSUserType.TabIndex = 67
        Me.lbl_POSUserType.Text = "Admin"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(377, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 20)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "Time:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(8, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 20)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Date:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(334, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 20)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "User Type:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 20)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "User:"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lbl_POSTotal)
        Me.Panel5.Controls.Add(Me.Label25)
        Me.Panel5.Controls.Add(Me.Button5)
        Me.Panel5.Controls.Add(Me.lbl_POSVat)
        Me.Panel5.Controls.Add(Me.lbl_POSChange)
        Me.Panel5.Controls.Add(Me.txt_POSTendered)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Controls.Add(Me.Label23)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Location = New System.Drawing.Point(668, 642)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(680, 83)
        Me.Panel5.TabIndex = 76
        '
        'lbl_POSTotal
        '
        Me.lbl_POSTotal.AutoSize = True
        Me.lbl_POSTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_POSTotal.Location = New System.Drawing.Point(121, 9)
        Me.lbl_POSTotal.Name = "lbl_POSTotal"
        Me.lbl_POSTotal.Size = New System.Drawing.Size(45, 24)
        Me.lbl_POSTotal.TabIndex = 75
        Me.lbl_POSTotal.Text = "0.00"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(593, 63)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 16)
        Me.Label25.TabIndex = 70
        Me.Label25.Text = "PRINT"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.Location = New System.Drawing.Point(574, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 57)
        Me.Button5.TabIndex = 69
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lbl_POSVat
        '
        Me.lbl_POSVat.AutoSize = True
        Me.lbl_POSVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_POSVat.Location = New System.Drawing.Point(121, 46)
        Me.lbl_POSVat.Name = "lbl_POSVat"
        Me.lbl_POSVat.Size = New System.Drawing.Size(40, 20)
        Me.lbl_POSVat.TabIndex = 68
        Me.lbl_POSVat.Text = "0.00"
        '
        'lbl_POSChange
        '
        Me.lbl_POSChange.AutoSize = True
        Me.lbl_POSChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_POSChange.Location = New System.Drawing.Point(456, 52)
        Me.lbl_POSChange.Name = "lbl_POSChange"
        Me.lbl_POSChange.Size = New System.Drawing.Size(40, 20)
        Me.lbl_POSChange.TabIndex = 67
        Me.lbl_POSChange.Text = "0.00"
        '
        'txt_POSTendered
        '
        Me.txt_POSTendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POSTendered.Location = New System.Drawing.Point(410, 9)
        Me.txt_POSTendered.Name = "txt_POSTendered"
        Me.txt_POSTendered.Size = New System.Drawing.Size(123, 26)
        Me.txt_POSTendered.TabIndex = 66
        Me.txt_POSTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(303, 52)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 20)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "CHANGE:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(16, 46)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(37, 20)
        Me.Label22.TabIndex = 63
        Me.Label22.Text = "Vat"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(302, 12)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(90, 20)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "Tendered:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(8, 9)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 20)
        Me.Label24.TabIndex = 61
        Me.Label24.Text = "Total:"
        '
        'dgv_POSProList
        '
        Me.dgv_POSProList.AllowUserToAddRows = False
        Me.dgv_POSProList.AllowUserToDeleteRows = False
        Me.dgv_POSProList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_POSProList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_POSProList.BackgroundColor = System.Drawing.Color.White
        Me.dgv_POSProList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_POSProList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_POSProList.ColumnHeadersHeight = 35
        Me.dgv_POSProList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_POSProList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column15, Me.Column11, Me.Column3, Me.Column12, Me.Column1})
        Me.dgv_POSProList.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_POSProList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_POSProList.EnableHeadersVisualStyles = False
        Me.dgv_POSProList.GridColor = System.Drawing.Color.White
        Me.dgv_POSProList.Location = New System.Drawing.Point(15, 250)
        Me.dgv_POSProList.Name = "dgv_POSProList"
        Me.dgv_POSProList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_POSProList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_POSProList.RowHeadersVisible = False
        Me.dgv_POSProList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_POSProList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_POSProList.Size = New System.Drawing.Size(572, 352)
        Me.dgv_POSProList.TabIndex = 104
        '
        'Column15
        '
        Me.Column15.HeaderText = "uid"
        Me.Column15.Name = "Column15"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Product Name"
        Me.Column11.Name = "Column11"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Brand"
        Me.Column3.Name = "Column3"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Price"
        Me.Column12.Name = "Column12"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Available"
        Me.Column1.Name = "Column1"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Salmon
        Me.Panel4.Location = New System.Drawing.Point(-1, 617)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1349, 19)
        Me.Panel4.TabIndex = 75
        '
        'dgv_POSRecieveList
        '
        Me.dgv_POSRecieveList.AllowUserToAddRows = False
        Me.dgv_POSRecieveList.AllowUserToDeleteRows = False
        Me.dgv_POSRecieveList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_POSRecieveList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_POSRecieveList.BackgroundColor = System.Drawing.Color.White
        Me.dgv_POSRecieveList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_POSRecieveList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_POSRecieveList.ColumnHeadersHeight = 35
        Me.dgv_POSRecieveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_POSRecieveList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.Column4, Me.Column5})
        Me.dgv_POSRecieveList.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Salmon
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_POSRecieveList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_POSRecieveList.EnableHeadersVisualStyles = False
        Me.dgv_POSRecieveList.GridColor = System.Drawing.Color.White
        Me.dgv_POSRecieveList.Location = New System.Drawing.Point(671, 250)
        Me.dgv_POSRecieveList.Name = "dgv_POSRecieveList"
        Me.dgv_POSRecieveList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_POSRecieveList.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_POSRecieveList.RowHeadersVisible = False
        Me.dgv_POSRecieveList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_POSRecieveList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_POSRecieveList.Size = New System.Drawing.Size(585, 352)
        Me.dgv_POSRecieveList.TabIndex = 105
        '
        'Column2
        '
        Me.Column2.HeaderText = "Uid"
        Me.Column2.Name = "Column2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sub Total"
        Me.Column5.Name = "Column5"
        '
        'Timer1
        '
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(548, 234)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(39, 13)
        Me.lbl_id.TabIndex = 106
        Me.lbl_id.Text = "Label1"
        '
        'lbl_Oid
        '
        Me.lbl_Oid.AutoSize = True
        Me.lbl_Oid.Location = New System.Drawing.Point(865, 231)
        Me.lbl_Oid.Name = "lbl_Oid"
        Me.lbl_Oid.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Oid.TabIndex = 107
        Me.lbl_Oid.Text = "Label1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'form_POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1349, 728)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_Oid)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.dgv_POSRecieveList)
        Me.Controls.Add(Me.dgv_POSProList)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_POS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales and Inventory V 1.0"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgv_POSProList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_POSRecieveList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmb_POSSort As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_POSUserType As System.Windows.Forms.Label
    Friend WithEvents lbl_POSUser As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents lbl_POSVat As System.Windows.Forms.Label
    Friend WithEvents lbl_POSChange As System.Windows.Forms.Label
    Friend WithEvents txt_POSTendered As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents dgv_POSProList As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgv_POSRecieveList As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_POSTime As System.Windows.Forms.Label
    Friend WithEvents lbl_POSDate As System.Windows.Forms.Label
    Friend WithEvents lbl_POSTotal As System.Windows.Forms.Label
    Friend WithEvents txt_POSSearch As Software_Engineering.Watermark
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_POSCustomerCNo As Software_Engineering.Watermark
    Friend WithEvents txt_POSCustomerName As Software_Engineering.Watermark
    Friend WithEvents txt_POSCustomerAddress As Software_Engineering.Watermark
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents lbl_Oid As System.Windows.Forms.Label
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
