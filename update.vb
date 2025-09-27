Imports System.Data.OleDb
Public Class updateCars
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + connectionStr.con_str())
    Dim cmd As OleDbCommand
    Dim que As String

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click


        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        que = "UPDATE add_table SET Car_name = @name, Car_model = @model, Luggage = @luggage, Fuel = @fuel, Car_category = @category, Seats = @seats, Engine = @engine, AC = @ac, Chaise = @chaise, Rent = @rent WHERE RC = @rc"
        cmd = New OleDbCommand(que, conn)
        cmd.Parameters.AddWithValue("@name", TextBox2.Text)
        cmd.Parameters.AddWithValue("@model", TextBox3.Text)
        cmd.Parameters.AddWithValue("@luggage", TextBox4.Text)
        cmd.Parameters.AddWithValue("@fuel", ComboBox2.Text)
        cmd.Parameters.AddWithValue("@category", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@seats", TextBox7.Text)
        cmd.Parameters.AddWithValue("@engine", TextBox8.Text)
        cmd.Parameters.AddWithValue("@ac", ComboBox3.Text)
        cmd.Parameters.AddWithValue("@chaise", TextBox10.Text)
        cmd.Parameters.AddWithValue("@rent", TextBox11.Text)
        cmd.Parameters.AddWithValue("@rc", TextBox1.Text)

        If cmd.ExecuteNonQuery Then
            MsgBox("Sucess")
            clear_fields()
        Else
            MsgBox("Error")
        End If


    End Sub



    Private Sub TextBox6_KeyUp(sender As Object, e As EventArgs) Handles TextBox1.KeyUp
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        que = "SELECT * FROM add_table WHERE RC=@no"
        cmd = New OleDbCommand(que, conn)
        cmd.Parameters.AddWithValue("@no", TextBox1.Text)

        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        If count > 0 Then
            Dim res As Object = cmd.ExecuteReader()
            While res.Read()
                TextBox2.Text = res.Item(1)
                TextBox3.Text = res.Item(2)
                TextBox4.Text = res.Item(3)
                ComboBox1.Text = res.Item(4)
                ComboBox2.Text = res.Item(5)
                TextBox7.Text = res.Item(6)
                TextBox8.Text = res.Item(7)
                ComboBox3.Text = res.Item(9)
                TextBox10.Text = res.Item(10)
                TextBox11.Text = res.Item(11)
            End While
        Else
            clear_fields()
        End If

    End Sub

    Private Sub clear_fields()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        TextBox7.Clear()
        TextBox8.Clear()
        ComboBox3.ResetText()
        TextBox10.Clear()
        TextBox11.Clear()
    End Sub

    Private Sub Label27_Click_1(sender As Object, e As EventArgs)
        dashboard.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        Login_form.Show()
        Me.Close()
    End Sub

   
    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        search.Show()
        Me.Close()
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        delete.Show()
        Me.Close()
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click
        add.Show()
        Me.Close()
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        history.Show()
        Me.Close()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        booking.Show()
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        If upcoming.HasUpcomingRecords() Then
            Dim up As New upcoming()
            up.Show()
            Me.Close() ' close current form only if records exist
        Else
            MsgBox("No upcoming bookings found!", MsgBoxStyle.Information)
            ' Do nothing, stay on the current form
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        dashboard.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles PictureBox7.Click
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

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click
        about.Show()
        Me.Close()
    End Sub
End Class