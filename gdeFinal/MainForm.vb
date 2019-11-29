Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.bouton_modifier.Value = False
    End Sub

    Private Sub Main_bouton_quitter_Click(sender As Object, e As EventArgs) Handles Main_bouton_quitter.Click
        Form1.Close()
    End Sub

    Private Sub Bouton_home_Click(sender As Object, e As EventArgs) Handles bouton_home.Click
        Me.MainPages.SelectTab(0)
        ModuleChangementDynamique.NombreEtudiantEtablissement()
    End Sub

    Private Sub Bouton_ajoutEtudiant_Click(sender As Object, e As EventArgs) Handles bouton_ajoutEtudiant.Click
        Me.MainPages.SelectTab(1)
    End Sub

    Private Sub Bouton_ajoutMatiere_Click(sender As Object, e As EventArgs) Handles bouton_ajoutMatiere.Click
        Me.MainPages.SelectTab(2)
    End Sub

    Private Sub Bouton_ajoutNote_Click(sender As Object, e As EventArgs) Handles bouton_ajoutNote.Click
        Me.MainPages.SelectTab(3)
    End Sub

    Private Sub Bouton_affichage_Click(sender As Object, e As EventArgs) Handles bouton_affichage.Click
        Me.MainPages.SelectTab(4)
        ModuleAffichage.AffichageDonneesEtudiant()
    End Sub

    Private Sub Bouton_parametreCompte_Click(sender As Object, e As EventArgs) Handles bouton_parametreCompte.Click
        Dim password As String
        password = InputBox("Veuillez entrer le mot de passe")
        If (password = ClasseSession.getEtablissementPassword()) Then
            Me.MainPages.SelectTab(5)
            ModuleParametre.AffichageDonneesCompte()
        Else
            MsgBox("Mot de passe incorrect", 48, "Password error")
        End If
    End Sub

    Private Sub Bouton_modifier_OnValueChange(sender As Object, e As EventArgs) Handles bouton_modifier.OnValueChange
        If (Me.bouton_modifier.Value = True) Then
            liste_etudiant.Hide()
        Else
            liste_etudiant.Show()
            Try
                ModuleModification.ModificationEtudiant()
            Catch ex As Exception

            End Try
        End If
    End Sub


    Private Sub Bouton_modifier_parametre_OnValueChange(sender As Object, e As EventArgs)
        If (Me.bouton_modifier.Value = True) Then
            Me.nom_etab_compte.Enabled = False
            Me.adresse_etab_compte.Enabled = False
            Me.mail_etab_compte.Enabled = False
            Me.contact_etab_compte.Enabled = False
            Me.password_etab_compte.Enabled = False
        Else
            Me.nom_etab_compte.Enabled = True
            Me.adresse_etab_compte.Enabled = True
            Me.mail_etab_compte.Enabled = True
            Me.contact_etab_compte.Enabled = True
            Me.password_etab_compte.Enabled = True

        End If
    End Sub



    ' Ajout d'étudiant
    Private Sub Bouton_etudiant_ajout_Click(sender As Object, e As EventArgs) Handles bouton_etudiant_ajout.Click
        If (Me.nom_etudiant_ajout.Text <> "") And (Me.prenom_etudiant_ajout.Text <> "") And (Me.adresse_etudiant_ajout.Text <> "") And (Me.numero_etudiant_ajout.Text <> "") And (Me.categorie_etudiant_ajout.selectedIndex <> -1) And (Me.classe_etudiant_ajout.selectedIndex <> -1) Then
            If (IsNumeric(Me.numero_etudiant_ajout.Text) = True) Then
                ModuleAjout.AjoutEtudiant()
            Else
                MsgBox("Veuillez entrer un numéro correct pour l'étudiant", 48, "Information error")
            End If
        Else
            MsgBox("Veuillez vérifier toutes les informations nécéssaires", 48, "Information error")
        End If
    End Sub

    Private Sub Categorie_etudiant_ajout_onItemSelected(sender As Object, e As EventArgs) Handles categorie_etudiant_ajout.onItemSelected
        ModuleChangementDynamique.RemplissageClasse(categorie_etudiant_ajout, classe_etudiant_ajout)
    End Sub





    ' Ajout de matière
    Private Sub Bouton_matiere_ajout_Click(sender As Object, e As EventArgs) Handles bouton_matiere_ajout.Click
        If (Me.categorie_matiere_ajout.selectedIndex <> -1) And (Me.classe_matiere_ajout.selectedIndex <> -1) And (Me.ID_etudiant_matiere_ajout.selectedIndex <> -1) And (Me.nom_etudiant_matiere_ajout.Text <> "") And (Me.nom_matiere_ajout.selectedIndex <> -1) And (Me.coe_matiere_ajout.selectedIndex <> -1) Then
            ModuleAssignation.AssignationMatiere()
        Else
            MsgBox("Veuillez vérifier toutes les informations nécéssaires", 48, "Information error")
        End If
    End Sub

    Private Sub Categorie_matiere_ajout_onItemSelected(sender As Object, e As EventArgs) Handles categorie_matiere_ajout.onItemSelected
        Me.ID_etudiant_matiere_ajout.Clear()
        Me.nom_etudiant_matiere_ajout.Text = ""
        Me.nom_matiere_ajout.selectedIndex = -1
        Me.coe_matiere_ajout.selectedIndex = -1
        ModuleChangementDynamique.RemplissageClasse(categorie_matiere_ajout, classe_matiere_ajout)
        ModuleChangementDynamique.RemplissageMatiere(categorie_matiere_ajout, nom_matiere_ajout)
    End Sub

    Private Sub Classe_matiere_ajout_onItemSelected(sender As Object, e As EventArgs) Handles classe_matiere_ajout.onItemSelected
        ModuleChangementDynamique.RemplissageIDEtudiant(classe_matiere_ajout, ID_etudiant_matiere_ajout, nom_etudiant_matiere_ajout)
    End Sub

    Private Sub ID_etudiant_matiere_ajout_onItemSelected(sender As Object, e As EventArgs) Handles ID_etudiant_matiere_ajout.onItemSelected
        ModuleChangementDynamique.RemplissageNomEtudiant(ID_etudiant_matiere_ajout, nom_etudiant_matiere_ajout)
    End Sub





    ' Ajout de note
    Private Sub Bouton_note_ajout_Click(sender As Object, e As EventArgs) Handles bouton_note_ajout.Click
        If (Me.categorie_note_ajout.selectedIndex <> -1) And (Me.classe_note_ajout.selectedIndex <> -1) And (Me.ID_etudiant_note_ajout.selectedIndex <> -1) And (Me.trimestre_note_ajout.selectedIndex <> -1) And (Me.matiere_note_ajout.selectedIndex <> -1) And (Me.valeur_note_ajout.selectedIndex <> -1) Then
            ModuleAttribution.AttributionNote()
        Else
            MsgBox("Veuillez vérifier toutes les informations nécéssaires", 48, "Information error")
        End If
    End Sub

    Private Sub Categorie_note_ajout_onItemSelected(sender As Object, e As EventArgs) Handles categorie_note_ajout.onItemSelected
        Me.ID_etudiant_note_ajout.Clear()
        Me.nom_etudiant_note_ajout.Text = ""
        Me.matiere_note_ajout.Clear()
        ModuleChangementDynamique.RemplissageClasse(categorie_note_ajout, classe_note_ajout)
    End Sub

    Private Sub Classe_note_ajout_onItemSelected(sender As Object, e As EventArgs) Handles classe_note_ajout.onItemSelected
        ModuleChangementDynamique.RemplissageIDEtudiant(classe_note_ajout, ID_etudiant_note_ajout, nom_etudiant_note_ajout)
        Me.matiere_note_ajout.Clear()
    End Sub

    Private Sub ID_etudiant_note_ajout_onItemSelected(sender As Object, e As EventArgs) Handles ID_etudiant_note_ajout.onItemSelected
        ModuleChangementDynamique.RemplissageNomEtudiant(ID_etudiant_note_ajout, nom_etudiant_note_ajout)
        ModuleChangementDynamique.RemplissageMatiereEtudiant()
    End Sub





    ' Affichage des étudiants
    Private Sub Categorie_affichage_etudiant_onItemSelected(sender As Object, e As EventArgs) Handles categorie_affichage_etudiant.onItemSelected
        ModuleChangementDynamique.RemplissageClasse(categorie_affichage_etudiant, classe_affichage_etudiant)
    End Sub

    Private Sub Classe_affichage_etudiant_onItemSelected(sender As Object, e As EventArgs) Handles classe_affichage_etudiant.onItemSelected
        ModuleAffichage.AffichageDonneesEtudiant()
    End Sub

    Private Sub Bouton_deconnexion_Click(sender As Object, e As EventArgs) Handles bouton_deconnexion.Click
        ModuleDeconnexion.DeconnexionSession()
        ProfilForm.Close()
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub liste_etudiant_DoubleClick(sender As Object, e As EventArgs) Handles liste_etudiant.DoubleClick
        Try
            ModuleProfil.GenerationProfil(Me.liste_etudiant.CurrentRow.Index)
            ProfilForm.Show()
        Catch ex As Exception

        End Try
    End Sub

    ' Recherche des étudiants en fonction de : nom, prénom et adresse
    Private Sub recherche_etudiant_OnTextChange(sender As Object, e As EventArgs) Handles recherche_etudiant.OnTextChange
        If Me.recherche_etudiant.text <> "" Then
            ModuleRecherche.RechercheNom(Me.recherche_etudiant.text)
        Else
            ModuleAffichage.AffichageDonneesEtudiant()
        End If
    End Sub

    ' Modification des étudiants
    Private Sub bouton_modification_etudiant_Click(sender As Object, e As EventArgs) Handles bouton_modification_etudiant.Click
        If (Me.nom_modification.Text <> "") And (Me.prenom_modification.Text <> "") And (Me.adresse_modification.Text <> "") And (Me.categorie_modification.Text <> "") And (Me.classe_modification.Text <> "") And (Me.numero_modification.Text <> "") Then
            ModuleModification.ModificationEtudiantAppliquer()
        Else
            MsgBox("Veuillez vérifier toutes les informations nécéssaires", 48, "Information error")
        End If
    End Sub

    Private Sub bouton_suppression_etudiant_Click(sender As Object, e As EventArgs) Handles bouton_suppression_etudiant.Click
        ModuleModification.SuppressionEtudiantAppliquer()
    End Sub


    ' Modification des paramètres de l'établissement
    Private Sub bouton_actualiser_Click(sender As Object, e As EventArgs) Handles bouton_actualiser.Click
        If (Me.nom_etab_compte.Text <> "") And (Me.adresse_etab_compte.Text <> "") And (Me.mail_etab_compte.Text <> "") And (Me.contact_etab_compte.Text <> "") And (Me.password_etab_compte.Text <> "") Then
            ModuleParametre.ModificationDonneesCompte()
        End If
    End Sub
End Class