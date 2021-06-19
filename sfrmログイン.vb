Imports System.Windows.Forms
Imports System.Text.RegularExpressions  ''正規表現

Imports System.Data
Imports System.Data.SqlClient

Public Class sfrmログイン

    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Private Sub sfrm出勤確認_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblメッセージ.Text = ""
    End Sub

    Private Function subログイン() As Boolean
        Dim str_CheckPassword As String = Now.Date.ToString("yyyyMMdd").Substring(7, 1)
        Dim str_InputPassword As String = txtパスワード.Text

        'パスワード大文字・小文字判別チェック
        If String.Compare(str_CheckPassword, str_InputPassword, True) = 0 Then
            '認証ＯＫ
            Return True

        Else
            '認証ＮＧ
            lblメッセージ.Text = "会員ID、または、パスワードに誤りがあります。"
            Return False
            End If


    End Function

    Private Sub btnログイン_Click(sender As Object, e As EventArgs) Handles btnログイン.Click
        With txtパスワード
            Select Case .Text
                Case ""
                    lblメッセージ.Text = "パスワードを入力してください。"

                    Call .Select()
                    Exit Sub
                Case Else

            End Select

        End With

        Select Case subログイン()
            Case True
                Me.Close()
            Case Else
                txtパスワード.Select()
        End Select
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Call Application.Exit()

    End Sub

End Class
