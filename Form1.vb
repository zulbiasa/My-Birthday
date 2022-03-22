Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Your birth date was " & DateTimePicker1.Text)
        MsgBox("Day of the year: " &
        DateTimePicker1.Value.DayOfYear.ToString())
        MsgBox("Today is " & DateTimePicker1.Value.Now.ToString())
    End Sub
End Class
