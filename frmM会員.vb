Imports System.Data
Imports System.Data.SqlClient
Imports System.Text  ''エンコード時使用
Imports ClosedXML.Excel

Public Class frmM会員
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private mdtbl会員 As New DataTable
    Private mclsコンボ As New clsコンボボックス
    'Public my環境設定 As cls環境設定
    'Public MS会員ID As String
    'Public MS氏名 As String

    Private yomiConv As ImeComposition.ImeYomiConversion

    Private Sub frmM会員_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '画面の初期化
        Call subクリア()

        'コンボボックスの呼び出し
        Call mclsコンボ.口座区分コンボ(cmb口座種類)
        Call mclsコンボ.職名コンボ(cmb役職名)
        Call mclsコンボ.担当理事コンボ(cmb担当理事)

        'カナ自動入力
        yomiConv = New ImeComposition.ImeYomiConversion(txt氏名, txtフリガナ)

        mdtbl会員 = dtbl会員一覧取得()
        With dgv一覧
            .DataSource = mdtbl会員
            'Call グリッド並び()
        End With

    End Sub

    'Private Sub グリッド並び()
    '    'グリッド表示順
    '　　'データベースのテーブルと同じ順番ならいらない　　
    '    With dgv一覧
    '        .Columns("colID").DisplayIndex = 0
    '        .Columns("col会員ID").DisplayIndex = 1
    '        .Columns("colパスワード").DisplayIndex = 2
    '        .Columns("colフリガナ").DisplayIndex = 3
    '        .Columns("col氏名").DisplayIndex = 4
    '        .Columns("col役職名").DisplayIndex = 5
    '        .Columns("col性別").DisplayIndex = 6
    '        .Columns("col生年月日").DisplayIndex = 7
    '        .Columns("col郵便番号").DisplayIndex = 8
    '        .Columns("col住所").DisplayIndex = 9
    '        .Columns("col電話番号").DisplayIndex = 10
    '        .Columns("colラインID").DisplayIndex = 11
    '        .Columns("colメールアドレス").DisplayIndex = 12
    '        .Columns("col担当理事").DisplayIndex = 13
    '        .Columns("col入会日").DisplayIndex = 14
    '        .Columns("col退会日").DisplayIndex = 15
    '        .Columns("col銀行名").DisplayIndex = 16
    '        .Columns("col銀行支店名").DisplayIndex = 17
    '        .Columns("col口座種類").DisplayIndex = 18
    '        .Columns("col口座番号").DisplayIndex = 19
    '        .Columns("col口座名義").DisplayIndex = 20
    '        .Columns("col備考").DisplayIndex = 21

    '    End With

    'End Sub

    Private Sub txt氏名_Enter(sender As Object, e As EventArgs) Handles txt氏名.Enter
        yomiConv.Enabled = True
    End Sub

    Private Sub txt氏名_Leave(sender As Object, e As EventArgs) Handles txt氏名.Leave
        yomiConv.Enabled = False
    End Sub

    Private Sub btn生年月日_Click(sender As Object, e As EventArgs) Handles btn生年月日.Click
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()
        txt生年月日.Text = sfrm.日付
    End Sub

    Private Sub btn入会日_Click(sender As Object, e As EventArgs) Handles btn入会日.Click
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()
        txt入会日.Text = sfrm.日付
    End Sub

    Private Sub btn退会日_Click(sender As Object, e As EventArgs) Handles btn退会日.Click
        Dim sfrm As New sfrm日付選択
        Call sfrm.ShowDialog()
        txt退会日.Text = sfrm.日付
    End Sub

    Private Sub btn取得_Click(sender As Object, e As EventArgs) Handles btn取得.Click
        Dim sfrm As New sfrm住所検索
        sfrm.検索郵便 = txt郵便番号.Text
        Call sfrm.ShowDialog()

        txt郵便番号.Text = sfrm.検索郵便
        txt住所.Text = sfrm.検索住所

        Call txt住所.Select(Len(txt住所.Text), 0)
    End Sub

    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click

        'エラーチェック

        With txt会員ID
            Select Case .Text
                Case ""
                    MessageBox.Show("会員IDは必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Call .Select()
                    Exit Sub

                Case Else
                    If IsNumeric(.Text) = False Then
                        MessageBox.Show("会員IDは数字入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Call .Select()
                        Exit Sub
                    End If

            End Select
        End With

        With txtパスワード
            Select Case .Text
                Case ""
                    MessageBox.Show("パスワードは必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Call .Select()
                    Exit Sub

                Case Else
                    If IsNumeric(.Text) = False Then
                        MessageBox.Show("パスワードは数字入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Call .Select()
                        Exit Sub
                    End If

            End Select
        End With

        With txt氏名
            Select Case .Text
                Case ""
                    MessageBox.Show("氏名は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Call .Select()
                    Exit Sub

                Case Else

                    If Len(.Text) >= 50 Then
                        MessageBox.Show("氏名は50文字以内の入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Call .Select()
                        Exit Sub
                    End If

            End Select
        End With

        With txt生年月日
            Select Case .Text
                Case ""
                    MessageBox.Show("生年月日は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Call .Select()
                    Exit Sub

                Case Else
                    If IsDate(.Text) = False Then
                        MessageBox.Show("正しい生年月日を入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Call .Select()
                        Exit Sub
                    End If


            End Select
        End With

        With txt電話番号
            Dim get電話番号 As String
            get電話番号 = txt電話番号.Text.Replace("-", "")
            Select Case .Text
                Case ""
                    MessageBox.Show("電話番号は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Call .Select()
                    Exit Sub

                Case Else
                    If IsNumeric(get電話番号) = False Then
                        MessageBox.Show("正しい電話番号を入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Call .Select()
                        Exit Sub
                    End If

                    If Len(get電話番号) >= 13 Then
                        MessageBox.Show("正しい電話番号を入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Call .Select()
                        Exit Sub
                    End If

            End Select
        End With

        With txtメールアドレス
            Select Case .Text
                Case ""

                Case Else
                    If .Text.Contains("@") = False Then
                        MessageBox.Show("正しいメールアドレスを入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Call .Select()
                        Exit Sub
                    End If
            End Select

        End With

        With txt入会日
            Select Case .Text
                Case ""
                    MessageBox.Show("入会日は必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Call .Select()
                    Exit Sub

                Case Else
                    If IsDate(.Text) = False Then
                        MessageBox.Show("正しい入会日を入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Call .Select()
                        Exit Sub
                    End If

            End Select
        End With

        'ハイフンが入っていた場合は取り除く

        txt郵便番号.Text = Replace(txt郵便番号.Text, "-", "")

        'ラジオボタンのデータ取得

        Dim 性別 As String = ""
        If rdo男.Checked = True Then
            性別 = "1"
        End If
        If rdo女.Checked = True Then
            性別 = "2"
        End If

        Dim cDB As New clsDB
        Dim dtbl会員 As New DataTable
        'Dim get施設ID As String = my環境設定.施設ID
        Dim get会員ID As String = txt会員ID.Text

        '登録出来るか検索

        msSQL = "Select * FROM MST_会員"
        'msSQL += " WHERE 施設ID = " & get施設ID & "'"
        'msSQL += " AND 会員ID='" & get会員ID & "'"
        msSQL += " WHERE 会員ID='" & get会員ID & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl会員)

        '新規か登録かIF文

        If dtbl会員.Rows.Count = 0 Then

            '新規

            msSQL = "INSERT INTO MST_会員("

            'msSQL += " 施設ID"
            'msSQL += ",会員ID"
            msSQL += " 会員ID"
            msSQL += ",パスワード"
            msSQL += ",フリガナ"
            msSQL += ",氏名"
            msSQL += ",役職名"
            msSQL += ",性別"
            msSQL += ",生年月日"
            msSQL += ",郵便番号"
            msSQL += ",住所"
            msSQL += ",電話番号"
            msSQL += ",ラインID"
            msSQL += ",メールアドレス"
            msSQL += ",担当理事"
            msSQL += ",入会日"
            msSQL += ",退会日"
            msSQL += ",銀行名"
            msSQL += ",銀行支店名"
            msSQL += ",口座種類"
            msSQL += ",口座番号"
            msSQL += ",口座名義"
            msSQL += ",備考"

            msSQL += ")VALUES("

            'msSQL += " '" & get施設ID & "'"
            'msSQL += ",'" & txt会員ID.Text & "'"
            msSQL += " '" & txt会員ID.Text & "'"
            msSQL += ",'" & txtパスワード.Text & "'"
            msSQL += ",'" & txtフリガナ.Text & "'"
            msSQL += ",'" & txt氏名.Text & "'"
            msSQL += ",'" & cmb役職名.Text & "'"
            msSQL += ",'" & 性別.ToString & "'"
            msSQL += ",'" & txt生年月日.Text & "'"
            msSQL += ",'" & txt郵便番号.Text & "'"
            msSQL += ",'" & txt住所.Text & "'"
            msSQL += ",'" & txt電話番号.Text & "'"
            msSQL += ",'" & txtラインID.Text & "'"
            msSQL += ",'" & txtメールアドレス.Text & "'"
            msSQL += ",'" & cmb担当理事.Text & "'"
            msSQL += ",'" & txt入会日.Text & "'"
            msSQL += ",NULL"
            msSQL += ",'" & txt銀行名.Text & "'"
            msSQL += ",'" & txt銀行支店名.Text & "'"
            msSQL += ",'" & cmb口座種類.SelectedValue & "'"
            msSQL += ",'" & txt口座番号.Text & "'"
            msSQL += ",'" & txt口座名義.Text & "'"
            msSQL += ",'" & txt備考.Text & "'"

            msSQL += ")"

        Else
            Select Case MessageBox.Show("会員ID:" & get会員ID & "の修正を行います。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                Case ShowDialog.OK
                Case Else
                    Exit Sub
            End Select

            '更新

            msSQL = " Update MST_会員 SET"
            msSQL += " パスワード = '" & Trim(txtパスワード.Text) & "'"
            msSQL += ",フリガナ = '" & Trim(txtフリガナ.Text) & "'"
            msSQL += ",氏名 = '" & Trim(txt氏名.Text) & "'"
            msSQL += ",役職名 = '" & Trim(cmb役職名.Text) & "'"
            msSQL += ",性別 = '" & Trim(性別.ToString) & "'"
            msSQL += ",生年月日 = '" & Trim(txt生年月日.Text) & "'"
            msSQL += ",郵便番号 = '" & Trim(txt郵便番号.Text) & "'"
            msSQL += ",住所 = '" & Trim(txt住所.Text) & "'"
            msSQL += ",電話番号 = '" & Trim(txt電話番号.Text) & "'"
            msSQL += ",ラインID = '" & Trim(txtラインID.Text) & "'"
            msSQL += ",メールアドレス = '" & Trim(txtメールアドレス.Text) & "'"
            msSQL += ",担当理事 = '" & Trim(cmb担当理事.Text) & "'"
            msSQL += ",入会日 = '" & Trim(txt入会日.Text) & "'"

            If txt退会日.Text = "" Then
                msSQL += ",退会日 =NULL"
            Else
                msSQL += ",退会日 ='" & Trim(txt退会日.Text) & "'"
            End If

            msSQL += ",銀行名 = '" & Trim(txt銀行名.Text) & "'"
            msSQL += ",銀行支店名 = '" & Trim(txt銀行支店名.Text) & "'"
            msSQL += ",口座種類 = '" & Trim(cmb口座種類.Text) & "'"
            msSQL += ",口座番号 = '" & Trim(txt口座名義.Text) & "'"
            msSQL += ",口座名義 = '" & Trim(txt口座名義.Text) & "'"
            msSQL += ",備考 = '" & Trim(txt備考.Text) & "'"

            'msSQL += " WHERE 施設ID = " & get施設ID & "'"
            'msSQL += " AND 会員ID='" & get会員ID & "'"
            msSQL += " WHERE 会員ID='" & get会員ID & "'"

            CType(sender, Button).ForeColor = Color.Red
        End If

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        '初期化
        MessageBox.Show("登録が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call subクリア()

        mdtbl会員 = dtbl会員一覧取得()

        With dgv一覧
            .DataSource = mdtbl会員
            'Call グリッド並び()
        End With

        Call cDB.Close()

    End Sub

    Private Sub btnクリア_Click(sender As Object, e As EventArgs) Handles btnクリア.Click
        Call subクリア()

    End Sub

    Private Sub subクリア()
        txt会員ID.Text = ""
        txtパスワード.Text = ""
        txtフリガナ.Text = ""
        txt氏名.Text = ""
        cmb役職名.Text = ""
        txt生年月日.Text = ""
        txt郵便番号.Text = ""
        txt住所.Text = ""
        txt電話番号.Text = ""
        txtラインID.Text = ""
        txtメールアドレス.Text = ""
        cmb担当理事.Text = ""
        txt入会日.Text = ""
        txt退会日.Text = ""
        txt銀行名.Text = ""
        txt銀行支店名.Text = ""
        cmb口座種類.Text = ""
        txt口座番号.Text = ""
        txt口座名義.Text = ""
        txt備考.Text = ""

        Call txt会員ID.Select()
    End Sub

    Private Function dtbl会員一覧取得(Optional set会員ID As String = "") As DataTable
        Dim cDB As New clsDB
        Dim myTable As New DataTable

        msSQL = "SELECT * FROM MST_会員"
        'msSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        'If set会員ID <> 0 Then msSQL += " AND 会員ID='" & set会員ID & "'"
        If set会員ID <> "" Then msSQL += " WHERE 会員ID='" & set会員ID & "'"
        msSQL += " ORDER BY 退会日,CONVERT(int,会員ID)"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        Return myTable

    End Function

    Private Sub dgv一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellClick

        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        Dim dtbl会員 As DataTable
        Dim get会員ID, get氏名, get送信先LINEID As String

        Call subクリア()

        'データベースからデータを取ってくる方法
        get会員ID = Trim(dgv一覧.Rows(e.RowIndex).Cells("col会員ID").Value.ToString)
        txt会員ID.Text = get会員ID

        dtbl会員 = dtbl会員一覧取得(txt会員ID.Text)
        For Each get行 As DataRow In dtbl会員.Rows
            txtパスワード.Text = get行("パスワード").ToString
            get氏名 = get行("氏名").ToString
            txtフリガナ.Text = get行("フリガナ").ToString
            txt氏名.Text = get氏名
            cmb役職名.Text = get行("役職名").ToString
            If get行("性別").ToString = "1" Then
                rdo男.Checked = True
            Else
                rdo女.Checked = True
            End If
            txt生年月日.Text = CDate(get行("生年月日")).ToString("yyyy/MM/dd")
            txt郵便番号.Text = get行("郵便番号").ToString
            txt住所.Text = get行("住所").ToString
            txt電話番号.Text = get行("電話番号").ToString
            get送信先LINEID = get行("ラインID").ToString
            txtラインID.Text = get行("ラインID").ToString
            txtメールアドレス.Text = get行("メールアドレス").ToString
            cmb担当理事.Text = get行("担当理事").ToString
            txt入会日.Text = CDate(get行("入会日")).ToString("yyyy/MM/dd")

            If get行("退会日").ToString = "" Then
                txt退会日.Text = ""
            Else
                txt退会日.Text = CDate(get行("退会日")).ToString("yyyy/MM/dd")
            End If

            txt銀行名.Text = get行("銀行名").ToString
            txt銀行支店名.Text = get行("銀行支店名").ToString
            cmb口座種類.Text = get行("口座種類").ToString
            txt口座番号.Text = get行("口座番号").ToString
            txt口座名義.Text = get行("口座名義").ToString
            txt備考.Text = get行("備考").ToString
        Next

        'データグリッドビューからデータを取ってくる方法
        'txt会員ID.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col会員ID").Value.ToString)
        'txtパスワード.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("colパスワード").Value.ToString)
        'txt氏名.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col氏名").Value.ToString)
        'txtフリガナ.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("colフリガナ").Value.ToString)
        'cmb役職名.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col役職名").Value.ToString)

        'If Trim(dgv一覧.Rows(e.RowIndex).Cells("col性別").Value.ToString) = "1" Then
        '    rdo男.Checked = True
        'Else
        '    rdo女.Checked = True
        'End If

        'txt生年月日.Text = Trim(CDate(dgv一覧.Rows(e.RowIndex).Cells("col生年月日").Value).ToString("yyyy/MM/dd"))
        'txt郵便番号.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col郵便番号").Value.ToString)
        'txt住所.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col住所").Value.ToString)
        'txt電話番号.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col電話番号").Value.ToString)
        'txtラインID.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("colラインID").Value.ToString)
        'txtメールアドレス.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("colメールアドレス").Value.ToString)
        'cmb担当理事.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col担当理事").Value.ToString)
        'txt入会日.Text = Trim(CDate(dgv一覧.Rows(e.RowIndex).Cells("col入会日").Value).ToString("yyyy/MM/dd"))

        'If dgv一覧.Rows(e.RowIndex).Cells("col退会日").Value.ToString = "" Then
        '    txt退会日.Text = ""
        'Else
        '    txt退会日.Text = Trim(CDate(dgv一覧.Rows(e.RowIndex).Cells("col退会日").Value).ToString("yyyy/MM/dd"))
        'End If

        'txt銀行名.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col銀行名").Value.ToString)
        'txt銀行支店名.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col銀行支店名").Value.ToString)
        'cmb口座種類.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col口座種類").Value.ToString)
        'txt口座番号.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col口座番号").Value.ToString)
        'txt口座名義.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col口座名義").Value.ToString)
        'txt備考.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col備考").Value.ToString)


        Select Case dgv一覧.Columns(e.ColumnIndex).Name
            Case "col会員ID"
                Dim sfrm As New sfrm会員情報
                sfrm.会員 = get会員ID
                Call sfrm.ShowDialog()

            Case "colLINE送信"
                Dim sfrm As New sfrmLineメッセージ
                sfrm.s送信先会員ID = get会員ID
                sfrm.s送信先会員名 = get氏名
                sfrm.s送信先LINEID = get送信先LINEID
                Call sfrm.ShowDialog()

        End Select


    End Sub

    Private Sub btn会員名簿_Click(sender As Object, e As EventArgs) Handles btn会員名簿.Click
        Dim sテンプレートパス As String = "Temp/会員名簿.xlsx"
        Dim getExcelファイル As String

        Try
            'Excelファイルを開く
            Using workbook = New ClosedXML.Excel.XLWorkbook(sテンプレートパス)
                'ワークシートを取得する
                Dim worksheet As ClosedXML.Excel.IXLWorksheet = workbook.Worksheet("Sheet1")

                Dim cel施設名 = worksheet.Cell(5, "H") ' 行番号と列名でも指定可能
                '    cel施設名.Value = my環境設定.施設名

                Dim n行カウント As Integer = 9
                For Each get行 As DataRow In mdtbl会員.Rows
                    '位置を指定してセルを取得する
                    Dim cel役職名 = worksheet.Cell(n行カウント, 2) ' 行番号と列名でも指定可能
                    cel役職名.Value = get行("役職名").ToString

                    Dim cel氏名 = worksheet.Cell(n行カウント, 3) ' 行番号と列名でも指定可能
                    cel氏名.Value = get行("氏名").ToString

                    Dim cel郵便番号 = worksheet.Cell(n行カウント, 4) ' 行番号と列名でも指定可能
                    cel郵便番号.Value = get行("郵便番号").ToString

                    Dim cel住所 = worksheet.Cell(n行カウント, 5) ' 行番号と列名でも指定可能
                    cel住所.Value = get行("住所").ToString

                    Dim cel電話番号 = worksheet.Cell(n行カウント, 6) ' 行番号と列名でも指定可能
                    cel電話番号.Value = get行("電話番号").ToString

                    Dim cel担当理事 = worksheet.Cell(n行カウント, 7) ' 行番号と列名でも指定可能
                    cel担当理事.Value = get行("担当理事").ToString

                    Dim cel備考 = worksheet.Cell(n行カウント, 8) ' 行番号と列名でも指定可能
                    cel備考.Value = get行("備考").ToString

                    n行カウント += 1
                Next

                'ワークブックを保存する
                Using sfd As SaveFileDialog = New SaveFileDialog
                    'デフォルトのファイル名を指定します
                    sfd.Filter = "Excelファイル(*.xlsx)|*.xlsx"
                    sfd.FileName = "会員名簿"
                    sfd.InitialDirectory = System.Windows.Forms.Application.StartupPath & "\Excel"

                    If sfd.ShowDialog() = DialogResult.OK Then
                        getExcelファイル = sfd.FileName
                        workbook.SaveAs(getExcelファイル)     ''別ブックで保存

                        ''作成ファイルオープン
                        Select Case sfrmメッセージ.ShowDialog("フィルが作成されました。" & vbCrLf _
                                                    & "作成ファイルを開きますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                            Case vbOK
                                Dim execProc As New Process
                                With execProc
                                    .StartInfo.FileName = getExcelファイル
                                    .Start()
                                End With
                        End Select

                    End If
                End Using
            End Using



        Catch ex As Exception
            sfrmメッセージ.ShowDialog(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class
