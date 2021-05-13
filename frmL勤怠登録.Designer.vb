<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmL勤怠登録
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
        Me.components = New System.ComponentModel.Container()
        Me.picImg = New System.Windows.Forms.PictureBox()
        Me.lbl施設 = New System.Windows.Forms.Label()
        Me.dgv一覧 = New System.Windows.Forms.DataGridView()
        Me.lbl日付 = New System.Windows.Forms.Label()
        Me.lbl時間 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.lblバージョン = New System.Windows.Forms.Label()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn13 = New System.Windows.Forms.Button()
        Me.btn17 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn11 = New System.Windows.Forms.Button()
        Me.btn12 = New System.Windows.Forms.Button()
        Me.btn14 = New System.Windows.Forms.Button()
        Me.btn15 = New System.Windows.Forms.Button()
        Me.btn16 = New System.Windows.Forms.Button()
        Me.btn18 = New System.Windows.Forms.Button()
        Me.btn19 = New System.Windows.Forms.Button()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.tim時間 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picImg
        '
        Me.picImg.Image = Global.カシオペイア.My.Resources.Resources.カシオペイア
        Me.picImg.InitialImage = Nothing
        Me.picImg.Location = New System.Drawing.Point(42, 33)
        Me.picImg.Name = "picImg"
        Me.picImg.Size = New System.Drawing.Size(150, 150)
        Me.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImg.TabIndex = 102
        Me.picImg.TabStop = False
        '
        'lbl施設
        '
        Me.lbl施設.AutoSize = True
        Me.lbl施設.Font = New System.Drawing.Font("MS UI Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl施設.Location = New System.Drawing.Point(236, 33)
        Me.lbl施設.Name = "lbl施設"
        Me.lbl施設.Size = New System.Drawing.Size(99, 40)
        Me.lbl施設.TabIndex = 103
        Me.lbl施設.Text = "施設"
        '
        'dgv一覧
        '
        Me.dgv一覧.BackgroundColor = System.Drawing.Color.White
        Me.dgv一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv一覧.Location = New System.Drawing.Point(243, 76)
        Me.dgv一覧.Name = "dgv一覧"
        Me.dgv一覧.RowTemplate.Height = 21
        Me.dgv一覧.Size = New System.Drawing.Size(918, 107)
        Me.dgv一覧.TabIndex = 104
        '
        'lbl日付
        '
        Me.lbl日付.AutoSize = True
        Me.lbl日付.Font = New System.Drawing.Font("MS UI Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl日付.Location = New System.Drawing.Point(683, 33)
        Me.lbl日付.Name = "lbl日付"
        Me.lbl日付.Size = New System.Drawing.Size(241, 40)
        Me.lbl日付.TabIndex = 105
        Me.lbl日付.Text = "yyyy/mm/dd"
        '
        'lbl時間
        '
        Me.lbl時間.AutoSize = True
        Me.lbl時間.Font = New System.Drawing.Font("MS UI Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl時間.Location = New System.Drawing.Point(1021, 33)
        Me.lbl時間.Name = "lbl時間"
        Me.lbl時間.Size = New System.Drawing.Size(140, 40)
        Me.lbl時間.TabIndex = 106
        Me.lbl時間.Text = "HH:mm"
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.Red
        Me.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1.Location = New System.Drawing.Point(12, 208)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(225, 50)
        Me.btn1.TabIndex = 107
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lblバージョン
        '
        Me.lblバージョン.AutoSize = True
        Me.lblバージョン.Location = New System.Drawing.Point(67, 186)
        Me.lblバージョン.Name = "lblバージョン"
        Me.lblバージョン.Size = New System.Drawing.Size(93, 19)
        Me.lblバージョン.TabIndex = 108
        Me.lblバージョン.Text = "ver 0.0.0.0"
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.Red
        Me.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn2.Location = New System.Drawing.Point(12, 264)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(225, 50)
        Me.btn2.TabIndex = 109
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.Red
        Me.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn3.Location = New System.Drawing.Point(12, 320)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(225, 50)
        Me.btn3.TabIndex = 110
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.Red
        Me.btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn4.Location = New System.Drawing.Point(12, 376)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(225, 50)
        Me.btn4.TabIndex = 111
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.Red
        Me.btn5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn5.Location = New System.Drawing.Point(243, 208)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(225, 50)
        Me.btn5.TabIndex = 112
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn6.ForeColor = System.Drawing.Color.Red
        Me.btn6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn6.Location = New System.Drawing.Point(243, 264)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(225, 50)
        Me.btn6.TabIndex = 113
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn7.ForeColor = System.Drawing.Color.Red
        Me.btn7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn7.Location = New System.Drawing.Point(243, 320)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(225, 50)
        Me.btn7.TabIndex = 114
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn10
        '
        Me.btn10.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn10.ForeColor = System.Drawing.Color.Red
        Me.btn10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn10.Location = New System.Drawing.Point(474, 264)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(225, 50)
        Me.btn10.TabIndex = 115
        Me.btn10.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn8.ForeColor = System.Drawing.Color.Red
        Me.btn8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn8.Location = New System.Drawing.Point(243, 376)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(225, 50)
        Me.btn8.TabIndex = 116
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn13
        '
        Me.btn13.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn13.ForeColor = System.Drawing.Color.Red
        Me.btn13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn13.Location = New System.Drawing.Point(705, 208)
        Me.btn13.Name = "btn13"
        Me.btn13.Size = New System.Drawing.Size(225, 50)
        Me.btn13.TabIndex = 117
        Me.btn13.UseVisualStyleBackColor = True
        '
        'btn17
        '
        Me.btn17.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn17.ForeColor = System.Drawing.Color.Red
        Me.btn17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn17.Location = New System.Drawing.Point(936, 208)
        Me.btn17.Name = "btn17"
        Me.btn17.Size = New System.Drawing.Size(225, 50)
        Me.btn17.TabIndex = 118
        Me.btn17.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn9.ForeColor = System.Drawing.Color.Red
        Me.btn9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn9.Location = New System.Drawing.Point(474, 208)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(225, 50)
        Me.btn9.TabIndex = 119
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn11
        '
        Me.btn11.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn11.ForeColor = System.Drawing.Color.Red
        Me.btn11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn11.Location = New System.Drawing.Point(474, 320)
        Me.btn11.Name = "btn11"
        Me.btn11.Size = New System.Drawing.Size(225, 50)
        Me.btn11.TabIndex = 120
        Me.btn11.UseVisualStyleBackColor = True
        '
        'btn12
        '
        Me.btn12.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn12.ForeColor = System.Drawing.Color.Red
        Me.btn12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn12.Location = New System.Drawing.Point(474, 376)
        Me.btn12.Name = "btn12"
        Me.btn12.Size = New System.Drawing.Size(225, 50)
        Me.btn12.TabIndex = 121
        Me.btn12.UseVisualStyleBackColor = True
        '
        'btn14
        '
        Me.btn14.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn14.ForeColor = System.Drawing.Color.Red
        Me.btn14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn14.Location = New System.Drawing.Point(705, 264)
        Me.btn14.Name = "btn14"
        Me.btn14.Size = New System.Drawing.Size(225, 50)
        Me.btn14.TabIndex = 122
        Me.btn14.UseVisualStyleBackColor = True
        '
        'btn15
        '
        Me.btn15.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn15.ForeColor = System.Drawing.Color.Red
        Me.btn15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn15.Location = New System.Drawing.Point(705, 320)
        Me.btn15.Name = "btn15"
        Me.btn15.Size = New System.Drawing.Size(225, 50)
        Me.btn15.TabIndex = 123
        Me.btn15.UseVisualStyleBackColor = True
        '
        'btn16
        '
        Me.btn16.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn16.ForeColor = System.Drawing.Color.Red
        Me.btn16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn16.Location = New System.Drawing.Point(705, 376)
        Me.btn16.Name = "btn16"
        Me.btn16.Size = New System.Drawing.Size(225, 50)
        Me.btn16.TabIndex = 124
        Me.btn16.UseVisualStyleBackColor = True
        '
        'btn18
        '
        Me.btn18.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn18.ForeColor = System.Drawing.Color.Red
        Me.btn18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn18.Location = New System.Drawing.Point(936, 264)
        Me.btn18.Name = "btn18"
        Me.btn18.Size = New System.Drawing.Size(225, 50)
        Me.btn18.TabIndex = 125
        Me.btn18.UseVisualStyleBackColor = True
        '
        'btn19
        '
        Me.btn19.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn19.ForeColor = System.Drawing.Color.Red
        Me.btn19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn19.Location = New System.Drawing.Point(936, 320)
        Me.btn19.Name = "btn19"
        Me.btn19.Size = New System.Drawing.Size(225, 50)
        Me.btn19.TabIndex = 126
        Me.btn19.UseVisualStyleBackColor = True
        '
        'btn20
        '
        Me.btn20.Font = New System.Drawing.Font("ＭＳ 明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn20.ForeColor = System.Drawing.Color.Red
        Me.btn20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn20.Location = New System.Drawing.Point(936, 376)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(225, 50)
        Me.btn20.TabIndex = 127
        Me.btn20.UseVisualStyleBackColor = True
        '
        'tim時間
        '
        Me.tim時間.Interval = 30
        '
        'frmL勤怠登録
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 741)
        Me.Controls.Add(Me.btn20)
        Me.Controls.Add(Me.btn19)
        Me.Controls.Add(Me.btn18)
        Me.Controls.Add(Me.btn16)
        Me.Controls.Add(Me.btn15)
        Me.Controls.Add(Me.btn14)
        Me.Controls.Add(Me.btn12)
        Me.Controls.Add(Me.btn11)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn17)
        Me.Controls.Add(Me.btn13)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn10)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.lblバージョン)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lbl時間)
        Me.Controls.Add(Me.lbl日付)
        Me.Controls.Add(Me.dgv一覧)
        Me.Controls.Add(Me.lbl施設)
        Me.Controls.Add(Me.picImg)
        Me.Name = "frmL勤怠登録"
        Me.Text = "frmL勤怠登録"
        Me.Controls.SetChildIndex(Me.picImg, 0)
        Me.Controls.SetChildIndex(Me.lbl施設, 0)
        Me.Controls.SetChildIndex(Me.dgv一覧, 0)
        Me.Controls.SetChildIndex(Me.lbl日付, 0)
        Me.Controls.SetChildIndex(Me.lbl時間, 0)
        Me.Controls.SetChildIndex(Me.btn1, 0)
        Me.Controls.SetChildIndex(Me.lblバージョン, 0)
        Me.Controls.SetChildIndex(Me.btn2, 0)
        Me.Controls.SetChildIndex(Me.btn3, 0)
        Me.Controls.SetChildIndex(Me.btn4, 0)
        Me.Controls.SetChildIndex(Me.btn5, 0)
        Me.Controls.SetChildIndex(Me.btn6, 0)
        Me.Controls.SetChildIndex(Me.btn7, 0)
        Me.Controls.SetChildIndex(Me.btn10, 0)
        Me.Controls.SetChildIndex(Me.btn8, 0)
        Me.Controls.SetChildIndex(Me.btn13, 0)
        Me.Controls.SetChildIndex(Me.btn17, 0)
        Me.Controls.SetChildIndex(Me.btn9, 0)
        Me.Controls.SetChildIndex(Me.btn11, 0)
        Me.Controls.SetChildIndex(Me.btn12, 0)
        Me.Controls.SetChildIndex(Me.btn14, 0)
        Me.Controls.SetChildIndex(Me.btn15, 0)
        Me.Controls.SetChildIndex(Me.btn16, 0)
        Me.Controls.SetChildIndex(Me.btn18, 0)
        Me.Controls.SetChildIndex(Me.btn19, 0)
        Me.Controls.SetChildIndex(Me.btn20, 0)
        CType(Me.picImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picImg As PictureBox
    Friend WithEvents lbl施設 As Label
    Friend WithEvents dgv一覧 As DataGridView
    Friend WithEvents lbl日付 As Label
    Friend WithEvents lbl時間 As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents lblバージョン As Label
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn10 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn13 As Button
    Friend WithEvents btn17 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn11 As Button
    Friend WithEvents btn12 As Button
    Friend WithEvents btn14 As Button
    Friend WithEvents btn15 As Button
    Friend WithEvents btn16 As Button
    Friend WithEvents btn18 As Button
    Friend WithEvents btn19 As Button
    Friend WithEvents btn20 As Button
    Friend WithEvents tim時間 As Timer
End Class
