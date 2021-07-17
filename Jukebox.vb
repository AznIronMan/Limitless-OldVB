﻿Imports System.IO
Imports NAudio.Wave

Module Jukebox

    Dim ActiveSong As BlockAlignReductionStream = Nothing
    Dim SongOutput As New NAudio.Wave.WaveOut
    Public SongPlaying As Boolean = False
    Dim SongLoaded As Boolean = False
    Dim SongPosition As Long = 0
    Public IntroInPlay As Boolean = False

    Public Function NewSong(mp3file As Byte()) As Boolean
        If SongPlaying Then
            StopSong()
        End If
        If mp3file IsNot Nothing Then
            Dim Songfile As MemoryStream = New MemoryStream(mp3file)
            Dim pcm As WaveStream = WaveFormatConversionStream.CreatePcmStream(New Mp3FileReader(Songfile))
            ActiveSong = New BlockAlignReductionStream(pcm)
            SongOutput = New WaveOut
            Dim [loop] As LoopStream = New LoopStream(ActiveSong)
            SongOutput.Init([loop])
            NewSong = True
        Else
            NewSong = False
            ActiveSong = Nothing
            SongPlaying = False
        End If

    End Function

    Public Sub PlayMp3(mp3file As String)
        PlaySong(NewSong(FileToStreamSong(mp3file)))
    End Sub

    Public Function FileToStreamSong(mp3file As String) As Byte()
        FileToStreamSong = System.IO.File.ReadAllBytes(mp3file)
    End Function

    Public Sub PlaySong(isitloaded As Boolean)
        SongLoaded = isitloaded
        If SongLoaded Then
            SongOutput.Play()
            SongPlaying = True
        End If

    End Sub

    Public Sub StopSong()
        If SongOutput.PlaybackState = PlaybackState.Playing Or SongOutput.PlaybackState = PlaybackState.Paused Then
            SongOutput.Stop()
            SongOutput.Dispose()
        End If
        SongPlaying = False
        ActiveSong = Nothing
        SongLoaded = False
        SongOutput.Stop()
        SongOutput.Dispose()
    End Sub

    Public Sub ReturnToIntro(stopbutton As Button, playbutton As Button, optionslist As ListBox, activebox As CheckBox,
        editbutton As Button, message As Label, colorgroup As GroupBox, musicgroup As GroupBox, managegroup As GroupBox,
        importbutton As Button, deletebutton As Button)
        'Specific for the Custom Music/Sound Menu
        If stopbutton.Enabled = True Then
            playbutton.Enabled = True
            optionslist.Enabled = True
            stopbutton.Enabled = False
            activebox.Enabled = True
            editbutton.Enabled = True
            message.Visible = False
            colorgroup.Enabled = True
            musicgroup.Enabled = True
            managegroup.Enabled = True
            importbutton.Enabled = True
            deletebutton.Enabled = True
            SwitchToIntro()
        End If
    End Sub

    Public Sub SwitchToIntro()
        If IntroInPlay = False Then
            StopSong()
            If Settings.SettingsMusic.ToLower = "on" Then
                If Settings.SettingsCustM = "on" And Settings.SettingsCustI.StartsWith("on") Then
                    Dim customintro As String = MemoryBank.MusicDir & "/" & Settings.SettingsCustI.Substring(3) & ".mp3"
                    If System.IO.File.Exists(customintro) Then Jukebox.PlayMp3(customintro) Else Jukebox.PlaySong(Jukebox.NewSong(My.Resources.intro))
                Else
                    Jukebox.PlaySong(Jukebox.NewSong(My.Resources.intro))
                End If
                IntroInPlay = True
            End If
        End If
    End Sub

End Module

Public Class LoopStream

    Inherits WaveStream
    Dim SourceStream As WaveStream

    Public Sub New(ByVal sourceStream As WaveStream)
        Me.SourceStream = sourceStream
        Me.EnableLooping = True
    End Sub

    Public Property EnableLooping As Boolean

    Public Overrides ReadOnly Property WaveFormat As WaveFormat
        Get
            Return SourceStream.WaveFormat
        End Get
    End Property

    Public Overrides ReadOnly Property Length As Long
        Get
            Return SourceStream.Length
        End Get
    End Property

    Public Overrides Property Position As Long
        Get
            Return SourceStream.Position
        End Get
        Set(ByVal value As Long)
            SourceStream.Position = value
        End Set
    End Property

    Public Overrides Function Read(ByVal buffer As Byte(), ByVal offset As Integer, ByVal count As Integer) As Integer
        Dim totalBytesRead As Integer = 0
        While totalBytesRead < count
            Dim bytesRead As Integer = SourceStream.Read(buffer, offset + totalBytesRead, count - totalBytesRead)
            If bytesRead = 0 Then
                If SourceStream.Position = 0 OrElse Not EnableLooping Then
                    Exit While
                End If
                SourceStream.Position = 0
            End If
            totalBytesRead += bytesRead
        End While
        Return totalBytesRead
    End Function
End Class