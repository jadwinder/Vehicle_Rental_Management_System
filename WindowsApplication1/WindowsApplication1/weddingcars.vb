Public Class weddingcars


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        amaze.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vitara.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        delta.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        cars.Show()
        Me.Hide()
    End Sub

    Private Sub weddingcars_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class