Public Class Name_Entry_Test
    Private numOfLetters As Integer = 0
    Public theString As String = "Yellow"
    Private Sub Name_Entry_Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        theString = ""
        numOfLetters = 0
    End Sub
    Public Function getName()
        Return theString
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then

        Else
            numOfLetters += 1
            If TextBox1.Text.Length > 8 Then
                TextBox1.Text = theString
            End If
        End If
        theString = TextBox1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        numOfLetters = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Public Sub reset()
        TextBox1.Text = ""
        numOfLetters = 0
    End Sub

    Public Sub changeLabelText(ByVal newText As String)
        Label1.Text = newText
    End Sub
End Class