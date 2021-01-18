Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient



Public Class dodajArtikalForm



    Dim conn As New MySqlConnection(GlobalneVarijable.connStr)
    Dim popisProizvodaca As DataTable = New DataTable
    Dim popisSkladista As DataTable = New DataTable


    Private Sub dodajArtikal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        napuniProizvodace()

    End Sub


    Private Sub napuniProizvodace()
        Try
            Dim Adapter As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM proizvodaci", conn)
            Adapter.Fill(popisProizvodaca)

            conn.Open()
            proizvodac.DataSource = popisProizvodaca
            proizvodac.DisplayMember = "naziv_proizvodaca"
            proizvodac.ValueMember = "id_proizvodaca"

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles dodaj.Click

        Try
            If id_kod.Text <> "" And naziv_artikla.Text <> "" Then

                Dim cmd As MySqlCommand = conn.CreateCommand
                Dim cmd2 As MySqlCommand = conn.CreateCommand
                cmd.CommandText = "INSERT INTO artikli(id_kod,naziv,proizvodac_id) VALUES('" & Convert.ToInt16(id_kod.Text) & "','" & naziv_artikla.Text & "','" & proizvodac.SelectedValue & "')"

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                Me.Close()
            Else
                MessageBox.Show("Unos nije ispravan", "ERROR")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub
End Class