<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.backbutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.buttonbayar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.hargakamar = New System.Windows.Forms.TextBox()
        Me.tipekamar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nokamar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bayar = New System.Windows.Forms.TextBox()
        Me.hasilhitung = New System.Windows.Forms.TextBox()
        Me.berapahari = New System.Windows.Forms.NumericUpDown()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.berapahari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.backbutton)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(12, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(827, 56)
        Me.Panel3.TabIndex = 2
        '
        'backbutton
        '
        Me.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backbutton.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.backbutton.Location = New System.Drawing.Point(662, 7)
        Me.backbutton.Name = "backbutton"
        Me.backbutton.Size = New System.Drawing.Size(130, 43)
        Me.backbutton.TabIndex = 3
        Me.backbutton.Text = "BACK"
        Me.backbutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(143, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TRANSAKSI"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Project_UAS.My.Resources.Resources._2
        Me.PictureBox2.Location = New System.Drawing.Point(52, -4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(81, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_UAS.My.Resources.Resources._1
        Me.PictureBox1.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.buttonbayar)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.hargakamar)
        Me.Panel1.Controls.Add(Me.tipekamar)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.nokamar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.bayar)
        Me.Panel1.Controls.Add(Me.hasilhitung)
        Me.Panel1.Controls.Add(Me.berapahari)
        Me.Panel1.Location = New System.Drawing.Point(12, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 358)
        Me.Panel1.TabIndex = 3
        '
        'buttonbayar
        '
        Me.buttonbayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonbayar.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonbayar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buttonbayar.Location = New System.Drawing.Point(609, 204)
        Me.buttonbayar.Name = "buttonbayar"
        Me.buttonbayar.Size = New System.Drawing.Size(132, 43)
        Me.buttonbayar.TabIndex = 4
        Me.buttonbayar.Text = "BAYAR"
        Me.buttonbayar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(618, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "TOTAL HARGA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(23, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Harga Per Malam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(26, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Tipe Kamar"
        '
        'hargakamar
        '
        Me.hargakamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hargakamar.Location = New System.Drawing.Point(250, 122)
        Me.hargakamar.Name = "hargakamar"
        Me.hargakamar.ReadOnly = True
        Me.hargakamar.Size = New System.Drawing.Size(194, 30)
        Me.hargakamar.TabIndex = 14
        '
        'tipekamar
        '
        Me.tipekamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipekamar.Location = New System.Drawing.Point(213, 76)
        Me.tipekamar.Name = "tipekamar"
        Me.tipekamar.ReadOnly = True
        Me.tipekamar.Size = New System.Drawing.Size(231, 30)
        Me.tipekamar.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(26, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nomor Kamar"
        '
        'nokamar
        '
        Me.nokamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nokamar.Location = New System.Drawing.Point(213, 22)
        Me.nokamar.Name = "nokamar"
        Me.nokamar.ReadOnly = True
        Me.nokamar.Size = New System.Drawing.Size(231, 30)
        Me.nokamar.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(26, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mau Berapa Hari?"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(523, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 51)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "MASUKAN JUMLAH UANG PEMBAYARAN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bayar
        '
        Me.bayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bayar.Location = New System.Drawing.Point(540, 155)
        Me.bayar.Name = "bayar"
        Me.bayar.Size = New System.Drawing.Size(249, 30)
        Me.bayar.TabIndex = 5
        '
        'hasilhitung
        '
        Me.hasilhitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasilhitung.Location = New System.Drawing.Point(609, 55)
        Me.hasilhitung.Name = "hasilhitung"
        Me.hasilhitung.Size = New System.Drawing.Size(180, 30)
        Me.hasilhitung.TabIndex = 4
        '
        'berapahari
        '
        Me.berapahari.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.berapahari.Location = New System.Drawing.Point(367, 175)
        Me.berapahari.Name = "berapahari"
        Me.berapahari.Size = New System.Drawing.Size(77, 28)
        Me.berapahari.TabIndex = 1
        '
        'transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 344)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "transaksi"
        Me.Text = "TRANSAKSI"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.berapahari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents backbutton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents bayar As TextBox
    Friend WithEvents hasilhitung As TextBox
    Friend WithEvents berapahari As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents hargakamar As TextBox
    Friend WithEvents tipekamar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nokamar As TextBox
    Friend WithEvents buttonbayar As Button
End Class
