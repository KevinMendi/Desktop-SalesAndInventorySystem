
Imports MySql.Data.MySqlClient

Public Class form_DamageList
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        form_Stocks.Show()
        Me.Hide()

    End Sub

#Region "Update_Table"
    Public Sub UpdateTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String = "SELECT UID, DProduct_ID, DProduct_Name, DQuantity, DDate FROM table_stockout ORDER BY DProduct_Name"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
            dgv_viewDamList.Rows.Clear()
            While (Reader.Read() = True)
                dgv_viewDamList.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4))

            End While

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
#End Region
    Private Sub form_DamageList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTable()
        
    End Sub





    Private Sub txt_SOSearch_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchDamageList.TextChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            If txt_SearchDamageList.Text = "" Then
                Dim Query2 As String = "SELECT UID, DProduct_ID, DProduct_Name, DQuantity, DDate FROM table_stockout ORDER BY DProduct_Name"
                Command = New MySqlCommand(Query2, MysqlConn)
                Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
                dgv_viewDamList.Rows.Clear()
                While (Reader.Read() = True)
                    dgv_viewDamList.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4))

                End While

            Else
                Dim Query3 As String = "SELECT * FROM table_stockout WHERE DProduct_Name LIKE '%" & txt_SearchDamageList.Text & "%' "
                Command = New MySqlCommand(Query3, MysqlConn)
                Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
                dgv_viewDamList.Rows.Clear()
                While (Reader.Read() = True)
                    dgv_viewDamList.Rows.Add(Reader(1), Reader(2), Reader(3), Reader(4))

                End While

            End If



            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_NUDelete_Click(sender As Object, e As EventArgs) Handles btn_NUDelete.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader

        Try
            If MessageBox.Show("Do you really want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then


                MysqlConn.Open()
                Dim AffectedRow As Integer = 0
                Dim Query As String = "DELETE FROM software_engineering_v1.table_stockout WHERE UID = @UID1"
                Command = New MySqlCommand(Query, MysqlConn)
                Command.Parameters.AddWithValue("@UID1", lbl_uid.Text)
                AffectedRow = Command.ExecuteNonQuery


                If AffectedRow > 0 Then
                    MessageBox.Show("Successfully Deleted !", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Else
                    MessageBox.Show("No found Record !", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)



                End If


                MysqlConn.Close()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        UpdateTable()
    End Sub

    Private Sub dgv_viewDamList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_viewDamList.CellClick
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader



    End Sub

    Private Sub dgv_viewDamList_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_viewDamList.MouseClick
        Try
            If dgv_viewDamList.Rows.Count Then
                Dim dgvRow As DataGridViewRow = dgv_viewDamList.SelectedRows(0)

                lbl_uid.Text = dgvRow.Cells(0).Value.ToString
                


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class