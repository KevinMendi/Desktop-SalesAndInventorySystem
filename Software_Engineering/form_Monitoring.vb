Imports MySql.Data.MySqlClient

Public Class form_Monitoring
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()

    End Sub

#Region "ColorTable"
    Public Sub ColorTable()
        For i As Integer = 0 To dgv_CriticalProducts.Rows.Count() - 1 Step +1
            Dim Val As Integer
            Val = dgv_CriticalProducts.Rows(i).Cells(6).Value
            
            If Val >= 0 And Val <= 39 Then
                dgv_CriticalProducts.Rows(i).DefaultCellStyle.BackColor = Color.Red
                Timer1.Start()

            ElseIf Val >= 40 And Val <= 79 Then
                dgv_CriticalProducts.Rows(i).DefaultCellStyle.BackColor = Color.Lime
            ElseIf Val >= 80 And Val <= 100 Then
                dgv_CriticalProducts.Rows(i).DefaultCellStyle.BackColor = Color.Yellow

            Else

                dgv_CriticalProducts.Rows(i).DefaultCellStyle.BackColor = Color.White


            End If
        Next
    End Sub
#End Region

    Private Sub form_Monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String = "SELECT Supplier_Code, Product_ID, Product_Name, Description, Brand, Price, Quantity FROM table_stockin WHERE Quantity < 100 ORDER BY Quantity DESC "
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
            dgv_CriticalProducts.Rows.Clear()
            While (Reader.Read() = True)
                dgv_CriticalProducts.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4), Reader(5), Reader(6))

            End While

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        ColorTable()

    End Sub

    Private Sub txt_SearchCriticalProducts_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_SearchCriticalProducts.MouseClick
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_SearchCriticalProducts_TextChanged(sender As Object, e As EventArgs) Handles txt_SearchCriticalProducts.TextChanged

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"
        Dim Reader As MySqlDataReader


        Try
            MysqlConn.Open()
            If txt_SearchCriticalProducts.Text = "" Then
                Dim Query2 As String = "SELECT Supplier_Code, Product_ID, Product_Name, Description, Brand, Price, Quantity FROM table_stockin WHERE Quantity < 100 ORDER BY Quantity DESC"
                Command = New MySqlCommand(Query2, MysqlConn)
                Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
                dgv_CriticalProducts.Rows.Clear()
                While (Reader.Read() = True)
                    dgv_CriticalProducts.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4), Reader(5), Reader(6))

                End While

            Else
                Dim Query3 As String = "SELECT Supplier_Code, Product_ID, Product_Name, Description, Brand, Price, Quantity FROM table_stockin WHERE Product_Name  LIKE '%" & txt_SearchCriticalProducts.Text & "%' ORDER BY Quantity DESC "
                Command = New MySqlCommand(Query3, MysqlConn)
                Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
                dgv_CriticalProducts.Rows.Clear()
                While (Reader.Read() = True)
                    dgv_CriticalProducts.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4), Reader(5), Reader(6))

                End While

            End If



            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ColorTable()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For i As Integer = 0 To dgv_CriticalProducts.Rows.Count() - 1 Step +1
            Dim Val As Integer
            Val = dgv_CriticalProducts.Rows(i).Cells(6).Value

            If Val >= 0 And Val <= 39 Then
                If dgv_CriticalProducts.Rows(i).DefaultCellStyle.BackColor = Color.Red Then
                    dgv_CriticalProducts.Rows(i).DefaultCellStyle.BackColor = Color.White
                ElseIf dgv_CriticalProducts.Rows(i).DefaultCellStyle.BackColor = Color.White Then
                    dgv_CriticalProducts.Rows(i).DefaultCellStyle.BackColor = Color.Red
                End If
            
            



            End If
        Next
    End Sub
End Class