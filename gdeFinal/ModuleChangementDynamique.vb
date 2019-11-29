Imports Bunifu.Framework.UI
Imports MySql.Data.MySqlClient

Module ModuleChangementDynamique
    Public Sub RemplissageClasse(ByVal boxCategorie As BunifuDropdown, ByVal boxClasse As BunifuDropdown)
        Dim niveau As String = boxCategorie.selectedValue

        boxClasse.Clear()

        Dim EcolePrimaireTab(5) As String
        Dim CollegeTab(3) As String
        Dim LyceeTab(5) As String

        EcolePrimaireTab(0) = "12ème"
        EcolePrimaireTab(1) = "11ème"
        EcolePrimaireTab(2) = "10ème"
        EcolePrimaireTab(3) = "9ème"
        EcolePrimaireTab(4) = "8ème"
        EcolePrimaireTab(5) = "7ème"

        CollegeTab(0) = "6ème"
        CollegeTab(1) = "5ème"
        CollegeTab(2) = "4ème"
        CollegeTab(3) = "3ème"

        LyceeTab(0) = "2nd"
        LyceeTab(1) = "1ère L"
        LyceeTab(2) = "1ère S"
        LyceeTab(3) = "Terminale A"
        LyceeTab(4) = "Terminale C"
        LyceeTab(5) = "Terminale D"

        If (niveau = "Ecole Primaire") Then
            For i As Integer = 0 To EcolePrimaireTab.Length - 1
                boxClasse.AddItem(EcolePrimaireTab(i))
            Next
        ElseIf (niveau = "Collège") Then
            For i As Integer = 0 To CollegeTab.Length - 1
                boxClasse.AddItem(CollegeTab(i))
            Next
        ElseIf (niveau = "Lycée") Then
            For i As Integer = 0 To LyceeTab.Length - 1
                boxClasse.AddItem(LyceeTab(i))
            Next
        End If
    End Sub



    Public Sub RemplissageIDEtudiant(ByVal boxClasse As BunifuDropdown, ByVal boxID As BunifuDropdown, ByVal Nom As BunifuMaterialTextbox)
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()

        boxID.Clear()
        Nom.Text = ""

        Try
            Dim RequeteIDEtudiant As String = "SELECT e.id_etudiant
                                               FROM etudiant e, ajouter a
                                               WHERE e.id_etudiant = a.id_etudiant
                                               AND a.id_etablissement = " & ClasseSession.getEtablissementID & "
                                               AND classe_etudiant = '" & boxClasse.selectedValue & "'
                                               ORDER BY id_etudiant"

            Dim CommandeIDEtudiant As New MySqlCommand(RequeteIDEtudiant, Connexion)
            Dim MonReaderIDEtudiant As MySqlDataReader = CommandeIDEtudiant.ExecuteReader()

            While MonReaderIDEtudiant.Read()
                boxID.AddItem(MonReaderIDEtudiant.GetInt32(0))
            End While

            MonReaderIDEtudiant.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Sub RemplissageNomEtudiant(ByVal boxID As BunifuDropdown, ByVal Nom As BunifuMaterialTextbox)
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()

        Try
            Dim RequeteNomEtudiant As String = "SELECT nom_etudiant, prenom_etudiant
                                                FROM etudiant
                                                WHERE id_etudiant = " & boxID.selectedValue & "
                                                ORDER BY nom_etudiant ASC, prenom_etudiant ASC"
            Dim CommandeNomEtudiant As New MySqlCommand(RequeteNomEtudiant, Connexion)
            Dim MonReaderNomEtudiant As MySqlDataReader = CommandeNomEtudiant.ExecuteReader()

            If MonReaderNomEtudiant.Read() Then
                Nom.Text = MonReaderNomEtudiant.GetString(0) & " " & MonReaderNomEtudiant.GetString(1)
            End If

            MonReaderNomEtudiant.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Sub RemplissageMatiere(ByVal boxCategorie As BunifuDropdown, ByVal boxMatiere As BunifuDropdown)
        Dim niveau As String = boxCategorie.selectedValue

        boxMatiere.Clear()

        Dim EcolePrimaireTab(7) As String
        Dim CollegeTab(11) As String
        Dim LyceeTab(14) As String

        EcolePrimaireTab(0) = "Calcul"
        EcolePrimaireTab(1) = "Problème"
        EcolePrimaireTab(2) = "S.V.T"
        EcolePrimaireTab(3) = "Histoire"
        EcolePrimaireTab(4) = "Géographie"
        EcolePrimaireTab(5) = "Français"
        EcolePrimaireTab(6) = "Anglais"
        EcolePrimaireTab(7) = "Education civique"

        CollegeTab(0) = "Mathématiques"
        CollegeTab(1) = "Physiques - Chimie"
        CollegeTab(2) = "S.V.T"
        CollegeTab(3) = "Histo-Géo"
        CollegeTab(4) = "Malagasy"
        CollegeTab(5) = "Français"
        CollegeTab(6) = "Anglais"
        CollegeTab(7) = "Allemand"
        CollegeTab(8) = "Espagnol"
        CollegeTab(9) = "Laboratoire"
        CollegeTab(10) = "E.P.S"
        CollegeTab(11) = "Education civique"

        LyceeTab(0) = "Mathématiques"
        LyceeTab(1) = "Physiques - Chimie"
        LyceeTab(2) = "S.V.T"
        LyceeTab(3) = "Histo-Géo"
        LyceeTab(4) = "Malagasy"
        LyceeTab(5) = "Français"
        LyceeTab(6) = "Anglais"
        LyceeTab(7) = "Allemand"
        LyceeTab(8) = "Espagnol"
        LyceeTab(9) = "Mandarin"
        LyceeTab(10) = "Japonais"
        LyceeTab(11) = "Philosophie"
        LyceeTab(12) = "Laboratoire"
        LyceeTab(13) = "E.P.S"
        LyceeTab(14) = "Education civique"

        If (niveau = "Ecole Primaire") Then
            For i As Integer = 0 To EcolePrimaireTab.Length - 1
                boxMatiere.AddItem(EcolePrimaireTab(i))
            Next
        ElseIf (niveau = "Collège") Then
            For i As Integer = 0 To CollegeTab.Length - 1
                boxMatiere.AddItem(CollegeTab(i))
            Next
        ElseIf (niveau = "Lycée") Then
            For i As Integer = 0 To LyceeTab.Length - 1
                boxMatiere.AddItem(LyceeTab(i))
            Next
        End If
    End Sub



    Public Sub RemplissageMatiereEtudiant()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()
        MainForm.matiere_note_ajout.Clear()

        Try
            Dim RequeteMatiereEtudiant As String = "SELECT nom_matiere
                                                    FROM matiere m, assigner a
                                                    WHERE m.id_matiere = a.id_matiere
                                                    AND a.id_etudiant = " & MainForm.ID_etudiant_note_ajout.selectedValue
            Dim CommandeMatiereEtudiant As New MySqlCommand(RequeteMatiereEtudiant, Connexion)
            Dim MonReaderMatiereEtudiant As MySqlDataReader = CommandeMatiereEtudiant.ExecuteReader()

            While MonReaderMatiereEtudiant.Read()
                MainForm.matiere_note_ajout.AddItem(MonReaderMatiereEtudiant(0))
            End While

            MonReaderMatiereEtudiant.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub HideModificationEtudiant()
        MainForm.nom_modification.Hide()
        MainForm.prenom_modification.Hide()
        MainForm.adresse_modification.Hide()
        MainForm.categorie_modification.Hide()
        MainForm.classe_modification.Hide()
        MainForm.numero_modification.Hide()
        MainForm.bouton_suppression_etudiant.Hide()
        MainForm.bouton_modification_etudiant.Hide()
    End Sub

    Public Sub ShowModificationEtudiant()
        MainForm.nom_modification.Show()
        MainForm.prenom_modification.Show()
        MainForm.adresse_modification.Show()
        MainForm.categorie_modification.Show()
        MainForm.classe_modification.Show()
        MainForm.numero_modification.Show()
        MainForm.bouton_suppression_etudiant.Show()
        MainForm.bouton_modification_etudiant.Show()
    End Sub

    Friend Sub NombreEtudiantEtablissement()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()
        Dim nbrEtudiant = 0

        Try
            Dim RequeteMatiereEtudiant As String = "SELECT COUNT(e.id_etudiant)
                                                    FROM etudiant e
                                                    INNER JOIN ajouter a
                                                    WHERE e.id_etudiant = a.id_etudiant
                                                    AND a.id_etablissement = " & ClasseSession.getEtablissementID()
            Dim CommandeMatiereEtudiant As New MySqlCommand(RequeteMatiereEtudiant, Connexion)
            Dim MonReaderMatiereEtudiant As MySqlDataReader = CommandeMatiereEtudiant.ExecuteReader()

            While MonReaderMatiereEtudiant.Read()
                nbrEtudiant = MonReaderMatiereEtudiant.GetInt32(0)
            End While

            MonReaderMatiereEtudiant.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        MainForm.label_nombre_eleve.Text = CStr(nbrEtudiant)
    End Sub
End Module
