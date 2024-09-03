Imports System
Imports System.IO.Ports
Imports System.Windows.Forms
Imports System.Globalization
Imports System.IO
Imports System.Threading

Public Class Form_Main
    Dim receivedData As String = ""
    Dim id(2) As String
    Dim data(13) As String
    Dim k As Integer = 0
    Dim IDError As Integer = 0
    Dim culture = New System.Globalization.CultureInfo("id-ID")
    Dim tanggal As String = Date.Today.ToString("dd MMMM yyyy")
    Dim day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek)

    Dim pass As String
    Dim comport As String

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
        combotujuan.Items.Clear()
        combopemilah.Items.Clear()

        txtrfid.Enabled = False
        txtread.Enabled = False

        txtIDpaket.Enabled = False

        txtnamapenerima.Enabled = False
        txtalamatpenerima.Enabled = False
        txtkecpenerima.Enabled = False
        txtkotapenerima.Enabled = False
        txtprovinsipenerima.Enabled = False
        txtkodepospenerima.Enabled = False
        txthppenerima.Enabled = False

        txtnamapengirim.Enabled = False
        txtalamatpengirim.Enabled = False
        txthppengirim.Enabled = False

        clear_btn.Enabled = False
        load_btn.Enabled = False
        save_btn.Enabled = False
        ID_btn.Enabled = False
        scan_btn.Enabled = False
        combotujuan.Enabled = False
        combopemilah.Enabled = False

        clear()
        SerialPort1.Close()
        SerialPort1.Dispose()

        Form_Login.txtpass.Text = ""
        Form_Login.Show()

        'Timer2.Stop()
        'txtIDpaket.Text = ""
        'txtnamapenerima.Text = ""
        'txtalamatpenerima.Text = ""
        'txtkecpenerima.Text = ""
        'txtkotapenerima.Text = ""
        'txtprovinsipenerima.Text = ""
        'txtkodepospenerima.Text = ""
        'txthppenerima.Text = ""

        'txtnamapengirim.Text = ""
        'txtalamatpengirim.Text = ""
        'txthppengirim.Text = ""
        'combotujuan.SelectedIndex = -1
        'combopemilah.SelectedIndex = -1
        'ProgressBar1.Value = 0
        'lblcomp.Visible = False
    End Sub

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label15.Hide()
        Label16.Hide()
        comboport.Hide()
        txtpass.Hide()
        refresh_btn.Hide()
        connect_btn.Hide()

        'pass = "12345"
        'comport = ""

        'For Each SerialPortCom As String In My.Computer.Ports.SerialPortNames
        '    comboport.Items.Add(SerialPortCom)
        'Next

        combotujuan.Items.Add("Dalam Kota")
        combotujuan.Items.Add("Luar Kota Dalam Provinsi")
        combotujuan.Items.Add("Luar Provinsi ")

        combopemilah.Items.Add("Dalam Pulau")
        combopemilah.Items.Add("Luar Pulau")
        combopemilah.Items.Add("Luar Negeri")

        txtrfid.Enabled = True
        txtread.Enabled = True

        txtIDpaket.Enabled = True

        txtnamapenerima.Enabled = True
        txtalamatpenerima.Enabled = True
        txtkecpenerima.Enabled = True
        txtkotapenerima.Enabled = True
        txtprovinsipenerima.Enabled = True
        txtkodepospenerima.Enabled = True
        txthppenerima.Enabled = True

        txtnamapengirim.Enabled = True
        txtalamatpengirim.Enabled = True
        txthppengirim.Enabled = True

        clear_btn.Enabled = True
        load_btn.Enabled = True
        save_btn.Enabled = True
        ID_btn.Enabled = True
        scan_btn.Enabled = True
        combotujuan.Enabled = True

        Timer1.Start()
        Timer2.Stop()
        Timer3.Start()

        'txtrfid.Enabled = False
        'txtread.Enabled = False

        'txtIDpaket.Enabled = False

        'txtnamapenerima.Enabled = False
        'txtalamatpenerima.Enabled = False
        'txtkecpenerima.Enabled = False
        'txtkotapenerima.Enabled = False
        'txtprovinsipenerima.Enabled = False
        'txtkodepospenerima.Enabled = False
        'txthppenerima.Enabled = False

        'txtnamapengirim.Enabled = False
        'txtalamatpengirim.Enabled = False
        'txthppengirim.Enabled = False

        'clear_btn.Enabled = False
        'load_btn.Enabled = False
        'save_btn.Enabled = False
        'ID_btn.Enabled = False
        'scan_btn.Enabled = False

        'combotujuan.Enabled = False
        comport = Form_Login.SerialPort1.PortName
        SerialPort1.PortName = comport
        'SerialPort1.BaudRate = 9600
        'SerialPort1.DataBits = 8
        'SerialPort1.Parity = Parity.None
        'SerialPort1.StopBits = StopBits.One
        'SerialPort1.Handshake = Handshake.None
        'SerialPort1.Encoding = System.Text.Encoding.Default
        'SerialPort1.RtsEnable = True

        SerialPort1.Open()
        AddHandler SerialPort1.DataReceived, AddressOf SerialPort1_DataReceived1

    End Sub

    Private Sub combotujuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combotujuan.SelectedIndexChanged
        If (combotujuan.SelectedItem = "Luar Provinsi ") Then
            combopemilah.Enabled = True
        Else
            combopemilah.Enabled = False
        End If
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        lblcomp.Visible = True
        lblcomp.Text = ""
        Timer2.Start()
        Dim ID As String
        Dim DataPengirim As String
        Dim DataPenerima As String
        Dim Tujuan As String

        ID = txtIDpaket.Text
        DataPenerima = txtnamapenerima.Text + "|" + txtalamatpenerima.Text + "|" + txtkecpenerima.Text + "|" + txtkotapenerima.Text + "|" + txtprovinsipenerima.Text + "|" + txtkodepospenerima.Text + "|" + txthppenerima.Text
        DataPengirim = txtnamapengirim.Text + "|" + txtalamatpengirim.Text + "|" + txthppengirim.Text
        'Jika yang dipilih hanya combotujuan tanpa combopemilah, maka combopemilah.selectedindex = -1
        'If (combopemilah.SelectedIndex = -1) Then
        '    combopemilah.SelectedIndex = 4
        'End If
        Tujuan = combotujuan.SelectedIndex.ToString + combopemilah.SelectedIndex.ToString

        ProgressBar1.Value = 100

        SerialPort1.Write("*" + ID)
        SerialPort1.Write("#" + DataPenerima)
        SerialPort1.Write("#" + DataPengirim)
        SerialPort1.Write("#" + Tujuan + ".")
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        clear()
        SerialPort1.Write("%")
        Timer3.Start()
    End Sub

    Private Sub clear()
        receivedData = ""

        txtrfid.Text = ""
        txtIDpaket.Text = ""
        txtnamapenerima.Text = ""
        txtalamatpenerima.Text = ""
        txtkecpenerima.Text = ""
        txtkotapenerima.Text = ""
        txtprovinsipenerima.Text = ""
        txtkodepospenerima.Text = ""
        txthppenerima.Text = ""

        txtread.Text = ""
        txtnamapengirim.Text = ""
        txtalamatpengirim.Text = ""
        txthppengirim.Text = ""
        combotujuan.SelectedIndex = -1
        combopemilah.SelectedIndex = -1
        ProgressBar1.Value = 0
        lblcomp.Visible = False
        Timer2.Stop()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label17.Text = day + ", " + tanggal
        Label18.Text = DateTime.Now.ToString("HH : mm : ss")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblcomp.Text = "Saving Data"
        lblcomp.Visible = Not lblcomp.Visible
    End Sub

    Private Sub load_btn_Click(sender As Object, e As EventArgs) Handles load_btn.Click
        'txtread.Text = ""
        'SerialPort1.Write("&")
    End Sub

    Private Sub SerialPort1_DataReceived1(sender As Object, e As SerialDataReceivedEventArgs)
        receivedData = ""
        Try
            If SerialPort1.IsOpen Then
                receivedData &= SerialPort1.ReadTo("#")
                If receivedData.Contains("OK") Then
                    Timer2.Stop()
                    Me.Invoke(New EventHandler(AddressOf datacomplete))
                ElseIf receivedData.Contains("ID") Then
                    Me.Invoke(New EventHandler(AddressOf dataid))
                ElseIf receivedData.Contains("Datae") Then
                    Me.Invoke(New EventHandler(AddressOf datarfid))
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtnamapenerima.Text = "Bambang Pamungkas Prayitno"
        txtalamatpenerima.Text = "Jalan Ikan Lumba-lumba Gang VIIC nomor 56, Tukang kayu"
        txtkecpenerima.Text = "Krembangan"
        txtkotapenerima.Text = "Kota Jember"
        txtprovinsipenerima.Text = "Provinsi Jawa Timur"
        txtkodepospenerima.Text = "98324"
        txthppenerima.Text = "082234044089"

        txtnamapengirim.Text = "Benny Manurung"
        txtalamatpengirim.Text = "Jalan Benowo Gang VI/35, Surabaya"
        txthppengirim.Text = "082241240192"
    End Sub

    Private Sub datacomplete(sender As Object, e As EventArgs)
        lblcomp.Visible = True
        lblcomp.Text = ""
        lblcomp.Text = "Completed"
    End Sub

    Private Sub scan_btn_Click(sender As Object, e As EventArgs) Handles scan_btn.Click
        'txtrfid.Text = ""
        'id(1) = ""
        'SerialPort1.Write("@")
        'If IDError = 1 Then
        '    SerialPort1.BaudRate = 115200
        '    System.Threading.Thread.Sleep(1000)
        '    SerialPort1.BaudRate = 9600
        '    System.Threading.Thread.Sleep(1000)
        '    IDError = 0
        'End If
    End Sub

    Private Sub dataid()
        Array.Clear(id, 0, id.Length)
        id = Split(receivedData, "|")
        If id(1) = "" Then
        Else
            Timer3.Stop()
            txtrfid.Text = id(1)
            delayy(2)
            txtread.Text = ""
            SerialPort1.Write("&")
        End If
        'If id(1).Contains("Error") Then
        '    IDError = 1
        'End If
    End Sub

    Private Sub ID_btn_Click(sender As Object, e As EventArgs) Handles ID_btn.Click
        k = k + 1
        If k > 9 Then
            k = 1
        End If
        txtIDpaket.Text = id(1) + DateTime.Now.ToString("HHmmss") + k.ToString
    End Sub

    Private Sub datarfid(sender As Object, e As EventArgs)
        Dim tuju As String = ""
        data = Split(receivedData, "|")
        txtread.Text = ""
        txtread.Text = receivedData.ToString
        If data(12) = "-1-1" Then
            tuju = "Tanpa Tujuan"
        ElseIf data(12) = "0-1" Then
            tuju = "Dalam Kota"
        ElseIf data(12) = "1-1" Then
            tuju = "Luar Kota Dalam Provinsi"
        ElseIf data(12) = "20" Then
            tuju = "Luar Provinsi Dalam Pulau"
        ElseIf data(12) = "21" Then
            tuju = "Luar Provinsi Luar Pulau"
        ElseIf data(12) = "22" Then
            tuju = "Luar Negeri"
        Else
            tuju = "Error"
        End If
        'txtread.Text = receivedData
        txtread.Text = "ID : " + data(1) + vbCrLf +
        "Nama Pengirim : " + data(2) + vbCrLf +
        "Alamat Pengirim : " + data(3) + vbCrLf +
        "Hp Pengirim : " + data(4) + vbCrLf + vbCrLf +
        "Nama Penerima : " + data(5) + vbCrLf +
        "Alamat Penerima : " + data(6) + vbCrLf +
        "Kecamatan Pengirim : " + data(7) + vbCrLf +
        "Kota Penerima : " + data(8) + vbCrLf +
        "Provinsi Penerima : " + data(9) + vbCrLf +
        "Kodepos Pengirim : " + data(10) + vbCrLf +
        "Hp Pengirim : " + data(11) + vbCrLf +
        "Tujuan Barang : " + tuju + vbCrLf
    End Sub

    Private Sub comboport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboport.SelectedIndexChanged
        '    txtpass.Text = ""
        '    If (comboport.SelectedItem <> "") Then
        '        comport = comboport.SelectedItem
        '    End If
    End Sub

    Private Sub connect_btn_Click(sender As Object, e As EventArgs) Handles connect_btn.Click
        '    If (connect_btn.Text = "CONNECT") Then
        '        Try
        '            If comport <> "" Then
        '                If txtpass.Text = pass Then
        '                    SerialPort1.Close()
        '                    SerialPort1.PortName = comport
        '                    SerialPort1.BaudRate = 9600
        '                    SerialPort1.DataBits = 8
        '                    SerialPort1.Parity = Parity.None
        '                    SerialPort1.StopBits = StopBits.One
        '                    SerialPort1.Handshake = Handshake.None
        '                    SerialPort1.Encoding = System.Text.Encoding.Default
        '                    SerialPort1.RtsEnable = True

        '                    SerialPort1.Open()
        '                    AddHandler SerialPort1.DataReceived, AddressOf SerialPort1_DataReceived1

        '                    connect_btn.Text = "DISCONNECT"
        '                    txtpass.Text = ""
        '                    txtpass.Enabled = False
        '                    refresh_btn.Enabled = False
        '                    comboport.Enabled = False

        '                    txtrfid.Enabled = True
        '                    txtread.Enabled = True

        '                    txtIDpaket.Enabled = True

        '                    txtnamapenerima.Enabled = True
        '                    txtalamatpenerima.Enabled = True
        '                    txtkecpenerima.Enabled = True
        '                    txtkotapenerima.Enabled = True
        '                    txtprovinsipenerima.Enabled = True
        '                    txtkodepospenerima.Enabled = True
        '                    txthppenerima.Enabled = True

        '                    txtnamapengirim.Enabled = True
        '                    txtalamatpengirim.Enabled = True
        '                    txthppengirim.Enabled = True

        '                    clear_btn.Enabled = True
        '                    load_btn.Enabled = True
        '                    save_btn.Enabled = True
        '                    ID_btn.Enabled = True
        '                    scan_btn.Enabled = True
        '                    combotujuan.Enabled = True

        '                    combotujuan.Items.Add("Dalam Kota")
        '                    combotujuan.Items.Add("Luar Kota Dalam Provinsi")
        '                    combotujuan.Items.Add("Luar Provinsi ")

        '                    combopemilah.Items.Add("Dalam Pulau")
        '                    combopemilah.Items.Add("Luar Pulau")
        '                    combopemilah.Items.Add("Luar Negeri")

        '                Else
        '                    MessageBox.Show("Error : Invalid password!")
        '                End If
        '            Else
        '                MsgBox("Select a COM port!")
        '            End If
        '        Catch ex As Exception
        '            MsgBox("Comport Error", vbOKOnly, "Warning")
        '        End Try
        '    ElseIf (connect_btn.Text = "DISCONNECT") Then
        '        Try
        '            If SerialPort1.IsOpen Then
        '                combotujuan.Items.Clear()
        '                combopemilah.Items.Clear()

        '                txtrfid.Enabled = False
        '                txtread.Enabled = False

        '                txtIDpaket.Enabled = False

        '                txtnamapenerima.Enabled = False
        '                txtalamatpenerima.Enabled = False
        '                txtkecpenerima.Enabled = False
        '                txtkotapenerima.Enabled = False
        '                txtprovinsipenerima.Enabled = False
        '                txtkodepospenerima.Enabled = False
        '                txthppenerima.Enabled = False

        '                txtnamapengirim.Enabled = False
        '                txtalamatpengirim.Enabled = False
        '                txthppengirim.Enabled = False

        '                clear_btn.Enabled = False
        '                load_btn.Enabled = False
        '                save_btn.Enabled = False
        '                ID_btn.Enabled = False
        '                scan_btn.Enabled = False
        '                combotujuan.Enabled = False
        '                combopemilah.Enabled = False

        '                clear()
        '                SerialPort1.Close()
        '                SerialPort1.Dispose()
        '                comboport.SelectedIndex = -1
        '                refresh_btn.Enabled = True
        '                txtpass.Enabled = True
        '                comboport.Enabled = True
        '                connect_btn.Text = "CONNECT"
        '            End If
        '        Catch ex As Exception
        '            MsgBox("Comport Error", vbOKOnly, "Warning")
        '        End Try
        '    End If
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        '    comport = ""
        '    comboport.Items.Clear()
        '    For Each SerialPortCom As String In My.Computer.Ports.SerialPortNames
        '        comboport.Items.Add(SerialPortCom)
        '    Next
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        '        txtrfid.Text = ""
        '        id(1) = ""
        SerialPort1.Write("@")
    End Sub
End Class