﻿Public Class dashboard



    Private Sub Label5_Click(sender As Object, e As EventArgs)
        cars.Show()
    End Sub

 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cars.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        weddingcars.show()
        Me.Hide()
    End Sub

   
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lux.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        suvs.Show()
        Me.Hide()
    End Sub
End Class