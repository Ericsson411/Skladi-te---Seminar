Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient



Public Class DodajForm

    Dim connStr As String = "server=remotemysql.com;user=VcLM9jz5zd;database=VcLM9jz5zd;port=3306;password=nOIVOaRp3c;"
    Dim conn As New MySqlConnection(connStr)
    Dim popisProizvodaca As DataTable = New DataTable
    Dim popisSkladista As DataTable = New DataTable
    Public Property odabraniId As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If id_kod.Text <> "" And naziv_artikla.Text <> "" And regal_red.Text <> "" Then

            Dim cmd2 As MySqlCommand = conn.CreateCommand

            cmd2.CommandText = "INSERT INTO lager(id_artikla,id_skladista,lager,paleta,regal_red) VALUES('" & Convert.ToInt16(id_kod.Text) & "','" & skladiste.SelectedValue & "','" & Convert.ToDecimal(lager.Text) & "','" & Convert.ToInt16(paleta.Text) & "','" & regal_red.Text & "')"
            conn.Open()

            cmd2.ExecuteNonQuery()
            conn.Close()

        Else
            MessageBox.Show("Unos nije ispravan", "ERROR")
        End If



    End Sub

    Private Sub proizvodac_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub napuniProizvodace()

        Dim Adapter As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM proizvodaci", conn)
        Adapter.Fill(popisProizvodaca)

        conn.Open()
        proizvodac.DataSource = popisProizvodaca
        proizvodac.DisplayMember = "naziv_proizvodaca"
        proizvodac.ValueMember = "id_proizvodaca"

        conn.Close()

    End Sub

    Private Sub napuniSkladista()

        Dim Adapter As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM skladista", conn)
        Adapter.Fill(popisSkladista)

        conn.Open()
        skladiste.DataSource = popisSkladista
        skladiste.DisplayMember = "naziv_skladista"
        skladiste.ValueMember = "id_skladista"


        conn.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        napuniProizvodace()
        napuniSkladista()

        Dim cmd As MySqlCommand = conn.CreateCommand
        cmd.CommandText = "SELECT * FROM artikli WHERE id_kod = '" & odabraniId & "'"

        conn.Open()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            id_kod.Text = reader("id_kod").ToString()
            naziv_artikla.Text = reader("naziv").ToString()
            proizvodac.SelectedValue = reader("proizvodac_id")


        End While
        conn.Close()

    End Sub
End Class