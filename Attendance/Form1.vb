Imports DPFP
Imports DPFP.Capture
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text
Public Class Form1
    Implements DPFP.Capture.EventHandler
    Private captura As DPFP.Capture.Capture
    Private template As DPFP.Template
    Private verification As DPFP.Verification.Verification
    Dim sapi As Object
    Dim tick As Integer = 0


    Protected Overridable Sub init()
        Try
            captura = New Capture()
            If Not captura Is Nothing Then
                captura.EventHandler = Me
                verification = New Verification.Verification
                template = New Template()
            Else
                MsgBox("no finger print was captured!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Sub startcapture()
        If Not captura Is Nothing Then
            Try
                captura.StartCapture()
            Catch ex As Exception
                MsgBox("Error at startcapture. " + ex.Message)
            End Try
        End If
    End Sub

    Protected Sub stopcapture()
        If Not captura Is Nothing Then
            Try
                captura.StopCapture()
            Catch ex As Exception
                MsgBox("Error at stopcapture! " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub fingerprint(ByVal bmg)
        PictureBox1.Image = bmg
    End Sub

    Protected Function convertsample(ByVal sample As DPFP.Sample) As Bitmap
        Dim converter As New DPFP.Capture.SampleConversion()
        Dim pic As Bitmap = Nothing
        converter.ConvertToPicture(sample, pic)
        Return pic
    End Function

    Protected Function getchar(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()
        Dim digital As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim xtics As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Purpose, digital, xtics)

        If (digital = DPFP.Capture.CaptureFeedback.Good) Then
            Return xtics
        Else
            Return Nothing
        End If
    End Function

    Public Sub OnComplete(Capture As Object, ReaderSerialNumber As String, Sample As Sample) Implements EventHandler.OnComplete
        fingerprint(convertsample(Sample))
        Dim charr As DPFP.FeatureSet = getchar(Sample, DPFP.Processing.DataPurpose.Verification)
        tick = 0
        If Not charr Is Nothing Then
            Dim result As New DPFP.Verification.Verification.Result()


            Dim con As New MySqlConnection(cs)
            con.Open()
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand("select * from staff", con)
            Dim read As MySqlDataReader
            read = cmd.ExecuteReader()
            Dim verified As Boolean = False
            Dim staffid As String = ""
            While (read.Read())
                Dim mem As New MemoryStream(CType(read("fingerprint"), Byte()))
                template.DeSerialize(mem.ToArray())
                verification.Verify(charr, template, result)
                If (result.Verified) Then
                    staffid = read("staff_id")
                    staff_name = read("fullname")
                    verified = True
                    Exit While
                End If
            End While
            If (verified) Then
                read.Close()
                Try
                    cmd2 = New MySqlCommand("select * from attendance where Staff_ID = '" & staffid & "' and Date = '" & Now.Date.ToString("yyy-MM-dd") & "'", con)
                    adp = New MySqlDataAdapter(cmd2)
                    tb = New DataTable
                    adp.Fill(tb)
                    If tb.Rows.Count < 1 Then
                        cmd3 = New MySqlCommand("INSERT INTO `attendance`( `Staff_ID`, `Name`, `In_Time`,  `Date`, `sid`) values ('" & staffid & "','" & staff_name & "','" & TimeString.ToString & "','" & Now.Date.ToString("yyy-MM-dd") & "','" & sid & "')", con)
                        cmd3.ExecuteNonQuery()
                        sapi = CreateObject("sapi.spvoice")
                        sapi.speak("Verified")
                        Exit Sub
                    ElseIf tb.Rows.Count = 1 Then
                        cmd3 = New MySqlCommand("update attendance set Out_Time='" & TimeString.ToString & "' where Staff_ID='" & staffid & "' and Date='" & Now.Date.ToString("yyyy-MM-dd") & "' and sid = '" & sid & "'", con)
                        cmd3.ExecuteNonQuery()
                        sapi = CreateObject("sapi.spvoice")
                        sapi.speak("Verified")
                        End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                sapi = CreateObject("sapi.spvoice")
                sapi.speak("This fingerprint was not found  please try again")
            End If
            cmd.Dispose()
            con.Close()
        End If
    End Sub

    Public Sub OnFingerGone(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerGone

    End Sub

    Public Sub OnFingerTouch(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnFingerTouch

    End Sub

    Public Sub OnReaderConnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderConnect

    End Sub

    Public Sub OnReaderDisconnect(Capture As Object, ReaderSerialNumber As String) Implements EventHandler.OnReaderDisconnect

    End Sub

    Public Sub OnSampleQuality(Capture As Object, ReaderSerialNumber As String, CaptureFeedback As CaptureFeedback) Implements EventHandler.OnSampleQuality

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
        startcapture()
    End Sub


    Private Sub Form1_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        stopcapture()
    End Sub
End Class
