Imports System.Data.OleDb

Public Class delete
    Dim cmd As OleDbCommand
    Dim que As String
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + connectionStr.con_str())

    Private Sub Label27_Click(sender As Object, e As EventArgs)
        dashboard.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        search.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        add.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        updateCars.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        history.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        booking.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        upcoming.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim val As String = ""

        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Please enter RC No or Engine No to Search", MsgBoxStyle.Information)
            Exit Sub
        End If

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        If TextBox1.Text <> "" Then
            que = "SELECT * FROM add_table WHERE Engine=@no"
            val = TextBox1.Text
        ElseIf TextBox2.Text <> "" Then
            que = "SELECT * FROM add_table WHERE RC=@no"
            val = TextBox2.Text
        End If

        cmd = New OleDbCommand(que, conn)
        cmd.Parameters.AddWithValue("@no", val)

        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        If count > 0 Then
            If TextBox1.Text <> "" Then
                que = "DELETE FROM add_table WHERE Engine=@no"
            ElseIf TextBox2.Text <> "" Then
                que = "DELETE FROM add_table WHERE RC=@no"
            End If

            cmd = New OleDbCommand(que, conn)
            cmd.Parameters.AddWithValue("@no", val)

            If MsgBox("Are you sure! You want to delete this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                cmd.ExecuteNonQuery()
                MsgBox("Car Successfully Deleted", MsgBoxStyle.OkOnly)
                TextBox1.Clear()
                TextBox2.Clear()
            Else
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        Else
            MsgBox("No result found!", MsgBoxStyle.Information)
            TextBox1.Clear()
            TextBox2.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As EventArgs) Handles TextBox1.KeyUp
        If TextBox2.Text <> "" Then
            TextBox2.Clear()
        End If
    End Sub

    Private Sub TextBox2_KeyUp(sender As Object, e As EventArgs) Handles TextBox2.KeyUp
        If TextBox1.Text <> "" Then
            TextBox1.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Label27_Click_1(sender As Object, e As EventArgs)
        dashboard.Show()
        Me.Close()
    End Sub

   

   
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        dashboard.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim result As DialogResult
        result = MessageBox.Show("You want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Login_form.Show()
            Me.Close()
            Login_form.TextBox1.Clear()
            Login_form.TextBox2.Clear()
        End If
        ' If No is clicked, nothing happens, so the user stays on the current form.
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        search.Show()
        Me.Close()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        add.Show()
        Me.Close()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        updateCars.Show()
        Me.Close()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        history.Show()
        Me.Close()
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        booking.Show()
        Me.Close()
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        If upcoming.HasUpcomingRecords() Then
            Dim up As New upcoming()
            up.Show()
            Me.Close() ' close current form only if records exist
        Else
            MsgBox("No upcoming bookings found!", MsgBoxStyle.Information)
            ' Do nothing, stay on the current form
        End If
    End Sub

End Class