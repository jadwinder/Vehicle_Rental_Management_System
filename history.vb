Imports System.Data.OleDb

Public Class history
    Dim cmd As OleDbCommand
    Dim que As String
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + connectionStr.con_str())

    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim val As String = ""
        Dim row As String()
        Dim table As New DataTable("cars")
        table.Columns.Add("Customer Name")
        table.Columns.Add("Email")
        table.Columns.Add("Phone No")
        table.Columns.Add("Address")
        table.Columns.Add("City")
        table.Columns.Add("State")
        table.Columns.Add("RC No")
        table.Columns.Add("Vehicle Name")
        table.Columns.Add("Vehicle Type")
        table.Columns.Add("Pickup Date")
        table.Columns.Add("Dropoff Date")
        table.Columns.Add("Pickup Location")
        table.Columns.Add("Dopoff Location")

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        que = "SELECT * FROM Booking_table WHERE pick_up_date < date()"
        cmd = New OleDbCommand(que, conn)
        cmd.Parameters.AddWithValue("@no", val)

        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        If count > 0 Then
            Dim res As Object = cmd.ExecuteReader()
            While res.Read()
                row = New String() {res.Item(1), res.Item(2), res.Item(3), res.Item(4), res.Item(5), res.Item(6), res.Item(7), res.Item(8), res.Item(9), res.Item(10), res.Item(11), res.Item(12), res.Item(13)}
                table.Rows.Add(row)
            End While
        Else
            MsgBox("No result found!", MsgBoxStyle.Information)
            DataGridView1.DataSource = vbNull
            Exit Sub
        End If

        DataGridView1.DataSource = table
    End Sub




    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        dashboard.Show()
        Me.Close()
    End Sub
End Class