Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.SE = "Google" Then
            RadioButton1.Checked = True
        ElseIf My.Settings.SE = "Yahoo" Then
            RadioButton2.Checked = True
        ElseIf My.Settings.SE = "Bing" Then
            RadioButton3.Checked = True
        ElseIf My.Settings.SE = "DuckDuckGo" Then
            RadioButton4.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            My.Settings.SE = "Google"
        ElseIf RadioButton2.Checked = True Then
            My.Settings.SE = "Yahoo"
        ElseIf RadioButton3.Checked = True Then
            My.Settings.SE = "Bing"
        ElseIf RadioButton4.Checked = True Then
            My.Settings.SE = "DuckDuckGo"
        End If
        My.Settings.Save()
        My.Settings.Reload()

        Me.Close()

    End Sub
End Class