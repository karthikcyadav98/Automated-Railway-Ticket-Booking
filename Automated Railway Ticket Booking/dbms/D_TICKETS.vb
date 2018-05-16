Public Class D_TICKETS
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Dim rs1 As New ADODB.Recordset

    Private Sub D_TICKETS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("DBMS", "system", "tiger")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = Nothing Or TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("FIELDS CAN'T BE LEFT EMPTY")
        Else
            rs.Open("SELECT * FROM RESERVDB WHERE RDATE = '" & ComboBox1.Text & "' ", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            TextBox4.Text = 100 - rs.Fields(1).Value
            rs1.Open("SELECT * FROM TRAIN_INFO WHERE S_FROM = '" & TextBox1.Text & "' AND DESTINATION = '" & TextBox2.Text & "' ", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            TextBox6.Text = rs1.Fields(0).Value
            TextBox3.Text = rs1.Fields(1).Value
            TextBox5.Text = rs1.Fields(3).Value
            TextBox7.Text = rs1.Fields(4).Value
            TextBox8.Text = rs1.Fields(2).Value
            TextBox9.Text = rs1.Fields(8).Value
        End If
    End Sub
End Class