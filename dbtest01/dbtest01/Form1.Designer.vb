﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
  Inherits System.Windows.Forms.Form

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
    Me.ButtonConnect = New System.Windows.Forms.Button()
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
    Me.ButtonDisconnect = New System.Windows.Forms.Button()
    Me.ButtonReload = New System.Windows.Forms.Button()
    Me.ButtonSubmit = New System.Windows.Forms.Button()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'ButtonConnect
    '
    Me.ButtonConnect.Location = New System.Drawing.Point(8, 13)
    Me.ButtonConnect.Name = "ButtonConnect"
    Me.ButtonConnect.Size = New System.Drawing.Size(76, 29)
    Me.ButtonConnect.TabIndex = 0
    Me.ButtonConnect.Text = "接続"
    Me.ButtonConnect.UseVisualStyleBackColor = True
    '
    'DataGridView1
    '
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.Location = New System.Drawing.Point(8, 48)
    Me.DataGridView1.Name = "DataGridView1"
    Me.DataGridView1.RowTemplate.Height = 21
    Me.DataGridView1.Size = New System.Drawing.Size(343, 150)
    Me.DataGridView1.TabIndex = 1
    '
    'ButtonDisconnect
    '
    Me.ButtonDisconnect.Location = New System.Drawing.Point(97, 12)
    Me.ButtonDisconnect.Name = "ButtonDisconnect"
    Me.ButtonDisconnect.Size = New System.Drawing.Size(76, 29)
    Me.ButtonDisconnect.TabIndex = 2
    Me.ButtonDisconnect.Text = "切断"
    Me.ButtonDisconnect.UseVisualStyleBackColor = True
    '
    'ButtonReload
    '
    Me.ButtonReload.Location = New System.Drawing.Point(275, 12)
    Me.ButtonReload.Name = "ButtonReload"
    Me.ButtonReload.Size = New System.Drawing.Size(76, 29)
    Me.ButtonReload.TabIndex = 4
    Me.ButtonReload.Text = "再読み込み"
    Me.ButtonReload.UseVisualStyleBackColor = True
    '
    'ButtonSubmit
    '
    Me.ButtonSubmit.Location = New System.Drawing.Point(186, 13)
    Me.ButtonSubmit.Name = "ButtonSubmit"
    Me.ButtonSubmit.Size = New System.Drawing.Size(76, 29)
    Me.ButtonSubmit.TabIndex = 3
    Me.ButtonSubmit.Text = "提出"
    Me.ButtonSubmit.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(504, 261)
    Me.Controls.Add(Me.ButtonDisconnect)
    Me.Controls.Add(Me.ButtonReload)
    Me.Controls.Add(Me.ButtonSubmit)
    Me.Controls.Add(Me.DataGridView1)
    Me.Controls.Add(Me.ButtonConnect)
    Me.Name = "Form1"
    Me.Text = "Form1"
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents ButtonConnect As Button
  Friend WithEvents DataGridView1 As DataGridView
  Friend WithEvents BindingSource1 As BindingSource
  Friend WithEvents ButtonDisconnect As Button
  Friend WithEvents ButtonReload As Button
  Friend WithEvents ButtonSubmit As Button
End Class
