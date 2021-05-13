

Imports System.Data
Imports System.Data.SqlClient
Imports System.IO　　''ファイル操作用
Imports System.Text  ''エンコード時使用
Public Class frmM企業
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private myコンボ As New clsコンボボックス
    'Private yomiConv As ImeComposition.ImeYomiConversion

    Private Sub frmM企業_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''コンボボックスセット
        Call myコンボ.口座区分コンボ(cmb口座種別)

        Call sub一覧表示()
        Call sub初期化()

        ''カナ自動入力
        'yomiConv = New ImeComposition.ImeYomiConversion(txt企業名.txtフリガナ)

    End Sub

    Private Sub sub一覧表示(Optional ByVal set口座名 As String = "")
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = "SELECT * "
        msSQL += " FROM MST_区分明細"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        dgv一覧.DataSource = myTable
        Call グリッド並び()

        Call cDB.Close()

    End Sub


    Private Sub sub一覧表示()
        Dim cDB As New clsDB
        'Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = "SELECT * FROM MST_企業"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        dgv一覧.DataSource = myTable
        Call グリッド並び()

        Call cDB.Close()


    End Sub

    Private Sub グリッド並び()
        ''グリッド表示順
        With dgv一覧
            .Columns("col企業ID").DisplayIndex = 0
            .Columns("colフリガナ").DisplayIndex = 1
            .Columns("col企業名").DisplayIndex = 2
            .Columns("col支店名").DisplayIndex = 3
            .Columns("col代表者名").DisplayIndex = 4
            .Columns("col担当者名").DisplayIndex = 5
            .Columns("col郵便番号").DisplayIndex = 6
            .Columns("col住所").DisplayIndex = 7
            .Columns("col電話番号").DisplayIndex = 8
            .Columns("colFAX番号").DisplayIndex = 9
            .Columns("colメールアドレス").DisplayIndex = 10
            .Columns("colHPアドレス").DisplayIndex = 11
            .Columns("col銀行名").DisplayIndex = 14
            .Columns("col銀行支店名").DisplayIndex = 15
            .Columns("col口座種別").DisplayIndex = 16
            .Columns("col口座").DisplayIndex = 17
            .Columns("col口座番号").DisplayIndex = 18
            .Columns("col口座名義").DisplayIndex = 19
            .Columns("col登録日").DisplayIndex = 20
            .Columns("col更新日").DisplayIndex = 21
            .Columns("col備考").DisplayIndex = 22
            .Columns("col社内担当者").DisplayIndex = 23
        End With

    End Sub

    Private Sub sub初期化()
        txt企業ID.Text = ""
        txt企業名.Text = ""
        txtフリガナ.Text = ""
        txt支店名.Text = ""
        txt代表者名.Text = ""

        txt郵便番号.Text = ""
        txt住所.Text = ""
        txt電話番号.Text = ""
        txtFAX番号.Text = ""
        txtメアド.Text = ""
        txtHPアドレス.Text = ""

        txt担当者名.Text = ""
        txt備考.Text = ""

        lbl登録日.Text = ""
        lbl更新日.Text = ""

        txt銀行名.Text = ""
        txt銀行支店名.Text = ""
        txt口座番号.Text = ""
        cmb口座種別.SelectedValue = 0
        txt口座名義.Text = ""

        '休日.SelectedValue &
        txt社内担当者.Text = ""

    End Sub
    Private Sub btn取得_Click(sender As Object, e As EventArgs) Handles btn郵便番号.Click

        ''郵便番号から住所の入力-----------------------------------------------------------------------
        'Dim subForm As New sfrm住所検索
        'subForm.検索郵便 = txt郵便番号.Text
        'Call subForm.ShowDialog()

        'txt郵便番号.Text = subForm.検索郵便
        'txt住所.Text = subForm.検索住所

        'Call txt住所.Select(Len(txt住所.Text), 0)

    End Sub



    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable


        ''エラーチェック==========================================================================================================

        With txt企業ID
            Select Case .Text
                Case ""
                    MessageBox.Show("企業IDは必須入力項目です", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()
                    Exit Sub
                Case Else
                    If IsNumeric(.Text) = False Then
                        MessageBox.Show("企業IDは数字入力項目です", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Call .Select()
                        Exit Sub

                    End If

            End Select
        End With

        With txt企業名
            Select Case .Text
                Case ""
                    MessageBox.Show("企業名は必須入力項目です", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()
                    Exit Sub
                Case Else
            End Select
        End With


        With txtフリガナ
            Select Case .Text
                Case ""
                    MessageBox.Show("フリガナは必須入力項目です", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()
                    Exit Sub
                Case Else
            End Select
        End With


        With txt電話番号
            Select Case .Text
                Case ""
                    MessageBox.Show("電話番号は必須入力項目です", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()
                    Exit Sub
                Case Else
                    If IsNumeric(.Text) = False Then
                        MessageBox.Show("電話番号は数字入力項目です", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Call .Select()
                        Exit Sub

                    End If

                    If Len(.Text) > 10 Then
                        MessageBox.Show("電話番号は10文字以内の入力項目です")

                        Call .Select()
                        Exit Sub

                    End If
            End Select
        End With


        ''登録===================================================================================================================
        'Try
        ''存在チェック
        msSQL = " SELECT * FROM MST_企業"
        msSQL += " WHERE 企業ID = '" & txt企業ID.Text & "'"


        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''

        If myTable.Rows.Count = 0 Then

            ''新規追加

            msSQL = " INSERT INTO  MST_企業("
            msSQL += " 企業ID,"
            msSQL += " 企業名,"
            msSQL += " フリガナ,"
            msSQL += " 支店名,"
            msSQL += " 代表者名,"
            msSQL += " 郵便番号,"
            msSQL += " 住所,"
            msSQL += " 電話番号,"
            msSQL += " FAX番号,"
            msSQL += " メールアドレス,"
            msSQL += " HPアドレス,"
            msSQL += " 担当者名,"
            msSQL += " 備考,"
            msSQL += " 登録日,"
            msSQL += " 更新日,"
            msSQL += " 銀行名,"
            msSQL += " 銀行支店名,"
            msSQL += " 口座種別,"
            msSQL += " 口座番号,"
            msSQL += " 口座名義,"
            msSQL += " 社内担当者"
            msSQL += " )"
            msSQL += " VALUES"
            msSQL += " ("
            msSQL += "'" & Trim(txt企業ID.Text) & "',"
            msSQL += "'" & Trim(txt企業名.Text) & "',"
            msSQL += "'" & Trim(txtフリガナ.Text) & "',"
            msSQL += "'" & Trim(txt支店名.Text) & "',"
            msSQL += "'" & Trim(txt代表者名.Text) & "',"
            msSQL += "'" & Trim(txt郵便番号.Text) & "',"
            msSQL += "'" & Trim(txt住所.Text) & "',"
            msSQL += "'" & Trim(txt電話番号.Text) & "',"
            msSQL += "'" & Trim(txtFAX番号.Text) & "',"
            msSQL += "'" & Trim(txtメアド.Text) & "',"
            msSQL += "'" & Trim(txtHPアドレス.Text) & "',"
            msSQL += "'" & Trim(txt担当者名.Text) & "',"
            msSQL += "'" & Trim(txt備考.Text) & "',"
            msSQL += "'" & Date.Today & "',"
            msSQL += "'" & Date.Today & "',"
            msSQL += "'" & Trim(txt銀行名.Text) & "',"
            msSQL += "'" & Trim(txt銀行支店名.Text) & "',"
            msSQL += "'" & cmb口座種別.SelectedValue & "',"
            msSQL += "'" & Trim(txt口座番号.Text) & "',"
            msSQL += "'" & Trim(txt口座名義.Text) & "',"
            msSQL += "'" & Trim(txt社内担当者.Text) & "'"
            msSQL += " )"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()

        Else
            Select Case MessageBox.Show("上書き更新を行ってもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Case Windows.Forms.DialogResult.OK
                Case Else
                    Exit Sub
            End Select


            ''更新
            msSQL = " UPDATE MST_企業 SET "
            'msSQL += " 企業ID = '" & Trim(txt企業ID.Text) & "',"
            msSQL += " 企業名 = '" & Trim(txt企業名.Text) & "',"
            msSQL += " フリガナ = '" & Trim(txtフリガナ.Text) & "',"
            msSQL += " 支店名 = '" & Trim(txt支店名.Text) & "',"
            msSQL += " 代表者名 = '" & Trim(txt代表者名.Text) & "',"
            msSQL += " 郵便番号 = '" & Trim(txt郵便番号.Text) & "',"
            msSQL += " 住所 = '" & Trim(txt住所.Text) & "',"
            msSQL += " 電話番号 = '" & Trim(txt電話番号.Text) & "',"
            msSQL += " ＦＡＸ番号 = '" & Trim(txtFAX番号.Text) & "',"
            msSQL += " メールアドレス = '" & Trim(txtメアド.Text) & "',"
            msSQL += " HPアドレス = '" & Trim(txtHPアドレス.Text) & "',"
            msSQL += " 担当者名 = '" & Trim(txt担当者名.Text) & "',"
            msSQL += " 備考 = '" & Trim(txt備考.Text) & "',"
            'msSQL += " 登録日 = '" & Date.Today & "',"
            msSQL += " 更新日 = '" & Date.Today & "',"
            msSQL += " 銀行名 = '" & Trim(txt銀行名.Text) & "',"
            msSQL += " 銀行支店名 = '" & Trim(txt銀行支店名.Text) & "',"
            msSQL += " 口座種別 = '" & cmb口座種別.SelectedValue & "',"
            msSQL += " 口座番号 = '" & Trim(txt口座番号.Text) & "',"
            msSQL += " 口座名義 = '" & Trim(txt口座名義.Text) & "',"
            msSQL += " 社内担当者 = '" & Trim(txt社内担当者.Text) & "'"
            msSQL += " WHERE 企業ID = '" & txt企業ID.Text & "'"

            mCommand = cDB.getsqlComand(msSQL)
            Call mCommand.ExecuteNonQuery()
        End If

        MessageBox.Show("登録完了")

        ''再表示============================================================================
        Call sub一覧表示()
        'dgv一覧.DataSource = myTable
        'Call グリッド並び()


        ''クリア============================================================================
        Call sub初期化()
        Call txt企業ID.Select()

        Call cDB.Close()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try


    End Sub

    Private Sub dgv一覧_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv一覧.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub

        Call sub初期化()

        txt企業ID.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col企業ID").Value.ToString)
        txtフリガナ.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("colフリガナ").Value.ToString)
        txt企業名.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col企業名").Value.ToString)
        txt支店名.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col支店名").Value.ToString)
        txt代表者名.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col代表者名").Value.ToString)
        txt担当者名.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col担当者名").Value.ToString)
        txt郵便番号.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col郵便番号").Value.ToString)
        txt住所.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col住所").Value.ToString)
        txt電話番号.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col電話番号").Value.ToString)
        txtFAX番号.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("colFAX番号").Value.ToString)
        txt銀行名.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col銀行名").Value.ToString)
        txt銀行支店名.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col銀行支店名").Value.ToString)
        txt銀行名.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col銀行名").Value.ToString)
        cmb口座種別.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col口座種別").Value.ToString)
        txt口座番号.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col口座番号").Value.ToString)
        txt備考.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col備考").Value.ToString)
        txt社内担当者.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col社内担当者").Value.ToString)

        'txt入社日.Text = Trim(CDate(dgv一覧.Rows(e.RowIndex).Cells("col入社日").Value).ToString("yyyy/MM/dd"))


        If Not IsDBNull(dgv一覧.Rows(e.RowIndex).Cells("colメールアドレス").Value) Then txtメアド.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("colメールアドレス").Value.ToString)
        If Not IsDBNull(dgv一覧.Rows(e.RowIndex).Cells("colHPアドレス").Value) Then txtHPアドレス.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("colHPアドレス").Value.ToString)
        'If Not IsDBNull(dgv一覧.Rows(e.RowIndex).Cells("col退社日").Value) Then txt退社日.Text = Trim(CDate(dgv一覧.Rows(e.RowIndex).Cells("col退社日").Value).ToString("yyyy/MM/dd"))


        'If IsDBNull(dgv一覧.Rows(e.RowIndex).Cells("col削除フラグ").Value) OrElse CInt(dgv一覧.Rows(e.RowIndex).Cells("col削除フラグ").Value) = 0 Then
        '    chk削除.Checked = False
        'Else
        '    chk削除.Checked = True
        'End If



    End Sub

    Private Sub btn郵便番号_Click(sender As Object, e As EventArgs) Handles btn郵便番号.Click
        Dim sfrm As New sfrm住所検索
        Call sfrm.ShowDialog()

    End Sub


    Private Sub btnクリア_Click(sender As Object, e As EventArgs) Handles btnクリア.Click
        Call sub初期化()
        Call txt企業ID.Select()


    End Sub

    Private Sub btnCSV_Click(sender As Object, e As EventArgs) Handles btnCSV.Click
        Dim SFD As New SaveFileDialog


        With SFD
            .FileName = "ファイルA"
            .Filter = "CSV(*.CSV)|*.csv"
            .Title = "ファイル名を入力してください"
            .RestoreDirectory = True
            .CheckPathExists = True

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    System.IO.File.Delete(.FileName) ''すでにある同名データは削除

                Catch ex As Exception
                    MessageBox.Show(.FileName & "は開かれています。")

                    Exit Sub
                End Try

                '' ======================================
                ''CSV出力内容　bCSV出力(.FileName,[出力データテーブル])
                '' ======================================

            End If
        End With
    End Sub

    Public Sub sCSV出力(ByVal CSVファイル名 As String, ByVal setテーブル As DataTable)
        Dim sCSV As String = ""
        Dim sヘッダ As String = ""
        Dim sデータ As String = ""
        ''ヘッダ作成
        For i_Col As Integer = 0 To setテーブル.Columns.Count - 1
            If sヘッダ <> "" Then sヘッダ += "," ''カンマを付加
            sヘッダ += """" + setテーブル.Columns(i_Col).ColumnName + """"
        Next
        sCSV = sヘッダ + vbCrLf
        ''データ作成
        For Each get行 As DataRow In setテーブル.Rows
            sデータ = ""
            For i As Integer = 0 To get行.ItemArray.Length - 1
                If sデータ <> "" Then sデータ += "," ''カンマを付加
                sデータ += """" + get行(i).ToString + """"
            Next
            sCSV += sデータ & vbCrLf
        Next
        Dim SW As New StreamWriter(CSVファイル名, False, Encoding.Default)
        Call SW.WriteLine(sCSV)  ''データ書き込み
        Call SW.Close()
    End Sub

End Class