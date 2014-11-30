Public Class Form1

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://google.com")
    End Sub

    Private Sub WebBrowser1_DocumentTitleChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.Text = WebBrowser1.DocumentTitle
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myTabPage As New TabPage()
        myTabPage.Text = "TabPage " & (TabControl1.TabPages.Count + 1)
        TabControl1.TabPages.Add(myTabPage)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub
End Class
