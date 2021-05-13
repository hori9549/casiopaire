Imports System.Data
Imports System.Data.SqlClient

Public Class frmM会員スキル

    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private mdtbl会員スキル As New DataTable
    Private myコンボ As New clsコンボボックス

    Private Sub frmM会員スキル_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call subクリア()
        'コンボボックスの呼び出し
        Call myコンボ.会員IDコンボ(cmb会員ID)
        Call myコンボ.スキルコンボ(cmbスキル)
        Call myコンボ.スキルレベルコンボ(cmbスキルレベル)

        Call cmb会員ID.Select()
        Call sub会員スキル一覧表示()

    End Sub

    Private Sub btn登録_Click(sender As Object, e As EventArgs) Handles btn登録.Click
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        'エラーチェック

        With cmb会員ID
            Select Case .Text
                Case ""
                    sfrmメッセージ.ShowDialog("会員IDは必須入力項目です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call .Select()
                    Exit Sub
                Case Else

            End Select
        End With

        '登録出来るか検索

        msSQL = "SELECT * FROM MST_会員スキル"
        msSQL += " WHERE 会員ID = " & cmb会員ID.SelectedValue
        msSQL += " AND スキル名 = '" & cmbスキル.Text & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable) ''データセット作成

        '新規か登録かIF文

        If myTable.Rows.Count = 0 Then

            '新規

            msSQL = "INSERT INTO MST_会員スキル("
            msSQL += " 会員ID"
            msSQL += ",スキル名"
            msSQL += ",スキルレベル"
            msSQL += ",備考"
            msSQL += ",削除フラグ"
            msSQL += " )"
            msSQL += " VALUES"
            msSQL += " ("
            msSQL += " '" & Trim(cmb会員ID.SelectedValue) & "'"
            msSQL += ",'" & Trim(cmbスキル.Text) & "'"
            msSQL += ",'" & Trim(cmbスキルレベル.Text) & "'"
            msSQL += ",'" & Trim(txt備考.Text) & "'"
            msSQL += ",'0'"
            msSQL += " )"

        Else
            Select Case MessageBox.Show("会員ID:" & cmb会員ID.Text & "の修正を行います。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                Case ShowDialog.OK
                Case Else
                    Exit Sub
            End Select

            '更新

            msSQL = " Update MST_会員スキル SET"
            msSQL += " スキル名 = '" & Trim(cmbスキル.Text) & "'"
            msSQL += ",スキルレベル = '" & Trim(cmbスキルレベル.Text) & "'"
            msSQL += ",備考 = '" & Trim(txt備考.Text) & "'"
            msSQL += ",削除フラグ = '" & Math.Abs(CInt(chk削除.Checked)) & "'"
            msSQL += " WHERE 会員ID = " & cmb会員ID.SelectedValue
            msSQL += " AND スキル名 = '" & cmbスキル.Text & "'"

        End If

        mCommand = cDB.getsqlComand(msSQL)
        Call mCommand.ExecuteNonQuery()

        '初期化
        MessageBox.Show("登録が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call subクリア()

        '再表示
        Call sub会員スキル一覧表示()

        'コンボボックスセット
        Call myコンボ.会員IDコンボ(cmb会員ID)
        Call myコンボ.スキルコンボ(cmbスキル)
        Call myコンボ.スキルレベルコンボ(cmbスキルレベル)

    End Sub

    Private Sub subクリア()
        cmb会員ID.Text = ""
        cmbスキル.Text = ""
        cmbスキルレベル.Text = ""
        txt備考.Text = ""
        chk削除.Checked = False

        Call cmb会員ID.Select()
    End Sub

    Private Sub sub会員スキル一覧表示(Optional ByVal set会員ID As Integer = 0)
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = "SELECT *"
        msSQL += ",(SELECT 氏名 FROM MST_会員 WHERE MST_会員スキル.会員ID = MST_会員.会員ID)as 氏名"
        msSQL += " From MST_会員スキル"
        If set会員ID <> 0 Then msSQL += " WHERE 会員ID ='" & set会員ID & "'"
        msSQL += " ORDER BY 会員ID,スキル名"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        dgv一覧.DataSource = myTable

        Call cDB.Close()
        Exit Sub
    End Sub

    Private Sub subグリッド並び_会員スキル一覧表示()
        ''グリッド表示順
        With dgv一覧
            .Columns("col氏名").DisplayIndex = 0
            .Columns("colスキル名").DisplayIndex = 1
            .Columns("colスキルレベル").DisplayIndex = 2
            .Columns("col備考").DisplayIndex = 3
            .Columns("col削除").DisplayIndex = 4

        End With

    End Sub

End Class