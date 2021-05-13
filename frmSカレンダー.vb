﻿'20210408 Sカレンダーに改造　堀内
Imports System.Data
Imports System.Data.SqlClient

Public Class frmSカレンダー
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private myコンボ As New clsコンボボックス

    Private pro年度 As Integer
    Private pro月 As Integer

    Private Sub frmSカレンダー_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Call frmメニュー.Show()
    End Sub

    Private Sub frmSカレンダー_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pro月 = Now.Month
        Select Case Now.Month
            Case >= 4
                pro年度 = Now.Year
                lbl年度.Text = pro年度
            Case Else
                pro年度 = Now.Year - 1
                lbl年度.Text = pro年度
        End Select
        txt作成年度.Text = Now.Year
        lbl施設.Text = my環境設定.会社名 & "カレンダー"

        'Call sub予定表示(pro年度, Now.Month)
        Dim btn月 As Control
        For n月カウント As Integer = 1 To 12
            btn月 = Me.Controls("btn" & n月カウント)
            If n月カウント = Now.Month Then
                CType(btn月, Button).ForeColor = Color.Red
                Call CType(btn月, Button).PerformClick()
            Else
                CType(btn月, Button).ForeColor = Color.Blue
            End If
        Next

        lbl施設.Select()
        '    ActiveControl() = Nothing
    End Sub
    Private Sub グリッド並び()
        ''グリッド表示順
        With dgvカレンダー
            .Columns("colID").DisplayIndex = 0
            .Columns("col休日区分").DisplayIndex = 1
            .Columns("col施設ID").DisplayIndex = 2
            .Columns("col年度").DisplayIndex = 3
            .Columns("col年月日").DisplayIndex = 4
            .Columns("col予定追加").DisplayIndex = 5
            .Columns("col曜日").DisplayIndex = 6
            .Columns("col予定").DisplayIndex = 7

        End With

    End Sub
    Private Sub btn作成_Click(sender As Object, e As EventArgs) Handles btn作成.Click
        With txt作成年度
            Select Case .Text
                Case ""
                    sfrmメッセージ.ShowDialog("カレンダー作成の年度が設定されていません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()

                    Exit Sub
                Case Else
                    If IsNumeric(.Text) = False Then
                        sfrmメッセージ.ShowDialog("カレンダー作成の年度は数字で入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call .Select()

                        Exit Sub
                    End If

                    If CInt(.Text) <= 2020 Then
                        sfrmメッセージ.ShowDialog("カレンダー作成の年度は2021年以上で入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call .Select()

                        Exit Sub
                    End If
            End Select
        End With

        ''処理開始============================================
        Dim cDB As New clsDB
        Dim dtblカレンダー As New DataTable

        ''年度データ確認-----------------------------------------------------
        msSQL = "SELECT * FROM MST_Sカレンダー"
        msSQL += " WHERE 年度='" & txt作成年度.Text & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtblカレンダー) ''データセット作成

        If dtblカレンダー.Rows.Count <> 0 Then
            Select Case sfrmメッセージ.ShowDialog(txt作成年度.Text & "年度のデータはすでに作成されています。" & vbCrLf _
                                        & "再作成を行いますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Case DialogResult.OK
                    ''年度データ削除-----------------------------------------
                    msSQL = " DELETE MST_Sカレンダー"
                    msSQL += " WHERE 年度='" & txt作成年度.Text & "'"

                    mCommand = cDB.getsqlComand(msSQL)
                    Call mCommand.ExecuteNonQuery()
                Case Else
                    Exit Sub
            End Select

        End If

        ''作成開始-------------------------------------------------------------
        Dim dt開始日 As Date = CDate(txt作成年度.Text & "/4/1")
        Dim dt終了日 As Date = DateAdd("yyyy", 1, dt開始日)
        Dim dtカウント As Date = dt開始日

        Do Until dtカウント >= dt終了日

            msSQL = " INSERT INTO MST_Sカレンダー("
            msSQL += "年度"
            msSQL += ",年月日"
            msSQL += ",休日区分"
            msSQL += " )"
            msSQL += " VALUES"
            msSQL += " ("
            msSQL += "'" & txt作成年度.Text & "'"
            msSQL += ",'" & dtカウント.ToString("yyyy/MM/dd") & "'"
            Select Case dtカウント.DayOfWeek
                Case 0  ''日曜
                    If chk日曜休.Checked = True Then
                        msSQL += ",'" & 1 & "'"
                    Else
                        msSQL += ",'" & 0 & "'"
                    End If
                Case 6  ''土曜
                    If chk土曜休.Checked = True Then
                        msSQL += ",'" & 1 & "'"
                    Else
                        msSQL += ",'" & 0 & "'"
                    End If
                Case Else
                    msSQL += ",'" & 0 & "'"

            End Select
            msSQL += " )"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

            ''カウントアップ
            dtカウント = DateAdd("d", 1, dtカウント)
            'spbベース.Value += 1
        Loop

        Call cDB.Close()
        sfrmメッセージ.ShowDialog("カレンダー作成が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call sub予定表示(txt作成年度.Text, pro月)
    End Sub

    Private Sub sub予定表示(get年度 As Integer, get月 As Integer)
        Dim cDB As New clsDB
        Dim dtblカレンダー As New DataTable
        Dim dt開始日, dt終了日 As Date

        Select Case get月
            Case <= 3
                dt開始日 = New Date(get年度 + 1, get月, 1)
            Case Else
                dt開始日 = New Date(get年度, get月, 1)
        End Select
        dt終了日 = DateAdd("M", 1, dt開始日)
        dt終了日 = DateAdd("d", -1, dt終了日)

        ''表示--------------------------------------------------------
        msSQL = "SELECT MST_Sカレンダー.* ,('') as 予定,"
        msSQL += " (Case DatePart(Weekday, 年月日)"
        msSQL += "  WHEN 1 THEN '日' "
        msSQL += "  WHEN 2 THEN '月' "
        msSQL += "  WHEN 3 THEN '火' "
        msSQL += "  WHEN 4 THEN '水' "
        msSQL += "  WHEN 5 THEN '木' "
        msSQL += "  WHEN 6 THEN '金' "
        msSQL += "  WHEN 7 THEN '土' "
        msSQL += " END) as 曜日"

        msSQL += " FROM MST_Sカレンダー"

        msSQL += " WHERE 年度='" & get年度 & "'"
        msSQL += " AND 年月日>='" & dt開始日 & "'"
        msSQL += " AND 年月日<='" & dt終了日 & "'"
        msSQL += " ORDER BY 年月日" '"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtblカレンダー) ''データセット作成

        ''予定設定
        Dim dtbl予定 As New DataTable
        Dim s予定 As String = ""
        Dim dt開始, dt終了 As DateTime
        '  Dim simei As String
        For Each get行 As DataRow In dtblカレンダー.Rows
            Call dtbl予定.Clear()
            s予定 = ""
            '当日の予定を検索
            msSQL = "SELECT a.* ,b.氏名 "
            msSQL += " FROM MST_スケジュール a LEFT JOIN [MST_会員] b"
            msSQL += " ON a.[会員ID] = b.[会員ID]"
            msSQL += " WHERE a.開始日 ='" & get行("年月日") & "'"

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand
            Call mSDA.Fill(dtbl予定) ''データセット作成

            For Each get日予定 As DataRow In dtbl予定.Rows
                dt開始 = DateTime.Parse(get日予定("開始時間").ToString)
                dt終了 = DateTime.Parse(get日予定("終了時間").ToString)

                s予定 += get日予定("氏名") & " " &
                         get日予定("予定").ToString & " " &
                         dt開始.ToString("HH:mm") & "～" & dt終了.ToString("HH:mm") & vbCrLf
            Next
            If s予定 <> "" Then get行("予定") = s予定.Remove(s予定.Length - 2, 2)
        Next


        ''グリッド表示
        With dgvカレンダー
            .DataSource = dtblカレンダー

            Call グリッド並び()
            dgvカレンダー.CurrentCell = Nothing

        End With
    End Sub

    Private Sub btn月_Click(sender As Object, e As EventArgs) Handles btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click _
                                                                        , btn10.Click, btn11.Click, btn12.Click, btn1.Click, btn2.Click, btn3.Click

        pro月 = CType(sender, Button).Tag
        Call sub予定表示(pro年度, pro月)
    End Sub

    Private Sub dgvカレンダー_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvカレンダー.CellFormatting
        Dim get休日, get日付 As String
        Dim setColor As Color

        If e.RowIndex >= 0 Then
            ''MsgBox(dgv_ASSYList.Rows(e.RowIndex).Cells(0).Value)
            get休日 = dgvカレンダー.Rows(e.RowIndex).Cells("col休日区分").Value ''連番情報取得
            get日付 = dgvカレンダー.Rows(e.RowIndex).Cells("col年月日").Value ''連番情報取得

            Select Case get休日
                Case "1" '休日
                    setColor = Color.LightPink
            End Select

            ''着色
            If CDate(get日付).ToString("yyyy/MM/dd") = Now.Date.ToString("yyyy/MM/dd") Then
                Dim i_RowCount As Integer
                For i_RowCount = 0 To dgvカレンダー.ColumnCount - 1
                    dgvカレンダー.Rows(e.RowIndex).Cells(i_RowCount).Style.BackColor = Color.LightYellow
                Next

            Else
                If get休日 <> "" Then
                    Dim i_RowCount As Integer
                    For i_RowCount = 0 To dgvカレンダー.ColumnCount - 1
                        dgvカレンダー.Rows(e.RowIndex).Cells(i_RowCount).Style.BackColor = setColor

                    Next
                End If
            End If

        End If
    End Sub

    Private Sub dgvカレンダー_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvカレンダー.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        Dim cDB As New clsDB
        Dim dt日付 As Date
        Dim myTable As New DataTable

        dt日付 = Trim(dgvカレンダー.Rows(e.RowIndex).Cells("col年月日").Value.ToString)


        Select Case dgvカレンダー.Columns(e.ColumnIndex).Name
            Case "col予定追加"

                Dim sfrm As New sfrmS予定登録
                sfrm.日付 = dt日付.ToString("yyyy/MM/dd")
                sfrm.ShowDialog()

                Call sub予定表示(pro年度, pro月)

            Case "col予定"

                Dim sfrm As New frm個別カレンダー

                sfrm.日付 = dt日付.ToString("yyyy/MM/dd")
                sfrm.ShowDialog()

                Call sub予定表示(pro年度, pro月)

            Case "col週間表示"

                Dim sfrm As New frm週間表示
                sfrm.日付 = dt日付.ToString("yyyy/MM/dd")
                sfrm.ShowDialog()

                Call sub予定表示(pro年度, pro月)
        End Select
    End Sub

    Private Sub btn前_Click(sender As Object, e As EventArgs) Handles btn前.Click
        pro年度 = pro年度 - 1
        lbl年度.Text = pro年度
        Call sub予定表示(pro年度, pro月)
    End Sub

    Private Sub btn次_Click(sender As Object, e As EventArgs) Handles btn次.Click
        pro年度 = pro年度 + 1
        lbl年度.Text = pro年度
        Call sub予定表示(pro年度, pro月)
    End Sub

End Class