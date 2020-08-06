Imports MySql.Data.MySqlClient

Public Class form_Stocks
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Dim prod_name As String = ""
    Dim prod_id As String = ""
    Dim prod_unit As String = ""

    Dim prod_name1 As String = ""
    Dim prod_id1 As String = ""
    Dim prod_unit1 As String = ""

    Dim ro_prod_id As String = ""
    Dim ro_quan As String = ""

    Dim d_prod_id As String = ""
    Dim d_quan As String = ""
    Dim ii As Integer
    Dim iii As Integer

#Region "Clear"
    Public Sub reset()
        cmb_SDSupCode.Text = Nothing
        txt_SDProID.Text = ""
        txt_SDProName.Text = ""
        txt_SDProDesciption.Text = ""
        txt_SDBrand.Text = ""
        cmb_SDIUnit.Text = Nothing
        txt_SDPrice.Text = ""
        txt_SDQuantity.Text = ""
        lbl_Iuid.Text = 0
    End Sub
#End Region

#Region "Display Data"
    Public Sub Getdata()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"
        Dim Reader As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim Query As String = "SELECT * FROM table_stockin ORDER BY Product_Name"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
            DataGridView1.Rows.Clear()
            While (Reader.Read() = True)
                DataGridView1.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4), Reader(5), Reader(6), Reader(7), Reader(8))

            End While

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

#End Region


#Region "Search"
    Public Sub Filter()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"
        Dim Reader As MySqlDataReader


        Try
            MysqlConn.Open()
            If txt_SDISearch.Text = "" Then
                Dim Query2 As String = "SELECT * FROM table_stockin ORDER BY Product_Name"
                Command = New MySqlCommand(Query2, MysqlConn)
                Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
                DataGridView1.Rows.Clear()
                While (Reader.Read() = True)
                    DataGridView1.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4), Reader(5), Reader(6), Reader(7))

                End While

            Else
                Dim Query3 As String = "SELECT * FROM table_stockin WHERE Product_Name LIKE '%" & txt_SDISearch.Text & "%' "
                Command = New MySqlCommand(Query3, MysqlConn)
                Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
                DataGridView1.Rows.Clear()
                While (Reader.Read() = True)
                    DataGridView1.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4), Reader(5), Reader(6), Reader(7))

                End While

            End If



            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
#End Region


#Region "Update table SO"
    Public Sub Update_So()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String = "SELECT UID, Product_Name, Price, Quantity FROM table_stockin ORDER BY Product_Name"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
            dgv_SOPRoList.Rows.Clear()
            While (Reader.Read() = True)
                dgv_SOPRoList.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3))

            End While

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
#End Region

