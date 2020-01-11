Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If screen.Text = "0" Then
            screen.Text = "1"
        Else
            screen.Text = screen.Text & "1"

        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If screen.Text = "0" Then
            screen.Text = "2"
        Else
            screen.Text = screen.Text & "2"

        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If screen.Text = "0" Then
            screen.Text = "3"
        Else
            screen.Text = screen.Text & "3"

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If screen.Text = "0" Then
            screen.Text = "4"
        Else
            screen.Text = screen.Text & "4"

        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If screen.Text = "0" Then
            screen.Text = "5"
        Else
            screen.Text = screen.Text & "5"

        End If
    End Sub
End Class
