<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm週間表示
    ' Inherits System.Windows.Forms.Form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl日付 = New System.Windows.Forms.Label()
        Me.dgv週間表示 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn進む = New System.Windows.Forms.Button()
        Me.btn戻る = New System.Windows.Forms.Button()
        CType(Me.dgv週間表示, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl日付
        '
        Me.lbl日付.Enabled = False
        Me.lbl日付.Font = New System.Drawing.Font("MS UI Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl日付.Location = New System.Drawing.Point(61, 24)
        Me.lbl日付.Name = "lbl日付"
        Me.lbl日付.Size = New System.Drawing.Size(213, 27)
        Me.lbl日付.TabIndex = 1
        Me.lbl日付.Text = "yyyy/mm/dd（曜）"
        '
        'dgv週間表示
        '
        Me.dgv週間表示.AllowUserToAddRows = False
        Me.dgv週間表示.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv週間表示.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Column1})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv週間表示.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgv週間表示.Location = New System.Drawing.Point(14, 84)
        Me.dgv週間表示.Margin = New System.Windows.Forms.Padding(5)
        Me.dgv週間表示.Name = "dgv週間表示"
        Me.dgv週間表示.RowHeadersVisible = False
        Me.dgv週間表示.RowHeadersWidth = 51
        Me.dgv週間表示.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv週間表示.RowTemplate.DividerHeight = 1
        Me.dgv週間表示.RowTemplate.Height = 50
        Me.dgv週間表示.Size = New System.Drawing.Size(1158, 587)
        Me.dgv週間表示.TabIndex = 5
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "氏名"
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "氏名"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'btn進む
        '
        Me.btn進む.Location = New System.Drawing.Point(270, 17)
        Me.btn進む.Name = "btn進む"
        Me.btn進む.Size = New System.Drawing.Size(47, 41)
        Me.btn進む.TabIndex = 102
        Me.btn進む.Text = ">>"
        Me.btn進む.UseVisualStyleBackColor = True
        '
        'btn戻る
        '
        Me.btn戻る.Location = New System.Drawing.Point(8, 20)
        Me.btn戻る.Name = "btn戻る"
        Me.btn戻る.Size = New System.Drawing.Size(47, 41)
        Me.btn戻る.TabIndex = 103
        Me.btn戻る.Text = "<<"
        Me.btn戻る.UseVisualStyleBackColor = True
        '
        'frm週間表示
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.btn戻る)
        Me.Controls.Add(Me.btn進む)
        Me.Controls.Add(Me.dgv週間表示)
        Me.Controls.Add(Me.lbl日付)
        Me.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.Name = "frm週間表示"
        Me.Text = "1週間表示"
        Me.Controls.SetChildIndex(Me.lbl日付, 0)
        Me.Controls.SetChildIndex(Me.dgv週間表示, 0)
        Me.Controls.SetChildIndex(Me.btn進む, 0)
        Me.Controls.SetChildIndex(Me.btn戻る, 0)
        CType(Me.dgv週間表示, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl日付 As Label
    Friend WithEvents dgv週間表示 As DataGridView
    Friend WithEvents btn進む As Button
    Friend WithEvents btn戻る As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
