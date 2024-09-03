<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.comboport = New System.Windows.Forms.ComboBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Com Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(136, 60)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(100, 26)
        Me.txtpass.TabIndex = 2
        '
        'comboport
        '
        Me.comboport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboport.FormattingEnabled = True
        Me.comboport.Location = New System.Drawing.Point(136, 22)
        Me.comboport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.comboport.Name = "comboport"
        Me.comboport.Size = New System.Drawing.Size(100, 28)
        Me.comboport.TabIndex = 3
        '
        'login_btn
        '
        Me.login_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.Location = New System.Drawing.Point(24, 96)
        Me.login_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(108, 44)
        Me.login_btn.TabIndex = 4
        Me.login_btn.Text = "LOGIN"
        Me.login_btn.UseVisualStyleBackColor = True
        '
        'refresh_btn
        '
        Me.refresh_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_btn.Location = New System.Drawing.Point(132, 96)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(108, 44)
        Me.refresh_btn.TabIndex = 5
        Me.refresh_btn.Text = "REFRESH"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'exit_btn
        '
        Me.exit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_btn.Location = New System.Drawing.Point(24, 144)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(216, 48)
        Me.exit_btn.TabIndex = 6
        Me.exit_btn.Text = "EXIT"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 214)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.comboport)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents comboport As System.Windows.Forms.ComboBox
    Friend WithEvents login_btn As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents refresh_btn As System.Windows.Forms.Button
    Friend WithEvents exit_btn As System.Windows.Forms.Button
End Class
