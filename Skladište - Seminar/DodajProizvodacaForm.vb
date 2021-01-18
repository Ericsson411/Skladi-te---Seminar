Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class DodajProizvodacaForm


    Dim conn As New MySqlConnection(GlobalneVarijable.connStr)
    Dim popisProizvodaca As DataTable = New DataTable

    Private Sub DodajProizvodacaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        napuniProizvodace()


    End Sub

    Private Sub napuniProizvodace()
        Try
            popisProizvodaca.Clear()
            Dim Adapter As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM proizvodaci", conn)
            Adapter.Fill(popisProizvodaca)

            conn.Open()
            ListBox1.DataSource = popisProizvodaca
            ListBox1.DisplayMember = "naziv_proizvodaca"
            ListBox1.ValueMember = "id_proizvodaca"

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim cmd As MySqlCommand = conn.CreateCommand
            cmd.CommandText = "INSERT INTO proizvodaci(naziv_proizvodaca) VALUES('" & nazivProizvodaca_textbox.Text & "')"

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            napuniProizvodace()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim cmd2 As MySqlCommand = conn.CreateCommand
            Dim cmd As MySqlCommand = conn.CreateCommand
            cmd.CommandText = "DELETE FROM proizvodaci WHERE id_proizvodaca =  " & ListBox1.SelectedValue
            cmd2.CommandText = "UPDATE artikli SET proizvodac_id = 1 WHERE proizvodac_id = " & ListBox1.SelectedValue
            conn.Open()
            cmd2.ExecuteNonQuery()
            cmd.ExecuteNonQuery()
            conn.Close()
            napuniProizvodace()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


    End Sub
End Class