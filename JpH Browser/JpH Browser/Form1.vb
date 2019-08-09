Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.ScriptErrorsSuppressed = True
    End Sub

    Sub checkAddress() Handles WebBrowser1.DocumentCompleted
        BoxAddr.Text = WebBrowser1.Url.ToString

    End Sub

    Private Sub tmStats_Tick(sender As Object, e As EventArgs) Handles tmStats.Tick
        Label1.Text = WebBrowser1.StatusText.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If WebBrowser1.CanGoBack Then
            WebBrowser1.GoBack()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If WebBrowser1.CanGoForward Then
            WebBrowser1.GoForward()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser1.Navigate(BoxAddr.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If My.Settings.SE = "Google" Then
            WebBrowser1.Navigate(My.Settings.Google + BoxSearch.Text)
        ElseIf My.Settings.SE = "Yahoo" Then
            WebBrowser1.Navigate(My.Settings.Yahoo + BoxSearch.Text)
        ElseIf My.Settings.SE = "Bing" Then
            WebBrowser1.Navigate(My.Settings.Bing + BoxSearch.Text)
        ElseIf My.Settings.SE = "DuckDuckGo" Then
            WebBrowser1.Navigate(My.Settings.DuckDuckGo + BoxSearch.Text)
        End If
    End Sub

    Private Sub BoxSearch_TextChanged(sender As Object, e As EventArgs) Handles BoxSearch.Click
        If BoxAddr.Text = "Search" Then
            BoxAddr.Text = ""
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
    End Sub

    Private Sub BoxAddr_KeyDown(sender As Object, e As KeyEventArgs) Handles BoxAddr.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            WebBrowser1.Navigate(BoxAddr.Text)
        End If
    End Sub

    Private Sub BoxSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles BoxSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If My.Settings.SE = "Google" Then
                WebBrowser1.Navigate(My.Settings.Google + BoxSearch.Text)
            ElseIf My.Settings.SE = "Yahoo" Then
                WebBrowser1.Navigate(My.Settings.Yahoo + BoxSearch.Text)
            ElseIf My.Settings.SE = "Bing" Then
                WebBrowser1.Navigate(My.Settings.Bing + BoxSearch.Text)
            ElseIf My.Settings.SE = "DuckDuckGo" Then
                WebBrowser1.Navigate(My.Settings.DuckDuckGo + BoxSearch.Text)
            End If
        End If
    End Sub


End Class