#Region "fill"
    Public Sub comboFill()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()

            Dim Query As String = "SELECT Sup_Code FROM table_supplier ORDER BY Sup_Code"
            Dim adapt As New MySqlDataAdapter
            Dim ds As New DataSet("ds")
            Dim dtable As DataTable
            adapt = New MySqlDataAdapter(Query, MysqlConn)
            Command = New MySqlCommand(Query, MysqlConn)

            adapt.Fill(ds)
            dtable = ds.Tables(0)
            cmb_SDSupCode.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                cmb_SDSupCode.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region


    Private Sub form_Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Visible = False
        Panel5.Visible = False
        btn_SDAddPro.Enabled = False
        btn_SDNew.Enabled = True
        btn_SDEditPro.Enabled = True
        btn_SDDelPro.Enabled = True

       

        Getdata()

        comboFill()
       

        Update_So()

       

    End Sub



    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel3.Visible = True
        Panel5.Visible = False

        'pnl_so.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' pnl_so.Show()

        Panel3.Visible = False
        Panel5.Visible = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Me.Close()


    End Sub

    Private Sub btn_SDAddPro_Click(sender As Object, e As EventArgs) Handles btn_SDAddPro.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader

        If Len(Trim(cmb_SDSupCode.Text)) = 0 Then
            ErrorProvider1.SetError(cmb_SDSupCode, "Please Select Supplier Code")
            MessageBox.Show("Please Select Supplier Code", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmb_SDSupCode.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_SDProID.Text)) = 0 Then
            ErrorProvider1.SetError(txt_SDProID, "Please Enter Product ID")
            MessageBox.Show("Please Enter Product ID", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_SDProID.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_SDProName.Text)) = 0 Then
            ErrorProvider1.SetError(txt_SDProName, "Please Enter Product Name")
            MessageBox.Show("Please Enter Product Name", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_SDProName.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_SDProDesciption.Text)) = 0 Then
            ErrorProvider1.SetError(txt_SDProDesciption, "Please Enter Product Description")
            MessageBox.Show("Please Enter Product Description", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_SDProDesciption.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_SDBrand.Text)) = 0 Then
            ErrorProvider1.SetError(txt_SDBrand, "Please Enter Product Brand")
            MessageBox.Show("Please Enter Product Brand", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_SDBrand.Focus()
            Exit Sub
        End If

        If Len(Trim(cmb_SDIUnit.Text)) = 0 Then
            ErrorProvider1.SetError(cmb_SDIUnit, "Please Enter Product Unit")
            MessageBox.Show("Please Enter Product Unit", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmb_SDIUnit.Focus()
            Exit Sub
        End If


        If Len(Trim(txt_SDPrice.Text)) = 0 Then
            ErrorProvider1.SetError(txt_SDPrice, "Please Enter Product Price")
            MessageBox.Show("Please Enter Product Price", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_SDPrice.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_SDQuantity.Text)) = 0 Then
            ErrorProvider1.SetError(txt_SDQuantity, "Please Enter Product Quantity")
            MessageBox.Show("Please Enter Product Quantity", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_SDQuantity.Focus()
            Exit Sub
        End If






        Try
            MysqlConn.Open()
            Dim Query As String = "SELECT Product_ID FROM table_stockin WHERE Product_ID = @find"
            Command = New MySqlCommand(Query, MysqlConn)
            Command.Parameters.Add(New MySqlParameter("@find", MySql.Data.MySqlClient.MySqlDbType.VarChar, 100, "Product_ID"))
            Command.Parameters("@find").Value = txt_SDProID.Text
            Reader = Command.ExecuteReader

            If Reader.Read Then
                MessageBox.Show("Product ID Already Exist !", "Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_SDProID.Text = ""
                Return

            Else
                Try
                    Reader.Close()


                    Dim Query1 As String = "INSERT INTO table_stockin (Supplier_Code, Product_ID, Product_Name, Description, Brand, Unit, Price, Quantity) VALUES (@SC, @PID, @PN, @DES, @BR, @UN, @PR, @QUAN) "
                    Command = New MySqlCommand(Query1, MysqlConn)

                    Command.Parameters.AddWithValue("@SC", cmb_SDSupCode.Text)
                    Command.Parameters.AddWithValue("@PID", txt_SDProID.Text.ToUpper)
                    Command.Parameters.AddWithValue("@PN", txt_SDProName.Text)
                    Command.Parameters.AddWithValue("@DES", txt_SDProDesciption.Text)
                    Command.Parameters.AddWithValue("@BR", txt_SDBrand.Text)
                    Command.Parameters.AddWithValue("@UN", cmb_SDIUnit.Text)
                    Command.Parameters.AddWithValue("@PR", txt_SDPrice.Text)
                    Command.Parameters.AddWithValue("@QUAN", txt_SDQuantity.Text)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Successfully Saved !")
                    reset()


                    If Reader Is Nothing Then
                        Reader.Close()

                    End If


                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()

                End Try



            End If


            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Getdata()
    End Sub

    Private Sub btn_SDNew_Click(sender As Object, e As EventArgs) Handles btn_SDNew.Click
        reset()
        btn_SDAddPro.Enabled = True
        btn_SDNew.Enabled = True
        btn_SDEditPro.Enabled = True
        btn_SDDelPro.Enabled = True

    End Sub

    Private Sub btn_SDDelPro_Click(sender As Object, e As EventArgs) Handles btn_SDDelPro.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        ' Dim Reader As MySqlDataReader

        Try
            If MessageBox.Show("Do you really want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then


                MysqlConn.Open()
                Dim AffectedRow As Integer = 0
                Dim Query As String = "DELETE FROM table_stockin WHERE UID = @uid1"
                Command = New MySqlCommand(Query, MysqlConn)
                Command.Parameters.AddWithValue("@uid1", lbl_Iuid.Text)
                AffectedRow = Command.ExecuteNonQuery


                If AffectedRow > 0 Then
                    MessageBox.Show("Successfully Deleted !", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    reset()

                Else
                    MessageBox.Show("No found Record !", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    reset()


                End If


                MysqlConn.Close()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Getdata()

    End Sub

    Private Sub btn_SDEditPro_Click(sender As Object, e As EventArgs) Handles btn_SDEditPro.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader

        If Len(Trim(cmb_SDSupCode.Text)) = 0 Then
            ErrorProvider1.SetError(cmb_SDSupCode, "Please Select Supplier Code")
            MessageBox.Show("Please Select Supplier Code", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmb_SDSupCode.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_SDProID.Text)) = 0 Then
            ErrorProvider1.SetError(txt_SDProID, "Please Enter Product ID")
            MessageBox.Show("Please Enter Product ID", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_SDProID.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_SDProName.Text)) = 0 Then
            ErrorProvider1.SetError(txt_SDProName, "Please Enter Product Name")
            MessageBox.Show("Please Enter Product Name", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_SDProName.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_SDProDesciption.Text)) = 0 Then
            ErrorProvider1.SetError(txt_SDProDesciption, "Please Enter Product Description")
            MessageBox.Show("Please Enter Product Description", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_SDProDesciption.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_SDBrand.Text)) = 0 Then
            ErrorProvider1.SetError(txt_SDBrand, "Please Enter Product Brand")
            MessageBox.Show("Please Enter Product Brand", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_SDBrand.Focus()
            Exit Sub
        End If


        If Len(Trim(cmb_SDIUnit.Text)) = 0 Then
            ErrorProvider1.SetError(cmb_SDIUnit, "Please Enter Product Unit")
            MessageBox.Show("Please Enter Product Unit", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmb_SDIUnit.Focus()
            Exit Sub
        End If


        If Len(Trim(txt_SDPrice.Text)) = 0 Then
            ErrorProvider1.SetError(txt_SDPrice, "Please Enter Product Price")
            MessageBox.Show("Please Enter Product Price", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_SDPrice.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_SDQuantity.Text)) = 0 Then
            ErrorProvider1.SetError(txt_SDQuantity, "Please Enter Product Quantity")
            MessageBox.Show("Please Enter Product Quantity", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_SDQuantity.Focus()
            Exit Sub
        End If




        Try
            If MessageBox.Show("Are you sure you want to Update this record ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then




                Try
                    MysqlConn.Open()
                    Dim Query As String = "UPDATE table_stockin SET Supplier_Code=@SC, Product_ID=@PID, Product_Name=@PN, Description=@DES, Brand=@BR, Unit=@UN, Price=@PR, Quantity=@QUAN WHERE UID=@UID1 "
                    Command = New MySqlCommand(Query, MysqlConn)
                    Command.Parameters.AddWithValue("@UID1", lbl_Iuid.Text)
                    Command.Parameters.AddWithValue("@SC", cmb_SDSupCode.Text)
                    Command.Parameters.AddWithValue("@PID", txt_SDProID.Text)
                    Command.Parameters.AddWithValue("@PN", txt_SDProName.Text)
                    Command.Parameters.AddWithValue("@DES", txt_SDProDesciption.Text)
                    Command.Parameters.AddWithValue("@BR", txt_SDBrand.Text)
                    Command.Parameters.AddWithValue("@UN", cmb_SDIUnit.Text)
                    Command.Parameters.AddWithValue("@PR", txt_SDPrice.Text)
                    Command.Parameters.AddWithValue("@QUAN", txt_SDQuantity.Text)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Successfully Updated !")


                    If Reader Is Nothing Then

                        Reader.Close()

                    End If
                    reset()
                    Getdata()


                    MysqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Try
            If DataGridView1.Rows.Count Then
                Dim dgvRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                lbl_Iuid.Text = dgvRow.Cells(0).Value.ToString
                cmb_SDSupCode.Text = dgvRow.Cells(1).Value.ToString
                txt_SDProID.Text = dgvRow.Cells(2).Value.ToString
                txt_SDProName.Text = dgvRow.Cells(3).Value.ToString
                txt_SDProDesciption.Text = dgvRow.Cells(4).Value.ToString
                txt_SDBrand.Text = dgvRow.Cells(5).Value.ToString
                cmb_SDIUnit.Text = dgvRow.Cells(6).Value.ToString
                txt_SDPrice.Text = dgvRow.Cells(7).Value.ToString
                txt_SDQuantity.Text = dgvRow.Cells(8).Value.ToString


                btn_SDNew.Enabled = True
                btn_SDAddPro.Enabled = False
                btn_SDDelPro.Enabled = True
                btn_SDEditPro.Enabled = True


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub txt_SDISearch_TextChanged(sender As Object, e As EventArgs) Handles txt_SDISearch.TextChanged
        Filter()

    End Sub

    Private Sub Watermark1_TextChanged(sender As Object, e As EventArgs) Handles txt_SOSearch.TextChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"
        Dim Reader As MySqlDataReader


     Try
            MysqlConn.Open()
            If txt_SOSearch.Text = "" Then
                Dim Query2 As String = "SELECT Product_ID, Product_Name, Price, Quantity FROM table_stockin ORDER BY Product_Name"
                Command = New MySqlCommand(Query2, MysqlConn)
                Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
                dgv_SOPRoList.Rows.Clear()
                While (Reader.Read() = True)
                    dgv_SOPRoList.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3))

                End While

            Else
                Dim Query3 As String = "SELECT * FROM table_stockin WHERE Product_Name LIKE '%" & txt_SOSearch.Text & "%' "
                Command = New MySqlCommand(Query3, MysqlConn)
                Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
                dgv_SOPRoList.Rows.Clear()
                While (Reader.Read() = True)
                    dgv_SOPRoList.Rows.Add(Reader(2), Reader(3), Reader(6), Reader(7))

                End While

            End If



            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        form_DamageList.ShowDialog()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
      
        If prod_id1 = "" Then
            MsgBox("Please select data on product table")
        Else
            Try
                Dim quan As Integer = InputBox("Enter quantity of damage item")
                If quan = 0 Then
                    MsgBox("Zero value is not accepted")
                Else
                    Dim num As Integer = 0
                    For i As Integer = 0 To dgv_damageList.Rows.Count - 1
                        Dim id1 As String = dgv_damageList.Rows(i).Cells(0).Value.ToString
                        If prod_id1 = id1 Then
                            dgv_damageList.Rows(i).Cells(2).Value = quan
                            num = 1
                        End If
                    Next
                    If num = 0 Then
                        dgv_damageList.Rows.Add(prod_id1, prod_name1, quan, Now.Date)
                    End If

                End If
            Catch ex As Exception
                'MsgBox("Please input a number")
            End Try
            prod_id1 = ""
            ' load_product1()
        End If

    End Sub

    Private Sub dgv_SOPRoList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_SOPRoList.CellClick
        Try
            Dim i As Integer
            i = dgv_SOPRoList.CurrentRow.Index
            prod_id1 = dgv_SOPRoList.Rows(i).Cells(0).Value.ToString
            prod_name1 = dgv_SOPRoList.Rows(i).Cells(1).Value.ToString
            prod_unit1 = dgv_SOPRoList.Rows(i).Cells(3).Value.ToString

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If d_prod_id = "" Then
            MsgBox("Please select data on product table")
        Else
            dgv_damageList.Rows.RemoveAt(iii)
        End If
        'load_product1()
        d_prod_id = ""
    End Sub

    Private Sub dgv_damageList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_damageList.CellClick
        Try

            iii = dgv_damageList.CurrentRow.Index
            d_prod_id = dgv_damageList.Rows(iii).Cells(0).Value.ToString
            d_quan = dgv_damageList.Rows(iii).Cells(2).Value.ToString

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If d_prod_id = "" Then
            MsgBox("Please select data on ordered list table")
        Else
            Try
                Dim quan As Integer = InputBox("", "Enter new quantity of damage item", d_quan)
                If quan = 0 Then
                    MsgBox("Zero value is not accepted")
                Else
                    For j As Integer = 0 To dgv_damageList.Rows.Count - 1
                        Dim id As String = dgv_damageList.Rows(j).Cells(0).Value.ToString
                        If id = d_prod_id Then
                            dgv_damageList.Rows(j).Cells(2).Value = quan
                        End If
                    Next
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
            d_prod_id = ""
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")


        If dgv_damageList.Rows.Count = 0 Then
            MessageBox.Show("Sorry !, No Item list found")
        Else
            Try
                MysqlConn.Open()
                Dim Reader1 As MySqlDataReader
                For Each dr As DataGridViewRow In dgv_damageList.Rows
                    Dim DProduct_ID As String = dr.Cells(0).Value.ToString
                    Dim DProduct_Name As String = dr.Cells(1).Value.ToString
                    Dim Qty As String = dr.Cells(2).Value.ToString
                    Dim Query As String = "INSERT INTO table_stockout (DProduct_ID, DProduct_Name, DQuantity, DDate) VALUES (@Dpid, @Dpn, @Dq, @Dd)"
                    Command = New MySqlCommand(Query, MysqlConn)
                    Command.Parameters.AddWithValue("@Dpid", DProduct_ID)
                    Command.Parameters.AddWithValue("@Dpn", DProduct_Name)
                    Command.Parameters.AddWithValue("@Dq", Qty)
                    Command.Parameters.AddWithValue("@Dd", Now)
                    Reader1 = Command.ExecuteReader
                Next
                MysqlConn.Close()

             
                
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


            ''''Update

            Try
                MysqlConn.Open()
                Dim Reader2 As MySqlDataReader
                For Each dr As DataGridViewRow In dgv_damageList.Rows
                    Dim Pro_ID As String = dr.Cells(0).Value.ToString
                    Dim Qty As String = dr.Cells(2).Value.ToString
                    Dim Query1 As String = "UPDATE table_stockin SET Quantity = Quantity - " & CDec(Qty) & " WHERE UID = " & CInt(Pro_ID) & "  "
                    Command = New MySqlCommand(Query1, MysqlConn)
                    Reader2 = Command.ExecuteReader
                Next
                MessageBox.Show("Successfully Saved Damaged Item")
                Update_So()
                dgv_damageList.Rows.Clear()
                prod_id = ""
                MysqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try





        End If


    End Sub

    Private Sub Panel5_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub dgv_SOPRoList_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_SOPRoList.MouseClick

    End Sub
End Class