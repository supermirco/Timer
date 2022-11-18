Public Class Form1
    Dim x As Integer
    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAdd.Click
        x = 60
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If x > 0 Then
            LblTimer.Text = x
            x = x - 1
        Else
            LblTimer.Text = x
            Timer1.Stop()
        End If
    End Sub
End Class
