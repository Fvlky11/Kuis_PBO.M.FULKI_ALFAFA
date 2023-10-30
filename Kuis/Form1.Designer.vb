<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        btnhasil = New Button()
        txtkembalian = New TextBox()
        txtuang = New TextBox()
        txttotalbayar = New TextBox()
        txthargapeminjaman = New TextBox()
        txtdenda = New TextBox()
        txtjumlahketerlambatan = New TextBox()
        txtbuku = New TextBox()
        txtnama = New TextBox()
        txtktp = New TextBox()
        txtanggota = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label1.AutoEllipsis = True
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(241, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 25)
        Label1.TabIndex = 0
        Label1.Text = "Transaksi Peminjaman Buku"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox1.BackColor = Color.MidnightBlue
        GroupBox1.Controls.Add(DateTimePicker2)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(btnhasil)
        GroupBox1.Controls.Add(txtkembalian)
        GroupBox1.Controls.Add(txtuang)
        GroupBox1.Controls.Add(txttotalbayar)
        GroupBox1.Controls.Add(txthargapeminjaman)
        GroupBox1.Controls.Add(txtdenda)
        GroupBox1.Controls.Add(txtjumlahketerlambatan)
        GroupBox1.Controls.Add(txtbuku)
        GroupBox1.Controls.Add(txtnama)
        GroupBox1.Controls.Add(txtktp)
        GroupBox1.Controls.Add(txtanggota)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.ForeColor = SystemColors.InfoText
        GroupBox1.Location = New Point(12, 54)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(659, 457)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(229, 191)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(301, 27)
        DateTimePicker2.TabIndex = 38
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(229, 158)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(301, 27)
        DateTimePicker1.TabIndex = 37
        ' 
        ' btnhasil
        ' 
        btnhasil.Location = New Point(536, 389)
        btnhasil.Name = "btnhasil"
        btnhasil.Size = New Size(94, 29)
        btnhasil.TabIndex = 36
        btnhasil.Text = "Hasil"
        btnhasil.UseVisualStyleBackColor = True
        ' 
        ' txtkembalian
        ' 
        txtkembalian.Location = New Point(229, 389)
        txtkembalian.Name = "txtkembalian"
        txtkembalian.Size = New Size(301, 27)
        txtkembalian.TabIndex = 35
        ' 
        ' txtuang
        ' 
        txtuang.Location = New Point(229, 356)
        txtuang.Name = "txtuang"
        txtuang.Size = New Size(301, 27)
        txtuang.TabIndex = 34
        ' 
        ' txttotalbayar
        ' 
        txttotalbayar.Location = New Point(229, 323)
        txttotalbayar.Name = "txttotalbayar"
        txttotalbayar.Size = New Size(301, 27)
        txttotalbayar.TabIndex = 33
        ' 
        ' txthargapeminjaman
        ' 
        txthargapeminjaman.Location = New Point(229, 290)
        txthargapeminjaman.Name = "txthargapeminjaman"
        txthargapeminjaman.Size = New Size(301, 27)
        txthargapeminjaman.TabIndex = 32
        ' 
        ' txtdenda
        ' 
        txtdenda.Location = New Point(229, 257)
        txtdenda.Name = "txtdenda"
        txtdenda.Size = New Size(301, 27)
        txtdenda.TabIndex = 31
        ' 
        ' txtjumlahketerlambatan
        ' 
        txtjumlahketerlambatan.Location = New Point(229, 224)
        txtjumlahketerlambatan.Name = "txtjumlahketerlambatan"
        txtjumlahketerlambatan.Size = New Size(301, 27)
        txtjumlahketerlambatan.TabIndex = 30
        ' 
        ' txtbuku
        ' 
        txtbuku.Location = New Point(229, 125)
        txtbuku.Name = "txtbuku"
        txtbuku.Size = New Size(301, 27)
        txtbuku.TabIndex = 28
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(229, 92)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(301, 27)
        txtnama.TabIndex = 27
        ' 
        ' txtktp
        ' 
        txtktp.Location = New Point(229, 59)
        txtktp.Name = "txtktp"
        txtktp.Size = New Size(301, 27)
        txtktp.TabIndex = 26
        ' 
        ' txtanggota
        ' 
        txtanggota.Location = New Point(229, 26)
        txtanggota.Name = "txtanggota"
        txtanggota.Size = New Size(301, 27)
        txtanggota.TabIndex = 25
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.ForeColor = SystemColors.Control
        Label13.Location = New Point(9, 389)
        Label13.Name = "Label13"
        Label13.Size = New Size(80, 20)
        Label13.TabIndex = 24
        Label13.Text = "Kembalian"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.ForeColor = SystemColors.Control
        Label12.Location = New Point(6, 353)
        Label12.Name = "Label12"
        Label12.Size = New Size(205, 20)
        Label12.TabIndex = 23
        Label12.Text = "Uang Yang Harus Di Bayarkan"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = SystemColors.Control
        Label11.Location = New Point(6, 323)
        Label11.Name = "Label11"
        Label11.Size = New Size(83, 20)
        Label11.TabIndex = 22
        Label11.Text = "Total Bayar"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = SystemColors.Control
        Label10.Location = New Point(6, 290)
        Label10.Name = "Label10"
        Label10.Size = New Size(171, 20)
        Label10.TabIndex = 21
        Label10.Text = "Harga Peminjaman Buku"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = SystemColors.Control
        Label9.Location = New Point(6, 257)
        Label9.Name = "Label9"
        Label9.Size = New Size(130, 20)
        Label9.TabIndex = 20
        Label9.Text = "Total Biaya Denda"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = SystemColors.Control
        Label8.Location = New Point(6, 224)
        Label8.Name = "Label8"
        Label8.Size = New Size(199, 20)
        Label8.TabIndex = 19
        Label8.Text = "Jumlah Keterlambatan (Hari)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(6, 191)
        Label7.Name = "Label7"
        Label7.Size = New Size(159, 20)
        Label7.TabIndex = 18
        Label7.Text = "Tanggal Pengembalian"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(6, 158)
        Label6.Name = "Label6"
        Label6.Size = New Size(146, 20)
        Label6.TabIndex = 17
        Label6.Text = "Tanggal Peminjaman"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(6, 125)
        Label5.Name = "Label5"
        Label5.Size = New Size(182, 20)
        Label5.TabIndex = 16
        Label5.Text = "Buku Yang Akan Di Pinjam"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(6, 92)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 20)
        Label4.TabIndex = 15
        Label4.Text = "Nama Lengkap"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(6, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 20)
        Label3.TabIndex = 14
        Label3.Text = "No KTP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(6, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 20)
        Label2.TabIndex = 13
        Label2.Text = "No Anggota"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(683, 523)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Fulki Alfafa"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtjumlahketerlambatan As TextBox
    Friend WithEvents txtbuku As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtktp As TextBox
    Friend WithEvents txtanggota As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txthargapeminjaman As TextBox
    Friend WithEvents txtdenda As TextBox
    Friend WithEvents txtkembalian As TextBox
    Friend WithEvents txtuang As TextBox
    Friend WithEvents txttotalbayar As TextBox
    Friend WithEvents btnhasil As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
