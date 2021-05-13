Imports System.Data
Imports System.Data.SqlClient

Public Class clsコンボボックス
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    Public Sub 区分コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        ''検索SQL======================================================
        getSQL = "SELECT DISTINCT (区分名) as 表示,区分"
        getSQL += " FROM MST_区分"
        'getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " ORDER BY 区分,区分名"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("区分") = "0"
        myRow("表示") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "区分"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 口座区分コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        'getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        'getSQL += " AND 区分 = 1 AND 削除フラグ = 0"
        getSQL += " WHERE 区分 = 1 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "内容"
            .ValueMember = "コード"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 職名コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        'getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        'getSQL += " AND 区分 = 2 AND 削除フラグ = 0"
        getSQL += " WHERE 区分 = 2 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        'myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "内容"
            .ValueMember = "内容"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 担当理事コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        ''検索SQL======================================================
        getSQL = "SELECT 会員ID"
        getSQL += " ,(氏名) as Display"
        getSQL += " ,フリガナ"
        getSQL += " FROM MST_会員"
        'getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        'getSQL += " OR 役職名 = '理事長' OR 役職名 = '副理事' OR 役職名 = '理事'"
        getSQL += " WHERE 役職名 = '理事長' OR 役職名 = '副理事' OR 役職名 = '理事'"
        getSQL += " AND 退会日 IS NULL"
        getSQL += " ORDER BY フリガナ"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow

        myRow("会員ID") = ""
        myRow("Display") = ""

        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .ValueMember = "会員ID"
            .DisplayMember = "Display"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With

    End Sub

    Public Sub プロジェクトIDコンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        ''検索SQL======================================================
        getSQL = "SELECT DISTINCT (プロジェクト名) as 表示,プロジェクトID"
        getSQL += " FROM MST_プロジェクト"
        'getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " ORDER BY プロジェクトID"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(myTable)
        ''============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("プロジェクトID") = "0"
        myRow("表示") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "プロジェクトID"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 会員IDコンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT 会員ID"
        getSQL += " ,(氏名) as Display"
        getSQL += " ,フリガナ"
        getSQL += " FROM MST_会員"
        'getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " WHERE 退会日 IS NULL"
        getSQL += " ORDER BY フリガナ"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("会員ID") = ""
        myRow("Display") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "Display"
            .ValueMember = "会員ID"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub スキルコンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        'getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " WHERE 区分 = 3 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        'myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "内容"
            .ValueMember = "内容"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub スキルレベルコンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        'getSQL += " WHERE 施設ID='" & my環境設定.施設ID & "'"
        getSQL += " WHERE 区分 = 4 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        'myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "内容"
            .ValueMember = "内容"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

    Public Sub 理事区分コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 区分 = 2 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "内容"
            .ValueMember = "内容"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub


    Public Sub ステータス区分コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable

        If Not myTable Is Nothing Then myTable.Clear()
        ''検索SQL======================================================
        getSQL = "SELECT コード,内容"
        getSQL += " FROM MST_区分明細"
        getSQL += " WHERE 区分 = 3 AND 削除フラグ = 0"
        getSQL += " ORDER BY コード"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("コード") = "0"
        myRow("内容") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "内容"
            .ValueMember = "コード"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub

End Class
