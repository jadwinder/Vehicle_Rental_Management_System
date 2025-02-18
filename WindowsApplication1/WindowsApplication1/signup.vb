Public Class SignUp_form

   

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login_form.Show()
        Me.Hide()
    End Sub


    Private Sub SignUp_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class