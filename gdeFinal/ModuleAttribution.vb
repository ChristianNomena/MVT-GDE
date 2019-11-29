Imports Bunifu.Framework.UI
Imports MySql.Data.MySqlClient

Module ModuleAttribution
    Public Sub AttributionNote()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()
        Dim AccessValeurNote As Boolean = VerificationValeurNote()
        Dim id_matiere As Integer = RecuperationIDMatiere(MainForm.matiere_note_ajout, MainForm.ID_etudiant_note_ajout)
        Dim id_trimestre As Integer = RecuperationIDTrimestre()
        Dim id_etudiant As Integer = CInt(MainForm.ID_etudiant_note_ajout.selectedValue)

        If (AccessValeurNote) Then
            Try
                Dim RequeteNote As String = "INSERT INTO note (valeur_note, id_matiere, id_trimestre, id_etudiant)
                                             VALUES(" & MainForm.valeur_note_ajout.selectedValue & ", " & id_matiere & ", " & id_trimestre & ", " & id_etudiant & ")"
                Dim CommandeNote As New MySqlCommand(RequeteNote, Connexion)
                CommandeNote.ExecuteNonQuery()

                MainForm.matiere_note_ajout.Clear()
                MainForm.valeur_note_ajout.Clear()
                ModuleChangementDynamique.RemplissageMatiereEtudiant()
                ModuleInitialisation.RemplissageNote()

                MsgBox("Note attribuée à la matière avec succès !", 64, "Attribution note")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub



    Private Function VerificationValeurNote() As Boolean
        Dim AccessValeurNote As Boolean = True

        If (CInt(MainForm.valeur_note_ajout.selectedValue) < 0) Or (CInt(MainForm.valeur_note_ajout.selectedValue) > 20) Then
            AccessValeurNote = False
            MsgBox("Veuillez ne pas dépasser '20' pour l'attribution de la note", 48, "Erreur valeur note")
        End If

        Return AccessValeurNote
    End Function

    Public Function RecuperationIDMatiere(ByVal boxMatiere As BunifuDropdown, ByVal boxIDEtudiant As BunifuDropdown) As Integer
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()
        Dim id_matiere As Integer

        Try
            Dim RequeteIDMatiere As String = "SELECT m.id_matiere
                                              FROM matiere m, assigner a
                                              WHERE nom_matiere = '" & boxMatiere.selectedValue & "'
                                              AND m.id_matiere = a.id_matiere
                                              AND a.id_etudiant = " & CInt(boxIDEtudiant.selectedValue)
            Dim CommandeIDMatiere As New MySqlCommand(RequeteIDMatiere, Connexion)
            Dim MonReaderIDMatiere As MySqlDataReader = CommandeIDMatiere.ExecuteReader()

            If MonReaderIDMatiere.Read() Then
                id_matiere = MonReaderIDMatiere.GetInt32(0)
            End If

            MonReaderIDMatiere.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return id_matiere
    End Function

    Private Function RecuperationIDTrimestre() As Integer
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()
        Dim id_trimestre As Integer

        Try
            Dim RequeteIDTrimestre As String = "SELECT t.id_trimestre
                                                FROM trimestre t, lier l, matiere m, assigner a
                                                WHERE numero_trimestre = " & CInt(MainForm.trimestre_note_ajout.selectedValue) & "
                                                AND nom_matiere = '" & MainForm.matiere_note_ajout.selectedValue & "'
                                                AND t.id_trimestre = l.id_trimestre
                                                AND l.id_matiere = m.id_matiere
                                                AND m.id_matiere = a.id_matiere
                                                AND a.id_etudiant = " & CInt(MainForm.ID_etudiant_note_ajout.selectedValue)
            Dim CommandeIDTrimestre As New MySqlCommand(RequeteIDTrimestre, Connexion)
            Dim MonReaderIDTrimestre As MySqlDataReader = CommandeIDTrimestre.ExecuteReader()

            While MonReaderIDTrimestre.Read()
                id_trimestre = MonReaderIDTrimestre.GetInt32(0)
            End While

            MonReaderIDTrimestre.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return id_trimestre
    End Function
End Module
