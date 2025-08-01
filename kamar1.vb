Imports MySql.Data.MySqlClient

Public Class kamar1
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim roomId As Integer = 1
    Public Property Username As String

    ' Fungsi koneksi ke MySQL
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

    ' Fungsi untuk menampilkan data kamar berdasarkan roomId
    Private Sub tampilkanData(roomId As Integer)
        Dim query As String = "SELECT room_number, room_type, price, description FROM rooms WHERE room_id = @roomId"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@roomId", roomId)

        Try
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                nokamar.Text = reader("room_number").ToString()
                tipekamar.Text = reader("room_type").ToString()
                hargakamar.Text = reader("price").ToString()
                deskripsi.Text = reader("description").ToString()
            Else
                MessageBox.Show("Data tidak ditemukan.")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    ' Event saat form kamar1 dimuat
    Private Sub kamar1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilkanData(roomId)

    End Sub

    ' Event saat tombol kembali ditekan
    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Hide()
        homepage.Show()
    End Sub

    ' Event saat tombol pesan ditekan
    Private Sub pesan_Click(sender As Object, e As EventArgs) Handles pesan.Click
        Dim transaksiForm As New transaksi
        transaksiForm.RoomId = roomId
        transaksiForm.Username = Username
        transaksiForm.Show()
        Me.Hide()
    End Sub


End Class
