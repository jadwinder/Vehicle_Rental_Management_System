Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class confirmpass


    Private Sub confirmpass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Visible = False ' Hide eye icon for new password
        PictureBox3.Visible = False ' Hide eye icon for confirm password

        ' Optional: Set focus to first textbox if you want
        TextBox1.Focus()
    End Sub



    Dim cmd As OleDbCommand
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + connectionStr.con_str())

    ' This will be set by changepass form before opening this one
    Public usernameValue As String

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Login_form.Show()
        Me.Close()
    End Sub




    ' Show/Hide Eye Icon Based on Password Length
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        PictureBox2.Visible = TextBox1.Text.Length > 0
    End Sub


    ' Show/Hide Eye Icon Based on Password Length
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        PictureBox3.Visible = TextBox2.Text.Length > 0
    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If TextBox2.PasswordChar = "*" Then
            TextBox2.PasswordChar = "" ' Show password
            PictureBox3.Image = Image.FromFile("view.png")
        Else
            TextBox2.PasswordChar = "*" ' Hide password
            PictureBox3.Image = Image.FromFile("hide.png")
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If TextBox1.PasswordChar = "*" Then
            TextBox1.PasswordChar = "" ' Show password
            PictureBox2.Image = Image.FromFile("view.png")
        Else
            TextBox1.PasswordChar = "*" ' Hide password
            PictureBox2.Image = Image.FromFile("hide.png")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(usernameValue) Then
            MsgBox("Username is missing. Cannot update password.", MsgBoxStyle.Critical, "Wheels 4 U")
            Exit Sub
        End If


        Dim newPassword As String = TextBox1.Text
        Dim confirmPassword As String = TextBox2.Text

        ' 1. Empty check
        If newPassword = "" Or confirmPassword = "" Then
            MsgBox("Fields are empty", MsgBoxStyle.Exclamation, "Wheels 4 U")
            Exit Sub
        End If

        ' 2. Strength check
        Dim pattern As String = "^(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]).{6,}$"
        If Not Regex.IsMatch(newPassword, pattern) Then
            MsgBox("Password must be at least 6 characters long and include one uppercase letter, one digit, and one special character.", MsgBoxStyle.Critical, "Wheels 4 U")
            Exit Sub
        End If

        ' 3. Match check
        If newPassword <> confirmPassword Then
            MsgBox("Passwords do not match", MsgBoxStyle.Critical, "Wheels 4 U")
            Exit Sub
        End If

        ' 4. Update password in DB
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim que As String = "UPDATE login_table SET pass=@pass WHERE login=@login"
            cmd = New OleDbCommand(que, conn)
            cmd.Parameters.AddWithValue("@pass", newPassword)
            cmd.Parameters.AddWithValue("@login", usernameValue)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MsgBox("Password changed Successfully", MsgBoxStyle.Information, "Wheels 4 U")
                Me.Close()
                Login_form.Show()
            Else
                MsgBox("Username not found or failed to update.", MsgBoxStyle.Critical, "Wheels 4 U")
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Wheels 4 U")
        Finally
            conn.Close()
        End Try
    End Sub
End Class
