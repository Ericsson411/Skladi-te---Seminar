Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient



Public Class dodajArtikal



    Dim connStr As String = "server=remotemysql.com;user=VcLM9jz5zd;database=VcLM9jz5zd;port=3306;password=nOIVOaRp3c;"
    Dim conn As New MySqlConnection(connStr)
    Dim popisProizvodaca As DataTable = New DataTable
    Dim popisSkladista As DataTable = New DataTable


    Private Sub dodajArtikal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        napuniProizvodace()

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles dodaj.Click
        If id_kod.Text <> "" And naziv_artikla.Text <> "" Then

            Dim cmd As MySqlCommand = conn.CreateCommand
            Dim cmd2 As MySqlCommand = conn.CreateCommand
            cmd.CommandText = "INSERT INTO artikli(id_kod,naziv,proizvodac_id) VALUES('" & Convert.ToInt16(id_kod.Text) & "','" & naziv_artikla.Text & "','" & proizvodac.SelectedValue & "')"

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

        Else
            MessageBox.Show("Unos nije ispravan", "ERROR")
        End If
    End Sub
End Class