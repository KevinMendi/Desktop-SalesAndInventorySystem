Imports MySql.Data.MySqlClient
Public Class Form1
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")



        ProgressBar1.Increment(+1)
        If ProgressBar1.Value = 10 Then
            'Label3.Text = ""
            Label3.Text = "Checking System Settings...."
        End If
        If ProgressBar1.Value = 30 Then
            Label3.Text = "System Ok ...."
        End If
        If ProgressBar1.Value = 50 Then
            Label3.Text = "Checking Server Connection ...."
        End If
        If ProgressBar1.Value = 65 Then
            Try
                MysqlConn.Open()
                Label3.Text = "Database Connected ! ..."
                MysqlConn.Close()

            Catch ex As Exception
                Timer1.Stop()
                MessageBox.Show("Please check your connection to the database !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.Close()






            End Try


        End If
        If ProgressBar1.Value = 80 Then
            Label3.Text = "Starting ...."
        End If

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            form_Login.Show()
            Me.Hide()
        End If
    End Sub
End Class
