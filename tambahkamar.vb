Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class tambahkamar
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    ' Fungsi koneksi ke database MySQL
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

    ' Fungsi untuk memuat data kamar ke dalam ListView
    Private Sub LoadRoomsData()
        ListView1.Items.Clear()
        cmd = New MySqlCommand("SELECT room_id, room_number, room_type, price, description FROM rooms", conn)
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            While dr.Read()
                Dim item As New ListViewItem(dr("room_id").ToString())
                item.SubItems.Add(dr("room_number").ToString())
                item.SubItems.Add(dr("room_type").ToString())
                item.SubItems.Add(dr("price").ToString())
                item.SubItems.Add(dr("description").ToString())
                ListView1.Items.Add(item)
            End While
        End If
        dr.Close()
    End Sub

    ' Event saat form dimuat
    Private Sub tambahkamar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        LoadRoomsData()
    End Sub

    ' Tombol keluar aplikasi
    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Me.Hide()
        homepage.Show()
    End Sub

    ' Fungsi untuk menambah kamar
    Private Sub btntambahkamar_Click(sender As Object, e As EventArgs) Handles btntambahkamar.Click
        Try
            cmd = New MySqlCommand("INSERT INTO rooms (room_id, room_number, room_type, price, description) " &
                                    "VALUES (@roomId, @roomNumber, @roomType, @roomPrice, @roomDesc)", conn)
            cmd.Parameters.AddWithValue("@roomId", roomid.Text)
            cmd.Parameters.AddWithValue("@roomNumber", roomnumber.Text)
            cmd.Parameters.AddWithValue("@roomType", roomtype.Text)
            cmd.Parameters.AddWithValue("@roomPrice", roomprice.Text)
            cmd.Parameters.AddWithValue("@roomDesc", roomdesc.Text)
            cmd.ExecuteNonQuery()
            LoadRoomsData()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    ' Fungsi untuk mengubah data kamar
    Private Sub btnubahkamar_Click(sender As Object, e As EventArgs) Handles btnubahkamar.Click
        Try
            cmd = New MySqlCommand("UPDATE rooms SET room_number = @roomNumber, room_type = @roomType, price = @roomPrice, description = @roomDesc WHERE room_id = @roomId", conn)
            cmd.Parameters.AddWithValue("@roomId", roomid.Text)
            cmd.Parameters.AddWithValue("@roomNumber", roomnumber.Text)
            cmd.Parameters.AddWithValue("@roomType", roomtype.Text)
            cmd.Parameters.AddWithValue("@roomPrice", roomprice.Text)
            cmd.Parameters.AddWithValue("@roomDesc", roomdesc.Text)
            cmd.ExecuteNonQuery()
            LoadRoomsData()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    ' Fungsi untuk menghapus kamar
    Private Sub btnhapuskamar_Click(sender As Object, e As EventArgs) Handles btnhapuskamar.Click
        Try
            cmd = New MySqlCommand("DELETE FROM rooms WHERE room_id = @roomId", conn)
            cmd.Parameters.AddWithValue("@roomId", roomid.Text)
            cmd.ExecuteNonQuery()
            LoadRoomsData()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub


End Class
