Public Class Form1


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btCalcular.Click
        Dim x1 As Double
        Dim x2 As Double
        Dim y1 As Double
        Dim y2 As Double

        x1 = txtX1.Text
        x2 = txtX2.Text
        y1 = txtY1.Text
        y2 = txtY2.Text

        TextBox5.Text = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 4)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btLimpiar.Click
        txtX1.Text = ""
        txtX2.Text = ""
        txtY1.Text = ""
        txtY2.Text = ""
        TextBox5.Text = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btSalir.Click

    End Sub
End Class




