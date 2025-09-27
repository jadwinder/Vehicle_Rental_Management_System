Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class add
    Dim cmd As OleDbCommand
    Dim que As String
    Dim numValidation As Regex = New Regex("^[\d]+$")
    Dim acValidation As Regex = New Regex("^(Yes|No)$")
    Dim rcvalidation As Regex = New Regex("^[a-zA-Z]{2}[\d]{2}[a-zA-Z]{2}[\d]{4}$")
    Dim fuelValidation As Regex = New Regex("^(Petrol|CNG|Diesel)$")
    Dim categoryValidation As Regex = New Regex("^(Luxury|SUV|Economical)$")

    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + connectionStr.con_str())

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Not validate_fields() Then
            Exit Sub
        End If

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        que = "INSERT INTO add_table(Car_name, Car_model, Luggage, Fuel, Car_category, Seats, RC, Engine, AC , Chaise, Rent) VALUES(@name, @model, @luggage, @fuel, @category, @seats, @rc, @engine, @ac, @chaise, @rent)"
        cmd = New OleDbCommand(que, conn)
        cmd.Parameters.AddWithValue("@name", TextBox1.Text)
        cmd.Parameters.AddWithValue("@model", TextBox2.Text)
        cmd.Parameters.AddWithValue("@luggage", TextBox3.Text)
        cmd.Parameters.AddWithValue("@fuel", ComboBox1.Text)
        cmd.Parameters.AddWithValue("@category", ComboBox3.Text)
        cmd.Parameters.AddWithValue("@seats", TextBox6.Text)
        cmd.Parameters.AddWithValue("@rc", TextBox7.Text)
        cmd.Parameters.AddWithValue("@engine", TextBox8.Text)
        cmd.Parameters.AddWithValue("@ac", ComboBox2.Text)
        cmd.Parameters.AddWithValue("@chaise", TextBox10.Text)
        cmd.Parameters.AddWithValue("@rent", TextBox11.Text)

        If cmd.ExecuteNonQuery Then
            MsgBox("Sucess")
            clear_fields()
        Else
            MsgBox("Error")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clear_fields()
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

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        search.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        dashboard.Show()
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

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        history.Show()
        Me.Close()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        booking.Show()
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        upcoming.Show()
        Me.Close()
    End Sub

    Private Function validate_fields()
        Dim nameField As String = TextBox1.Text
        Dim modelField As String = TextBox2.Text
        Dim luggageField As String = TextBox3.Text
        Dim fuelField As String = ComboBox1.Text
        Dim categoryField As String = ComboBox2.Text
        Dim seatsFields As String = TextBox6.Text
        Dim rcField As String = TextBox7.Text
        Dim engineField As String = TextBox8.Text
        Dim acField As String = ComboBox3.Text
        Dim chaiseField As String = TextBox10.Text
        Dim rentField As String = TextBox11.Text

        If nameField = vbNullString Or modelField = vbNullString Or luggageField = vbNullString Or fuelField = vbNullString Or categoryField = vbNullString Or seatsFields = vbNullString Or rcField = vbNullString Or engineField = vbNullString Or acField = vbNullString Or chaiseField = vbNullString Or rentField = vbNullString Then
            MsgBox("Error! All fields are required.", MsgBoxStyle.Critical, "Wheels 4 U")
            Return False
        End If

        If Not fuelValidation.IsMatch(fuelField) Then
            MsgBox("Fuel Type must be Petrol | Diesel| CNG", MsgBoxStyle.Critical, "Wheels 4 U")
            Return False
        End If

        If Not categoryValidation.IsMatch(categoryField) Then
            MsgBox("Category must be of Luxury | SUV | Economical Type", MsgBoxStyle.Information, "Wheels 4 U")
            Return False
        End If

        If Not numValidation.IsMatch(seatsFields) Then
            MsgBox("Seats must be in Digit [0-9]", MsgBoxStyle.Information, "Wheels 4 U")
            Return False
        End If

        If Not rcvalidation.IsMatch(rcField) Then
            MsgBox("RC number must be of proper format eg. PB10XX9999", MsgBoxStyle.Information, "Wheels 4 U")
            Return False
        End If

        If Not acValidation.IsMatch(acField) Then
            MsgBox("AC value must be in Yes or No", MsgBoxStyle.Information, "Wheels 4 U")
            Return False
        End If

        If Not numValidation.IsMatch(rentField) Then
            MsgBox("Rent must be in Digits [0-9]", MsgBoxStyle.Information, "Wheels 4 U")
            Return False
        End If

        Return True
    End Function

    Private Sub clear_fields()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.ResetText()
        ComboBox3.ResetText()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        ComboBox2.ResetText()
        TextBox10.Clear()
        TextBox11.Clear()
    End Sub
End Class

