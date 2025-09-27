Imports System.Data.OleDb

Public Class upcoming
    Dim cmd As OleDbCommand
    Dim que As String
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + connectionStr.con_str())

    ' Function to check if there are any upcoming records
    Public Shared Function HasUpcomingRecords() As Boolean
        Dim result As Boolean = False
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + connectionStr.con_str())
        Try
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM Booking_table WHERE pick_up_date >= date()"
            Dim cmd As New OleDbCommand(query, conn)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            result = (count > 0)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
        Return result
    End Function

    Private Sub upcoming_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        table.Columns.Add("Dropoff Location")

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            que = "SELECT * FROM Booking_table WHERE pick_up_date >= date()"
            cmd = New OleDbCommand(que, conn)
            Dim res As OleDbDataReader = cmd.ExecuteReader()

            If res.HasRows Then
                While res.Read()
                    Dim row As String() = {res.Item(1).ToString(), res.Item(2).ToString(), res.Item(3).ToString(),
                                           res.Item(4).ToString(), res.Item(5).ToString(), res.Item(6).ToString(),
                                           res.Item(7).ToString(), res.Item(8).ToString(), res.Item(9).ToString(),
                                           res.Item(10).ToString(), res.Item(11).ToString(), res.Item(12).ToString(),
                                           res.Item(13).ToString()}
                    table.Rows.Add(row)
                End While
            Else
                MsgBox("No upcoming bookings found!", MsgBoxStyle.Information)
                Me.Close() ' Ensure this is removed if you don't want the form to close
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try

        DataGridView1.DataSource = table
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        dashboard.Show()
        Me.Close()
    End Sub
End Class


