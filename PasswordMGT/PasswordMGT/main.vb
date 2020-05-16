Imports System
Imports System.IO
Imports System.Text
Imports System.Management

Public Class Main
    Dim total As String = Nothing
    Dim g As Graphics
    Dim str As String = "HARDWARE\DESCRIPTION\System\CentralProcessor"
    Dim webAddress As String = "https://diginodes.io"
    Dim cpuCount As Integer = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(str, False).SubKeyCount
    Dim cpuName As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("ProcessorNameString")






    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.gen


        NotifyIcon1.BalloonTipText = "Copied to clipboard"

        NotifyIcon1.Text = "Windows Application"
        CreateContextMenu()

        RichTextBox2.Text = My.Settings.notes
        Label7.Text = My.Settings.wrongpw
        RichTextBox1.Text = "Computer Name:  " + My.Computer.Name & vbNewLine & vbNewLine + "OS:  " + My.Computer.Info.OSFullName & vbNewLine & vbNewLine + "CPU:  " + cpuName

    End Sub

    Public Sub CreateContextMenu()

        'Define New Context Menu and Menu Item 
        Dim contextMenu As New ContextMenu
        Dim menuItem As New MenuItem("Exit")
        contextMenu.MenuItems.Add(menuItem)

        ' Associate context menu with Notify Icon 
        NotifyIcon1.ContextMenu = contextMenu

        'Add functionality for menu Item click 
        AddHandler menuItem.Click, AddressOf menuItem_Click

    End Sub

    Private Sub menuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Image = My.Resources.u5
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = My.Resources.d5
    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Image = My.Resources.u4_1
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Image = My.Resources.d4
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Image = My.Resources.u3
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources.d3
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Image = My.Resources.u2
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.d2
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = My.Resources.u1
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.d1
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel1.Show()
        Panel2.Hide()
        Panel4.Hide()
        Panel3.Hide()
        Panel5.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel2.Show()
        Panel1.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel3.Hide()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged
        My.Settings.notes = RichTextBox2.Text
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        MaterialSingleLineTextField3.PasswordChar = ""
    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton3.Click
        MaterialSingleLineTextField3.PasswordChar = "•"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Panel3.Show()
        Panel1.Hide()
        Panel2.Hide()
        Panel4.Hide()
        Panel5.Hide()
    End Sub



    Private Sub MaterialRaisedButton6_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton6.Click

        Label21.Text.Trim()
        If MaterialCheckBox1.Checked = False And MaterialCheckBox3.Checked = False And MaterialCheckBox2.Checked = False And MaterialCheckBox4.Checked = False Then
            MsgBox("You must select atleast 1 option!", MsgBoxStyle.Critical)
        End If

        If Label21.Text <= 3 Then
            MsgBox("Password Length is to low, minimum is 4!", MsgBoxStyle.Critical, )
            Exit Sub

        End If
        If Label21.Text > 20 Then
            MsgBox("Password Length is to high, max is 20!", MsgBoxStyle.Critical, )

            Exit Sub

        End If
        RichTextBox3.SelectionAlignment = HorizontalAlignment.Center
        RichTextBox3.Text = GenerateCode()
    End Sub
    Public Function GenerateCode()
        Dim intRnd As Integer
        Dim intStep As Integer = Nothing
        Dim strname As String
        Dim intlength As Integer
        Dim strinputstring As String = ""
        Dim Numbers As String = "1234567890"
        Dim Lower As String = "abcdefghijklmnopqrstuvwxyzyz"
        Dim Upper As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZYZ"
        Dim Symbols As String = "!$%@#"
        Dim intnamelength As Integer = 1


        If MaterialCheckBox3.Checked Then strinputstring &= Lower
        If MaterialCheckBox1.Checked Then strinputstring &= Numbers
        If MaterialCheckBox4.Checked Then strinputstring &= Upper
        If MaterialCheckBox2.Checked Then strinputstring &= Symbols



        intlength = Len(strinputstring)



        Integer.TryParse(Label21.Text, intnamelength)

        Randomize()


        strname = ""


        For inStep = 1 To intnamelength


            intRnd = Int(Rnd() * intlength) + 1


            strname = strname & Mid(strinputstring, intRnd, 1)


        Next


        Return strname

    End Function

    Private Sub RichTextBox3_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox3.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub MaterialRaisedButton4_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton4.Click
        Label21.Text += 1
        If Label21.Text = "10" Then
            Label21.Location = New Point(2, 7)
        End If
    End Sub

    Private Sub MaterialRaisedButton5_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton5.Click
        Label21.Text -= 1
        If Label21.Text = "9" Then
            Label21.Location = New Point(5, 7)
        End If
    End Sub

    Private Sub MaterialRaisedButton7_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton7.Click
        If RichTextBox3.Text = "" Then
            MsgBox("Error")
        Else
            MsgBox("Copied to clipboard")
            Clipboard.SetText(RichTextBox3.Text)
            NotifyIcon1.ShowBalloonTip(5000)
        End If
    End Sub

    Private Sub MaterialRaisedButton8_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton8.Click
        RichTextBox3.Text = ""
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Panel4.Show()
        Panel1.Hide()
        Panel2.Hide()
        Panel3.Hide()
        Panel5.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Process.Start(webAddress)
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

    End Sub

    Private Sub MaterialRaisedButton10_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton10.Click
        TextBox1.PasswordChar = ""
    End Sub

    Private Sub MaterialRaisedButton9_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton9.Click
        TextBox1.PasswordChar = "•"
    End Sub

    Private Sub MaterialRaisedButton47_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton47.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub MaterialRaisedButton46_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton46.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub MaterialRaisedButton45_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton45.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub MaterialRaisedButton44_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton44.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub MaterialRaisedButton43_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton43.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub MaterialRaisedButton42_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton42.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub MaterialRaisedButton41_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton41.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub MaterialRaisedButton40_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton40.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub MaterialRaisedButton39_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton39.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub MaterialRaisedButton38_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton38.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub MaterialRaisedButton37_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton37.Click
        TextBox1.Text = TextBox1.Text + "-"
    End Sub

    Private Sub MaterialRaisedButton36_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton36.Click
        TextBox1.Text = TextBox1.Text + "="
    End Sub

    Private Sub MaterialRaisedButton12_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton12.Click
        TextBox1.Text = TextBox1.Text + "Q"
    End Sub

    Private Sub MaterialRaisedButton13_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton13.Click
        TextBox1.Text = TextBox1.Text + "W"
    End Sub

    Private Sub MaterialRaisedButton14_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton14.Click
        TextBox1.Text = TextBox1.Text + "E"
    End Sub

    Private Sub MaterialRaisedButton15_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton15.Click
        TextBox1.Text = TextBox1.Text + "R"
    End Sub

    Private Sub MaterialRaisedButton16_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton16.Click
        TextBox1.Text = TextBox1.Text + "T"
    End Sub

    Private Sub MaterialRaisedButton17_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton17.Click
        TextBox1.Text = TextBox1.Text + "Y"
    End Sub

    Private Sub MaterialRaisedButton18_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton18.Click
        TextBox1.Text = TextBox1.Text + "U"
    End Sub

    Private Sub MaterialRaisedButton19_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton19.Click
        TextBox1.Text = TextBox1.Text + "I"
    End Sub

    Private Sub MaterialRaisedButton20_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton20.Click
        TextBox1.Text = TextBox1.Text + "O"
    End Sub

    Private Sub MaterialRaisedButton21_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton21.Click
        TextBox1.Text = TextBox1.Text + "P"
    End Sub

    Private Sub MaterialRaisedButton22_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton22.Click
        TextBox1.Text = TextBox1.Text + "["
    End Sub

    Private Sub MaterialRaisedButton23_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton23.Click
        TextBox1.Text = TextBox1.Text + "]"
    End Sub

    Private Sub MaterialRaisedButton35_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton35.Click
        TextBox1.Text = TextBox1.Text + "A"
    End Sub

    Private Sub MaterialRaisedButton34_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton34.Click
        TextBox1.Text = TextBox1.Text + "S"
    End Sub

    Private Sub MaterialRaisedButton33_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton33.Click
        TextBox1.Text = TextBox1.Text + "D"
    End Sub

    Private Sub MaterialRaisedButton32_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton32.Click
        TextBox1.Text = TextBox1.Text + "F"
    End Sub

    Private Sub MaterialRaisedButton31_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton31.Click
        TextBox1.Text = TextBox1.Text + "G"
    End Sub

    Private Sub MaterialRaisedButton30_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton30.Click
        TextBox1.Text = TextBox1.Text + "H"
    End Sub

    Private Sub MaterialRaisedButton29_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton29.Click
        TextBox1.Text = TextBox1.Text + "J"
    End Sub

    Private Sub MaterialRaisedButton28_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton28.Click
        TextBox1.Text = TextBox1.Text + "K"
    End Sub

    Private Sub MaterialRaisedButton27_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton27.Click
        TextBox1.Text = TextBox1.Text + "L"
    End Sub

    Private Sub MaterialRaisedButton26_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton26.Click
        TextBox1.Text = TextBox1.Text + ";"
    End Sub

    Private Sub MaterialRaisedButton25_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton25.Click
        TextBox1.Text = TextBox1.Text + "'"
    End Sub

    Private Sub MaterialRaisedButton24_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton24.Click
        TextBox1.Text = TextBox1.Text + "#"
    End Sub

    Private Sub MaterialRaisedButton59_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton59.Click
        TextBox1.Text = TextBox1.Text + "\"
    End Sub

    Private Sub MaterialRaisedButton58_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton58.Click
        TextBox1.Text = TextBox1.Text + "Z"
    End Sub

    Private Sub MaterialRaisedButton57_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton57.Click
        TextBox1.Text = TextBox1.Text + "X"
    End Sub

    Private Sub MaterialRaisedButton56_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton56.Click
        TextBox1.Text = TextBox1.Text + "C"
    End Sub

    Private Sub MaterialRaisedButton55_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton55.Click
        TextBox1.Text = TextBox1.Text + "V"
    End Sub

    Private Sub MaterialRaisedButton54_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton54.Click
        TextBox1.Text = TextBox1.Text + "B"
    End Sub

    Private Sub MaterialRaisedButton53_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton53.Click
        TextBox1.Text = TextBox1.Text + "N"
    End Sub

    Private Sub MaterialRaisedButton52_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton52.Click
        TextBox1.Text = TextBox1.Text + "M"
    End Sub

    Private Sub MaterialRaisedButton51_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton51.Click
        TextBox1.Text = TextBox1.Text + ","
    End Sub

    Private Sub MaterialRaisedButton50_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton50.Click
        TextBox1.Text = TextBox1.Text + "."
    End Sub

    Private Sub MaterialRaisedButton49_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton49.Click
        TextBox1.Text = TextBox1.Text + "/"
    End Sub

    Private Sub MaterialRaisedButton48_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton48.Click
        TextBox1.Text = TextBox1.Text + "~"
    End Sub

    Private Sub MaterialRaisedButton11_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton11.Click
        If TextBox1.Text = My.Settings.gen Then
            MsgBox("Right Password")
        Else
            MsgBox("Wrong password")
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Panel5.Show()
        Panel1.Hide()
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class