Imports MySql.Data.MySqlClient

Module ModuleInitialisation
    Public Sub InitBD()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")

        Dim ReaderTest As MySqlDataReader

        ' Initialisation de la base de données et création des tables nécessaires
        Try
            ' Test de connexion à la BD
            Connexion.Open()

            Try
                ' Tentative de lecture à la BD pour vérifier si les tables ont déjà été créées
                Dim RequeteTest As String = "SELECT id_etudiant FROM etudiant"
                Dim CommandeTest As New MySqlCommand(RequeteTest, Connexion)
                ReaderTest = CommandeTest.ExecuteReader()
                ReaderTest.Close()

            Catch ex As Exception
                ' Création des tables nécessaires si elles n'ont pas encore été créées
                Dim RequeteTable As String = "  #------------------------------------------------------------
                                                #        Script MySQL.
                                                #------------------------------------------------------------


                                                #------------------------------------------------------------
                                                # Table: Etudiant
                                                #------------------------------------------------------------

                                                CREATE TABLE Etudiant(
                                                        id_etudiant        Int  Auto_increment  NOT NULL ,
                                                        nom_etudiant       Varchar (255) NOT NULL ,
                                                        prenom_etudiant    Varchar (255) NOT NULL ,
                                                        adresse_etudiant   Varchar (255) NOT NULL ,
                                                        naissance_etudiant Date NOT NULL ,
                                                        numero_etudiant    Varchar (25) NOT NULL ,
                                                        categorie_etudiant Varchar (255) NOT NULL ,
                                                        classe_etudiant    Varchar (255) NOT NULL
	                                                ,CONSTRAINT Etudiant_PK PRIMARY KEY (id_etudiant)
                                                )ENGINE=InnoDB;


                                                #------------------------------------------------------------
                                                # Table: Matiere
                                                #------------------------------------------------------------

                                                CREATE TABLE Matiere(
                                                        id_matiere  Int  Auto_increment  NOT NULL ,
                                                        nom_matiere Varchar (255) NOT NULL ,
                                                        coe_matiere Int NOT NULL
	                                                ,CONSTRAINT Matiere_PK PRIMARY KEY (id_matiere)
                                                )ENGINE=InnoDB;


                                                #------------------------------------------------------------
                                                # Table: Trimestre
                                                #------------------------------------------------------------

                                                CREATE TABLE Trimestre(
                                                        id_trimestre      Int  Auto_increment  NOT NULL ,
                                                        numero_trimestre  Int NOT NULL ,
                                                        moyenne_trimestre Decimal NULL
	                                                ,CONSTRAINT Trimestre_PK PRIMARY KEY (id_trimestre)
                                                )ENGINE=InnoDB;


                                                #------------------------------------------------------------
                                                # Table: Note
                                                #------------------------------------------------------------

                                                CREATE TABLE Note(
                                                        id_note      Int  Auto_increment  NOT NULL ,
                                                        valeur_note  Decimal NOT NULL ,
                                                        id_matiere   Int NOT NULL ,
                                                        id_trimestre Int NOT NULL ,
                                                        id_etudiant  Int NOT NULL
	                                                ,CONSTRAINT Note_PK PRIMARY KEY (id_note)

	                                                ,CONSTRAINT Note_Matiere_FK FOREIGN KEY (id_matiere) REFERENCES Matiere(id_matiere)
	                                                ,CONSTRAINT Note_Trimestre0_FK FOREIGN KEY (id_trimestre) REFERENCES Trimestre(id_trimestre)
	                                                ,CONSTRAINT Note_Etudiant1_FK FOREIGN KEY (id_etudiant) REFERENCES Etudiant(id_etudiant)
                                                )ENGINE=InnoDB;


                                                #------------------------------------------------------------
                                                # Table: Etablissement
                                                #------------------------------------------------------------

                                                CREATE TABLE Etablissement(
                                                        id_etablissement       Int  Auto_increment  NOT NULL ,
                                                        nom_etablissement      Varchar (255) NOT NULL ,
                                                        email_etablissement    Varchar (255) NOT NULL ,
                                                        adresse_etablissement  Varchar (255) NOT NULL ,
                                                        contact_etablissement   Varchar (255) NOT NULL ,
                                                        password_etablissement Varchar (255) NOT NULL
	                                                ,CONSTRAINT Etablissement_PK PRIMARY KEY (id_etablissement)
                                                )ENGINE=InnoDB;


                                                #------------------------------------------------------------
                                                # Table: Assigner
                                                #------------------------------------------------------------

                                                CREATE TABLE Assigner(
                                                        id_matiere  Int NOT NULL ,
                                                        id_etudiant Int NOT NULL
	                                                ,CONSTRAINT Assigner_PK PRIMARY KEY (id_matiere,id_etudiant)

	                                                ,CONSTRAINT Assigner_Matiere_FK FOREIGN KEY (id_matiere) REFERENCES Matiere(id_matiere)
	                                                ,CONSTRAINT Assigner_Etudiant0_FK FOREIGN KEY (id_etudiant) REFERENCES Etudiant(id_etudiant)
                                                )ENGINE=InnoDB;


                                                #------------------------------------------------------------
                                                # Table: Ajouter
                                                #------------------------------------------------------------

                                                CREATE TABLE Ajouter(
                                                        id_etudiant      Int NOT NULL ,
                                                        id_etablissement Int NOT NULL
	                                                ,CONSTRAINT Ajouter_PK PRIMARY KEY (id_etudiant,id_etablissement)

	                                                ,CONSTRAINT Ajouter_Etudiant_FK FOREIGN KEY (id_etudiant) REFERENCES Etudiant(id_etudiant)
	                                                ,CONSTRAINT Ajouter_Etablissement0_FK FOREIGN KEY (id_etablissement) REFERENCES Etablissement(id_etablissement)
                                                )ENGINE=InnoDB;


                                                #------------------------------------------------------------
                                                # Table: Lier
                                                #------------------------------------------------------------

                                                CREATE TABLE Lier(
                                                        id_matiere   Int NOT NULL ,
                                                        id_trimestre Int NOT NULL
	                                                ,CONSTRAINT Lier_PK PRIMARY KEY (id_matiere,id_trimestre)

	                                                ,CONSTRAINT Lier_Matiere_FK FOREIGN KEY (id_matiere) REFERENCES Matiere(id_matiere)
	                                                ,CONSTRAINT Lier_Trimestre0_FK FOREIGN KEY (id_trimestre) REFERENCES Trimestre(id_trimestre)
                                                )ENGINE=InnoDB;"

                Dim CommandeTable As New MySqlCommand(RequeteTable, Connexion)
                CommandeTable.ExecuteNonQuery()
                CommandeTable.Dispose()
            End Try

        Catch ex As Exception
            ' Création de la BD dans le serveur
            Dim NewDatabaseConnexion As New MySqlConnection("Server=localhost;Database=;Uid=root;Pwd=;")
            Try
                NewDatabaseConnexion.Open()
                Dim Requete As String = "CREATE DATABASE GDE"
                Dim Commande As New MySqlCommand(Requete, NewDatabaseConnexion)
                Commande.ExecuteNonQuery()
                Commande.Dispose()
                Connexion.Close()
                NewDatabaseConnexion.Close()
                MsgBox("Votre base de données vient d'être initialisée" & Chr(13) &
                       "Merci de bien vouloir exécuter l'application à nouveau.", 64, "Database Initialization")
                Form1.Close()
            Catch ex1 As Exception
                MsgBox("Arrêt immédiat", 16, "Database Error")
                Form1.Close()
            End Try
        End Try
    End Sub





    Public Sub Connexion()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()

        Dim Connecter As Boolean = False

        Try
            Dim RequeteConnexion As String = "SELECT *
                                              FROM etablissement"
            Dim CommandeConnexion As New MySqlCommand(RequeteConnexion, Connexion)
            Dim MonReaderConnexion As MySqlDataReader = CommandeConnexion.ExecuteReader()

            ' Mettre les données de la table ETUDIANT de la colonne NOM_ETUDIANT en tant qu'option du formulaire etudiant
            While MonReaderConnexion.Read()
                If (MonReaderConnexion.GetString(2) = Form1.email_login.Text) Then
                    If (MonReaderConnexion.GetString(5) = Form1.password_login.Text) Then
                        Connecter = True

                        ' Session de l'utilisateur
                        ClasseSession.setEtablissementID(MonReaderConnexion.GetInt32(0))
                        ClasseSession.setEtablissementNom(MonReaderConnexion.GetString(1))
                        ClasseSession.setEtablissementMail(MonReaderConnexion.GetString(2))
                        ClasseSession.setEtablissementAdresse(MonReaderConnexion.GetString(3))
                        ClasseSession.setEtablissementContact(MonReaderConnexion.GetString(4))
                        ClasseSession.setEtablissementPassword(MonReaderConnexion.GetString(5))
                    End If
                End If
            End While

            MonReaderConnexion.Close()
        Catch ex As Exception

        End Try

        If (Connecter) Then
            Form1.Hide()
            MainForm.Enabled = True
            MainForm.Show()
        Else
            MsgBox("Veuillez vérifier toutes les informations nécéssaires", 48, "Information error")
        End If
    End Sub





    Public Sub Enregistrement()
        Dim Connexion As New MySqlConnection("Server=localhost;Database=GDE;Uid=root;Pwd=;")
        Connexion.Open()

        Try
            Dim RequeteEnregistrement As String = "INSERT INTO etablissement (nom_etablissement, email_etablissement, adresse_etablissement, contact_etablissement, password_etablissement)
                                                   VALUES ('" & Form1.nom_register.Text & "', '" & Form1.email_register.Text & "', '" & Form1.adresse_register.Text & "', '" & Form1.contact_register.Text & "', '" & Form1.password_register.Text & "')"
            Dim CommandeEnregistrement As New MySqlCommand(RequeteEnregistrement, Connexion)
            CommandeEnregistrement.ExecuteNonQuery()
            MsgBox("Compte créé avec succès", 64, "Account created")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Public Sub RemplissageCategorie()
        MainForm.categorie_etudiant_ajout.AddItem("Ecole Primaire")
        MainForm.categorie_etudiant_ajout.AddItem("Collège")
        MainForm.categorie_etudiant_ajout.AddItem("Lycée")

        MainForm.categorie_matiere_ajout.AddItem("Ecole Primaire")
        MainForm.categorie_matiere_ajout.AddItem("Collège")
        MainForm.categorie_matiere_ajout.AddItem("Lycée")

        MainForm.categorie_note_ajout.AddItem("Ecole Primaire")
        MainForm.categorie_note_ajout.AddItem("Collège")
        MainForm.categorie_note_ajout.AddItem("Lycée")

        MainForm.categorie_affichage_etudiant.AddItem("Ecole Primaire")
        MainForm.categorie_affichage_etudiant.AddItem("Collège")
        MainForm.categorie_affichage_etudiant.AddItem("Lycée")
    End Sub

    Public Sub RemplissageTrimestre()
        MainForm.trimestre_note_ajout.AddItem("1")
        MainForm.trimestre_note_ajout.AddItem("2")
        MainForm.trimestre_note_ajout.AddItem("3")
    End Sub

    Public Sub RemplissageCoefficient()
        MainForm.coe_matiere_ajout.AddItem("1")
        MainForm.coe_matiere_ajout.AddItem("2")
        MainForm.coe_matiere_ajout.AddItem("3")
        MainForm.coe_matiere_ajout.AddItem("4")
        MainForm.coe_matiere_ajout.AddItem("5")
    End Sub

    Public Sub RemplissageNote()
        MainForm.valeur_note_ajout.AddItem("0")
        MainForm.valeur_note_ajout.AddItem("1")
        MainForm.valeur_note_ajout.AddItem("2")
        MainForm.valeur_note_ajout.AddItem("3")
        MainForm.valeur_note_ajout.AddItem("4")
        MainForm.valeur_note_ajout.AddItem("5")
        MainForm.valeur_note_ajout.AddItem("6")
        MainForm.valeur_note_ajout.AddItem("7")
        MainForm.valeur_note_ajout.AddItem("8")
        MainForm.valeur_note_ajout.AddItem("9")
        MainForm.valeur_note_ajout.AddItem("10")
        MainForm.valeur_note_ajout.AddItem("11")
        MainForm.valeur_note_ajout.AddItem("12")
        MainForm.valeur_note_ajout.AddItem("13")
        MainForm.valeur_note_ajout.AddItem("14")
        MainForm.valeur_note_ajout.AddItem("15")
        MainForm.valeur_note_ajout.AddItem("16")
        MainForm.valeur_note_ajout.AddItem("17")
        MainForm.valeur_note_ajout.AddItem("18")
        MainForm.valeur_note_ajout.AddItem("19")
        MainForm.valeur_note_ajout.AddItem("20")
    End Sub
End Module
