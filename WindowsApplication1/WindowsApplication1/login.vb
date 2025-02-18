Public Class Login_form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login_button.Click
        index.Show()
        Me.Close()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SignUp_form.Show()
        Me.Hide()
    End Sub

    Private Sub Login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class