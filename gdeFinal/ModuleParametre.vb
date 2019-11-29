Imports MySql.Data.MySqlClient

Module ModuleParametre
    Public Sub AffichageDonneesCompte()
        MainForm.nom_etab_compte.Text = ClasseSession.getEtablissementNom()
        MainForm.adresse_etab_compte.Text = ClasseSession.getEtablissementAdresse()
        MainForm.mail_etab_compte.Text = ClasseSession.getEtablissementMail()
        MainForm.contact_etab_compte.Text = ClasseSession.getEtablissementContact()
        MainForm.password_etab_compte.Text = ClasseSession.getEtablissementPassword()
    End Sub

    Public Sub ModificationDonneesCompte()
        If (MainForm.nom_etab_compte.Text <> ClasseSession.getEtablissementNom()) Then
            ClasseSession.setEtablissementNom(MainForm.nom_etab_compte.Text)
        End If
        If (MainForm.adresse_etab_compte.Text <> ClasseSession.getEtablissementAdresse()) Then
            ClasseSession.setEtablissementAdresse(MainForm.adresse_etab_compte.Text)
        End If
        If (MainForm.mail_etab_compte.Text <> ClasseSession.getEtablissementMail()) Then
            ClasseSession.setEtablissementMail(MainForm.mail_etab_compte.Text)
        End If
        If (MainForm.contact_etab_compte.Text <> ClasseSession.getEtablissementContact()) Then
            ClasseSession.setEtablissementContact(MainForm.contact_etab_compte.Text)
        End If
        If (MainForm.password_etab_compte.Text <> ClasseSession.getEtablissementPassword()) Then
            ClasseSession.setEtablissementPassword(MainForm.password_etab_compte.Text)
        End If
        ModificationDonneesBD()
        MainForm.nom_etab.Text = ClasseSession.getEtablissementNom()
    End Sub

    Private Sub ModificationDonneesBD()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()

        Try
            Dim RequeteParametre As String = "UPDATE etablissement
                                              SET nom_etablissement = '" & ClasseSession.getEtablissementNom() & "', email_etablissement = '" & ClasseSession.getEtablissementMail() & "', adresse_etablissement = '" & ClasseSession.getEtablissementAdresse() & "', contact_etablissement = '" & ClasseSession.getEtablissementContact() & "', password_etablissement = '" & ClasseSession.getEtablissementPassword() & "'
                                              WHERE id_etablissement = " & getEtablissementID()
            Dim CommandeParametre As New MySqlCommand(RequeteParametre, Connexion)
            CommandeParametre.ExecuteNonQuery()
            MsgBox("Modification faite avec succès", 64, "Account modified")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
