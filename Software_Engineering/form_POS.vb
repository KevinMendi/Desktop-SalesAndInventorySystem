Imports MySql.Data.MySqlClient


Public Class form_POS
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Dim emp_id As String = ""
    Dim ItemID As String = ""
    Dim prod_id As String = "0"
    Dim prod_name As String = ""
    Dim brand As String = ""
    Dim prod_price As String = ""
    Dim prod_old_qty As String = ""
    Dim prod_ordered_id As String = "0"
    Dim prod_ordered_name As String = ""
    Dim old_qty As String = ""

    Dim trx_id As String = ""


#Region "Search"
    Public Sub Filter()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"
        Dim Reader As MySqlDataReader


        Try
            MysqlConn.Open()
            If txt_POSSearch.Text = "" Then
                Dim Query2 As String = "SELECT UID, Product_Name, Brand, Price, Quantity FROM table_stockin "
                Command = New MySqlCommand(Query2, MysqlConn)
                Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
                dgv_POSProList.Rows.Clear()
                While (Reader.Read() = True)
                    dgv_POSProList.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4))

                End While

            Else
                Dim Query3 As String = "SELECT * FROM table_stockin WHERE Product_Name LIKE '%" & txt_POSSearch.Text & "%' "
                Command = New MySqlCommand(Query3, MysqlConn)
                Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
                dgv_POSProList.Rows.Clear()
                While (Reader.Read() = True)
                    dgv_POSProList.Rows.Add(Reader(0), Reader(3), Reader(5), Reader(7), Reader(8))

                End While

            End If



            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
#End Region



#Region "Display table POS"
    Public Sub Display_POS()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String = "SELECT UID, Product_Name, Brand, Price, Quantity FROM table_stockin ORDER BY Product_Name"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
            dgv_POSProList.Rows.Clear()
            While (Reader.Read() = True)
                dgv_POSProList.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4))

            End While

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
#End Region




    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub


#Region "Get Total"
    Public Sub getTotal()
        If dgv_POSRecieveList.Rows.Count > 0 Then
            Dim grand_total As Decimal
            For Each dr As DataGridViewRow In dgv_POSRecieveList.Rows
                Dim total As Decimal = dr.Cells(4).Value
                grand_total += total
            Next
            If grand_total < 100 Then
                lbl_POSTotal.Text = Format(grand_total, "0.00")
            Else
                lbl_POSTotal.Text = Format(grand_total, "#,000.00")
            End If

        Else
            lbl_POSTotal.Text = "0.00"
        End If
    End Sub
