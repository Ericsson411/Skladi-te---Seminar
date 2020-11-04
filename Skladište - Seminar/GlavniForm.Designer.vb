<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GlavniForm
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
        Me.id_listbox = New System.Windows.Forms.ListBox()
        Me.naziv_listbox = New System.Windows.Forms.ListBox()
        Me.proizvodac_listbox = New System.Windows.Forms.ListBox()
        Me.search_textbox = New System.Windows.Forms.TextBox()
        Me.lager_listBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.proizvodaci_checkBox = New System.Windows.Forms.CheckBox()
        Me.proizvodaci_comboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.red_listbox = New System.Windows.Forms.ListBox()
        Me.paleta_listbox = New System.Windows.Forms.ListBox()
        Me.skladiste_listbox = New System.Windows.Forms.ListBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dodajArtikalbotun = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'id_listbox
        '
        Me.id_listbox.FormattingEnabled = True
        Me.id_listbox.Location = New System.Drawing.Point(12, 75)
        Me.id_listbox.Name = "id_listbox"
        Me.id_listbox.Size = New System.Drawing.Size(67, 355)
        Me.id_listbox.TabIndex = 0
        '
        'naziv_listbox
        '
        Me.naziv_listbox.FormattingEnabled = True
        Me.naziv_listbox.Location = New System.Drawing.Point(78, 75)
        Me.naziv_listbox.Name = "naziv_listbox"
        Me.naziv_listbox.Size = New System.Drawing.Size(120, 355)
        Me.naziv_listbox.TabIndex = 1
        '
        'proizvodac_listbox
        '
        Me.proizvodac_listbox.FormattingEnabled = True
        Me.proizvodac_listbox.Location = New System.Drawing.Point(197, 75)
        Me.proizvodac_listbox.Name = "proizvodac_listbox"
        Me.proizvodac_listbox.Size = New System.Drawing.Size(120, 355)
        Me.proizvodac_listbox.TabIndex = 2
        '
        'search_textbox
        '
        Me.search_textbox.Location = New System.Drawing.Point(12, 27)
        Me.search_textbox.Name = "search_textbox"
        Me.search_textbox.Size = New System.Drawing.Size(156, 20)
        Me.search_textbox.TabIndex = 3
        '
        'lager_listBox
        '
        Me.lager_listBox.FormattingEnabled = True
        Me.lager_listBox.Location = New System.Drawing.Point(669, 75)
        Me.lager_listBox.Name = "lager_listBox"
        Me.lager_listBox.Size = New System.Drawing.Size(49, 355)
        Me.lager_listBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID artikla"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Naziv artikla"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(197, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Proizvođač"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.Location = New System.Drawing.Point(372, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 73)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "UREDI"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'proizvodaci_checkBox
        '
        Me.proizvodaci_checkBox.AutoSize = True
        Me.proizvodaci_checkBox.Location = New System.Drawing.Point(324, 443)
        Me.proizvodaci_checkBox.Name = "proizvodaci_checkBox"
        Me.proizvodaci_checkBox.Size = New System.Drawing.Size(15, 14)
        Me.proizvodaci_checkBox.TabIndex = 10
        Me.proizvodaci_checkBox.UseVisualStyleBackColor = True
        '
        'proizvodaci_comboBox
        '
        Me.proizvodaci_comboBox.FormattingEnabled = True
        Me.proizvodaci_comboBox.Location = New System.Drawing.Point(203, 438)
        Me.proizvodaci_comboBox.Name = "proizvodaci_comboBox"
        Me.proizvodaci_comboBox.Size = New System.Drawing.Size(109, 21)
        Me.proizvodaci_comboBox.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Pretraživanje"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button2.Location = New System.Drawing.Point(372, 169)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 73)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "DODAJ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button3.Location = New System.Drawing.Point(372, 264)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 73)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "IZBRIŠI"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(385, 433)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 34)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Dodaj proizvođača"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'red_listbox
        '
        Me.red_listbox.FormattingEnabled = True
        Me.red_listbox.Location = New System.Drawing.Point(586, 75)
        Me.red_listbox.Name = "red_listbox"
        Me.red_listbox.Size = New System.Drawing.Size(49, 355)
        Me.red_listbox.TabIndex = 17
        '
        'paleta_listbox
        '
        Me.paleta_listbox.FormattingEnabled = True
        Me.paleta_listbox.Location = New System.Drawing.Point(634, 75)
        Me.paleta_listbox.Name = "paleta_listbox"
        Me.paleta_listbox.Size = New System.Drawing.Size(36, 355)
        Me.paleta_listbox.TabIndex = 18
        '
        'skladiste_listbox
        '
        Me.skladiste_listbox.FormattingEnabled = True
        Me.skladiste_listbox.Location = New System.Drawing.Point(520, 75)
        Me.skladiste_listbox.Name = "skladiste_listbox"
        Me.skladiste_listbox.Size = New System.Drawing.Size(67, 355)
        Me.skladiste_listbox.TabIndex = 20
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(517, 59)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(50, 13)
        Me.label5.TabIndex = 21
        Me.label5.Text = "Skladište"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(578, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Regal/Red"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(636, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Paleta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(681, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Lager"
        '
        'dodajArtikalbotun
        '
        Me.dodajArtikalbotun.Location = New System.Drawing.Point(15, 439)
        Me.dodajArtikalbotun.Name = "dodajArtikalbotun"
        Me.dodajArtikalbotun.Size = New System.Drawing.Size(132, 23)
        Me.dodajArtikalbotun.TabIndex = 25
        Me.dodajArtikalbotun.Text = "Dodaj artikal"
        Me.dodajArtikalbotun.UseVisualStyleBackColor = True
        '
        'GlavniForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 492)
        Me.Controls.Add(Me.dodajArtikalbotun)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.skladiste_listbox)
        Me.Controls.Add(Me.paleta_listbox)
        Me.Controls.Add(Me.red_listbox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.proizvodaci_comboBox)
        Me.Controls.Add(Me.proizvodaci_checkBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lager_listBox)
        Me.Controls.Add(Me.search_textbox)
        Me.Controls.Add(Me.proizvodac_listbox)
        Me.Controls.Add(Me.naziv_listbox)
        Me.Controls.Add(Me.id_listbox)
        Me.Name = "GlavniForm"
        Me.Text = "Skladište"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents id_listbox As ListBox
    Friend WithEvents naziv_listbox As ListBox
    Friend WithEvents proizvodac_listbox As ListBox
    Friend WithEvents search_textbox As TextBox
    Friend WithEvents lager_listBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents proizvodaci_checkBox As CheckBox
    Friend WithEvents proizvodaci_comboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents red_listbox As ListBox
    Friend WithEvents paleta_listbox As ListBox
    Friend WithEvents skladiste_listbox As ListBox
    Friend WithEvents label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dodajArtikalbotun As Button
End Class
