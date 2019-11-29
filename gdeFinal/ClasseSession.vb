Module ClasseSession
    Private id_etablissement As Integer
    Private nom_etablissement As String
    Private email_etablissement As String
    Private adresse_etablissement As String
    Private contact_etablissement As String
    Private password_etablissement As String


    Public Sub setEtablissementID(ByVal value As Integer)
        id_etablissement = value
    End Sub

    Public Function getEtablissementID()
        Return id_etablissement
    End Function



    Public Sub setEtablissementNom(ByVal value As String)
        nom_etablissement = value
    End Sub

    Public Function getEtablissementNom()
        Return nom_etablissement
    End Function



    Public Sub setEtablissementMail(ByVal value As String)
        email_etablissement = value
    End Sub

    Public Function getEtablissementMail()
        Return email_etablissement
    End Function



    Public Sub setEtablissementAdresse(ByVal value As String)
        adresse_etablissement = value
    End Sub

    Public Function getEtablissementAdresse()
        Return adresse_etablissement
    End Function



    Public Sub setEtablissementContact(ByVal value As String)
        contact_etablissement = value
    End Sub

    Public Function getEtablissementContact()
        Return contact_etablissement
    End Function



    Public Sub setEtablissementPassword(ByVal value As String)
        password_etablissement = value
    End Sub

    Public Function getEtablissementPassword()
        Return password_etablissement
    End Function


    Private modification_etudiant_id As Integer

    Public Sub setModificationEtudiantID(ByVal value As Integer)
        modification_etudiant_id = value
    End Sub

    Public Function getModificationEtudiantID()
        Return modification_etudiant_id
    End Function
End Module
