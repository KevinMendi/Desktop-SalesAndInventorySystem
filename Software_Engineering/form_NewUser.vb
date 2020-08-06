Imports MySql.Data.MySqlClient


Public Class form_NewUser
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

#Region "Reset"
    Public Sub _reset()

        txt_NUName.Text = ""
        txt_NUGender.Text = Nothing
        txt_NUAge.Text = ""
        txt_NUContact.Text = ""
        txt_NUAddress.Text = ""
        txt_NUGmail.Text = ""
        txt_NUUserType.Text = Nothing
        txt_NUUsername.Text = ""
        txt_NUPassword.Text = ""
        txt_NUCPassword.Text = ""
        ErrorProvider1.Clear()


    End Sub
#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NUNew.Click
        _reset()
        lbl_uid.Text = 0
        btn_NUSave.Enabled = True


    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NUSave.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader


      

        If Len(Trim(txt_NUName.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUName, "Please Enter User Full Name")
            MessageBox.Show("Please Enter User Full Name", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUName.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUGender.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUGender, "Please Select User Gender")
            MessageBox.Show("Please Select User Gender", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUGender.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUAge.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUAge, "Please Enter User Age")
            MessageBox.Show("Please Enter User Age", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUAge.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUContact.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUContact, "Please Enter User Contact No")
            MessageBox.Show("Please Enter User Contact No", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUContact.Focus()
            Exit Sub
        End If


        If Len(Trim(txt_NUAddress.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUAddress, "Please Enter User Address")
            MessageBox.Show("Please Enter User Address", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUAddress.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUGmail.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUGmail, "Please Enter User Gmail")
            MessageBox.Show("Please Enter User Gmail", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUGmail.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUUserType.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUUserType, "Please Enter User Role")
            MessageBox.Show("Please Enter User Role", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUUserType.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUUsername.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUUsername, "Please Enter User Username")
            MessageBox.Show("Please Enter User Username", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUUsername.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUPassword.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUPassword, "Please Enter User Password")
            MessageBox.Show("Please Enter User Password", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUPassword.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUCPassword.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUCPassword, "Please Enter User Confirm Password")
            MessageBox.Show("Please Enter User Confirm Password", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUCPassword.Focus()
            Exit Sub
        End If

        If txt_NUPassword.Text <> txt_NUCPassword.Text Then
            ErrorProvider1.SetError(txt_NUCPassword, "Password Not Match !")
            MessageBox.Show("Password Not Match", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUPassword.Text = ""
            txt_NUCPassword.Text = ""
            txt_NUPassword.Focus()
            Exit Sub
        End If


        Try
            MysqlConn.Open()
            Dim Query1 As String = "SELECT Username FROM software_engineering_v1.table_login WHERE Username = @find"
            Command = New MySqlCommand(Query1, MysqlConn)
            Command.Parameters.Add(New MySqlParameter("@find", MySql.Data.MySqlClient.MySqlDbType.VarChar, 30, "Username"))
            Command.Parameters("@find").Value = txt_NUUsername.Text
            Reader = Command.ExecuteReader

            If Reader.Read Then
                MessageBox.Show("Username Already Exist !", "Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_NUUsername.Text = ""
                Return


            Else



                Try


                    Reader.Close()



                    Dim Query As String = "INSERT INTO software_engineering_v1.table_login ( Name,  Gender, Age, Contact_No, Address, Gmail, User_Type, Username, Pass) VALUES (  @Name,  @Gender, @Age, @Contact_No, @Address, @Gmail, @User_Type, @Username, md5(@Pass))"
                    Command = New MySqlCommand(Query, MysqlConn)



                    Command.Parameters.AddWithValue("@Name", txt_NUName.Text.ToUpper)
                    Command.Parameters.AddWithValue("@Gender", txt_NUGender.Text)
                    Command.Parameters.AddWithValue("@Age", txt_NUAge.Text)
                    Command.Parameters.AddWithValue("@Contact_No", txt_NUContact.Text)
                    Command.Parameters.AddWithValue("@Address", txt_NUAddress.Text)
                    Command.Parameters.AddWithValue("@Gmail", txt_NUGmail.Text)
                    Command.Parameters.AddWithValue("@User_Type", txt_NUUserType.Text)
                    Command.Parameters.AddWithValue("@Username", txt_NUUsername.Text)
                    Command.Parameters.AddWithValue("@Pass", txt_NUPassword.Text)
                    Reader = Command.ExecuteReader()
                    MessageBox.Show("Saved Successfully !, " & txt_NUUsername.Text & "")

                    _reset()



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



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NUUpdate.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader


        


        If Len(Trim(txt_NUName.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUName, "Please Enter User Full Name")
            MessageBox.Show("Please Enter User Full Name", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUName.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUGender.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUGender, "Please Select User Gender")
            MessageBox.Show("Please Select User Gender", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUGender.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUAge.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUAge, "Please Enter User Age")
            MessageBox.Show("Please Enter User Age", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUAge.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUContact.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUContact, "Please Enter User Contact No")
            MessageBox.Show("Please Enter User Contact No", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUContact.Focus()
            Exit Sub
        End If


        If Len(Trim(txt_NUAddress.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUAddress, "Please Enter User Address")
            MessageBox.Show("Please Enter User Address", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUAddress.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUGmail.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUGmail, "Please Enter User Gmail")
            MessageBox.Show("Please Enter User Gmail", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUGmail.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUUserType.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUUserType, "Please Enter User Role")
            MessageBox.Show("Please Enter User Role", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUUserType.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUUsername.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUUsername, "Please Enter User Username")
            MessageBox.Show("Please Enter User Username", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUUsername.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUPassword.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUPassword, "Please Enter User Password")
            MessageBox.Show("Please Enter User Password", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUPassword.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_NUCPassword.Text)) = 0 Then
            ErrorProvider1.SetError(txt_NUCPassword, "Please Enter User Confirm Password")
            MessageBox.Show("Please Enter User Confirm Password", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUCPassword.Focus()
            Exit Sub
        End If

        If txt_NUPassword.Text <> txt_NUCPassword.Text Then
            ErrorProvider1.SetError(txt_NUCPassword, "Password Not Match !")
            MessageBox.Show("Password Not Match", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_NUPassword.Text = ""
            txt_NUCPassword.Text = ""
            txt_NUPassword.Focus()
            Exit Sub
        End If



        Try
            If MessageBox.Show("Are you sure you want to Update this record ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then




                Try
                    MysqlConn.Open()
                    Dim Query As String = "UPDATE software_engineering_v1.table_login SET Name=@name, Gender=@gender, Age=@age, Contact_No=@cn, Address=@address, Gmail=@gmail, User_Type=@ut, Username=@username, Pass=md5(@pass) WHERE ID=@ID "
                    Command = New MySqlCommand(Query, MysqlConn)
                    Command.Parameters.AddWithValue("@ID", lbl_uid.Text)
                    Command.Parameters.AddWithValue("@name", txt_NUName.Text)
                    Command.Parameters.AddWithValue("@gender", txt_NUGender.Text)
                    Command.Parameters.AddWithValue("@age", txt_NUAge.Text)
                    Command.Parameters.AddWithValue("@cn", txt_NUContact.Text)
                    Command.Parameters.AddWithValue("@address", txt_NUAddress.Text)
                    Command.Parameters.AddWithValue("@gmail", txt_NUGmail.Text)
                    Command.Parameters.AddWithValue("@ut", txt_NUUserType.Text)
                    Command.Parameters.AddWithValue("@username", txt_NUUsername.Text)
                    Command.Parameters.AddWithValue("@pass", txt_NUPassword.Text)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Successfully Updated !")


                    If Reader Is Nothing Then

                        Reader.Close()

                    End If
                    _reset()
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NUDelete.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"

        Dim Reader As MySqlDataReader

        Try
            If MessageBox.Show("Do you really want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then


                MysqlConn.Open()
                Dim AffectedRow As Integer = 0
                Dim Query As String = "DELETE FROM software_engineering_v1.table_login WHERE ID = @ID1"
                Command = New MySqlCommand(Query, MysqlConn)
                Command.Parameters.AddWithValue("@ID1", lbl_uid.Text)
                AffectedRow = Command.ExecuteNonQuery


                If AffectedRow > 0 Then
                    MessageBox.Show("Successfully Deleted !", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    _reset()

                Else
                    MessageBox.Show("No found Record !", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    _reset()


                End If


                MysqlConn.Close()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Getdata()


    End Sub

#Region "Update"

    Public Sub UpdateTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"

        Dim sda As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String = "SELECT * FROM software_engineering_v1"
            Command = New MySqlCommand(Query, MysqlConn)
            sda.SelectCommand = Command
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            sda.Update(dbDataSet)



            MysqlConn.Close()

        Catch ex As Exception

        End Try

    End Sub

#End Region



    Private Sub UpdateTb()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"

        Dim sda As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String = "SELECT * FROM software_engineering_v1.table_login"
            Command = New MySqlCommand(Query, MysqlConn)
            sda.SelectCommand = Command
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            sda.Update(dbDataSet)



            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub


#Region "Display Data"
    Public Sub Getdata()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"
        Dim Reader As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim Query As String = "SELECT * FROM software_engineering_v1.table_login ORDER BY Name"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
            DataGridView1.Rows.Clear()
            While (Reader.Read() = True)
                DataGridView1.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4), Reader(5), Reader(6), Reader(7), Reader(8), Reader(9))

            End While

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

#End Region

    Private Sub form_NewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'UpdateTb()
        Getdata()

    End Sub

    

    Private Sub dgw1_cellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub dgw1_mouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Try
            If DataGridView1.Rows.Count Then
                Dim dgvRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                lbl_uid.Text = dgvRow.Cells(0).Value.ToString
                txt_NUName.Text = dgvRow.Cells(1).Value.ToString
                txt_NUGender.Text = dgvRow.Cells(2).Value.ToString
                txt_NUAge.Text = dgvRow.Cells(3).Value.ToString
                txt_NUContact.Text = dgvRow.Cells(4).Value.ToString
                txt_NUAddress.Text = dgvRow.Cells(5).Value.ToString
                txt_NUGmail.Text = dgvRow.Cells(6).Value.ToString
                txt_NUUserType.Text = dgvRow.Cells(7).Value.ToString
                txt_NUUsername.Text = dgvRow.Cells(8).Value.ToString
                txt_NUPassword.Text = dgvRow.Cells(9).Value.ToString
                txt_NUCPassword.Text = dgvRow.Cells(9).Value.ToString

                btn_NUUpdate.Enabled = True
                btn_NUNew.Enabled = True
                btn_NUDelete.Enabled = True
                btn_NUSave.Enabled = False



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub lbl_uid_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Watermark1_TextChanged(sender As Object, e As EventArgs) Handles txt_NUCPassword.TextChanged

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

    End Sub
End Class