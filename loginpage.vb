Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class loginpage

    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Public Property LoggedInUsername As String

    ' Metode untuk koneksi ke MySQL
    Sub koneksi()
        Try
            conn = New MySqlConnection("Server=localhost;Database=facilis;Uid=root;Pwd=;")
            conn.Open()
            MsgBox("Koneksi berhasil dibuka.", MsgBoxStyle.Information)
        Catch ex As MySqlException
            MsgBox("Terjadi kesalahan pada koneksi MySQL: " & ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Saat form loginpage dimuat
    Private Sub loginpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    ' Fungsi login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usernamelogin = username.Text
        Dim passwordlogin = password.Text

        Dim connString = "Server=localhost;Database=facilis;Uid=root;Pwd=;"

        Using conn As New MySqlConnection(connString)
            Try
                conn.Open()
                Dim query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password"

                Using cmd As New MySqlCommand(query, conn)
                    ' Tambahkan parameter untuk menghindari SQL Injection
                    cmd.Parameters.AddWithValue("@username", usernamelogin)
                    cmd.Parameters.AddWithValue("@password", passwordlogin)

                    Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Login berhasil!")
                        LoggedInUsername = usernamelogin
                        Hide()
                        Dim homepageForm As New homepage
                        homepageForm.Username = LoggedInUsername ' Oper username ke form homepage
                        homepageForm.Show()
                    Else
                        MessageBox.Show("Username atau password salah!")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    ' Tombol untuk membuka form registrasi
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim daftarform As New daftar()
        daftarform.Show()
    End Sub


End Class
