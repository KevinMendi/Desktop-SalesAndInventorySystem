Imports MySql.Data.MySqlClient


Public Class form_Login
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
#Region "reset"
    Sub reset()
        txt_Username.Text = Nothing
        txt_Password.Text = Nothing
    End Sub
#End Region




    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader


        If Len(Trim(txt_Username.Text)) = 0 Then
            ErrorProvider1.SetError(txt_Username, "Please Enter Your Username")
            MessageBox.Show("Please Enter Your Username", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_Username.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_Password.Text)) = 0 Then
            ErrorProvider1.SetError(txt_Password, "Please Enter Your Password")
            MessageBox.Show("Please Enter Your Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_Password.Focus()
            Exit Sub

        End If






        Try
            MysqlConn.Open()
            Dim Query As String = "SELECT User_Type, Name FROM software_engineering_v1.table_login WHERE Username = @find"
            Command = New MySqlCommand(Query, MysqlConn)
            Command.Parameters.Add(New MySqlParameter("@find", MySql.Data.MySqlClient.MySqlDbType.VarChar, 30, "Username"))
            Command.Parameters("@find").Value = txt_Username.Text
            Reader = Command.ExecuteReader

            If Reader.Read Then

                label_role.Text = Reader("User_Type").ToString
                label_Name.Text = Reader("Name").ToString
            Else
                MessageBox.Show("Invalid Username", "Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Username.Text = ""
                txt_Username.Focus()
                Return

                If Reader Is Nothing Then
                    Reader.Close()

                End If
            End If

            If Reader Is Nothing Then
                Reader.Close()

            End If

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try




        Try
            MysqlConn.Open()

            Dim Query As String = "SELECT * FROM software_engineering_v1.table_login WHERE Username = '" & txt_Username.Text & "' and Pass =md5('" & txt_Password.Text & "')"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader

            If Reader.HasRows Then
                form_Main.label_UserType.Text = label_role.Text
                form_Main.label_User.Text = label_Name.Text
                Me.Hide()
                form_Main.ShowDialog()

                If Reader Is Nothing Then
                    Reader.Close()
                End If

            Else
                MessageBox.Show("Invalid Password", "Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Password.Text = ""
                txt_Password.Focus()

                If Reader Is Nothing Then
                    Reader.Close()
                End If
            End If

            'Dim count As Integer

            ' While Reader.Read
            'count = count + 1

            'End While

            'If count = 1 Then
            'MessageBox.Show("Username and Password are correct")
            ' Me.Close()
            'form_Main.ShowDialog()



            'Else
            ' MessageBox.Show("Username and Password are incorrect")
            ' End If
            If Reader Is Nothing Then
                Reader.Close()
            End If
            MysqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub form_MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        form_Supplier.ShowDialog()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        form_POS.ShowDialog()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        form_manageProducts.ShowDialog()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        form_StockIO.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        form_Monitoring.ShowDialog()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub label_role_Click(sender As Object, e As EventArgs) Handles label_role.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader


        If Len(Trim(txt_Username.Text)) = 0 Then
            ErrorProvider1.SetError(txt_Username, "Please Enter Your Username")
            MessageBox.Show("Please Enter Your Username", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_Username.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_Password.Text)) = 0 Then
            ErrorProvider1.SetError(txt_Password, "Please Enter Your Password")
            MessageBox.Show("Please Enter Your Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_Password.Focus()
            Exit Sub

        End If






        Try
            MysqlConn.Open()
            Dim Query As String = "SELECT User_Type, Name FROM software_engineering_v1.table_login WHERE Username = @find"
            Command = New MySqlCommand(Query, MysqlConn)
            Command.Parameters.Add(New MySqlParameter("@find", MySql.Data.MySqlClient.MySqlDbType.VarChar, 30, "Username"))
            Command.Parameters("@find").Value = txt_Username.Text
            Reader = Command.ExecuteReader

            If Reader.Read Then

                label_role.Text = Reader("User_Type").ToString
                label_Name.Text = Reader("Name").ToString
            Else
                MessageBox.Show("Invalid Username", "Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Username.Text = ""
                txt_Username.Focus()
                Return

                If Reader Is Nothing Then
                    Reader.Close()

                End If
            End If

            If Reader Is Nothing Then
                Reader.Close()

            End If

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try




        Try
            MysqlConn.Open()

            Dim Query As String = "SELECT * FROM software_engineering_v1.table_login WHERE Username = '" & txt_Username.Text & "' and Pass =md5('" & txt_Password.Text & "')"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader

            If Reader.HasRows Then
                form_Main.label_UserType.Text = label_role.Text
                form_Main.label_User.Text = label_Name.Text
                form_POS.lbl_POSUser.Text = label_Name.Text
                form_POS.lbl_POSUserType.Text = label_role.Text
                Me.Hide()
                form_Main.ShowDialog()

                If Reader Is Nothing Then
                    Reader.Close()
                End If

            Else
                MessageBox.Show("Invalid Password", "Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Password.Text = ""
                txt_Password.Focus()

                If Reader Is Nothing Then
                    Reader.Close()
                End If
            End If

            'Dim count As Integer

            ' While Reader.Read
            'count = count + 1

            'End While

            'If count = 1 Then
            'MessageBox.Show("Username and Password are correct")
            ' Me.Close()
            'form_Main.ShowDialog()



            'Else
            ' MessageBox.Show("Username and Password are incorrect")
            ' End If
            If Reader Is Nothing Then
                Reader.Close()
            End If
            MysqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub txt_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Password.KeyPress

    End Sub
End Class