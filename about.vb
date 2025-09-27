Public Class about

    ' Structure to hold car details
    Private Structure Car
        Dim ImagePath As String
        Dim Price As String
        Dim Model As String
        Dim Doors As String
        Dim Seats As String
        Dim AirConditioning As String
        Dim Fuel As String
        Dim Logo As String
    End Structure

    ' Array of car details
    Private cars As Car() = {
    New Car With {.ImagePath = "scorpioN.png", .Price = "Rs. 5,000 per day", .Model = "2024", .Doors = "5", .Seats = "7", .AirConditioning = "Yes", .Fuel = "Diesel", .Logo = "scorpioN_logo.png"},
    New Car With {.ImagePath = "ciaz.jpg", .Price = "Rs. 2,500 per day", .Model = "2025", .Doors = "4", .Seats = "5", .AirConditioning = "Yes", .Fuel = "Petrol", .Logo = "ciaz_logo.png"},
    New Car With {.ImagePath = "xuv700.png", .Price = "Rs. 5,000 per day", .Model = "2025", .Doors = "5", .Seats = "7", .AirConditioning = "Yes", .Fuel = "Diesel", .Logo = "xuv700_logo.jpg"},
    New Car With {.ImagePath = "thar.png", .Price = "Rs. 4,000 per day", .Model = "2022", .Doors = "3", .Seats = "5", .AirConditioning = "Yes", .Fuel = "Petrol/Diesel", .Logo = "thar_logo.jpg"},
    New Car With {.ImagePath = "fortuner.jpg", .Price = "Rs. 4,000 per day", .Model = "2022", .Doors = "5", .Seats = "7", .AirConditioning = "Yes", .Fuel = "Diesel", .Logo = "fortuner_logo.png"}
}


    Private currentIndex As Integer = 0

    ' Update the image and details
    Private Sub UpdateCarDetails()
        PictureBox1.Image = Image.FromFile(cars(currentIndex).ImagePath)
        LabelPrice.Text = cars(currentIndex).Price
        LabelModel.Text = cars(currentIndex).Model
        LabelDoors.Text = cars(currentIndex).Doors
        LabelSeats.Text = cars(currentIndex).Seats
        LabelAirConditioning.Text = cars(currentIndex).AirConditioning
        LabelFuel.Text = cars(currentIndex).Fuel
        PictureBox3.Image = Image.FromFile(cars(currentIndex).Logo)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateCarDetails()
    End Sub

    ' Event handler for the left arrow button
    Private Sub Left_button_Click(sender As Object, e As EventArgs) Handles Left_button.Click
        currentIndex -= 1
        If currentIndex < 0 Then
            currentIndex = cars.Length - 1
        End If
        UpdateCarDetails()
    End Sub

    ' Event handler for the right arrow button
    Private Sub Right_button_Click(sender As Object, e As EventArgs) Handles Right_button.Click
        currentIndex += 1
        If currentIndex >= cars.Length Then
            currentIndex = 0
        End If
        UpdateCarDetails()
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
End Class
