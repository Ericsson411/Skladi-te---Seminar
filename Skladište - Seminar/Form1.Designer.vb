<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dodajArtikal
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
        Me.proizvodac = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_kod = New System.Windows.Forms.TextBox()
        Me.naziv_artikla = New System.Windows.Forms.TextBox()
        Me.dodaj = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'proizvodac
        '
        Me.proizvodac.FormattingEnabled = True
        Me.proizvodac.Location = New System.Drawing.Point(10, 124)
        Me.proizvodac.Name = "proizvodac"
        Me.proizvodac.Size = New System.Drawing.Size(127, 21)
        Me.proizvodac.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Bar kod"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Proizvođač"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Naziv artikla"
        '
        'id_kod
        '
        Me.id_kod.Location = New System.Drawing.Point(12, 43)
        Me.id_kod.Name = "id_kod"
        Me.id_kod.Size = New System.Drawing.Size(125, 20)
        Me.id_kod.TabIndex = 23
        '
        'naziv_artikla
        '
        Me.naziv_artikla.Location = New System.Drawing.Point(12, 85)
        Me.naziv_artikla.Name = "naziv_artikla"
        Me.naziv_artikla.Size = New System.Drawing.Size(125, 20)
        Me.naziv_artikla.TabIndex = 22
        '
        'dodaj
        '
        Me.dodaj.Location = New System.Drawing.Point(28, 161)
        Me.dodaj.Name = "dodaj"
        Me.dodaj.Size = New System.Drawing.Size(75, 23)
        Me.dodaj.TabIndex = 28
        Me.dodaj.Text = "Dodaj"
        Me.dodaj.UseVisualStyleBackColor = True
        '
        'dodajArtikal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(171, 196)
        Me.Controls.Add(Me.dodaj)
        Me.Controls.Add(Me.proizvodac)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.id_kod)
        Me.Controls.Add(Me.naziv_artikla)
        Me.Name = "dodajArtikal"
        Me.Text = "Dodaj Artikal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents proizvodac As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents id_kod As TextBox
    Friend WithEvents naziv_artikla As TextBox
    Friend WithEvents dodaj As Button
End Class
