Imports System
Imports System.IO.Ports

Public Class Form_Login
    Dim pass As String
    Dim comportt As String
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pass = "12345"
        comportt = ""

        For Each SerialPortCom As String In My.Computer.Ports.SerialPortNames
            comboport.Items.Add(SerialPortCom)
        Next
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        If (login_btn.Text = "LOGIN") Then
            Try
                If (comportt <> "") Then
                    SerialPort1.Close()
                    SerialPort1.PortName = comportt
                    SerialPort1.BaudRate = 9600
                    SerialPort1.DataBits = 8
                    SerialPort1.Parity = Parity.None
                    SerialPort1.StopBits = StopBits.One
                    SerialPort1.Handshake = Handshake.None
                    SerialPort1.Encoding = System.Text.Encoding.Default
                    SerialPort1.RtsEnable = True

                    'SerialPort1.Open()

                    If txtpass.Text = pass Then
                        Me.Hide()
                        Form_Main.Show()
                    Else
                        MessageBox.Show("Error : Invalid password!")
                    End If

                Else
                    MsgBox("Select a COM port!")
                End If
            Catch ex As Exception
                MsgBox("Comport Error", vbOKOnly, "Warning")
            End Try

        Else
            SerialPort1.Close()
            '            login_btn.Text = ""
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboport.SelectedIndexChanged
        txtpass.Text = ""
        If (comboport.SelectedItem <> "") Then
            comportt = comboport.SelectedItem
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        txtpass.Text = ""
        comboport.Items.Clear()
        For Each SerialPortCom As String In My.Computer.Ports.SerialPortNames
            comboport.Items.Add(SerialPortCom)
        Next
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
        SerialPort1.Close()
    End Sub
End Class