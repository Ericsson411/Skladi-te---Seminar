<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DodajForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.id_kod = New System.Windows.Forms.TextBox()
        Me.regal_red = New System.Windows.Forms.TextBox()
        Me.naziv_artikla = New System.Windows.Forms.TextBox()
        Me.proizvodac = New System.Windows.Forms.ComboBox()
        Me.paleta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lager = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.skladiste = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Regal / Red"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Bar kod"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Proizvođač"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Naziv artikla"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Dodaj"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'id_kod
        '
        Me.id_kod.Location = New System.Drawing.Point(24, 51)
        Me.id_kod.Name = "id_kod"
        Me.id_kod.Size = New System.Drawing.Size(125, 20)
        Me.id_kod.TabIndex = 14
        '
        'regal_red
        '
        Me.regal_red.Location = New System.Drawing.Point(203, 118)
        Me.regal_red.Name = "regal_red"
        Me.regal_red.Size = New System.Drawing.Size(125, 20)
        Me.regal_red.TabIndex = 13
        '
        'naziv_artikla
        '
        Me.naziv_artikla.Location = New System.Drawing.Point(24, 93)
        Me.naziv_artikla.Name = "naziv_artikla"
        Me.naziv_artikla.Size = New System.Drawing.Size(125, 20)
        Me.naziv_artikla.TabIndex = 11
        '
        'proizvodac
        '
        Me.proizvodac.FormattingEnabled = True
        Me.proizvodac.Location = New System.Drawing.Point(22, 132)
        Me.proizvodac.Name = "proizvodac"
        Me.proizvodac.Size = New System.Drawing.Size(127, 21)
        Me.proizvodac.TabIndex = 21
        '
        'paleta
        '
        Me.paleta.Location = New System.Drawing.Point(203, 158)
        Me.paleta.Name = "paleta"
        Me.paleta.Size = New System.Drawing.Size(125, 20)
        Me.paleta.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(203, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Lager"
        '
        'lager
        '
        Me.lager.Location = New System.Drawing.Point(203, 200)
        Me.lager.Name = "lager"
        Me.lager.Size = New System.Drawing.Size(125, 20)
        Me.lager.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(203, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Paleta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(200, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Skladište"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(200, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 27
        '
        'skladiste
        '
        Me.skladiste.FormattingEnabled = True
        Me.skladiste.Location = New System.Drawing.Point(200, 77)
        Me.skladiste.Name = "skladiste"
        Me.skladiste.Size = New System.Drawing.Size(128, 21)
        Me.skladiste.TabIndex = 29
        '
        'DodajForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 284)
        Me.Controls.Add(Me.skladiste)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lager)
        Me.Controls.Add(Me.paleta)
        Me.Controls.Add(Me.proizvodac)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.id_kod)
        Me.Controls.Add(Me.regal_red)
        Me.Controls.Add(Me.naziv_artikla)
        Me.Name = "DodajForm"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents id_kod As TextBox
    Friend WithEvents regal_red As TextBox
    Friend WithEvents naziv_artikla As TextBox
    Friend WithEvents proizvodac As ComboBox
    Friend WithEvents paleta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lager As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents skladiste As ComboBox
End Class
