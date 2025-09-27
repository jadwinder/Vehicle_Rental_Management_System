Imports System.Data.OleDb

Public Class booking
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + connectionStr.con_str())
    Dim cmd As OleDbCommand
    Dim que As String

    Private Sub booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox8.ReadOnly = True
        TextBox9.ReadOnly = True
        Label14.Visible = False
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        que = "SELECT * FROM add_table WHERE RC=@no"
        cmd = New OleDbCommand(que, conn)
        cmd.Parameters.AddWithValue("@no", TextBox1.Text)

        Dim res As OleDbDataReader = cmd.ExecuteReader()
        If res.HasRows Then
            While res.Read()
                TextBox8.Text = res.Item(1).ToString()
                TextBox9.Text = res.Item(5).ToString()
                Label14.Text = "Rent Rs. " + res.Item(11).ToString()
            End While
            Label14.Visible = True
        Else
            Label14.Visible = False
            TextBox8.Clear()
            TextBox9.Clear()
        End If
        res.Close()
    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        ' Trim all inputs before validation
        Dim email As String = TextBox3.Text.Trim()
        Dim phone As String = TextBox4.Text.Trim()

        ' Check for empty fields
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
           String.IsNullOrWhiteSpace(email) OrElse
           String.IsNullOrWhiteSpace(phone) OrElse
           String.IsNullOrWhiteSpace(TextBox5.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox6.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox7.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox8.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox9.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox10.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox11.Text) Then

            MsgBox("Please fill all required fields correctly.", MsgBoxStyle.OkCancel, "Wheels 4 U")
            Exit Sub
        End If

        ' Validate email format
        If Not email.Contains("@") OrElse Not email.Contains(".") OrElse
           email.StartsWith("@") OrElse email.EndsWith("@") Then

            MsgBox("Invalid email address format! It should be username@domain.com", MsgBoxStyle.Critical, "Wheels 4 U")
            Exit Sub
        End If

        ' Validate phone number: numeric and at least 10 digits
        If Not IsNumeric(phone) OrElse phone.Length < 10 Then
            MsgBox("Please fill phone number correctly. ", MsgBoxStyle.Critical, "Wheels 4 U")
            Exit Sub
        End If



        ' All validations passed, proceed with database insert
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            que = "INSERT INTO Booking_table(CName, Email, Phone_No, Address, City, State, RcNo, VehicleName, VehicleType, Pick_up_date, Drop_off_date, Pickup_location, Drop_off_location) " &
                  "VALUES(@cname, @email, @phoneno, @addr, @city, @state, @rc, @vehiclename, @vehicletype, @pickupdate, @dropoffdate, @pickuploc, @dropoffloc)"
            cmd = New OleDbCommand(que, conn)

            cmd.Parameters.AddWithValue("@cname", TextBox2.Text)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@phoneno", phone)
            cmd.Parameters.AddWithValue("@addr", TextBox5.Text)
            cmd.Parameters.AddWithValue("@city", TextBox6.Text)
            cmd.Parameters.AddWithValue("@state", TextBox7.Text)
            cmd.Parameters.AddWithValue("@rc", TextBox1.Text)
            cmd.Parameters.AddWithValue("@vehiclename", TextBox8.Text)
            cmd.Parameters.AddWithValue("@vehicletype", TextBox9.Text)
            cmd.Parameters.AddWithValue("@pickupdate", Format(DateTimePicker1.Value, "MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@dropoffdate", Format(DateTimePicker2.Value, "MM/dd/yyyy"))
            cmd.Parameters.AddWithValue("@pickuploc", TextBox10.Text)
            cmd.Parameters.AddWithValue("@dropoffloc", TextBox11.Text)

            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Booking successful!", MsgBoxStyle.Information, "Wheels 4 U")
                dashboard.Show()
                Me.Close()
            Else
                MsgBox("Error occurred while booking.", MsgBoxStyle.Critical, "Wheels 4 U")
            End If

        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub



    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        dashboard.Show()
        Me.Close()
    End Sub


End Class
