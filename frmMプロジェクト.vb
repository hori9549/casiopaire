Imports System.Data
Imports System.Data.SqlClient

Public Class frmMプロジェクト
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private mdtblプロジェクト As New DataTable
    Private myコンボ As New clsコンボボックス

    'エンタータブ処理
    Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        Dim getControl As Control = Me.ActiveControl

        ''ボタンだったらタブにしない
        Select Case getControl.GetType.Name
            Case "TextBox", "ComboBox"
                'Returnキーが押されているか調べる
                'AltかCtrlキーが押されている時は、本来の動作をさせる
                If ((keyData And Keys.KeyCode) = Keys.Return) AndAlso
                    ((keyData And (Keys.Alt Or Keys.Control)) = Keys.None) Then
                    'Tabキーを押した時と同じ動作をさせる
                    'Shiftキーが押されている時は、逆順にする
                    Me.ProcessTabKey((keyData And Keys.Shift) <> Keys.Shift)
                    '本来の処理はさせない
                    Return True
                End If
                Return MyBase.ProcessDialogKey(keyData)

            Case Else

        End Select
        Return MyBase.ProcessDialogKey(keyData)
    End Function

    Private Sub frmMプロジェクト_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '画面の初期化
        'Call subクリア()

        'コンボボックスの呼び出し
        Call myコンボ.担当理事コンボ(cmb担当理事)
        Call myコンボ.プロジェクトIDコンボ(cmbPID_P参加会員)
        Call myコンボ.会員IDコンボ(cmb会員ID_P参加会員)

        Call txtプロジェクトID.Select()
        Call sub一覧表示_プロジェクト()
        Call sub一覧表示_参加会員()
        txtプロジェクトID.Text = iプロジェクトID最大取得()

        'With dg svプロジェクト
        '    .DataSource = mdtblプロジェクト
        '    Call グリッド並び()
        'End With

    End Sub

    Private Sub frmプロジェクト_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Call frmメニュー.Show()
    End Sub

    'Private Sub グリッド並び()
    '    'グリッド表示順
    '    With dgvプロジェクト
    '        .Columns("colID").DisplayIndex = 0
    '        .Columns("colプロジェクトID").DisplayIndex = 1
    '        .Columns("colプロジェクト名").DisplayIndex = 2
    '        .Columns("col内容").DisplayIndex = 3
    '        .Columns("col担当理事").DisplayIndex = 4
    '        .Columns("col開催日").DisplayIndex = 5
    '        .Columns("col開始日").DisplayIndex = 6
    '        .Columns("col終了日").DisplayIndex = 7
    '        .Columns("col備考").DisplayIndex = 8

    '    End With

    'End Sub

    Private Sub btn開始日_Click(sender As Object, e As EventArgs) Handles btn開始日.Click
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()
        txt開始日.Text = sfrm.日付
    End Sub

    Private Sub btn終了日_Click(sender As Object, e As EventArgs) Handles btn終了日.Click
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()
        txt終了日.Text = sfrm.日付
    End Sub

    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        'エラーチェック

        With txtプロジェクトID
            Select Case .Text
                Case ""
                    MessageBox.Show("プロジェクトIDは必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Call .Select()
                    Exit Sub

                Case Else
                    If IsNumeric(.Text) = False Then
                        MessageBox.Show("プロジェクトIDは数字入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Call .Select()
                        Exit Sub
                    End If

            End Select
        End With

        With txtプロジェクト名
            Select Case .Text
                Case ""
                    MessageBox.Show("プロジェクト名は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Call .Select()
                    Exit Sub

                Case Else

                    If Len(.Text) >= 50 Then
                        MessageBox.Show("プロジェクト名は50文字以内の入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Call .Select()
                        Exit Sub
                    End If

            End Select
        End With

        With txt開始日
            Select Case .Text
                Case ""
                    MessageBox.Show("開始日は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Call .Select()
                    Exit Sub

                Case Else
                    If IsDate(.Text) = False Then
                        MessageBox.Show("正しい開始日を入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call .Select()
                        Exit Sub
                    End If


            End Select
        End With

        'チェックボックスのデータ取得

        Dim 開催日 As String = ""
        If chc月.Checked = True Then
            開催日 = 開催日 & "月"
        End If
        If chc火.Checked = True Then
            開催日 = 開催日 & "火"
        End If
        If chc水.Checked = True Then
            開催日 = 開催日 & "水"
        End If
        If chc木.Checked = True Then
            開催日 = 開催日 & "木"
        End If
        If chc金.Checked = True Then
            開催日 = 開催日 & "金"
        End If
        If chc土.Checked = True Then
            開催日 = 開催日 & "土"
        End If
        If chc日.Checked = True Then
            開催日 = 開催日 & "日"
        End If

        '登録出来るか検索

        msSQL = "Select * FROM MST_プロジェクト"
        msSQL += " WHERE プロジェクトID = " & txtプロジェクトID.Text

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        '新規か登録かIF文

        If myTable.Rows.Count = 0 Then

            '新規

            msSQL = "INSERT INTO MST_プロジェクト("

            msSQL += "プロジェクトID"
            msSQL += ", プロジェクト名"
            msSQL += ", 内容"
            msSQL += ", 担当理事"
            msSQL += ", 開催日"
            msSQL += ", 開始日"
            msSQL += ", 備考"

            msSQL += ")VALUES("

            msSQL += "'" & txtプロジェクトID.Text & "'"
            msSQL += ",'" & txtプロジェクト名.Text & "'"
            msSQL += ",'" & txt内容.Text & "'"
            msSQL += ",'" & cmb担当理事.Text & "'"
            msSQL += ",'" & 開催日 & "'"
            msSQL += ",'" & txt開始日.Text & "'"
            msSQL += ",'" & txt備考.Text & "'"

            msSQL += ")"

        Else
            Select Case MessageBox.Show("プロジェクトID:" & txtプロジェクトID.Text & "の修正を行います。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                Case ShowDialog.OK
                Case Else
                    Exit Sub
            End Select

            '更新

            msSQL = " Update MST_プロジェクト SET"
            msSQL += " プロジェクト名 = '" & Trim(txtプロジェクト名.Text) & "'"
            msSQL += ",内容 = '" & Trim(txt内容.Text) & "'"
            msSQL += ",担当理事 = '" & Trim(cmb担当理事.Text) & "'"
            msSQL += ",開催日 = '" & Trim(開催日) & "'"
            msSQL += ",開始日 = '" & Trim(txt開始日.Text) & "'"

            If txt終了日.Text = "" Then
                msSQL += ",終了日 =NULL"
            Else
                msSQL += ",終了日 ='" & Trim(txt終了日.Text) & "'"
            End If

            msSQL += ",備考 = '" & Trim(txt備考.Text) & "'"

            msSQL += " WHERE プロジェクトID = " & txtプロジェクトID.Text

        End If

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        '初期化
        MessageBox.Show("登録が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ''再表示
        Call sub一覧表示_プロジェクト()

        ''クリア
        txtプロジェクトID.Text = iプロジェクトID最大取得()
        txtプロジェクト名.Text = ""
        Call txtプロジェクトID.Select()
        Call cDB.Close()

        ''コンボボックスセット
        Call myコンボ.担当理事コンボ(cmb担当理事)

    End Sub

    Private Sub sub一覧表示_プロジェクト()
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = "SELECT * FROM MST_プロジェクト"
        msSQL += " ORDER BY プロジェクトID"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        dgvプロジェクト.DataSource = myTable

        Call cDB.Close()
        Exit Sub
    End Sub

    '
    ' 機能      : プロジェクトIDの最大コードを取得する
    '
    ' 返り値    : 最大コードに１を加算する
    '
    ' 機能説明  : 
    '
    ' 備考      : 
    '
    Private Function iプロジェクトID最大取得() As Integer
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = " SELECT * FROM MST_プロジェクト"
        'msSQL += " WHERE 施設ID = " & my環境設定.施設ID
        msSQL += " ORDER BY プロジェクトID DESC"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        If myTable.Rows.Count = 0 Then
            Return 1

        Else
            Return myTable.Rows(0)("プロジェクトID") + 1

        End If

        Call cDB.Close()
    End Function

    Private Sub dgvプロジェクト_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvプロジェクト.CellClick

        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        'Call subクリア()
        txtプロジェクトID.Text = dgvプロジェクト.Rows(e.RowIndex).Cells("colプロジェクトID").Value.ToString
        txtプロジェクト名.Text = dgvプロジェクト.Rows(e.RowIndex).Cells("colプロジェクト名").Value.ToString
        txt内容.Text = dgvプロジェクト.Rows(e.RowIndex).Cells("col内容").Value.ToString
        cmb担当理事.Text = dgvプロジェクト.Rows(e.RowIndex).Cells("col担当理事").Value.ToString

        Dim 開催日 As String
        開催日 = dgvプロジェクト.Rows(e.RowIndex).Cells("col開催日").Value.ToString
        If InStr(開催日, "月") <> 0 Then
            chc月.Checked = True
        End If
        If InStr(開催日, "火") <> 0 Then
            chc火.Checked = True
        End If
        If InStr(開催日, "水") <> 0 Then
            chc水.Checked = True
        End If
        If InStr(開催日, "木") <> 0 Then
            chc木.Checked = True
        End If
        If InStr(開催日, "金") <> 0 Then
            chc金.Checked = True
        End If
        If InStr(開催日, "土") <> 0 Then
            chc土.Checked = True
        End If
        If InStr(開催日, "日") <> 0 Then
            chc日.Checked = True
        End If


        txt開始日.Text = CDate(dgvプロジェクト.Rows(e.RowIndex).Cells("col開始日").Value.ToString).ToString("yyyy/MM/dd")

        If dgvプロジェクト.Rows(e.RowIndex).Cells("col終了日").Value.ToString = "" Then
            txt終了日.Text = ""
        Else
            txt終了日.Text = CDate(dgvプロジェクト.Rows(e.RowIndex).Cells("col終了日").Value.ToString).ToString("yyyy/MM/dd")
        End If

        txt備考.Text = dgvプロジェクト.Rows(e.RowIndex).Cells("col備考").Value.ToString

    End Sub

    'Private Sub subクリア()
    '    txtプロジェクトID.Text = ""
    '    txtプロジェクト名.Text = ""
    '    txt内容.Text = ""
    '    cmb担当理事.Text = ""
    '    chc月.Checked = False
    '    chc火.Checked = False
    '    chc水.Checked = False
    '    chc木.Checked = False
    '    chc金.Checked = False
    '    chc土.Checked = False
    '    chc日.Checked = False
    '    txt終了日.Text = ""
    '    txt開始日.Text = ""
    '    txt終了日.Text = ""
    '    txt備考.Text = ""

    '    Call txtプロジェクトID.Select()
    'End Sub

    Private Sub btn新規_Click(sender As Object, e As EventArgs) Handles btn新規.Click
        txtプロジェクトID.Text = iプロジェクトID最大取得()
        txtプロジェクト名.Text = ""
        txt内容.Text = ""
        cmb担当理事.Text = ""
        chc月.Checked = False
        chc火.Checked = False
        chc水.Checked = False
        chc木.Checked = False
        chc金.Checked = False
        chc土.Checked = False
        chc日.Checked = False
        txt終了日.Text = ""
        txt開始日.Text = ""
        txt終了日.Text = ""
        txt備考.Text = ""
    End Sub

    Private Sub btn登録_P参加会員_Click(sender As Object, e As EventArgs) Handles btn登録_P参加会員.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        With cmbPID_P参加会員
            Select Case .SelectedValue
                Case 0
                    sfrmメッセージ.ShowDialog("プロジェクトIDは必須入力項目です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call .Select()
                    Exit Sub
                Case Else
            End Select
        End With

        With cmb会員ID_P参加会員
            Select Case .Text
                Case ""
                    sfrmメッセージ.ShowDialog("会員IDは必須入力項目です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call .Select()
                    Exit Sub
                Case Else
            End Select
        End With

        ''存在チェック
        msSQL = " SELECT * FROM MST_P参加会員"
        'msSQL += " WHERE 施設ID = " & my環境設定.施設ID
        msSQL += " WHERE プロジェクトID = " & cmbPID_P参加会員.SelectedValue
        msSQL += " AND 会員ID = " & cmb会員ID_P参加会員.SelectedValue

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        If myTable.Rows.Count = 0 Then

            ''新規追加
            msSQL = " INSERT INTO MST_P参加会員("
            'msSQL += " 施設ID"
            msSQL += " プロジェクトID"
            msSQL += ",会員ID"
            msSQL += ",備考"
            msSQL += ",削除フラグ"
            msSQL += " )"
            msSQL += " VALUES"
            msSQL += " ("
            'msSQL += " '" & my環境設定.施設ID & "'"
            msSQL += " '" & Trim(cmbPID_P参加会員.SelectedValue) & "'"
            msSQL += ",'" & Trim(cmb会員ID_P参加会員.SelectedValue) & "'"
            msSQL += ",'" & Trim(txt備考_P参加会員.Text) & "'"
            msSQL += ",'0'"
            msSQL += " )"

        Else

            ''更新
            msSQL = " UPDATE MST_P参加会員 SET "
            msSQL += " プロジェクトID = '" & Trim(cmbPID_P参加会員.SelectedValue) & "'"
            msSQL += ",会員ID = '" & Trim(cmb会員ID_P参加会員.SelectedValue) & "'"
            msSQL += ",備考 = '" & Trim(txt備考_P参加会員.Text) & "'"
            msSQL += ",削除フラグ = '" & Math.Abs(CInt(chk削除_P参加会員.Checked)) & "'"
            'msSQL += " WHERE 施設ID = " & my環境設定.施設ID
            msSQL += " WHERE プロジェクトID = " & cmbPID_P参加会員.SelectedValue
            msSQL += " AND 会員ID = " & cmb会員ID_P参加会員.SelectedValue

        End If

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        ''再表示
        Call sub一覧表示_参加会員()

        ''クリア
        Call sub一覧表示_参加会員(cmbPID_P参加会員.SelectedValue)
        cmb会員ID_P参加会員.Text = ""
        txt備考_P参加会員.Text = ""
        Call cmb会員ID_P参加会員.Select()
        Call cDB.Close()

    End Sub

    Private Sub sub一覧表示_参加会員(Optional ByVal setプロジェクトID As Integer = 0)
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = "SELECT * FROM MST_P参加会員"
        'msSQL += " WHERE 施設ID = " & my環境設定.施設ID
        If setプロジェクトID <> 0 Then msSQL += " WHERE プロジェクトID ='" & setプロジェクトID & "'"
        msSQL += " ORDER BY プロジェクトID"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        dgv参加会員.DataSource = myTable

        Call cDB.Close()
        Exit Sub
    End Sub

    Private Sub dgv参加会員_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv参加会員.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        cmbPID_P参加会員.Text = Trim(dgv参加会員.Rows(e.RowIndex).Cells("colプロジェクトID_P参加会員").Value.ToString)
        cmb会員ID_P参加会員.Text = Trim(dgv参加会員.Rows(e.RowIndex).Cells("col会員ID_P参加会員").Value.ToString)
        txt備考_P参加会員.Text = Trim(dgv参加会員.Rows(e.RowIndex).Cells("col備考_P参加会員").Value.ToString)
        chk削除_P参加会員.Checked = Trim(dgv参加会員.Rows(e.RowIndex).Cells("col削除_P参加会員").Value.ToString)
    End Sub

End Class