Public Class Form1
    Dim hr, min, sec, mili As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Button2.Enabled = True
        Button3.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Button1.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        milisecond.Text = "0"
        second.Text = "0"
        minute.Text = "0"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        milisecond.Text += 1
        If milisecond.Text > 99 Then
            second.Text += 1
            milisecond.Text = 0
        End If

        If second.Text = 60 Then
            minute.Text += 1
            second.Text = 0
        End If

        If minute.Text = 60 Then
            hour.Text += 1
            minute.Text = 0
        End If

    End Sub

End Class
