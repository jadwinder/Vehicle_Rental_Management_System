Public Class Loader
    Private Sub Loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start() ' Start the loading process
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop() ' Stop the timer when loading is complete

        ' Open the Dashboard form
        Dim dashboardForm As New Dashboard()
        dashboard.Show()

        ' Close the Loader form
        Me.Close()
    End Sub
End Class
