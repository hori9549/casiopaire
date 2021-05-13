<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMプロジェクト
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtプロジェクトID = New System.Windows.Forms.TextBox()
        Me.txt内容 = New System.Windows.Forms.TextBox()
        Me.txtプロジェクト名 = New System.Windows.Forms.TextBox()
        Me.txt開始日 = New System.Windows.Forms.TextBox()
        Me.txt終了日 = New System.Windows.Forms.TextBox()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.cmb担当理事 = New System.Windows.Forms.ComboBox()
        Me.dgvプロジェクト = New System.Windows.Forms.DataGridView()
        Me.btn開始日 = New System.Windows.Forms.Button()
        Me.btn終了日 = New System.Windows.Forms.Button()
        Me.chc月 = New System.Windows.Forms.CheckBox()
        Me.chc水 = New System.Windows.Forms.CheckBox()
        Me.chc木 = New System.Windows.Forms.CheckBox()
        Me.chc火 = New System.Windows.Forms.CheckBox()
        Me.chc金 = New System.Windows.Forms.CheckBox()
        Me.chc土 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt備考 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chc日 = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn新規 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmb会員ID_P参加会員 = New System.Windows.Forms.ComboBox()
        Me.dgv参加会員 = New System.Windows.Forms.DataGridView()
        Me.colID_P参加会員 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colプロジェクト名_P参加会員 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col氏名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colプロジェクトID_P参加会員 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col会員ID_P参加会員 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考_P参加会員 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col削除_P参加会員 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn登録_P参加会員 = New System.Windows.Forms.Button()
        Me.chk削除_P参加会員 = New System.Windows.Forms.CheckBox()
        Me.txt備考_P参加会員 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbPID_P参加会員 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colプロジェクトID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colプロジェクト名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col内容 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col担当理事 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col開催日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col開始日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col終了日 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvプロジェクト, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv参加会員, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "プロジェクトID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "内容"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "開催日"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "開始日"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(370, 126)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "終了日"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 89)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "担当理事"
        '
        'txtプロジェクトID
        '
        Me.txtプロジェクトID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtプロジェクトID.Location = New System.Drawing.Point(142, 14)
        Me.txtプロジェクトID.Margin = New System.Windows.Forms.Padding(5)
        Me.txtプロジェクトID.Name = "txtプロジェクトID"
        Me.txtプロジェクトID.Size = New System.Drawing.Size(79, 26)
        Me.txtプロジェクトID.TabIndex = 1
        '
        'txt内容
        '
        Me.txt内容.Location = New System.Drawing.Point(142, 50)
        Me.txt内容.Margin = New System.Windows.Forms.Padding(5)
        Me.txt内容.Name = "txt内容"
        Me.txt内容.Size = New System.Drawing.Size(837, 26)
        Me.txt内容.TabIndex = 5
        '
        'txtプロジェクト名
        '
        Me.txtプロジェクト名.Location = New System.Drawing.Point(446, 14)
        Me.txtプロジェクト名.Margin = New System.Windows.Forms.Padding(5)
        Me.txtプロジェクト名.Name = "txtプロジェクト名"
        Me.txtプロジェクト名.Size = New System.Drawing.Size(533, 26)
        Me.txtプロジェクト名.TabIndex = 3
        '
        'txt開始日
        '
        Me.txt開始日.Location = New System.Drawing.Point(142, 123)
        Me.txt開始日.Margin = New System.Windows.Forms.Padding(5)
        Me.txt開始日.Name = "txt開始日"
        Me.txt開始日.Size = New System.Drawing.Size(164, 26)
        Me.txt開始日.TabIndex = 17
        '
        'txt終了日
        '
        Me.txt終了日.Location = New System.Drawing.Point(446, 124)
        Me.txt終了日.Margin = New System.Windows.Forms.Padding(5)
        Me.txt終了日.Name = "txt終了日"
        Me.txt終了日.Size = New System.Drawing.Size(164, 26)
        Me.txt終了日.TabIndex = 20
        '
        'btn登録
        '
        Me.btn登録.Location = New System.Drawing.Point(990, 174)
        Me.btn登録.Margin = New System.Windows.Forms.Padding(5)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(125, 36)
        Me.btn登録.TabIndex = 24
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'cmb担当理事
        '
        Me.cmb担当理事.FormattingEnabled = True
        Me.cmb担当理事.Location = New System.Drawing.Point(142, 86)
        Me.cmb担当理事.Margin = New System.Windows.Forms.Padding(5)
        Me.cmb担当理事.Name = "cmb担当理事"
        Me.cmb担当理事.Size = New System.Drawing.Size(199, 27)
        Me.cmb担当理事.TabIndex = 7
        '
        'dgvプロジェクト
        '
        Me.dgvプロジェクト.AllowUserToAddRows = False
        Me.dgvプロジェクト.AllowUserToDeleteRows = False
        Me.dgvプロジェクト.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvプロジェクト.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvプロジェクト.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colプロジェクトID, Me.colプロジェクト名, Me.col内容, Me.col担当理事, Me.col開催日, Me.col開始日, Me.col終了日, Me.col備考})
        Me.dgvプロジェクト.Location = New System.Drawing.Point(29, 220)
        Me.dgvプロジェクト.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvプロジェクト.Name = "dgvプロジェクト"
        Me.dgvプロジェクト.ReadOnly = True
        Me.dgvプロジェクト.RowHeadersVisible = False
        Me.dgvプロジェクト.RowTemplate.Height = 21
        Me.dgvプロジェクト.Size = New System.Drawing.Size(1086, 399)
        Me.dgvプロジェクト.TabIndex = 25
        Me.dgvプロジェクト.TabStop = False
        '
        'btn開始日
        '
        Me.btn開始日.Image = Global.カシオペイア.My.Resources.Resources.カレンダー
        Me.btn開始日.Location = New System.Drawing.Point(306, 123)
        Me.btn開始日.Name = "btn開始日"
        Me.btn開始日.Size = New System.Drawing.Size(26, 26)
        Me.btn開始日.TabIndex = 18
        Me.btn開始日.TabStop = False
        Me.btn開始日.UseVisualStyleBackColor = True
        '
        'btn終了日
        '
        Me.btn終了日.Image = Global.カシオペイア.My.Resources.Resources.カレンダー
        Me.btn終了日.Location = New System.Drawing.Point(610, 124)
        Me.btn終了日.Name = "btn終了日"
        Me.btn終了日.Size = New System.Drawing.Size(26, 26)
        Me.btn終了日.TabIndex = 21
        Me.btn終了日.TabStop = False
        Me.btn終了日.UseVisualStyleBackColor = True
        '
        'chc月
        '
        Me.chc月.AutoSize = True
        Me.chc月.Location = New System.Drawing.Point(444, 88)
        Me.chc月.Name = "chc月"
        Me.chc月.Size = New System.Drawing.Size(47, 23)
        Me.chc月.TabIndex = 9
        Me.chc月.Text = "月"
        Me.chc月.UseVisualStyleBackColor = True
        '
        'chc水
        '
        Me.chc水.AutoSize = True
        Me.chc水.Location = New System.Drawing.Point(550, 88)
        Me.chc水.Name = "chc水"
        Me.chc水.Size = New System.Drawing.Size(47, 23)
        Me.chc水.TabIndex = 11
        Me.chc水.Text = "水"
        Me.chc水.UseVisualStyleBackColor = True
        '
        'chc木
        '
        Me.chc木.AutoSize = True
        Me.chc木.Location = New System.Drawing.Point(603, 88)
        Me.chc木.Name = "chc木"
        Me.chc木.Size = New System.Drawing.Size(47, 23)
        Me.chc木.TabIndex = 12
        Me.chc木.Text = "木"
        Me.chc木.UseVisualStyleBackColor = True
        '
        'chc火
        '
        Me.chc火.AutoSize = True
        Me.chc火.Location = New System.Drawing.Point(497, 88)
        Me.chc火.Name = "chc火"
        Me.chc火.Size = New System.Drawing.Size(47, 23)
        Me.chc火.TabIndex = 10
        Me.chc火.Text = "火"
        Me.chc火.UseVisualStyleBackColor = True
        '
        'chc金
        '
        Me.chc金.AutoSize = True
        Me.chc金.Location = New System.Drawing.Point(656, 88)
        Me.chc金.Name = "chc金"
        Me.chc金.Size = New System.Drawing.Size(47, 23)
        Me.chc金.TabIndex = 13
        Me.chc金.Text = "金"
        Me.chc金.UseVisualStyleBackColor = True
        '
        'chc土
        '
        Me.chc土.AutoSize = True
        Me.chc土.Location = New System.Drawing.Point(709, 88)
        Me.chc土.Name = "chc土"
        Me.chc土.Size = New System.Drawing.Size(47, 23)
        Me.chc土.TabIndex = 14
        Me.chc土.Text = "土"
        Me.chc土.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(85, 162)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "備考"
        '
        'txt備考
        '
        Me.txt備考.Location = New System.Drawing.Point(142, 159)
        Me.txt備考.Margin = New System.Windows.Forms.Padding(5)
        Me.txt備考.Multiline = True
        Me.txt備考.Name = "txt備考"
        Me.txt備考.Size = New System.Drawing.Size(837, 51)
        Me.txt備考.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(327, 17)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 19)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "プロジェクト名"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(338, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 16)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "※"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(987, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "※"
        '
        'chc日
        '
        Me.chc日.AutoSize = True
        Me.chc日.Location = New System.Drawing.Point(762, 88)
        Me.chc日.Name = "chc日"
        Me.chc日.Size = New System.Drawing.Size(47, 23)
        Me.chc日.TabIndex = 15
        Me.chc日.Text = "日"
        Me.chc日.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1160, 674)
        Me.TabControl1.TabIndex = 102
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn新規)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.chc日)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txt備考)
        Me.TabPage1.Controls.Add(Me.txtプロジェクトID)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txt内容)
        Me.TabPage1.Controls.Add(Me.chc土)
        Me.TabPage1.Controls.Add(Me.txtプロジェクト名)
        Me.TabPage1.Controls.Add(Me.chc金)
        Me.TabPage1.Controls.Add(Me.txt開始日)
        Me.TabPage1.Controls.Add(Me.chc火)
        Me.TabPage1.Controls.Add(Me.txt終了日)
        Me.TabPage1.Controls.Add(Me.chc木)
        Me.TabPage1.Controls.Add(Me.btn登録)
        Me.TabPage1.Controls.Add(Me.chc水)
        Me.TabPage1.Controls.Add(Me.cmb担当理事)
        Me.TabPage1.Controls.Add(Me.chc月)
        Me.TabPage1.Controls.Add(Me.dgvプロジェクト)
        Me.TabPage1.Controls.Add(Me.btn終了日)
        Me.TabPage1.Controls.Add(Me.btn開始日)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1152, 641)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "プロジェクト"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn新規
        '
        Me.btn新規.Location = New System.Drawing.Point(222, 12)
        Me.btn新規.Name = "btn新規"
        Me.btn新規.Size = New System.Drawing.Size(30, 30)
        Me.btn新規.TabIndex = 29
        Me.btn新規.Text = "+"
        Me.btn新規.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmb会員ID_P参加会員)
        Me.TabPage2.Controls.Add(Me.dgv参加会員)
        Me.TabPage2.Controls.Add(Me.btn登録_P参加会員)
        Me.TabPage2.Controls.Add(Me.chk削除_P参加会員)
        Me.TabPage2.Controls.Add(Me.txt備考_P参加会員)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.cmbPID_P参加会員)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1152, 641)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "参加会員"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmb会員ID_P参加会員
        '
        Me.cmb会員ID_P参加会員.FormattingEnabled = True
        Me.cmb会員ID_P参加会員.Location = New System.Drawing.Point(140, 47)
        Me.cmb会員ID_P参加会員.Name = "cmb会員ID_P参加会員"
        Me.cmb会員ID_P参加会員.Size = New System.Drawing.Size(389, 27)
        Me.cmb会員ID_P参加会員.TabIndex = 12
        '
        'dgv参加会員
        '
        Me.dgv参加会員.AllowUserToAddRows = False
        Me.dgv参加会員.AllowUserToDeleteRows = False
        Me.dgv参加会員.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv参加会員.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv参加会員.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID_P参加会員, Me.colプロジェクト名_P参加会員, Me.col氏名, Me.colプロジェクトID_P参加会員, Me.col会員ID_P参加会員, Me.col備考_P参加会員, Me.col削除_P参加会員})
        Me.dgv参加会員.Location = New System.Drawing.Point(29, 140)
        Me.dgv参加会員.Name = "dgv参加会員"
        Me.dgv参加会員.ReadOnly = True
        Me.dgv参加会員.RowHeadersVisible = False
        Me.dgv参加会員.RowTemplate.Height = 21
        Me.dgv参加会員.Size = New System.Drawing.Size(1093, 479)
        Me.dgv参加会員.TabIndex = 11
        Me.dgv参加会員.TabStop = False
        '
        'colID_P参加会員
        '
        Me.colID_P参加会員.DataPropertyName = "ID"
        Me.colID_P参加会員.HeaderText = "ID"
        Me.colID_P参加会員.Name = "colID_P参加会員"
        Me.colID_P参加会員.ReadOnly = True
        Me.colID_P参加会員.Visible = False
        '
        'colプロジェクト名_P参加会員
        '
        Me.colプロジェクト名_P参加会員.DataPropertyName = "プロジェクト名"
        Me.colプロジェクト名_P参加会員.HeaderText = "プロジェクト名"
        Me.colプロジェクト名_P参加会員.Name = "colプロジェクト名_P参加会員"
        Me.colプロジェクト名_P参加会員.ReadOnly = True
        Me.colプロジェクト名_P参加会員.Width = 200
        '
        'col氏名
        '
        Me.col氏名.DataPropertyName = "氏名"
        Me.col氏名.HeaderText = "氏名"
        Me.col氏名.Name = "col氏名"
        Me.col氏名.ReadOnly = True
        Me.col氏名.Width = 200
        '
        'colプロジェクトID_P参加会員
        '
        Me.colプロジェクトID_P参加会員.DataPropertyName = "プロジェクトID"
        Me.colプロジェクトID_P参加会員.HeaderText = "プロジェクトID"
        Me.colプロジェクトID_P参加会員.Name = "colプロジェクトID_P参加会員"
        Me.colプロジェクトID_P参加会員.ReadOnly = True
        Me.colプロジェクトID_P参加会員.Visible = False
        Me.colプロジェクトID_P参加会員.Width = 200
        '
        'col会員ID_P参加会員
        '
        Me.col会員ID_P参加会員.DataPropertyName = "会員ID"
        Me.col会員ID_P参加会員.HeaderText = "会員ID"
        Me.col会員ID_P参加会員.Name = "col会員ID_P参加会員"
        Me.col会員ID_P参加会員.ReadOnly = True
        Me.col会員ID_P参加会員.Visible = False
        Me.col会員ID_P参加会員.Width = 200
        '
        'col備考_P参加会員
        '
        Me.col備考_P参加会員.DataPropertyName = "備考"
        Me.col備考_P参加会員.HeaderText = "備考"
        Me.col備考_P参加会員.Name = "col備考_P参加会員"
        Me.col備考_P参加会員.ReadOnly = True
        Me.col備考_P参加会員.Width = 400
        '
        'col削除_P参加会員
        '
        Me.col削除_P参加会員.DataPropertyName = "削除フラグ"
        Me.col削除_P参加会員.HeaderText = "削除"
        Me.col削除_P参加会員.Name = "col削除_P参加会員"
        Me.col削除_P参加会員.ReadOnly = True
        Me.col削除_P参加会員.Width = 75
        '
        'btn登録_P参加会員
        '
        Me.btn登録_P参加会員.Location = New System.Drawing.Point(999, 61)
        Me.btn登録_P参加会員.Name = "btn登録_P参加会員"
        Me.btn登録_P参加会員.Size = New System.Drawing.Size(123, 45)
        Me.btn登録_P参加会員.TabIndex = 10
        Me.btn登録_P参加会員.Text = "登録"
        Me.btn登録_P参加会員.UseVisualStyleBackColor = True
        '
        'chk削除_P参加会員
        '
        Me.chk削除_P参加会員.AutoSize = True
        Me.chk削除_P参加会員.Location = New System.Drawing.Point(846, 111)
        Me.chk削除_P参加会員.Name = "chk削除_P参加会員"
        Me.chk削除_P参加会員.Size = New System.Drawing.Size(66, 23)
        Me.chk削除_P参加会員.TabIndex = 9
        Me.chk削除_P参加会員.Text = "削除"
        Me.chk削除_P参加会員.UseVisualStyleBackColor = True
        '
        'txt備考_P参加会員
        '
        Me.txt備考_P参加会員.Location = New System.Drawing.Point(140, 80)
        Me.txt備考_P参加会員.Multiline = True
        Me.txt備考_P参加会員.Name = "txt備考_P参加会員"
        Me.txt備考_P参加会員.Size = New System.Drawing.Size(700, 54)
        Me.txt備考_P参加会員.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(85, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 19)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "備考"
        '
        'cmbPID_P参加会員
        '
        Me.cmbPID_P参加会員.FormattingEnabled = True
        Me.cmbPID_P参加会員.Location = New System.Drawing.Point(140, 14)
        Me.cmbPID_P参加会員.Name = "cmbPID_P参加会員"
        Me.cmbPID_P参加会員.Size = New System.Drawing.Size(389, 27)
        Me.cmbPID_P参加会員.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(68, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 19)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "会員ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 19)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "プロジェクトID"
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.Frozen = True
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'colプロジェクトID
        '
        Me.colプロジェクトID.DataPropertyName = "プロジェクトID"
        Me.colプロジェクトID.Frozen = True
        Me.colプロジェクトID.HeaderText = "プロジェクトID"
        Me.colプロジェクトID.Name = "colプロジェクトID"
        Me.colプロジェクトID.ReadOnly = True
        Me.colプロジェクトID.Width = 130
        '
        'colプロジェクト名
        '
        Me.colプロジェクト名.DataPropertyName = "プロジェクト名"
        Me.colプロジェクト名.Frozen = True
        Me.colプロジェクト名.HeaderText = "プロジェクト名"
        Me.colプロジェクト名.Name = "colプロジェクト名"
        Me.colプロジェクト名.ReadOnly = True
        Me.colプロジェクト名.Width = 300
        '
        'col内容
        '
        Me.col内容.DataPropertyName = "内容"
        Me.col内容.HeaderText = "内容"
        Me.col内容.Name = "col内容"
        Me.col内容.ReadOnly = True
        Me.col内容.Width = 400
        '
        'col担当理事
        '
        Me.col担当理事.DataPropertyName = "担当理事"
        Me.col担当理事.HeaderText = "担当理事"
        Me.col担当理事.Name = "col担当理事"
        Me.col担当理事.ReadOnly = True
        Me.col担当理事.Width = 200
        '
        'col開催日
        '
        Me.col開催日.DataPropertyName = "開催日"
        Me.col開催日.HeaderText = "開催日"
        Me.col開催日.Name = "col開催日"
        Me.col開催日.ReadOnly = True
        Me.col開催日.Width = 150
        '
        'col開始日
        '
        Me.col開始日.DataPropertyName = "開始日"
        Me.col開始日.HeaderText = "開始日"
        Me.col開始日.Name = "col開始日"
        Me.col開始日.ReadOnly = True
        Me.col開始日.Width = 120
        '
        'col終了日
        '
        Me.col終了日.DataPropertyName = "終了日"
        Me.col終了日.HeaderText = "終了日"
        Me.col終了日.Name = "col終了日"
        Me.col終了日.ReadOnly = True
        Me.col終了日.Width = 120
        '
        'col備考
        '
        Me.col備考.DataPropertyName = "備考"
        Me.col備考.HeaderText = "備考"
        Me.col備考.Name = "col備考"
        Me.col備考.ReadOnly = True
        Me.col備考.Width = 400
        '
        'frmMプロジェクト
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "frmMプロジェクト"
        Me.Text = "プロジェクトマスタ"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        CType(Me.dgvプロジェクト, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv参加会員, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtプロジェクトID As TextBox
    Friend WithEvents txt内容 As TextBox
    Friend WithEvents txtプロジェクト名 As TextBox
    Friend WithEvents txt開始日 As TextBox
    Friend WithEvents txt終了日 As TextBox
    Friend WithEvents btn登録 As Button
    Friend WithEvents cmb担当理事 As ComboBox
    Friend WithEvents dgvプロジェクト As DataGridView
    Friend WithEvents btn開始日 As Button
    Friend WithEvents btn終了日 As Button
    Friend WithEvents chc月 As CheckBox
    Friend WithEvents chc水 As CheckBox
    Friend WithEvents chc木 As CheckBox
    Friend WithEvents chc火 As CheckBox
    Friend WithEvents chc金 As CheckBox
    Friend WithEvents chc土 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt備考 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents chc日 As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbPID_P参加会員 As ComboBox
    Friend WithEvents txt備考_P参加会員 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents chk削除_P参加会員 As CheckBox
    Friend WithEvents btn登録_P参加会員 As Button
    Friend WithEvents dgv参加会員 As DataGridView
    Friend WithEvents btn新規 As Button
    Friend WithEvents cmb会員ID_P参加会員 As ComboBox
    Friend WithEvents colID_P参加会員 As DataGridViewTextBoxColumn
    Friend WithEvents colプロジェクト名_P参加会員 As DataGridViewTextBoxColumn
    Friend WithEvents col氏名 As DataGridViewTextBoxColumn
    Friend WithEvents colプロジェクトID_P参加会員 As DataGridViewTextBoxColumn
    Friend WithEvents col会員ID_P参加会員 As DataGridViewTextBoxColumn
    Friend WithEvents col備考_P参加会員 As DataGridViewTextBoxColumn
    Friend WithEvents col削除_P参加会員 As DataGridViewTextBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colプロジェクトID As DataGridViewTextBoxColumn
    Friend WithEvents colプロジェクト名 As DataGridViewTextBoxColumn
    Friend WithEvents col内容 As DataGridViewTextBoxColumn
    Friend WithEvents col担当理事 As DataGridViewTextBoxColumn
    Friend WithEvents col開催日 As DataGridViewTextBoxColumn
    Friend WithEvents col開始日 As DataGridViewTextBoxColumn
    Friend WithEvents col終了日 As DataGridViewTextBoxColumn
    Friend WithEvents col備考 As DataGridViewTextBoxColumn
End Class
