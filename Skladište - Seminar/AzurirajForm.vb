Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class AzurirajForm

    Dim connStr As String = "server=remotemysql.com;user=VcLM9jz5zd;database=VcLM9jz5zd;port=3306;password=nOIVOaRp3c;"
    Dim conn As New MySqlConnection(connStr)
    Dim popisProizvodaca As DataTable = New DataTable
    Dim popisSkladista As DataTable = New DataTable
    Dim popisLagera As DataTable = New DataTable
    Public Property odabraniId As Integer



    Private Sub napuniProizvodace()

        popisProizvodaca.Clear()

        Dim Adapter As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM proizvodaci", conn)
        Adapter.Fill(popisProizvodaca)



        conn.Open()
        proizvodaci_comboBox.DataSource = popisProizvodaca
        proizvodaci_comboBox.DisplayMember = "naziv_proizvodaca"
        proizvodaci_comboBox.ValueMember = "id_proizvodaca"

        conn.Close()

    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        napuniProizvodace()
        Try
            napuniListBox()
            napuniTextbox()
        Catch
        End Try

        napuniSkladista()


        Dim cmd As MySqlCommand = conn.CreateCommand
        cmd.CommandText = "SELECT * FROM artikli WHERE id_kod = '" & odabraniId & "'"

        conn.Open()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            id_kod.Text = reader("id_kod").ToString()
            naziv_artikla.Text = reader("naziv").ToString()
            proizvodaci_combobox.SelectedValue = reader("proizvodac_id")


        End While
        conn.Close()

    End Sub

    Private Sub napuniListBox()

        popisLagera.Clear()
        Dim Adapter As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM lager JOIN skladista ON lager.id_skladista = skladista.id_skladista WHERE id_artikla = '" & odabraniId & "'", conn)
        Adapter.Fill(popisLagera)

        skladiste_listbox.DataSource = popisLagera
        red_listbox.DataSource = popisLagera
        paleta_listbox.DataSource = popisLagera
        lager_listBox.DataSource = popisLagera

        skladiste_listbox.DisplayMember = "naziv_skladista"
        red_listbox.DisplayMember = "regal_red"
        paleta_listbox.DisplayMember = "paleta"
        lager_listBox.DisplayMember = "lager"

        skladiste_listbox.ValueMember = "id_skladista"




    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand = conn.CreateCommand
        Dim cmd2 As MySqlCommand = conn.CreateCommand


        'nevalja sql commanda

        cmd2.CommandText = "UPDATE artikli SET id_kod = " & id_kod.Text & ",naziv = '" & naziv_artikla.Text & "',proizvodac_id = " & proizvodaci_combobox.SelectedValue & " WHERE id_kod = " & odabraniId & ""

        conn.Open()
        If regal_red.Text <> "" And paleta.Text <> "" And lager.Text <> "" Then
            cmd.CommandText = "UPDATE lager SET lager = " & Convert.ToInt16(lager.Text) & ",id_skladista = " & skladiste_listbox.SelectedValue & ",regal_red = " & regal_red.Text & ",paleta = " & paleta.Text & " WHERE id_artikla = " & odabraniId & " AND lager = " & lager_listBox.GetItemText(lager_listBox.SelectedItem) & " AND regal_red = " & red_listbox.GetItemText(red_listbox.SelectedItem) & " AND paleta = " & paleta_listbox.GetItemText(paleta_listbox.SelectedItem)
            cmd.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
        Else
            cmd2.ExecuteNonQuery()
        End If


        napuniListBox()
        napuniTextbox()


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

    Private Sub napuniTextbox()

        Try
            paleta.Text = paleta_listbox.GetItemText(paleta_listbox.SelectedItem).ToString()
            regal_red.Text = red_listbox.GetItemText(red_listbox.SelectedItem).ToString()
            skladiste.SelectedValue = skladiste_listbox.SelectedValue
            lager.Text = lager_listBox.GetItemText(lager_listBox.SelectedItem).ToString()
        Catch
        End Try

    End Sub

    Private Sub skladiste_listbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles skladiste_listbox.SelectedIndexChanged

        napuniTextbox()
    End Sub
End Class