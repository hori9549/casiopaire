<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sfrmログイン
    'Inherits System.Windows.Forms.Form
    Inherits sfrmベース

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
        Me.lblメッセージ = New System.Windows.Forms.Label()
        Me.txtパスワード = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.btnログイン = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblメッセージ
        '
        Me.lblメッセージ.AutoSize = True
        Me.lblメッセージ.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblメッセージ.ForeColor = System.Drawing.Color.Red
        Me.lblメッセージ.Location = New System.Drawing.Point(83, 105)
        Me.lblメッセージ.Name = "lblメッセージ"
        Me.lblメッセージ.Size = New System.Drawing.Size(57, 19)
        Me.lblメッセージ.TabIndex = 111
        Me.lblメッセージ.Text = "XXXX"
        '
        'txtパスワード
        '
        Me.txtパスワード.Location = New System.Drawing.Point(173, 67)
        Me.txtパスワード.Name = "txtパスワード"
        Me.txtパスワード.Size = New System.Drawing.Size(233, 26)
        Me.txtパスワード.TabIndex = 110
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "パスワード"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(278, 142)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(128, 44)
        Me.Cancel_Button.TabIndex = 113
        Me.Cancel_Button.Text = "終了"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'btnログイン
        '
        Me.btnログイン.Location = New System.Drawing.Point(87, 142)
        Me.btnログイン.Name = "btnログイン"
        Me.btnログイン.Size = New System.Drawing.Size(128, 44)
        Me.btnログイン.TabIndex = 112
        Me.btnログイン.Text = "ログイン"
        Me.btnログイン.UseVisualStyleBackColor = True
        '
        'sfrmログイン
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 216)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.btnログイン)
        Me.Controls.Add(Me.lblメッセージ)
        Me.Controls.Add(Me.txtパスワード)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sfrmログイン"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ログイン"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblメッセージ As Label
    Friend WithEvents txtパスワード As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents btnログイン As Button
End Class
