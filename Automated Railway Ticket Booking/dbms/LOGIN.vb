Public Class login
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open("DBMS", "system", "tiger")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As Boolean = False
        rs.Open("SELECT * FROM LOGIN1", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        While rs.EOF = False
            If rs.Fields(0).Value = TextBox1.Text Then
                If rs.Fields(1).Value = TextBox2.Text Then
                    x = True
                    Me.Hide()
                    _1.Show()
                End If
            End If
            rs.MoveNext()
        End While
        If x = False Then
            MsgBox("INCORRECT USERNAME OR PASSWORD")
        End If
        rs.Close()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con.Close()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = Nothing And TextBox2.Text <> Nothing Then

            MsgBox("ENTER USERNAME")


        ElseIf TextBox1.Text <> Nothing And TextBox2.Text = Nothing Then

            MsgBox("ENTER PASSWORD")

        ElseIf TextBox1.Text = Nothing And TextBox2.Text = Nothing Then

            MsgBox("FIELDS CANNOT BE LEFT EMPTY")

        Else

            rs.Open("INSERT INTO LOGIN1 VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "') ", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            MsgBox("SUCCESSFULLY CREATED")

        End If
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