#End Region




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = ("server=localhost;userid=root;password=09201996;database=software_engineering_v1")
        Dim Reader As MySqlDataReader


        If prod_id = "0" Then
            MsgBox("Please select data on table")
        ElseIf prod_old_qty = "0" Then
            MsgBox("Insufficient stocks available")
        Else
            Dim qty As String = ""

            qty = InputBox("Enter Quantity to buy for " + prod_name)

            Try
                If CDec(qty) <= 0.0 Then
                    MsgBox("Zero or below is not accepted")
                Else
                    If CDec(qty) > CDec(prod_old_qty) Then
                        MsgBox("Insufficient stocks available")
                    Else
                        Dim num As Integer = 0

                        For i As Integer = 0 To dgv_POSRecieveList.Rows.Count - 1
                            Dim id As String = dgv_POSRecieveList.Rows(i).Cells(0).Value.ToString
                            Dim order_quan As String = dgv_POSRecieveList.Rows(i).Cells(3).Value.ToString
                            If prod_id = id Then
                                dgv_POSRecieveList.Rows(i).Cells(3).Value = CDbl(qty) + CDbl(order_quan)
                                dgv_POSRecieveList.Rows(i).Cells(4).Value = Format((CDbl(qty) + CDbl(order_quan)) * CDbl(prod_price), "0.00")
                                num = 1
                            End If
                        Next

                        If num = 0 Then
                            ' dgv_POSRecieveList.Rows.Add(prod_id, prod_name, prod_price, qty, Format(CDbl(qty) * CDbl(prod_price), "0.00"))
                            dgv_POSRecieveList.Rows.Add(prod_id, prod_name, prod_price, qty, Format(CDbl(qty) * CDbl(prod_price), "0.00"))
                        End If


                        MysqlConn.Open()
                        Dim Query As String = "UPDATE table_stockin SET Quantity='" & prod_old_qty - qty & "' " &
                                                       "WHERE UID= '" & lbl_id.Text & "' "
                        Command = New MySqlCommand(Query, MysqlConn)
                        Reader = Command.ExecuteReader
                        ' Dim ds As New DataSet
                        ' Dim da As New MySqlDataAdapter("UPDATE table_stockin SET Quantity='" & prod_old_qty - qty & "' " &
                        '"WHERE UID= '" & lbl_id.Text & "' ", MysqlConn)
                        'da.Fill(ds, "table_stockin")
                        'load_prod()
                        Display_POS()
                        getTotal()

                        MysqlConn.Close()


                    End If
                End If
            Catch ex As Exception
            End Try
            prod_id = "0"
        End If
        'dgv_order.ClearSelection()
        'txt_search.Clear()

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub dgv_SOPRoList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_POSProList.CellContentClick

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Watermark1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Watermark4_TextChanged(sender As Object, e As EventArgs) Handles txt_POSCustomerCNo.TextChanged

    End Sub

    Private Sub lbl_POSUser_Click(sender As Object, e As EventArgs) Handles lbl_POSUser.Click

    End Sub

    Private Sub form_POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        Display_POS()
       
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_POSDate.Text = Date.Now.ToString("MM/dd/yyyy")
        lbl_POSTime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub txt_POSSearch_TextChanged(sender As Object, e As EventArgs) Handles txt_POSSearch.TextChanged
        Filter()
    End Sub

    Private Sub cmb_POSSort_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_POSSort.SelectedValueChanged

    End Sub

    Private Sub cmb_POSSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_POSSort.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"
        Dim Reader As MySqlDataReader

        If cmb_POSSort.Text = "Name" Then
            Try
                MysqlConn.Open()
                Dim Query2 As String = "SELECT UID, Product_Name, Brand, Price, Quantity FROM table_stockin ORDER BY Product_Name"
                Command = New MySqlCommand(Query2, MysqlConn)
                Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
                dgv_POSProList.Rows.Clear()
                While (Reader.Read() = True)
                    dgv_POSProList.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4))

                End While
                MysqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try



        ElseIf cmb_POSSort.Text = "Brand" Then
            Try
                MysqlConn.Open()
                Dim Query2 As String = "SELECT UID, Product_Name, Brand, Price, Quantity FROM table_stockin ORDER BY Brand"
                Command = New MySqlCommand(Query2, MysqlConn)
                Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
                dgv_POSProList.Rows.Clear()
                While (Reader.Read() = True)
                    dgv_POSProList.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4))

                End While
                MysqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            Try
                MysqlConn.Open()
                Dim Query2 As String = "SELECT UID, Product_Name, Brand, Price, Quantity FROM table_stockin "
                Command = New MySqlCommand(Query2, MysqlConn)
                Reader = Command.ExecuteReader(CommandBehavior.CloseConnection)
                dgv_POSProList.Rows.Clear()
                While (Reader.Read() = True)
                    dgv_POSProList.Rows.Add(Reader(0), Reader(1), Reader(2), Reader(3), Reader(4))

                End While
                MysqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        End If

    End Sub

    Private Sub dgv_POSProList_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_POSProList.MouseClick

    End Sub

    Private Sub dgv_POSProList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_POSProList.CellClick
        Try
            Dim i As Integer
            i = dgv_POSProList.CurrentRow.Index


            prod_id = dgv_POSProList.Rows(i).Cells(0).Value.ToString
            lbl_id.Text = dgv_POSProList.Rows(i).Cells(0).Value.ToString
            ' ItemID = dgv_POSProList.Rows(i).Cells(1).Value.ToString
            prod_name = dgv_POSProList.Rows(i).Cells(1).Value.ToString
            brand = dgv_POSProList.Rows(i).Cells(2).Value.ToString
            prod_price = dgv_POSProList.Rows(i).Cells(3).Value.ToString
            prod_old_qty = dgv_POSProList.Rows(i).Cells(4).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"
        Dim Reader As MySqlDataReader

        If dgv_POSRecieveList.Rows.Count = 0 Then
            MsgBox("Sorry, no item list found")
        ElseIf prod_ordered_id = "0" Then
            MsgBox("Please select data on the ordered table list")
        ElseIf dgv_POSRecieveList.Rows.Count > 0 Then
            Try
                Dim i As Integer
                i = dgv_POSRecieveList.CurrentRow.Index
                prod_ordered_id = dgv_POSRecieveList.Rows(i).Cells(0).Value.ToString
                prod_old_qty = dgv_POSRecieveList.Rows(i).Cells(3).Value.ToString

                MysqlConn.Open()
                Dim query As String = "UPDATE table_stockin SET Quantity = Quantity+ " & CDec(prod_old_qty) & " WHERE UID = '" & lbl_Oid.Text & "' "
                Command = New MySqlCommand(query, MysqlConn)
                Reader = Command.ExecuteReader
                Display_POS()

                MysqlConn.Close()

                'Call connect_db()
                'Dim ds As New DataSet
                'Dim da As New MySqlDataAdapter("UPDATE tbl_product SET prod_quan=prod_quan+" & CDec(prod_old_qty) & " " &
                ' "WHERE prod_status='1' AND prod_id=" & prod_ordered_id & "", sqlcon)
                'da.Fill(ds, "tbl_product")
                'load_prod()
                prod_ordered_id = "0"
                'Call disconnect_db()


                dgv_POSRecieveList.Rows.RemoveAt(i)
                dgv_POSRecieveList.ClearSelection()
                getTotal()

                'Call get_total()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Please select Data on the product ordered list")
        End If
    End Sub

    Private Sub dgv_POSRecieveList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_POSRecieveList.CellClick

     


        Try
            Dim i As Integer
            i = dgv_POSRecieveList.CurrentRow.Index
            prod_ordered_id = dgv_POSRecieveList.Rows(i).Cells(0).Value.ToString
            lbl_Oid.Text = dgv_POSRecieveList.Rows(i).Cells(0).Value.ToString
            prod_ordered_name = dgv_POSRecieveList.Rows(i).Cells(1).Value.ToString
            prod_price = dgv_POSRecieveList.Rows(i).Cells(2).Value.ToString
            old_qty = dgv_POSRecieveList.Rows(i).Cells(3).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"
        Dim Reader As MySqlDataReader

        If dgv_POSRecieveList.Rows.Count = 0 Then
            MsgBox("Sorry, no item list found")
        Else
            Dim result As Integer = MessageBox.Show("Are you sure you want clear list?", "", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If dgv_POSRecieveList.Rows.Count > 0 Then
                    For Each dr As DataGridViewRow In dgv_POSRecieveList.Rows
                        Dim prod_id1 As Integer = dr.Cells(0).Value
                        Dim qty As Decimal = dr.Cells(3).Value

                        MysqlConn.Open()
                        Dim Query As String = "UPDATE table_stockin SET Quantity=Quantity+ " & qty & " WHERE UID = " & prod_id1 & " "
                        Command = New MySqlCommand(Query, MysqlConn)
                        Reader = Command.ExecuteReader


                        MysqlConn.Close()

                        'Call connect_db()
                        'Dim ds As New DataSet
                        ' Dim da As New MySqlDataAdapter("UPDATE tbl_product SET prod_quan=prod_quan+" & qty & " " &
                        '"WHERE prod_status='1' AND prod_id=" & prod_id1 & "", sqlcon)
                        '.Fill(ds, "tbl_product")
                        'Call disconnect_db()
                    Next
                    ' load_prod()
                    Display_POS()

                    dgv_POSRecieveList.Rows.Clear()
                    dgv_POSRecieveList.ClearSelection()
                    'Call get_total()
                    getTotal()

                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"
        Dim Reader1 As MySqlDataReader
        Dim Reader2 As MySqlDataReader
        If prod_ordered_id = "0" Then
            MsgBox("Please select data on the ordered table list")

        ElseIf dgv_POSRecieveList.Rows.Count > 0 Then
            Dim new_qty As String = ""
            'new_qty = InputBox("", "Enter new Quantity to buy for " + prod_ordered_name + "", old_qty, new_qty, True, False
            new_qty = InputBox("", "Enter new Quantity to buy for " + prod_ordered_name, old_qty)
            If new_qty <> "" Then

                For Each dr As DataGridViewRow In dgv_POSProList.Rows
                    Dim prod_id As String = dr.Cells(0).Value.ToString
                    If prod_id = prod_ordered_id Then


                        If dr.Cells(3).Value < new_qty Then
                            MsgBox("Sorry, You Input greater than the available stocks ")
                        Else
                            Dim i As Integer
                            i = dgv_POSRecieveList.CurrentRow.Index
                            Dim price As Decimal = CDec(dgv_POSRecieveList.Item(2, i).Value)
                            Dim old_qty1 As Decimal = CDec(dgv_POSRecieveList.Item(3, i).Value)
                            Dim new_total As Decimal = CInt(new_qty) * price

                            dgv_POSRecieveList.Item(3, i).Value = new_qty
                            dgv_POSRecieveList.Item(4, i).Value = Format(new_total, "0.00")
                            'Call get_total()
                            getTotal()


                            MysqlConn.Open()
                            Dim Query As String = "UPDATE table_stockin SET Quantity=(Quantity+" & old_qty1 & ")-" & CDec(new_qty) & " WHERE UID = " & prod_ordered_id & " "
                            Command = New MySqlCommand(Query, MysqlConn)
                            Reader1 = Command.ExecuteReader
                            MysqlConn.Close()
                            Display_POS()


                            'Call connect_db()
                            'Dim ds As New DataSet
                            ' Dim da As New MySqlDataAdapter("UPDATE tbl_product_mngt SET prod_quantity=(prod_quantity+" & old_qty1 & ")-" & CDec(new_qty) & " " &
                            '"WHERE active='yes' AND prod_id=" & prod_ordered_id & "", sqlcon)
                            '.Fill(ds, "tbl_product_mngt")
                            'Call disconnect_db()

                            'refreshgrid()
                            dgv_POSRecieveList.ClearSelection()
                        End If

                    End If
                Next

               
            ElseIf new_qty = "0" Then
                MsgBox("Sorry, zero or below is not accepted")
            End If
        Else
            MsgBox("There is no ordered item list")
        End If



      
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=09201996;database=software_engineering_v1"

        If Len(Trim(txt_POSCustomerName.Text)) = 0 Then
            ErrorProvider1.SetError(txt_POSCustomerName, "Please Enter Your Customer Full Name")
            MessageBox.Show("Please Enter Your Customer Full Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_POSCustomerName.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_POSCustomerCNo.Text)) = 0 Then
            ErrorProvider1.SetError(txt_POSCustomerCNo, "Please Enter Your Customer Contact No")
            MessageBox.Show("Please Enter Your Customer Contact No", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_POSCustomerCNo.Focus()
            Exit Sub
        End If

        If Len(Trim(txt_POSCustomerAddress.Text)) = 0 Then
            ErrorProvider1.SetError(txt_POSCustomerAddress, "Please Enter Your Customer Contact No")
            MessageBox.Show("Please Enter Your Customer Contact No", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_POSCustomerAddress.Focus()
            Exit Sub
        End If

        


        If lbl_POSTotal.Text = "0.00" Then
            MessageBox.Show("Sorry, no order list")
        ElseIf txt_POSTendered.Text = "" Then
            MessageBox.Show("Please input the money render")
            txt_POSTendered.Focus()
        ElseIf CInt(txt_POSTendered.Text) < CInt(lbl_POSTotal.Text) Then
            MessageBox.Show("Sorry, not enough rendered Money")
            txt_POSTendered.Focus()
        Else
            If (MessageBox.Show("Are you sure you want to proceed printing ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = Windows.Forms.DialogResult.Yes Then

            End If

        End If


    End Sub

    Private Sub txt_POSTendered_TextChanged(sender As Object, e As EventArgs) Handles txt_POSTendered.TextChanged

        Try
            If txt_POSTendered.Text = "" Then
                lbl_POSChange.Text = "0.00"
            Else
                lbl_POSChange.Text = CDec(txt_POSTendered.Text) - CDec(lbl_POSTotal.Text)
            End If
        Catch ex As Exception
            'msgDialog.ShowDialog("", "", "Invalid Input", "", 3)
            MessageBox.Show(ex.Message, "Invalid Input !")
            txt_POSTendered.Text = ""
            lbl_POSChange.Text = "0.00"
        End Try
    End Sub
End Class