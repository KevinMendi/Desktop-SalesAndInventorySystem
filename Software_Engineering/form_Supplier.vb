
Imports MySql.Data.MySqlClient

Public Class form_Supplier
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

#Region "reset"
    Public Sub reset()
        txt_NSSuppCode.Text = ""
        txt_NSBname.Text = ""
        txt_NSAddress.Text = ""
        txt_NSContactPerson.Text = ""
        cmb_NSGender.Text = Nothing
        txt_NSContact.Text = ""
        txt_NSEmail.Text = ""
        ErrorProvider1.Clear()
    End Sub
#End Region

#Region "Display Table"
    Public Sub Getdata()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"
        Dim Reader As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim Query As String = "SELECT * FROM software_engineering_v1.table_supplier ORDER BY Sup_BName"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
            DataGridView1.Rows.Clear()
            While (Reader.Read() = True)
                DataGridView1.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4), Reader(5), Reader(6), Reader(7))

            End While

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

#End Region



    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_NSSave.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"
        Dim Reader As MySqlDataReader


        If Len(Trim(txt_NSSuppCode.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NSSuppCode, "Please Enter Supplier Code")
            MessageBox.Show("Please Enter Supplier Code", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NSSuppCode.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NSBname.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NSBname, "Please Enter Bussiness Name")
            MessageBox.Show("Please Enter Bussiness Name", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NSBname.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NSAddress.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NSAddress, "Please Enter Supplier Address")
            MessageBox.Show("Please Enter Supplier Address", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NSAddress.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NSContactPerson.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NSContactPerson, "Please Enter Contact Person")
            MessageBox.Show("Please Enter Contact Person", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NSContactPerson.Focus()
            Exit Sub
        End If

        If Len(Trim(cmb_NSGender.Text)) = 0 Then
            ErrorProvider1.SetError(cmb_NSGender, "Please Enter Gender")
            MessageBox.Show("Please Enter Gender", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmb_NSGender.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NSContact.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NSContact, "Please Enter Contact No")
            MessageBox.Show("Please Enter Contact No", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NSContact.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NSEmail.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NSEmail, "Please Enter Email Address")
            MessageBox.Show("Please Enter Email Address", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NSEmail.Focus()
            Exit Sub
        End If


        Try
            MysqlConn.Open()
            Dim Query1 As String = "SELECT Sup_Code FROM table_supplier WHERE Sup_Code = @find"
            Command = New MySqlCommand(Query1, MysqlConn)
            Command.Parameters.Add(New MySqlParameter("@find", MySql.Data.MySqlClient.MySqlDbType.VarChar, 100, "@find"))
            Command.Parameters("@find").Value = txt_NSSuppCode.Text
            Reader = Command.ExecuteReader

            If Reader.Read Then
                MessageBox.Show("Supplier Code Already Exist !", "Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_NSSuppCode.Text = ""

            Else
                Reader.Close()


                Dim Query As String = "INSERT INTO table_supplier (Sup_Code, Sup_BName, Sup_Address, Sup_CPerson, Sup_Gender, Sup_ContactNo, Sup_Email) VALUES (@sc, @sbn, @sa, @scp, @sg, @scn, @se) "
                Command = New MySqlCommand(Query, MysqlConn)

                Command.Parameters.AddWithValue("@sc", txt_NSSuppCode.Text.ToUpper)
                Command.Parameters.AddWithValue("@sbn", txt_NSBname.Text)
                Command.Parameters.AddWithValue("@sa", txt_NSAddress.Text)
                Command.Parameters.AddWithValue("@scp", txt_NSContactPerson.Text)
                Command.Parameters.AddWithValue("@sg", cmb_NSGender.Text)
                Command.Parameters.AddWithValue("@scn", txt_NSContact.Text)
                Command.Parameters.AddWithValue("@se", txt_NSEmail.Text)
                Reader = Command.ExecuteReader

                MessageBox.Show("Successfully Saved !")


                If Reader Is Nothing Then
                    Reader.Close()

                End If
                reset()


            End If




            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally

            MysqlConn.Dispose()


        End Try

        Getdata()



    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_NSUpdate.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader

        If Len(Trim(txt_NSSuppCode.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NSSuppCode, "Please Enter Supplier Code")
            MessageBox.Show("Please Enter Supplier Code", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NSSuppCode.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NSBname.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NSBname, "Please Enter Bussiness Name")
            MessageBox.Show("Please Enter Bussiness Name", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NSBname.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NSAddress.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NSAddress, "Please Enter Supplier Address")
            MessageBox.Show("Please Enter Supplier Address", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NSAddress.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NSContactPerson.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NSContactPerson, "Please Enter Contact Person")
            MessageBox.Show("Please Enter Contact Person", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NSContactPerson.Focus()
            Exit Sub
        End If

        If Len(Trim(cmb_NSGender.Text)) = 0 Then
            ErrorProvider1.SetError(cmb_NSGender, "Please Enter Gender")
            MessageBox.Show("Please Enter Gender", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmb_NSGender.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NSContact.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NSContact, "Please Enter Contact No")
            MessageBox.Show("Please Enter Contact No", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NSContact.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NSEmail.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NSEmail, "Please Enter Email Address")
            MessageBox.Show("Please Enter Email Address", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NSEmail.Focus()
            Exit Sub
        End If


        Try
            If MessageBox.Show("Are you sure you want to Update this record ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

                Try
                    MysqlConn.Open()

                    Dim Query As String = "UPDATE table_supplier SET Sup_Code=@sc, Sup_Bname=@sbn, Sup_Address=@sa, Sup_CPerson=@scp, Sup_Gender=@sg, Sup_ContactNo=@scn, Sup_Email=@se WHERE SID = @sid"
                    Command = New MySqlCommand(Query, MysqlConn)
                    Command.Parameters.AddWithValue("@sid", lbl_sid.Text)
                    Command.Parameters.AddWithValue("@sc", txt_NSSuppCode.Text)
                    Command.Parameters.AddWithValue("@sbn", txt_NSBname.Text)
                    Command.Parameters.AddWithValue("@sa", txt_NSAddress.Text)
                    Command.Parameters.AddWithValue("@scp", txt_NSContactPerson.Text)
                    Command.Parameters.AddWithValue("@sg", cmb_NSGender.Text)
                    Command.Parameters.AddWithValue("@scn", txt_NSContact.Text)
                    Command.Parameters.AddWithValue("@se", txt_NSEmail.Text)
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_NSDelete.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"
        'Dim Reader As MySqlDataReader

        Try
            If MessageBox.Show("Do you really want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then


                MysqlConn.Open()
                Dim AffectedRow As Integer = 0
                Dim Query As String = "DELETE FROM software_engineering_v1.table_supplier WHERE SID = @SID1"
                Command = New MySqlCommand(Query, MysqlConn)
                Command.Parameters.AddWithValue("@SID1", lbl_sid.Text)
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

    Private Sub btn_NUNew_Click(sender As Object, e As EventArgs) Handles btn_NSNew.Click
        reset()
        lbl_sid.Text = 0
        btn_NSSave.Enabled = True
    End Sub

    Private Sub form_Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getdata()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Try
            If DataGridView1.Rows.Count Then
                Dim dgvRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                lbl_sid.Text = dgvRow.Cells(0).Value.ToString
                txt_NSSuppCode.Text = dgvRow.Cells(1).Value.ToString
                txt_NSBname.Text = dgvRow.Cells(2).Value.ToString
                txt_NSAddress.Text = dgvRow.Cells(3).Value.ToString
                txt_NSContactPerson.Text = dgvRow.Cells(4).Value.ToString
                cmb_NSGender.Text = dgvRow.Cells(5).Value.ToString
                txt_NSContact.Text = dgvRow.Cells(6).Value.ToString
                txt_NSEmail.Text = dgvRow.Cells(7).Value.ToString
                
                btn_NSUpdate.Enabled = True
                btn_NSNew.Enabled = True
                btn_NSDelete.Enabled = True
                btn_NSSave.Enabled = False



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class