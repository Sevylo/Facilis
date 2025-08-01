Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class daftar
    Private Sub daftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim conn As New MySqlConnection("Server=localhost;Database=facilis;Uid=root;Pwd=;")
            conn.Open()
            'MessageBox.Show("Koneksi berhasil dibuka.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Koneksi gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim usernameregister As String = username.Text.Trim()
        Dim passwordregister As String = password.Text.Trim()
        Dim fullnameregister As String = fullname.Text.Trim()
        Dim emailregister As String = email.Text.Trim()

        ' Validasi input
        If String.IsNullOrEmpty(usernameregister) OrElse String.IsNullOrEmpty(passwordregister) OrElse String.IsNullOrEmpty(fullnameregister) OrElse String.IsNullOrEmpty(emailregister) Then
            MessageBox.Show("Semua bidang wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' String koneksi ke MySQL
        Dim connString As String = "Server=localhost;Database=facilis;Uid=root;Pwd=;"

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' Query untuk memasukkan data
                Dim query As String = "INSERT INTO users (username, password, full_name, email) VALUES (@username, @password, @fullname, @email)"

                Using cmd As New MySqlCommand(query, conn)
                    ' Tambahkan parameter untuk menghindari SQL Injection
                    cmd.Parameters.AddWithValue("@username", usernameregister)
                    cmd.Parameters.AddWithValue("@password", passwordregister)
                    cmd.Parameters.AddWithValue("@fullname", fullnameregister)
                    cmd.Parameters.AddWithValue("@email", emailregister)

                    ' Eksekusi query
                    Dim result As Integer = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show("Registrasi berhasil.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Registrasi gagal.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Kesalahan MySQL: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Alihkan ke form login
        Me.Hide()
        Dim loginform As New loginpage()
        loginform.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim loginform As New loginpage()
        loginform.Show()
    End Sub
End Class
