Imports MySql.Data.MySqlClient

Module ModuleAffichage
    Public Sub AffichageDonneesEtudiant()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()
        Dim i As Integer = 0

        Try
            Dim RequeteAffichage As String = "SELECT nom_etudiant, prenom_etudiant, adresse_etudiant, naissance_etudiant, numero_etudiant
                                              FROM etudiant e, ajouter a
                                              WHERE e.id_etudiant = a.id_etudiant
                                              AND e.categorie_etudiant = '" & MainForm.categorie_affichage_etudiant.selectedValue & "'
                                              AND e.classe_etudiant = '" & MainForm.classe_affichage_etudiant.selectedValue & "'
                                              AND a.id_etablissement = " & ClasseSession.getEtablissementID()
            Dim CommandeAffichage As New MySqlCommand(RequeteAffichage, Connexion)
            Dim AdaptateurAffichage As New MySqlDataAdapter(CommandeAffichage)
            Dim MonDataSetAffichage As New DataSet
            Try
                AdaptateurAffichage.Fill(MonDataSetAffichage, "Etudiant")

                MainForm.liste_etudiant.DataSource = MonDataSetAffichage.Tables(0)
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub
End Module
