<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmM会員
    'Inherits System.Windows.Forms.Form
    Inherits frmベース

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl会員ID = New System.Windows.Forms.Label()
        Me.lblパスワード = New System.Windows.Forms.Label()
        Me.lblフリガナ = New System.Windows.Forms.Label()
        Me.lbl氏名 = New System.Windows.Forms.Label()
        Me.lbl性別 = New System.Windows.Forms.Label()
        Me.lbl生年月日 = New System.Windows.Forms.Label()
        Me.lbl郵便番号 = New System.Windows.Forms.Label()
        Me.lbl電話番号 = New System.Windows.Forms.Label()
        Me.lblメールアドレス = New System.Windows.Forms.Label()
        Me.lbl担当理事 = New System.Windows.Forms.Label()
        Me.lbl入会日 = New System.Windows.Forms.Label()
        Me.lbl退会日 = New System.Windows.Forms.Label()
        Me.lbl銀行名 = New System.Windows.Forms.Label()
        Me.lbl銀行支店名 = New System.Windows.Forms.Label()
        Me.lbl口座番号 = New System.Windows.Forms.Label()
        Me.lbl口座名義 = New System.Windows.Forms.Label()
        Me.lbl備考 = New System.Windows.Forms.Label()
        Me.txt会員ID = New System.Windows.Forms.TextBox()
        Me.txtパスワード = New System.Windows.Forms.TextBox()
        Me.txtフリガナ = New System.Windows.Forms.TextBox()
        Me.txt氏名 = New System.Windows.Forms.TextBox()
        Me.txt郵便番号 = New System.Windows.Forms.TextBox()
        Me.txt住所 = New System.Windows.Forms.TextBox()
        Me.txt電話番号 = New System.Windows.Forms.TextBox()
        Me.txtメールアドレス = New System.Windows.Forms.TextBox()
        Me.txt銀行名 = New System.Windows.Forms.TextBox()
        Me.txt銀行支店名 = New System.Windows.Forms.TextBox()
        Me.txt口座番号 = New System.Windows.Forms.TextBox()
        Me.txt口座名義 = New System.Windows.Forms.TextBox()
        Me.txt備考 = New System.Windows.Forms.TextBox()
        Me.rdo男 = New System.Windows.Forms.RadioButton()
        Me.rdo女 = New System.Windows.Forms.RadioButton()
        Me.cmb担当理事 = New System.Windows.Forms.ComboBox()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col会員ID = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colLINE送信 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.col氏名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colフリガナ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colパスワード = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col役職名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col性別 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col生年月日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col郵便番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col住所 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col電話番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colラインID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colメールアドレス = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col担当理事 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col入会日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col退会日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col銀行名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col銀行支店名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col口座種類 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col口座番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col口座名義 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn取得 = New System.Windows.Forms.Button()
        Me.btn閉じる = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt退会日 = New System.Windows.Forms.TextBox()
        Me.btn退会日 = New System.Windows.Forms.Button()
        Me.txt生年月日 = New System.Windows.Forms.TextBox()
        Me.txt入会日 = New System.Windows.Forms.TextBox()
        Me.btn入会日 = New System.Windows.Forms.Button()
        Me.btn生年月日 = New System.Windows.Forms.Button()
        Me.cmb口座種類 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblラインID = New System.Windows.Forms.Label()
        Me.txtラインID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb役職名 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnクリア = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn会員名簿 = New System.Windows.Forms.Button()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl会員ID
        '
        Me.lbl会員ID.AutoSize = True
        Me.lbl会員ID.Location = New System.Drawing.Point(32, 19)
        Me.lbl会員ID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl会員ID.Name = "lbl会員ID"
        Me.lbl会員ID.Size = New System.Drawing.Size(64, 19)
        Me.lbl会員ID.TabIndex = 0
        Me.lbl会員ID.Text = "会員ID"
        '
        'lblパスワード
        '
        Me.lblパスワード.AutoSize = True
        Me.lblパスワード.Location = New System.Drawing.Point(295, 19)
        Me.lblパスワード.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblパスワード.Name = "lblパスワード"
        Me.lblパスワード.Size = New System.Drawing.Size(84, 19)
        Me.lblパスワード.TabIndex = 3
        Me.lblパスワード.Text = "パスワード"
        '
        'lblフリガナ
        '
        Me.lblフリガナ.AutoSize = True
        Me.lblフリガナ.Location = New System.Drawing.Point(33, 51)
        Me.lblフリガナ.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblフリガナ.Name = "lblフリガナ"
        Me.lblフリガナ.Size = New System.Drawing.Size(63, 19)
        Me.lblフリガナ.TabIndex = 6
        Me.lblフリガナ.Text = "フリガナ"
        '
        'lbl氏名
        '
        Me.lbl氏名.AutoSize = True
        Me.lbl氏名.Location = New System.Drawing.Point(49, 83)
        Me.lbl氏名.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl氏名.Name = "lbl氏名"
        Me.lbl氏名.Size = New System.Drawing.Size(47, 19)
        Me.lbl氏名.TabIndex = 13
        Me.lbl氏名.Text = "氏名"
        '
        'lbl性別
        '
        Me.lbl性別.AutoSize = True
        Me.lbl性別.Location = New System.Drawing.Point(648, 51)
        Me.lbl性別.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl性別.Name = "lbl性別"
        Me.lbl性別.Size = New System.Drawing.Size(47, 19)
        Me.lbl性別.TabIndex = 11
        Me.lbl性別.Text = "性別"
        '
        'lbl生年月日
        '
        Me.lbl生年月日.AutoSize = True
        Me.lbl生年月日.Location = New System.Drawing.Point(294, 83)
        Me.lbl生年月日.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl生年月日.Name = "lbl生年月日"
        Me.lbl生年月日.Size = New System.Drawing.Size(85, 19)
        Me.lbl生年月日.TabIndex = 16
        Me.lbl生年月日.Text = "生年月日"
        '
        'lbl郵便番号
        '
        Me.lbl郵便番号.AutoSize = True
        Me.lbl郵便番号.Location = New System.Drawing.Point(11, 147)
        Me.lbl郵便番号.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl郵便番号.Name = "lbl郵便番号"
        Me.lbl郵便番号.Size = New System.Drawing.Size(85, 19)
        Me.lbl郵便番号.TabIndex = 28
        Me.lbl郵便番号.Text = "郵便番号"
        '
        'lbl電話番号
        '
        Me.lbl電話番号.AutoSize = True
        Me.lbl電話番号.Location = New System.Drawing.Point(610, 82)
        Me.lbl電話番号.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl電話番号.Name = "lbl電話番号"
        Me.lbl電話番号.Size = New System.Drawing.Size(85, 19)
        Me.lbl電話番号.TabIndex = 20
        Me.lbl電話番号.Text = "電話番号"
        '
        'lblメールアドレス
        '
        Me.lblメールアドレス.AutoSize = True
        Me.lblメールアドレス.Location = New System.Drawing.Point(268, 115)
        Me.lblメールアドレス.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblメールアドレス.Name = "lblメールアドレス"
        Me.lblメールアドレス.Size = New System.Drawing.Size(111, 19)
        Me.lblメールアドレス.TabIndex = 26
        Me.lblメールアドレス.Text = "メールアドレス"
        '
        'lbl担当理事
        '
        Me.lbl担当理事.AutoSize = True
        Me.lbl担当理事.Location = New System.Drawing.Point(10, 179)
        Me.lbl担当理事.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl担当理事.Name = "lbl担当理事"
        Me.lbl担当理事.Size = New System.Drawing.Size(85, 19)
        Me.lbl担当理事.TabIndex = 32
        Me.lbl担当理事.Text = "担当理事"
        '
        'lbl入会日
        '
        Me.lbl入会日.AutoSize = True
        Me.lbl入会日.Location = New System.Drawing.Point(312, 179)
        Me.lbl入会日.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl入会日.Name = "lbl入会日"
        Me.lbl入会日.Size = New System.Drawing.Size(66, 19)
        Me.lbl入会日.TabIndex = 34
        Me.lbl入会日.Text = "入会日"
        '
        'lbl退会日
        '
        Me.lbl退会日.AutoSize = True
        Me.lbl退会日.Location = New System.Drawing.Point(629, 180)
        Me.lbl退会日.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl退会日.Name = "lbl退会日"
        Me.lbl退会日.Size = New System.Drawing.Size(66, 19)
        Me.lbl退会日.TabIndex = 38
        Me.lbl退会日.Text = "退会日"
        '
        'lbl銀行名
        '
        Me.lbl銀行名.AutoSize = True
        Me.lbl銀行名.Location = New System.Drawing.Point(29, 213)
        Me.lbl銀行名.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl銀行名.Name = "lbl銀行名"
        Me.lbl銀行名.Size = New System.Drawing.Size(66, 19)
        Me.lbl銀行名.TabIndex = 41
        Me.lbl銀行名.Text = "銀行名"
        '
        'lbl銀行支店名
        '
        Me.lbl銀行支店名.AutoSize = True
        Me.lbl銀行支店名.Location = New System.Drawing.Point(312, 213)
        Me.lbl銀行支店名.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl銀行支店名.Name = "lbl銀行支店名"
        Me.lbl銀行支店名.Size = New System.Drawing.Size(66, 19)
        Me.lbl銀行支店名.TabIndex = 43
        Me.lbl銀行支店名.Text = "支店名"
        '
        'lbl口座番号
        '
        Me.lbl口座番号.AutoSize = True
        Me.lbl口座番号.Location = New System.Drawing.Point(610, 213)
        Me.lbl口座番号.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl口座番号.Name = "lbl口座番号"
        Me.lbl口座番号.Size = New System.Drawing.Size(85, 19)
        Me.lbl口座番号.TabIndex = 45
        Me.lbl口座番号.Text = "口座番号"
        '
        'lbl口座名義
        '
        Me.lbl口座名義.AutoSize = True
        Me.lbl口座名義.Location = New System.Drawing.Point(919, 213)
        Me.lbl口座名義.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl口座名義.Name = "lbl口座名義"
        Me.lbl口座名義.Size = New System.Drawing.Size(85, 19)
        Me.lbl口座名義.TabIndex = 48
        Me.lbl口座名義.Text = "口座名義"
        '
        'lbl備考
        '
        Me.lbl備考.AutoSize = True
        Me.lbl備考.Location = New System.Drawing.Point(49, 245)
        Me.lbl備考.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl備考.Name = "lbl備考"
        Me.lbl備考.Size = New System.Drawing.Size(47, 19)
        Me.lbl備考.TabIndex = 50
        Me.lbl備考.Text = "備考"
        '
        'txt会員ID
        '
        Me.txt会員ID.BackColor = System.Drawing.SystemColors.Window
        Me.txt会員ID.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt会員ID.Location = New System.Drawing.Point(100, 16)
        Me.txt会員ID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt会員ID.MaxLength = 50
        Me.txt会員ID.Name = "txt会員ID"
        Me.txt会員ID.Size = New System.Drawing.Size(79, 26)
        Me.txt会員ID.TabIndex = 1
        '
        'txtパスワード
        '
        Me.txtパスワード.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtパスワード.Location = New System.Drawing.Point(383, 16)
        Me.txtパスワード.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtパスワード.MaxLength = 50
        Me.txtパスワード.Name = "txtパスワード"
        Me.txtパスワード.Size = New System.Drawing.Size(164, 26)
        Me.txtパスワード.TabIndex = 4
        '
        'txtフリガナ
        '
        Me.txtフリガナ.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.txtフリガナ.Location = New System.Drawing.Point(100, 48)
        Me.txtフリガナ.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtフリガナ.MaxLength = 50
        Me.txtフリガナ.Name = "txtフリガナ"
        Me.txtフリガナ.Size = New System.Drawing.Size(164, 26)
        Me.txtフリガナ.TabIndex = 7
        Me.txtフリガナ.TabStop = False
        '
        'txt氏名
        '
        Me.txt氏名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt氏名.Location = New System.Drawing.Point(100, 80)
        Me.txt氏名.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt氏名.MaxLength = 50
        Me.txt氏名.Name = "txt氏名"
        Me.txt氏名.Size = New System.Drawing.Size(164, 26)
        Me.txt氏名.TabIndex = 14
        '
        'txt郵便番号
        '
        Me.txt郵便番号.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt郵便番号.Location = New System.Drawing.Point(100, 144)
        Me.txt郵便番号.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt郵便番号.MaxLength = 50
        Me.txt郵便番号.Name = "txt郵便番号"
        Me.txt郵便番号.Size = New System.Drawing.Size(96, 26)
        Me.txt郵便番号.TabIndex = 29
        '
        'txt住所
        '
        Me.txt住所.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt住所.Location = New System.Drawing.Point(223, 144)
        Me.txt住所.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt住所.MaxLength = 50
        Me.txt住所.Name = "txt住所"
        Me.txt住所.Size = New System.Drawing.Size(949, 26)
        Me.txt住所.TabIndex = 31
        '
        'txt電話番号
        '
        Me.txt電話番号.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt電話番号.Location = New System.Drawing.Point(699, 79)
        Me.txt電話番号.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt電話番号.MaxLength = 50
        Me.txt電話番号.Name = "txt電話番号"
        Me.txt電話番号.Size = New System.Drawing.Size(164, 26)
        Me.txt電話番号.TabIndex = 21
        '
        'txtメールアドレス
        '
        Me.txtメールアドレス.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtメールアドレス.Location = New System.Drawing.Point(382, 114)
        Me.txtメールアドレス.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtメールアドレス.MaxLength = 50
        Me.txtメールアドレス.Name = "txtメールアドレス"
        Me.txtメールアドレス.Size = New System.Drawing.Size(481, 26)
        Me.txtメールアドレス.TabIndex = 27
        '
        'txt銀行名
        '
        Me.txt銀行名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt銀行名.Location = New System.Drawing.Point(99, 210)
        Me.txt銀行名.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt銀行名.MaxLength = 50
        Me.txt銀行名.Name = "txt銀行名"
        Me.txt銀行名.Size = New System.Drawing.Size(164, 26)
        Me.txt銀行名.TabIndex = 42
        '
        'txt銀行支店名
        '
        Me.txt銀行支店名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt銀行支店名.Location = New System.Drawing.Point(382, 210)
        Me.txt銀行支店名.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt銀行支店名.MaxLength = 50
        Me.txt銀行支店名.Name = "txt銀行支店名"
        Me.txt銀行支店名.Size = New System.Drawing.Size(164, 26)
        Me.txt銀行支店名.TabIndex = 44
        '
        'txt口座番号
        '
        Me.txt口座番号.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt口座番号.Location = New System.Drawing.Point(760, 207)
        Me.txt口座番号.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt口座番号.MaxLength = 50
        Me.txt口座番号.Name = "txt口座番号"
        Me.txt口座番号.Size = New System.Drawing.Size(134, 26)
        Me.txt口座番号.TabIndex = 47
        '
        'txt口座名義
        '
        Me.txt口座名義.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt口座名義.Location = New System.Drawing.Point(1008, 210)
        Me.txt口座名義.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt口座名義.MaxLength = 50
        Me.txt口座名義.Name = "txt口座名義"
        Me.txt口座名義.Size = New System.Drawing.Size(164, 26)
        Me.txt口座名義.TabIndex = 49
        '
        'txt備考
        '
        Me.txt備考.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt備考.Location = New System.Drawing.Point(100, 242)
        Me.txt備考.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt備考.Multiline = True
        Me.txt備考.Name = "txt備考"
        Me.txt備考.Size = New System.Drawing.Size(787, 87)
        Me.txt備考.TabIndex = 51
        '
        'rdo男
        '
        Me.rdo男.AutoSize = True
        Me.rdo男.Checked = True
        Me.rdo男.Location = New System.Drawing.Point(14, 3)
        Me.rdo男.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo男.Name = "rdo男"
        Me.rdo男.Size = New System.Drawing.Size(46, 23)
        Me.rdo男.TabIndex = 0
        Me.rdo男.TabStop = True
        Me.rdo男.Text = "男"
        Me.rdo男.UseVisualStyleBackColor = True
        '
        'rdo女
        '
        Me.rdo女.AutoSize = True
        Me.rdo女.Location = New System.Drawing.Point(64, 3)
        Me.rdo女.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.rdo女.Name = "rdo女"
        Me.rdo女.Size = New System.Drawing.Size(46, 23)
        Me.rdo女.TabIndex = 1
        Me.rdo女.Text = "女"
        Me.rdo女.UseVisualStyleBackColor = True
        '
        'cmb担当理事
        '
        Me.cmb担当理事.FormattingEnabled = True
        Me.cmb担当理事.Location = New System.Drawing.Point(99, 176)
        Me.cmb担当理事.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmb担当理事.Name = "cmb担当理事"
        Me.cmb担当理事.Size = New System.Drawing.Size(164, 27)
        Me.cmb担当理事.TabIndex = 33
        '
        'btn登録
        '
        Me.btn登録.ForeColor = System.Drawing.Color.Blue
        Me.btn登録.Location = New System.Drawing.Point(1047, 293)
        Me.btn登録.Margin = New System.Windows.Forms.Padding(5)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(125, 36)
        Me.btn登録.TabIndex = 52
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.AllowUserToDeleteRows = False
        Me.dgv一覧.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.col会員ID, Me.colLINE送信, Me.col氏名, Me.colフリガナ, Me.colパスワード, Me.col役職名, Me.col性別, Me.col生年月日, Me.col郵便番号, Me.col住所, Me.col電話番号, Me.colラインID, Me.colメールアドレス, Me.col担当理事, Me.col入会日, Me.col退会日, Me.col銀行名, Me.col銀行支店名, Me.col口座種類, Me.col口座番号, Me.col口座名義, Me.col備考})
        Me.dgv一覧.Location = New System.Drawing.Point(17, 339)
        Me.dgv一覧.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowHeadersWidth = 51
        Me.dgv一覧.RowTemplate.Height = 30
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(1155, 345)
        Me.dgv一覧.TabIndex = 53
        Me.dgv一覧.TabStop = False
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = False
        Me.colID.Width = 70
        '
        'col会員ID
        '
        Me.col会員ID.DataPropertyName = "会員ID"
        Me.col会員ID.HeaderText = "会員ID"
        Me.col会員ID.Name = "col会員ID"
        Me.col会員ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col会員ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colLINE送信
        '
        Me.colLINE送信.HeaderText = "メッセージ"
        Me.colLINE送信.Name = "colLINE送信"
        Me.colLINE送信.ReadOnly = True
        Me.colLINE送信.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colLINE送信.Text = "LINE送信"
        Me.colLINE送信.UseColumnTextForButtonValue = True
        Me.colLINE送信.Width = 120
        '
        'col氏名
        '
        Me.col氏名.DataPropertyName = "氏名"
        Me.col氏名.HeaderText = "氏名"
        Me.col氏名.Name = "col氏名"
        Me.col氏名.Width = 200
        '
        'colフリガナ
        '
        Me.colフリガナ.DataPropertyName = "フリガナ"
        Me.colフリガナ.HeaderText = "フリガナ"
        Me.colフリガナ.Name = "colフリガナ"
        Me.colフリガナ.Visible = False
        '
        'colパスワード
        '
        Me.colパスワード.DataPropertyName = "パスワード"
        Me.colパスワード.HeaderText = "パスワード"
        Me.colパスワード.Name = "colパスワード"
        Me.colパスワード.Width = 120
        '
        'col役職名
        '
        Me.col役職名.DataPropertyName = "役職名"
        Me.col役職名.HeaderText = "役職名"
        Me.col役職名.Name = "col役職名"
        Me.col役職名.Width = 200
        '
        'col性別
        '
        Me.col性別.DataPropertyName = "性別"
        Me.col性別.HeaderText = "性別"
        Me.col性別.Name = "col性別"
        Me.col性別.Width = 70
        '
        'col生年月日
        '
        Me.col生年月日.DataPropertyName = "生年月日"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.col生年月日.DefaultCellStyle = DataGridViewCellStyle1
        Me.col生年月日.HeaderText = "生年月日"
        Me.col生年月日.Name = "col生年月日"
        Me.col生年月日.Width = 120
        '
        'col郵便番号
        '
        Me.col郵便番号.DataPropertyName = "郵便番号"
        Me.col郵便番号.HeaderText = "郵便番号"
        Me.col郵便番号.Name = "col郵便番号"
        Me.col郵便番号.Width = 120
        '
        'col住所
        '
        Me.col住所.DataPropertyName = "住所"
        Me.col住所.HeaderText = "住所"
        Me.col住所.Name = "col住所"
        Me.col住所.Width = 400
        '
        'col電話番号
        '
        Me.col電話番号.DataPropertyName = "電話番号"
        Me.col電話番号.HeaderText = "電話番号"
        Me.col電話番号.Name = "col電話番号"
        Me.col電話番号.Width = 200
        '
        'colラインID
        '
        Me.colラインID.DataPropertyName = "ラインID"
        Me.colラインID.HeaderText = "ラインID"
        Me.colラインID.Name = "colラインID"
        '
        'colメールアドレス
        '
        Me.colメールアドレス.DataPropertyName = "メールアドレス"
        Me.colメールアドレス.HeaderText = "メールアドレス"
        Me.colメールアドレス.Name = "colメールアドレス"
        Me.colメールアドレス.Width = 200
        '
        'col担当理事
        '
        Me.col担当理事.DataPropertyName = "担当理事"
        Me.col担当理事.HeaderText = "担当理事"
        Me.col担当理事.Name = "col担当理事"
        Me.col担当理事.Width = 200
        '
        'col入会日
        '
        Me.col入会日.DataPropertyName = "入会日"
        Me.col入会日.HeaderText = "入会日"
        Me.col入会日.Name = "col入会日"
        Me.col入会日.Width = 120
        '
        'col退会日
        '
        Me.col退会日.DataPropertyName = "退会日"
        Me.col退会日.HeaderText = "退会日"
        Me.col退会日.Name = "col退会日"
        Me.col退会日.Width = 120
        '
        'col銀行名
        '
        Me.col銀行名.DataPropertyName = "銀行名"
        Me.col銀行名.HeaderText = "銀行名"
        Me.col銀行名.Name = "col銀行名"
        Me.col銀行名.Width = 120
        '
        'col銀行支店名
        '
        Me.col銀行支店名.DataPropertyName = "銀行支店名"
        Me.col銀行支店名.HeaderText = "銀行支店名"
        Me.col銀行支店名.Name = "col銀行支店名"
        Me.col銀行支店名.Width = 130
        '
        'col口座種類
        '
        Me.col口座種類.DataPropertyName = "口座種類"
        Me.col口座種類.HeaderText = "口座種類"
        Me.col口座種類.Name = "col口座種類"
        Me.col口座種類.Width = 120
        '
        'col口座番号
        '
        Me.col口座番号.DataPropertyName = "口座番号"
        Me.col口座番号.HeaderText = "口座番号"
        Me.col口座番号.Name = "col口座番号"
        Me.col口座番号.Width = 120
        '
        'col口座名義
        '
        Me.col口座名義.DataPropertyName = "口座名義"
        Me.col口座名義.HeaderText = "口座名義"
        Me.col口座名義.Name = "col口座名義"
        Me.col口座名義.Width = 200
        '
        'col備考
        '
        Me.col備考.DataPropertyName = "備考"
        Me.col備考.HeaderText = "備考"
        Me.col備考.Name = "col備考"
        Me.col備考.Width = 300
        '
        'btn取得
        '
        Me.btn取得.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn取得.ForeColor = System.Drawing.Color.Red
        Me.btn取得.Location = New System.Drawing.Point(196, 144)
        Me.btn取得.Margin = New System.Windows.Forms.Padding(5)
        Me.btn取得.Name = "btn取得"
        Me.btn取得.Size = New System.Drawing.Size(26, 26)
        Me.btn取得.TabIndex = 30
        Me.btn取得.Text = "〒"
        Me.btn取得.UseVisualStyleBackColor = True
        '
        'btn閉じる
        '
        Me.btn閉じる.Location = New System.Drawing.Point(1498, 1094)
        Me.btn閉じる.Margin = New System.Windows.Forms.Padding(5)
        Me.btn閉じる.Name = "btn閉じる"
        Me.btn閉じる.Size = New System.Drawing.Size(125, 36)
        Me.btn閉じる.TabIndex = 9
        Me.btn閉じる.Text = "閉じる"
        Me.btn閉じる.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rdo男)
        Me.Panel1.Controls.Add(Me.rdo女)
        Me.Panel1.Location = New System.Drawing.Point(699, 46)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(117, 28)
        Me.Panel1.TabIndex = 12
        '
        'txt退会日
        '
        Me.txt退会日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt退会日.Location = New System.Drawing.Point(699, 175)
        Me.txt退会日.Margin = New System.Windows.Forms.Padding(5)
        Me.txt退会日.Name = "txt退会日"
        Me.txt退会日.Size = New System.Drawing.Size(164, 26)
        Me.txt退会日.TabIndex = 39
        '
        'btn退会日
        '
        Me.btn退会日.Image = Global.カシオペイア.My.Resources.Resources.カレンダー
        Me.btn退会日.Location = New System.Drawing.Point(863, 176)
        Me.btn退会日.Margin = New System.Windows.Forms.Padding(5)
        Me.btn退会日.Name = "btn退会日"
        Me.btn退会日.Size = New System.Drawing.Size(26, 26)
        Me.btn退会日.TabIndex = 40
        Me.btn退会日.TabStop = False
        Me.btn退会日.UseVisualStyleBackColor = True
        '
        'txt生年月日
        '
        Me.txt生年月日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt生年月日.Location = New System.Drawing.Point(383, 80)
        Me.txt生年月日.Margin = New System.Windows.Forms.Padding(5)
        Me.txt生年月日.Name = "txt生年月日"
        Me.txt生年月日.Size = New System.Drawing.Size(164, 26)
        Me.txt生年月日.TabIndex = 17
        '
        'txt入会日
        '
        Me.txt入会日.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt入会日.Location = New System.Drawing.Point(382, 176)
        Me.txt入会日.Margin = New System.Windows.Forms.Padding(5)
        Me.txt入会日.Name = "txt入会日"
        Me.txt入会日.Size = New System.Drawing.Size(164, 26)
        Me.txt入会日.TabIndex = 35
        '
        'btn入会日
        '
        Me.btn入会日.Image = Global.カシオペイア.My.Resources.Resources.カレンダー
        Me.btn入会日.Location = New System.Drawing.Point(546, 176)
        Me.btn入会日.Margin = New System.Windows.Forms.Padding(5)
        Me.btn入会日.Name = "btn入会日"
        Me.btn入会日.Size = New System.Drawing.Size(26, 26)
        Me.btn入会日.TabIndex = 36
        Me.btn入会日.TabStop = False
        Me.btn入会日.UseVisualStyleBackColor = True
        '
        'btn生年月日
        '
        Me.btn生年月日.Image = Global.カシオペイア.My.Resources.Resources.カレンダー
        Me.btn生年月日.Location = New System.Drawing.Point(547, 80)
        Me.btn生年月日.Margin = New System.Windows.Forms.Padding(5)
        Me.btn生年月日.Name = "btn生年月日"
        Me.btn生年月日.Size = New System.Drawing.Size(26, 26)
        Me.btn生年月日.TabIndex = 18
        Me.btn生年月日.TabStop = False
        Me.btn生年月日.UseVisualStyleBackColor = True
        '
        'cmb口座種類
        '
        Me.cmb口座種類.FormattingEnabled = True
        Me.cmb口座種類.Items.AddRange(New Object() {"普通", "当座"})
        Me.cmb口座種類.Location = New System.Drawing.Point(699, 207)
        Me.cmb口座種類.Margin = New System.Windows.Forms.Padding(5)
        Me.cmb口座種類.Name = "cmb口座種類"
        Me.cmb口座種類.Size = New System.Drawing.Size(62, 27)
        Me.cmb口座種類.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(184, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(580, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "※"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(269, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "※"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(581, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "※"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(868, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "※"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(898, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "例）000-0000-0000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(552, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "※"
        '
        'lblラインID
        '
        Me.lblラインID.AutoSize = True
        Me.lblラインID.Location = New System.Drawing.Point(29, 115)
        Me.lblラインID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblラインID.Name = "lblラインID"
        Me.lblラインID.Size = New System.Drawing.Size(67, 19)
        Me.lblラインID.TabIndex = 24
        Me.lblラインID.Text = "ラインID"
        '
        'txtラインID
        '
        Me.txtラインID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtラインID.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtラインID.Location = New System.Drawing.Point(100, 112)
        Me.txtラインID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtラインID.MaxLength = 50
        Me.txtラインID.Name = "txtラインID"
        Me.txtラインID.ReadOnly = True
        Me.txtラインID.Size = New System.Drawing.Size(164, 26)
        Me.txtラインID.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(312, 51)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "役職名"
        '
        'cmb役職名
        '
        Me.cmb役職名.FormattingEnabled = True
        Me.cmb役職名.Items.AddRange(New Object() {"○○理事", "△△理事", "□□理事"})
        Me.cmb役職名.Location = New System.Drawing.Point(382, 47)
        Me.cmb役職名.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmb役職名.Name = "cmb役職名"
        Me.cmb役職名.Size = New System.Drawing.Size(164, 27)
        Me.cmb役職名.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(551, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "※"
        '
        'btnクリア
        '
        Me.btnクリア.Location = New System.Drawing.Point(914, 293)
        Me.btnクリア.Name = "btnクリア"
        Me.btnクリア.Size = New System.Drawing.Size(125, 36)
        Me.btnクリア.TabIndex = 102
        Me.btnクリア.TabStop = False
        Me.btnクリア.Text = "クリア"
        Me.btnクリア.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(190, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 16)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "※"
        '
        'btn会員名簿
        '
        Me.btn会員名簿.ForeColor = System.Drawing.Color.Green
        Me.btn会員名簿.Location = New System.Drawing.Point(889, 694)
        Me.btn会員名簿.Name = "btn会員名簿"
        Me.btn会員名簿.Size = New System.Drawing.Size(125, 40)
        Me.btn会員名簿.TabIndex = 104
        Me.btn会員名簿.Text = "会員名簿"
        Me.btn会員名簿.UseVisualStyleBackColor = True
        '
        'frmM会員
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 741)
        Me.Controls.Add(Me.btn会員名簿)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnクリア)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb役職名)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtラインID)
        Me.Controls.Add(Me.lblラインID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb口座種類)
        Me.Controls.Add(Me.btn生年月日)
        Me.Controls.Add(Me.btn入会日)
        Me.Controls.Add(Me.txt入会日)
        Me.Controls.Add(Me.txt生年月日)
        Me.Controls.Add(Me.btn退会日)
        Me.Controls.Add(Me.txt退会日)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn取得)
        Me.Controls.Add(Me.dgv一覧)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.cmb担当理事)
        Me.Controls.Add(Me.txt備考)
        Me.Controls.Add(Me.txt口座名義)
        Me.Controls.Add(Me.txt口座番号)
        Me.Controls.Add(Me.txt銀行支店名)
        Me.Controls.Add(Me.txt銀行名)
        Me.Controls.Add(Me.txtメールアドレス)
        Me.Controls.Add(Me.txt電話番号)
        Me.Controls.Add(Me.txt住所)
        Me.Controls.Add(Me.txt郵便番号)
        Me.Controls.Add(Me.txt氏名)
        Me.Controls.Add(Me.txtフリガナ)
        Me.Controls.Add(Me.txtパスワード)
        Me.Controls.Add(Me.txt会員ID)
        Me.Controls.Add(Me.lbl備考)
        Me.Controls.Add(Me.lbl口座名義)
        Me.Controls.Add(Me.lbl口座番号)
        Me.Controls.Add(Me.lbl銀行支店名)
        Me.Controls.Add(Me.lbl銀行名)
        Me.Controls.Add(Me.lbl退会日)
        Me.Controls.Add(Me.lbl入会日)
        Me.Controls.Add(Me.lbl担当理事)
        Me.Controls.Add(Me.lblメールアドレス)
        Me.Controls.Add(Me.lbl電話番号)
        Me.Controls.Add(Me.lbl郵便番号)
        Me.Controls.Add(Me.lbl生年月日)
        Me.Controls.Add(Me.lbl性別)
        Me.Controls.Add(Me.lbl氏名)
        Me.Controls.Add(Me.lblフリガナ)
        Me.Controls.Add(Me.lblパスワード)
        Me.Controls.Add(Me.lbl会員ID)
        Me.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmM会員"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " 会員マスタ      "
        Me.Controls.SetChildIndex(Me.lbl会員ID, 0)
        Me.Controls.SetChildIndex(Me.lblパスワード, 0)
        Me.Controls.SetChildIndex(Me.lblフリガナ, 0)
        Me.Controls.SetChildIndex(Me.lbl氏名, 0)
        Me.Controls.SetChildIndex(Me.lbl性別, 0)
        Me.Controls.SetChildIndex(Me.lbl生年月日, 0)
        Me.Controls.SetChildIndex(Me.lbl郵便番号, 0)
        Me.Controls.SetChildIndex(Me.lbl電話番号, 0)
        Me.Controls.SetChildIndex(Me.lblメールアドレス, 0)
        Me.Controls.SetChildIndex(Me.lbl担当理事, 0)
        Me.Controls.SetChildIndex(Me.lbl入会日, 0)
        Me.Controls.SetChildIndex(Me.lbl退会日, 0)
        Me.Controls.SetChildIndex(Me.lbl銀行名, 0)
        Me.Controls.SetChildIndex(Me.lbl銀行支店名, 0)
        Me.Controls.SetChildIndex(Me.lbl口座番号, 0)
        Me.Controls.SetChildIndex(Me.lbl口座名義, 0)
        Me.Controls.SetChildIndex(Me.lbl備考, 0)
        Me.Controls.SetChildIndex(Me.txt会員ID, 0)
        Me.Controls.SetChildIndex(Me.txtパスワード, 0)
        Me.Controls.SetChildIndex(Me.txtフリガナ, 0)
        Me.Controls.SetChildIndex(Me.txt氏名, 0)
        Me.Controls.SetChildIndex(Me.txt郵便番号, 0)
        Me.Controls.SetChildIndex(Me.txt住所, 0)
        Me.Controls.SetChildIndex(Me.txt電話番号, 0)
        Me.Controls.SetChildIndex(Me.txtメールアドレス, 0)
        Me.Controls.SetChildIndex(Me.txt銀行名, 0)
        Me.Controls.SetChildIndex(Me.txt銀行支店名, 0)
        Me.Controls.SetChildIndex(Me.txt口座番号, 0)
        Me.Controls.SetChildIndex(Me.txt口座名義, 0)
        Me.Controls.SetChildIndex(Me.txt備考, 0)
        Me.Controls.SetChildIndex(Me.cmb担当理事, 0)
        Me.Controls.SetChildIndex(Me.btn登録, 0)
        Me.Controls.SetChildIndex(Me.dgv一覧, 0)
        Me.Controls.SetChildIndex(Me.btn取得, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.txt退会日, 0)
        Me.Controls.SetChildIndex(Me.btn退会日, 0)
        Me.Controls.SetChildIndex(Me.txt生年月日, 0)
        Me.Controls.SetChildIndex(Me.txt入会日, 0)
        Me.Controls.SetChildIndex(Me.btn入会日, 0)
        Me.Controls.SetChildIndex(Me.btn生年月日, 0)
        Me.Controls.SetChildIndex(Me.cmb口座種類, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.lblラインID, 0)
        Me.Controls.SetChildIndex(Me.txtラインID, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.cmb役職名, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.btnクリア, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.btn会員名簿, 0)
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl会員ID As Label
    Friend WithEvents lblパスワード As Label
    Friend WithEvents lblフリガナ As Label
    Friend WithEvents lbl氏名 As Label
    Friend WithEvents lbl性別 As Label
    Friend WithEvents lbl生年月日 As Label
    Friend WithEvents lbl郵便番号 As Label
    Friend WithEvents lbl電話番号 As Label
    Friend WithEvents lblメールアドレス As Label
    Friend WithEvents lbl担当理事 As Label
    Friend WithEvents lbl入会日 As Label
    Friend WithEvents lbl退会日 As Label
    Friend WithEvents lbl銀行名 As Label
    Friend WithEvents lbl銀行支店名 As Label
    Friend WithEvents lbl口座番号 As Label
    Friend WithEvents lbl口座名義 As Label
    Friend WithEvents lbl備考 As Label
    Friend WithEvents txt会員ID As TextBox
    Friend WithEvents txtパスワード As TextBox
    Friend WithEvents txtフリガナ As TextBox
    Friend WithEvents txt氏名 As TextBox
    Friend WithEvents txt郵便番号 As TextBox
    Friend WithEvents txt住所 As TextBox
    Friend WithEvents txt電話番号 As TextBox
    Friend WithEvents txtメールアドレス As TextBox
    Friend WithEvents txt銀行名 As TextBox
    Friend WithEvents txt銀行支店名 As TextBox
    Friend WithEvents txt口座番号 As TextBox
    Friend WithEvents txt口座名義 As TextBox
    Friend WithEvents txt備考 As TextBox
    Friend WithEvents rdo男 As RadioButton
    Friend WithEvents rdo女 As RadioButton
    Friend WithEvents cmb担当理事 As ComboBox
    Friend WithEvents btn登録 As Button
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents btn取得 As Button
    Friend WithEvents btn閉じる As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt退会日 As TextBox
    Friend WithEvents btn退会日 As Button
    Friend WithEvents txt生年月日 As TextBox
    Friend WithEvents txt入会日 As TextBox
    Friend WithEvents btn入会日 As Button
    Friend WithEvents btn生年月日 As Button
    Friend WithEvents cmb口座種類 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblラインID As Label
    Friend WithEvents txtラインID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb役職名 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnクリア As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btn会員名簿 As Button
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents col会員ID As DataGridViewButtonColumn
    Friend WithEvents colLINE送信 As DataGridViewButtonColumn
    Friend WithEvents col氏名 As DataGridViewTextBoxColumn
    Friend WithEvents colフリガナ As DataGridViewTextBoxColumn
    Friend WithEvents colパスワード As DataGridViewTextBoxColumn
    Friend WithEvents col役職名 As DataGridViewTextBoxColumn
    Friend WithEvents col性別 As DataGridViewTextBoxColumn
    Friend WithEvents col生年月日 As DataGridViewTextBoxColumn
    Friend WithEvents col郵便番号 As DataGridViewTextBoxColumn
    Friend WithEvents col住所 As DataGridViewTextBoxColumn
    Friend WithEvents col電話番号 As DataGridViewTextBoxColumn
    Friend WithEvents colラインID As DataGridViewTextBoxColumn
    Friend WithEvents colメールアドレス As DataGridViewTextBoxColumn
    Friend WithEvents col担当理事 As DataGridViewTextBoxColumn
    Friend WithEvents col入会日 As DataGridViewTextBoxColumn
    Friend WithEvents col退会日 As DataGridViewTextBoxColumn
    Friend WithEvents col銀行名 As DataGridViewTextBoxColumn
    Friend WithEvents col銀行支店名 As DataGridViewTextBoxColumn
    Friend WithEvents col口座種類 As DataGridViewTextBoxColumn
    Friend WithEvents col口座番号 As DataGridViewTextBoxColumn
    Friend WithEvents col口座名義 As DataGridViewTextBoxColumn
    Friend WithEvents col備考 As DataGridViewTextBoxColumn
End Class
