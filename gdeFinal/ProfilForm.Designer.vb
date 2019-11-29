<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfilForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfilForm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Header = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.profil_bouton_quitter = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelProfil = New System.Windows.Forms.Panel()
        Me.label_notes_profil = New System.Windows.Forms.Label()
        Me.liste_note_profil = New System.Windows.Forms.ListView()
        Me.column_header = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.column_trimestre1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.column_trimestre2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.column_trimestre3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.classe_etudiant = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numero_etudiant = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.naissance_etudiant = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.adresse_etudiant = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.prenom_etudiant = New System.Windows.Forms.Label()
        Me.nom_etudiant = New System.Windows.Forms.Label()
        Me.Header.SuspendLayout()
        CType(Me.profil_bouton_quitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProfil.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Header.Controls.Add(Me.Label1)
        Me.Header.Controls.Add(Me.profil_bouton_quitter)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(900, 40)
        Me.Header.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Informations étudiant"
        '
        'profil_bouton_quitter
        '
        Me.profil_bouton_quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.profil_bouton_quitter.Image = CType(resources.GetObject("profil_bouton_quitter.Image"), System.Drawing.Image)
        Me.profil_bouton_quitter.ImageActive = Nothing
        Me.profil_bouton_quitter.InitialImage = Nothing
        Me.profil_bouton_quitter.Location = New System.Drawing.Point(869, 9)
        Me.profil_bouton_quitter.Name = "profil_bouton_quitter"
        Me.profil_bouton_quitter.Size = New System.Drawing.Size(20, 20)
        Me.profil_bouton_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.profil_bouton_quitter.TabIndex = 4
        Me.profil_bouton_quitter.TabStop = False
        Me.profil_bouton_quitter.Zoom = 10
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Header
        Me.BunifuDragControl1.Vertical = True
        '
        'PanelProfil
        '
        Me.PanelProfil.AutoScroll = True
        Me.PanelProfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.PanelProfil.Controls.Add(Me.label_notes_profil)
        Me.PanelProfil.Controls.Add(Me.liste_note_profil)
        Me.PanelProfil.Controls.Add(Me.Label7)
        Me.PanelProfil.Controls.Add(Me.classe_etudiant)
        Me.PanelProfil.Controls.Add(Me.Label6)
        Me.PanelProfil.Controls.Add(Me.numero_etudiant)
        Me.PanelProfil.Controls.Add(Me.Label5)
        Me.PanelProfil.Controls.Add(Me.naissance_etudiant)
        Me.PanelProfil.Controls.Add(Me.Label4)
        Me.PanelProfil.Controls.Add(Me.adresse_etudiant)
        Me.PanelProfil.Controls.Add(Me.Label3)
        Me.PanelProfil.Controls.Add(Me.Label2)
        Me.PanelProfil.Controls.Add(Me.prenom_etudiant)
        Me.PanelProfil.Controls.Add(Me.nom_etudiant)
        Me.PanelProfil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelProfil.Location = New System.Drawing.Point(0, 40)
        Me.PanelProfil.Name = "PanelProfil"
        Me.PanelProfil.Size = New System.Drawing.Size(900, 460)
        Me.PanelProfil.TabIndex = 1
        '
        'label_notes_profil
        '
        Me.label_notes_profil.AutoSize = True
        Me.label_notes_profil.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_notes_profil.ForeColor = System.Drawing.Color.White
        Me.label_notes_profil.Location = New System.Drawing.Point(633, 24)
        Me.label_notes_profil.Name = "label_notes_profil"
        Me.label_notes_profil.Size = New System.Drawing.Size(74, 26)
        Me.label_notes_profil.TabIndex = 13
        Me.label_notes_profil.Text = "Notes"
        '
        'liste_note_profil
        '
        Me.liste_note_profil.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.liste_note_profil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.liste_note_profil.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_header, Me.column_trimestre1, Me.column_trimestre2, Me.column_trimestre3})
        Me.liste_note_profil.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.liste_note_profil.ForeColor = System.Drawing.Color.White
        Me.liste_note_profil.GridLines = True
        Me.liste_note_profil.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.liste_note_profil.HideSelection = False
        Me.liste_note_profil.Location = New System.Drawing.Point(449, 55)
        Me.liste_note_profil.Name = "liste_note_profil"
        Me.liste_note_profil.Size = New System.Drawing.Size(425, 326)
        Me.liste_note_profil.TabIndex = 12
        Me.liste_note_profil.UseCompatibleStateImageBehavior = False
        Me.liste_note_profil.View = System.Windows.Forms.View.Details
        '
        'column_header
        '
        Me.column_header.Text = "Matières"
        Me.column_header.Width = 120
        '
        'column_trimestre1
        '
        Me.column_trimestre1.Text = "Trimestre 1"
        Me.column_trimestre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.column_trimestre1.Width = 100
        '
        'column_trimestre2
        '
        Me.column_trimestre2.Text = "Trimestre 2"
        Me.column_trimestre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.column_trimestre2.Width = 100
        '
        'column_trimestre3
        '
        Me.column_trimestre3.Text = "Trimestre 3"
        Me.column_trimestre3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.column_trimestre3.Width = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(15, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Classe :"
        '
        'classe_etudiant
        '
        Me.classe_etudiant.AutoSize = True
        Me.classe_etudiant.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classe_etudiant.ForeColor = System.Drawing.Color.White
        Me.classe_etudiant.Location = New System.Drawing.Point(210, 297)
        Me.classe_etudiant.Name = "classe_etudiant"
        Me.classe_etudiant.Size = New System.Drawing.Size(63, 20)
        Me.classe_etudiant.TabIndex = 11
        Me.classe_etudiant.Text = "Classe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(15, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Numéro de classe :"
        '
        'numero_etudiant
        '
        Me.numero_etudiant.AutoSize = True
        Me.numero_etudiant.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero_etudiant.ForeColor = System.Drawing.Color.White
        Me.numero_etudiant.Location = New System.Drawing.Point(210, 357)
        Me.numero_etudiant.Name = "numero_etudiant"
        Me.numero_etudiant.Size = New System.Drawing.Size(155, 20)
        Me.numero_etudiant.TabIndex = 10
        Me.numero_etudiant.Text = "Numéro de classe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date de naissance :"
        '
        'naissance_etudiant
        '
        Me.naissance_etudiant.AutoSize = True
        Me.naissance_etudiant.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.naissance_etudiant.ForeColor = System.Drawing.Color.White
        Me.naissance_etudiant.Location = New System.Drawing.Point(210, 237)
        Me.naissance_etudiant.Name = "naissance_etudiant"
        Me.naissance_etudiant.Size = New System.Drawing.Size(161, 20)
        Me.naissance_etudiant.TabIndex = 9
        Me.naissance_etudiant.Text = "Date de naissance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Adresse :"
        '
        'adresse_etudiant
        '
        Me.adresse_etudiant.AutoSize = True
        Me.adresse_etudiant.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adresse_etudiant.ForeColor = System.Drawing.Color.White
        Me.adresse_etudiant.Location = New System.Drawing.Point(210, 177)
        Me.adresse_etudiant.Name = "adresse_etudiant"
        Me.adresse_etudiant.Size = New System.Drawing.Size(74, 20)
        Me.adresse_etudiant.TabIndex = 8
        Me.adresse_etudiant.Text = "Adresse"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Prénom(s) :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nom :"
        '
        'prenom_etudiant
        '
        Me.prenom_etudiant.AutoSize = True
        Me.prenom_etudiant.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenom_etudiant.ForeColor = System.Drawing.Color.White
        Me.prenom_etudiant.Location = New System.Drawing.Point(210, 117)
        Me.prenom_etudiant.Name = "prenom_etudiant"
        Me.prenom_etudiant.Size = New System.Drawing.Size(93, 20)
        Me.prenom_etudiant.TabIndex = 7
        Me.prenom_etudiant.Text = "Prénom(s)"
        '
        'nom_etudiant
        '
        Me.nom_etudiant.AutoSize = True
        Me.nom_etudiant.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_etudiant.ForeColor = System.Drawing.Color.White
        Me.nom_etudiant.Location = New System.Drawing.Point(210, 57)
        Me.nom_etudiant.Name = "nom_etudiant"
        Me.nom_etudiant.Size = New System.Drawing.Size(46, 20)
        Me.nom_etudiant.TabIndex = 6
        Me.nom_etudiant.Text = "Nom"
        '
        'ProfilForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.PanelProfil)
        Me.Controls.Add(Me.Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProfilForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProfilForm"
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        CType(Me.profil_bouton_quitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProfil.ResumeLayout(False)
        Me.PanelProfil.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Header As Panel
    Friend WithEvents profil_bouton_quitter As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelProfil As Panel
    Friend WithEvents classe_etudiant As Label
    Friend WithEvents numero_etudiant As Label
    Friend WithEvents naissance_etudiant As Label
    Friend WithEvents adresse_etudiant As Label
    Friend WithEvents prenom_etudiant As Label
    Friend WithEvents nom_etudiant As Label
    Friend WithEvents label_notes_profil As Label
    Friend WithEvents liste_note_profil As ListView
    Friend WithEvents column_header As ColumnHeader
    Friend WithEvents column_trimestre1 As ColumnHeader
    Friend WithEvents column_trimestre2 As ColumnHeader
    Friend WithEvents column_trimestre3 As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
