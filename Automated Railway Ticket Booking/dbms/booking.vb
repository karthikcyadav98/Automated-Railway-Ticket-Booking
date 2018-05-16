Public Class booking
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub booking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("DBMS", "system", "tiger")
        TextBox1.Text = RESERVATION.TextBox6.Text
        TextBox2.Text = RESERVATION.TextBox3.Text
        TextBox3.Text = RESERVATION.TextBox9.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Tickets Booked")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        RESERVATION.Show()
    End Sub
End Class