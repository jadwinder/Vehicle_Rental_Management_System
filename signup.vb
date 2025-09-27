Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class signup
    Dim cmd As OleDbCommand
    Dim que As String
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + connectionStr.con_str())

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "Enter your username"
        TextBox1.ForeColor = Color.LightGray

        TextBox2.PasswordChar = "*"
        TextBox2.UseSystemPasswordChar = False
        PictureBox3.Visible = False ' Hide eye icon
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus, TextBox3.GotFocus
        If TextBox1.Text = "Enter your username" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus, TextBox3.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.Text = "Enter your username"
            TextBox1.ForeColor = Color.LightGray
        End If
    End Sub

    ' Show/Hide Eye Icon Based on Password Length
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged
        PictureBox3.Visible = TextBox2.Text.Length > 0
    End Sub

    ' Show/Hide Password Eye Click
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If TextBox2.PasswordChar = "*" Then
            TextBox2.PasswordChar = ""
            PictureBox3.Image = Image.FromFile("view.png")
        Else
            TextBox2.PasswordChar = "*"
            PictureBox3.Image = Image.FromFile("hide.png")
        End If
    End Sub

    ' 🔐 Regex-based Strong Password Validator
    Private Function IsValidPassword(password As String) As Boolean
        Dim pattern As String = "^(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]).{6,}$"
        Return Regex.IsMatch(password, pattern)
    End Function

    Private Sub Signup_button_Click(sender As Object, e As EventArgs) Handles Signup_button.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Fields are empty", MsgBoxStyle.Exclamation, "Wheels 4 U")
            Exit Sub
        End If

        If Not IsValidPassword(TextBox2.Text) Then
            MsgBox("Password must be at least 6 characters long and include one uppercase letter, one digit, and one special character.", MsgBoxStyle.Critical, "Wheels 4 U")
            Exit Sub
        End If

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            que = "INSERT INTO login_table (login, pass, First_name, Last_name, Mobile_no) VALUES (@login, @pass, @fname, @lname, @mobileNo)"
            cmd = New OleDbCommand(que, conn)
            cmd.Parameters.AddWithValue("@login", TextBox1.Text)
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text)
            cmd.Parameters.AddWithValue("@fname", TextBox3.Text)
            cmd.Parameters.AddWithValue("@lname", TextBox4.Text)
            cmd.Parameters.AddWithValue("@mobileNo", TextBox5.Text)

            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Signed Up Successfully", MsgBoxStyle.Information, "Wheels 4 U")

                ' Clear fields
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()

                Me.Hide()
                Dim loaderForm As New Loader()
                loaderForm.Show()
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Wheels 4 U")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Login_form.Show()
        Me.Close()
    End Sub
End Class
