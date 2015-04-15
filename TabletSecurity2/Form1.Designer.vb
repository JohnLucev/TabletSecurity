<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtV710 = New System.Windows.Forms.TextBox()
        Me.lblV710 = New System.Windows.Forms.Label()
        Me.lblV712 = New System.Windows.Forms.Label()
        Me.txtV712 = New System.Windows.Forms.TextBox()
        Me.lblV714 = New System.Windows.Forms.Label()
        Me.txtV714 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblWetness = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.BtnRequest = New System.Windows.Forms.Button()
        Me.ReqComplete = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ClientAceDA_Junction1 = New Kepware.ClientAce.DA_Junction.ClientAceDA_Junction()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        CType(Me.ClientAceDA_Junction1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtV710
        '
        Me.txtV710.Location = New System.Drawing.Point(83, 24)
        Me.txtV710.Name = "txtV710"
        Me.txtV710.Size = New System.Drawing.Size(82, 20)
        Me.txtV710.TabIndex = 0
        '
        'lblV710
        '
        Me.lblV710.AutoSize = True
        Me.lblV710.Location = New System.Drawing.Point(38, 28)
        Me.lblV710.Name = "lblV710"
        Me.lblV710.Size = New System.Drawing.Size(32, 13)
        Me.lblV710.TabIndex = 1
        Me.lblV710.Text = "V710"
        '
        'lblV712
        '
        Me.lblV712.AutoSize = True
        Me.lblV712.Location = New System.Drawing.Point(38, 68)
        Me.lblV712.Name = "lblV712"
        Me.lblV712.Size = New System.Drawing.Size(32, 13)
        Me.lblV712.TabIndex = 3
        Me.lblV712.Text = "V712"
        '
        'txtV712
        '
        Me.txtV712.Location = New System.Drawing.Point(83, 64)
        Me.txtV712.Name = "txtV712"
        Me.txtV712.Size = New System.Drawing.Size(82, 20)
        Me.txtV712.TabIndex = 2
        '
        'lblV714
        '
        Me.lblV714.AutoSize = True
        Me.lblV714.Location = New System.Drawing.Point(38, 107)
        Me.lblV714.Name = "lblV714"
        Me.lblV714.Size = New System.Drawing.Size(32, 13)
        Me.lblV714.TabIndex = 5
        Me.lblV714.Text = "V714"
        '
        'txtV714
        '
        Me.txtV714.Location = New System.Drawing.Point(83, 103)
        Me.txtV714.Name = "txtV714"
        Me.txtV714.Size = New System.Drawing.Size(82, 20)
        Me.txtV714.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 184)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(83, 20)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(83, 222)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(86, 20)
        Me.TextBox2.TabIndex = 7
        '
        'lblWetness
        '
        Me.lblWetness.AutoSize = True
        Me.lblWetness.Location = New System.Drawing.Point(12, 191)
        Me.lblWetness.Name = "lblWetness"
        Me.lblWetness.Size = New System.Drawing.Size(49, 13)
        Me.lblWetness.TabIndex = 8
        Me.lblWetness.Text = "Wetness"
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(12, 229)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(34, 13)
        Me.lblTemp.TabIndex = 9
        Me.lblTemp.Text = "Temp"
        '
        'BtnRequest
        '
        Me.BtnRequest.Location = New System.Drawing.Point(83, 305)
        Me.BtnRequest.Name = "BtnRequest"
        Me.BtnRequest.Size = New System.Drawing.Size(89, 28)
        Me.BtnRequest.TabIndex = 10
        Me.BtnRequest.Text = "Request"
        Me.BtnRequest.UseVisualStyleBackColor = True
        '
        'ReqComplete
        '
        Me.ReqComplete.Location = New System.Drawing.Point(250, 305)
        Me.ReqComplete.Name = "ReqComplete"
        Me.ReqComplete.Size = New System.Drawing.Size(100, 28)
        Me.ReqComplete.TabIndex = 11
        Me.ReqComplete.Text = "RequestComplete"
        Me.ReqComplete.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'ClientAceDA_Junction1
        '
        Me.ClientAceDA_Junction1.AutoAddedServers = New String() {resources.GetString("ClientAceDA_Junction1.AutoAddedServers")}
        Me.ClientAceDA_Junction1.BackColorError = System.Drawing.Color.Red
        Me.ClientAceDA_Junction1.BackColorQualityBad = System.Drawing.Color.Red
        Me.ClientAceDA_Junction1.ClientAceConfiguration = "Click here to open configuration"
        Me.ClientAceDA_Junction1.Config = resources.GetString("ClientAceDA_Junction1.Config")
        Me.ClientAceDA_Junction1.DefaultUpdateRate = 1000
        Me.ClientAceDA_Junction1.Parent = Me
        Me.ClientAceDA_Junction1.ShowTimestampInTooltip = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(349, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(349, 122)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(90, 20)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(349, 179)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(91, 20)
        Me.TextBox4.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(349, 263)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(90, 20)
        Me.TextBox5.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 406)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReqComplete)
        Me.Controls.Add(Me.BtnRequest)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.lblWetness)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblV714)
        Me.Controls.Add(Me.txtV714)
        Me.Controls.Add(Me.lblV712)
        Me.Controls.Add(Me.txtV712)
        Me.Controls.Add(Me.lblV710)
        Me.Controls.Add(Me.txtV710)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ClientAceDA_Junction1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtV710 As System.Windows.Forms.TextBox
    Friend WithEvents lblV710 As System.Windows.Forms.Label
    Friend WithEvents lblV712 As System.Windows.Forms.Label
    Friend WithEvents txtV712 As System.Windows.Forms.TextBox
    Friend WithEvents lblV714 As System.Windows.Forms.Label
    Friend WithEvents txtV714 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblWetness As System.Windows.Forms.Label
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents BtnRequest As System.Windows.Forms.Button
    Friend WithEvents ReqComplete As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents ClientAceDA_Junction1 As Kepware.ClientAce.DA_Junction.ClientAceDA_Junction
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox

End Class
