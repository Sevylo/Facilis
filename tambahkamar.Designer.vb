<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambahkamar
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.roomdesc = New System.Windows.Forms.TextBox()
        Me.roomprice = New System.Windows.Forms.TextBox()
        Me.roomtype = New System.Windows.Forms.TextBox()
        Me.roomnumber = New System.Windows.Forms.TextBox()
        Me.roomid = New System.Windows.Forms.TextBox()
        Me.btnhapuskamar = New System.Windows.Forms.Button()
        Me.btnubahkamar = New System.Windows.Forms.Button()
        Me.btntambahkamar = New System.Windows.Forms.Button()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.exitbutton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(847, 56)
        Me.Panel1.TabIndex = 1
        '
        'exitbutton
        '
        Me.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitbutton.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.exitbutton.Location = New System.Drawing.Point(712, 7)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(115, 43)
        Me.exitbutton.TabIndex = 3
        Me.exitbutton.Text = "BACK"
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(133, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FACILIS  ADMINISTRATOR"
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
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(14, 13)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(813, 122)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.roomdesc)
        Me.Panel2.Controls.Add(Me.roomprice)
        Me.Panel2.Controls.Add(Me.roomtype)
        Me.Panel2.Controls.Add(Me.roomnumber)
        Me.Panel2.Controls.Add(Me.roomid)
        Me.Panel2.Controls.Add(Me.btnhapuskamar)
        Me.Panel2.Controls.Add(Me.btnubahkamar)
        Me.Panel2.Controls.Add(Me.btntambahkamar)
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Location = New System.Drawing.Point(12, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(847, 296)
        Me.Panel2.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(579, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "DESCRIPTION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(451, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "PRICE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(305, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "ROOM TYPE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(135, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ROOM NUMBER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(10, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ROOM ID"
        '
        'roomdesc
        '
        Me.roomdesc.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomdesc.Location = New System.Drawing.Point(583, 174)
        Me.roomdesc.Multiline = True
        Me.roomdesc.Name = "roomdesc"
        Me.roomdesc.Size = New System.Drawing.Size(244, 103)
        Me.roomdesc.TabIndex = 11
        '
        'roomprice
        '
        Me.roomprice.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomprice.Location = New System.Drawing.Point(455, 174)
        Me.roomprice.Name = "roomprice"
        Me.roomprice.Size = New System.Drawing.Size(122, 32)
        Me.roomprice.TabIndex = 10
        '
        'roomtype
        '
        Me.roomtype.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomtype.Location = New System.Drawing.Point(309, 174)
        Me.roomtype.Name = "roomtype"
        Me.roomtype.Size = New System.Drawing.Size(140, 32)
        Me.roomtype.TabIndex = 9
        '
        'roomnumber
        '
        Me.roomnumber.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomnumber.Location = New System.Drawing.Point(139, 174)
        Me.roomnumber.Name = "roomnumber"
        Me.roomnumber.Size = New System.Drawing.Size(159, 32)
        Me.roomnumber.TabIndex = 8
        '
        'roomid
        '
        Me.roomid.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomid.Location = New System.Drawing.Point(14, 174)
        Me.roomid.Name = "roomid"
        Me.roomid.Size = New System.Drawing.Size(119, 32)
        Me.roomid.TabIndex = 7
        '
        'btnhapuskamar
        '
        Me.btnhapuskamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapuskamar.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapuskamar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnhapuskamar.Location = New System.Drawing.Point(309, 225)
        Me.btnhapuskamar.Name = "btnhapuskamar"
        Me.btnhapuskamar.Size = New System.Drawing.Size(135, 43)
        Me.btnhapuskamar.TabIndex = 6
        Me.btnhapuskamar.Text = "HAPUS"
        Me.btnhapuskamar.UseVisualStyleBackColor = True
        '
        'btnubahkamar
        '
        Me.btnubahkamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnubahkamar.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubahkamar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnubahkamar.Location = New System.Drawing.Point(189, 225)
        Me.btnubahkamar.Name = "btnubahkamar"
        Me.btnubahkamar.Size = New System.Drawing.Size(114, 43)
        Me.btnubahkamar.TabIndex = 5
        Me.btnubahkamar.Text = "UBAH"
        Me.btnubahkamar.UseVisualStyleBackColor = True
        '
        'btntambahkamar
        '
        Me.btntambahkamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambahkamar.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambahkamar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btntambahkamar.Location = New System.Drawing.Point(9, 225)
        Me.btntambahkamar.Name = "btntambahkamar"
        Me.btntambahkamar.Size = New System.Drawing.Size(174, 43)
        Me.btntambahkamar.TabIndex = 4
        Me.btntambahkamar.Text = "TAMBAH"
        Me.btntambahkamar.UseVisualStyleBackColor = True
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Room ID"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Room Number"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Room Type"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Price"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Description"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 300
        '
        'tambahkamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 391)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "tambahkamar"
        Me.Text = "ADD ROOMS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents exitbutton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents roomdesc As TextBox
    Friend WithEvents roomprice As TextBox
    Friend WithEvents roomtype As TextBox
    Friend WithEvents roomid As TextBox
    Friend WithEvents btnhapuskamar As Button
    Friend WithEvents btnubahkamar As Button
    Friend WithEvents btntambahkamar As Button
    Friend WithEvents roomnumber As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
