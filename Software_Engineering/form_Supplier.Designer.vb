<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Supplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_Supplier))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_NSEmail = New Software_Engineering.Watermark()
        Me.txt_NSContact = New Software_Engineering.Watermark()
        Me.txt_NSContactPerson = New Software_Engineering.Watermark()
        Me.txt_NSAddress = New Software_Engineering.Watermark()
        Me.txt_NSBname = New Software_Engineering.Watermark()
        Me.txt_NSSuppCode = New Software_Engineering.Watermark()
        Me.cmb_NSGender = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_NSDelete = New System.Windows.Forms.Button()
        Me.btn_NSUpdate = New System.Windows.Forms.Button()
        Me.btn_NSSave = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_NSNew = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_sid = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(294, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(695, 75)
        Me.Panel1.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(363, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(323, 46)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "NEW SUPPLIER"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bradley Hand ITC", 39.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(26, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(262, 66)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Kasadpan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(41, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(211, 24)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "General Merchandise"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_NSEmail)
        Me.GroupBox1.Controls.Add(Me.txt_NSContact)
        Me.GroupBox1.Controls.Add(Me.txt_NSContactPerson)
        Me.GroupBox1.Controls.Add(Me.txt_NSAddress)
        Me.GroupBox1.Controls.Add(Me.txt_NSBname)
        Me.GroupBox1.Controls.Add(Me.txt_NSSuppCode)
        Me.GroupBox1.Controls.Add(Me.cmb_NSGender)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 235)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier General Information"
        '
        'txt_NSEmail
        '
        Me.txt_NSEmail.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NSEmail.Location = New System.Drawing.Point(521, 123)
        Me.txt_NSEmail.Name = "txt_NSEmail"
        Me.txt_NSEmail.Size = New System.Drawing.Size(231, 31)
        Me.txt_NSEmail.TabIndex = 6
        Me.txt_NSEmail.WatermarkColor = System.Drawing.Color.Gray
        Me.txt_NSEmail.WatermarkText = "Enter Email Address"
        '
        'txt_NSContact
        '
        Me.txt_NSContact.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NSContact.Location = New System.Drawing.Point(521, 81)
        Me.txt_NSContact.Name = "txt_NSContact"
        Me.txt_NSContact.Size = New System.Drawing.Size(231, 31)
        Me.txt_NSContact.TabIndex = 5
        Me.txt_NSContact.WatermarkColor = System.Drawing.Color.Gray
        Me.txt_NSContact.WatermarkText = "Enter Contact Person"
        '
        'txt_NSContactPerson
        '
        Me.txt_NSContactPerson.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NSContactPerson.Location = New System.Drawing.Point(138, 185)
        Me.txt_NSContactPerson.Name = "txt_NSContactPerson"
        Me.txt_NSContactPerson.Size = New System.Drawing.Size(231, 31)
        Me.txt_NSContactPerson.TabIndex = 3
        Me.txt_NSContactPerson.WatermarkColor = System.Drawing.Color.Gray
        Me.txt_NSContactPerson.WatermarkText = "Enter Contact Person"
        '
        'txt_NSAddress
        '
        Me.txt_NSAddress.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NSAddress.Location = New System.Drawing.Point(136, 136)
        Me.txt_NSAddress.Name = "txt_NSAddress"
        Me.txt_NSAddress.Size = New System.Drawing.Size(231, 31)
        Me.txt_NSAddress.TabIndex = 2
        Me.txt_NSAddress.WatermarkColor = System.Drawing.Color.Gray
        Me.txt_NSAddress.WatermarkText = "Enter Complete Address"
        '
        'txt_NSBname
        '
        Me.txt_NSBname.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NSBname.Location = New System.Drawing.Point(136, 92)
        Me.txt_NSBname.Name = "txt_NSBname"
        Me.txt_NSBname.Size = New System.Drawing.Size(231, 31)
        Me.txt_NSBname.TabIndex = 1
        Me.txt_NSBname.WatermarkColor = System.Drawing.Color.Gray
        Me.txt_NSBname.WatermarkText = "Enter Bussiness Name"
        '
        'txt_NSSuppCode
        '
        Me.txt_NSSuppCode.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NSSuppCode.Location = New System.Drawing.Point(136, 46)
        Me.txt_NSSuppCode.Name = "txt_NSSuppCode"
        Me.txt_NSSuppCode.Size = New System.Drawing.Size(231, 31)
        Me.txt_NSSuppCode.TabIndex = 0
        Me.txt_NSSuppCode.WatermarkColor = System.Drawing.Color.Gray
        Me.txt_NSSuppCode.WatermarkText = "Enter Supplier Code"
        '
        'cmb_NSGender
        '
        Me.cmb_NSGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_NSGender.FormattingEnabled = True
        Me.cmb_NSGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmb_NSGender.Location = New System.Drawing.Point(523, 46)
        Me.cmb_NSGender.Name = "cmb_NSGender"
        Me.cmb_NSGender.Size = New System.Drawing.Size(229, 29)
        Me.cmb_NSGender.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(467, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contact No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(452, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contact Person"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bussiness Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supplier Code"
        '
        'btn_NSDelete
        '
        Me.btn_NSDelete.BackColor = System.Drawing.Color.Yellow
        Me.btn_NSDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NSDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NSDelete.Image = CType(resources.GetObject("btn_NSDelete.Image"), System.Drawing.Image)
        Me.btn_NSDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NSDelete.Location = New System.Drawing.Point(20, 144)
        Me.btn_NSDelete.Name = "btn_NSDelete"
        Me.btn_NSDelete.Size = New System.Drawing.Size(142, 35)
        Me.btn_NSDelete.TabIndex = 66
        Me.btn_NSDelete.Text = "Delete"
        Me.btn_NSDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_NSDelete.UseVisualStyleBackColor = False
        '
        'btn_NSUpdate
        '
        Me.btn_NSUpdate.BackColor = System.Drawing.Color.Yellow
        Me.btn_NSUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NSUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NSUpdate.Image = CType(resources.GetObject("btn_NSUpdate.Image"), System.Drawing.Image)
        Me.btn_NSUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NSUpdate.Location = New System.Drawing.Point(20, 103)
        Me.btn_NSUpdate.Name = "btn_NSUpdate"
        Me.btn_NSUpdate.Size = New System.Drawing.Size(142, 35)
        Me.btn_NSUpdate.TabIndex = 65
        Me.btn_NSUpdate.Text = "Update"
        Me.btn_NSUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_NSUpdate.UseVisualStyleBackColor = False
        '
        'btn_NSSave
        '
        Me.btn_NSSave.BackColor = System.Drawing.Color.Yellow
        Me.btn_NSSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NSSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NSSave.Image = CType(resources.GetObject("btn_NSSave.Image"), System.Drawing.Image)
        Me.btn_NSSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NSSave.Location = New System.Drawing.Point(20, 62)
        Me.btn_NSSave.Name = "btn_NSSave"
        Me.btn_NSSave.Size = New System.Drawing.Size(142, 35)
        Me.btn_NSSave.TabIndex = 64
        Me.btn_NSSave.Text = "Save"
        Me.btn_NSSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_NSSave.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btn_NSNew)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.btn_NSSave)
        Me.Panel3.Controls.Add(Me.btn_NSDelete)
        Me.Panel3.Controls.Add(Me.btn_NSUpdate)
        Me.Panel3.Location = New System.Drawing.Point(793, 110)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(185, 226)
        Me.Panel3.TabIndex = 68
        '
        'btn_NSNew
        '
        Me.btn_NSNew.BackColor = System.Drawing.Color.Yellow
        Me.btn_NSNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_NSNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NSNew.Image = CType(resources.GetObject("btn_NSNew.Image"), System.Drawing.Image)
        Me.btn_NSNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NSNew.Location = New System.Drawing.Point(20, 21)
        Me.btn_NSNew.Name = "btn_NSNew"
        Me.btn_NSNew.Size = New System.Drawing.Size(142, 35)
        Me.btn_NSNew.TabIndex = 69
        Me.btn_NSNew.Text = "New"
        Me.btn_NSNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_NSNew.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Yellow
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(20, 186)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 35)
        Me.Button5.TabIndex = 67
        Me.Button5.Text = "Home"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(12, 341)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(964, 140)
        Me.DataGridView1.TabIndex = 69
        '
        'Column1
        '
        Me.Column1.HeaderText = "Supplier ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Supplier Code"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Bussiness Name"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Address"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Contact Person"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Gender"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Contact No"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Email"
        Me.Column8.Name = "Column8"
        '
        'lbl_sid
        '
        Me.lbl_sid.AutoSize = True
        Me.lbl_sid.Location = New System.Drawing.Point(939, 94)
        Me.lbl_sid.Name = "lbl_sid"
        Me.lbl_sid.Size = New System.Drawing.Size(39, 13)
        Me.lbl_sid.TabIndex = 70
        Me.lbl_sid.Text = "Label9"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'form_Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(987, 482)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_sid)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_Supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales and Inventory V 1.0"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_NSGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_NSDelete As System.Windows.Forms.Button
    Friend WithEvents btn_NSUpdate As System.Windows.Forms.Button
    Friend WithEvents btn_NSSave As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txt_NSSuppCode As Software_Engineering.Watermark
    Friend WithEvents txt_NSEmail As Software_Engineering.Watermark
    Friend WithEvents txt_NSContact As Software_Engineering.Watermark
    Friend WithEvents txt_NSContactPerson As Software_Engineering.Watermark
    Friend WithEvents txt_NSAddress As Software_Engineering.Watermark
    Friend WithEvents txt_NSBname As Software_Engineering.Watermark
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_NSNew As System.Windows.Forms.Button
    Friend WithEvents lbl_sid As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
