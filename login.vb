Imports System.Data.OleDb

Public Class Login_form
    Dim cmd As OleDbCommand
    Dim que As String
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + connectionStr.con_str())

    ' Form Load Event
    ' Form Load Event
    Private Sub Login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Placeholder for Username
        TextBox1.Text = "Enter your username"
        TextBox1.ForeColor = Color.SlateGray

        ' Placeholder for Password
        TextBox2.Text = "Enter your password"
        TextBox2.ForeColor = Color.SlateGray
        TextBox2.PasswordChar = ControlChars.NullChar
        TextBox2.UseSystemPasswordChar = False

        PictureBox3.Visible = False ' Hide the eye icon initially

        ' Set ActiveControl to Nothing to prevent auto-focus
        Me.ActiveControl = Nothing
        Label1.Select()
    End Sub


    ' Placeholder Handling for Username
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Enter your username" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.Text = "Enter your username"
            TextBox1.ForeColor = Color.SlateGray
        End If
    End Sub

    ' Placeholder Handling for Password
    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        If TextBox2.Text = "Enter your password" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.PasswordChar = "*" ' Enable password character when typing
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text = "" Then
            TextBox2.Text = "Enter your password"
            TextBox2.ForeColor = Color.SlateGray
            TextBox2.PasswordChar = ControlChars.NullChar ' Disable password character for placeholder
        End If
    End Sub


   

    ' Login Button Click Event
    Private Sub Login_button_Click(sender As Object, e As EventArgs) Handles Login_button.Click
        If TextBox1.Text = "Enter your username" Or TextBox2.Text = "Enter your password" Then
            MsgBox("Fields are empty", MsgBoxStyle.Exclamation, "Wheels 4 U")
            Exit Sub
        End If

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        que = "SELECT COUNT(*) FROM Login_table WHERE login=@login AND pass=@pass"
        cmd = New OleDbCommand(que, conn)
        cmd.Parameters.AddWithValue("@login", TextBox1.Text)
        cmd.Parameters.AddWithValue("@pass", TextBox2.Text)

        Try
            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If result > 0 Then
                MsgBox("Logged In Successfully", MsgBoxStyle.Information, "Wheels 4 U")
                Me.Hide()
                Dim loaderForm As New Loader()
                loaderForm.Show()
            Else
                MsgBox("Invalid Credentials", MsgBoxStyle.Information, "Wheels 4 U")
                TextBox2.Clear()
                TextBox2.Focus()
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Signup Button Click Event
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        signup.Show()
        Me.Close()
    End Sub

    ' Show/Hide Eye Icon Based on Password Length
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        PictureBox3.Visible = TextBox2.Text.Length > 0
    End Sub

  
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If TextBox2.PasswordChar = "*" Then
            TextBox2.PasswordChar = "" ' Show password in plain text
            PictureBox3.Image = Image.FromFile("view.png") ' Show icon for "visible"
        Else
            TextBox2.PasswordChar = "*" ' Hide password with asterisks
            PictureBox3.Image = Image.FromFile("hide.png") ' Show icon for "hidden"
        End If
    End Sub

 
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        changepass.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        signup.Show()
        Me.Hide()
    End Sub
End Class
