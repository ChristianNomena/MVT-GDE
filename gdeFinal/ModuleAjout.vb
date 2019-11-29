Imports MySql.Data.MySqlClient

Module ModuleAjout
    Public Sub AjoutEtudiant()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()
        Dim AccessNumero As Boolean = VerificationNumeroClasse()
        Dim DateNaissance As String = PriseDateNaissance()

        If (AccessNumero = True) Then
            Try
                Dim RequeteEtudiant As String = "INSERT INTO etudiant (nom_etudiant, prenom_etudiant, adresse_etudiant, naissance_etudiant, categorie_etudiant, classe_etudiant, numero_etudiant)
                                                 VALUES('" & MainForm.nom_etudiant_ajout.Text & "', '" & MainForm.prenom_etudiant_ajout.Text & "', '" & MainForm.adresse_etudiant_ajout.Text & "', '" & DateNaissance & "', '" & MainForm.categorie_etudiant_ajout.selectedValue & "', '" & MainForm.classe_etudiant_ajout.selectedValue & "', " & MainForm.numero_etudiant_ajout.Text & ")"
                Dim CommandeEtudiant As New MySqlCommand(RequeteEtudiant, Connexion)
                CommandeEtudiant.ExecuteNonQuery()
                LiaisonEtablissementEtudiant()

                MainForm.nom_etudiant_ajout.Text = ""
                MainForm.prenom_etudiant_ajout.Text = ""
                MainForm.adresse_etudiant_ajout.Text = ""
                MainForm.numero_etudiant_ajout.Text = ""

                MsgBox("Etudiant ajouté avec succès !", 64, "Ajout étudiant")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub



    Private Function VerificationNumeroClasse() As Boolean
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()
        Dim AccessNumero = True
        Dim num As Integer

        Try
            Dim RequetePrendreNumero As String = "SELECT numero_etudiant
                                                  FROM etudiant
                                                  WHERE classe_etudiant = '" & MainForm.classe_etudiant_ajout.Text & "'"
            Dim CommandePrendreNumero As New MySqlCommand(RequetePrendreNumero, Connexion)
            Dim MonReaderPrendreNumero As MySqlDataReader = CommandePrendreNumero.ExecuteReader()

            While MonReaderPrendreNumero.Read()
                num = MonReaderPrendreNumero.GetInt32(0)
                If CInt(MainForm.numero_etudiant_ajout.Text) = num Then
                    AccessNumero = False
                End If
            End While

            MonReaderPrendreNumero.Close()

            If (AccessNumero = False) Then
                MsgBox("Numéro déjà utilisé dans la classe", 48, "Erreur numéro de classe")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return AccessNumero
    End Function

    Private Function PriseDateNaissance() As String
        Dim DateTab(1) As String
        Dim JourTab(2) As String
        Dim DateNaissance As String

        DateTab = MainForm.naissance_etudiant_ajout.Value.ToShortDateString().Split(" ")

        JourTab = DateTab(0).Split("/")
        DateNaissance = JourTab(2) + "-" + JourTab(1) + "-" + JourTab(0)

        Return DateNaissance
    End Function

    Private Sub LiaisonEtablissementEtudiant()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()
        Dim id_etudiant As Integer
        Dim id_etablissement As Integer

        ' Récupération de l'ID de l'étudiant
        Try
            Dim RequeteIDetudiant As String = "SELECT *
                                               FROM etudiant"
            Dim CommandeIDetudiant As New MySqlCommand(RequeteIDetudiant, Connexion)
            Dim MonReaderIDetudiant As MySqlDataReader = CommandeIDetudiant.ExecuteReader()

            While MonReaderIDetudiant.Read()
                If (MonReaderIDetudiant.GetString(1) = MainForm.nom_etudiant_ajout.Text) Then
                    If (MonReaderIDetudiant.GetString(2) = MainForm.prenom_etudiant_ajout.Text) Then
                        If (MonReaderIDetudiant.GetString(3) = MainForm.adresse_etudiant_ajout.Text) Then
                            id_etudiant = MonReaderIDetudiant.GetInt32(0)
                        End If
                    End If
                End If
            End While

            MonReaderIDetudiant.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' Récupération de l'ID de l'établissement
        id_etablissement = ClasseSession.getEtablissementID()

        ' Liaison entre les deux ID
        Try
            Dim RequeteEtudiant As String = "INSERT INTO ajouter (id_etudiant, id_etablissement)
                                             VALUES(" & id_etudiant & ", " & id_etablissement & ")"
            Dim CommandeEtudiant As New MySqlCommand(RequeteEtudiant, Connexion)
            CommandeEtudiant.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
