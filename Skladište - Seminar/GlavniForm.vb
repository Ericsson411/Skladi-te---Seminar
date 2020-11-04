Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class GlavniForm
    'https://remotemysql.com/phpmyadmin/index.php?db=VcLM9jz5zd&table=artikli&target=sql.php

    Dim connStr As String = "server=remotemysql.com;user=VcLM9jz5zd;database=VcLM9jz5zd;port=3306;password=nOIVOaRp3c;"
    Dim conn As New MySqlConnection(connStr)
    Dim popisLagera As DataTable = New DataTable
    Dim popisArtikala As DataTable = New DataTable
    Dim popisProizvodaca As DataTable = New DataTable
    Dim dtPopisArtikala As DataView = New DataView
    Dim dtPopisLagera As DataView = New DataView
    Dim odabraniArtikal As Integer = 1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        napuniListBox()
        napuniListBoxItemima()
        napuniProizvodace()

    End Sub

    Private Sub napuniListBox()

        popisLagera.Clear()

        Dim Adapter As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM lager JOIN skladista ON lager.id_skladista = skladista.id_skladista ", conn)
        Adapter.Fill(popisLagera)


        skladiste_listbox.DataSource = popisLagera
        red_listbox.DataSource = popisLagera
        paleta_listbox.DataSource = popisLagera
        lager_listBox.DataSource = popisLagera



        skladiste_listbox.DisplayMember = "naziv_skladista"
        red_listbox.DisplayMember = "regal_red"
        paleta_listbox.DisplayMember = "paleta"
        lager_listBox.DisplayMember = "lager"





    End Sub

    Private Sub id_listbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles id_listbox.SelectedIndexChanged


        Try
            dtPopisLagera = popisLagera.DefaultView
            dtPopisLagera.RowFilter = "id_artikla = " & id_listbox.GetItemText(id_listbox.SelectedItem)

        Catch

        End Try

    End Sub

    Private Sub napuniListBoxItemima()

        popisArtikala.Clear()


        Dim Adapter As MySqlDataAdapter
        Adapter = New MySqlDataAdapter("Select * FROM artikli JOIN proizvodaci On artikli.proizvodac_id = proizvodaci.id_proizvodaca ", conn)


        Adapter.Fill(popisArtikala)


        id_listbox.DataSource = popisArtikala
        naziv_listbox.DataSource = popisArtikala
        proizvodac_listbox.DataSource = popisArtikala

        id_listbox.DisplayMember = "id_kod"
        naziv_listbox.DisplayMember = "naziv"
        proizvodac_listbox.DisplayMember = "naziv_proizvodaca"


        id_listbox.ValueMember = "id_kod"
        naziv_listbox.ValueMember = "id_kod"
        proizvodac_listbox.ValueMember = "id_kod"





    End Sub

    Private Sub napuniProizvodace()

        popisProizvodaca.Clear()

        Dim Adapter As MySqlDataAdapter = New MySqlDataAdapter("Select * FROM proizvodaci", conn)
        Adapter.Fill(popisProizvodaca)


        proizvodaci_comboBox.DataSource = popisProizvodaca
        proizvodaci_comboBox.DisplayMember = "naziv_proizvodaca"
        proizvodaci_comboBox.ValueMember = "id_proizvodaca"


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles search_textbox.TextChanged

        dtPopisArtikala = popisArtikala.DefaultView

        dtPopisArtikala.RowFilter = "naziv Like '%" & search_textbox.Text & "%'"

    End Sub

    Private Sub proizvodaci_comboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles proizvodaci_comboBox.SelectedIndexChanged

        If proizvodaci_checkBox.Checked = True Then
            dtPopisArtikala = popisArtikala.DefaultView
            dtPopisArtikala.RowFilter = "naziv_proizvodaca Like '%" & proizvodaci_comboBox.Text & "%'"
        Else
            dtPopisArtikala = popisArtikala.DefaultView
            dtPopisArtikala.RowFilter = "naziv_proizvodaca Like '%%'"
        End If


    End Sub

    Private Sub proizvodaci_checkBox_CheckedChanged(sender As Object, e As EventArgs) Handles proizvodaci_checkBox.CheckedChanged

        If proizvodaci_checkBox.Checked = True Then
            dtPopisArtikala = popisArtikala.DefaultView
            dtPopisArtikala.RowFilter = "naziv_proizvodaca Like '%" & proizvodaci_comboBox.Text & "%'"
        Else
            dtPopisArtikala = popisArtikala.DefaultView
            dtPopisArtikala.RowFilter = "naziv_proizvodaca Like '%%'"
        End If


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


        MessageBox.Show(id_listbox.GetItemText(id_listbox.SelectedItem))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim azuriraj As AzurirajForm = New AzurirajForm
        azuriraj.odabraniId = id_listbox.SelectedValue
        azuriraj.ShowDialog()
        napuniListBoxItemima()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dodaj As DodajForm = New DodajForm
        dodaj.odabraniId = id_listbox.SelectedValue

        dodaj.ShowDialog()
        napuniListBox()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As MySqlCommand = conn.CreateCommand
        If MessageBox.Show("Jeste si sigurni da želite izbrisati taj artikal?", "Jeste li sigurni?", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            cmd.CommandText = "DELETE FROM lager WHERE id_artikla =" & id_listbox.SelectedValue & " AND lager = " & lager_listBox.GetItemText(lager_listBox.SelectedItem)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            napuniListBox()

        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dodajProizvo As DodajProizvodacaForm = New DodajProizvodacaForm
        dodajProizvo.ShowDialog()

        napuniProizvodace()
        napuniListBoxItemima()


    End Sub

    Private Sub dodajArtikalbotun_Click(sender As Object, e As EventArgs) Handles dodajArtikalbotun.Click
        Dim dodajArtikalForm As dodajArtikal = New dodajArtikal
        dodajArtikalForm.ShowDialog()

        napuniListBoxItemima()

    End Sub
End Class
