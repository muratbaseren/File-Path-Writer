Public Class FileDetails
    Inherits ListViewItem

#Region "Local Variables"
    Private FilePath_ As String
#End Region

#Region "Property"
    Public Property FilePath() As String
        Get
            Return Me.FilePath_
        End Get
        Set(ByVal value As String)
            Me.FilePath_ = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Public Sub New()

    End Sub

    Public Sub New(ByVal FilePath As String)
        Me.FilePath_ = Trim(FilePath)

        If Not FilePath = "" Then
            Me.Text = Trim(FilePath).Substring(FilePath.LastIndexOf("\") + 1, FilePath.LastIndexOf(".") - FilePath.LastIndexOf("\") - 1)

            If System.IO.File.Exists(Trim(FilePath)) = False Then
                Me.ImageIndex = 19
            Else
                Select Case Trim(FilePath).Substring(FilePath.LastIndexOf(".") + 1).ToLower
                    Case "zip", "rar"
                        Me.ImageIndex = 0
                    Case "wmv"
                        Me.ImageIndex = 1
                    Case "wma"
                        Me.ImageIndex = 2
                    Case "mp3"
                        Me.ImageIndex = 3
                    Case "wav"
                        Me.ImageIndex = 4
                    Case "ini"
                        Me.ImageIndex = 5
                    Case "bat"
                        Me.ImageIndex = 6
                    Case "jpg", "jpeg", "jpe"
                        Me.ImageIndex = 7
                    Case "bmp"
                        Me.ImageIndex = 8
                    Case "gif"
                        Me.ImageIndex = 9
                    Case "txt"
                        Me.ImageIndex = 10
                    Case "dll"
                        Me.ImageIndex = 11
                    Case "cs"
                        Me.ImageIndex = 12
                    Case "html"
                        Me.ImageIndex = 13
                    Case "xls"
                        Me.ImageIndex = 14
                    Case "doc"
                        Me.ImageIndex = 15
                    Case "ppt"
                        Me.ImageIndex = 16
                    Case "vb"
                        Me.ImageIndex = 17
                    Case Else
                        Me.ImageIndex = 18
                End Select
            End If
        End If
    End Sub
#End Region

End Class
