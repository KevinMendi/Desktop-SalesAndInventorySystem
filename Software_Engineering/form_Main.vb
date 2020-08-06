Public Class form_Main

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddSupplier.Click
        form_Supplier.ShowDialog()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        form_manageProducts.ShowDialog()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_IO.Click
        form_Stocks.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_monitor.Click
        form_Monitoring.ShowDialog()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_POS.Click
        form_POS.ShowDialog()

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        form_Login.label_role.Text = "Role"
        form_Login.label_Name.Text = "User"
        Me.Close()
        form_Login.Show()
        form_Login.ErrorProvider1.Clear()
        form_Login.reset()



    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddUser.Click
        form_NewUser.ShowDialog()

    End Sub

    Private Sub form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True


        If label_UserType.Text = "Master Admin" Then
            btn_AddUser.Enabled = True
            btn_AddSupplier.Enabled = True
            btn_POS.Enabled = True
            btn_IO.Enabled = True
            ' btn_MP.Enabled = True
            btn_monitor.Enabled = True
            btn_genRep.Enabled = True

        ElseIf label_UserType.Text = "Admin" Then
            btn_AddUser.Enabled = True
            btn_AddSupplier.Enabled = True
            btn_POS.Enabled = True
            btn_IO.Enabled = True
            ' btn_MP.Enabled = True
            btn_monitor.Enabled = True
            btn_genRep.Enabled = True

        ElseIf label_UserType.Text = "User" Then
            btn_AddUser.Enabled = False
            btn_AddSupplier.Enabled = False
            btn_POS.Enabled = True
            btn_IO.Enabled = True
            ' btn_MP.Enabled = False
            btn_monitor.Enabled = True
            btn_genRep.Enabled = True

        Else
            btn_AddUser.Enabled = False
            btn_AddSupplier.Enabled = False
            btn_POS.Enabled = False
            btn_IO.Enabled = False
            ' btn_MP.Enabled = False
            btn_monitor.Enabled = False
            btn_genRep.Enabled = False




        End If
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date.Text = Date.Now.ToString("MM/dd/yyyy")
        lbl_time.Text = Date.Now.ToString("hh:mm:ss")

    End Sub
End Class