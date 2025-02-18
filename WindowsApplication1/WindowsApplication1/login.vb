<<<<<<< HEAD
﻿Public Class Login_form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login_button.Click
        index.Show()
        Me.Close()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SignUp_form.Show()
        Me.Hide()
    End Sub

    Private Sub Login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "Enter your Mobile no."
        TextBox1.ForeColor = Color.LightGray

    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Enter your Mobile no." Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black


        End If

    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus

        If TextBox1.Text = "" Then
            TextBox1.Text = "Enter your Mobile no."
            TextBox1.ForeColor = Color.LightGray

        End If

    End Sub
=======
﻿Public Class Login_form
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
>>>>>>> 71adab6 (done)
End Class