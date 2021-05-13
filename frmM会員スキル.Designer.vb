<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmM会員スキル
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col氏名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col会員ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colスキル名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colスキルレベル = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col備考 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col削除 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb会員ID = New System.Windows.Forms.ComboBox()
        Me.cmbスキルレベル = New System.Windows.Forms.ComboBox()
        Me.cmbスキル = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt備考 = New System.Windows.Forms.TextBox()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.chk削除 = New System.Windows.Forms.CheckBox()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "会員ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 19)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "スキル名"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 19)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "スキルレベル"
        '
        'dgv一覧
        '
        Me.dgv一覧.AllowUserToAddRows = False
        Me.dgv一覧.AllowUserToDeleteRows = False
        Me.dgv一覧.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.col氏名, Me.col会員ID, Me.colスキル名, Me.colスキルレベル, Me.col備考, Me.col削除})
        Me.dgv一覧.Location = New System.Drawing.Point(16, 175)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.ReadOnly = True
        Me.dgv一覧.RowHeadersVisible = False
        Me.dgv一覧.RowTemplate.Height = 21
        Me.dgv一覧.Size = New System.Drawing.Size(1156, 511)
        Me.dgv一覧.TabIndex = 107
        Me.dgv一覧.TabStop = False
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'col氏名
        '
        Me.col氏名.DataPropertyName = "氏名"
        Me.col氏名.HeaderText = "氏名"
        Me.col氏名.Name = "col氏名"
        Me.col氏名.ReadOnly = True
        Me.col氏名.Width = 200
        '
        'col会員ID
        '
        Me.col会員ID.DataPropertyName = "会員ID"
        Me.col会員ID.HeaderText = "会員ID"
        Me.col会員ID.Name = "col会員ID"
        Me.col会員ID.ReadOnly = True
        Me.col会員ID.Visible = False
        Me.col会員ID.Width = 200
        '
        'colスキル名
        '
        Me.colスキル名.DataPropertyName = "スキル名"
        Me.colスキル名.HeaderText = "スキル名"
        Me.colスキル名.Name = "colスキル名"
        Me.colスキル名.ReadOnly = True
        Me.colスキル名.Width = 200
        '
        'colスキルレベル
        '
        Me.colスキルレベル.DataPropertyName = "スキルレベル"
        Me.colスキルレベル.HeaderText = "スキルレベル"
        Me.colスキルレベル.Name = "colスキルレベル"
        Me.colスキルレベル.ReadOnly = True
        Me.colスキルレベル.Width = 150
        '
        'col備考
        '
        Me.col備考.DataPropertyName = "備考"
        Me.col備考.HeaderText = "備考"
        Me.col備考.Name = "col備考"
        Me.col備考.ReadOnly = True
        Me.col備考.Width = 400
        '
        'col削除
        '
        Me.col削除.DataPropertyName = "削除フラグ"
        Me.col削除.HeaderText = "削除"
        Me.col削除.Name = "col削除"
        Me.col削除.ReadOnly = True
        Me.col削除.Width = 75
        '
        'cmb会員ID
        '
        Me.cmb会員ID.FormattingEnabled = True
        Me.cmb会員ID.Location = New System.Drawing.Point(120, 16)
        Me.cmb会員ID.Name = "cmb会員ID"
        Me.cmb会員ID.Size = New System.Drawing.Size(389, 27)
        Me.cmb会員ID.TabIndex = 108
        '
        'cmbスキルレベル
        '
        Me.cmbスキルレベル.FormattingEnabled = True
        Me.cmbスキルレベル.Location = New System.Drawing.Point(120, 82)
        Me.cmbスキルレベル.Name = "cmbスキルレベル"
        Me.cmbスキルレベル.Size = New System.Drawing.Size(389, 27)
        Me.cmbスキルレベル.TabIndex = 110
        '
        'cmbスキル
        '
        Me.cmbスキル.FormattingEnabled = True
        Me.cmbスキル.Location = New System.Drawing.Point(120, 49)
        Me.cmbスキル.Name = "cmbスキル"
        Me.cmbスキル.Size = New System.Drawing.Size(389, 27)
        Me.cmbスキル.TabIndex = 112
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "備考"
        '
        'txt備考
        '
        Me.txt備考.Location = New System.Drawing.Point(120, 115)
        Me.txt備考.Multiline = True
        Me.txt備考.Name = "txt備考"
        Me.txt備考.Size = New System.Drawing.Size(700, 54)
        Me.txt備考.TabIndex = 114
        '
        'btn登録
        '
        Me.btn登録.Location = New System.Drawing.Point(1049, 124)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(123, 45)
        Me.btn登録.TabIndex = 115
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'chk削除
        '
        Me.chk削除.AutoSize = True
        Me.chk削除.Location = New System.Drawing.Point(826, 146)
        Me.chk削除.Name = "chk削除"
        Me.chk削除.Size = New System.Drawing.Size(66, 23)
        Me.chk削除.TabIndex = 116
        Me.chk削除.Text = "削除"
        Me.chk削除.UseVisualStyleBackColor = True
        '
        'frmM会員スキル
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.chk削除)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.txt備考)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbスキル)
        Me.Controls.Add(Me.cmbスキルレベル)
        Me.Controls.Add(Me.cmb会員ID)
        Me.Controls.Add(Me.dgv一覧)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmM会員スキル"
        Me.Text = "会員スキルマスタ"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.dgv一覧, 0)
        Me.Controls.SetChildIndex(Me.cmb会員ID, 0)
        Me.Controls.SetChildIndex(Me.cmbスキルレベル, 0)
        Me.Controls.SetChildIndex(Me.cmbスキル, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txt備考, 0)
        Me.Controls.SetChildIndex(Me.btn登録, 0)
        Me.Controls.SetChildIndex(Me.chk削除, 0)
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents cmb会員ID As ComboBox
    Friend WithEvents cmbスキルレベル As ComboBox
    Friend WithEvents cmbスキル As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt備考 As TextBox
    Friend WithEvents btn登録 As Button
    Friend WithEvents chk削除 As CheckBox
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents col氏名 As DataGridViewTextBoxColumn
    Friend WithEvents col会員ID As DataGridViewTextBoxColumn
    Friend WithEvents colスキル名 As DataGridViewTextBoxColumn
    Friend WithEvents colスキルレベル As DataGridViewTextBoxColumn
    Friend WithEvents col備考 As DataGridViewTextBoxColumn
    Friend WithEvents col削除 As DataGridViewTextBoxColumn
End Class
