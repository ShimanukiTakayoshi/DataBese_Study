<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
    Me.ButtonConnect = New System.Windows.Forms.Button()
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
    Me.ButtonDisconnect = New System.Windows.Forms.Button()
    Me.ButtonReload = New System.Windows.Forms.Button()
    Me.ButtonSubmit = New System.Windows.Forms.Button()
    Me.LabelId = New System.Windows.Forms.Label()
    Me.TextBoxName = New System.Windows.Forms.TextBox()
    Me.TextBoxBirthday = New System.Windows.Forms.TextBox()
    Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
    Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
    Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
    Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
    Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.BindingNavigator1.SuspendLayout()
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
    'LabelId
    '
    Me.LabelId.AutoSize = True
    Me.LabelId.Location = New System.Drawing.Point(19, 237)
    Me.LabelId.Name = "LabelId"
    Me.LabelId.Size = New System.Drawing.Size(38, 12)
    Me.LabelId.TabIndex = 5
    Me.LabelId.Text = "Label1"
    '
    'TextBoxName
    '
    Me.TextBoxName.Location = New System.Drawing.Point(21, 252)
    Me.TextBoxName.Name = "TextBoxName"
    Me.TextBoxName.Size = New System.Drawing.Size(97, 19)
    Me.TextBoxName.TabIndex = 6
    '
    'TextBoxBirthday
    '
    Me.TextBoxBirthday.Location = New System.Drawing.Point(21, 277)
    Me.TextBoxBirthday.Name = "TextBoxBirthday"
    Me.TextBoxBirthday.Size = New System.Drawing.Size(97, 19)
    Me.TextBoxBirthday.TabIndex = 7
    '
    'BindingNavigator1
    '
    Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
    Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
    Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
    Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
    Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
    Me.BindingNavigator1.Location = New System.Drawing.Point(21, 300)
    Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
    Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
    Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
    Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
    Me.BindingNavigator1.Name = "BindingNavigator1"
    Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
    Me.BindingNavigator1.Size = New System.Drawing.Size(249, 25)
    Me.BindingNavigator1.TabIndex = 8
    Me.BindingNavigator1.Text = "BindingNavigator1"
    '
    'BindingNavigatorMoveFirstItem
    '
    Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
    Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
    Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
    Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
    Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
    '
    'BindingNavigatorMovePreviousItem
    '
    Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
    Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
    Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
    Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
    Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
    '
    'BindingNavigatorSeparator
    '
    Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
    Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
    '
    'BindingNavigatorPositionItem
    '
    Me.BindingNavigatorPositionItem.AccessibleName = "位置"
    Me.BindingNavigatorPositionItem.AutoSize = False
    Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
    Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
    Me.BindingNavigatorPositionItem.Text = "0"
    Me.BindingNavigatorPositionItem.ToolTipText = "現在の場所"
    '
    'BindingNavigatorCountItem
    '
    Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
    Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(29, 22)
    Me.BindingNavigatorCountItem.Text = "/ {0}"
    Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
    '
    'BindingNavigatorSeparator1
    '
    Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
    Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'BindingNavigatorMoveNextItem
    '
    Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
    Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
    Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
    Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
    Me.BindingNavigatorMoveNextItem.Text = "次に移動"
    '
    'BindingNavigatorMoveLastItem
    '
    Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
    Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
    Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
    Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
    Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
    '
    'BindingNavigatorSeparator2
    '
    Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
    Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'BindingNavigatorAddNewItem
    '
    Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
    Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
    Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
    Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
    Me.BindingNavigatorAddNewItem.Text = "新規追加"
    '
    'BindingNavigatorDeleteItem
    '
    Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
    Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
    Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
    Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
    Me.BindingNavigatorDeleteItem.Text = "削除"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(504, 334)
    Me.Controls.Add(Me.BindingNavigator1)
    Me.Controls.Add(Me.TextBoxBirthday)
    Me.Controls.Add(Me.TextBoxName)
    Me.Controls.Add(Me.LabelId)
    Me.Controls.Add(Me.ButtonDisconnect)
    Me.Controls.Add(Me.ButtonReload)
    Me.Controls.Add(Me.ButtonSubmit)
    Me.Controls.Add(Me.DataGridView1)
    Me.Controls.Add(Me.ButtonConnect)
    Me.Name = "Form1"
    Me.Text = "Form1"
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.BindingNavigator1.ResumeLayout(False)
    Me.BindingNavigator1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents ButtonConnect As Button
  Friend WithEvents DataGridView1 As DataGridView
  Friend WithEvents BindingSource1 As BindingSource
  Friend WithEvents ButtonDisconnect As Button
  Friend WithEvents ButtonReload As Button
  Friend WithEvents ButtonSubmit As Button
  Friend WithEvents LabelId As Label
  Friend WithEvents TextBoxName As TextBox
  Friend WithEvents TextBoxBirthday As TextBox
  Friend WithEvents BindingNavigator1 As BindingNavigator
  Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
  Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
  Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
  Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
  Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
  Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
  Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
  Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
  Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
  Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
  Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
End Class
