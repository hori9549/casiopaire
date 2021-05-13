' @(s)
'   MediaSMS利用クラス
'
Imports System.Net
Imports System.IO
Imports System.Configuration

Public Class clsLineMsg
    Private sApiKey As String
    Private s送信先ユーザーID As String
    Private b送信メッセージ有無 As Boolean
    Private s送信メッセージ As String
    Private sLineBatchPath As String

    'インスタンス作成
    '[App.config]ファイルより、認証情報を取得する。
    Public Sub New()
        'パラメータ初期化
        'APIKeyを生成する
        sApiKey = ConfigurationManager.AppSettings("LineMessageAPIKey")
        'バッチファイルのパスを生成する
        sLineBatchPath = ConfigurationManager.AppSettings("LineBatchPath")
    End Sub

    '送信先ユーザーIDを設定する
    Public Sub subユーザーID設定(ByVal sユーザーID As String)
        Me.s送信先ユーザーID = sユーザーID
    End Sub

    '送信メッセージを設定する
    Public Sub sub送信メッセージ設定(ByVal s送信予定メッセージ As String)
        '設定済の場合は設定しない
        If Trim(s送信予定メッセージ) <> "" And b送信メッセージ有無 = False Then

            Dim s送信メッセージ入力値() As Char
            Dim s変換後文字 As String
            '送信URLにオプションを追加する
            s送信メッセージ入力値 = s送信予定メッセージ

            ''curlコマンドで日本語メッセージを送信するためにunicodeエスケープさせる
            ''MessagingAPIに対応している言語なら不要な処理
            For i As Integer = 0 To s送信メッセージ入力値.Length - 1
                s変換後文字 = ""
                ''unicodeエスケープした文字に変換する
                ''改行文字は特殊変換
                If s送信メッセージ入力値(i) = vbCr Then
                    s変換後文字 = "\r"
                ElseIf s送信メッセージ入力値(i) = vbLf Then
                    s変換後文字 = "\n"
                Else
                    ''AscW()でbyte文字に変換、Hex()で16進数に変換、\uを付けで出来上がり
                    s変換後文字 = Hex(AscW(s送信メッセージ入力値(i)))
                    s変換後文字 = s変換後文字.PadLeft(4, "0"c)
                    s変換後文字 = "\u" & s変換後文字
                End If
                'Console.WriteLine("変換前：" & s送信メッセージ入力値(i) & " 変換後：" & s変換後文字列)

                s送信メッセージ += s変換後文字
            Next i

            b送信メッセージ有無 = True
        End If
    End Sub

    'SMS送信を実施する
    Public Function sメッセージ送信実行() As Boolean

        Dim b送信結果 As Boolean = False
        Dim i終了コード As Integer
        Dim p実行プロセス As Process

        ''実行プロセスの設定情報
        Dim psInfo As New ProcessStartInfo()
        ''実行するファイル
        psInfo.FileName = sLineBatchPath
        ''実行時の引数
        psInfo.Arguments = sApiKey & " " & s送信先ユーザーID & " " & s送信メッセージ
        ''非表示で実行する
        psInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden

        ''バッチファイルを起動する
        p実行プロセス = Process.Start(psInfo)
        ''バッチ処理の終了を待つ（最大で5秒）
        p実行プロセス.WaitForExit(5000)

        ''終了コードの取得
        i終了コード = p実行プロセス.ExitCode

        ''正常終了しているか判断
        If i終了コード = 0 Then
            b送信結果 = True
        Else
            MessageBox.Show("送信メッセージに失敗しました" & Environment.NewLine & "終了コード(" & i終了コード & ")",
                            "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return b送信結果

    End Function

End Class
