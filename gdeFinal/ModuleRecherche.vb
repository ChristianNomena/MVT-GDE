Imports MySql.Data.MySqlClient

Module ModuleRecherche
    Friend Sub RechercheNom(ByVal recherche As String)
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()

        Try
            Dim RequeteRecherche As String = "SELECT nom_etudiant, prenom_etudiant, adresse_etudiant, naissance_etudiant, numero_etudiant
                                              FROM etudiant e, ajouter a
                                              WHERE e.id_etudiant = a.id_etudiant
                                              AND e.categorie_etudiant = '" & MainForm.categorie_affichage_etudiant.selectedValue & "'
                                              AND e.classe_etudiant = '" & MainForm.classe_affichage_etudiant.selectedValue & "'
                                              AND a.id_etablissement = " & ClasseSession.getEtablissementID() & "
                                              AND (nom_etudiant LIKE '%" & recherche & "%' OR prenom_etudiant LIKE '%" & recherche & "%' OR adresse_etudiant LIKE '%" & recherche & "%')"
            Dim CommandeRecherche As New MySqlCommand(RequeteRecherche, Connexion)
            Dim AdaptateurRecherche As New MySqlDataAdapter(CommandeRecherche)
            Dim MonDataSetRecherche As New DataSet
            Try
                AdaptateurRecherche.Fill(MonDataSetRecherche, "Etudiant")

                MainForm.liste_etudiant.DataSource = MonDataSetRecherche.Tables(0)
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub
End Module
