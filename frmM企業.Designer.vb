<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmM企業
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
        Me.btn郵便番号 = New System.Windows.Forms.Button()
        Me.lbl企業名 = New System.Windows.Forms.Label()
        Me.txt代表者名 = New System.Windows.Forms.TextBox()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col口座 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col企業ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colフリガナ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col企業名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col支店名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col代表者名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col担当者名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col郵便番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col住所 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col電話番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFAX番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colメールアドレス = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHPアドレス = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col銀行名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col銀行支店名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col口座種別 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col口座番号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col口座名義 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col登録日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col更新日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col社内担当者 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl電話 = New System.Windows.Forms.Label()
        Me.lbl住所 = New System.Windows.Forms.Label()
        Me.lbl代表者名 = New System.Windows.Forms.Label()
        Me.lbl支店名 = New System.Windows.Forms.Label()
        Me.lbl郵便番号 = New System.Windows.Forms.Label()
        Me.lblフリガナ = New System.Windows.Forms.Label()
        Me.txt住所 = New System.Windows.Forms.TextBox()
        Me.txt郵便番号 = New System.Windows.Forms.TextBox()
        Me.txt支店名 = New System.Windows.Forms.TextBox()
        Me.txtフリガナ = New System.Windows.Forms.TextBox()
        Me.txt企業名 = New System.Windows.Forms.TextBox()
        Me.txt企業ID = New System.Windows.Forms.TextBox()
        Me.lbl企業ID = New System.Windows.Forms.Label()
        Me.lblメアド = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.txt備考 = New System.Windows.Forms.TextBox()
        Me.txtHPアドレス = New System.Windows.Forms.TextBox()
        Me.txtメアド = New System.Windows.Forms.TextBox()
        Me.txt電話番号 = New System.Windows.Forms.TextBox()
        Me.txtFAX番号 = New System.Windows.Forms.TextBox()
        Me.lblHPアド = New System.Windows.Forms.Label()
        Me.lbl担当者名 = New System.Windows.Forms.Label()
        Me.txt担当者名 = New System.Windows.Forms.TextBox()
        Me.lbl備考 = New System.Windows.Forms.Label()
        Me.lbl銀行名 = New System.Windows.Forms.Label()
        Me.txt口座名義 = New System.Windows.Forms.TextBox()
        Me.txt銀行支店名 = New System.Windows.Forms.TextBox()
        Me.txt銀行名 = New System.Windows.Forms.TextBox()
        Me.lbl銀行支店名 = New System.Windows.Forms.Label()
        Me.lbl口座番号 = New System.Windows.Forms.Label()
        Me.cmb口座種別 = New System.Windows.Forms.ComboBox()
        Me.txt口座番号 = New System.Windows.Forms.TextBox()
        Me.lbl口座名義 = New System.Windows.Forms.Label()
        Me.lbl社内担当者 = New System.Windows.Forms.Label()
        Me.txt社内担当者 = New System.Windows.Forms.TextBox()
        Me.lbl登録日 = New System.Windows.Forms.Label()
        Me.lbl更新日 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx削除 = New System.Windows.Forms.CheckBox()
        Me.btnクリア = New System.Windows.Forms.Button()
        Me.btnCSV = New System.Windows.Forms.Button()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn郵便番号
        '
        Me.btn郵便番号.Location = New System.Drawing.Point(240, 136)
        Me.btn郵便番号.Name = "btn郵便番号"
        Me.btn郵便番号.Size = New System.Drawing.Size(47, 29)
        Me.btn郵便番号.TabIndex = 20
        Me.btn郵便番号.Text = "〒"
        Me.btn郵便番号.UseVisualStyleBackColor = True
        '
        'lbl企業名
        '
        Me.lbl企業名.AutoSize = True
        Me.lbl企業名.Location = New System.Drawing.Point(38, 84)
        Me.lbl企業名.Name = "lbl企業名"
        Me.lbl企業名.Size = New System.Drawing.Size(66, 19)
        Me.lbl企業名.TabIndex = 2
        Me.lbl企業名.Text = "企業名"
        '
        'txt代表者名
        '
        Me.txt代表者名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt代表者名.Location = New System.Drawing.Point(582, 106)
        Me.txt代表者名.Name = "txt代表者名"
        Me.txt代表者名.Size = New System.Drawing.Size(204, 26)
        Me.txt代表者名.TabIndex = 9
        '
        'dgv一覧
        '
        Me.dgv一覧.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.col口座, Me.col企業ID, Me.colフリガナ, Me.col企業名, Me.col支店名, Me.col代表者名, Me.col担当者名, Me.col郵便番号, Me.col住所, Me.col電話番号, Me.colFAX番号, Me.colメールアドレス, Me.colHPアドレス, Me.col銀行名, Me.col銀行支店名, Me.col口座種別, Me.col口座番号, Me.col口座名義, Me.col登録日, Me.col更新日, Me.col備考, Me.col社内担当者})
        Me.dgv一覧.Location = New System.Drawing.Point(12, 358)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowHeadersWidth = 51
        Me.dgv一覧.RowTemplate.Height = 30
        Me.dgv一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv一覧.Size = New System.Drawing.Size(1169, 328)
        Me.dgv一覧.TabIndex = 46
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "colID"
        Me.colID.Name = "colID"
        Me.colID.Visible = False
        '
        'col口座
        '
        Me.col口座.DataPropertyName = "口座"
        Me.col口座.HeaderText = "口座"
        Me.col口座.Name = "col口座"
        Me.col口座.Visible = False
        '
        'col企業ID
        '
        Me.col企業ID.DataPropertyName = "企業ID"
        Me.col企業ID.HeaderText = "企業ID"
        Me.col企業ID.Name = "col企業ID"
        Me.col企業ID.Width = 90
        '
        'colフリガナ
        '
        Me.colフリガナ.DataPropertyName = "フリガナ"
        Me.colフリガナ.HeaderText = "フリガナ"
        Me.colフリガナ.Name = "colフリガナ"
        Me.colフリガナ.Width = 120
        '
        'col企業名
        '
        Me.col企業名.DataPropertyName = "企業名"
        Me.col企業名.HeaderText = "企業名"
        Me.col企業名.Name = "col企業名"
        Me.col企業名.Width = 200
        '
        'col支店名
        '
        Me.col支店名.DataPropertyName = "支店名"
        Me.col支店名.HeaderText = "支店名"
        Me.col支店名.Name = "col支店名"
        Me.col支店名.Width = 200
        '
        'col代表者名
        '
        Me.col代表者名.DataPropertyName = "代表者名"
        Me.col代表者名.HeaderText = "代表者名"
        Me.col代表者名.Name = "col代表者名"
        Me.col代表者名.Width = 120
        '
        'col担当者名
        '
        Me.col担当者名.DataPropertyName = "担当者名"
        Me.col担当者名.HeaderText = "担当者名"
        Me.col担当者名.Name = "col担当者名"
        Me.col担当者名.Width = 120
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
        Me.col電話番号.Width = 120
        '
        'colFAX番号
        '
        Me.colFAX番号.DataPropertyName = "FAX番号"
        Me.colFAX番号.HeaderText = "FAX番号"
        Me.colFAX番号.Name = "colFAX番号"
        Me.colFAX番号.Width = 120
        '
        'colメールアドレス
        '
        Me.colメールアドレス.DataPropertyName = "メールアドレス"
        Me.colメールアドレス.HeaderText = "メールアドレス"
        Me.colメールアドレス.Name = "colメールアドレス"
        Me.colメールアドレス.Width = 200
        '
        'colHPアドレス
        '
        Me.colHPアドレス.DataPropertyName = "HPアドレス"
        Me.colHPアドレス.HeaderText = "HPアドレス"
        Me.colHPアドレス.Name = "colHPアドレス"
        Me.colHPアドレス.Width = 200
        '
        'col銀行名
        '
        Me.col銀行名.DataPropertyName = "銀行名"
        Me.col銀行名.HeaderText = "銀行名"
        Me.col銀行名.Name = "col銀行名"
        Me.col銀行名.Width = 130
        '
        'col銀行支店名
        '
        Me.col銀行支店名.DataPropertyName = "銀行支店名"
        Me.col銀行支店名.HeaderText = "銀行支店名"
        Me.col銀行支店名.Name = "col銀行支店名"
        Me.col銀行支店名.Width = 130
        '
        'col口座種別
        '
        Me.col口座種別.DataPropertyName = "口座種別"
        Me.col口座種別.HeaderText = "口座種別"
        Me.col口座種別.Name = "col口座種別"
        Me.col口座種別.Width = 120
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
        Me.col口座名義.Width = 120
        '
        'col登録日
        '
        Me.col登録日.DataPropertyName = "登録日"
        Me.col登録日.HeaderText = "登録日"
        Me.col登録日.Name = "col登録日"
        Me.col登録日.Width = 130
        '
        'col更新日
        '
        Me.col更新日.DataPropertyName = "更新日"
        Me.col更新日.HeaderText = "更新日"
        Me.col更新日.Name = "col更新日"
        Me.col更新日.Width = 130
        '
        'col備考
        '
        Me.col備考.DataPropertyName = "備考"
        Me.col備考.HeaderText = "備考"
        Me.col備考.Name = "col備考"
        Me.col備考.Width = 300
        '
        'col社内担当者
        '
        Me.col社内担当者.DataPropertyName = "社内担当者"
        Me.col社内担当者.HeaderText = "社内担当者"
        Me.col社内担当者.Name = "col社内担当者"
        Me.col社内担当者.Width = 150
        '
        'lbl電話
        '
        Me.lbl電話.AutoSize = True
        Me.lbl電話.Location = New System.Drawing.Point(16, 171)
        Me.lbl電話.Name = "lbl電話"
        Me.lbl電話.Size = New System.Drawing.Size(85, 19)
        Me.lbl電話.TabIndex = 23
        Me.lbl電話.Text = "電話番号"
        '
        'lbl住所
        '
        Me.lbl住所.AutoSize = True
        Me.lbl住所.Location = New System.Drawing.Point(305, 143)
        Me.lbl住所.Name = "lbl住所"
        Me.lbl住所.Size = New System.Drawing.Size(47, 19)
        Me.lbl住所.TabIndex = 21
        Me.lbl住所.Text = "住所"
        '
        'lbl代表者名
        '
        Me.lbl代表者名.AutoSize = True
        Me.lbl代表者名.Location = New System.Drawing.Point(487, 109)
        Me.lbl代表者名.Name = "lbl代表者名"
        Me.lbl代表者名.Size = New System.Drawing.Size(85, 19)
        Me.lbl代表者名.TabIndex = 8
        Me.lbl代表者名.Text = "代表者名"
        '
        'lbl支店名
        '
        Me.lbl支店名.AutoSize = True
        Me.lbl支店名.Location = New System.Drawing.Point(38, 113)
        Me.lbl支店名.Name = "lbl支店名"
        Me.lbl支店名.Size = New System.Drawing.Size(66, 19)
        Me.lbl支店名.TabIndex = 6
        Me.lbl支店名.Text = "支店名"
        '
        'lbl郵便番号
        '
        Me.lbl郵便番号.AutoSize = True
        Me.lbl郵便番号.Location = New System.Drawing.Point(19, 141)
        Me.lbl郵便番号.Name = "lbl郵便番号"
        Me.lbl郵便番号.Size = New System.Drawing.Size(85, 19)
        Me.lbl郵便番号.TabIndex = 18
        Me.lbl郵便番号.Text = "郵便番号"
        '
        'lblフリガナ
        '
        Me.lblフリガナ.AutoSize = True
        Me.lblフリガナ.Location = New System.Drawing.Point(38, 55)
        Me.lblフリガナ.Name = "lblフリガナ"
        Me.lblフリガナ.Size = New System.Drawing.Size(63, 19)
        Me.lblフリガナ.TabIndex = 4
        Me.lblフリガナ.Text = "フリガナ"
        '
        'txt住所
        '
        Me.txt住所.Location = New System.Drawing.Point(364, 138)
        Me.txt住所.Multiline = True
        Me.txt住所.Name = "txt住所"
        Me.txt住所.Size = New System.Drawing.Size(554, 26)
        Me.txt住所.TabIndex = 22
        '
        'txt郵便番号
        '
        Me.txt郵便番号.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt郵便番号.Location = New System.Drawing.Point(106, 138)
        Me.txt郵便番号.Name = "txt郵便番号"
        Me.txt郵便番号.Size = New System.Drawing.Size(124, 26)
        Me.txt郵便番号.TabIndex = 19
        '
        'txt支店名
        '
        Me.txt支店名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt支店名.Location = New System.Drawing.Point(106, 109)
        Me.txt支店名.Name = "txt支店名"
        Me.txt支店名.Size = New System.Drawing.Size(344, 26)
        Me.txt支店名.TabIndex = 7
        '
        'txtフリガナ
        '
        Me.txtフリガナ.BackColor = System.Drawing.Color.White
        Me.txtフリガナ.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.txtフリガナ.Location = New System.Drawing.Point(106, 51)
        Me.txtフリガナ.Name = "txtフリガナ"
        Me.txtフリガナ.Size = New System.Drawing.Size(344, 26)
        Me.txtフリガナ.TabIndex = 5
        Me.txtフリガナ.TabStop = False
        '
        'txt企業名
        '
        Me.txt企業名.BackColor = System.Drawing.Color.White
        Me.txt企業名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt企業名.Location = New System.Drawing.Point(106, 80)
        Me.txt企業名.Name = "txt企業名"
        Me.txt企業名.Size = New System.Drawing.Size(344, 26)
        Me.txt企業名.TabIndex = 3
        '
        'txt企業ID
        '
        Me.txt企業ID.BackColor = System.Drawing.Color.White
        Me.txt企業ID.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt企業ID.Location = New System.Drawing.Point(106, 16)
        Me.txt企業ID.Name = "txt企業ID"
        Me.txt企業ID.Size = New System.Drawing.Size(89, 26)
        Me.txt企業ID.TabIndex = 1
        '
        'lbl企業ID
        '
        Me.lbl企業ID.AutoSize = True
        Me.lbl企業ID.Location = New System.Drawing.Point(34, 19)
        Me.lbl企業ID.Name = "lbl企業ID"
        Me.lbl企業ID.Size = New System.Drawing.Size(64, 19)
        Me.lbl企業ID.TabIndex = 0
        Me.lbl企業ID.Text = "企業ID"
        '
        'lblメアド
        '
        Me.lblメアド.AutoSize = True
        Me.lblメアド.Location = New System.Drawing.Point(635, 170)
        Me.lblメアド.Name = "lblメアド"
        Me.lblメアド.Size = New System.Drawing.Size(111, 19)
        Me.lblメアド.TabIndex = 27
        Me.lblメアド.Text = "メールアドレス"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(308, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 19)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "FAX番号"
        '
        'btn登録
        '
        Me.btn登録.Location = New System.Drawing.Point(1049, 304)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(115, 46)
        Me.btn登録.TabIndex = 43
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'txt備考
        '
        Me.txt備考.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt備考.Location = New System.Drawing.Point(106, 259)
        Me.txt備考.Multiline = True
        Me.txt備考.Name = "txt備考"
        Me.txt備考.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt備考.Size = New System.Drawing.Size(754, 93)
        Me.txt備考.TabIndex = 32
        '
        'txtHPアドレス
        '
        Me.txtHPアドレス.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtHPアドレス.Location = New System.Drawing.Point(106, 197)
        Me.txtHPアドレス.Name = "txtHPアドレス"
        Me.txtHPアドレス.Size = New System.Drawing.Size(554, 26)
        Me.txtHPアドレス.TabIndex = 30
        '
        'txtメアド
        '
        Me.txtメアド.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtメアド.Location = New System.Drawing.Point(749, 168)
        Me.txtメアド.Name = "txtメアド"
        Me.txtメアド.Size = New System.Drawing.Size(380, 26)
        Me.txtメアド.TabIndex = 28
        '
        'txt電話番号
        '
        Me.txt電話番号.BackColor = System.Drawing.Color.White
        Me.txt電話番号.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt電話番号.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt電話番号.Location = New System.Drawing.Point(106, 168)
        Me.txt電話番号.Name = "txt電話番号"
        Me.txt電話番号.Size = New System.Drawing.Size(194, 26)
        Me.txt電話番号.TabIndex = 24
        '
        'txtFAX番号
        '
        Me.txtFAX番号.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtFAX番号.Location = New System.Drawing.Point(394, 167)
        Me.txtFAX番号.Name = "txtFAX番号"
        Me.txtFAX番号.Size = New System.Drawing.Size(217, 26)
        Me.txtFAX番号.TabIndex = 26
        '
        'lblHPアド
        '
        Me.lblHPアド.AutoSize = True
        Me.lblHPアド.Location = New System.Drawing.Point(11, 200)
        Me.lblHPアド.Name = "lblHPアド"
        Me.lblHPアド.Size = New System.Drawing.Size(90, 19)
        Me.lblHPアド.TabIndex = 29
        Me.lblHPアド.Text = "HPアドレス"
        '
        'lbl担当者名
        '
        Me.lbl担当者名.AutoSize = True
        Me.lbl担当者名.Location = New System.Drawing.Point(823, 109)
        Me.lbl担当者名.Name = "lbl担当者名"
        Me.lbl担当者名.Size = New System.Drawing.Size(85, 19)
        Me.lbl担当者名.TabIndex = 10
        Me.lbl担当者名.Text = "担当者名"
        '
        'txt担当者名
        '
        Me.txt担当者名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt担当者名.Location = New System.Drawing.Point(914, 106)
        Me.txt担当者名.Name = "txt担当者名"
        Me.txt担当者名.Size = New System.Drawing.Size(215, 26)
        Me.txt担当者名.TabIndex = 11
        '
        'lbl備考
        '
        Me.lbl備考.AutoSize = True
        Me.lbl備考.Location = New System.Drawing.Point(51, 263)
        Me.lbl備考.Name = "lbl備考"
        Me.lbl備考.Size = New System.Drawing.Size(47, 19)
        Me.lbl備考.TabIndex = 31
        Me.lbl備考.Text = "備考"
        '
        'lbl銀行名
        '
        Me.lbl銀行名.AutoSize = True
        Me.lbl銀行名.Location = New System.Drawing.Point(32, 230)
        Me.lbl銀行名.Name = "lbl銀行名"
        Me.lbl銀行名.Size = New System.Drawing.Size(66, 19)
        Me.lbl銀行名.TabIndex = 33
        Me.lbl銀行名.Text = "銀行名"
        '
        'txt口座名義
        '
        Me.txt口座名義.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.txt口座名義.Location = New System.Drawing.Point(959, 227)
        Me.txt口座名義.Name = "txt口座名義"
        Me.txt口座名義.Size = New System.Drawing.Size(212, 26)
        Me.txt口座名義.TabIndex = 41
        '
        'txt銀行支店名
        '
        Me.txt銀行支店名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt銀行支店名.Location = New System.Drawing.Point(378, 227)
        Me.txt銀行支店名.Name = "txt銀行支店名"
        Me.txt銀行支店名.Size = New System.Drawing.Size(194, 26)
        Me.txt銀行支店名.TabIndex = 36
        '
        'txt銀行名
        '
        Me.txt銀行名.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt銀行名.Location = New System.Drawing.Point(106, 227)
        Me.txt銀行名.Name = "txt銀行名"
        Me.txt銀行名.Size = New System.Drawing.Size(194, 26)
        Me.txt銀行名.TabIndex = 34
        '
        'lbl銀行支店名
        '
        Me.lbl銀行支店名.AutoSize = True
        Me.lbl銀行支店名.Location = New System.Drawing.Point(308, 231)
        Me.lbl銀行支店名.Name = "lbl銀行支店名"
        Me.lbl銀行支店名.Size = New System.Drawing.Size(66, 19)
        Me.lbl銀行支店名.TabIndex = 35
        Me.lbl銀行支店名.Text = "支店名"
        '
        'lbl口座番号
        '
        Me.lbl口座番号.AutoSize = True
        Me.lbl口座番号.Location = New System.Drawing.Point(578, 231)
        Me.lbl口座番号.Name = "lbl口座番号"
        Me.lbl口座番号.Size = New System.Drawing.Size(85, 19)
        Me.lbl口座番号.TabIndex = 37
        Me.lbl口座番号.Text = "口座番号"
        '
        'cmb口座種別
        '
        Me.cmb口座種別.FormattingEnabled = True
        Me.cmb口座種別.Location = New System.Drawing.Point(665, 226)
        Me.cmb口座種別.Name = "cmb口座種別"
        Me.cmb口座種別.Size = New System.Drawing.Size(82, 27)
        Me.cmb口座種別.TabIndex = 38
        '
        'txt口座番号
        '
        Me.txt口座番号.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt口座番号.Location = New System.Drawing.Point(749, 226)
        Me.txt口座番号.Name = "txt口座番号"
        Me.txt口座番号.Size = New System.Drawing.Size(111, 26)
        Me.txt口座番号.TabIndex = 39
        '
        'lbl口座名義
        '
        Me.lbl口座名義.AutoSize = True
        Me.lbl口座名義.Location = New System.Drawing.Point(868, 230)
        Me.lbl口座名義.Name = "lbl口座名義"
        Me.lbl口座名義.Size = New System.Drawing.Size(85, 19)
        Me.lbl口座名義.TabIndex = 40
        Me.lbl口座名義.Text = "口座名義"
        '
        'lbl社内担当者
        '
        Me.lbl社内担当者.AutoSize = True
        Me.lbl社内担当者.Location = New System.Drawing.Point(914, 271)
        Me.lbl社内担当者.Name = "lbl社内担当者"
        Me.lbl社内担当者.Size = New System.Drawing.Size(104, 19)
        Me.lbl社内担当者.TabIndex = 44
        Me.lbl社内担当者.Text = "社内担当者"
        '
        'txt社内担当者
        '
        Me.txt社内担当者.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txt社内担当者.Location = New System.Drawing.Point(1020, 268)
        Me.txt社内担当者.Name = "txt社内担当者"
        Me.txt社内担当者.Size = New System.Drawing.Size(149, 26)
        Me.txt社内担当者.TabIndex = 45
        '
        'lbl登録日
        '
        Me.lbl登録日.AutoSize = True
        Me.lbl登録日.Location = New System.Drawing.Point(1197, 86)
        Me.lbl登録日.Name = "lbl登録日"
        Me.lbl登録日.Size = New System.Drawing.Size(76, 19)
        Me.lbl登録日.TabIndex = 46
        Me.lbl登録日.Text = "登録日："
        '
        'lbl更新日
        '
        Me.lbl更新日.AutoSize = True
        Me.lbl更新日.Location = New System.Drawing.Point(1197, 157)
        Me.lbl更新日.Name = "lbl更新日"
        Me.lbl更新日.Size = New System.Drawing.Size(76, 19)
        Me.lbl更新日.TabIndex = 47
        Me.lbl更新日.Text = "更新日："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1217, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 19)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "yy/mm/dd"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1217, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 19)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "yy/mm/dd"
        '
        'cbx削除
        '
        Me.cbx削除.AutoSize = True
        Me.cbx削除.Location = New System.Drawing.Point(977, 317)
        Me.cbx削除.Name = "cbx削除"
        Me.cbx削除.Size = New System.Drawing.Size(66, 23)
        Me.cbx削除.TabIndex = 42
        Me.cbx削除.Text = "削除"
        Me.cbx削除.UseVisualStyleBackColor = True
        '
        'btnクリア
        '
        Me.btnクリア.Location = New System.Drawing.Point(206, 14)
        Me.btnクリア.Name = "btnクリア"
        Me.btnクリア.Size = New System.Drawing.Size(47, 29)
        Me.btnクリア.TabIndex = 52
        Me.btnクリア.Text = "C"
        Me.btnクリア.UseVisualStyleBackColor = True
        '
        'btnCSV
        '
        Me.btnCSV.Location = New System.Drawing.Point(883, 694)
        Me.btnCSV.Name = "btnCSV"
        Me.btnCSV.Size = New System.Drawing.Size(135, 40)
        Me.btnCSV.TabIndex = 53
        Me.btnCSV.Text = "CSV"
        Me.btnCSV.UseVisualStyleBackColor = True
        '
        'frmM企業
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.btnCSV)
        Me.Controls.Add(Me.btnクリア)
        Me.Controls.Add(Me.cbx削除)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl更新日)
        Me.Controls.Add(Me.lbl登録日)
        Me.Controls.Add(Me.txt社内担当者)
        Me.Controls.Add(Me.lbl社内担当者)
        Me.Controls.Add(Me.lbl口座名義)
        Me.Controls.Add(Me.txt口座番号)
        Me.Controls.Add(Me.cmb口座種別)
        Me.Controls.Add(Me.lbl口座番号)
        Me.Controls.Add(Me.lbl銀行支店名)
        Me.Controls.Add(Me.txt銀行名)
        Me.Controls.Add(Me.txt銀行支店名)
        Me.Controls.Add(Me.txt口座名義)
        Me.Controls.Add(Me.lbl銀行名)
        Me.Controls.Add(Me.lbl備考)
        Me.Controls.Add(Me.txt担当者名)
        Me.Controls.Add(Me.lbl担当者名)
        Me.Controls.Add(Me.lblHPアド)
        Me.Controls.Add(Me.txtFAX番号)
        Me.Controls.Add(Me.txt電話番号)
        Me.Controls.Add(Me.txtメアド)
        Me.Controls.Add(Me.txtHPアドレス)
        Me.Controls.Add(Me.txt備考)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblメアド)
        Me.Controls.Add(Me.lbl企業ID)
        Me.Controls.Add(Me.txt企業ID)
        Me.Controls.Add(Me.txt企業名)
        Me.Controls.Add(Me.txtフリガナ)
        Me.Controls.Add(Me.txt支店名)
        Me.Controls.Add(Me.txt郵便番号)
        Me.Controls.Add(Me.txt住所)
        Me.Controls.Add(Me.lblフリガナ)
        Me.Controls.Add(Me.lbl郵便番号)
        Me.Controls.Add(Me.lbl支店名)
        Me.Controls.Add(Me.lbl代表者名)
        Me.Controls.Add(Me.lbl住所)
        Me.Controls.Add(Me.lbl電話)
        Me.Controls.Add(Me.dgv一覧)
        Me.Controls.Add(Me.txt代表者名)
        Me.Controls.Add(Me.lbl企業名)
        Me.Controls.Add(Me.btn郵便番号)
        Me.Margin = New System.Windows.Forms.Padding(3)
        Me.Name = "frmM企業"
        Me.Text = "企業マスタ"
        Me.Controls.SetChildIndex(Me.btn郵便番号, 0)
        Me.Controls.SetChildIndex(Me.lbl企業名, 0)
        Me.Controls.SetChildIndex(Me.txt代表者名, 0)
        Me.Controls.SetChildIndex(Me.dgv一覧, 0)
        Me.Controls.SetChildIndex(Me.lbl電話, 0)
        Me.Controls.SetChildIndex(Me.lbl住所, 0)
        Me.Controls.SetChildIndex(Me.lbl代表者名, 0)
        Me.Controls.SetChildIndex(Me.lbl支店名, 0)
        Me.Controls.SetChildIndex(Me.lbl郵便番号, 0)
        Me.Controls.SetChildIndex(Me.lblフリガナ, 0)
        Me.Controls.SetChildIndex(Me.txt住所, 0)
        Me.Controls.SetChildIndex(Me.txt郵便番号, 0)
        Me.Controls.SetChildIndex(Me.txt支店名, 0)
        Me.Controls.SetChildIndex(Me.txtフリガナ, 0)
        Me.Controls.SetChildIndex(Me.txt企業名, 0)
        Me.Controls.SetChildIndex(Me.txt企業ID, 0)
        Me.Controls.SetChildIndex(Me.lbl企業ID, 0)
        Me.Controls.SetChildIndex(Me.lblメアド, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.btn登録, 0)
        Me.Controls.SetChildIndex(Me.txt備考, 0)
        Me.Controls.SetChildIndex(Me.txtHPアドレス, 0)
        Me.Controls.SetChildIndex(Me.txtメアド, 0)
        Me.Controls.SetChildIndex(Me.txt電話番号, 0)
        Me.Controls.SetChildIndex(Me.txtFAX番号, 0)
        Me.Controls.SetChildIndex(Me.lblHPアド, 0)
        Me.Controls.SetChildIndex(Me.lbl担当者名, 0)
        Me.Controls.SetChildIndex(Me.txt担当者名, 0)
        Me.Controls.SetChildIndex(Me.lbl備考, 0)
        Me.Controls.SetChildIndex(Me.lbl銀行名, 0)
        Me.Controls.SetChildIndex(Me.txt口座名義, 0)
        Me.Controls.SetChildIndex(Me.txt銀行支店名, 0)
        Me.Controls.SetChildIndex(Me.txt銀行名, 0)
        Me.Controls.SetChildIndex(Me.lbl銀行支店名, 0)
        Me.Controls.SetChildIndex(Me.lbl口座番号, 0)
        Me.Controls.SetChildIndex(Me.cmb口座種別, 0)
        Me.Controls.SetChildIndex(Me.txt口座番号, 0)
        Me.Controls.SetChildIndex(Me.lbl口座名義, 0)
        Me.Controls.SetChildIndex(Me.lbl社内担当者, 0)
        Me.Controls.SetChildIndex(Me.txt社内担当者, 0)
        Me.Controls.SetChildIndex(Me.lbl登録日, 0)
        Me.Controls.SetChildIndex(Me.lbl更新日, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.cbx削除, 0)
        Me.Controls.SetChildIndex(Me.btnクリア, 0)
        Me.Controls.SetChildIndex(Me.btnCSV, 0)
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn郵便番号 As Button
    Friend WithEvents lbl企業名 As Label
    Friend WithEvents txt代表者名 As TextBox
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents lbl電話 As Label
    Friend WithEvents lbl住所 As Label
    Friend WithEvents lbl代表者名 As Label
    Friend WithEvents lbl支店名 As Label
    Friend WithEvents lbl郵便番号 As Label
    Friend WithEvents lblフリガナ As Label
    Friend WithEvents txt住所 As TextBox
    Friend WithEvents txt郵便番号 As TextBox
    Friend WithEvents txt支店名 As TextBox
    Friend WithEvents txtフリガナ As TextBox
    Friend WithEvents txt企業名 As TextBox
    Friend WithEvents txt企業ID As TextBox
    Friend WithEvents lbl企業ID As Label
    Friend WithEvents lblメアド As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn登録 As Button
    Friend WithEvents txt備考 As TextBox
    Friend WithEvents txtHPアドレス As TextBox
    Friend WithEvents txtメアド As TextBox
    Friend WithEvents txt電話番号 As TextBox
    Friend WithEvents txtFAX番号 As TextBox
    Friend WithEvents lblHPアド As Label
    Friend WithEvents lbl担当者名 As Label
    Friend WithEvents txt担当者名 As TextBox
    Friend WithEvents lbl備考 As Label
    Friend WithEvents lbl銀行名 As Label
    Friend WithEvents txt口座名義 As TextBox
    Friend WithEvents txt銀行支店名 As TextBox
    Friend WithEvents txt銀行名 As TextBox
    Friend WithEvents lbl銀行支店名 As Label
    Friend WithEvents lbl口座番号 As Label
    Friend WithEvents cmb口座種別 As ComboBox
    Friend WithEvents txt口座番号 As TextBox
    Friend WithEvents lbl口座名義 As Label
    Friend WithEvents lbl社内担当者 As Label
    Friend WithEvents txt社内担当者 As TextBox
    Friend WithEvents lbl登録日 As Label
    Friend WithEvents lbl更新日 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx削除 As CheckBox
    Friend WithEvents btnクリア As Button
    Friend WithEvents btnCSV As Button
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents col口座 As DataGridViewTextBoxColumn
    Friend WithEvents col企業ID As DataGridViewTextBoxColumn
    Friend WithEvents colフリガナ As DataGridViewTextBoxColumn
    Friend WithEvents col企業名 As DataGridViewTextBoxColumn
    Friend WithEvents col支店名 As DataGridViewTextBoxColumn
    Friend WithEvents col代表者名 As DataGridViewTextBoxColumn
    Friend WithEvents col担当者名 As DataGridViewTextBoxColumn
    Friend WithEvents col郵便番号 As DataGridViewTextBoxColumn
    Friend WithEvents col住所 As DataGridViewTextBoxColumn
    Friend WithEvents col電話番号 As DataGridViewTextBoxColumn
    Friend WithEvents colFAX番号 As DataGridViewTextBoxColumn
    Friend WithEvents colメールアドレス As DataGridViewTextBoxColumn
    Friend WithEvents colHPアドレス As DataGridViewTextBoxColumn
    Friend WithEvents col銀行名 As DataGridViewTextBoxColumn
    Friend WithEvents col銀行支店名 As DataGridViewTextBoxColumn
    Friend WithEvents col口座種別 As DataGridViewTextBoxColumn
    Friend WithEvents col口座番号 As DataGridViewTextBoxColumn
    Friend WithEvents col口座名義 As DataGridViewTextBoxColumn
    Friend WithEvents col登録日 As DataGridViewTextBoxColumn
    Friend WithEvents col更新日 As DataGridViewTextBoxColumn
    Friend WithEvents col備考 As DataGridViewTextBoxColumn
    Friend WithEvents col社内担当者 As DataGridViewTextBoxColumn
End Class
