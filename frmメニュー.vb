Public Class frmメニュー

    Private Shared _mutex As System.Threading.Mutex
    Private OpenForm As Form

    Private Sub frmメニュー_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sfrm As New sfrmログイン
        Select Case sfrm.ShowDialog()
            Case DialogResult.OK
            Case Else
        End Select

        lblバージョン.Text = "Ver" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()

        ''環境設定読み込み
        my環境設定 = New cls環境設定        'どのFormからも見えるようにModule内に定義している

        tim時間.Enabled = True

        lbl日付.Text = Now.Date.ToString("yyyy/MM/dd（ddd）")
        lbl時間.Text = Now.ToString("HH:mm")
    End Sub

    ''  Private Sub tim時間_Tick(sender As Object, e As EventArgs) Handles tim時間.Tick
    '      lbl日付.Text = Now.Date.ToString("yyyy/MM/dd（ddd）")
    '      lbl時間.Text = Now.ToString("HH:mm")

    ' ' End Sub

    Private Sub btn環境設定_Click(sender As Object, e As EventArgs) Handles btn環境設定.Click
        Dim sfrm As New frmM環境設定
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn区分管理マスタ_Click(sender As Object, e As EventArgs) Handles btn区分管理マスタ.Click
        Dim frm As New frmM区分管理
        frm.ShowDialog()

    End Sub

    Private Sub btn郵便番号取込_Click(sender As Object, e As EventArgs) Handles btn郵便番号取込.Click
        Dim sfrm As New frmM郵便番号取込
        Call sfrm.ShowDialog()
    End Sub

    Private Sub btn会員マスタ_Click(sender As Object, e As EventArgs) Handles btn会員マスタ.Click
        Dim frm As New frmM会員
        frm.ShowDialog()

    End Sub

    Private Sub btn企業マスタ_Click(sender As Object, e As EventArgs) Handles btn企業マスタ.Click
        Dim frm As New frmM企業
        frm.ShowDialog()

    End Sub

    Private Sub btnプロジェクトマスタ_Click(sender As Object, e As EventArgs) Handles btnプロジェクトマスタ.Click
        Dim frm As New frmMプロジェクト
        frm.ShowDialog()

    End Sub

    Private Sub btn会員スキルマスタ_Click(sender As Object, e As EventArgs) Handles btn会員スキルマスタ.Click
        Dim frm As New frmM会員スキル
        frm.ShowDialog()

    End Sub

    Private Sub frmカレンダー表示_Click(sender As Object, e As EventArgs) Handles frmカレンダー表示.Click
        'Dim frm As New frmSカレンダー
        'frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmM案件
        frm.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmSカレンダー
        frm.ShowDialog()
    End Sub
End Class
