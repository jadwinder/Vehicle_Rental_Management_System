Imports System.Data.OleDb

Public Class search
    Dim cmd As OleDbCommand
    Dim que As String
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + connectionStr.con_str())




    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim val As String = ""
        Dim row As String()
        Dim table As New DataTable("cars")
        table.Columns.Add("Car Name")
        table.Columns.Add("Model")
        table.Columns.Add("Luggage")
        table.Columns.Add("Fuel Type")
        table.Columns.Add("Category")
        table.Columns.Add("NoOfSeats")
        table.Columns.Add("RC number")
        table.Columns.Add("Engine No")
        table.Columns.Add("Chaise No")
        table.Columns.Add("Rent")

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
            Dim res As Object = cmd.ExecuteReader()
            While res.Read()
                row = New String() {res.Item(1), res.Item(2), res.Item(3), res.Item(4), res.Item(5), res.Item(6), res.Item(7), res.Item(8), res.Item(10), res.Item(11)}
                table.Rows.Add(row)
            End While
        Else
            MsgBox("No result found!", MsgBoxStyle.Information)
            DataGridView1.DataSource = vbNull
            TextBox1.Clear()
            TextBox2.Clear()
            Exit Sub
        End If

        DataGridView1.DataSource = table
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

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        Login_form.Show()
        Me.Close()
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        add.Show()
        Me.Close()
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click
        delete.Show()
        Me.Close()
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        updateCars.Show()
        Me.Close()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        history.Show()
        Me.Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        booking.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
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

    
    Private Sub search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class