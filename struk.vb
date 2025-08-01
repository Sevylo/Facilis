Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class struk
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    Public Property Username As String
    Public Property RoomId As Integer
    Public Property KodeReservasi As String
    Public Property reservasiKode As String
    Public Property NilaiKembalian As Decimal

    ' Fungsi untuk koneksi ke database MySQL
    Sub koneksi()
        Try
            conn = New MySqlConnection("Server=localhost;Database=facilis;Uid=root;Pwd=;")
            conn.Open()
            'MsgBox("Koneksi berhasil dibuka.", MsgBoxStyle.Information)
        Catch ex As MySqlException
            MsgBox("Terjadi kesalahan pada koneksi MySQL: " & ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then
                ' Koneksi tetap terbuka jika dibutuhkan
            End If
        End Try
    End Sub

    ' Fungsi untuk menampilkan data ke ListView
    Sub tampildata()
        ListView1.Items.Clear()

        ' Query SQL untuk mengambil data dari tabel reservations
        cmd = New MySqlCommand("SELECT reservation_id, username, check_in, check_out, total_price, status FROM reservations WHERE reservation_id = @reservationId", conn)
        cmd.Parameters.AddWithValue("@reservationId", reservasiKode) ' Menggunakan parameter untuk keamanan

        Try
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                While dr.Read()
                    ' Buat item baru untuk setiap baris data
                    Dim item As New ListViewItem(dr("reservation_id").ToString()) ' Kolom pertama dengan reservation_id
                    item.SubItems.Add(dr("username").ToString()) ' Kolom kedua dengan username
                    item.SubItems.Add(Convert.ToDateTime(dr("check_in")).ToString("dd-MM-yyyy")) ' Kolom ketiga dengan check_in
                    item.SubItems.Add(Convert.ToDateTime(dr("check_out")).ToString("dd-MM-yyyy")) ' Kolom keempat dengan check_out
                    item.SubItems.Add(Decimal.Parse(dr("total_price").ToString()).ToString("C", CultureInfo.GetCultureInfo("id-ID"))) ' Kolom kelima dengan total_price
                    item.SubItems.Add(dr("status").ToString()) ' Kolom keenam dengan status

                    ListView1.Items.Add(item) ' Tambahkan item ke ListView
                End While
            Else
                MessageBox.Show("Tidak ada data yang ditemukan untuk reservationId: " & reservasiKode, "Data Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cmd.Dispose()
    End Sub

    ' Event saat form struk dimuat
    Private Sub struk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            koneksi()
            If String.IsNullOrEmpty(reservasiKode) Then
                MessageBox.Show("Reservation ID tidak valid.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            Else
                tampildata()
                kembalian.Text = NilaiKembalian.ToString("C", CultureInfo.GetCultureInfo("id-ID"))
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event saat tombol kembali ditekan
    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Me.Hide()
        loginpage.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kamar2Form As New Form1()
        kamar2Form.Username = Username ' Oper username ke form kamar2
        kamar2Form.Show()
        Me.Hide()
    End Sub
End Class
