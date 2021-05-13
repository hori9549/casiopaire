Imports System.Windows.Forms
Imports System.Text.RegularExpressions  ''正規表現

Imports System.Data
Imports System.Data.SqlClient

Public Class sfrm会員情報
    ''データベース接続用-------------------------------
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private myコンボ As New clsコンボボックス
    Private mdtbl会員 As New DataTable
    Private mdtblスキル As New DataTable

    Private pro会員 As String
    Public Property 会員() As String
        Get
            Return pro会員
        End Get

        Set(ByVal value As String)
            pro会員 = value
        End Set
    End Property

    Private Sub sfrm会員情報_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call myコンボ.会員IDコンボ(cmb会員)
        Call subクリア()

        cmb会員.SelectedValue = pro会員
        Call sub参加プロジェクト一覧表示(pro会員)
        Call sub会員スキル一覧表示(pro会員)

    End Sub

    Private Sub subクリア()
        cmb会員.Text = ""

        Call cmb会員.Select()
    End Sub

    'Private Sub cmb会員_Leave(sender As Object, e As EventArgs) Handles cmb会員.Leave
    '    pro会員 = cmb会員.SelectedValue
    '    Call sub会員スキル一覧表示(pro会員)
    'End Sub

    Private Sub cmb会員_SelectedValueChanged(sender1 As Object, e As EventArgs) Handles cmb会員.SelectedValueChanged

        'pro会員 = cmb会員.SelectedValue
        Call sub参加プロジェクト一覧表示(cmb会員.SelectedValue)
        Call sub会員スキル一覧表示(cmb会員.SelectedValue)

        'Try
        '    pro会員 = cmb会員.SelectedValue
        '    Call sub会員スキル一覧表示(pro会員)
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub sub参加プロジェクト一覧表示(Optional ByVal pro会員 As String = "")
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = "SELECT MST_プロジェクト.*,MST_P参加会員.会員ID
        FROM MST_プロジェクト
        LEFT JOIN MST_P参加会員
        ON MST_P参加会員.プロジェクトID = MST_プロジェクト.プロジェクトID"

        'msSQL = "SELECT MST_プロジェクト.*,MST_P参加会員.会員ID"
        'msSQL = "FROM MST_プロジェクト"
        'msSQL = "LEFT JOIN MST_P参加会員"
        'msSQL = "ON MST_P参加会員.プロジェクトID = MST_プロジェクト.プロジェクトID"
        If pro会員 <> "" Then msSQL += " WHERE 会員ID ='" & pro会員 & "'"

        msSQL += " ORDER BY プロジェクトID"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        dgvプロジェクト.DataSource = myTable

        Call cDB.Close()
        Exit Sub
    End Sub

    Private Sub sub会員スキル一覧表示(Optional ByVal pro会員 As String = "")
        Dim cDB As New clsDB
        Dim msSQL As String
        Dim myTable As New DataTable

        msSQL = "SELECT * FROM MST_会員スキル"
        If pro会員 <> "" Then msSQL += " WHERE 会員ID ='" & pro会員 & "'"

        msSQL += " ORDER BY スキル名"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable) ''データセット作成

        dgvスキル.DataSource = myTable

        Call cDB.Close()
        Exit Sub
    End Sub

End Class
