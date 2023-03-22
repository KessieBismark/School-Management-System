
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO

Imports System.Security.Cryptography

Module connections
    Public enc As System.Text.UTF8Encoding
    Public encryptor As ICryptoTransform
    Public decryptor As ICryptoTransform
    Public up As Integer = 0
    Public AppName As String
#Region "Encription and decription"

    Public Function Encript(ByVal value As String)
        Dim KEY_128 As Byte() = {42, 1, 52, 67, 231, 13, 94, 101, 123, 6, 0, 12, 32, 91, 4, 111, 31, 70, 21, 141, 123, 142, 234, 82, 95, 129, 187, 162, 12, 55, 98, 23}
        Dim IV_128 As Byte() = {234, 12, 52, 44, 214, 222, 200, 109, 2, 98, 45, 76, 88, 53, 23, 78}
        Dim symmetricKey As RijndaelManaged = New RijndaelManaged()
        symmetricKey.Mode = CipherMode.CBC

        enc = New System.Text.UTF8Encoding
        encryptor = symmetricKey.CreateEncryptor(KEY_128, IV_128)
        decryptor = symmetricKey.CreateDecryptor(KEY_128, IV_128)

        Dim sPlainText As String = value
        If Not String.IsNullOrEmpty(sPlainText) Then
            Dim memoryStream As MemoryStream = New MemoryStream()
            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)
            cryptoStream.Write(enc.GetBytes(sPlainText), 0, sPlainText.Length)
            cryptoStream.FlushFinalBlock()
            Return Convert.ToBase64String(memoryStream.ToArray())
            memoryStream.Close()
            cryptoStream.Close()
        End If
        Return ""
    End Function
    Public Function Decrypt(ByVal value As String)
        Dim KEY_128 As Byte() = {42, 1, 52, 67, 231, 13, 94, 101, 123, 6, 0, 12, 32, 91, 4, 111, 31, 70, 21, 141, 123, 142, 234, 82, 95, 129, 187, 162, 12, 55, 98, 23}
        Dim IV_128 As Byte() = {234, 12, 52, 44, 214, 222, 200, 109, 2, 98, 45, 76, 88, 53, 23, 78}
        Dim symmetricKey As RijndaelManaged = New RijndaelManaged()
        symmetricKey.Mode = CipherMode.CBC

        enc = New System.Text.UTF8Encoding
        encryptor = symmetricKey.CreateEncryptor(KEY_128, IV_128)
        decryptor = symmetricKey.CreateDecryptor(KEY_128, IV_128)
        If Not String.IsNullOrEmpty(value) Then
            Dim cypherTextBytes As Byte() = Convert.FromBase64String(value)
            Dim memoryStream As MemoryStream = New MemoryStream(cypherTextBytes)
            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)
            Dim plainTextBytes(cypherTextBytes.Length) As Byte
            Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
            memoryStream.Close()
            cryptoStream.Close()
            Return enc.GetString(plainTextBytes, 0, decryptedByteCount)
        End If
        Return ""
    End Function

#End Region

#Region "savecon"
    Dim server As String
    Dim database As String
    Dim userid As String
    Dim password As String
#End Region

#Region "Declarations"
    Public con As MySqlConnection
    Public cmd, cmd2, cmd3, cmd4, cmd5, cmd6, cmd7, cmd8, cmd9, cmdb As MySqlCommand
    Public adp, adp2, adp4, adp3, adp5, adp6, adpb As MySqlDataAdapter
    Public tb, tb2, tb3, tb4, tb5, tb6, tbb As DataTable
    Public ds, ds2, ds3, ds4 As DataSet
    Public cs As String
    Public querryString As String
#End Region

#Region "set connection"
    Public Sub setup()
        AppName = "MyScol - "
        Try
            Dim file As System.IO.StreamReader
            file = My.Computer.FileSystem.OpenTextFileReader("OnlineDB.txt")
            server = Decrypt(file.ReadLine)
            database = Decrypt(file.ReadLine)
            userid = Decrypt(file.ReadLine)
            password = file.ReadLine
            If password = "" Then
            Else
                password = Decrypt(password)
            End If
            file.Close()
            cs = "server='" + server + "'; userid='" + userid + "'; password='" + password + "';  database='" + database + "'"
            ' cs = "server='localhost'; userid='root';   database='myskul'"
        Catch ex As Exception
            showerror(ex.Message)
            dbconfig.ShowDialog()
        End Try
    End Sub
#End Region

End Module
