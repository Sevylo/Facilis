Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Windows.Forms

Public Class transaksi

    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    Public Property Username As String
    Public Property KodeReservasi As String
    Public Property reservasiKode As String
    Dim totalHarga As Decimal
    Public Property RoomId As Integer

    Sub koneksi()
        Try
            conn = New MySqlConnection("server=localhost;user id=root;password=;database=facilis;")
            conn.Open()
        Catch ex As MySqlException
            MsgBox("Terjadi kesalahan pada koneksi MySQL: " & ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then
                'conn.Close()
            End If
        End Try
    End Sub

    Private Sub tampilkanData(roomId As Integer)
        Dim cmd As New MySqlCommand("SELECT room_number, room_type, price FROM rooms WHERE room_id = @roomId", conn)
        cmd.Parameters.AddWithValue("@roomId", roomId)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                nokamar.Text = reader("room_number").ToString()
                tipekamar.Text = reader("room_type").ToString()
                hargakamar.Text = reader("price").ToString()
            Else
                MessageBox.Show("Data tidak ditemukan.")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilkanData(RoomId)
    End Sub

    Function GenerateNumericReservationId() As Integer
        Dim newId As Integer
        Dim cmd As New MySqlCommand("SELECT IFNULL(MAX(reservation_id), 0) + 1 FROM reservations", conn)
        newId = Convert.ToInt32(cmd.ExecuteScalar())
        Return newId
    End Function

    Private Sub SimpanTransaksi(reservationId As Integer)
        reservationId = GenerateNumericReservationId()
        Dim username As String = Me.Username
        Dim roomId As Integer = Me.RoomId
        Dim checkIn As Date = DateTime.Now
        Dim checkOut As Date = DateTime.Now.AddDays(Convert.ToInt32(berapahari.Value))
        Dim totalPrice As Decimal = Decimal.Parse(hasilhitung.Text, Globalization.NumberStyles.Currency, New Globalization.CultureInfo("id-ID"))
        Dim status As String = "Booked"

        Dim cmd As New MySqlCommand("INSERT INTO reservations (reservation_id, username, room_id, check_in, check_out, total_price, status) " &
                                     "VALUES (@reservationId, @username, @roomId, @checkIn, @checkOut, @totalPrice, @status)", conn)
        cmd.Parameters.AddWithValue("@reservationId", reservationId)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@roomId", roomId)
        cmd.Parameters.AddWithValue("@checkIn", checkIn)
        cmd.Parameters.AddWithValue("@checkOut", checkOut)
        cmd.Parameters.AddWithValue("@totalPrice", totalPrice)
        cmd.Parameters.AddWithValue("@status", status)

        Try
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Transaksi berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Gagal menyimpan transaksi.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub buttonbayar_Click(sender As Object, e As EventArgs) Handles buttonbayar.Click
        Dim uangDibayar As Decimal
        If Decimal.TryParse(bayar.Text, uangDibayar) Then
            If totalHarga <= 0 Then
                MessageBox.Show("Harga total harus lebih dari 0", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If uangDibayar < totalHarga Then
                MessageBox.Show("Uang yang dibayarkan kurang dari total harga. Silakan bayar lagi.", "Pembayaran Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Pembayaran berhasil! Terima kasih.", "Pembayaran Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim reservationId As Integer = GenerateNumericReservationId()
                SimpanTransaksi(reservationId)

                Dim kembalian As Decimal = uangDibayar - totalHarga

                Dim strukshow As New struk
                strukshow.NilaiKembalian = kembalian
                strukshow.RoomId = RoomId
                strukshow.Username = Username
                strukshow.reservasiKode = reservationId
                strukshow.Show()

                Me.Hide()
            End If
        Else
            MessageBox.Show("Masukkan jumlah uang yang valid.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Dim hompek As New homepage()
        hompek.Username = Username ' Oper username ke form kamar2
        hompek.Show()
        Me.Hide()
        homepage.Show()

    End Sub

    Private Sub berapahari_ValueChanged(sender As Object, e As EventArgs) Handles berapahari.ValueChanged
        Dim harga As Decimal = Convert.ToDecimal(hargakamar.Text)
        Dim jumlahHari As Integer = Convert.ToInt32(berapahari.Value)
        Dim cultureInfo As New CultureInfo("id-ID")
        totalHarga = harga * jumlahHari
        MessageBox.Show("Total Harga: " & totalHarga.ToString("C", cultureInfo))
        hasilhitung.Text = totalHarga.ToString("C", cultureInfo)
    End Sub


End Class
