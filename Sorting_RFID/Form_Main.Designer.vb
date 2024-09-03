<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnamapenerima = New System.Windows.Forms.TextBox()
        Me.txtalamatpenerima = New System.Windows.Forms.TextBox()
        Me.txtkecpenerima = New System.Windows.Forms.TextBox()
        Me.txtkotapenerima = New System.Windows.Forms.TextBox()
        Me.txtprovinsipenerima = New System.Windows.Forms.TextBox()
        Me.txtkodepospenerima = New System.Windows.Forms.TextBox()
        Me.txthppenerima = New System.Windows.Forms.TextBox()
        Me.txtnamapengirim = New System.Windows.Forms.TextBox()
        Me.txtalamatpengirim = New System.Windows.Forms.TextBox()
        Me.txthppengirim = New System.Windows.Forms.TextBox()
        Me.txtIDpaket = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.combotujuan = New System.Windows.Forms.ComboBox()
        Me.combopemilah = New System.Windows.Forms.ComboBox()
        Me.lblcomp = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.load_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtrfid = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.scan_btn = New System.Windows.Forms.Button()
        Me.ID_btn = New System.Windows.Forms.Button()
        Me.txtread = New System.Windows.Forms.TextBox()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.connect_btn = New System.Windows.Forms.Button()
        Me.comboport = New System.Windows.Forms.ComboBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 120)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Penerima"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 148)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 245)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kecamatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 273)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Kota/Kabupaten"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 369)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No. HP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 337)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Kode Pos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 305)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Provinsi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(356, 180)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Pengirim"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(356, 212)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Alamat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(356, 276)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "No. HP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(356, 308)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 16)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Tujuan"
        '
        'txtnamapenerima
        '
        Me.txtnamapenerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamapenerima.Location = New System.Drawing.Point(128, 116)
        Me.txtnamapenerima.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnamapenerima.MaxLength = 32
        Me.txtnamapenerima.Name = "txtnamapenerima"
        Me.txtnamapenerima.Size = New System.Drawing.Size(215, 22)
        Me.txtnamapenerima.TabIndex = 11
        '
        'txtalamatpenerima
        '
        Me.txtalamatpenerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamatpenerima.Location = New System.Drawing.Point(128, 148)
        Me.txtalamatpenerima.Margin = New System.Windows.Forms.Padding(4)
        Me.txtalamatpenerima.MaxLength = 96
        Me.txtalamatpenerima.Multiline = True
        Me.txtalamatpenerima.Name = "txtalamatpenerima"
        Me.txtalamatpenerima.Size = New System.Drawing.Size(215, 85)
        Me.txtalamatpenerima.TabIndex = 12
        '
        'txtkecpenerima
        '
        Me.txtkecpenerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkecpenerima.Location = New System.Drawing.Point(128, 242)
        Me.txtkecpenerima.Margin = New System.Windows.Forms.Padding(4)
        Me.txtkecpenerima.MaxLength = 32
        Me.txtkecpenerima.Name = "txtkecpenerima"
        Me.txtkecpenerima.Size = New System.Drawing.Size(215, 22)
        Me.txtkecpenerima.TabIndex = 13
        '
        'txtkotapenerima
        '
        Me.txtkotapenerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkotapenerima.Location = New System.Drawing.Point(128, 270)
        Me.txtkotapenerima.Margin = New System.Windows.Forms.Padding(4)
        Me.txtkotapenerima.MaxLength = 32
        Me.txtkotapenerima.Name = "txtkotapenerima"
        Me.txtkotapenerima.Size = New System.Drawing.Size(215, 22)
        Me.txtkotapenerima.TabIndex = 14
        '
        'txtprovinsipenerima
        '
        Me.txtprovinsipenerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprovinsipenerima.Location = New System.Drawing.Point(128, 301)
        Me.txtprovinsipenerima.Margin = New System.Windows.Forms.Padding(4)
        Me.txtprovinsipenerima.MaxLength = 32
        Me.txtprovinsipenerima.Name = "txtprovinsipenerima"
        Me.txtprovinsipenerima.Size = New System.Drawing.Size(215, 22)
        Me.txtprovinsipenerima.TabIndex = 15
        '
        'txtkodepospenerima
        '
        Me.txtkodepospenerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkodepospenerima.Location = New System.Drawing.Point(128, 332)
        Me.txtkodepospenerima.Margin = New System.Windows.Forms.Padding(4)
        Me.txtkodepospenerima.MaxLength = 16
        Me.txtkodepospenerima.Name = "txtkodepospenerima"
        Me.txtkodepospenerima.Size = New System.Drawing.Size(215, 22)
        Me.txtkodepospenerima.TabIndex = 16
        '
        'txthppenerima
        '
        Me.txthppenerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthppenerima.Location = New System.Drawing.Point(128, 364)
        Me.txthppenerima.Margin = New System.Windows.Forms.Padding(4)
        Me.txthppenerima.MaxLength = 16
        Me.txthppenerima.Name = "txthppenerima"
        Me.txthppenerima.Size = New System.Drawing.Size(215, 22)
        Me.txthppenerima.TabIndex = 17
        '
        'txtnamapengirim
        '
        Me.txtnamapengirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamapengirim.Location = New System.Drawing.Point(432, 176)
        Me.txtnamapengirim.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnamapengirim.MaxLength = 32
        Me.txtnamapengirim.Name = "txtnamapengirim"
        Me.txtnamapengirim.Size = New System.Drawing.Size(215, 22)
        Me.txtnamapengirim.TabIndex = 18
        '
        'txtalamatpengirim
        '
        Me.txtalamatpengirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamatpengirim.Location = New System.Drawing.Point(432, 208)
        Me.txtalamatpengirim.Margin = New System.Windows.Forms.Padding(4)
        Me.txtalamatpengirim.MaxLength = 32
        Me.txtalamatpengirim.Multiline = True
        Me.txtalamatpengirim.Name = "txtalamatpengirim"
        Me.txtalamatpengirim.Size = New System.Drawing.Size(215, 56)
        Me.txtalamatpengirim.TabIndex = 23
        '
        'txthppengirim
        '
        Me.txthppengirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthppengirim.Location = New System.Drawing.Point(432, 272)
        Me.txthppengirim.Margin = New System.Windows.Forms.Padding(4)
        Me.txthppengirim.MaxLength = 16
        Me.txthppengirim.Name = "txthppengirim"
        Me.txthppengirim.Size = New System.Drawing.Size(215, 22)
        Me.txthppengirim.TabIndex = 24
        '
        'txtIDpaket
        '
        Me.txtIDpaket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDpaket.Location = New System.Drawing.Point(432, 144)
        Me.txtIDpaket.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIDpaket.MaxLength = 16
        Me.txtIDpaket.Name = "txtIDpaket"
        Me.txtIDpaket.Size = New System.Drawing.Size(215, 22)
        Me.txtIDpaket.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(356, 148)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "ID Paket"
        '
        'close_btn
        '
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.Location = New System.Drawing.Point(652, 313)
        Me.close_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(115, 73)
        Me.close_btn.TabIndex = 27
        Me.close_btn.Text = "CLOSE"
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.Location = New System.Drawing.Point(652, 196)
        Me.save_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(115, 32)
        Me.save_btn.TabIndex = 28
        Me.save_btn.Text = "SAVE"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(83, 4)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(469, 68)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "RANCANG BANGUN SISTEM SORTIR BARANG PAKET BERBASIS RFID"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(4, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'combotujuan
        '
        Me.combotujuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combotujuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combotujuan.FormattingEnabled = True
        Me.combotujuan.Location = New System.Drawing.Point(432, 304)
        Me.combotujuan.Margin = New System.Windows.Forms.Padding(4)
        Me.combotujuan.Name = "combotujuan"
        Me.combotujuan.Size = New System.Drawing.Size(215, 24)
        Me.combotujuan.TabIndex = 31
        '
        'combopemilah
        '
        Me.combopemilah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combopemilah.Enabled = False
        Me.combopemilah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combopemilah.FormattingEnabled = True
        Me.combopemilah.Location = New System.Drawing.Point(432, 332)
        Me.combopemilah.Margin = New System.Windows.Forms.Padding(4)
        Me.combopemilah.Name = "combopemilah"
        Me.combopemilah.Size = New System.Drawing.Size(215, 24)
        Me.combopemilah.TabIndex = 32
        '
        'lblcomp
        '
        Me.lblcomp.AutoSize = True
        Me.lblcomp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcomp.ForeColor = System.Drawing.Color.Green
        Me.lblcomp.Location = New System.Drawing.Point(432, 368)
        Me.lblcomp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcomp.Name = "lblcomp"
        Me.lblcomp.Size = New System.Drawing.Size(51, 16)
        Me.lblcomp.TabIndex = 34
        Me.lblcomp.Text = "Status"
        Me.lblcomp.Visible = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(356, 368)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Status"
        '
        'clear_btn
        '
        Me.clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.Location = New System.Drawing.Point(652, 250)
        Me.clear_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(115, 32)
        Me.clear_btn.TabIndex = 43
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(553, 24)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 17)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Tanggal"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(553, 44)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 16)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Waktu"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(676, 2)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 13)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Create by : Benny"
        '
        'Timer2
        '
        Me.Timer2.Interval = 200
        '
        'load_btn
        '
        Me.load_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.load_btn.Location = New System.Drawing.Point(259, 501)
        Me.load_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.load_btn.Name = "load_btn"
        Me.load_btn.Size = New System.Drawing.Size(115, 32)
        Me.load_btn.TabIndex = 49
        Me.load_btn.Text = "LOAD"
        Me.load_btn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(609, 360)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 24)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Exm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(376, 112)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(273, 20)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 51
        '
        'txtrfid
        '
        Me.txtrfid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrfid.Location = New System.Drawing.Point(504, 84)
        Me.txtrfid.Name = "txtrfid"
        Me.txtrfid.Size = New System.Drawing.Size(144, 26)
        Me.txtrfid.TabIndex = 52
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(371, 88)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(127, 20)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "RFID TAG ID :"
        '
        'scan_btn
        '
        Me.scan_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scan_btn.Location = New System.Drawing.Point(383, 494)
        Me.scan_btn.Name = "scan_btn"
        Me.scan_btn.Size = New System.Drawing.Size(115, 56)
        Me.scan_btn.TabIndex = 54
        Me.scan_btn.Text = "SCAN RFID"
        Me.scan_btn.UseVisualStyleBackColor = True
        '
        'ID_btn
        '
        Me.ID_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_btn.Location = New System.Drawing.Point(652, 144)
        Me.ID_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.ID_btn.Name = "ID_btn"
        Me.ID_btn.Size = New System.Drawing.Size(115, 32)
        Me.ID_btn.TabIndex = 55
        Me.ID_btn.Text = "ID PAKET"
        Me.ID_btn.UseVisualStyleBackColor = True
        '
        'txtread
        '
        Me.txtread.Location = New System.Drawing.Point(7, 393)
        Me.txtread.Multiline = True
        Me.txtread.Name = "txtread"
        Me.txtread.Size = New System.Drawing.Size(760, 263)
        Me.txtread.TabIndex = 56
        '
        'refresh_btn
        '
        Me.refresh_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_btn.Location = New System.Drawing.Point(378, 429)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(120, 30)
        Me.refresh_btn.TabIndex = 57
        Me.refresh_btn.Text = "REFRESH"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'connect_btn
        '
        Me.connect_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_btn.Location = New System.Drawing.Point(378, 461)
        Me.connect_btn.Name = "connect_btn"
        Me.connect_btn.Size = New System.Drawing.Size(120, 30)
        Me.connect_btn.TabIndex = 58
        Me.connect_btn.Text = "CONNECT"
        Me.connect_btn.UseVisualStyleBackColor = True
        '
        'comboport
        '
        Me.comboport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboport.FormattingEnabled = True
        Me.comboport.Location = New System.Drawing.Point(286, 433)
        Me.comboport.Name = "comboport"
        Me.comboport.Size = New System.Drawing.Size(88, 24)
        Me.comboport.TabIndex = 59
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(286, 465)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(88, 22)
        Me.txtpass.TabIndex = 60
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(210, 437)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 16)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Com Port"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(210, 469)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 16)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "Password"
        '
        'Timer3
        '
        Me.Timer3.Interval = 3000
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(776, 668)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtread)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.comboport)
        Me.Controls.Add(Me.connect_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.ID_btn)
        Me.Controls.Add(Me.scan_btn)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtrfid)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.load_btn)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblcomp)
        Me.Controls.Add(Me.combopemilah)
        Me.Controls.Add(Me.combotujuan)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.txtIDpaket)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txthppengirim)
        Me.Controls.Add(Me.txtalamatpengirim)
        Me.Controls.Add(Me.txtnamapengirim)
        Me.Controls.Add(Me.txthppenerima)
        Me.Controls.Add(Me.txtkodepospenerima)
        Me.Controls.Add(Me.txtprovinsipenerima)
        Me.Controls.Add(Me.txtkotapenerima)
        Me.Controls.Add(Me.txtkecpenerima)
        Me.Controls.Add(Me.txtalamatpenerima)
        Me.Controls.Add(Me.txtnamapenerima)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Main"
        Me.Text = "RFID_Sorter"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtnamapenerima As System.Windows.Forms.TextBox
    Friend WithEvents txtalamatpenerima As System.Windows.Forms.TextBox
    Friend WithEvents txtkecpenerima As System.Windows.Forms.TextBox
    Friend WithEvents txtkotapenerima As System.Windows.Forms.TextBox
    Friend WithEvents txtprovinsipenerima As System.Windows.Forms.TextBox
    Friend WithEvents txtkodepospenerima As System.Windows.Forms.TextBox
    Friend WithEvents txthppenerima As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapengirim As System.Windows.Forms.TextBox
    Friend WithEvents txtalamatpengirim As System.Windows.Forms.TextBox
    Friend WithEvents txthppengirim As System.Windows.Forms.TextBox
    Friend WithEvents txtIDpaket As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents close_btn As System.Windows.Forms.Button
    Friend WithEvents save_btn As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents combotujuan As System.Windows.Forms.ComboBox
    Friend WithEvents combopemilah As System.Windows.Forms.ComboBox
    Friend WithEvents lblcomp As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents load_btn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents txtrfid As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents scan_btn As System.Windows.Forms.Button
    Friend WithEvents ID_btn As System.Windows.Forms.Button
    Friend WithEvents txtread As System.Windows.Forms.TextBox
    Friend WithEvents refresh_btn As System.Windows.Forms.Button
    Friend WithEvents connect_btn As System.Windows.Forms.Button
    Friend WithEvents comboport As System.Windows.Forms.ComboBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer

End Class
