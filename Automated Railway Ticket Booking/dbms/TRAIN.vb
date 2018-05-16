Public Class TRAIN
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Dim rs1 As New ADODB.Recordset
    Dim rs2 As New ADODB.Recordset
    Private Sub RichTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RichTextBox2.Text = Nothing And RichTextBox1.Text <> Nothing Then
            rs1.Open("select * from TRAIN_INFO WHERE TRAIN_NUMBER= '" & RichTextBox1.Text & "' ", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            TextBox1.Text = rs1.Fields(6).Value
            TextBox2.Text = rs1.Fields(5).Value
            TextBox3.Text = rs1.Fields(3).Value
            TextBox4.Text = rs1.Fields(4).Value
            TextBox5.Text = rs1.Fields(2).Value

        ElseIf RichTextBox1.Text = Nothing And RichTextBox2.Text <> Nothing Then
            rs.Open("select * from TRAIN_INFO WHERE TRAIN_NAME = '" & RichTextBox2.Text & "' ", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            TextBox1.Text = rs.Fields(6).Value
            TextBox2.Text = rs.Fields(5).Value
            TextBox3.Text = rs.Fields(3).Value
            TextBox4.Text = rs.Fields(4).Value
            TextBox5.Text = rs.Fields(2).Value

        ElseIf RichTextBox1.Text = Nothing And RichTextBox2.Text = Nothing Then
            MsgBox("FIELDS CANNOT BE LEFT EMPTY")

        Else
            rs2.Open("select * from TRAIN_INFO WHERE TRAIN_NUMBER= '" & RichTextBox1.Text & "' AND TRAIN_NAME= '" & RichTextBox2.Text & "' ", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            TextBox1.Text = rs2.Fields(6).Value
            TextBox2.Text = rs2.Fields(5).Value
            TextBox3.Text = rs2.Fields(3).Value
            TextBox4.Text = rs2.Fields(4).Value
            TextBox5.Text = rs2.Fields(2).Value

        End If
        RichTextBox1.Clear()
        RichTextBox2.Clear()
    End Sub

    Private Sub t_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("DBMS", "system", "tiger")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        _1.Show()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
End Class