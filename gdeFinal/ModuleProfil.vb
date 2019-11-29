Imports Bunifu.Framework.UI
Imports MySql.Data.MySqlClient

Module ModuleProfil
    Friend Sub GenerationProfil(ByVal numeroIndex As Integer)
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()

        Dim naissance As String
        Dim idEtudiantCible As Integer

        ' Affichage des informations personnelles
        Try
            Dim RequeteProfilEtudiant As String = "SELECT *
                                                   FROM etudiant
                                                   WHERE categorie_etudiant = '" & MainForm.categorie_affichage_etudiant.selectedValue & "'
                                                   AND classe_etudiant = '" & MainForm.classe_affichage_etudiant.selectedValue & "'
                                                   AND numero_etudiant = " & CInt(MainForm.liste_etudiant.Rows(numeroIndex).Cells(4).Value)
            Dim CommandeProfilEtudiant As New MySqlCommand(RequeteProfilEtudiant, Connexion)
            Dim MonReaderProfilEtudiant As MySqlDataReader = CommandeProfilEtudiant.ExecuteReader()

            If MonReaderProfilEtudiant.Read() Then
                idEtudiantCible = MonReaderProfilEtudiant.GetInt32("id_etudiant")
                ProfilForm.nom_etudiant.Text = MonReaderProfilEtudiant.GetString("nom_etudiant")
                ProfilForm.prenom_etudiant.Text = MonReaderProfilEtudiant.GetString("prenom_etudiant")
                ProfilForm.adresse_etudiant.Text = MonReaderProfilEtudiant.GetString("adresse_etudiant")
                naissance = MonReaderProfilEtudiant.GetString("naissance_etudiant")
                naissance = GenerationDateDeNaissance(naissance)
                ProfilForm.naissance_etudiant.Text = naissance
                ProfilForm.classe_etudiant.Text = MonReaderProfilEtudiant.GetString("classe_etudiant")
                ProfilForm.numero_etudiant.Text = MonReaderProfilEtudiant.GetString("numero_etudiant")
            End If

            MonReaderProfilEtudiant.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        GenerationNotes(idEtudiantCible)
    End Sub

    Private Function GenerationDateDeNaissance(ByVal dateComplet As String)
        Dim dateNaissance As String
        Dim DateTab1() As String
        Dim DateTab2() As String
        Dim jour As Integer
        Dim JourTab(2) As String

        DateTab1 = dateComplet.Split(" ")
        DateTab2 = DateTab1(0).Split("/")

        JourTab(0) = DateTab2(0)
        JourTab(2) = DateTab2(2)

        jour = CInt(DateTab2(1))
        Select Case jour
            Case 1
                JourTab(1) = " Janvier "
            Case 2
                JourTab(1) = " Février "
            Case 3
                JourTab(1) = " Mars "
            Case 4
                JourTab(1) = " Avril "
            Case 5
                JourTab(1) = " Mai "
            Case 6
                JourTab(1) = " Juin "
            Case 7
                JourTab(1) = " Juillet "
            Case 8
                JourTab(1) = " Août "
            Case 9
                JourTab(1) = " Septembre "
            Case 10
                JourTab(1) = " Octobre "
            Case 11
                JourTab(1) = " Novembre "
            Case 12
                JourTab(1) = " Décembre "
        End Select

        dateNaissance = JourTab(0) + JourTab(1) + JourTab(2)

        Return dateNaissance
    End Function

    Private Sub GenerationNotes(ByVal numeroID As Integer)
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()

        Dim nbrMatiere As Integer = -1
        Dim matieres(0) As String

        ' Ajout de la première colonne (matières)
        Try
            Dim RequeteProfilEtudiant As String = "SELECT nom_matiere
                                                   FROM matiere m
                                                   NATURAL JOIN assigner a
                                                   WHERE a.id_etudiant = " & numeroID & "
                                                   AND m.id_matiere = a.id_matiere"
            Dim CommandeProfilEtudiant As New MySqlCommand(RequeteProfilEtudiant, Connexion)
            Dim MonReaderProfilEtudiant As MySqlDataReader = CommandeProfilEtudiant.ExecuteReader()

            While MonReaderProfilEtudiant.Read()
                nbrMatiere += 1
                ReDim Preserve matieres(nbrMatiere)
                ProfilForm.liste_note_profil.Items.Add(MonReaderProfilEtudiant.GetString(0))
                matieres(nbrMatiere) = MonReaderProfilEtudiant.GetString(0)
            End While

            MonReaderProfilEtudiant.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        ' Ajout des notes en trimestre
        Try
            Dim RequeteProfilEtudiant As String = "SELECT valeur_note, nom_matiere
                                                   FROM note n
                                                   INNER JOIN matiere m
                                                   WHERE n.id_etudiant = " & numeroID & "
                                                   AND n.id_matiere = m.id_matiere"
            Dim CommandeProfilEtudiant As New MySqlCommand(RequeteProfilEtudiant, Connexion)
            Dim MonReaderProfilEtudiant As MySqlDataReader = CommandeProfilEtudiant.ExecuteReader()

            While MonReaderProfilEtudiant.Read()
                For i As Integer = 0 To matieres.Length - 1
                    If MonReaderProfilEtudiant.GetString("nom_matiere") = matieres(i) Then
                        ProfilForm.liste_note_profil.Items(i).SubItems.Add(MonReaderProfilEtudiant.GetInt32("valeur_note"))
                    End If
                Next
            End While

            MonReaderProfilEtudiant.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
