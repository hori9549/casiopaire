Imports System.Data.SqlClient
Imports System.Data


Public Class frm週間表示
    Private 規定色 As String = "D9D9D9"
    Private dW(7) As String
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    '日付の受け渡し
    Private get日付 As Date

    Public Property 日付() As Date
        Get
            Return get日付
        End Get

        Set(ByVal value As Date)
            get日付 = value
        End Set
    End Property

    Private Sub 週間表示_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''見出し等 初期設定
        lbl日付.Text = get日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call sub予定表示(get日付)

    End Sub
    Private Sub subクリア()

    End Sub
    Private Sub sub予定表示(get日付)
        Dim dtbl会員名簿 As New DataTable
        Dim dtbl週間表示 As New DataTable
        Dim dtblタイトル As New DataTable
        Dim dtbl予定 As New DataTable

        '  dtbl会員名簿の形成
        '    Dim dtbl会員名簿 As New DataTable
        Dim cDB As New clsDB
        Dim mCommand As SqlCommand

        ''検索SQL======================================================
        msSQL = "SELECT DISTINCT 氏名 ,会員ID"
        msSQL += " FROM MST_会員"
        msSQL += " ORDER BY 会員ID,氏名"
        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl会員名簿)

        Dim dtbl週間カレンダー As New DataTable
        dtbl週間カレンダー.Columns.Add("表示する日付")

        dtbl週間表示.Columns.Add("ID")
        dtbl週間表示.Columns.Add("氏名")

        Dim sbjDt As Date = get日付      '表示対象日付 
        Dim wd As Integer = Weekday(sbjDt) ' 4:水曜日
        If wd = 1 Then wd = 8       '日曜日だったら6日前から表示 

        Dim monDt As Date = DateAdd(DateInterval.Day, (2 - wd), sbjDt)
        Dim row週間カレンダー As DataRow

        For i = 0 To 6
            row週間カレンダー = dtbl週間カレンダー.NewRow
            row週間カレンダー("表示する日付") = monDt.AddDays(i).ToString("yyyy/MM/dd")
            dtbl週間カレンダー.Rows.Add(row週間カレンダー)

            dW(i) = monDt.AddDays(i).ToString("MM/dd (ddd)")
        Next
        ' Dim d月 As String = dt.AddDays(2 - wd).ToString("MM/dd (ddd)")

        '  dtbl週間表示(0)(3) = dt.AddDays(2 - wd).ToString("MM/dd (ddd)")
        dtbl週間表示.Columns.Add(dW(0))
        dtbl週間表示.Columns.Add(dW(1))    ' dtbl週間表示.Columns(3)
        dtbl週間表示.Columns.Add(dW(2))
        dtbl週間表示.Columns.Add(dW(3))
        dtbl週間表示.Columns.Add(dW(4))
        dtbl週間表示.Columns.Add(dW(5))
        dtbl週間表示.Columns.Add(dW(6))
        ''予定読込-----------------------------------------------------

        '
        '  dtbl週間表示.Rows.Count-------いま何行使っているか
        '   n_strtRowIndex ------ 別の会員に移った時にどの行から書き始めるか
        '   n_eventCount -------  その日に 表示した予定の数 (使った行数)
        '   weekDindex ------- 処理中の曜日
        '    midasiFlag -----  会員名は1回だけ表示
        '   dtbl週間カレンダー ----- hyoujisuru1週間の日にちを記したもの
        '
        Dim dtblある日の〇さんの予定一覧 As New DataTable

        Dim midasiFlag As Boolean = False   '日付けは1回だけ表示
        Dim n_eventCount As Integer = 0
        Dim n_strtRowIndex As Integer = 0
        Dim weekDindex As Integer
        Dim rowIndex As Integer
        For Each get会員ID As DataRow In dtbl会員名簿.Rows

            Dim wりcheck As Boolean = False
            n_strtRowIndex = dtbl週間表示.Rows.Count
            n_eventCount = 0
            weekDindex = 1    '週初
            For Each getある日の〇さんの予定 As DataRow In dtbl週間カレンダー.Rows
                dtblある日の〇さんの予定一覧.Clear()
                ''検索SQL======================================================
                msSQL = "SELECT a.*, b.氏名"
                msSQL += " FROM MST_スケジュール as a INNER JOIN MST_会員 b "
                msSQL += " ON a.会員ID = b.会員ID"
                msSQL += " WHERE a.会員ID="
                msSQL += "'" & get会員ID("会員ID") & "'"
                msSQL += " AND 開始日="
                msSQL += "'" & getある日の〇さんの予定("表示する日付") & "'"

                mCommand = cDB.getsqlComand(msSQL)
                mSDA.SelectCommand = mCommand
                Call mSDA.Fill(dtblある日の〇さんの予定一覧)

                weekDindex += 1     '曜日がかわったのでカウントアップ
                n_eventCount = 0
                If dtblある日の〇さんの予定一覧.Rows.Count > 0 Then
                    Dim row週間表示 As DataRow = dtbl週間表示.NewRow
                    For Each get行 As DataRow In dtblある日の〇さんの予定一覧.Rows
                        n_eventCount += 1
                        '1行増やすか判定
                        If dtbl週間表示.Rows.Count < n_eventCount + n_strtRowIndex Then
                            row週間表示 = dtbl週間表示.NewRow
                            dtbl週間表示.Rows.Add(row週間表示)
                            '       n_eventCount += 1
                        End If
                        Dim s予定 As String = ""
                        s予定 += get行("color") & vbCrLf      '改行
                        s予定 += get行("予定") & vbCrLf
                        s予定 += get行("記事") & vbCrLf
                        s予定 += get行("開始時間") & " ～ "
                        s予定 += get行("終了時間") & vbCrLf
                        s予定 += get行("開始日") & " ～ "
                        s予定 += get行("終了日")

                        '      With dtbl週間表示.Rows.Count - 1
                        rowIndex = (dtbl週間表示.Rows.Count - 1) -
                                ((dtbl週間表示.Rows.Count - 1) - (n_strtRowIndex + (n_eventCount - 1)))   'どの行に書き込めばよいか

                        dtbl週間表示.Rows(rowIndex)(weekDindex) = s予定
                        If wりcheck = False Then
                            row週間表示("氏名") = get行("氏名")
                            wりcheck = True
                        Else
                            row週間表示("氏名") = ""
                        End If

                    Next
                End If
            Next

        Next
        midasiFlag = False


        dgv週間表示.DataSource = dtbl週間表示

        Call グリッドstyle()

    End Sub
    Private Sub self_formating()
        Dim str As String()
        Dim strStatus As String
        Dim hexColor As String

        Dim n_row As Integer
        Dim n_col As Integer


        For n_row = 0 To dgv週間表示.RowCount - 1
            For n_col = 2 To dgv週間表示.ColumnCount - 1
                With dgv週間表示.Rows(n_row).Cells(n_col)

                    str = Split(dgv週間表示.Rows(n_row).Cells(n_col).Value.ToString, vbCrLf)

                    strStatus = str(0)
                    Select Case strStatus.Length
                        Case 0
                            .Style.BackColor = Color.White
                        Case Else
                            ''取り出した文字は、整数か？
                            Dim d As Integer
                            If Integer.TryParse(str(0), d) Then
                                Dim P(3) As String
                                hexColor = Convert.ToString(d, 16)
                                P = sfrmS予定登録.rtnRGB(hexColor)
                                .Style.BackColor = Color.FromArgb(P(0), P(1), P(2))
                                '  .Style.ForeColor = Color.FromArgb(R, G, B)
                                .Value = .Value.ToString.Remove(0, strStatus.Length + 2)     '先頭のcolorコードと改行コードを取り除く
                                '       MsgBox("先頭からVBLFCRまでは＝", .Value.ToString)
                                .Style.Font = New Font(“ＭＳ ゴシック”, 10)

                            Else
                                '  MsgBox("数字ではありません。" & str(0))
                            End If

                    End Select

                End With

            Next
        Next
    End Sub
    Private Sub btn前_Click(sender As Object, e As EventArgs)
        get日付 = DateAdd("d", -1, get日付)
        lbl日付.Text = get日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call sub予定表示(get日付)

    End Sub

    Private Sub btn次_Click(sender As Object, e As EventArgs)
        get日付 = DateAdd("d", 1, get日付)
        lbl日付.Text = get日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call sub予定表示(get日付)
    End Sub

    Private Sub btn進む_Click(sender As Object, e As EventArgs) Handles btn進む.Click
        get日付 = DateAdd("d", 7, get日付)
        lbl日付.Text = get日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call sub予定表示(get日付)

    End Sub

    Private Sub btn戻る_Click(sender As Object, e As EventArgs) Handles btn戻る.Click
        get日付 = DateAdd("d", -7, get日付)
        lbl日付.Text = get日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call sub予定表示(get日付)


    End Sub
    Private Sub グリッドstyle()
        'dgv週間表示.RowHeadersDefaultCellStyle.Font = New Font(“ＭＳ ゴシック”, 20)

        '列のソート禁止
        For Each colm As DataGridViewColumn In dgv週間表示.Columns  'ソート禁止
            colm.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        'ヘッダーとすべてのセルの内容に合わせて、行の高さを自動調整する
        dgv週間表示.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        For i = 0 To dgv週間表示.Columns.Count - 1 'HeaderCell.Style を MiddleCenter
            dgv週間表示.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv週間表示.Columns(i).HeaderCell.Style.BackColor = Color.LightGreen

        Next

        dgv週間表示.Columns(0).Width = 50
        '  dgv週間表示.Columns(1).Width = 80
        For i = 1 To dgv週間表示.Columns.Count - 1
            dgv週間表示.Columns(i).Width = 138
        Next

        Call self_formating()   '採色
        dgv週間表示.CurrentCell = Nothing

    End Sub

    Private Sub dgv週間表示_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv週間表示.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 2 Then Exit Sub
        Dim getDay As Date
        getDay = dgv週間表示.Columns(e.ColumnIndex).Name
        '  MsgBox("clicked Day is", +getDay.ToString("yyyy/MM/dd"))
        Dim sfrm As New sfrmS予定登録
        sfrm.日付 = getDay.ToString("yyyy/MM/dd")
        sfrm.ShowDialog()

        Call sub予定表示(get日付)

    End Sub

End Class