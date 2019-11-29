Module ModuleDeconnexion
    Friend Sub DeconnexionSession()
        ClasseSession.setEtablissementID(0)
        ClasseSession.setEtablissementNom("")
        ClasseSession.setEtablissementMail("")
        ClasseSession.setEtablissementAdresse("")
        ClasseSession.setEtablissementContact("")
        ClasseSession.setEtablissementPassword("")

        LibererFormulaire()
    End Sub

    Private Sub LibererFormulaire()
        Form1.email_login.Text = ""
        Form1.password_login.Text = "          "

        Form1.nom_register.Text = ""
        Form1.email_register.Text = ""
        Form1.adresse_register.Text = ""
        Form1.contact_register.Text = ""
        Form1.password_register.Text = "          "
    End Sub
End Module
