
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO　　''ファイル操作用
Imports System.Text  ''エンコード時使用

Public Class frmM案件
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private myコンボ As New clsコンボボックス
    Private yomiConv As ImeComposition.ImeYomiConversion


    Private Sub frmM案件_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''コンボボックスセット
        Call myコンボ.理事区分コンボ(cmb担当理事)
        Call myコンボ.ステータス区分コンボ(cmbステータス)


        Call sub一覧表示()
        Call sub初期化()

        ''カナ自動入力
        yomiConv = New ImeComposition.ImeYomiConversion(txt案件名, txtフリガナ)

    End Sub


    Private Sub sub一覧表示(Optional ByVal set案件名 As String = "")
        Dim cDB As New clsDB
        'Dim msSQL As String
        Dim myTable As New DataTable


        msSQL = "SELECT * "
        ''msSQL += ",(SELECT TOP 1 内容 FROM MST_区分明細 WHERE 区分='3' AND コード=ステータス ) as ステータス"
        'msSQL += ",(SELECT TOP 1 内容 FROM MST_区分明細 WHERE 区分='3' AND コード=ステータス ) as ステータス"

        msSQL += " FROM MST_案件"
        If set案件名 <> "" Then msSQL += " WHERE 案件名 LIKE '%" & set案件名 & "%' OR 案件ID ='" & set案件名 & "'"

        ''↑『Or 案件ID』がないと動かないのはなぜ？

        'If cmbステータス.SelectedValue <> "0" Then msSQL += " AND ステータス ='" & cmbステータス.SelectedValue & "'"


        ''msSQL += " ORDER BY 削除フラグ,フリガナ"
        msSQL += " ORDER BY フリガナ"

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
            .Columns("col案件ID").DisplayIndex = 1
            .Columns("colフリガナ").DisplayIndex = 2
            .Columns("col案件名").DisplayIndex = 3
            .Columns("col受注日").DisplayIndex = 4
            .Columns("col納期").DisplayIndex = 5
            .Columns("col担当理事").DisplayIndex = 6
            .Columns("col参加者１").DisplayIndex = 7
            .Columns("col参加者２").DisplayIndex = 8
            .Columns("col参加者３").DisplayIndex = 9
            .Columns("col備考").DisplayIndex = 10
            .Columns("colステータス").DisplayIndex = 11

        End With

    End Sub

    Private Sub sub初期化()
        txt企業ID.Text = ""
        txt案件ID.Text = ""
        txtフリガナ.Text = ""
        txt案件名.Text = ""
        txt受注日.Text = ""

        txt納期.Text = ""
        cmb担当理事.SelectedValue = 0
        txt参加者１.Text = ""
        txt参加者２.Text = ""
        txt参加者３.Text = ""
        txt備考.Text = ""
        cmbステータス.SelectedValue = 0

    End Sub
    Private Sub sub案件初期化()
        txt案件ID.Text = ""
        txtフリガナ.Text = ""
        txt案件名.Text = ""
        txt受注日.Text = ""

        txt納期.Text = ""
        cmb担当理事.SelectedValue = 0
        txt参加者１.Text = ""
        txt参加者２.Text = ""
        txt参加者３.Text = ""
        txt備考.Text = ""
        cmbステータス.SelectedValue = 0

    End Sub

    Private Sub txt案件名_Enter(sender As Object, e As EventArgs) Handles txt案件名.Enter
        yomiConv.Enabled = True
    End Sub

    Private Sub txt案件名_Leave(sender As Object, e As EventArgs) Handles txt案件名.Leave
        yomiConv.Enabled = False
    End Sub



    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable


        ''エラーチェック==========================================================================================================

        With txt企業ID
            Select Case .Text
                Case ""
                    MessageBox.Show("企業IDは必須入力項目です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call .Select()
                    Exit Sub
                Case Else
                    If IsNumeric(.Text) = False Then
                        MessageBox.Show("企業IDは数字入力項目です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Call .Select()
                        Exit Sub

                    End If

            End Select
        End With


        With txt案件ID
            Select Case .Text
                Case ""
                    MessageBox.Show("案件IDは必須入力項目です")
                    Call .Select()
                    Exit Sub
                Case Else
                    If IsNumeric(.Text) = False Then
                        MessageBox.Show("企業IDは数字入力項目です")

                        Call .Select()
                        Exit Sub

                    End If

            End Select
        End With


        With txtフリガナ
            Select Case .Text
                Case ""
                    MessageBox.Show("フリガナは必須入力項目です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call .Select()
                    Exit Sub
                Case Else
            End Select
        End With


        With txt受注日
            Select Case .Text
                Case ""
                    MessageBox.Show("受注日は必須入力項目です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call .Focus()
                    Exit Sub
                Case Else
                    If IsDate(.Text) = False Then
                        MessageBox.Show("受注日の日付が誤りです。")
                        Call .Select()
                        Exit Sub
                    End If

            End Select
        End With



        With txt納期
            Select Case .Text
                Case ""
                    MessageBox.Show("納期は必須入力項目です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Call .Focus()
                    Exit Sub
                Case Else
                    If IsDate(.Text) = False Then
                        MessageBox.Show("納期の日付が誤りです。")
                        Call .Select()
                        Exit Sub
                    End If

            End Select
        End With




        ''登録===================================================================================================================
        'Try
        ''存在チェック
        msSQL = " SELECT * FROM MST_案件"
        msSQL += " WHERE 案件ID = '" & txt案件ID.Text & "'"


        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''

        If myTable.Rows.Count = 0 Then

            ''新規追加

            msSQL = " INSERT INTO  MST_案件("
            msSQL += " 企業ID,"
            msSQL += " 案件ID,"
            msSQL += " フリガナ,"
            msSQL += " 案件名,"
            msSQL += " 受注日,"
            msSQL += " 納期,"
            msSQL += " 担当理事,"
            msSQL += " 参加者１,"
            msSQL += " 参加者２,"
            msSQL += " 参加者３,"
            msSQL += " 備考,"
            msSQL += " ステータス"
            msSQL += " )"
            msSQL += " VALUES"
            msSQL += " ("
            msSQL += "'" & Trim(txt企業ID.Text) & "',"
            msSQL += "'" & Trim(txt案件ID.Text) & "',"
            msSQL += "'" & Trim(txtフリガナ.Text) & "',"
            msSQL += "'" & Trim(txt案件名.Text) & "',"
            msSQL += "'" & Trim(txt受注日.Text) & "',"
            msSQL += "'" & Trim(txt納期.Text) & "',"
            msSQL += "'" & cmb担当理事.SelectedValue & "',"
            msSQL += "'" & Trim(txt参加者１.Text) & "',"
            msSQL += "'" & Trim(txt参加者２.Text) & "',"
            msSQL += "'" & Trim(txt参加者３.Text) & "',"
            msSQL += "'" & Trim(txt備考.Text) & "',"
            msSQL += "'" & cmbステータス.SelectedValue & "'"
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
            msSQL = " UPDATE MST_案件 SET "
            'msSQL += " 企業ID = '" & Trim(txt企業ID.Text) & "',"
            msSQL += " 案件ID = '" & Trim(txt案件ID.Text) & "',"
            msSQL += " フリガナ = '" & Trim(txtフリガナ.Text) & "',"
            msSQL += " 案件名 = '" & Trim(txt案件名.Text) & "',"
            msSQL += " 受注日 = '" & Trim(txt受注日.Text) & "',"
            msSQL += " 納期 = '" & Trim(txt納期.Text) & "',"
            msSQL += " 担当理事　= '" & cmb担当理事.SelectedValue & "',"
            msSQL += " 参加者１ = '" & Trim(txt参加者１.Text) & "',"
            msSQL += " 参加者２ = '" & Trim(txt参加者２.Text) & "',"
            msSQL += " 参加者３ = '" & Trim(txt参加者３.Text) & "',"
            msSQL += " 備考 = '" & Trim(txt備考.Text) & "',"
            msSQL += " ステータス　= '" & cmbステータス.SelectedValue & "'"
            'msSQL += " 登録日 = '" & Date.Today & "',"
            'msSQL += " 更新日 = '" & Date.Today & "',"
            msSQL += " WHERE 案件ID = '" & txt案件ID.Text & "'"

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
        txt案件ID.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col案件ID").Value.ToString)
        txtフリガナ.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("colフリガナ").Value.ToString)
        txt案件名.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col案件名").Value.ToString)
        'txt受注日.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col受注日").Value.ToString)
        'txt納期.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col納期").Value.ToString)
        cmb担当理事.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col担当理事").Value.ToString)
        txt参加者１.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col参加者１").Value.ToString)
        txt参加者２.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col参加者２").Value.ToString)
        txt参加者３.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col参加者３").Value.ToString)
        txt備考.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("col備考").Value.ToString)
        cmbステータス.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("colステータス").Value.ToString)


        'テキストボックスに時間の表示をしないようにする
        txt受注日.Text = Trim(CDate(dgv一覧.Rows(e.RowIndex).Cells("col受注日").Value).ToString("yyyy/MM/dd"))
        txt納期.Text = Trim(CDate(dgv一覧.Rows(e.RowIndex).Cells("col納期").Value).ToString("yyyy/MM/dd"))


        'If Not IsDBNull(dgv一覧.Rows(e.RowIndex).Cells("colメールアドレス").Value) Then txtメアド.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("colメールアドレス").Value.ToString)
        'If Not IsDBNull(dgv一覧.Rows(e.RowIndex).Cells("colHPアドレス").Value) Then txtHPアドレス.Text = Trim(dgv一覧.Rows(e.RowIndex).Cells("colHPアドレス").Value.ToString)
        'If Not IsDBNull(dgv一覧.Rows(e.RowIndex).Cells("col退社日").Value) Then txt退社日.Text = Trim(CDate(dgv一覧.Rows(e.RowIndex).Cells("col退社日").Value).ToString("yyyy/MM/dd"))


        'If IsDBNull(dgv一覧.Rows(e.RowIndex).Cells("col削除フラグ").Value) OrElse CInt(dgv一覧.Rows(e.RowIndex).Cells("col削除フラグ").Value) = 0 Then
        '    chk削除.Checked = False
        'Else
        '    chk削除.Checked = True
        'End If



    End Sub



    Private Sub btn企業クリア_Click(sender As Object, e As EventArgs) Handles btn企業クリア.Click
        Call sub初期化()
        Call txt企業ID.Select()
    End Sub

    Private Sub btnクリア_Click(sender As Object, e As EventArgs) Handles btn案件クリア.Click
        Call sub案件初期化()
        Call txt案件ID.Select()
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

    Private Sub btnカレンダー受注_Click(sender As Object, e As EventArgs) Handles btnカレンダー受注.Click
        Dim sfrm As New sfrm日付選択
        sfrm.日付 = txt受注日.Text
        Call sfrm.ShowDialog()
        txt受注日.Text = sfrm.日付
    End Sub


    Private Sub btnカレンダー納期_Click(sender As Object, e As EventArgs) Handles btnカレンダー納期.Click
        Dim sfrm As New sfrm日付選択
        sfrm.日付 = txt納期.Text
        Call sfrm.ShowDialog()
        txt納期.Text = sfrm.日付
    End Sub

    Private Sub btn検索_Click(sender As Object, e As EventArgs) Handles btn検索.Click

        Call sub一覧表示(txt案件名.Text)
        Call txt受注日.Focus()

    End Sub

    Private Sub btnステータス検索_Click(sender As Object, e As EventArgs) Handles btnステータス検索.Click
        Dim myTable As New DataTable

        ''エラーチェック==========================================================================================================
        ''登録===================================================================================================================
        Try
            ''再表示============================================================================
            Call sub一覧表示()

            ''クリア============================================================================
            Call sub初期化()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class
