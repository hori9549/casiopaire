'210307個別表示カレンダー　
'210512スケジュール管理 source整頓

Imports System.Data
Imports System.Data.SqlClient

Public Class frm個別カレンダー
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private 表示mode As Boolean = True   '表示mode ON 中は、追加btnを、押せなくする
    Private n_個別表示 As Integer = -1   'dtbl個別表示 の Current Row Number
    Private 規定色 As String = "D9D9D9"
    Private get日付 As Date
    Public Property 日付() As Date
        Get
            Return get日付
        End Get

        Set(ByVal value As Date)
            get日付 = value
        End Set
    End Property


    Private Sub frm個別カレンダー_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''見出し等 初期設定
        lbl日付.Text = get日付.ToString("yyyy/MM/dd（ddd）")

        Call subクリア()
        Call sub予定表示(get日付)
        dgv個別表示.CurrentCell = Nothing
        '  dgv個別表示.CurrentCell = dgv個別表示(0, 1)
    End Sub
    Private Sub subクリア()
        For Each row As DataGridViewRow In dgv個別表示.Rows
            dgv個別表示.Rows.Remove(row)
        Next
    End Sub

    Private Sub sub予定表示(set日付 As Date)
        Dim cDB As New clsDB
        Dim dtbl予定 As New DataTable
        Dim dtbl個別表示 As New DataTable

        dtbl個別表示.Columns.Add("ID")
        dtbl個別表示.Columns.Add("氏名")
        dtbl個別表示.Columns.Add("予定追加")
        ' dtbl個別表示.Columns.Add("◁")
        dtbl個別表示.Columns.Add("０")
        dtbl個別表示.Columns.Add("１")
        dtbl個別表示.Columns.Add("２")
        dtbl個別表示.Columns.Add("３")
        dtbl個別表示.Columns.Add("４")
        dtbl個別表示.Columns.Add("５")
        dtbl個別表示.Columns.Add("６")
        dtbl個別表示.Columns.Add("７")
        dtbl個別表示.Columns.Add("８")
        dtbl個別表示.Columns.Add("９")
        dtbl個別表示.Columns.Add("１０")
        dtbl個別表示.Columns.Add("１１")
        dtbl個別表示.Columns.Add("１２")
        dtbl個別表示.Columns.Add("１３")
        dtbl個別表示.Columns.Add("１４")
        dtbl個別表示.Columns.Add("１５")
        dtbl個別表示.Columns.Add("１６")
        dtbl個別表示.Columns.Add("１７")
        dtbl個別表示.Columns.Add("１８")
        dtbl個別表示.Columns.Add("１９")
        dtbl個別表示.Columns.Add("２０")
        dtbl個別表示.Columns.Add("２１")
        dtbl個別表示.Columns.Add("２２")
        dtbl個別表示.Columns.Add("２３")
        dtbl個別表示.Columns.Add("▷")

        '表示する会員の一覧表取得
        '   退会者も表示対象 (予定登録のほうで、新規登録はできない)   
        Dim getSQL As String
        '    Dim wりcheck As Boolean = False
        Dim dtbl会員ID As New DataTable

        If Not dtbl会員ID Is Nothing Then dtbl会員ID.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT 会員ID"
        getSQL += " FROM MST_会員"
        'getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " ORDER BY 会員ID"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl会員ID)

        'For each 会員　　で回すべき
        '   For kid = 1 To 5
        For Each get会員ID As DataRow In dtbl会員ID.Rows
            If Not dtbl予定 Is Nothing Then dtbl予定.Clear()
            Dim wりcheck As Boolean = False
            msSQL = " Select a.* "
            msSQL += ",b.氏名 "

            msSQL += " FROM MST_スケジュール As a INNER JOIN MST_会員 b "
            msSQL += " On a.会員ID = b.会員ID "
            msSQL += " WHERE 開始日='" & set日付 & "'"
            msSQL += " AND a. 会員ID =" & get会員ID("会員ID")
            msSQL += " ORDER BY a.会員ID,開始日,開始時間"

            mCommand = cDB.getsqlComand(msSQL)
            mSDA.SelectCommand = mCommand
            Call mSDA.Fill(dtbl予定) ''データセット


            Dim i As Integer = 0
            For Each get行 As DataRow In dtbl予定.Rows

                Dim row追加 As DataRow = dtbl個別表示.NewRow
                If wりcheck = False Then
                    row追加("氏名") = get行("氏名")
                    wりcheck = True
                Else
                    row追加("氏名") = ""
                End If

                Dim s予定 As String = ""
                s予定 += get行("予定") & vbCrLf
                s予定 += get行("記事") & vbCrLf

                s予定 += get行("開始時間") & " ～ "
                s予定 += get行("終了時間") & vbCrLf

                s予定 += get行("開始日") & " ～ "
                s予定 += get行("終了日")

                row追加("予定追加") = s予定

                ''横棒グラフの形成

                '開始日,終了日のマーキング
                Dim endDay As Date = get行("終了日")
                If endDay > get日付 Then
                    row追加("▷") = get行("color")
                End If
                Dim tgtDate As Date = get日付
                '  Dim tgtDate As Date = lbl日付.Text
                Dim td_s As String = tgtDate.ToString("yyyyMMdd") & "0000"
                Dim td_e As String = tgtDate.ToString("yyyyMMdd") & "2359"   '1日の終わり時間

                Dim sC, eC As Integer '色付けを開始.終了するCell
                Dim td1 As Date = get行("開始時間")
                Dim td2 As Date = get行("終了時間")

                If (td1 = "00:00") And (td2 = "00:00") Then     '時間の指定がない場合
                    sC = 0
                    eC = 0
                Else

                    Dim tdHHmm As String = td1.ToString("HHmm")
                    Dim td開始 As String = tgtDate.ToString("yyyyMMdd") & tdHHmm

                    tdHHmm = td2.ToString("HHmm")
                    Dim td終了 As String = tgtDate.ToString("yyyyMMdd") & tdHHmm

                    sC = relat_s(td_s, td開始)  'startCELL
                    eC = relat_e(td_e, td終了)  'endCELL
                    If sC >= eC Then eC = sC    '1jikanndake表示

                End If
                With dtbl個別表示

                    Dim colNam As String
                    For i = 0 To 23
                        colNam = .Columns(i + 3).ColumnName
                        row追加(colNam) = ""
                    Next
                    Dim j As Integer = sC + 2
                    Do While j <= (eC + 2)        '' 5:それ以前 30:それ以後
                        colNam = .Columns(j).ColumnName
                        row追加(colNam) = get行("color")
                        j += 1
                    Loop
                End With
                dtbl個別表示.Rows.Add(row追加)
            Next
        Next

        dgv個別表示.DataSource = dtbl個別表示
        Call グリッドstyle()

    End Sub
    Private Sub グリッドstyle()
        '列のソート禁止
        For Each colm As DataGridViewColumn In dgv個別表示.Columns  'ソート禁止
            colm.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        dgv個別表示.Columns("col予定追加").DefaultCellStyle.Font = New Font(“ＭＳ ゴシック”, 10)

        Call self_formating()   '採色

        'ヘッダーとすべてのセルの内容に合わせて、行の高さを自動調整する
        dgv個別表示.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv個別表示.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
        dgv個別表示.DefaultCellStyle.BackColor = Color.LightGreen

        Call グリッド並び()
        dgv個別表示.CurrentCell = Nothing
    End Sub
    Private Sub グリッド並び()
        ''グリッド表示順
        With dgv個別表示
            .Columns("col会員ID").DisplayIndex = 0
            .Columns("col氏名").DisplayIndex = 1
            .Columns("col予定").DisplayIndex = 2
        End With
    End Sub
    Private Sub subクリアー()
        dgv個別表示.DataSource = ""
    End Sub
    '
    '時間の相対位置(relative)を返す
    Private Function relat_s(td_s As String, td As String) As Integer
        If td < td_s Then  '予定が表示日付よりも前に始まっている場合
            Return 0            '' 0:それ以前 
        Else
            Return Int(td.Substring(8, 2)) + 1     '相対位置
        End If
    End Function
    Private Function relat_e(td_e As String, td As String) As Integer    '終了時間の位置検索
        If td > td_e Then  '予定が終了日時よりも後にある場合
            Return 25                 ''  25:それ以後
        Else
            ''00,15,30,45分のときは、帯を繰り上げない
            ' If td.Substring(10, 2) = "00" Or td.Substring(10, 2) = "30" Then
            ' If ("00", "15", "30", "45").contains(td.Substring(10, 2)) Then
            '00分のときは、帯を繰り上げない
            If (td.Substring(10, 2) + 60) Mod 60 = 0 Then
                Return Int(td.Substring(8, 2))
            Else
                Return Int(td.Substring(8, 2)) + 1
            End If
        End If
    End Function

    Private Sub dgv個別表示_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv個別表示.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        Select Case dgv個別表示.Columns(e.ColumnIndex).Name
            Case "col予定追加"

                Dim sfrm As New sfrmS予定登録
                sfrm.日付 = get日付.ToString("yyyy/MM/dd")
                sfrm.ShowDialog()

                Call sub予定表示(get日付)

        End Select

    End Sub

    Private Sub btn進む_Click(sender As Object, e As EventArgs) Handles btn進む.Click
        get日付 = DateAdd("d", 1, get日付)
        lbl日付.Text = get日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call sub予定表示(get日付)
    End Sub

    Private Sub btn戻る_Click(sender As Object, e As EventArgs) Handles btn戻る.Click
        get日付 = DateAdd("d", -1, get日付)
        lbl日付.Text = get日付.ToString("yyyy/MM/dd（ddd）")
        Call subクリア()
        Call sub予定表示(get日付)
    End Sub


    Private Sub self_formating()
        Dim strStatus As String
        Dim hexColor As String

        Dim n_row As Integer
        Dim n_col As Integer


        For n_row = 0 To dgv個別表示.RowCount - 1

            For n_col = 0 To dgv個別表示.ColumnCount - 1         'dgv個別表示.Columns.Count - 1

                With dgv個別表示.Rows(n_row).Cells(n_col)

                    If .Value IsNot Nothing Then

                        strStatus = .Value.ToString

                        Select Case strStatus.Length
                            Case 0
                                .Style.BackColor = Color.White
                                '     .Value.ToString.Remove(0, 2)     '先頭の改行コードを取り除く
                            Case Else
                                ''取り出した文字は、整数か？
                                Dim d As Integer
                                If Integer.TryParse(strStatus, d) Then
                                    Dim P(3) As String
                                    hexColor = Convert.ToString(d, 16)
                                    '  Call makeParam(hexColor, R, G, B)
                                    P = mdlCommon.rtnParameter(hexColor)
                                    .Style.BackColor = Color.FromArgb(P(0), P(1), P(2))
                                    .Style.ForeColor = Color.FromArgb(P(0), P(1), P(2))

                                Else

                                    ' MsgBox("数字ではありません。" & strStatus)
                                End If

                        End Select
                    End If
                End With
            Next
        Next
    End Sub

End Class