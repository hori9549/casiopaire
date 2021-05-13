<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmM区分管理
    'Inherits System.Windows.Forms.Form
    Inherits frmベース

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt区分 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt区分名 = New System.Windows.Forms.TextBox()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.dgv区分 = New System.Windows.Forms.DataGridView()
        Me.colID_区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col区分_区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col区分名_区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考_区分 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Tab区分 = New System.Windows.Forms.TabPage()
        Me.btn新規 = New System.Windows.Forms.Button()
        Me.txt備考 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tab区分明細 = New System.Windows.Forms.TabPage()
        Me.btn新規_明細 = New System.Windows.Forms.Button()
        Me.btn登録_明細 = New System.Windows.Forms.Button()
        Me.dgv区分明細 = New System.Windows.Forms.DataGridView()
        Me.colID_区分明細 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col区分_区分明細 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colコード_区分明細 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col内容_区分明細 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考_区分明細 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col削除_区分明細 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk削除_区分明細 = New System.Windows.Forms.CheckBox()
        Me.txt備考_区分明細 = New System.Windows.Forms.TextBox()
        Me.txt内容_区分明細 = New System.Windows.Forms.TextBox()
        Me.txtコード_区分明細 = New System.Windows.Forms.TextBox()
        Me.cmb区分_区分明細 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgv区分, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Tab区分.SuspendLayout()
        Me.Tab区分明細.SuspendLayout()
        CType(Me.dgv区分明細, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "区分"
        '
        'txt区分
        '
        Me.txt区分.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt区分.Location = New System.Drawing.Point(104, 20)
        Me.txt区分.Margin = New System.Windows.Forms.Padding(5)
        Me.txt区分.Name = "txt区分"
        Me.txt区分.Size = New System.Drawing.Size(60, 26)
        Me.txt区分.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "区分名"
        '
        'txt区分名
        '
        Me.txt区分名.Location = New System.Drawing.Point(104, 56)
        Me.txt区分名.Margin = New System.Windows.Forms.Padding(5)
        Me.txt区分名.Name = "txt区分名"
        Me.txt区分名.Size = New System.Drawing.Size(384, 26)
        Me.txt区分名.TabIndex = 3
        '
        'btn登録
        '
        Me.btn登録.Location = New System.Drawing.Point(1006, 73)
        Me.btn登録.Margin = New System.Windows.Forms.Padding(5)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(125, 45)
        Me.btn登録.TabIndex = 4
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'dgv区分
        '
        Me.dgv区分.AllowUserToAddRows = False
        Me.dgv区分.AllowUserToDeleteRows = False
        Me.dgv区分.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv区分.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv区分.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID_区分, Me.col区分_区分, Me.col区分名_区分, Me.col備考_区分})
        Me.dgv区分.Location = New System.Drawing.Point(51, 128)
        Me.dgv区分.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv区分.Name = "dgv区分"
        Me.dgv区分.ReadOnly = True
        Me.dgv区分.RowHeadersVisible = False
        Me.dgv区分.RowTemplate.Height = 21
        Me.dgv区分.Size = New System.Drawing.Size(1080, 483)
        Me.dgv区分.TabIndex = 5
        Me.dgv区分.TabStop = False
        '
        'colID_区分
        '
        Me.colID_区分.DataPropertyName = "ID"
        Me.colID_区分.HeaderText = "ID"
        Me.colID_区分.Name = "colID_区分"
        Me.colID_区分.ReadOnly = True
        Me.colID_区分.Visible = False
        '
        'col区分_区分
        '
        Me.col区分_区分.DataPropertyName = "区分"
        Me.col区分_区分.HeaderText = "区分"
        Me.col区分_区分.Name = "col区分_区分"
        Me.col区分_区分.ReadOnly = True
        Me.col区分_区分.Width = 70
        '
        'col区分名_区分
        '
        Me.col区分名_区分.DataPropertyName = "区分名"
        Me.col区分名_区分.HeaderText = "区分名"
        Me.col区分名_区分.Name = "col区分名_区分"
        Me.col区分名_区分.ReadOnly = True
        Me.col区分名_区分.Width = 300
        '
        'col備考_区分
        '
        Me.col備考_区分.DataPropertyName = "備考"
        Me.col備考_区分.HeaderText = "備考"
        Me.col備考_区分.Name = "col備考_区分"
        Me.col備考_区分.ReadOnly = True
        Me.col備考_区分.Width = 300
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Tab区分)
        Me.TabControl1.Controls.Add(Me.Tab区分明細)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1160, 674)
        Me.TabControl1.TabIndex = 6
        '
        'Tab区分
        '
        Me.Tab区分.Controls.Add(Me.btn新規)
        Me.Tab区分.Controls.Add(Me.txt備考)
        Me.Tab区分.Controls.Add(Me.Label3)
        Me.Tab区分.Controls.Add(Me.dgv区分)
        Me.Tab区分.Controls.Add(Me.btn登録)
        Me.Tab区分.Controls.Add(Me.txt区分名)
        Me.Tab区分.Controls.Add(Me.Label2)
        Me.Tab区分.Controls.Add(Me.txt区分)
        Me.Tab区分.Controls.Add(Me.Label1)
        Me.Tab区分.Location = New System.Drawing.Point(4, 29)
        Me.Tab区分.Margin = New System.Windows.Forms.Padding(5)
        Me.Tab区分.Name = "Tab区分"
        Me.Tab区分.Padding = New System.Windows.Forms.Padding(5)
        Me.Tab区分.Size = New System.Drawing.Size(1152, 641)
        Me.Tab区分.TabIndex = 0
        Me.Tab区分.Text = "区分"
        Me.Tab区分.UseVisualStyleBackColor = True
        '
        'btn新規
        '
        Me.btn新規.Location = New System.Drawing.Point(165, 20)
        Me.btn新規.Margin = New System.Windows.Forms.Padding(5)
        Me.btn新規.Name = "btn新規"
        Me.btn新規.Size = New System.Drawing.Size(26, 26)
        Me.btn新規.TabIndex = 8
        Me.btn新規.Text = "＋"
        Me.btn新規.UseVisualStyleBackColor = True
        '
        'txt備考
        '
        Me.txt備考.Location = New System.Drawing.Point(104, 92)
        Me.txt備考.Margin = New System.Windows.Forms.Padding(5)
        Me.txt備考.Name = "txt備考"
        Me.txt備考.Size = New System.Drawing.Size(384, 26)
        Me.txt備考.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "備考"
        '
        'Tab区分明細
        '
        Me.Tab区分明細.Controls.Add(Me.btn新規_明細)
        Me.Tab区分明細.Controls.Add(Me.btn登録_明細)
        Me.Tab区分明細.Controls.Add(Me.dgv区分明細)
        Me.Tab区分明細.Controls.Add(Me.chk削除_区分明細)
        Me.Tab区分明細.Controls.Add(Me.txt備考_区分明細)
        Me.Tab区分明細.Controls.Add(Me.txt内容_区分明細)
        Me.Tab区分明細.Controls.Add(Me.txtコード_区分明細)
        Me.Tab区分明細.Controls.Add(Me.cmb区分_区分明細)
        Me.Tab区分明細.Controls.Add(Me.Label7)
        Me.Tab区分明細.Controls.Add(Me.Label6)
        Me.Tab区分明細.Controls.Add(Me.Label5)
        Me.Tab区分明細.Controls.Add(Me.Label4)
        Me.Tab区分明細.Location = New System.Drawing.Point(4, 29)
        Me.Tab区分明細.Margin = New System.Windows.Forms.Padding(5)
        Me.Tab区分明細.Name = "Tab区分明細"
        Me.Tab区分明細.Padding = New System.Windows.Forms.Padding(5)
        Me.Tab区分明細.Size = New System.Drawing.Size(1152, 641)
        Me.Tab区分明細.TabIndex = 1
        Me.Tab区分明細.Text = "区分明細"
        Me.Tab区分明細.UseVisualStyleBackColor = True
        '
        'btn新規_明細
        '
        Me.btn新規_明細.Location = New System.Drawing.Point(484, 19)
        Me.btn新規_明細.Name = "btn新規_明細"
        Me.btn新規_明細.Size = New System.Drawing.Size(30, 30)
        Me.btn新規_明細.TabIndex = 12
        Me.btn新規_明細.Text = "+"
        Me.btn新規_明細.UseVisualStyleBackColor = True
        '
        'btn登録_明細
        '
        Me.btn登録_明細.Location = New System.Drawing.Point(1006, 74)
        Me.btn登録_明細.Name = "btn登録_明細"
        Me.btn登録_明細.Size = New System.Drawing.Size(125, 45)
        Me.btn登録_明細.TabIndex = 11
        Me.btn登録_明細.Text = "登録"
        Me.btn登録_明細.UseVisualStyleBackColor = True
        '
        'dgv区分明細
        '
        Me.dgv区分明細.AllowUserToAddRows = False
        Me.dgv区分明細.AllowUserToDeleteRows = False
        Me.dgv区分明細.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv区分明細.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID_区分明細, Me.col区分_区分明細, Me.colコード_区分明細, Me.col内容_区分明細, Me.col備考_区分明細, Me.col削除_区分明細})
        Me.dgv区分明細.Location = New System.Drawing.Point(51, 129)
        Me.dgv区分明細.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv区分明細.Name = "dgv区分明細"
        Me.dgv区分明細.ReadOnly = True
        Me.dgv区分明細.RowHeadersVisible = False
        Me.dgv区分明細.RowTemplate.Height = 21
        Me.dgv区分明細.Size = New System.Drawing.Size(1080, 483)
        Me.dgv区分明細.TabIndex = 10
        Me.dgv区分明細.TabStop = False
        '
        'colID_区分明細
        '
        Me.colID_区分明細.DataPropertyName = "ID"
        Me.colID_区分明細.HeaderText = "ID"
        Me.colID_区分明細.Name = "colID_区分明細"
        Me.colID_区分明細.ReadOnly = True
        Me.colID_区分明細.Visible = False
        '
        'col区分_区分明細
        '
        Me.col区分_区分明細.DataPropertyName = "区分"
        Me.col区分_区分明細.HeaderText = "区分"
        Me.col区分_区分明細.Name = "col区分_区分明細"
        Me.col区分_区分明細.ReadOnly = True
        Me.col区分_区分明細.Width = 70
        '
        'colコード_区分明細
        '
        Me.colコード_区分明細.DataPropertyName = "コード"
        Me.colコード_区分明細.HeaderText = "コード"
        Me.colコード_区分明細.Name = "colコード_区分明細"
        Me.colコード_区分明細.ReadOnly = True
        '
        'col内容_区分明細
        '
        Me.col内容_区分明細.DataPropertyName = "内容"
        Me.col内容_区分明細.HeaderText = "内容"
        Me.col内容_区分明細.Name = "col内容_区分明細"
        Me.col内容_区分明細.ReadOnly = True
        Me.col内容_区分明細.Width = 400
        '
        'col備考_区分明細
        '
        Me.col備考_区分明細.DataPropertyName = "備考"
        Me.col備考_区分明細.HeaderText = "備考"
        Me.col備考_区分明細.Name = "col備考_区分明細"
        Me.col備考_区分明細.ReadOnly = True
        Me.col備考_区分明細.Width = 400
        '
        'col削除_区分明細
        '
        Me.col削除_区分明細.DataPropertyName = "削除フラグ"
        Me.col削除_区分明細.HeaderText = "削除"
        Me.col削除_区分明細.Name = "col削除_区分明細"
        Me.col削除_区分明細.ReadOnly = True
        Me.col削除_区分明細.Width = 75
        '
        'chk削除_区分明細
        '
        Me.chk削除_区分明細.AutoSize = True
        Me.chk削除_区分明細.Location = New System.Drawing.Point(814, 95)
        Me.chk削除_区分明細.Margin = New System.Windows.Forms.Padding(5)
        Me.chk削除_区分明細.Name = "chk削除_区分明細"
        Me.chk削除_区分明細.Size = New System.Drawing.Size(66, 23)
        Me.chk削除_区分明細.TabIndex = 8
        Me.chk削除_区分明細.Text = "削除"
        Me.chk削除_区分明細.UseVisualStyleBackColor = True
        '
        'txt備考_区分明細
        '
        Me.txt備考_区分明細.Location = New System.Drawing.Point(104, 93)
        Me.txt備考_区分明細.Margin = New System.Windows.Forms.Padding(5)
        Me.txt備考_区分明細.Name = "txt備考_区分明細"
        Me.txt備考_区分明細.Size = New System.Drawing.Size(700, 26)
        Me.txt備考_区分明細.TabIndex = 7
        '
        'txt内容_区分明細
        '
        Me.txt内容_区分明細.Location = New System.Drawing.Point(104, 57)
        Me.txt内容_区分明細.Margin = New System.Windows.Forms.Padding(5)
        Me.txt内容_区分明細.Name = "txt内容_区分明細"
        Me.txt内容_区分明細.Size = New System.Drawing.Size(700, 26)
        Me.txt内容_区分明細.TabIndex = 6
        '
        'txtコード_区分明細
        '
        Me.txtコード_区分明細.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtコード_区分明細.Location = New System.Drawing.Point(424, 21)
        Me.txtコード_区分明細.Margin = New System.Windows.Forms.Padding(5)
        Me.txtコード_区分明細.Name = "txtコード_区分明細"
        Me.txtコード_区分明細.Size = New System.Drawing.Size(60, 26)
        Me.txtコード_区分明細.TabIndex = 5
        '
        'cmb区分_区分明細
        '
        Me.cmb区分_区分明細.FormattingEnabled = True
        Me.cmb区分_区分明細.Location = New System.Drawing.Point(104, 20)
        Me.cmb区分_区分明細.Margin = New System.Windows.Forms.Padding(5)
        Me.cmb区分_区分明細.Name = "cmb区分_区分明細"
        Me.cmb区分_区分明細.Size = New System.Drawing.Size(199, 27)
        Me.cmb区分_区分明細.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(362, 23)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "コード"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 96)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "備考"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 60)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "内容"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "区分"
        '
        'frmM区分管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "frmM区分管理"
        Me.Text = "区分管理マスタ"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        CType(Me.dgv区分, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Tab区分.ResumeLayout(False)
        Me.Tab区分.PerformLayout()
        Me.Tab区分明細.ResumeLayout(False)
        Me.Tab区分明細.PerformLayout()
        CType(Me.dgv区分明細, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt区分 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt区分名 As TextBox
    Friend WithEvents btn登録 As Button
    Friend WithEvents dgv区分 As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Tab区分 As TabPage
    Friend WithEvents txt備考 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Tab区分明細 As TabPage
    Friend WithEvents btn新規 As Button
    Friend WithEvents dgv区分明細 As DataGridView
    Friend WithEvents chk削除_区分明細 As CheckBox
    Friend WithEvents txt備考_区分明細 As TextBox
    Friend WithEvents txt内容_区分明細 As TextBox
    Friend WithEvents txtコード_区分明細 As TextBox
    Friend WithEvents cmb区分_区分明細 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn登録_明細 As Button
    Friend WithEvents btn新規_明細 As Button
    Friend WithEvents colID_区分明細 As DataGridViewTextBoxColumn
    Friend WithEvents col区分_区分明細 As DataGridViewTextBoxColumn
    Friend WithEvents colコード_区分明細 As DataGridViewTextBoxColumn
    Friend WithEvents col内容_区分明細 As DataGridViewTextBoxColumn
    Friend WithEvents col備考_区分明細 As DataGridViewTextBoxColumn
    Friend WithEvents col削除_区分明細 As DataGridViewTextBoxColumn
    Friend WithEvents colID_区分 As DataGridViewTextBoxColumn
    Friend WithEvents col区分_区分 As DataGridViewTextBoxColumn
    Friend WithEvents col区分名_区分 As DataGridViewTextBoxColumn
    Friend WithEvents col備考_区分 As DataGridViewTextBoxColumn
End Class
