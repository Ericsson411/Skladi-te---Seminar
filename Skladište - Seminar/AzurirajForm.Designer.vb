<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AzurirajForm
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
        Me.naziv_artikla = New System.Windows.Forms.TextBox()
        Me.lager = New System.Windows.Forms.TextBox()
        Me.id_kod = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.proizvodaci_combobox = New System.Windows.Forms.ComboBox()
        Me.skladiste = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.paleta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.regal_red = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.skladiste_listbox = New System.Windows.Forms.ListBox()
        Me.paleta_listbox = New System.Windows.Forms.ListBox()
        Me.red_listbox = New System.Windows.Forms.ListBox()
        Me.lager_listBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'naziv_artikla
        '
        Me.naziv_artikla.Location = New System.Drawing.Point(18, 88)
        Me.naziv_artikla.Name = "naziv_artikla"
        Me.naziv_artikla.Size = New System.Drawing.Size(125, 20)
        Me.naziv_artikla.TabIndex = 0
        '
        'lager
        '
        Me.lager.Location = New System.Drawing.Point(18, 319)
        Me.lager.Name = "lager"
        Me.lager.Size = New System.Drawing.Size(125, 20)
        Me.lager.TabIndex = 2
        '
        'id_kod
        '
        Me.id_kod.Location = New System.Drawing.Point(18, 44)
        Me.id_kod.Name = "id_kod"
        Me.id_kod.Size = New System.Drawing.Size(125, 20)
        Me.id_kod.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ažuriraj"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Naziv artikla"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Proizvođač"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Bar kod"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Lager"
        '
        'proizvodaci_combobox
        '
        Me.proizvodaci_combobox.FormattingEnabled = True
        Me.proizvodaci_combobox.Location = New System.Drawing.Point(18, 136)
        Me.proizvodaci_combobox.Name = "proizvodaci_combobox"
        Me.proizvodaci_combobox.Size = New System.Drawing.Size(121, 21)
        Me.proizvodaci_combobox.TabIndex = 11
        '
        'skladiste
        '
        Me.skladiste.FormattingEnabled = True
        Me.skladiste.Location = New System.Drawing.Point(18, 187)
        Me.skladiste.Name = "skladiste"
        Me.skladiste.Size = New System.Drawing.Size(121, 21)
        Me.skladiste.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Skladište"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Paleta"
        '
        'paleta
        '
        Me.paleta.Location = New System.Drawing.Point(18, 271)
        Me.paleta.Name = "paleta"
        Me.paleta.Size = New System.Drawing.Size(125, 20)
        Me.paleta.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Regal / Red"
        '
        'regal_red
        '
        Me.regal_red.Location = New System.Drawing.Point(18, 231)
        Me.regal_red.Name = "regal_red"
        Me.regal_red.Size = New System.Drawing.Size(125, 20)
        Me.regal_red.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(365, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Lager"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(320, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Paleta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(262, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Regal/Red"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(201, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Skladište"
        '
        'skladiste_listbox
        '
        Me.skladiste_listbox.FormattingEnabled = True
        Me.skladiste_listbox.Location = New System.Drawing.Point(204, 44)
        Me.skladiste_listbox.Name = "skladiste_listbox"
        Me.skladiste_listbox.Size = New System.Drawing.Size(67, 303)
        Me.skladiste_listbox.TabIndex = 41
        '
        'paleta_listbox
        '
        Me.paleta_listbox.FormattingEnabled = True
        Me.paleta_listbox.Location = New System.Drawing.Point(318, 44)
        Me.paleta_listbox.Name = "paleta_listbox"
        Me.paleta_listbox.Size = New System.Drawing.Size(36, 303)
        Me.paleta_listbox.TabIndex = 40
        '
        'red_listbox
        '
        Me.red_listbox.FormattingEnabled = True
        Me.red_listbox.Location = New System.Drawing.Point(270, 44)
        Me.red_listbox.Name = "red_listbox"
        Me.red_listbox.Size = New System.Drawing.Size(49, 303)
        Me.red_listbox.TabIndex = 39
        '
        'lager_listBox
        '
        Me.lager_listBox.FormattingEnabled = True
        Me.lager_listBox.Location = New System.Drawing.Point(353, 44)
        Me.lager_listBox.Name = "lager_listBox"
        Me.lager_listBox.Size = New System.Drawing.Size(49, 303)
        Me.lager_listBox.TabIndex = 38
        '
        'AzurirajForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 410)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.skladiste_listbox)
        Me.Controls.Add(Me.paleta_listbox)
        Me.Controls.Add(Me.red_listbox)
        Me.Controls.Add(Me.lager_listBox)
        Me.Controls.Add(Me.skladiste)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.paleta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.regal_red)
        Me.Controls.Add(Me.proizvodaci_combobox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.id_kod)
        Me.Controls.Add(Me.lager)
        Me.Controls.Add(Me.naziv_artikla)
        Me.Name = "AzurirajForm"
        Me.Text = "Ažuriraj"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents naziv_artikla As TextBox
    Friend WithEvents lager As TextBox
    Friend WithEvents id_kod As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents proizvodaci_combobox As ComboBox
    Friend WithEvents skladiste As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents paleta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents regal_red As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents skladiste_listbox As ListBox
    Friend WithEvents paleta_listbox As ListBox
    Friend WithEvents red_listbox As ListBox
    Friend WithEvents lager_listBox As ListBox
End Class
