Public Class dashboard
    
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        updateCars.Show()
        Me.Close()

    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs)
        Login_form.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        search.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        add.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        delete.Show()
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

    ' Code for button click event in the calling form (e.g., Dashboard)
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If upcoming.HasUpcomingRecords() Then
            Dim up As New upcoming()
            up.Show()
            Me.Close() ' close current form only if records exist
        Else
            MsgBox("No upcoming bookings found!", MsgBoxStyle.Information)
            ' Do nothing, stay on the current form
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        history.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        booking.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        about.Show()
        Me.Close()
    End Sub


    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = Nothing
        Label1.Select()
    End Sub
End Class