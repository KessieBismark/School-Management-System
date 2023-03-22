Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Drive.v3
Imports Google.Apis.Drive.v3.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports System
Imports System.Collections.Generic
'Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports Google.Apis.Download

Module google_drive

    Private AppName As String = "MyScol"
    Private Service As DriveService = New DriveService
#Region "Start google drive api and integrate credentials"
    Sub CreateService()
        Dim cre As UserCredential
        Dim crepath As String = "token.json"

        Using Stream = New System.IO.FileStream("cre.json", System.IO.FileMode.Open, System.IO.FileAccess.Read)
            cre = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(Stream).Secrets,
                    {DriveService.Scope.Drive},
                    "user",
                    CancellationToken.None,
                    New Google.Apis.Util.Store.FileDataStore(crepath, True)).Result
            Service = New DriveService(New BaseClientService.Initializer() With
            {
                .HttpClientInitializer = cre,
                .ApplicationName = AppName
            })

        End Using
    End Sub
#End Region

#Region "To prompt user for authentication"
    Public Sub CreaeteService()
        If Service.ApplicationName <> AppName Then CreateService()
    End Sub
#End Region


#Region "To list all the files"
    Public Sub ListFilesandFolders()
        If Service.ApplicationName <> AppName Then CreateService()
        Dim downloader = New MediaDownloader(Service)
        Dim request = Service.Files.List
        Dim results = request.Execute
        For Each x In results.Files
            Diagnostics.Debug.WriteLine(x.Name & " | " & x.Id)
        Next
    End Sub
#End Region
#Region "Search for files and folders"
    Public Sub SearchFilesFolders(ByVal foldername As String)
        If Service.ApplicationName <> AppName Then CreateService()
        Dim downloader = New MediaDownloader(Service)
        Dim request = Service.Files.List

        ' request.Q = foldername
        request.Fields = "nextPageToken, files(name, webViewLink)"
        '  request.OrderBy = "webViewLink"
        Dim results = request.Execute
        For Each x In results.Files
            Diagnostics.Debug.WriteLine(x.WebViewLink & " | " & x.Name)
            MsgBox((x.Name & " | " & x.Id))
        Next
        'Note do not uncomment these sections they will be use in the search 


        'Files with the name "hello" 	name = 'hello'
        'Files with a name containing the words "hello" And "goodbye" 	name contains 'hello' and name contains 'goodbye'
        'Files with a name that does Not contain the word "hello" 	Not name contains 'hello'
        'Folders that are Google apps Or have the folder MIME type 	mimeType = 'application/vnd.google-apps.folder'
        'Files that are Not folders 	mimeType != 'application/vnd.google-apps.folder'
        'Files that contain the text "important" And in the trash 	fullText contains 'important' and trashed = true
        'Files that contain the word "hello" 	fullText contains 'hello'
        'Files that do Not have the word "hello" 	Not fullText contains 'hello'
        'Files that contain the exact phrase "hello world" 	fullText contains '"hello world"'
        'Files with a query that contains the "" character (e.g., "\authors") 	fullText contains '\\authors'
        'Files with ID within a collection, e.g.parents collection 	'1234567' in parents
        'Files in an Application data folder in a collection 	'appDataFolder' in parents
        'Files for which user "test@example.org" has write permission 	'test@example.org' in writers
        'Files for which members of the group "group@example.org" have write permission 	'group@example.org' in writers
        'Files modified after a given date 	modifiedTime > '2012-06-04T12:00:00' // default time zone is UTC
        'Files shared with the authorized user with "hello" in the name 	sharedWithMe And name contains 'hello'
        'Files that have Not been Shared With anyone Or domains (only Private, Or shared with specific users Or groups) 	visibility = 'limited'
        'Image Or video files modified after a specific date 	modifiedTime > '2012-06-04T12:00:00' and (mimeType contains 'image/' or mimeType contains 'video/')
    End Sub
#End Region

#Region "Create Folders"
    Public Sub createFolder(ByVal fname As String)
        CreateService()
        Dim vfolder As New File()
        vfolder.Name = fname
        vfolder.MimeType = "application/vnd.google-apps.folder"
        Dim reqSetup = Service.Files.Create(vfolder)
        reqSetup.Fields = "id"
        Dim reqExe = reqSetup.Execute()
        Diagnostics.Debug.WriteLine(reqExe.Id)
    End Sub
#End Region

#Region "Create Sub Folders"
    Function CreateSubFolder(ByVal parentid As String, ByVal sfolder As String) As String
        CreateService()
        Dim vfolder As New File()
        vfolder.Name = sfolder
        vfolder.MimeType = "application/vnd.google-apps.folder"
        vfolder.Parents = New List(Of String) From {parentid}
        Dim reqSetup = Service.Files.Create(vfolder)
        reqSetup.Fields = "id"
        Dim reqExe = reqSetup.Execute()
        Diagnostics.Debug.WriteLine(reqExe.Id)

        Return reqExe.Id
    End Function

#End Region

#Region "upload file"
    Function UploadFile(ByVal parentid As String) As Boolean
        CreateService()
        Dim filepath As String ' = textbox1.text
        Dim vfile As New File()
        vfile.Name = filepath.Split("\").Last
        vfile.MimeType = getMimeType(filepath)
        vfile.Parents = New List(Of String) From {parentid}

        Dim bytesArr As Byte() = System.IO.File.ReadAllBytes(filepath)
        Dim stream As New System.IO.MemoryStream(bytesArr)
        Dim uploadReq As FilesResource.CreateMediaUpload = Service.Files.Create(vfile, stream, vfile.MimeType)
        uploadReq.Upload()
        Dim file As File = uploadReq.ResponseBody
        Return True
    End Function
#End Region

#Region "Get Mime Type of a file"
    Private Function getMimeType(ByVal filename As String) As String
        Dim mimeType As String = "application/unknown"
        Dim ext As String = System.IO.Path.GetExtension(filename).ToLower()
        Dim regkey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext)
        If regkey IsNot Nothing AndAlso regkey.GetValue("Content Type") IsNot Nothing Then mimeType = regkey.GetValue("Content Type").ToString()
        Return mimeType
    End Function
#End Region
#Region "Deleting file from google"
    Public Sub deleteFile(ByVal parentid As String)
        CreateService()
        Dim del_req = Service.Files.Delete(parentid).Execute()
    End Sub
#End Region

#Region "To download a file "
    Public Sub downloadFile(ByVal parentid As String)
        Dim getfile = Service.Files.Get(parentid)
        Dim vfile = getfile.Execute
        Dim DestinationFile As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & vfile.Name
        Dim downloader As New MediaDownloader(Service)
        downloader.ChunkSize = 256 * 1024
        Dim stream As System.IO.FileStream = New System.IO.FileStream(DestinationFile, System.IO.FileMode.Create, System.IO.FileAccess.Write)
        getfile.DownloadAsync(stream)
    End Sub
#End Region
#Region "Give permission"
    Public Sub Permission(ByVal email As String, ByVal parentid As String)
        'role
        'type
        Dim per As Permission = New Permission
        per.EmailAddress = email
        per.Type = "user"
        per.Type = "writer"
        Dim perReq = Service.Permissions.Create(per, parentid).Execute
    End Sub
#End Region
End Module
