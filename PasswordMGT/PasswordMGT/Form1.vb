Imports System.IO
Imports MaterialSkin
Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.firstime1 = True Then
            Pass3.Show()
            My.Settings.firstime1 = False
            My.Settings.Save()
            My.Settings.Reload()
            Me.Close()
        End If
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue400, Primary.Blue600, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub MaterialRadioButton1_CheckedChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        If MaterialSingleLineTextField2.Text = My.Settings.pw Then
            Main.Show()
            Me.Close()
        Else
            My.Settings.Save()
            My.Settings.Reload()
            MsgBox("Wrong Password")
        End If
    End Sub

End Class