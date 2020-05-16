Public Class Pass3

    Dim gen As String = Nothing

    Private Sub Pass3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Close()
        gen = GenerateCode()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
        RichTextBox1.Text = gen
        My.Settings.gen = gen
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Public Function GenerateCode()
        Dim intRnd As Integer
        Dim intStep As Integer = Nothing
        Dim strname As String
        Dim intlength As Integer
        Dim strinputstring As String = ""
        Dim Numbers As String = "1234567890"
        Dim Upper As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZYZ"
        Dim Symbols As String = "-=[];'#,./\~"
        Dim intnamelength As Integer = 1


        strinputstring &= Numbers
        strinputstring &= Upper
        strinputstring &= Symbols




        intlength = Len(strinputstring)



        Integer.TryParse("10", intnamelength)

        Randomize()


        strname = ""


        For inStep = 1 To intnamelength


            intRnd = Int(Rnd() * intlength) + 1


            strname = strname & Mid(strinputstring, intRnd, 1)


        Next


        Return strname

    End Function

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        If MaterialSingleLineTextField1.Text = "" Then
            MsgBox("Please enter a password")
        Else
            My.Settings.pw = MaterialSingleLineTextField1.Text
            My.Settings.Save()
            My.Settings.Reload()
            MsgBox("Password submitted to database, please login")
            Form1.Show()
            Me.Close()
        End If
    End Sub
End Class