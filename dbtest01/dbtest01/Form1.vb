Imports System.Data.SqlClient

Public Class Form1
  Private DataAdapter As SqlDataAdapter
  Private ConnectedValue As Boolean
  Property Connected As Boolean
    Get
      Return ConnectedValue
    End Get
    Set(value As Boolean)
      ConnectedValue = value
      ButtonConnect.Enabled = Not value
      ButtonDisconnect.Enabled = value
      ButtonSubmit.Enabled = value
      ButtonReload.Enabled = value
    End Set
  End Property

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    DataGridView1.DataSource = BindingSource1
    Connected = False
  End Sub

  Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
    Dim connectString = "Data Source=localhost\sqlexpress;" & "Initial Catalog=Test1;" & "integrated Security=true"
    Dim selectString = "select * from table1"
    Try
      Dim DataAdapter = New SqlDataAdapter(selectString, connectString)
      Dim commandBuilder = New SqlCommandBuilder(DataAdapter)
      Dim dataTable = New DataTable()
      DataAdapter.Fill(dataTable)
      BindingSource1.DataSource = dataTable
    Catch ex As Exception
      MessageBox.Show(ex.Message, "エラー")
    End Try
    Connected = True
  End Sub

  Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
    BindingSource1.DataSource = vbNull
    DataAdapter.Dispose()
    DataGridView1.Update()
    Connected = False
  End Sub

  Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
    DataAdapter.Update(CType(BindingSource1.DataSource, DataTable))
  End Sub

  Private Sub ButtonReload_Click(sender As Object, e As EventArgs) Handles ButtonReload.Click
    ButtonDisconnect_Click(sender, e)
    ButtonConnect_Click(sender, e)
  End Sub
End Class
