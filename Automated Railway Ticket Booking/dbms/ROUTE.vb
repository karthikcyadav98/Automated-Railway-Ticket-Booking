Public Class ROUTE
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Dim rs1 As New ADODB.Recordset
    Dim rs2 As New ADODB.Recordset
    Private Sub ROUTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("DBMS", "system", "tiger")
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        _1.Show()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RichTextBox2.Text = Nothing And RichTextBox1.Text <> Nothing Then
            rs1.Open("select * from TRAIN_INFO, ROUTE WHERE R_ID= '" & RichTextBox1.Text & "' AND (ROUTE.T_NUMBER = TRAIN_INFO.TRAIN_NUMBER)  ", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            TextBox1.Text = rs1.Fields(0).Value
            TextBox2.Text = rs1.Fields(1).Value

        ElseIf RichTextBox1.Text = Nothing And RichTextBox2.Text <> Nothing Then
            rs.Open("select * from TRAIN_INFO, ROUTE WHERE PICK_UP_POINT = '" & RichTextBox2.Text & "' AND (ROUTE.T_NUMBER = TRAIN_INFO.TRAIN_NUMBER) ", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            TextBox1.Text = rs.Fields(0).Value
            TextBox2.Text = rs.Fields(1).Value

        ElseIf RichTextBox1.Text = Nothing And RichTextBox2.Text = Nothing Then
            MsgBox("FIELDS CANNOT BE LEFT EMPTY")

        Else
            rs2.Open("select * from TRAIN_INFO, ROUTE WHERE R_ID= '" & RichTextBox1.Text & "' AND PICK_UP_POINT = '" & RichTextBox2.Text & "' AND (ROUTE.T_NUMBER = TRAIN_INFO.TRAIN_NUMBER) ", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            TextBox1.Text = rs2.Fields(0).Value
            TextBox2.Text = rs2.Fields(1).Value

        End If
        RichTextBox1.Clear()
        RichTextBox2.Clear()
    End Sub
End Class