Imports System.Windows.Forms
Imports System.Text.RegularExpressions  ''正規表現

Imports System.Data
Imports System.Data.SqlClient

Public Class sfrmS予定登録
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private get日付 As Date
    Private getID As Integer
    Private 予定color As String
    Private 規定色 As String = "A9A9A9"        '規定色 DarkGray
    Private dt年度末日 As Date
    Private get会員ID As New clsコンボボックス

    Public Property 日付() As Date
        Get
            Return get日付
        End Get

        Set(ByVal value As Date)
            get日付 = value
        End Set
    End Property
    Private Sub sfrm予定登録_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv一覧.Columns("col開始日").DefaultCellStyle.Format = "MM/dd"
        dgv一覧.Columns("col終了日").DefaultCellStyle.Format = "MM/dd"

        '
        ''cmb繰返し　の ITEMセット
        Dim dtbl繰返し As New DataTable
        dtbl繰返し.Columns.Add("繰返しID")
        dtbl繰返し.Columns.Add("繰返し種別")

        Dim row追加 As DataRow = dtbl繰返し.NewRow
        row追加("繰返しID") = "0"
        row追加("繰返し種別") = "なし"
        dtbl繰返し.Rows.Add(row追加)

        row追加 = dtbl繰返し.NewRow
        row追加("繰返しID") = "1"
        row追加("繰返し種別") = "毎日"
        dtbl繰返し.Rows.Add(row追加)

        row追加 = dtbl繰返し.NewRow
        row追加("繰返しID") = "2"
        row追加("繰返し種別") = "毎週"
        dtbl繰返し.Rows.Add(row追加)

        ''cmb繰返し dtbl繰返し 結びつけ
        With cmb繰返し
            .DisplayMember = "繰返し種別"
            .ValueMember = "繰返しID"

            .DataSource = dtbl繰返し.DefaultView
            .SelectedValue = 0
        End With

        ''会員一覧を MST会員から取得
        Call get会員ID.会員IDコンボ(cmb会員) 'メソッドはclsコンボボックス

        ''見出し等 初期設定
        lbl日付.Text = get日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call sub予定取得(get日付)
        Call sub予定表示(get日付)
        Call mode選択()

        btn追加.Enabled = True

        '繰返し限界日(dt年度末日)をあらかじめ見つけておこう
        Dim pro年度 As Integer
        Dim pro月 = Now.Month
        Select Case Now.Month
            Case >= 4
                pro年度 = Now.Year
                '    Dim lbl年度.Text = pro年度
            Case Else
                pro年度 = Now.Year - 1
                ' lbl年度.Text = pro年度
        End Select

        Dim dtNext As Date = CDate(pro年度 + 1 & "/4/1")
        dt年度末日 = DateAdd("d", -1, dtNext)


    End Sub
    'Private Sub 会員コンボ(ByVal setCMB As ComboBox)
    '    Dim cDB As New clsDB
    '    Dim getSQL As String
    '    Dim myTable As New DataTable

    '    ''検索SQL======================================================
    '    getSQL = "SELECT DISTINCT 氏名 ,会員ID"
    '    getSQL += " FROM MST_会員"
    '    getSQL += " ORDER BY 会員ID,氏名"
    '    mCommand = cDB.getsqlComand(getSQL)
    '    mSDA.SelectCommand = mCommand

    '    Call mSDA.Fill(myTable)
    '    ''=============================================================

    '    ''空行追加-----------------------------------------------------
    '    Dim myRow As DataRow = myTable.NewRow
    '    myRow("会員ID") = "0"
    '    myRow("氏名") = ""
    '    Call myTable.Rows.InsertAt(myRow, 0)

    '    With setCMB
    '        .DisplayMember = "氏名"
    '        .ValueMember = "会員ID"

    '        ''グリッド表示
    '        .DataSource = myTable.DefaultView
    '        .SelectedValue = 0
    '    End With


    'End Sub

    Private Sub btn前_Click(sender As Object, e As EventArgs) Handles btn前.Click
        get日付 = DateAdd("d", -1, get日付)
        lbl日付.Text = get日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call sub予定取得(get日付)
        Call sub予定表示(get日付)
        Call mode選択()

    End Sub

    Private Sub btn次_Click(sender As Object, e As EventArgs) Handles btn次.Click
        get日付 = DateAdd("d", 1, get日付)
        lbl日付.Text = get日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call sub予定取得(get日付)
        Call sub予定表示(get日付)
        Call mode選択()
    End Sub
    Private Sub mode選択()
        If get日付 < Now.Date Then
            Dim before As String = "b"
            Call mode表示(before)
            'lblMode表示.Text = "本日より前のスケジュールは、登録．更新．削除はできません。" & vbCrLf &
            '                   " [▷ ボタン]で日付を進めるか、前に戻って選択しなおしてください。"
            'lblMode表示.ForeColor = Color.Red
            grp予定登録.Enabled = False
            Call lblMode表示.Select()
        Else
            '  "新規登録モ-ド"
            Dim insert As String = "i"
            Call mode表示(insert)
            'txt予定ID.Text = getMaxId().ToString("0000000")
            'txt枝番号.Text = "000"
            'txt開始日.Text = get日付.ToString("yyyy/MM/dd")
            'txt終了日.Text = txt開始日.Text
            'Dim insert As String = "i"
            'Call mode表示(insert)
            'grp予定登録.Enabled = True
            grp更新時Enable.Enabled = True
            'btn追加.Enabled = True
            btn追加.Text = "新規登録"
            'Call subクリア()
            grp予定登録.Enabled = True
            Call cmb会員.Select()
        End If
    End Sub


    Private Sub mode表示(ByVal mode As String)
        Select Case mode
            Case "d"
                lblMode表示.Text = "削除モードです。"
                lblMode表示.ForeColor = Color.Red
            Case "b"
                lblMode表示.Text = "本日より前のスケジュールは、登録．更新．削除はできません。" '& vbCrLf &
                '  " [▷ ボタン]で日付を進めるか、前に戻って選択しなおしてください。"
                lblMode表示.ForeColor = Color.Brown
            Case "i"
                lblMode表示.Text = "新規登録モード" 'です、更新．削除は," &
                'vbCrLf & "下部の「一覧表」の中から選択してください。"
                ' &                vbCrLf & "≻ で日付を進めるか、前に戻って選択しなおしてください。"
                lblMode表示.ForeColor = Color.Blue
                btn追加.Text = "新規登録"
                btn追加.ForeColor = Color.Blue
            Case "U"
                lblMode表示.Text = "更新モード"
                lblMode表示.ForeColor = Color.Green
                btn追加.Text = "更新"
                btn追加.ForeColor = Color.Green

            Case Else
                MsgBox("その他mode未完です")

        End Select
    End Sub
    Private Sub sub予定取得(set日付 As Date)
        Dim cDB As New clsDB
        Dim dtblカレンダー As New DataTable

        ''年度データ確認-----------------------------------------------------
        msSQL = "SELECT * FROM MST_Sカレンダー"
        msSQL += " WHERE 年月日='" & set日付 & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtblカレンダー) ''データセット作成

        If dtblカレンダー.Rows.Count <> 0 Then
            Select Case dtblカレンダー.Rows(0)("休日区分")
                Case 1
                    chk休日.Checked = True
                Case Else
                    chk休日.Checked = False
            End Select

        End If

    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim cDB As New clsDB

        ''更新
        msSQL = " UPDATE MST_Sカレンダー SET "
        If chk休日.Checked = True Then
            msSQL += " 休日区分='1'"

        Else
            msSQL += " 休日区分='0'"

        End If
        msSQL += " WHERE 年月日='" & get日付 & "'"

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub subクリア()
        'txt予定ID.Text = ""
        'txt枝番号.Text = ""
        txt予定.Text = ""
        txt記事.Text = ""
        'txt開始日.Text = ""
        'txt終了日.Text = ""
        dtp開始時間.Text = "00:00"
        dtp終了時間.Text = "00:00"
        txt予定ID.Text = getMaxId().ToString("0000000")
        txt枝番号.Text = "000"
        txt開始日.Text = get日付.ToString("yyyy/MM/dd")
        txt終了日.Text = txt開始日.Text
        'Dim insert As String = "i"
        'Call mode表示(insert)
        'grp予定登録.Enabled = True
        'grp更新時Enable.Enabled = True
        'btn追加.Enabled = True
        'btn追加.Text = "新規登録"
        txtColor.Text = "　　　　規定色"
        txtColor.ForeColor = Color.White
        txtColor.BackColor = Color.Pink
        cmb会員.SelectedValue = 0
        cmb繰返し.SelectedValue = 0
        ' TXT規定色に彩色
        予定color = 規定色
        Dim RGB() As String
        RGB = mdlCommon.rtnParameter(予定color)
        txtColor.BackColor = Color.FromArgb(RGB(0), RGB(1), RGB(2))
        btnColor.BackColor = Color.FromArgb(RGB(0), RGB(1), RGB(2))
    End Sub

    Private Sub sub予定表示(set日付 As Date)
        Dim cDB As New clsDB
        Dim dtbl予定 As New DataTable
        msSQL = dtbl予定msSQL()

        msSQL += " WHERE 開始日='" & set日付 & "'"
        msSQL += " ORDER BY a.会員ID,開始日,開始時間"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl予定) ''データセット作成
        dgv一覧.DataSource = dtbl予定
        Call グリッドstyle()
    End Sub
    ' Function dtbl予定msSQL(ByVal str As String) As String
    Function dtbl予定msSQL() As String

        Dim str As String
        str = " SELECT "
        str += "a.ID"
        Str += ",a.予定ID"
        Str += ",CASE "
        Str += "substring(format(a.枝番号,'00000'),1,2) "
        Str += "when '00' then 'なし'"
        Str += "when '01' then '毎日'"
        Str += "when '02' then '毎週'"
        Str += "/*when '' then ''*/"
        Str += "else '未完成'"
        Str += "END AS 複数削除"
        Str += ",' ' AS 削除"
        Str += ",a.会員ID"
        Str += ",b.氏名 "
        Str += ",a.開始日"
        Str += ",a.終了日"
        Str += ",a.開始時間"
        Str += ",a.終了時間"
        Str += ",a.予定"
        Str += ",a.記事"
        Str += ",a.color"
        Str += " FROM MST_スケジュール as a INNER JOIN MST_会員 b "
        Str += " ON a.会員ID = b.会員ID "
        Return str
        'msSQL += " WHERE 開始日='" & set日付 & "'"
        'msSQL += " ORDER BY 開始日,開始時間"
    End Function

    Private Sub グリッドstyle()
        ''グリッド表示順
        With dgv一覧
            ''Self Formating    
            Dim P(3) As String
            For i = 0 To .RowCount - 1
                Dim d As Integer = Integer.Parse(.Rows(i).Cells("colcolor").Value.ToString)
                Dim inHex As String = Convert.ToString(d, 16)

                P = mdlCommon.rtnParameter(inHex)
                ' MsgBox(dgv一覧.Rows(i).Cells("colcolor").Value) '= Color.FromArgb(P(0), P(1), P(2))
                dgv一覧.Rows(i).Cells("colcolor").Style.BackColor = Color.FromArgb(P(0), P(1), P(2))
                dgv一覧.Rows(i).Cells("colcolor").Style.ForeColor = Color.FromArgb(P(0), P(1), P(2))
            Next

            .Columns("colID").DisplayIndex = 0
            .Columns("col予定ID").DisplayIndex = 1
            .Columns("複数削除").DisplayIndex = 2
            .Columns("削除").DisplayIndex = 3
            .Columns("col会員ID").DisplayIndex = 4
            .Columns("氏名").DisplayIndex = 5
            .Columns("col開始日").DisplayIndex = 6
            .Columns("col終了日").DisplayIndex = 7
            .Columns("col開始時間").DisplayIndex = 8
            .Columns("col終了時間").DisplayIndex = 9
            .Columns("col予定").DisplayIndex = 10
            .Columns("col記事").DisplayIndex = 11
            .Columns("colcolor").DisplayIndex = 12

        End With
        dgv一覧.CurrentCell = Nothing
    End Sub
    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn追加.Click
        '  
        '********* 入力データーの検証 **************
        '
        '終了日は正しいか？
        With txt終了日
            If .Text <> "" Then
                Select Case IsDate(.Text)
                    Case False
                        MessageBox.Show("終了日の入力に誤りがあります。")
                        Call .Select()
                        Exit Sub
                    Case Else '5/1のようなものも通してしまうので
                        Dim dtEnd As Date = .Text
                        ' txt終了日.Text = Format(dtEnd, "yyyy/MM/dd")
                        .Text = dtEnd.ToString("yyyy/MM/dd")    '終了日は自動的に入る 
                        'If txt開始日.Text > .Text Then
                        '    MsgBox("ありえない終了日です？？")
                        '    Call txt終了日.Select()
                        '    Exit Sub
                        'End If
                End Select
            Else    ' txt終了日="" なら期末日を終了日にする
                .Text = dt年度末日
            End If

        End With
        '
        '予定は正しいか？
        With txt予定
            Select Case .Text
                Case ""
                    sfrmメッセージ.ShowDialog("予定は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()
                    Exit Sub
                Case Else

            End Select
        End With
        '********* 入力データーの検証　終了 **************
        '登録 新規の場合
        If btn追加.Text = "新規登録" Then
            '
            '[枝番号] 付与規則
            '    cmb繰返しで選択された[繰返しID] + 入力順(nnn) 
            '    データベースに書き込むときは、整数化して容量を節約する。読み出し時は、Tostring("000##") 5ケタでゼロ埋めする。
            '     
            '-------------------枝番号の付与---------------------------------
            Dim kurikaesi種別 As Byte = cmb繰返し.SelectedValue
            Dim kurikaesi開始日 As Date = DateTime.Parse(txt開始日.Text)
            Dim kurikaesi終了日 As Date = DateTime.Parse(txt終了日.Text)
            Dim eda番号 As Integer = 0


            eda番号 = cmb繰返し.SelectedValue * 1000  ' 0 または　n000 が枝番号の　ベースになる


            '-------------------枝番号の付与 ここまで---------------------------------

            '
            ''繰り返す
            Dim dtカウント As Date = kurikaesi開始日
            Do While dtカウント <= kurikaesi終了日
                Dim cDB As New clsDB
                Dim dtbl予定 As New DataTable

                eda番号 += 1

                msSQL = " INSERT INTO MST_スケジュール("
                msSQL += "予定ID"
                msSQL += ",枝番号"
                msSQL += ",会員ID"
                msSQL += " ,開始日"
                msSQL += " ,終了日"
                msSQL += ",開始時間"
                msSQL += ",終了時間"
                msSQL += ",予定"
                msSQL += ",記事"
                msSQL += ",color"

                msSQL += ")VALUES("
                msSQL += "'" & Integer.Parse(txt予定ID.Text) & "'"

                msSQL += ",'" & eda番号 & "'"

                msSQL += ",'" & cmb会員.SelectedValue.ToString() & "'"
                msSQL += ",'" & DateTime.Parse(dtカウント) & "'"
                If txt終了日.Text = "" Then
                    msSQL += ",NULL"        '1900/1/1になってしまう
                Else
                    msSQL += ",'" & txt終了日.Text & "'"
                End If
                msSQL += ",'" & dtp開始時間.Text & "'"
                msSQL += ",'" & dtp終了時間.Text & "'"
                msSQL += ",'" & txt予定.Text & "'"
                msSQL += ",'" & txt記事.Text & "'"

                Dim num16 As Integer = Convert.ToInt32(予定color, 16)     'colorは、Int型
                msSQL += ",'" & num16 & "'"

                msSQL += ")"

                mCommand = cDB.getsqlComand(msSQL)
                Call mCommand.ExecuteNonQuery()

                ''繰返しの次の日はいつになるのかな？
                Select Case kurikaesi種別

                    Case 1, 0
                        dtカウント = DateAdd("d", 1, dtカウント)
                    Case 2
                        dtカウント = DateAdd("d", 7, dtカウント)
                End Select
            Loop

            '------------新規登録　ここまで-------------

        Else
            'update
            Dim cDB As New clsDB
            '        Dim dtbl予定 As New DataTable

            msSQL = "UPDATE MST_スケジュール SET"
            msSQL += "[会員ID]='" & cmb会員.SelectedValue.ToString() & "'"
            msSQL += ",[開始日]='" & txt開始日.Text & "'"
            If txt終了日.Text = "" Then
                msSQL += ",終了日 =NULL"        '1900/1/1になってしまう
            Else
                msSQL += ",[終了日]='" & txt終了日.Text & "'"
            End If
            msSQL += ",開始時間='" & dtp開始時間.Text & "'"
            msSQL += ",終了時間='" & dtp終了時間.Text & "'"
            msSQL += ",予定='" & txt予定.Text & "'"
            msSQL += ",[記事]='" & txt記事.Text & "'"


            Dim num16 As Integer = Convert.ToInt32(txtColor.Text, 16)     'colorは、Int型
            msSQL += ",[color]='" & num16 & "'"

            msSQL += " WHERE ID='" & getID & "'"
            '   msSQL += "AND 枝番号 = '" & txt枝番号.Text & "'"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

        End If

        ''初期化-----------------------------------------------------
        sfrmメッセージ.ShowDialog("登録が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call subクリア()
        Call sub予定表示(get日付)
        Call mode選択()

    End Sub

    Private Sub dgv一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable
        Dim dtbl予定 As New DataTable
        btn追加.Enabled = True
        getID = Trim(dgv一覧.Rows(e.RowIndex).Cells("colID").Value.ToString)

        ''MST_スケジュール
        msSQL = "SELECT * FROM MST_スケジュール"
        msSQL += " WHERE ID='" & getID & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl予定) ''データセット作成

        For Each get予定 As DataRow In dtbl予定.Rows
            txt予定ID.Text = get予定("予定ID")
            Dim sep As String = Format(get予定("枝番号"), "00000")       '先頭の2文字は繰り返し種別 なし：00 後ろ3文字は枝番号max：365
            cmb繰返し.SelectedValue = Integer.Parse(sep.Substring(0, 2))
            txt枝番号.Text = sep.Substring(2, 3)
            cmb会員.SelectedValue = get予定("会員ID")
            txt開始日.Text = get予定("開始日")

            If get予定("終了日") Is DBNull.Value Then
                txt終了日.Text = ""
            Else
                txt終了日.Text = get予定("終了日")
            End If

            dtp開始時間.Text = get予定("開始時間")
            dtp終了時間.Text = get予定("終了時間")
            txt予定.Text = get予定("予定")
            txt記事.Text = get予定("記事")
            'txtColorを発色
            Dim hexColor As String = Convert.ToString(get予定("color"), 16)
            txtColor.Text = hexColor

            Dim RGB(3) As String
            RGB = mdlCommon.rtnParameter(hexColor)
            '    Call makeParam(hexColor, r, g, b)   
            'プロパティに値を設定
            btnColor.BackColor = Color.FromArgb(RGB(0), RGB(1), RGB(2))
            txtColor.ForeColor = Color.FromArgb(RGB(0), RGB(1), RGB(2))
            txtColor.BackColor = Color.FromArgb(RGB(0), RGB(1), RGB(2))

        Next
        '  Dim dt As Date = txt開始日.Text
        If get日付 < Now.Date Then
            'sfrmメッセージ.ShowDialog("本日より前に登録された予定は、更新できません。")
            'btn追加.Enabled = False
            Call mode選択()
            Exit Sub
        End If

        Select Case dgv一覧.Columns(e.ColumnIndex).Name
'------ 削除を選択した場合---------
            Case "削除"      '繰返しなしの場合の削除
                Dim delete As String = "d"
                Call mode表示(delete)

                Select Case sfrmメッセージ.ShowDialog("明細欄のデーターを" & vbCrLf & "" &
                                                      vbCrLf & "削除します。よろしいですか？", "確認",
                                                      MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

                    Case Windows.Forms.DialogResult.OK
                        '  Exit Sub
                        '' 削除
                        msSQL = " DELETE FROM MST_スケジュール "
                        msSQL += " WHERE ID = '" & getID & "'"

                        mCommand = cDB.getsqlComand(msSQL)
                        Call mCommand.ExecuteNonQuery()

                    Case Else
                End Select

                Call subクリア()
                Call sub予定表示(get日付)
                Call mode選択()
                'Call btnOK.Select()

'------ 複数削除を選択した場合--------     
            Case "複数削除"         ''繰返しありの場合の削除
                Dim delete As String = "d"
                Call mode表示(delete)

                '            '再確認
                Dim dtbl削除一覧 As New DataTable
                '  Dim str As String
                msSQL = dtbl予定msSQL()
                msSQL += " WHERE 予定ID ="
                msSQL += "'" & txt予定ID.Text & "'"
                msSQL += "AND 開始日>= "
                msSQL += "'" & get日付.ToString("") & "'"
                mCommand = cDB.getsqlComand(msSQL)
                mSDA.SelectCommand = mCommand
                Call mSDA.Fill(dtbl削除一覧) ''データセット作成
                Dim recCount As Integer = dtbl削除一覧.Rows.Count     '削除対象の件数
                dgv一覧.DataSource = dtbl削除一覧

                '  System.Threading.Thread.Sleep(100)  'すこしあとにMSG
                Select Case sfrmメッセージ.ShowDialog("一覧表の " & recCount & "件　を削除します。" &
                                                        vbCrLf & "もとにはもどせません。", "最終確認",
                                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    Case Windows.Forms.DialogResult.OK
                        '全削除
                        msSQL = " DELETE FROM MST_スケジュール "
                        msSQL += " WHERE 予定ID ="
                        msSQL += "'" & txt予定ID.Text & "'"
                        msSQL += "AND 開始日>= "
                        msSQL += "'" & get日付.ToString("") & "'"

                        mCommand = cDB.getsqlComand(msSQL)
                        Call mCommand.ExecuteNonQuery()

                    Case Else
                        '    Exit Sub
                End Select

                Call subクリア()
                Call sub予定表示(get日付)
                Call mode選択()

            Case Else
                Dim update As String = "U"
                Call mode表示(update)

                grp更新時Enable.Enabled = False
                Call dtp開始時間.Select()
        End Select


        '   Call dtp開始時間.Select()
    End Sub

    Private Sub btn開始日_Click(sender As Object, e As EventArgs)
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()
        txt開始日.Text = sfrm.日付
        '   txt終了日.Text = txt開始日.Text   '開始日に合わせる
    End Sub
    Private Sub btn終了日_Click(sender As Object, e As EventArgs) Handles btn終了日.Click
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()
        txt終了日.Text = sfrm.日付
    End Sub

    '
    '[予定ID] 最大値を取得
    '   予定ID付与規則
    '     DateTime.Now.ToString("MMdd") +  登録順　　ex.　12月31日　なら　"1231000”　となる   
    '     データベースに書き込むときは、整数化して容量を節約する。読み出し時は、Tostring("0######")でゼロ埋めする。
    '     
    Private Function getMaxId() As Integer

        Dim mCommand As SqlCommand
        Dim mSDA As New SqlDataAdapter

        '予定ID ベース取得　yyMM  & "010"
        Dim IdBase As Integer = Integer.Parse(DateTime.Now.ToString("MMdd") + "001")
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim mytable As New DataTable
        Dim MaxId As Integer

        msSQL = " SELECT * FROM MST_スケジュール"
        msSQL += " ORDER BY 予定ID DESC"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(mytable) ''データセット作成

        If mytable.Rows.Count = 0 Then
            MaxId = IdBase
        Else

            Select Case mytable.Rows(0).Item("予定ID")

                Case >= IdBase
                    '  Dim intMaxId As Integer = Integer.Parse(mytable.Rows(0).Item("予定ID")) + 1
                    MaxId = mytable.Rows(0).Item("予定ID") + 1
                Case Else
                    MaxId = IdBase

            End Select
        End If
        Return MaxId
        mytable.Clear()
    End Function

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        ' Dim P1 As String
        Dim sfrm As New sfrmScolorサンプル
        sfrm.RtnColor = 予定color
        sfrm.ShowDialog()
        予定color = sfrm.RtnColor
        txtColor.Text = 予定color
        'Dim r, g, b As Byte
        'Call makeParam(予定color, r, g, b)          'プロパティに値を設定
        'btnColor.BackColor = Color.FromArgb(r, g, b)
        'txtColor.BackColor = Color.FromArgb(r, g, b)
        Dim RGB() As String
        RGB = mdlCommon.rtnParameter(予定color)
        btnColor.BackColor = Color.FromArgb(RGB(0), RGB(1), RGB(2))
        txtColor.BackColor = Color.FromArgb(RGB(0), RGB(1), RGB(2))
        txtColor.ForeColor = Color.FromArgb(RGB(0), RGB(1), RGB(2))

        Call txt予定.Select()

    End Sub

    'Public Shared Function rtnRGB(ByVal hexNum As String) As String()
    '    Dim P(2) As String
    '    Dim strTempColor As String
    '    Dim HexKasira As String = "&H"
    '    strTempColor = hexNum
    '    Select Case hexNum.Length         'HexのLengthによる処理
    '        Case 1 To 2
    '            P(0) = "&H0"
    '            P(1) = "&H0"
    '            P(2) = HexKasira & Mid(strTempColor, 1)
    '        Case 3
    '            P(0) = "&H0"
    '            P(1) = HexKasira & Mid(strTempColor, 1, 1)
    '            P(2) = HexKasira & Mid(strTempColor, 2, 2)
    '        Case 4
    '            P(0) = "&H0"
    '            P(1) = HexKasira & Mid(strTempColor, 1, 2)
    '            P(2) = HexKasira & Mid(strTempColor, 3, 2)
    '        Case 5
    '            P(0) = HexKasira & Mid(strTempColor, 1, 1)
    '            P(1) = HexKasira & Mid(strTempColor, 2, 2)
    '            P(2) = HexKasira & Mid(strTempColor, 4, 2)
    '        Case 6
    '            P(0) = HexKasira & Mid(strTempColor, 1, 2)
    '            P(1) = HexKasira & Mid(strTempColor, 3, 2)
    '            P(2) = HexKasira & Mid(strTempColor, 5, 2)
    '        Case Else
    '            P(0) = "&Hff"
    '            P(1) = "&Hff"
    '            P(2) = "&Hff"
    '    End Select

    '    Return P
    'End Function


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call subクリア()
        Call sub予定取得(get日付)
        Call sub予定表示(get日付)
        Call mode選択()
    End Sub
End Class
