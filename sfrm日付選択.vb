Imports System.Windows.Forms

Public Class sfrm日付選択
    '選択日付
    Private pro日付 As String
    Public Property 日付() As String
        Get
            Return pro日付
        End Get
        Set(ByVal value As String)
            pro日付 = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        pro日付 = ""

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub mcl日付_DateSelected(sender As Object, e As DateRangeEventArgs) Handles mcl日付.DateSelected
        pro日付 = mcl日付.SelectionStart.ToString("yyyy/MM/dd")
        Call Me.Close()
    End Sub
End Class
