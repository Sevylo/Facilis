
Imports System.Diagnostics
Public Class homepage
    Dim loginPage As loginpage = CType(Application.OpenForms("loginpage"), loginpage)
    Public Property Username As String

    Private Sub buttonkamar1_Click(sender As Object, e As EventArgs) Handles buttonkamar1.Click
        Me.Hide()
        Dim kamar1Form As New kamar1()
        kamar1Form.Username = Username ' Oper username ke form kamar1
        kamar1Form.Show()
    End Sub

    Private Sub buttonkamar2_Click(sender As Object, e As EventArgs) Handles buttonkamar2.Click
        Me.Hide()
        Dim kamar2Form As New kamar2()
        kamar2Form.Username = Username ' Oper username ke form kamar2
        kamar2Form.Show()
    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        tambahkamar.Show()
    End Sub



    Private Sub homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class