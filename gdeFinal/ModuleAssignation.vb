Imports MySql.Data.MySqlClient

Module ModuleAssignation
    Public Sub AssignationMatiere()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()

        Try
            Dim RequeteMatiere As String = "INSERT INTO matiere (nom_matiere, coe_matiere)
                                            VALUES('" & MainForm.nom_matiere_ajout.selectedValue & "', " & MainForm.coe_matiere_ajout.selectedValue & ")"
            Dim CommandeMatiere As New MySqlCommand(RequeteMatiere, Connexion)
            CommandeMatiere.ExecuteNonQuery()
            LiaisonMatiereEtudiant()
            InitialisationTrimestre()

            MainForm.nom_matiere_ajout.Clear()
            MainForm.coe_matiere_ajout.Clear()
            ModuleChangementDynamique.RemplissageMatiere(MainForm.categorie_matiere_ajout, MainForm.nom_matiere_ajout)
            ModuleInitialisation.RemplissageCoefficient()

            MsgBox("Matière assignée à l'étudiant avec succès !", 64, "Assignation matière")
        Catch ex As Exception
            MsgBox("1 : " & ex.Message)
        End Try
    End Sub



    Private Sub LiaisonMatiereEtudiant()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()
        Dim id_matiere As Integer
        Dim id_etudiant As Integer

        ' Récupération de l'ID de l'étudiant
        id_etudiant = CInt(MainForm.ID_etudiant_matiere_ajout.selectedValue)

        ' Récupération de l'ID de la matière
        Try
            Dim RequeteIDMatiere As String = "SELECT id_matiere
                                              FROM matiere
                                              WHERE nom_matiere = '" & MainForm.nom_matiere_ajout.selectedValue & "'
                                              ORDER BY id_matiere DESC"
            Dim CommandeIDMatiere As New MySqlCommand(RequeteIDMatiere, Connexion)
            Dim MonReaderIDMatiere As MySqlDataReader = CommandeIDMatiere.ExecuteReader()

            If MonReaderIDMatiere.Read() Then
                id_matiere = MonReaderIDMatiere.GetInt32(0)
            End If

            MonReaderIDMatiere.Close()
        Catch ex As Exception
            MsgBox("2 : " & ex.Message)
        End Try

        ' Liaison entre les deux ID
        Try
            Dim RequeteMatiere As String = "INSERT INTO assigner (id_matiere, id_etudiant)
                                            VALUES(" & id_matiere & ", " & id_etudiant & ")"
            Dim CommandeMatiere As New MySqlCommand(RequeteMatiere, Connexion)
            CommandeMatiere.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("3 : " & ex.Message)
        End Try
    End Sub

    Private Sub InitialisationTrimestre()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()
        Dim numero_trimestre As Integer = 1
        Dim id_matiere As Integer = ModuleAttribution.RecuperationIDMatiere(MainForm.nom_matiere_ajout, MainForm.ID_etudiant_matiere_ajout)
        Dim id_trimestre As Integer

        While (numero_trimestre <= 3)
            Try
                Dim RequeteTrimestre As String = "INSERT INTO trimestre (numero_trimestre)
                                                  VALUES(" & numero_trimestre & ")"
                Dim CommandeTrimestre As New MySqlCommand(RequeteTrimestre, Connexion)
                CommandeTrimestre.ExecuteNonQuery()

                id_trimestre = RecuperationIDTrimestre()
                LiaisonMatiereTrimestre(id_matiere, id_trimestre)
            Catch ex As Exception
                MsgBox("4 : " & ex.Message)
            End Try
            numero_trimestre += 1
        End While
    End Sub

    Private Function RecuperationIDTrimestre()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()
        Dim id_trimestre As Integer

        Try
            Dim RequeteIDTrimestre As String = "SELECT id_trimestre
                                                FROM trimestre
                                                ORDER BY id_trimestre DESC"
            Dim CommandeIDTrimestre As New MySqlCommand(RequeteIDTrimestre, Connexion)
            Dim MonReaderIDTrimestre As MySqlDataReader = CommandeIDTrimestre.ExecuteReader()

            If MonReaderIDTrimestre.Read() Then
                id_trimestre = MonReaderIDTrimestre.GetInt32(0)
            End If

            MonReaderIDTrimestre.Close()
        Catch ex As Exception
            MsgBox("5 : " & ex.Message)
        End Try

        Return id_trimestre
    End Function

    Private Sub LiaisonMatiereTrimestre(ByVal id_matiere As Integer, ByVal id_trimestre As Integer)
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()

        Try
            Dim RequeteMatiereTrimestre As String = "INSERT INTO lier (id_matiere, id_trimestre)
                                                     VALUES(" & id_matiere & ", " & id_trimestre & ")"
            Dim CommandeMatiereTrimestre As New MySqlCommand(RequeteMatiereTrimestre, Connexion)
            CommandeMatiereTrimestre.ExecuteNonQuery()

            id_trimestre = RecuperationIDTrimestre()
        Catch ex As Exception
            MsgBox("6 : " & ex.Message)
        End Try
    End Sub
End Module
