
Imports MySql.Data.MySqlClient

Public Class form_StockIO
    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand

#Region "Clear"
    Public Sub reset()
        cmb_SDSupCode.Text = Nothing
        txt_SDProID.Text = ""
        txt_SDProName.Text = ""
        txt_SDProDesciption.Text = ""
        txt_SDBrand.Text = ""
        txt_SDPrice.Text = ""
        txt_SDQuantity.Text = ""
        ' lbl_uid.Text = 0
    End Sub
#End Region


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Hide()

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        form_DamageList.ShowDialog()

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub btn_SDNew_Click(sender As Object, e As EventArgs) Handles btn_SDNew.Click
        reset()

    End Sub

    Private Sub btn_SDAddPro_Click(sender As Object, e As EventArgs) Handles btn_SDAddPro.Click
       





      


    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
      
    End Sub

    Private Sub form_StockIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class