Public Class Form1
    Private Sub Lien_changement_page_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lien_changement_page.LinkClicked
        If (Me.Pages.SelectedIndex = 1) Then
            Me.label_changement_page.Text = "Pas encore de compte?"
            Me.label_changement_page.Left = 218
            Me.lien_changement_page.Left = 381
            Me.Pages.SelectTab(0)
        Else
            Me.label_changement_page.Text = "Vous avez déjà un compte?"
            Me.label_changement_page.Left = 208
            Me.lien_changement_page.Left = 400
            Me.Pages.SelectTab(1)
        End If
    End Sub

    Private Sub Bouton_quitter_Click(sender As Object, e As EventArgs) Handles bouton_quitter.Click
        Me.Close()
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainForm.Enabled = False
        ModuleInitialisation.InitBD()
        ModuleInitialisation.RemplissageCategorie()
        ModuleInitialisation.RemplissageTrimestre()
        ModuleInitialisation.RemplissageCoefficient()
        ModuleInitialisation.RemplissageNote()
    End Sub

    Private Sub Bouton_login_Click(sender As Object, e As EventArgs) Handles bouton_login.Click
        If (Me.email_login.Text <> "") And (Me.password_login.Text <> "") Then
            ModuleInitialisation.Connexion()
            MainForm.nom_etab.Text = ClasseSession.getEtablissementNom()
            ModuleChangementDynamique.NombreEtudiantEtablissement()
        Else
            MsgBox("Veuillez vérifier toutes les informations nécéssaires", 48, "Information error")
        End If
    End Sub

    Private Sub Bouton_register_Click(sender As Object, e As EventArgs) Handles bouton_register.Click
        If (Me.nom_register.Text <> "") And (Me.adresse_register.Text <> "") And (Me.email_register.Text <> "") And (Me.password_register.Text <> "") Then
            If (Me.password_register.Text = "          ") Then
                MsgBox("Le mot de passe est encore par défaut", 48, "Default password")
            Else
                ModuleInitialisation.Enregistrement()
                Me.nom_register.Text = ""
                Me.adresse_register.Text = ""
                Me.email_register.Text = ""
                Me.contact_register.Text = ""
                Me.password_register.Text = ""
            End If
        Else
            MsgBox("Veuillez vérifier toutes les informations nécéssaires", 48, "Information error")
        End If
    End Sub






End Class
