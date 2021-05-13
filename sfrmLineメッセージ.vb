Imports System.Text
Imports System.Web
Imports System.Net

Public Class sfrmLineメッセージ

    Public Property s送信先会員名 As String
    Public Property s送信先会員ID As String
    Public Property s送信先LINEID As String

    Private Sub frmメイン_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''サンプル情報
        lbl送信先会員ID.Text = s送信先会員ID
        lbl送信先会員名.Text = s送信先会員名
        txt送信メッセージ.Text = ""
    End Sub

    Private Sub btn送信_Click(sender As Object, e As EventArgs) Handles btn送信.Click
        ''LINEメッセージ送信クラス
        Dim cLineMsg As New clsLineMsg
        Dim sメッセージチェック As String

        ''入力内容がない場合は送信しないようにする
        sメッセージチェック = Trim(txt送信メッセージ.Text).Replace(Environment.NewLine, "")
        If sメッセージチェック <> "" Then
            ''確認メッセージ生成
            Dim 確認メッセージ As String = ""
            確認メッセージ += "以下の内容で送信します よろしいですか？" + Environment.NewLine + Environment.NewLine
            確認メッセージ += txt送信メッセージ.Text


            ''送信前確認
            Select Case MessageBox.Show(確認メッセージ, "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Case DialogResult.Cancel
                    Me.DialogResult = DialogResult.None
                    Exit Sub
                Case DialogResult.OK
                    Me.DialogResult = DialogResult.OK
                    ''LINEメッセージ送信準備
                    cLineMsg.subユーザーID設定(s送信先LINEID)
                    cLineMsg.sub送信メッセージ設定(txt送信メッセージ.Text)
                    ''LINEメッセージ送信実行
                    If cLineMsg.sメッセージ送信実行() Then
                        MessageBox.Show("メッセージ送信が完了しました", "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    Me.Close()
            End Select
        Else
            Me.DialogResult = DialogResult.None
            MessageBox.Show("送信メッセージがありません", "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btn閉じる_Click(sender As Object, e As EventArgs) Handles btn閉じる.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
