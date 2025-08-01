Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class Form1

    Public Property Username As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Muat data pertama kali saat form dimuat
        LoadAllDataToReportViewer()
    End Sub

    ' Fungsi untuk membuat koneksi ke database MySQL
    Private Function GetConnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=facilis;")
    End Function

    ' Fungsi untuk memuat semua data ke ReportViewer
    Private Sub LoadAllDataToReportViewer()
        Dim dt As New DataTable()

        Using conn As MySqlConnection = GetConnection()
            Try
                conn.Open()
                ' Query untuk mengambil semua data dari tabel
                Dim query As String = "SELECT * FROM reservations ORDER BY updated_at DESC"

                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            Catch ex As MySqlException
                MessageBox.Show($"Error fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Catch ex As Exception
                MessageBox.Show($"General error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End Using

        ' Bind data ke ReportViewer
        If dt.Rows.Count > 0 Then
            Dim rds As New ReportDataSource("DataSet1", dt)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)
            ReportViewer1.RefreshReport()
        Else
            MessageBox.Show("No data found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Event handler untuk ReportViewer Load
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        ' Setiap kali ReportViewer di-load, data akan direfresh
        LoadAllDataToReportViewer()
    End Sub

    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Dim kamar2Form As New homepage()
        kamar2Form.Username = Username ' Oper username ke form kamar2
        kamar2Form.Show()
        Hide()
    End Sub
End Class
