Imports MySql.Data.MySqlClient

Module ModuleModification
    Private info(5) As String

    Friend Function RecuperationIndex()
        Dim Tab1(3) As String
        Dim Tab2(0) As String
        Dim index As Integer

        Tab1 = MainForm.liste_etudiant.CurrentRow.ToString.Split(" ")
        Tab2 = Tab1(2).Split("=")
        index = Tab2(1)

        Return index
    End Function

    Friend Sub ModificationEtudiant()
        Dim index As Integer = RecuperationIndex()
        Dim num_target As Integer = MainForm.liste_etudiant.Item(4, index).Value
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()

        If (index < 0) Then
            MsgBox("Veuillez choisir un étudiant à modifier", 48, "Modification error")
            MainForm.liste_etudiant.Show()
        Else
            Try
                Dim RequeteIndexBD As String = "SELECT *
                                                FROM etudiant
                                                WHERE numero_etudiant = " & num_target & "
                                                ORDER BY id_etudiant ASC"
                Dim CommandeIndexBD As New MySqlCommand(RequeteIndexBD, Connexion)
                Dim MonReaderIndexBD As MySqlDataReader = CommandeIndexBD.ExecuteReader()

                While MonReaderIndexBD.Read()
                    If (MonReaderIndexBD.GetString("categorie_etudiant") = MainForm.categorie_affichage_etudiant.selectedValue) Then
                        If (MonReaderIndexBD.GetString("classe_etudiant") = MainForm.classe_affichage_etudiant.selectedValue) Then
                            info(0) = MonReaderIndexBD.GetString("nom_etudiant")
                            info(1) = MonReaderIndexBD.GetString("prenom_etudiant")
                            info(2) = MonReaderIndexBD.GetString("adresse_etudiant")
                            info(3) = MonReaderIndexBD.GetString("categorie_etudiant")
                            info(4) = MonReaderIndexBD.GetString("classe_etudiant")
                            info(5) = MonReaderIndexBD.GetString("numero_etudiant")

                            ClasseSession.setModificationEtudiantID(MonReaderIndexBD.GetInt32("id_etudiant"))
                            AffichageDonnees()
                        End If
                    End If
                End While

                MonReaderIndexBD.Close()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub AffichageDonnees()
        MainForm.nom_modification.Text = info(0)
        MainForm.prenom_modification.Text = info(1)
        MainForm.adresse_modification.Text = info(2)
        MainForm.categorie_modification.Text = info(3)
        MainForm.classe_modification.Text = info(4)
        MainForm.numero_modification.Text = info(5)

        MainForm.liste_etudiant.Show()
    End Sub


    Friend Sub ModificationEtudiantAppliquer()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()

        Try
            Dim RequeteEtudiant As String = "UPDATE etudiant
                                             SET nom_etudiant = '" & MainForm.nom_modification.Text & "', prenom_etudiant = '" & MainForm.prenom_modification.Text & "', adresse_etudiant = '" & MainForm.adresse_modification.Text & "', categorie_etudiant = '" & MainForm.categorie_modification.Text & "', classe_etudiant = '" & MainForm.classe_modification.Text & "', numero_etudiant = '" & MainForm.numero_modification.Text & "'
                                             WHERE id_etudiant = " & getModificationEtudiantID()
            Dim CommandeEtudiant As New MySqlCommand(RequeteEtudiant, Connexion)
            CommandeEtudiant.ExecuteNonQuery()

            MsgBox("Modification faite avec succès", 64, "Etudiant modified")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Friend Sub SuppressionEtudiantAppliquer()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()

        Try
            Dim RequeteEtudiant As String = "DELETE FROM note
                                             WHERE id_etudiant = " & ClasseSession.getModificationEtudiantID()
            Dim CommandeEtudiant As New MySqlCommand(RequeteEtudiant, Connexion)
            CommandeEtudiant.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            Dim RequeteEtudiant As String = "DELETE FROM ajouter
                                             WHERE id_etudiant = " & ClasseSession.getModificationEtudiantID()
            Dim CommandeEtudiant As New MySqlCommand(RequeteEtudiant, Connexion)
            CommandeEtudiant.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            Dim RequeteEtudiant As String = "DELETE FROM assigner
                                             WHERE id_etudiant = " & ClasseSession.getModificationEtudiantID()
            Dim CommandeEtudiant As New MySqlCommand(RequeteEtudiant, Connexion)
            CommandeEtudiant.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            Dim RequeteEtudiant As String = "DELETE FROM etudiant
                                             WHERE id_etudiant = " & ClasseSession.getModificationEtudiantID()
            Dim CommandeEtudiant As New MySqlCommand(RequeteEtudiant, Connexion)
            CommandeEtudiant.ExecuteNonQuery()

            MsgBox("Etudiant supprimé avec succès !", 64, "Etudiant deleted")
        Catch ex As Exception

        End Try
    End Sub
End Module
