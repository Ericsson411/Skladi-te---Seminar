Imports System.Data

Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class AzurirajForm


    Dim conn As New MySqlConnection(GlobalneVarijable.connStr)
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
        napuniListBox()
        napuniTextbox()
        napuniSkladista()

        Try
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
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


    End Sub

    Private Sub napuniListBox()
        Try
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


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try




    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        Try

            Dim cmd As MySqlCommand = conn.CreateCommand()
            cmd.CommandText = "UPDATE artikli JOIN lager ON artikli.id_kod = lager.id_artikla SET id_kod = '" & odabraniId & "', naziv = '" & naziv_artikla.Text & "',proizvodac_id = '" & proizvodaci_combobox.SelectedValue & "',id_skladista ='" & skladiste.SelectedValue & "' ,regal_red = '" & regal_red.Text & "',Paleta ='" & paleta.Text & "',lager = '" & lager.Text & "',id_artikla = '" & odabraniId & "' WHERE id_kod = '" & odabraniId.ToString() & "' AND lager.id_skladista = '" & skladiste_listbox.SelectedValue & "' AND lager.regal_red = '" & red_listbox.GetItemText(red_listbox.SelectedValue) & "'"

            cmd.ExecuteNonQuery()
            conn.Close()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        conn.Close()



    End Sub

    Private Sub napuniSkladista()
        Try
            Dim Adapter As MySqlDataAdapter = New MySqlDataAdapter("SELECT * FROM skladista", conn)
            Adapter.Fill(popisSkladista)

            conn.Open()
            skladiste.DataSource = popisSkladista
            skladiste.DisplayMember = "naziv_skladista"
            skladiste.ValueMember = "id_skladista"


            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub napuniTextbox()

        Try
            paleta.Text = paleta_listbox.GetItemText(paleta_listbox.SelectedItem).ToString()
            regal_red.Text = red_listbox.GetItemText(red_listbox.SelectedItem).ToString()
            skladiste.SelectedValue = skladiste_listbox.SelectedValue
            lager.Text = lager_listBox.GetItemText(lager_listBox.SelectedItem).ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub skladiste_listbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles skladiste_listbox.SelectedIndexChanged

        napuniTextbox()
    End Sub
End Class