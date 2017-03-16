Imports System.Xml


Namespace MSLTimesheet


Public Class DataAccess

    '---------------------------------------------------
    ' PROPERTY: ConnectStr
    '       Looks up database connection string from
    '       XML file located in 'Database.xml'
    '---------------------------------------------------
    Public Shared _ConnectStr As String = ""

    Public ReadOnly Property ConnectStr() As String
        Get
            If _ConnectStr = "" Then ReadFromXmlFile()
            Return _ConnectStr


        End Get
    End Property



    '---------------------------------------------------
    ' PROPERTY: WebFolder
    '       Sets the location of the website
    '---------------------------------------------------
    Public Shared _WebFolder As String = ""

    Public Property WebFolder() As String
        Get
            Return _WebFolder
        End Get
        Set(ByVal Value As String)
            _WebFolder = Value
        End Set
    End Property

    '---------------------------------------------------
    ' PROPERTY: Server
    '       Database Server Name 
    '---------------------------------------------------
    Private Shared _Server As String

    Public Property Server() As String
        Get
            Return _Server
        End Get
        Set(ByVal Value As String)
            _Server = Value
        End Set
    End Property

    '---------------------------------------------------
    ' PROPERTY: Database
    '       Database Name 
    '---------------------------------------------------
    Private Shared _Database As String

    Public Property Database() As String
        Get
            Return _Database
        End Get
        Set(ByVal Value As String)
            _Database = Value
        End Set
    End Property

    '---------------------------------------------------
    ' PROPERTY: UserName
    '        Server UserName 
    '---------------------------------------------------
    Private Shared _Username As String

    Public Property Username() As String
        Get
            Return _Username
        End Get
        Set(ByVal Value As String)
            _Username = Value
        End Set
    End Property

    '---------------------------------------------------
    ' PROPERTY: Password
    '       Database Server Password 
    '---------------------------------------------------
    Private Shared _Password As String

    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal Value As String)
            _Password = Value
        End Set
    End Property


    Private Sub ReadFromXmlFile() 'for use for reading the xml file and outputting it to the public shared properties
        Dim enc As System.Text.UTF8Encoding
        Dim rd As New XmlTextReader(WebFolder & "\database.xml")

        While rd.Read ' while rs reads a line
            If (rd.NodeType = XmlNodeType.Element) And rd.Name = "Server" Then _Server = rd.ReadString
            If (rd.NodeType = XmlNodeType.Element) And rd.Name = "Database" Then _Database = rd.ReadString
            If (rd.NodeType = XmlNodeType.Element) And rd.Name = "Username" Then _Username = rd.ReadString
            If (rd.NodeType = XmlNodeType.Element) And rd.Name = "Password" Then _Password = rd.ReadString
        End While 'move to next line

        rd.Close()

        'the following is formatting the values so that the server can actually understand it when it is passed in
        _ConnectStr = "Data source=" & _Server & ";initial catalog=" & _Database & ";User ID=" & _Username & ";Password=" & _Password
    End Sub

End Class
End Namespace
