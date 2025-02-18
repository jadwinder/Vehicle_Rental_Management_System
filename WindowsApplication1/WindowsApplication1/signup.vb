<<<<<<< HEAD
﻿Public Class SignUp_form

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label3.Click, Label2.Click, Label4.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged, TextBox4.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login_form.Show()
        Me.Hide()
    End Sub


    Private Sub SignUp_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
=======
﻿Public Class SignUp_form

   

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login_form.Show()
        Me.Hide()
    End Sub


    Private Sub SignUp_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
>>>>>>> 71adab6 (done)
End Class