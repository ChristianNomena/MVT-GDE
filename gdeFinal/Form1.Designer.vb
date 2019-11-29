<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Header = New System.Windows.Forms.Panel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.bouton_quitter = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pages = New Bunifu.UI.WinForms.BunifuPages()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.label_password = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.label_email = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bouton_login = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.password_login = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.email_login = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.label_changement_page = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lien_changement_page = New System.Windows.Forms.LinkLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.password_register = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.contact_register = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.bouton_register = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.email_register = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.adresse_register = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.nom_register = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Header.SuspendLayout()
        CType(Me.bouton_quitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pages.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Header
        '
        Me.Header.Controls.Add(Me.BunifuCustomLabel1)
        Me.Header.Controls.Add(Me.bouton_quitter)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(690, 44)
        Me.Header.TabIndex = 0
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Header
        Me.BunifuDragControl1.Vertical = True
        '
        'bouton_quitter
        '
        Me.bouton_quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.bouton_quitter.Image = CType(resources.GetObject("bouton_quitter.Image"), System.Drawing.Image)
        Me.bouton_quitter.ImageActive = Nothing
        Me.bouton_quitter.InitialImage = Nothing
        Me.bouton_quitter.Location = New System.Drawing.Point(652, 6)
        Me.bouton_quitter.Name = "bouton_quitter"
        Me.bouton_quitter.Size = New System.Drawing.Size(30, 30)
        Me.bouton_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bouton_quitter.TabIndex = 0
        Me.bouton_quitter.TabStop = False
        Me.bouton_quitter.Zoom = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Enabled = False
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(12, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(235, 26)
        Me.BunifuCustomLabel1.TabIndex = 1
        Me.BunifuCustomLabel1.Text = "Gestion Des Etudiants"
        '
        'Pages
        '
        Me.Pages.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.Pages.Controls.Add(Me.TabPage1)
        Me.Pages.Controls.Add(Me.TabPage2)
        Me.Pages.Location = New System.Drawing.Point(150, 82)
        Me.Pages.Multiline = True
        Me.Pages.Name = "Pages"
        Me.Pages.SelectedIndex = 0
        Me.Pages.Size = New System.Drawing.Size(385, 317)
        Me.Pages.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.label_password)
        Me.TabPage1.Controls.Add(Me.label_email)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.bouton_login)
        Me.TabPage1.Controls.Add(Me.password_login)
        Me.TabPage1.Controls.Add(Me.email_login)
        Me.TabPage1.Controls.Add(Me.BunifuSeparator1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(377, 291)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Login"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.BunifuSeparator2)
        Me.TabPage2.Controls.Add(Me.bouton_register)
        Me.TabPage2.Controls.Add(Me.BunifuCustomLabel2)
        Me.TabPage2.Controls.Add(Me.BunifuCustomLabel6)
        Me.TabPage2.Controls.Add(Me.BunifuCustomLabel5)
        Me.TabPage2.Controls.Add(Me.BunifuCustomLabel4)
        Me.TabPage2.Controls.Add(Me.nom_register)
        Me.TabPage2.Controls.Add(Me.BunifuCustomLabel3)
        Me.TabPage2.Controls.Add(Me.adresse_register)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.email_register)
        Me.TabPage2.Controls.Add(Me.password_register)
        Me.TabPage2.Controls.Add(Me.contact_register)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(377, 291)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Register"
        '
        'label_password
        '
        Me.label_password.AutoSize = True
        Me.label_password.Enabled = False
        Me.label_password.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_password.ForeColor = System.Drawing.Color.White
        Me.label_password.Location = New System.Drawing.Point(35, 148)
        Me.label_password.Name = "label_password"
        Me.label_password.Size = New System.Drawing.Size(97, 16)
        Me.label_password.TabIndex = 17
        Me.label_password.Text = "Mot de passe"
        '
        'label_email
        '
        Me.label_email.AutoSize = True
        Me.label_email.Enabled = False
        Me.label_email.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_email.ForeColor = System.Drawing.Color.White
        Me.label_email.Location = New System.Drawing.Point(36, 70)
        Me.label_email.Name = "label_email"
        Me.label_email.Size = New System.Drawing.Size(48, 16)
        Me.label_email.TabIndex = 18
        Me.label_email.Text = "E-mail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(151, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "LOGIN"
        '
        'bouton_login
        '
        Me.bouton_login.Activecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.bouton_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bouton_login.BorderRadius = 0
        Me.bouton_login.ButtonText = "Connexion"
        Me.bouton_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_login.DisabledColor = System.Drawing.Color.Gray
        Me.bouton_login.Iconcolor = System.Drawing.Color.Transparent
        Me.bouton_login.Iconimage = Nothing
        Me.bouton_login.Iconimage_right = Nothing
        Me.bouton_login.Iconimage_right_Selected = Nothing
        Me.bouton_login.Iconimage_Selected = Nothing
        Me.bouton_login.IconMarginLeft = 0
        Me.bouton_login.IconMarginRight = 0
        Me.bouton_login.IconRightVisible = False
        Me.bouton_login.IconRightZoom = 0R
        Me.bouton_login.IconVisible = False
        Me.bouton_login.IconZoom = 90.0R
        Me.bouton_login.IsTab = False
        Me.bouton_login.Location = New System.Drawing.Point(38, 220)
        Me.bouton_login.Name = "bouton_login"
        Me.bouton_login.Normalcolor = System.Drawing.Color.Empty
        Me.bouton_login.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_login.OnHoverTextColor = System.Drawing.Color.White
        Me.bouton_login.selected = False
        Me.bouton_login.Size = New System.Drawing.Size(304, 48)
        Me.bouton_login.TabIndex = 15
        Me.bouton_login.Text = "Connexion"
        Me.bouton_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bouton_login.Textcolor = System.Drawing.Color.White
        Me.bouton_login.TextFont = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'password_login
        '
        Me.password_login.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password_login.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.password_login.ForeColor = System.Drawing.Color.White
        Me.password_login.HintForeColor = System.Drawing.Color.White
        Me.password_login.HintText = ""
        Me.password_login.isPassword = True
        Me.password_login.LineFocusedColor = System.Drawing.Color.White
        Me.password_login.LineIdleColor = System.Drawing.Color.White
        Me.password_login.LineMouseHoverColor = System.Drawing.Color.White
        Me.password_login.LineThickness = 3
        Me.password_login.Location = New System.Drawing.Point(38, 160)
        Me.password_login.Margin = New System.Windows.Forms.Padding(4)
        Me.password_login.Name = "password_login"
        Me.password_login.Size = New System.Drawing.Size(304, 33)
        Me.password_login.TabIndex = 14
        Me.password_login.Text = "          "
        Me.password_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'email_login
        '
        Me.email_login.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_login.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.email_login.ForeColor = System.Drawing.Color.White
        Me.email_login.HintForeColor = System.Drawing.Color.White
        Me.email_login.HintText = ""
        Me.email_login.isPassword = False
        Me.email_login.LineFocusedColor = System.Drawing.Color.White
        Me.email_login.LineIdleColor = System.Drawing.Color.White
        Me.email_login.LineMouseHoverColor = System.Drawing.Color.White
        Me.email_login.LineThickness = 3
        Me.email_login.Location = New System.Drawing.Point(38, 82)
        Me.email_login.Margin = New System.Windows.Forms.Padding(4)
        Me.email_login.Name = "email_login"
        Me.email_login.Size = New System.Drawing.Size(304, 33)
        Me.email_login.TabIndex = 13
        Me.email_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'label_changement_page
        '
        Me.label_changement_page.AutoSize = True
        Me.label_changement_page.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_changement_page.ForeColor = System.Drawing.Color.White
        Me.label_changement_page.Location = New System.Drawing.Point(218, 420)
        Me.label_changement_page.Name = "label_changement_page"
        Me.label_changement_page.Size = New System.Drawing.Size(163, 16)
        Me.label_changement_page.TabIndex = 2
        Me.label_changement_page.Text = "Pas encore de compte?"
        '
        'lien_changement_page
        '
        Me.lien_changement_page.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lien_changement_page.AutoSize = True
        Me.lien_changement_page.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lien_changement_page.LinkColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.lien_changement_page.Location = New System.Drawing.Point(381, 420)
        Me.lien_changement_page.Name = "lien_changement_page"
        Me.lien_changement_page.Size = New System.Drawing.Size(73, 16)
        Me.lien_changement_page.TabIndex = 3
        Me.lien_changement_page.TabStop = True
        Me.lien_changement_page.Text = "Cliquez ici"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Enabled = False
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(35, 382)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(97, 16)
        Me.BunifuCustomLabel2.TabIndex = 22
        Me.BunifuCustomLabel2.Text = "Mot de passe"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Enabled = False
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(36, 304)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(148, 16)
        Me.BunifuCustomLabel3.TabIndex = 23
        Me.BunifuCustomLabel3.Text = "Numéro de téléphone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(133, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "REGISTER"
        '
        'password_register
        '
        Me.password_register.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password_register.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.password_register.ForeColor = System.Drawing.Color.White
        Me.password_register.HintForeColor = System.Drawing.Color.White
        Me.password_register.HintText = ""
        Me.password_register.isPassword = True
        Me.password_register.LineFocusedColor = System.Drawing.Color.White
        Me.password_register.LineIdleColor = System.Drawing.Color.White
        Me.password_register.LineMouseHoverColor = System.Drawing.Color.White
        Me.password_register.LineThickness = 3
        Me.password_register.Location = New System.Drawing.Point(38, 394)
        Me.password_register.Margin = New System.Windows.Forms.Padding(4)
        Me.password_register.Name = "password_register"
        Me.password_register.Size = New System.Drawing.Size(304, 33)
        Me.password_register.TabIndex = 20
        Me.password_register.Text = "          "
        Me.password_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'contact_register
        '
        Me.contact_register.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contact_register.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.contact_register.ForeColor = System.Drawing.Color.White
        Me.contact_register.HintForeColor = System.Drawing.Color.White
        Me.contact_register.HintText = ""
        Me.contact_register.isPassword = False
        Me.contact_register.LineFocusedColor = System.Drawing.Color.White
        Me.contact_register.LineIdleColor = System.Drawing.Color.White
        Me.contact_register.LineMouseHoverColor = System.Drawing.Color.White
        Me.contact_register.LineThickness = 3
        Me.contact_register.Location = New System.Drawing.Point(38, 316)
        Me.contact_register.Margin = New System.Windows.Forms.Padding(4)
        Me.contact_register.Name = "contact_register"
        Me.contact_register.Size = New System.Drawing.Size(304, 33)
        Me.contact_register.TabIndex = 19
        Me.contact_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bouton_register
        '
        Me.bouton_register.Activecolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.bouton_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bouton_register.BorderRadius = 0
        Me.bouton_register.ButtonText = "Créer un compte"
        Me.bouton_register.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bouton_register.DisabledColor = System.Drawing.Color.Gray
        Me.bouton_register.Iconcolor = System.Drawing.Color.Transparent
        Me.bouton_register.Iconimage = Nothing
        Me.bouton_register.Iconimage_right = Nothing
        Me.bouton_register.Iconimage_right_Selected = Nothing
        Me.bouton_register.Iconimage_Selected = Nothing
        Me.bouton_register.IconMarginLeft = 0
        Me.bouton_register.IconMarginRight = 0
        Me.bouton_register.IconRightVisible = False
        Me.bouton_register.IconRightZoom = 0R
        Me.bouton_register.IconVisible = False
        Me.bouton_register.IconZoom = 90.0R
        Me.bouton_register.IsTab = False
        Me.bouton_register.Location = New System.Drawing.Point(38, 454)
        Me.bouton_register.Name = "bouton_register"
        Me.bouton_register.Normalcolor = System.Drawing.Color.Empty
        Me.bouton_register.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bouton_register.OnHoverTextColor = System.Drawing.Color.White
        Me.bouton_register.selected = False
        Me.bouton_register.Size = New System.Drawing.Size(304, 48)
        Me.bouton_register.TabIndex = 24
        Me.bouton_register.Text = "Créer un compte"
        Me.bouton_register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bouton_register.Textcolor = System.Drawing.Color.White
        Me.bouton_register.TextFont = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'email_register
        '
        Me.email_register.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_register.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.email_register.ForeColor = System.Drawing.Color.White
        Me.email_register.HintForeColor = System.Drawing.Color.White
        Me.email_register.HintText = ""
        Me.email_register.isPassword = False
        Me.email_register.LineFocusedColor = System.Drawing.Color.White
        Me.email_register.LineIdleColor = System.Drawing.Color.White
        Me.email_register.LineMouseHoverColor = System.Drawing.Color.White
        Me.email_register.LineThickness = 3
        Me.email_register.Location = New System.Drawing.Point(38, 238)
        Me.email_register.Margin = New System.Windows.Forms.Padding(4)
        Me.email_register.Name = "email_register"
        Me.email_register.Size = New System.Drawing.Size(304, 33)
        Me.email_register.TabIndex = 19
        Me.email_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Enabled = False
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(36, 226)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(48, 16)
        Me.BunifuCustomLabel4.TabIndex = 23
        Me.BunifuCustomLabel4.Text = "E-mail"
        '
        'adresse_register
        '
        Me.adresse_register.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.adresse_register.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.adresse_register.ForeColor = System.Drawing.Color.White
        Me.adresse_register.HintForeColor = System.Drawing.Color.White
        Me.adresse_register.HintText = ""
        Me.adresse_register.isPassword = False
        Me.adresse_register.LineFocusedColor = System.Drawing.Color.White
        Me.adresse_register.LineIdleColor = System.Drawing.Color.White
        Me.adresse_register.LineMouseHoverColor = System.Drawing.Color.White
        Me.adresse_register.LineThickness = 3
        Me.adresse_register.Location = New System.Drawing.Point(38, 160)
        Me.adresse_register.Margin = New System.Windows.Forms.Padding(4)
        Me.adresse_register.Name = "adresse_register"
        Me.adresse_register.Size = New System.Drawing.Size(304, 33)
        Me.adresse_register.TabIndex = 19
        Me.adresse_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Enabled = False
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(36, 148)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(60, 16)
        Me.BunifuCustomLabel5.TabIndex = 23
        Me.BunifuCustomLabel5.Text = "Adresse"
        '
        'nom_register
        '
        Me.nom_register.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nom_register.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.nom_register.ForeColor = System.Drawing.Color.White
        Me.nom_register.HintForeColor = System.Drawing.Color.White
        Me.nom_register.HintText = ""
        Me.nom_register.isPassword = False
        Me.nom_register.LineFocusedColor = System.Drawing.Color.White
        Me.nom_register.LineIdleColor = System.Drawing.Color.White
        Me.nom_register.LineMouseHoverColor = System.Drawing.Color.White
        Me.nom_register.LineThickness = 3
        Me.nom_register.Location = New System.Drawing.Point(38, 82)
        Me.nom_register.Margin = New System.Windows.Forms.Padding(4)
        Me.nom_register.Name = "nom_register"
        Me.nom_register.Size = New System.Drawing.Size(304, 33)
        Me.nom_register.TabIndex = 19
        Me.nom_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Enabled = False
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(36, 70)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(159, 16)
        Me.BunifuCustomLabel6.TabIndex = 23
        Me.BunifuCustomLabel6.Text = "Nom de l'établissement"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(0, 280)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(377, 10)
        Me.BunifuSeparator1.TabIndex = 19
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(0, 514)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(360, 10)
        Me.BunifuSeparator2.TabIndex = 25
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(690, 462)
        Me.Controls.Add(Me.lien_changement_page)
        Me.Controls.Add(Me.label_changement_page)
        Me.Controls.Add(Me.Pages)
        Me.Controls.Add(Me.Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        CType(Me.bouton_quitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pages.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Header As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents bouton_quitter As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pages As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents label_password As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents label_email As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents bouton_login As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents password_login As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents email_login As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lien_changement_page As LinkLabel
    Friend WithEvents label_changement_page As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents bouton_register As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents password_register As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents contact_register As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents nom_register As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents adresse_register As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents email_register As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
End Class
