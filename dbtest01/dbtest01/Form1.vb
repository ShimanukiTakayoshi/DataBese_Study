Imports System.Data.SqlClient

Public Class Form1

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    DataGridView1.DataSource = BindingSource1
  End Sub

  Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
    Dim connectString = "Data Source=localhost\sqlexpress;" & "Initial Catalog=Test1;" & "integrated Security=true"
    Dim selectString = "select * from table1"
    Try
      Dim dataAdapter = New SqlDataAdapter(selectString, connectString)
      Dim dataTable = New DataTable
      dataAdapter.Fill(dataTable)
      BindingSource1.DataSource = dataTable
    Catch ex As Exception
      MessageBox.Show(ex.Message.ToString(), "エラー")
    End Try
  End Sub
End Class
