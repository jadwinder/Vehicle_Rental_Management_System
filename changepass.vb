Imports System.Data.OleDb

Public Class changepass
    Dim cmd As OleDbCommand
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + connectionStr.con_str())

    ' Click event for the "Next" button
    Private Sub Login_button_Click(sender As Object, e As EventArgs) Handles Login_button.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim mobileNo As String = TextBox2.Text.Trim()

        If username = "" Or mobileNo = "" Then
            MsgBox("Please enter both Username and Mobile Number", MsgBoxStyle.Exclamation, "Wheels 4 U")
            Exit Sub
        End If

        Try
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM login_table WHERE login=@login AND Mobile_no=@mobile"
            cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@login", username)
            cmd.Parameters.AddWithValue("@mobile", mobileNo)

            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If result > 0 Then
                MsgBox("User verified! You may now reset your password.", MsgBoxStyle.Information, "Wheels 4 U")

               
                Dim cp As New confirmpass()
                cp.usernameValue = TextBox1.Text   ' Usernmae passed here 
                cp.Show()
                Me.Hide()
            Else
                MsgBox("Username and Mobile Number do not match.", MsgBoxStyle.Critical, "Wheels 4 U")
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Create account label
    
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        signup.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Login_form.Show()
        Me.Hide()
    End Sub
End Class
