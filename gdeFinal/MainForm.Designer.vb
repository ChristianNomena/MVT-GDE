<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.MainHeader = New System.Windows.Forms.Panel()
        Me.Main_bouton_quitter = New Bunifu.Framework.UI.BunifuImageButton()
        Me.nom_etab = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Lefter = New System.Windows.Forms.Panel()
        Me.bouton_deconnexion = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.bouton_parametreCompte = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bouton_affichage = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bouton_ajoutNote = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bouton_ajoutMatiere = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bouton_ajoutEtudiant = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bouton_home = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MainPages = New Bunifu.UI.WinForms.BunifuPages()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BunifuRating1 = New Bunifu.Framework.UI.BunifuRating()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label_nombre_eleve = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.bouton_etudiant_ajout = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.naissance_etudiant_ajout = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.numero_etudiant_ajout = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.adresse_etudiant_ajout = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.prenom_etudiant_ajout = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.nom_etudiant_ajout = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.classe_etudiant_ajout = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.categorie_etudiant_ajout = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.nom_etudiant_matiere_ajout = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.bouton_matiere_ajout = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.classe_matiere_ajout = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.coe_matiere_ajout = New Bunifu.Framework.UI.BunifuDropdown()
        Me.nom_matiere_ajout = New Bunifu.Framework.UI.BunifuDropdown()
        Me.ID_etudiant_matiere_ajout = New Bunifu.Framework.UI.BunifuDropdown()
        Me.categorie_matiere_ajout = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.nom_etudiant_note_ajout = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.bouton_note_ajout = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.matiere_note_ajout = New Bunifu.Framework.UI.BunifuDropdown()
        Me.valeur_note_ajout = New Bunifu.Framework.UI.BunifuDropdown()
        Me.trimestre_note_ajout = New Bunifu.Framework.UI.BunifuDropdown()
        Me.ID_etudiant_note_ajout = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.classe_note_ajout = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.categorie_note_ajout = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.recherche_etudiant = New Bunifu.Framework.UI.BunifuTextbox()
        Me.liste_etudiant = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.bouton_modification_etudiant = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.bouton_suppression_etudiant = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.numero_modification = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.classe_modification = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.categorie_modification = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.adresse_modification = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.prenom_modification = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.nom_modification = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.bouton_modifier = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.classe_affichage_etudiant = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.categorie_affichage_etudiant = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.bouton_actualiser = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.password_etab_compte = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.contact_etab_compte = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.mail_etab_compte = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.adresse_etab_compte = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.nom_etab_compte = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BunifuDragControlMain = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.MainHeader.SuspendLayout()
        CType(Me.Main_bouton_quitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Lefter.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPages.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.liste_etudiant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'MainHeader
        '
        Me.MainHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.MainHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainHeader.Controls.Add(Me.Main_bouton_quitter)
        Me.MainHeader.Controls.Add(Me.nom_etab)
        Me.MainHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.MainHeader.Location = New System.Drawing.Point(0, 0)
        Me.MainHeader.Name = "MainHeader"
        Me.MainHeader.Size = New System.Drawing.Size(1200, 44)
        Me.MainHeader.TabIndex = 0
        '
        'Main_bouton_quitter
        '
        Me.Main_bouton_quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Main_bouton_quitter.Image = CType(resources.GetObject("Main_bouton_quitter.Image"), System.Drawing.Image)
        Me.Main_bouton_quitter.ImageActive = Nothing
        Me.Main_bouton_quitter.InitialImage = Nothing
        Me.Main_bouton_quitter.Location = New System.Drawing.Point(1162, 6)
        Me.Main_bouton_quitter.Name = "Main_bouton_quitter"
        Me.Main_bouton_quitter.Size = New System.Drawing.Size(30, 30)
        Me.Main_bouton_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Main_bouton_quitter.TabIndex = 3
        Me.Main_bouton_quitter.TabStop = False
        Me.Main_bouton_quitter.Zoom = 10
        '
        'nom_etab
        '
        Me.nom_etab.AutoSize = True
        Me.nom_etab.Enabled = False
        Me.nom_etab.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_etab.ForeColor = System.Drawing.Color.White
        Me.nom_etab.Location = New System.Drawing.Point(12, 9)
        Me.nom_etab.Name = "nom_etab"
        Me.nom_etab.Size = New System.Drawing.Size(235, 26)
        Me.nom_etab.TabIndex = 2
        Me.nom_etab.Text = "Gestion Des Etudiants"
        '
        'Lefter
        '
        Me.Lefter.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Lefter.Controls.Add(Me.bouton_deconnexion)
        Me.Lefter.Controls.Add(Me.logo)
        Me.Lefter.Controls.Add(Me.bouton_parametreCompte)
        Me.Lefter.Controls.Add(Me.bouton_affichage)
        Me.Lefter.Controls.Add(Me.bouton_ajoutNote)
        Me.Lefter.Controls.Add(Me.bouton_ajoutMatiere)
        Me.Lefter.Controls.Add(Me.bouton_ajoutEtudiant)
        Me.Lefter.Controls.Add(Me.bouton_home)
        Me.Lefter.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lefter.Location = New System.Drawing.Point(0, 44)
        Me.Lefter.Name = "Lefter"
        Me.Lefter.Size = New System.Drawing.Size(230, 556)
        Me.Lefter.TabIndex = 1
        '
        'bouton_deconnexion
        '
        Me.bouton_deconnexion.BackColor = System.Drawing.Color.Transparent
        Me.bouton_deconnexion.BackgroundImage = CType(resources.GetObject("bouton_deconnexion.BackgroundImage"), System.Drawing.Image)
        Me.bouton_deconnexion.ButtonText = "Déconnexion"
        Me.bouton_deconnexion.ButtonTextMarginLeft = 0
        Me.bouton_deconnexion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_deconnexion.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.bouton_deconnexion.DisabledFillColor = System.Drawing.Color.Gray
        Me.bouton_deconnexion.DisabledForecolor = System.Drawing.Color.White
        Me.bouton_deconnexion.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bouton_deconnexion.ForeColor = System.Drawing.Color.White
        Me.bouton_deconnexion.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_deconnexion.IconPadding = 10
        Me.bouton_deconnexion.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_deconnexion.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.bouton_deconnexion.IdleBorderRadius = 1
        Me.bouton_deconnexion.IdleBorderThickness = 1
        Me.bouton_deconnexion.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.bouton_deconnexion.IdleIconLeftImage = Nothing
        Me.bouton_deconnexion.IdleIconRightImage = Nothing
        Me.bouton_deconnexion.Location = New System.Drawing.Point(8, 503)
        Me.bouton_deconnexion.Name = "bouton_deconnexion"
        StateProperties5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties5.BorderRadius = 1
        StateProperties5.BorderThickness = 1
        StateProperties5.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties5.ForeColor = System.Drawing.Color.White
        StateProperties5.IconLeftImage = Nothing
        StateProperties5.IconRightImage = Nothing
        Me.bouton_deconnexion.onHoverState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties6.BorderRadius = 1
        StateProperties6.BorderThickness = 1
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.White
        StateProperties6.IconLeftImage = Nothing
        StateProperties6.IconRightImage = Nothing
        Me.bouton_deconnexion.OnPressedState = StateProperties6
        Me.bouton_deconnexion.Size = New System.Drawing.Size(212, 41)
        Me.bouton_deconnexion.TabIndex = 19
        Me.bouton_deconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 6)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(210, 109)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.logo.TabIndex = 1
        Me.logo.TabStop = False
        '
        'bouton_parametreCompte
        '
        Me.bouton_parametreCompte.Activecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.bouton_parametreCompte.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bouton_parametreCompte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bouton_parametreCompte.BorderRadius = 0
        Me.bouton_parametreCompte.ButtonText = "Paramètres du compte"
        Me.bouton_parametreCompte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_parametreCompte.DisabledColor = System.Drawing.Color.Gray
        Me.bouton_parametreCompte.Iconcolor = System.Drawing.Color.Transparent
        Me.bouton_parametreCompte.Iconimage = CType(resources.GetObject("bouton_parametreCompte.Iconimage"), System.Drawing.Image)
        Me.bouton_parametreCompte.Iconimage_right = Nothing
        Me.bouton_parametreCompte.Iconimage_right_Selected = Nothing
        Me.bouton_parametreCompte.Iconimage_Selected = Nothing
        Me.bouton_parametreCompte.IconMarginLeft = 0
        Me.bouton_parametreCompte.IconMarginRight = 0
        Me.bouton_parametreCompte.IconRightVisible = True
        Me.bouton_parametreCompte.IconRightZoom = 0R
        Me.bouton_parametreCompte.IconVisible = True
        Me.bouton_parametreCompte.IconZoom = 65.0R
        Me.bouton_parametreCompte.IsTab = False
        Me.bouton_parametreCompte.Location = New System.Drawing.Point(12, 441)
        Me.bouton_parametreCompte.Name = "bouton_parametreCompte"
        Me.bouton_parametreCompte.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bouton_parametreCompte.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_parametreCompte.OnHoverTextColor = System.Drawing.Color.White
        Me.bouton_parametreCompte.selected = False
        Me.bouton_parametreCompte.Size = New System.Drawing.Size(212, 48)
        Me.bouton_parametreCompte.TabIndex = 0
        Me.bouton_parametreCompte.Text = "Paramètres du compte"
        Me.bouton_parametreCompte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bouton_parametreCompte.Textcolor = System.Drawing.Color.White
        Me.bouton_parametreCompte.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bouton_affichage
        '
        Me.bouton_affichage.Activecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.bouton_affichage.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bouton_affichage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bouton_affichage.BorderRadius = 0
        Me.bouton_affichage.ButtonText = "Afficher les données"
        Me.bouton_affichage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_affichage.DisabledColor = System.Drawing.Color.Gray
        Me.bouton_affichage.Iconcolor = System.Drawing.Color.Transparent
        Me.bouton_affichage.Iconimage = CType(resources.GetObject("bouton_affichage.Iconimage"), System.Drawing.Image)
        Me.bouton_affichage.Iconimage_right = Nothing
        Me.bouton_affichage.Iconimage_right_Selected = Nothing
        Me.bouton_affichage.Iconimage_Selected = Nothing
        Me.bouton_affichage.IconMarginLeft = 0
        Me.bouton_affichage.IconMarginRight = 0
        Me.bouton_affichage.IconRightVisible = True
        Me.bouton_affichage.IconRightZoom = 0R
        Me.bouton_affichage.IconVisible = True
        Me.bouton_affichage.IconZoom = 65.0R
        Me.bouton_affichage.IsTab = False
        Me.bouton_affichage.Location = New System.Drawing.Point(12, 377)
        Me.bouton_affichage.Name = "bouton_affichage"
        Me.bouton_affichage.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bouton_affichage.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_affichage.OnHoverTextColor = System.Drawing.Color.White
        Me.bouton_affichage.selected = False
        Me.bouton_affichage.Size = New System.Drawing.Size(212, 48)
        Me.bouton_affichage.TabIndex = 0
        Me.bouton_affichage.Text = "Afficher les données"
        Me.bouton_affichage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bouton_affichage.Textcolor = System.Drawing.Color.White
        Me.bouton_affichage.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bouton_ajoutNote
        '
        Me.bouton_ajoutNote.Activecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.bouton_ajoutNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bouton_ajoutNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bouton_ajoutNote.BorderRadius = 0
        Me.bouton_ajoutNote.ButtonText = "Attribuer une note"
        Me.bouton_ajoutNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_ajoutNote.DisabledColor = System.Drawing.Color.Gray
        Me.bouton_ajoutNote.Iconcolor = System.Drawing.Color.Transparent
        Me.bouton_ajoutNote.Iconimage = CType(resources.GetObject("bouton_ajoutNote.Iconimage"), System.Drawing.Image)
        Me.bouton_ajoutNote.Iconimage_right = Nothing
        Me.bouton_ajoutNote.Iconimage_right_Selected = Nothing
        Me.bouton_ajoutNote.Iconimage_Selected = Nothing
        Me.bouton_ajoutNote.IconMarginLeft = 0
        Me.bouton_ajoutNote.IconMarginRight = 0
        Me.bouton_ajoutNote.IconRightVisible = True
        Me.bouton_ajoutNote.IconRightZoom = 0R
        Me.bouton_ajoutNote.IconVisible = True
        Me.bouton_ajoutNote.IconZoom = 65.0R
        Me.bouton_ajoutNote.IsTab = False
        Me.bouton_ajoutNote.Location = New System.Drawing.Point(12, 313)
        Me.bouton_ajoutNote.Name = "bouton_ajoutNote"
        Me.bouton_ajoutNote.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bouton_ajoutNote.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_ajoutNote.OnHoverTextColor = System.Drawing.Color.White
        Me.bouton_ajoutNote.selected = False
        Me.bouton_ajoutNote.Size = New System.Drawing.Size(212, 48)
        Me.bouton_ajoutNote.TabIndex = 0
        Me.bouton_ajoutNote.Text = "Attribuer une note"
        Me.bouton_ajoutNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bouton_ajoutNote.Textcolor = System.Drawing.Color.White
        Me.bouton_ajoutNote.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bouton_ajoutMatiere
        '
        Me.bouton_ajoutMatiere.Activecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.bouton_ajoutMatiere.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bouton_ajoutMatiere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bouton_ajoutMatiere.BorderRadius = 0
        Me.bouton_ajoutMatiere.ButtonText = "Assigner une matière"
        Me.bouton_ajoutMatiere.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_ajoutMatiere.DisabledColor = System.Drawing.Color.Gray
        Me.bouton_ajoutMatiere.Iconcolor = System.Drawing.Color.Transparent
        Me.bouton_ajoutMatiere.Iconimage = CType(resources.GetObject("bouton_ajoutMatiere.Iconimage"), System.Drawing.Image)
        Me.bouton_ajoutMatiere.Iconimage_right = Nothing
        Me.bouton_ajoutMatiere.Iconimage_right_Selected = Nothing
        Me.bouton_ajoutMatiere.Iconimage_Selected = Nothing
        Me.bouton_ajoutMatiere.IconMarginLeft = 0
        Me.bouton_ajoutMatiere.IconMarginRight = 0
        Me.bouton_ajoutMatiere.IconRightVisible = True
        Me.bouton_ajoutMatiere.IconRightZoom = 0R
        Me.bouton_ajoutMatiere.IconVisible = True
        Me.bouton_ajoutMatiere.IconZoom = 65.0R
        Me.bouton_ajoutMatiere.IsTab = False
        Me.bouton_ajoutMatiere.Location = New System.Drawing.Point(12, 249)
        Me.bouton_ajoutMatiere.Name = "bouton_ajoutMatiere"
        Me.bouton_ajoutMatiere.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bouton_ajoutMatiere.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_ajoutMatiere.OnHoverTextColor = System.Drawing.Color.White
        Me.bouton_ajoutMatiere.selected = False
        Me.bouton_ajoutMatiere.Size = New System.Drawing.Size(212, 48)
        Me.bouton_ajoutMatiere.TabIndex = 0
        Me.bouton_ajoutMatiere.Text = "Assigner une matière"
        Me.bouton_ajoutMatiere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bouton_ajoutMatiere.Textcolor = System.Drawing.Color.White
        Me.bouton_ajoutMatiere.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bouton_ajoutEtudiant
        '
        Me.bouton_ajoutEtudiant.Activecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.bouton_ajoutEtudiant.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bouton_ajoutEtudiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bouton_ajoutEtudiant.BorderRadius = 0
        Me.bouton_ajoutEtudiant.ButtonText = "Ajouter un étudiant"
        Me.bouton_ajoutEtudiant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_ajoutEtudiant.DisabledColor = System.Drawing.Color.Gray
        Me.bouton_ajoutEtudiant.Iconcolor = System.Drawing.Color.Transparent
        Me.bouton_ajoutEtudiant.Iconimage = CType(resources.GetObject("bouton_ajoutEtudiant.Iconimage"), System.Drawing.Image)
        Me.bouton_ajoutEtudiant.Iconimage_right = Nothing
        Me.bouton_ajoutEtudiant.Iconimage_right_Selected = Nothing
        Me.bouton_ajoutEtudiant.Iconimage_Selected = Nothing
        Me.bouton_ajoutEtudiant.IconMarginLeft = 0
        Me.bouton_ajoutEtudiant.IconMarginRight = 0
        Me.bouton_ajoutEtudiant.IconRightVisible = True
        Me.bouton_ajoutEtudiant.IconRightZoom = 0R
        Me.bouton_ajoutEtudiant.IconVisible = True
        Me.bouton_ajoutEtudiant.IconZoom = 65.0R
        Me.bouton_ajoutEtudiant.IsTab = False
        Me.bouton_ajoutEtudiant.Location = New System.Drawing.Point(12, 185)
        Me.bouton_ajoutEtudiant.Name = "bouton_ajoutEtudiant"
        Me.bouton_ajoutEtudiant.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bouton_ajoutEtudiant.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_ajoutEtudiant.OnHoverTextColor = System.Drawing.Color.White
        Me.bouton_ajoutEtudiant.selected = False
        Me.bouton_ajoutEtudiant.Size = New System.Drawing.Size(212, 48)
        Me.bouton_ajoutEtudiant.TabIndex = 0
        Me.bouton_ajoutEtudiant.Text = "Ajouter un étudiant"
        Me.bouton_ajoutEtudiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bouton_ajoutEtudiant.Textcolor = System.Drawing.Color.White
        Me.bouton_ajoutEtudiant.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bouton_home
        '
        Me.bouton_home.Activecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.bouton_home.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bouton_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bouton_home.BorderRadius = 0
        Me.bouton_home.ButtonText = "Accueil"
        Me.bouton_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_home.DisabledColor = System.Drawing.Color.Gray
        Me.bouton_home.Iconcolor = System.Drawing.Color.Transparent
        Me.bouton_home.Iconimage = CType(resources.GetObject("bouton_home.Iconimage"), System.Drawing.Image)
        Me.bouton_home.Iconimage_right = Nothing
        Me.bouton_home.Iconimage_right_Selected = Nothing
        Me.bouton_home.Iconimage_Selected = Nothing
        Me.bouton_home.IconMarginLeft = 0
        Me.bouton_home.IconMarginRight = 0
        Me.bouton_home.IconRightVisible = True
        Me.bouton_home.IconRightZoom = 0R
        Me.bouton_home.IconVisible = True
        Me.bouton_home.IconZoom = 65.0R
        Me.bouton_home.IsTab = False
        Me.bouton_home.Location = New System.Drawing.Point(12, 121)
        Me.bouton_home.Name = "bouton_home"
        Me.bouton_home.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.bouton_home.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_home.OnHoverTextColor = System.Drawing.Color.White
        Me.bouton_home.selected = False
        Me.bouton_home.Size = New System.Drawing.Size(212, 48)
        Me.bouton_home.TabIndex = 0
        Me.bouton_home.Text = "Accueil"
        Me.bouton_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bouton_home.Textcolor = System.Drawing.Color.White
        Me.bouton_home.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MainPages
        '
        Me.MainPages.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.MainPages.Controls.Add(Me.TabPage1)
        Me.MainPages.Controls.Add(Me.TabPage2)
        Me.MainPages.Controls.Add(Me.TabPage3)
        Me.MainPages.Controls.Add(Me.TabPage4)
        Me.MainPages.Controls.Add(Me.TabPage5)
        Me.MainPages.Controls.Add(Me.TabPage6)
        Me.MainPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPages.Location = New System.Drawing.Point(230, 44)
        Me.MainPages.Multiline = True
        Me.MainPages.Name = "MainPages"
        Me.MainPages.SelectedIndex = 0
        Me.MainPages.Size = New System.Drawing.Size(970, 556)
        Me.MainPages.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.BunifuRating1)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.label_nombre_eleve)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(962, 530)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        '
        'BunifuRating1
        '
        Me.BunifuRating1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuRating1.Enabled = False
        Me.BunifuRating1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuRating1.Location = New System.Drawing.Point(686, 15)
        Me.BunifuRating1.Name = "BunifuRating1"
        Me.BunifuRating1.Size = New System.Drawing.Size(259, 38)
        Me.BunifuRating1.TabIndex = 9
        Me.BunifuRating1.Value = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 419)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'label_nombre_eleve
        '
        Me.label_nombre_eleve.AutoSize = True
        Me.label_nombre_eleve.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_nombre_eleve.ForeColor = System.Drawing.Color.White
        Me.label_nombre_eleve.Location = New System.Drawing.Point(611, 281)
        Me.label_nombre_eleve.Name = "label_nombre_eleve"
        Me.label_nombre_eleve.Size = New System.Drawing.Size(22, 24)
        Me.label_nombre_eleve.TabIndex = 6
        Me.label_nombre_eleve.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(370, 281)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(235, 24)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Nombre total d'élèves :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(441, 242)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(123, 24)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Bienvenue !"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.bouton_etudiant_ajout)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.naissance_etudiant_ajout)
        Me.TabPage2.Controls.Add(Me.numero_etudiant_ajout)
        Me.TabPage2.Controls.Add(Me.adresse_etudiant_ajout)
        Me.TabPage2.Controls.Add(Me.prenom_etudiant_ajout)
        Me.TabPage2.Controls.Add(Me.nom_etudiant_ajout)
        Me.TabPage2.Controls.Add(Me.classe_etudiant_ajout)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.categorie_etudiant_ajout)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(962, 530)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ajout Etudiant"
        '
        'bouton_etudiant_ajout
        '
        Me.bouton_etudiant_ajout.ActiveBorderThickness = 1
        Me.bouton_etudiant_ajout.ActiveCornerRadius = 20
        Me.bouton_etudiant_ajout.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_etudiant_ajout.ActiveForecolor = System.Drawing.Color.White
        Me.bouton_etudiant_ajout.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_etudiant_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.bouton_etudiant_ajout.BackgroundImage = CType(resources.GetObject("bouton_etudiant_ajout.BackgroundImage"), System.Drawing.Image)
        Me.bouton_etudiant_ajout.ButtonText = "Ajouter l'étudiant"
        Me.bouton_etudiant_ajout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_etudiant_ajout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bouton_etudiant_ajout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_etudiant_ajout.IdleBorderThickness = 1
        Me.bouton_etudiant_ajout.IdleCornerRadius = 20
        Me.bouton_etudiant_ajout.IdleFillColor = System.Drawing.Color.Transparent
        Me.bouton_etudiant_ajout.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_etudiant_ajout.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_etudiant_ajout.Location = New System.Drawing.Point(276, 733)
        Me.bouton_etudiant_ajout.Margin = New System.Windows.Forms.Padding(5)
        Me.bouton_etudiant_ajout.Name = "bouton_etudiant_ajout"
        Me.bouton_etudiant_ajout.Size = New System.Drawing.Size(379, 53)
        Me.bouton_etudiant_ajout.TabIndex = 11
        Me.bouton_etudiant_ajout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(272, 587)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Date de naissance"
        '
        'naissance_etudiant_ajout
        '
        Me.naissance_etudiant_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.naissance_etudiant_ajout.BorderRadius = 0
        Me.naissance_etudiant_ajout.ForeColor = System.Drawing.Color.White
        Me.naissance_etudiant_ajout.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.naissance_etudiant_ajout.FormatCustom = Nothing
        Me.naissance_etudiant_ajout.Location = New System.Drawing.Point(276, 610)
        Me.naissance_etudiant_ajout.Name = "naissance_etudiant_ajout"
        Me.naissance_etudiant_ajout.Size = New System.Drawing.Size(379, 33)
        Me.naissance_etudiant_ajout.TabIndex = 9
        Me.naissance_etudiant_ajout.Tag = ""
        Me.naissance_etudiant_ajout.Value = New Date(2019, 7, 22, 15, 1, 40, 666)
        '
        'numero_etudiant_ajout
        '
        Me.numero_etudiant_ajout.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numero_etudiant_ajout.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.numero_etudiant_ajout.ForeColor = System.Drawing.Color.White
        Me.numero_etudiant_ajout.HintForeColor = System.Drawing.Color.White
        Me.numero_etudiant_ajout.HintText = "Numéro de classe"
        Me.numero_etudiant_ajout.isPassword = False
        Me.numero_etudiant_ajout.LineFocusedColor = System.Drawing.Color.White
        Me.numero_etudiant_ajout.LineIdleColor = System.Drawing.Color.White
        Me.numero_etudiant_ajout.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.numero_etudiant_ajout.LineThickness = 3
        Me.numero_etudiant_ajout.Location = New System.Drawing.Point(276, 494)
        Me.numero_etudiant_ajout.Margin = New System.Windows.Forms.Padding(4)
        Me.numero_etudiant_ajout.Name = "numero_etudiant_ajout"
        Me.numero_etudiant_ajout.Size = New System.Drawing.Size(379, 33)
        Me.numero_etudiant_ajout.TabIndex = 8
        Me.numero_etudiant_ajout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'adresse_etudiant_ajout
        '
        Me.adresse_etudiant_ajout.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.adresse_etudiant_ajout.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.adresse_etudiant_ajout.ForeColor = System.Drawing.Color.White
        Me.adresse_etudiant_ajout.HintForeColor = System.Drawing.Color.White
        Me.adresse_etudiant_ajout.HintText = "Entrez l'adresse ici"
        Me.adresse_etudiant_ajout.isPassword = False
        Me.adresse_etudiant_ajout.LineFocusedColor = System.Drawing.Color.White
        Me.adresse_etudiant_ajout.LineIdleColor = System.Drawing.Color.White
        Me.adresse_etudiant_ajout.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.adresse_etudiant_ajout.LineThickness = 3
        Me.adresse_etudiant_ajout.Location = New System.Drawing.Point(276, 378)
        Me.adresse_etudiant_ajout.Margin = New System.Windows.Forms.Padding(4)
        Me.adresse_etudiant_ajout.Name = "adresse_etudiant_ajout"
        Me.adresse_etudiant_ajout.Size = New System.Drawing.Size(379, 33)
        Me.adresse_etudiant_ajout.TabIndex = 7
        Me.adresse_etudiant_ajout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'prenom_etudiant_ajout
        '
        Me.prenom_etudiant_ajout.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.prenom_etudiant_ajout.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.prenom_etudiant_ajout.ForeColor = System.Drawing.Color.White
        Me.prenom_etudiant_ajout.HintForeColor = System.Drawing.Color.White
        Me.prenom_etudiant_ajout.HintText = "Entrez le(s) prénom(s) ici"
        Me.prenom_etudiant_ajout.isPassword = False
        Me.prenom_etudiant_ajout.LineFocusedColor = System.Drawing.Color.White
        Me.prenom_etudiant_ajout.LineIdleColor = System.Drawing.Color.White
        Me.prenom_etudiant_ajout.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.prenom_etudiant_ajout.LineThickness = 3
        Me.prenom_etudiant_ajout.Location = New System.Drawing.Point(276, 262)
        Me.prenom_etudiant_ajout.Margin = New System.Windows.Forms.Padding(4)
        Me.prenom_etudiant_ajout.Name = "prenom_etudiant_ajout"
        Me.prenom_etudiant_ajout.Size = New System.Drawing.Size(379, 33)
        Me.prenom_etudiant_ajout.TabIndex = 6
        Me.prenom_etudiant_ajout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'nom_etudiant_ajout
        '
        Me.nom_etudiant_ajout.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nom_etudiant_ajout.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.nom_etudiant_ajout.ForeColor = System.Drawing.Color.White
        Me.nom_etudiant_ajout.HintForeColor = System.Drawing.Color.White
        Me.nom_etudiant_ajout.HintText = "Entrez le nom ici"
        Me.nom_etudiant_ajout.isPassword = False
        Me.nom_etudiant_ajout.LineFocusedColor = System.Drawing.Color.White
        Me.nom_etudiant_ajout.LineIdleColor = System.Drawing.Color.White
        Me.nom_etudiant_ajout.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.nom_etudiant_ajout.LineThickness = 3
        Me.nom_etudiant_ajout.Location = New System.Drawing.Point(276, 146)
        Me.nom_etudiant_ajout.Margin = New System.Windows.Forms.Padding(4)
        Me.nom_etudiant_ajout.Name = "nom_etudiant_ajout"
        Me.nom_etudiant_ajout.Size = New System.Drawing.Size(379, 33)
        Me.nom_etudiant_ajout.TabIndex = 5
        Me.nom_etudiant_ajout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'classe_etudiant_ajout
        '
        Me.classe_etudiant_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.classe_etudiant_ajout.BorderRadius = 3
        Me.classe_etudiant_ajout.DisabledColor = System.Drawing.Color.Gray
        Me.classe_etudiant_ajout.ForeColor = System.Drawing.Color.White
        Me.classe_etudiant_ajout.Items = New String(-1) {}
        Me.classe_etudiant_ajout.Location = New System.Drawing.Point(638, 33)
        Me.classe_etudiant_ajout.Name = "classe_etudiant_ajout"
        Me.classe_etudiant_ajout.NomalColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.classe_etudiant_ajout.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.classe_etudiant_ajout.selectedIndex = -1
        Me.classe_etudiant_ajout.Size = New System.Drawing.Size(284, 35)
        Me.classe_etudiant_ajout.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(532, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Classe"
        '
        'categorie_etudiant_ajout
        '
        Me.categorie_etudiant_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.categorie_etudiant_ajout.BorderRadius = 3
        Me.categorie_etudiant_ajout.DisabledColor = System.Drawing.Color.Gray
        Me.categorie_etudiant_ajout.ForeColor = System.Drawing.Color.White
        Me.categorie_etudiant_ajout.Items = New String(-1) {}
        Me.categorie_etudiant_ajout.Location = New System.Drawing.Point(164, 33)
        Me.categorie_etudiant_ajout.Name = "categorie_etudiant_ajout"
        Me.categorie_etudiant_ajout.NomalColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.categorie_etudiant_ajout.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.categorie_etudiant_ajout.selectedIndex = -1
        Me.categorie_etudiant_ajout.Size = New System.Drawing.Size(284, 35)
        Me.categorie_etudiant_ajout.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Catégorie"
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.nom_etudiant_matiere_ajout)
        Me.TabPage3.Controls.Add(Me.bouton_matiere_ajout)
        Me.TabPage3.Controls.Add(Me.classe_matiere_ajout)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.coe_matiere_ajout)
        Me.TabPage3.Controls.Add(Me.nom_matiere_ajout)
        Me.TabPage3.Controls.Add(Me.ID_etudiant_matiere_ajout)
        Me.TabPage3.Controls.Add(Me.categorie_matiere_ajout)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(962, 530)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Assignation matière"
        '
        'nom_etudiant_matiere_ajout
        '
        Me.nom_etudiant_matiere_ajout.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nom_etudiant_matiere_ajout.Enabled = False
        Me.nom_etudiant_matiere_ajout.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.nom_etudiant_matiere_ajout.ForeColor = System.Drawing.Color.White
        Me.nom_etudiant_matiere_ajout.HintForeColor = System.Drawing.Color.Empty
        Me.nom_etudiant_matiere_ajout.HintText = ""
        Me.nom_etudiant_matiere_ajout.isPassword = False
        Me.nom_etudiant_matiere_ajout.LineFocusedColor = System.Drawing.Color.Silver
        Me.nom_etudiant_matiere_ajout.LineIdleColor = System.Drawing.Color.WhiteSmoke
        Me.nom_etudiant_matiere_ajout.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.nom_etudiant_matiere_ajout.LineThickness = 2
        Me.nom_etudiant_matiere_ajout.Location = New System.Drawing.Point(276, 284)
        Me.nom_etudiant_matiere_ajout.Margin = New System.Windows.Forms.Padding(4)
        Me.nom_etudiant_matiere_ajout.Name = "nom_etudiant_matiere_ajout"
        Me.nom_etudiant_matiere_ajout.Size = New System.Drawing.Size(379, 33)
        Me.nom_etudiant_matiere_ajout.TabIndex = 13
        Me.nom_etudiant_matiere_ajout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bouton_matiere_ajout
        '
        Me.bouton_matiere_ajout.ActiveBorderThickness = 1
        Me.bouton_matiere_ajout.ActiveCornerRadius = 20
        Me.bouton_matiere_ajout.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_matiere_ajout.ActiveForecolor = System.Drawing.Color.White
        Me.bouton_matiere_ajout.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_matiere_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.bouton_matiere_ajout.BackgroundImage = CType(resources.GetObject("bouton_matiere_ajout.BackgroundImage"), System.Drawing.Image)
        Me.bouton_matiere_ajout.ButtonText = "Assigner la matière"
        Me.bouton_matiere_ajout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_matiere_ajout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bouton_matiere_ajout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_matiere_ajout.IdleBorderThickness = 1
        Me.bouton_matiere_ajout.IdleCornerRadius = 20
        Me.bouton_matiere_ajout.IdleFillColor = System.Drawing.Color.Transparent
        Me.bouton_matiere_ajout.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_matiere_ajout.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_matiere_ajout.Location = New System.Drawing.Point(276, 635)
        Me.bouton_matiere_ajout.Margin = New System.Windows.Forms.Padding(5)
        Me.bouton_matiere_ajout.Name = "bouton_matiere_ajout"
        Me.bouton_matiere_ajout.Size = New System.Drawing.Size(379, 53)
        Me.bouton_matiere_ajout.TabIndex = 12
        Me.bouton_matiere_ajout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'classe_matiere_ajout
        '
        Me.classe_matiere_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.classe_matiere_ajout.BorderRadius = 3
        Me.classe_matiere_ajout.DisabledColor = System.Drawing.Color.Gray
        Me.classe_matiere_ajout.ForeColor = System.Drawing.Color.White
        Me.classe_matiere_ajout.Items = New String(-1) {}
        Me.classe_matiere_ajout.Location = New System.Drawing.Point(638, 33)
        Me.classe_matiere_ajout.Name = "classe_matiere_ajout"
        Me.classe_matiere_ajout.NomalColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.classe_matiere_ajout.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.classe_matiere_ajout.selectedIndex = -1
        Me.classe_matiere_ajout.Size = New System.Drawing.Size(284, 35)
        Me.classe_matiere_ajout.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(532, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Classe"
        '
        'coe_matiere_ajout
        '
        Me.coe_matiere_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.coe_matiere_ajout.BorderRadius = 3
        Me.coe_matiere_ajout.DisabledColor = System.Drawing.Color.Gray
        Me.coe_matiere_ajout.ForeColor = System.Drawing.Color.White
        Me.coe_matiere_ajout.Items = New String(-1) {}
        Me.coe_matiere_ajout.Location = New System.Drawing.Point(276, 535)
        Me.coe_matiere_ajout.Name = "coe_matiere_ajout"
        Me.coe_matiere_ajout.NomalColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.coe_matiere_ajout.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.coe_matiere_ajout.selectedIndex = -1
        Me.coe_matiere_ajout.Size = New System.Drawing.Size(379, 33)
        Me.coe_matiere_ajout.TabIndex = 5
        '
        'nom_matiere_ajout
        '
        Me.nom_matiere_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.nom_matiere_ajout.BorderRadius = 3
        Me.nom_matiere_ajout.DisabledColor = System.Drawing.Color.Gray
        Me.nom_matiere_ajout.ForeColor = System.Drawing.Color.White
        Me.nom_matiere_ajout.Items = New String(-1) {}
        Me.nom_matiere_ajout.Location = New System.Drawing.Point(276, 411)
        Me.nom_matiere_ajout.Name = "nom_matiere_ajout"
        Me.nom_matiere_ajout.NomalColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.nom_matiere_ajout.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.nom_matiere_ajout.selectedIndex = -1
        Me.nom_matiere_ajout.Size = New System.Drawing.Size(379, 33)
        Me.nom_matiere_ajout.TabIndex = 5
        '
        'ID_etudiant_matiere_ajout
        '
        Me.ID_etudiant_matiere_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ID_etudiant_matiere_ajout.BorderRadius = 3
        Me.ID_etudiant_matiere_ajout.DisabledColor = System.Drawing.Color.Gray
        Me.ID_etudiant_matiere_ajout.ForeColor = System.Drawing.Color.White
        Me.ID_etudiant_matiere_ajout.Items = New String(-1) {}
        Me.ID_etudiant_matiere_ajout.Location = New System.Drawing.Point(276, 146)
        Me.ID_etudiant_matiere_ajout.Name = "ID_etudiant_matiere_ajout"
        Me.ID_etudiant_matiere_ajout.NomalColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ID_etudiant_matiere_ajout.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ID_etudiant_matiere_ajout.selectedIndex = -1
        Me.ID_etudiant_matiere_ajout.Size = New System.Drawing.Size(379, 33)
        Me.ID_etudiant_matiere_ajout.TabIndex = 5
        '
        'categorie_matiere_ajout
        '
        Me.categorie_matiere_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.categorie_matiere_ajout.BorderRadius = 3
        Me.categorie_matiere_ajout.DisabledColor = System.Drawing.Color.Gray
        Me.categorie_matiere_ajout.ForeColor = System.Drawing.Color.White
        Me.categorie_matiere_ajout.Items = New String(-1) {}
        Me.categorie_matiere_ajout.Location = New System.Drawing.Point(164, 33)
        Me.categorie_matiere_ajout.Name = "categorie_matiere_ajout"
        Me.categorie_matiere_ajout.NomalColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.categorie_matiere_ajout.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.categorie_matiere_ajout.selectedIndex = -1
        Me.categorie_matiere_ajout.Size = New System.Drawing.Size(284, 35)
        Me.categorie_matiere_ajout.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(272, 512)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 20)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Coefficient"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(272, 388)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Nom de la matière"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(272, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Nom de l'étudiant"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(272, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "ID de l'étudiant"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(41, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Catégorie"
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.nom_etudiant_note_ajout)
        Me.TabPage4.Controls.Add(Me.bouton_note_ajout)
        Me.TabPage4.Controls.Add(Me.matiere_note_ajout)
        Me.TabPage4.Controls.Add(Me.valeur_note_ajout)
        Me.TabPage4.Controls.Add(Me.trimestre_note_ajout)
        Me.TabPage4.Controls.Add(Me.ID_etudiant_note_ajout)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.classe_note_ajout)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.categorie_note_ajout)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Location = New System.Drawing.Point(4, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(962, 530)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Attribution note"
        '
        'nom_etudiant_note_ajout
        '
        Me.nom_etudiant_note_ajout.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nom_etudiant_note_ajout.Enabled = False
        Me.nom_etudiant_note_ajout.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.nom_etudiant_note_ajout.ForeColor = System.Drawing.Color.White
        Me.nom_etudiant_note_ajout.HintForeColor = System.Drawing.Color.Empty
        Me.nom_etudiant_note_ajout.HintText = ""
        Me.nom_etudiant_note_ajout.isPassword = False
        Me.nom_etudiant_note_ajout.LineFocusedColor = System.Drawing.Color.Silver
        Me.nom_etudiant_note_ajout.LineIdleColor = System.Drawing.Color.WhiteSmoke
        Me.nom_etudiant_note_ajout.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.nom_etudiant_note_ajout.LineThickness = 2
        Me.nom_etudiant_note_ajout.Location = New System.Drawing.Point(276, 308)
        Me.nom_etudiant_note_ajout.Margin = New System.Windows.Forms.Padding(4)
        Me.nom_etudiant_note_ajout.Name = "nom_etudiant_note_ajout"
        Me.nom_etudiant_note_ajout.Size = New System.Drawing.Size(379, 33)
        Me.nom_etudiant_note_ajout.TabIndex = 22
        Me.nom_etudiant_note_ajout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bouton_note_ajout
        '
        Me.bouton_note_ajout.ActiveBorderThickness = 1
        Me.bouton_note_ajout.ActiveCornerRadius = 20
        Me.bouton_note_ajout.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_note_ajout.ActiveForecolor = System.Drawing.Color.White
        Me.bouton_note_ajout.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_note_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.bouton_note_ajout.BackgroundImage = CType(resources.GetObject("bouton_note_ajout.BackgroundImage"), System.Drawing.Image)
        Me.bouton_note_ajout.ButtonText = "Attribuer la note"
        Me.bouton_note_ajout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_note_ajout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bouton_note_ajout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_note_ajout.IdleBorderThickness = 1
        Me.bouton_note_ajout.IdleCornerRadius = 20
        Me.bouton_note_ajout.IdleFillColor = System.Drawing.Color.Transparent
        Me.bouton_note_ajout.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_note_ajout.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_note_ajout.Location = New System.Drawing.Point(276, 774)
        Me.bouton_note_ajout.Margin = New System.Windows.Forms.Padding(5)
        Me.bouton_note_ajout.Name = "bouton_note_ajout"
        Me.bouton_note_ajout.Size = New System.Drawing.Size(379, 53)
        Me.bouton_note_ajout.TabIndex = 21
        Me.bouton_note_ajout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'matiere_note_ajout
        '
        Me.matiere_note_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.matiere_note_ajout.BorderRadius = 3
        Me.matiere_note_ajout.DisabledColor = System.Drawing.Color.Gray
        Me.matiere_note_ajout.ForeColor = System.Drawing.Color.White
        Me.matiere_note_ajout.Items = New String(-1) {}
        Me.matiere_note_ajout.Location = New System.Drawing.Point(276, 556)
        Me.matiere_note_ajout.Name = "matiere_note_ajout"
        Me.matiere_note_ajout.NomalColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.matiere_note_ajout.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.matiere_note_ajout.selectedIndex = -1
        Me.matiere_note_ajout.Size = New System.Drawing.Size(379, 33)
        Me.matiere_note_ajout.TabIndex = 18
        '
        'valeur_note_ajout
        '
        Me.valeur_note_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.valeur_note_ajout.BorderRadius = 3
        Me.valeur_note_ajout.DisabledColor = System.Drawing.Color.Gray
        Me.valeur_note_ajout.ForeColor = System.Drawing.Color.White
        Me.valeur_note_ajout.Items = New String(-1) {}
        Me.valeur_note_ajout.Location = New System.Drawing.Point(276, 674)
        Me.valeur_note_ajout.Name = "valeur_note_ajout"
        Me.valeur_note_ajout.NomalColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.valeur_note_ajout.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.valeur_note_ajout.selectedIndex = -1
        Me.valeur_note_ajout.Size = New System.Drawing.Size(379, 33)
        Me.valeur_note_ajout.TabIndex = 18
        '
        'trimestre_note_ajout
        '
        Me.trimestre_note_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.trimestre_note_ajout.BorderRadius = 3
        Me.trimestre_note_ajout.DisabledColor = System.Drawing.Color.Gray
        Me.trimestre_note_ajout.ForeColor = System.Drawing.Color.White
        Me.trimestre_note_ajout.Items = New String(-1) {}
        Me.trimestre_note_ajout.Location = New System.Drawing.Point(276, 435)
        Me.trimestre_note_ajout.Name = "trimestre_note_ajout"
        Me.trimestre_note_ajout.NomalColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.trimestre_note_ajout.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.trimestre_note_ajout.selectedIndex = -1
        Me.trimestre_note_ajout.Size = New System.Drawing.Size(379, 33)
        Me.trimestre_note_ajout.TabIndex = 19
        '
        'ID_etudiant_note_ajout
        '
        Me.ID_etudiant_note_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ID_etudiant_note_ajout.BorderRadius = 3
        Me.ID_etudiant_note_ajout.DisabledColor = System.Drawing.Color.Gray
        Me.ID_etudiant_note_ajout.ForeColor = System.Drawing.Color.White
        Me.ID_etudiant_note_ajout.Items = New String(-1) {}
        Me.ID_etudiant_note_ajout.Location = New System.Drawing.Point(276, 170)
        Me.ID_etudiant_note_ajout.Name = "ID_etudiant_note_ajout"
        Me.ID_etudiant_note_ajout.NomalColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ID_etudiant_note_ajout.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.ID_etudiant_note_ajout.selectedIndex = -1
        Me.ID_etudiant_note_ajout.Size = New System.Drawing.Size(379, 33)
        Me.ID_etudiant_note_ajout.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(272, 533)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 20)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Matière"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(272, 651)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 20)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Note"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(272, 412)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 20)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Trimestre"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(272, 284)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 20)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Nom de l'étudiant"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(272, 147)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(138, 20)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "ID de l'étudiant"
        '
        'classe_note_ajout
        '
        Me.classe_note_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.classe_note_ajout.BorderRadius = 3
        Me.classe_note_ajout.DisabledColor = System.Drawing.Color.Gray
        Me.classe_note_ajout.ForeColor = System.Drawing.Color.White
        Me.classe_note_ajout.Items = New String(-1) {}
        Me.classe_note_ajout.Location = New System.Drawing.Point(638, 33)
        Me.classe_note_ajout.Name = "classe_note_ajout"
        Me.classe_note_ajout.NomalColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.classe_note_ajout.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.classe_note_ajout.selectedIndex = -1
        Me.classe_note_ajout.Size = New System.Drawing.Size(284, 35)
        Me.classe_note_ajout.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(532, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Classe"
        '
        'categorie_note_ajout
        '
        Me.categorie_note_ajout.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.categorie_note_ajout.BorderRadius = 3
        Me.categorie_note_ajout.DisabledColor = System.Drawing.Color.Gray
        Me.categorie_note_ajout.ForeColor = System.Drawing.Color.White
        Me.categorie_note_ajout.Items = New String(-1) {}
        Me.categorie_note_ajout.Location = New System.Drawing.Point(164, 33)
        Me.categorie_note_ajout.Name = "categorie_note_ajout"
        Me.categorie_note_ajout.NomalColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.categorie_note_ajout.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.categorie_note_ajout.selectedIndex = -1
        Me.categorie_note_ajout.Size = New System.Drawing.Size(284, 35)
        Me.categorie_note_ajout.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(41, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Catégorie"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.recherche_etudiant)
        Me.TabPage5.Controls.Add(Me.liste_etudiant)
        Me.TabPage5.Controls.Add(Me.bouton_modification_etudiant)
        Me.TabPage5.Controls.Add(Me.bouton_suppression_etudiant)
        Me.TabPage5.Controls.Add(Me.numero_modification)
        Me.TabPage5.Controls.Add(Me.classe_modification)
        Me.TabPage5.Controls.Add(Me.categorie_modification)
        Me.TabPage5.Controls.Add(Me.adresse_modification)
        Me.TabPage5.Controls.Add(Me.prenom_modification)
        Me.TabPage5.Controls.Add(Me.nom_modification)
        Me.TabPage5.Controls.Add(Me.bouton_modifier)
        Me.TabPage5.Controls.Add(Me.classe_affichage_etudiant)
        Me.TabPage5.Controls.Add(Me.Label20)
        Me.TabPage5.Controls.Add(Me.Label18)
        Me.TabPage5.Controls.Add(Me.categorie_affichage_etudiant)
        Me.TabPage5.Controls.Add(Me.Label19)
        Me.TabPage5.Location = New System.Drawing.Point(4, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(962, 530)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Affichage étudiant"
        '
        'recherche_etudiant
        '
        Me.recherche_etudiant.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.recherche_etudiant.BackgroundImage = CType(resources.GetObject("recherche_etudiant.BackgroundImage"), System.Drawing.Image)
        Me.recherche_etudiant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.recherche_etudiant.ForeColor = System.Drawing.Color.LightGray
        Me.recherche_etudiant.Icon = CType(resources.GetObject("recherche_etudiant.Icon"), System.Drawing.Image)
        Me.recherche_etudiant.Location = New System.Drawing.Point(45, 56)
        Me.recherche_etudiant.Name = "recherche_etudiant"
        Me.recherche_etudiant.Size = New System.Drawing.Size(257, 42)
        Me.recherche_etudiant.TabIndex = 34
        Me.recherche_etudiant.text = ""
        '
        'liste_etudiant
        '
        Me.liste_etudiant.AllowCustomTheming = False
        Me.liste_etudiant.AllowUserToAddRows = False
        Me.liste_etudiant.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.liste_etudiant.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.liste_etudiant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.liste_etudiant.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.liste_etudiant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.liste_etudiant.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.liste_etudiant.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.liste_etudiant.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.liste_etudiant.ColumnHeadersHeight = 40
        Me.liste_etudiant.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.liste_etudiant.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.liste_etudiant.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.liste_etudiant.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.liste_etudiant.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.liste_etudiant.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.liste_etudiant.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.liste_etudiant.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.liste_etudiant.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.liste_etudiant.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.liste_etudiant.CurrentTheme.Name = Nothing
        Me.liste_etudiant.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.liste_etudiant.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.liste_etudiant.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.liste_etudiant.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.liste_etudiant.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.liste_etudiant.DefaultCellStyle = DataGridViewCellStyle3
        Me.liste_etudiant.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.liste_etudiant.EnableHeadersVisualStyles = False
        Me.liste_etudiant.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.liste_etudiant.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.liste_etudiant.HeaderBgColor = System.Drawing.Color.Empty
        Me.liste_etudiant.HeaderForeColor = System.Drawing.Color.White
        Me.liste_etudiant.Location = New System.Drawing.Point(3, 97)
        Me.liste_etudiant.Name = "liste_etudiant"
        Me.liste_etudiant.ReadOnly = True
        Me.liste_etudiant.RowHeadersVisible = False
        Me.liste_etudiant.RowTemplate.Height = 40
        Me.liste_etudiant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.liste_etudiant.Size = New System.Drawing.Size(956, 430)
        Me.liste_etudiant.TabIndex = 33
        Me.liste_etudiant.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'bouton_modification_etudiant
        '
        Me.bouton_modification_etudiant.BackColor = System.Drawing.Color.Transparent
        Me.bouton_modification_etudiant.BackgroundImage = CType(resources.GetObject("bouton_modification_etudiant.BackgroundImage"), System.Drawing.Image)
        Me.bouton_modification_etudiant.ButtonText = "Confirmer les modifications"
        Me.bouton_modification_etudiant.ButtonTextMarginLeft = 0
        Me.bouton_modification_etudiant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_modification_etudiant.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.bouton_modification_etudiant.DisabledFillColor = System.Drawing.Color.Gray
        Me.bouton_modification_etudiant.DisabledForecolor = System.Drawing.Color.White
        Me.bouton_modification_etudiant.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.bouton_modification_etudiant.ForeColor = System.Drawing.Color.White
        Me.bouton_modification_etudiant.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_modification_etudiant.IconPadding = 10
        Me.bouton_modification_etudiant.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_modification_etudiant.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bouton_modification_etudiant.IdleBorderRadius = 1
        Me.bouton_modification_etudiant.IdleBorderThickness = 1
        Me.bouton_modification_etudiant.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bouton_modification_etudiant.IdleIconLeftImage = Nothing
        Me.bouton_modification_etudiant.IdleIconRightImage = Nothing
        Me.bouton_modification_etudiant.Location = New System.Drawing.Point(637, 434)
        Me.bouton_modification_etudiant.Name = "bouton_modification_etudiant"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.bouton_modification_etudiant.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 1
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.bouton_modification_etudiant.OnPressedState = StateProperties2
        Me.bouton_modification_etudiant.Size = New System.Drawing.Size(197, 34)
        Me.bouton_modification_etudiant.TabIndex = 25
        Me.bouton_modification_etudiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bouton_suppression_etudiant
        '
        Me.bouton_suppression_etudiant.BackColor = System.Drawing.Color.Transparent
        Me.bouton_suppression_etudiant.BackgroundImage = CType(resources.GetObject("bouton_suppression_etudiant.BackgroundImage"), System.Drawing.Image)
        Me.bouton_suppression_etudiant.ButtonText = "Supprimer l'étudiant"
        Me.bouton_suppression_etudiant.ButtonTextMarginLeft = 0
        Me.bouton_suppression_etudiant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_suppression_etudiant.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.bouton_suppression_etudiant.DisabledFillColor = System.Drawing.Color.Gray
        Me.bouton_suppression_etudiant.DisabledForecolor = System.Drawing.Color.White
        Me.bouton_suppression_etudiant.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.bouton_suppression_etudiant.ForeColor = System.Drawing.Color.White
        Me.bouton_suppression_etudiant.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_suppression_etudiant.IconPadding = 10
        Me.bouton_suppression_etudiant.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_suppression_etudiant.IdleBorderColor = System.Drawing.Color.DarkRed
        Me.bouton_suppression_etudiant.IdleBorderRadius = 1
        Me.bouton_suppression_etudiant.IdleBorderThickness = 1
        Me.bouton_suppression_etudiant.IdleFillColor = System.Drawing.Color.DarkRed
        Me.bouton_suppression_etudiant.IdleIconLeftImage = Nothing
        Me.bouton_suppression_etudiant.IdleIconRightImage = Nothing
        Me.bouton_suppression_etudiant.Location = New System.Drawing.Point(136, 434)
        Me.bouton_suppression_etudiant.Name = "bouton_suppression_etudiant"
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties3.BorderRadius = 1
        StateProperties3.BorderThickness = 1
        StateProperties3.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties3.ForeColor = System.Drawing.Color.White
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.bouton_suppression_etudiant.onHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.BorderRadius = 1
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.bouton_suppression_etudiant.OnPressedState = StateProperties4
        Me.bouton_suppression_etudiant.Size = New System.Drawing.Size(197, 34)
        Me.bouton_suppression_etudiant.TabIndex = 26
        Me.bouton_suppression_etudiant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'numero_modification
        '
        Me.numero_modification.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numero_modification.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.numero_modification.ForeColor = System.Drawing.Color.White
        Me.numero_modification.HintForeColor = System.Drawing.Color.Empty
        Me.numero_modification.HintText = ""
        Me.numero_modification.isPassword = False
        Me.numero_modification.LineFocusedColor = System.Drawing.Color.Silver
        Me.numero_modification.LineIdleColor = System.Drawing.Color.WhiteSmoke
        Me.numero_modification.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.numero_modification.LineThickness = 3
        Me.numero_modification.Location = New System.Drawing.Point(537, 346)
        Me.numero_modification.Margin = New System.Windows.Forms.Padding(4)
        Me.numero_modification.Name = "numero_modification"
        Me.numero_modification.Size = New System.Drawing.Size(379, 33)
        Me.numero_modification.TabIndex = 32
        Me.numero_modification.Text = "Numéro de classe"
        Me.numero_modification.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'classe_modification
        '
        Me.classe_modification.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.classe_modification.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.classe_modification.ForeColor = System.Drawing.Color.White
        Me.classe_modification.HintForeColor = System.Drawing.Color.Empty
        Me.classe_modification.HintText = ""
        Me.classe_modification.isPassword = False
        Me.classe_modification.LineFocusedColor = System.Drawing.Color.Silver
        Me.classe_modification.LineIdleColor = System.Drawing.Color.WhiteSmoke
        Me.classe_modification.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.classe_modification.LineThickness = 3
        Me.classe_modification.Location = New System.Drawing.Point(46, 346)
        Me.classe_modification.Margin = New System.Windows.Forms.Padding(4)
        Me.classe_modification.Name = "classe_modification"
        Me.classe_modification.Size = New System.Drawing.Size(379, 33)
        Me.classe_modification.TabIndex = 31
        Me.classe_modification.Text = "Classe"
        Me.classe_modification.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'categorie_modification
        '
        Me.categorie_modification.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.categorie_modification.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.categorie_modification.ForeColor = System.Drawing.Color.White
        Me.categorie_modification.HintForeColor = System.Drawing.Color.Empty
        Me.categorie_modification.HintText = ""
        Me.categorie_modification.isPassword = False
        Me.categorie_modification.LineFocusedColor = System.Drawing.Color.Silver
        Me.categorie_modification.LineIdleColor = System.Drawing.Color.WhiteSmoke
        Me.categorie_modification.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.categorie_modification.LineThickness = 3
        Me.categorie_modification.Location = New System.Drawing.Point(537, 228)
        Me.categorie_modification.Margin = New System.Windows.Forms.Padding(4)
        Me.categorie_modification.Name = "categorie_modification"
        Me.categorie_modification.Size = New System.Drawing.Size(379, 33)
        Me.categorie_modification.TabIndex = 30
        Me.categorie_modification.Text = "Catégorie"
        Me.categorie_modification.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'adresse_modification
        '
        Me.adresse_modification.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.adresse_modification.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.adresse_modification.ForeColor = System.Drawing.Color.White
        Me.adresse_modification.HintForeColor = System.Drawing.Color.Empty
        Me.adresse_modification.HintText = ""
        Me.adresse_modification.isPassword = False
        Me.adresse_modification.LineFocusedColor = System.Drawing.Color.Silver
        Me.adresse_modification.LineIdleColor = System.Drawing.Color.WhiteSmoke
        Me.adresse_modification.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.adresse_modification.LineThickness = 3
        Me.adresse_modification.Location = New System.Drawing.Point(46, 228)
        Me.adresse_modification.Margin = New System.Windows.Forms.Padding(4)
        Me.adresse_modification.Name = "adresse_modification"
        Me.adresse_modification.Size = New System.Drawing.Size(379, 33)
        Me.adresse_modification.TabIndex = 29
        Me.adresse_modification.Text = "Adresse"
        Me.adresse_modification.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'prenom_modification
        '
        Me.prenom_modification.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.prenom_modification.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.prenom_modification.ForeColor = System.Drawing.Color.White
        Me.prenom_modification.HintForeColor = System.Drawing.Color.Empty
        Me.prenom_modification.HintText = ""
        Me.prenom_modification.isPassword = False
        Me.prenom_modification.LineFocusedColor = System.Drawing.Color.Silver
        Me.prenom_modification.LineIdleColor = System.Drawing.Color.WhiteSmoke
        Me.prenom_modification.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.prenom_modification.LineThickness = 3
        Me.prenom_modification.Location = New System.Drawing.Point(537, 133)
        Me.prenom_modification.Margin = New System.Windows.Forms.Padding(4)
        Me.prenom_modification.Name = "prenom_modification"
        Me.prenom_modification.Size = New System.Drawing.Size(379, 33)
        Me.prenom_modification.TabIndex = 28
        Me.prenom_modification.Text = "Prénom"
        Me.prenom_modification.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'nom_modification
        '
        Me.nom_modification.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nom_modification.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.nom_modification.ForeColor = System.Drawing.Color.White
        Me.nom_modification.HintForeColor = System.Drawing.Color.Empty
        Me.nom_modification.HintText = ""
        Me.nom_modification.isPassword = False
        Me.nom_modification.LineFocusedColor = System.Drawing.Color.Silver
        Me.nom_modification.LineIdleColor = System.Drawing.Color.WhiteSmoke
        Me.nom_modification.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.nom_modification.LineThickness = 3
        Me.nom_modification.Location = New System.Drawing.Point(46, 133)
        Me.nom_modification.Margin = New System.Windows.Forms.Padding(4)
        Me.nom_modification.Name = "nom_modification"
        Me.nom_modification.Size = New System.Drawing.Size(379, 33)
        Me.nom_modification.TabIndex = 27
        Me.nom_modification.Text = "Nom"
        Me.nom_modification.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bouton_modifier
        '
        Me.bouton_modifier.BackColor = System.Drawing.Color.Transparent
        Me.bouton_modifier.BackgroundImage = CType(resources.GetObject("bouton_modifier.BackgroundImage"), System.Drawing.Image)
        Me.bouton_modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bouton_modifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_modifier.Location = New System.Drawing.Point(887, 68)
        Me.bouton_modifier.Name = "bouton_modifier"
        Me.bouton_modifier.OffColor = System.Drawing.Color.Gray
        Me.bouton_modifier.OnColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_modifier.Size = New System.Drawing.Size(35, 20)
        Me.bouton_modifier.TabIndex = 16
        Me.bouton_modifier.Value = False
        '
        'classe_affichage_etudiant
        '
        Me.classe_affichage_etudiant.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.classe_affichage_etudiant.BorderRadius = 3
        Me.classe_affichage_etudiant.DisabledColor = System.Drawing.Color.Gray
        Me.classe_affichage_etudiant.ForeColor = System.Drawing.Color.White
        Me.classe_affichage_etudiant.Items = New String(-1) {}
        Me.classe_affichage_etudiant.Location = New System.Drawing.Point(638, 10)
        Me.classe_affichage_etudiant.Name = "classe_affichage_etudiant"
        Me.classe_affichage_etudiant.NomalColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.classe_affichage_etudiant.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.classe_affichage_etudiant.selectedIndex = -1
        Me.classe_affichage_etudiant.Size = New System.Drawing.Size(284, 35)
        Me.classe_affichage_etudiant.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(804, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 20)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Modifier"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(532, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 20)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Classe"
        '
        'categorie_affichage_etudiant
        '
        Me.categorie_affichage_etudiant.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.categorie_affichage_etudiant.BorderRadius = 3
        Me.categorie_affichage_etudiant.DisabledColor = System.Drawing.Color.Gray
        Me.categorie_affichage_etudiant.ForeColor = System.Drawing.Color.White
        Me.categorie_affichage_etudiant.Items = New String(-1) {}
        Me.categorie_affichage_etudiant.Location = New System.Drawing.Point(164, 10)
        Me.categorie_affichage_etudiant.Name = "categorie_affichage_etudiant"
        Me.categorie_affichage_etudiant.NomalColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.categorie_affichage_etudiant.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.categorie_affichage_etudiant.selectedIndex = -1
        Me.categorie_affichage_etudiant.Size = New System.Drawing.Size(284, 35)
        Me.categorie_affichage_etudiant.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(41, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 20)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Catégorie"
        '
        'TabPage6
        '
        Me.TabPage6.AutoScroll = True
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabPage6.Controls.Add(Me.bouton_actualiser)
        Me.TabPage6.Controls.Add(Me.password_etab_compte)
        Me.TabPage6.Controls.Add(Me.contact_etab_compte)
        Me.TabPage6.Controls.Add(Me.mail_etab_compte)
        Me.TabPage6.Controls.Add(Me.adresse_etab_compte)
        Me.TabPage6.Controls.Add(Me.nom_etab_compte)
        Me.TabPage6.Controls.Add(Me.Label25)
        Me.TabPage6.Controls.Add(Me.Label24)
        Me.TabPage6.Controls.Add(Me.Label23)
        Me.TabPage6.Controls.Add(Me.Label22)
        Me.TabPage6.Controls.Add(Me.Label21)
        Me.TabPage6.Location = New System.Drawing.Point(4, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(962, 530)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Paramètres"
        '
        'bouton_actualiser
        '
        Me.bouton_actualiser.ActiveBorderThickness = 1
        Me.bouton_actualiser.ActiveCornerRadius = 20
        Me.bouton_actualiser.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_actualiser.ActiveForecolor = System.Drawing.Color.White
        Me.bouton_actualiser.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_actualiser.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.bouton_actualiser.BackgroundImage = CType(resources.GetObject("bouton_actualiser.BackgroundImage"), System.Drawing.Image)
        Me.bouton_actualiser.ButtonText = "Actualiser"
        Me.bouton_actualiser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_actualiser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bouton_actualiser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_actualiser.IdleBorderThickness = 1
        Me.bouton_actualiser.IdleCornerRadius = 20
        Me.bouton_actualiser.IdleFillColor = System.Drawing.Color.Transparent
        Me.bouton_actualiser.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_actualiser.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_actualiser.Location = New System.Drawing.Point(474, 530)
        Me.bouton_actualiser.Margin = New System.Windows.Forms.Padding(5)
        Me.bouton_actualiser.Name = "bouton_actualiser"
        Me.bouton_actualiser.Size = New System.Drawing.Size(379, 53)
        Me.bouton_actualiser.TabIndex = 13
        Me.bouton_actualiser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'password_etab_compte
        '
        Me.password_etab_compte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password_etab_compte.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.password_etab_compte.ForeColor = System.Drawing.Color.White
        Me.password_etab_compte.HintForeColor = System.Drawing.Color.White
        Me.password_etab_compte.HintText = ""
        Me.password_etab_compte.isPassword = True
        Me.password_etab_compte.LineFocusedColor = System.Drawing.Color.White
        Me.password_etab_compte.LineIdleColor = System.Drawing.Color.White
        Me.password_etab_compte.LineMouseHoverColor = System.Drawing.Color.White
        Me.password_etab_compte.LineThickness = 3
        Me.password_etab_compte.Location = New System.Drawing.Point(474, 392)
        Me.password_etab_compte.Margin = New System.Windows.Forms.Padding(4)
        Me.password_etab_compte.Name = "password_etab_compte"
        Me.password_etab_compte.Size = New System.Drawing.Size(379, 33)
        Me.password_etab_compte.TabIndex = 9
        Me.password_etab_compte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'contact_etab_compte
        '
        Me.contact_etab_compte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contact_etab_compte.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.contact_etab_compte.ForeColor = System.Drawing.Color.White
        Me.contact_etab_compte.HintForeColor = System.Drawing.Color.White
        Me.contact_etab_compte.HintText = ""
        Me.contact_etab_compte.isPassword = False
        Me.contact_etab_compte.LineFocusedColor = System.Drawing.Color.White
        Me.contact_etab_compte.LineIdleColor = System.Drawing.Color.White
        Me.contact_etab_compte.LineMouseHoverColor = System.Drawing.Color.White
        Me.contact_etab_compte.LineThickness = 3
        Me.contact_etab_compte.Location = New System.Drawing.Point(474, 318)
        Me.contact_etab_compte.Margin = New System.Windows.Forms.Padding(4)
        Me.contact_etab_compte.Name = "contact_etab_compte"
        Me.contact_etab_compte.Size = New System.Drawing.Size(379, 33)
        Me.contact_etab_compte.TabIndex = 8
        Me.contact_etab_compte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mail_etab_compte
        '
        Me.mail_etab_compte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mail_etab_compte.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.mail_etab_compte.ForeColor = System.Drawing.Color.White
        Me.mail_etab_compte.HintForeColor = System.Drawing.Color.White
        Me.mail_etab_compte.HintText = ""
        Me.mail_etab_compte.isPassword = False
        Me.mail_etab_compte.LineFocusedColor = System.Drawing.Color.White
        Me.mail_etab_compte.LineIdleColor = System.Drawing.Color.White
        Me.mail_etab_compte.LineMouseHoverColor = System.Drawing.Color.White
        Me.mail_etab_compte.LineThickness = 3
        Me.mail_etab_compte.Location = New System.Drawing.Point(474, 239)
        Me.mail_etab_compte.Margin = New System.Windows.Forms.Padding(4)
        Me.mail_etab_compte.Name = "mail_etab_compte"
        Me.mail_etab_compte.Size = New System.Drawing.Size(379, 33)
        Me.mail_etab_compte.TabIndex = 7
        Me.mail_etab_compte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'adresse_etab_compte
        '
        Me.adresse_etab_compte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.adresse_etab_compte.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.adresse_etab_compte.ForeColor = System.Drawing.Color.White
        Me.adresse_etab_compte.HintForeColor = System.Drawing.Color.White
        Me.adresse_etab_compte.HintText = ""
        Me.adresse_etab_compte.isPassword = False
        Me.adresse_etab_compte.LineFocusedColor = System.Drawing.Color.White
        Me.adresse_etab_compte.LineIdleColor = System.Drawing.Color.White
        Me.adresse_etab_compte.LineMouseHoverColor = System.Drawing.Color.White
        Me.adresse_etab_compte.LineThickness = 3
        Me.adresse_etab_compte.Location = New System.Drawing.Point(474, 151)
        Me.adresse_etab_compte.Margin = New System.Windows.Forms.Padding(4)
        Me.adresse_etab_compte.Name = "adresse_etab_compte"
        Me.adresse_etab_compte.Size = New System.Drawing.Size(379, 33)
        Me.adresse_etab_compte.TabIndex = 6
        Me.adresse_etab_compte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nom_etab_compte
        '
        Me.nom_etab_compte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nom_etab_compte.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.nom_etab_compte.ForeColor = System.Drawing.Color.White
        Me.nom_etab_compte.HintForeColor = System.Drawing.Color.White
        Me.nom_etab_compte.HintText = ""
        Me.nom_etab_compte.isPassword = False
        Me.nom_etab_compte.LineFocusedColor = System.Drawing.Color.White
        Me.nom_etab_compte.LineIdleColor = System.Drawing.Color.White
        Me.nom_etab_compte.LineMouseHoverColor = System.Drawing.Color.White
        Me.nom_etab_compte.LineThickness = 3
        Me.nom_etab_compte.Location = New System.Drawing.Point(474, 62)
        Me.nom_etab_compte.Margin = New System.Windows.Forms.Padding(4)
        Me.nom_etab_compte.Name = "nom_etab_compte"
        Me.nom_etab_compte.Size = New System.Drawing.Size(379, 33)
        Me.nom_etab_compte.TabIndex = 5
        Me.nom_etab_compte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(82, 405)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(119, 20)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Mot de passe"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(82, 331)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(186, 20)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Numéro de téléphone"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(82, 252)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(54, 20)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Email"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(82, 164)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 20)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Adresse"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(82, 75)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(204, 20)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Nom de l'établissement"
        '
        'BunifuDragControlMain
        '
        Me.BunifuDragControlMain.Fixed = True
        Me.BunifuDragControlMain.Horizontal = True
        Me.BunifuDragControlMain.TargetControl = Me.MainHeader
        Me.BunifuDragControlMain.Vertical = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.MainPages)
        Me.Controls.Add(Me.Lefter)
        Me.Controls.Add(Me.MainHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.MainHeader.ResumeLayout(False)
        Me.MainHeader.PerformLayout()
        CType(Me.Main_bouton_quitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Lefter.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPages.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.liste_etudiant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents MainHeader As Panel
    Friend WithEvents Lefter As Panel
    Friend WithEvents MainPages As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents nom_etab As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Main_bouton_quitter As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents bouton_home As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bouton_affichage As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bouton_ajoutNote As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bouton_ajoutMatiere As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bouton_ajoutEtudiant As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents categorie_etudiant_ajout As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents classe_etudiant_ajout As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents nom_etudiant_ajout As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents prenom_etudiant_ajout As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents adresse_etudiant_ajout As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents numero_etudiant_ajout As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents naissance_etudiant_ajout As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents bouton_etudiant_ajout As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label3 As Label
    Friend WithEvents classe_matiere_ajout As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label4 As Label
    Friend WithEvents categorie_matiere_ajout As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents classe_note_ajout As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label6 As Label
    Friend WithEvents categorie_note_ajout As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label7 As Label
    Friend WithEvents ID_etudiant_matiere_ajout As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents coe_matiere_ajout As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents nom_matiere_ajout As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents bouton_matiere_ajout As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents nom_etudiant_matiere_ajout As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents nom_etudiant_note_ajout As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents bouton_note_ajout As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents valeur_note_ajout As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents trimestre_note_ajout As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents ID_etudiant_note_ajout As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents matiere_note_ajout As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents bouton_parametreCompte As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents logo As PictureBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents classe_affichage_etudiant As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label18 As Label
    Friend WithEvents categorie_affichage_etudiant As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label19 As Label
    Friend WithEvents bouton_modifier As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents Label20 As Label
    Friend WithEvents recherche_etudiant As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuDragControlMain As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents nom_etab_compte As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label25 As Label
    Friend WithEvents mail_etab_compte As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents adresse_etab_compte As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents password_etab_compte As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents contact_etab_compte As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents bouton_actualiser As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents bouton_deconnexion As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents bouton_modification_etudiant As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents bouton_suppression_etudiant As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents numero_modification As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents classe_modification As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents categorie_modification As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents adresse_modification As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents prenom_modification As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents nom_modification As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents liste_etudiant As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Label26 As Label
    Friend WithEvents label_nombre_eleve As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuRating1 As Bunifu.Framework.UI.BunifuRating
End Class
