Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class cls環境設定
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter

    'Private getデフォルトプリンタ As String
    Private get施設ID As String
    Private get施設名 As String
    Private getフリガナ As String
    Private get会社名 As String
    Private get代表者 As String
    Private get郵便番号 As String
    Private get住所 As String
    Private get電話番号 As String
    Private getFAX番号 As String
    Private getメールアドレス As String
    Private getラインID As String
    Private get銀行名 As String
    Private get支店名 As String
    Private get口座区分 As String
    Private get口座番号 As String

    Public ReadOnly Property 施設ID() As String
        Get
            Return get施設ID
        End Get

    End Property

    Public ReadOnly Property 施設名() As String
        Get
            Return get施設名
        End Get

    End Property

    Public ReadOnly Property フリガナ() As String
        Get
            Return getフリガナ
        End Get

    End Property

    Public ReadOnly Property 会社名() As String
        Get
            Return get会社名
        End Get

    End Property

    Public ReadOnly Property 代表者() As String
        Get
            Return get代表者
        End Get

    End Property

    Public ReadOnly Property 郵便番号() As String
        Get
            Return get郵便番号
        End Get

    End Property

    Public ReadOnly Property 住所() As String
        Get
            Return get住所
        End Get

    End Property

    Public ReadOnly Property 電話番号() As String
        Get
            Return get電話番号
        End Get

    End Property

    Public ReadOnly Property FAX番号() As String
        Get
            Return getFAX番号
        End Get

    End Property

    Public ReadOnly Property メールアドレス() As String
        Get
            Return getメールアドレス
        End Get

    End Property

    Public ReadOnly Property ラインID() As String
        Get
            Return getラインID
        End Get

    End Property

    Public ReadOnly Property 銀行名() As String
        Get
            Return get銀行名
        End Get

    End Property

    Public ReadOnly Property 支店名() As String
        Get
            Return get支店名
        End Get

    End Property

    Public ReadOnly Property 口座区分() As String
        Get
            Return get口座区分
        End Get

    End Property

    Public ReadOnly Property 口座番号() As String
        Get
            Return get口座番号
        End Get

    End Property

    'Public ReadOnly Property デフォルトプリンタ() As String
    '    Get
    '        Return getデフォルトプリンタ
    '    End Get

    'End Property

    Public Sub New()
        Call 環境設定読込()

    End Sub

    Public Sub 環境設定読込()
        Dim pd As New System.Drawing.Printing.PrintDocument
        Dim cDB As New clsDB
        Dim dtbl施設 As New DataTable
        Dim dtbl環境 As New DataTable


        ''施設情報==================================================
        msSQL = "SELECT * FROM MST_施設"
        msSQL += " WHERE 施設ID='" & ConfigurationManager.AppSettings("InstitutionID") & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl施設) ''データセット作成

        For Each getRow As DataRow In dtbl施設.Rows
            get施設ID = getRow("施設ID")
            get施設名 = getRow("施設名")

        Next

        ''環境情報取得==============================================
        msSQL = "SELECT * FROM MST_環境設定"
        msSQL += " WHERE 施設ID='" & get施設ID & "'"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand
        Call mSDA.Fill(dtbl環境) ''データセット作成

        ''デフォルトプリンタ情報の取得-----------------------------
        'getデフォルトプリンタ = pd.PrinterSettings.PrinterName

        ''情報取得-------------------------------------------------
        For Each getRow As DataRow In dtbl環境.Rows
            Select Case getRow("ID")
                Case 1 : getフリガナ = getRow("パラメータ")
                Case 2 : get会社名 = getRow("パラメータ")
                Case 3 : get代表者 = getRow("パラメータ")
                Case 4 : get郵便番号 = getRow("パラメータ")
                Case 5 : get住所 = getRow("パラメータ")
                Case 6 : get電話番号 = getRow("パラメータ")
                Case 7 : getFAX番号 = getRow("パラメータ")
                Case 8 : getメールアドレス = getRow("パラメータ")
                Case 9 : getラインID = getRow("パラメータ")
                Case 10 : get銀行名 = getRow("パラメータ")
                Case 11 : get支店名 = getRow("パラメータ")
                Case 12 : get口座区分 = getRow("パラメータ")
                Case 13 : get口座番号 = getRow("パラメータ")
            End Select

        Next

    End Sub

End Class
