Imports System.Xml

Public Class Form1

    Private RootPath As String = "c:\"

#Region "Methods"
    Private Sub LsvFilesItemCountChanged()
        If Not Me.lsvFiles.Items.Count = 0 Then
            Me.tssFileCount.Text = Me.lsvFiles.Items.Count & " adet dosya vardýr.."
        Else
            Me.tssFileCount.Text = ""
        End If
    End Sub

    Private Sub ReadConfig(ByVal sender As Object, ByVal e As EventArgs)
        'Yapýlan ayarlar okunuyor..Program kapatulýrken kaydedilen form boyutu, varsayýlan dosya ekleme konumu, listeleme türü okunup uygulanýyor..
        Dim doc As XmlDocument = New XmlDocument
        'XML döküman hafýzaya alýnýr..Bir DataTable gibi..
        doc.Load(Application.StartupPath & "\config.xml")

        'Root Node..
        Dim root As XmlElement = doc.DocumentElement

        'Root Node 'ýn tüm child Node'larý okunur..Program nasýl halde býrakýldýysa o þekilde ayarlanýr..Bu kýsým dahada zenginleþtirilebilir.
        For Each child As XmlElement In root.ChildNodes
            Select Case child.Name
                Case "FormWidth"
                    Me.Width = CInt(child.InnerText)
                Case "FormHeight"
                    Me.Height = CInt(child.InnerText)
                Case "RootPath"
                    RootPath = child.InnerText
                Case "ListType"
                    Select Case child.InnerText
                        Case "View.LargeIcon"
                            SimgeToolStripMenuItem_Click(sender, e)
                        Case "View.List"
                            ListeToolStripMenuItem_Click(sender, e)
                        Case Else
                            SimgeToolStripMenuItem_Click(sender, e)
                    End Select
            End Select
        Next

        'XML döküman hafýzadan silinir..
        doc = Nothing
    End Sub

    Private Sub WriteConfig()
        'Program kapatýlýrken yapýlan deiþiklikler kaydedilir..Form boyutu, listeleme türü, varsayýlan dosya açma konumu..XML dökümaný "ReadConfig" sub 'ýndaki açýklama þeklinde okunur ve gerekli ayarlar yapýlýr..
        Dim doc As XmlDocument = New XmlDocument
        doc.Load(Application.StartupPath & "\config.xml")

        Dim root As XmlElement = doc.DocumentElement

        For Each child As XmlElement In root.ChildNodes
            Select Case child.Name
                Case "FormWidth"
                    child.InnerText = Me.Width
                Case "FormHeight"
                    child.InnerText = Me.Height
                Case "RootPath"
                    child.InnerText = RootPath
                Case "ListType"
                    child.InnerText = Me.lsvFiles.View
            End Select
        Next

        'Hafýzaya alýnan XML dökümaný,XML dosyasýna kaydedilir..
        doc.Save(Application.StartupPath & "\config.xml")
        doc = Nothing
    End Sub
#End Region

#Region "toolStrip"
    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        'Klasör açma butonuna basýlýnca varsayýlan ,daha önceden açýlmýþ konum neyse oradan FolderBrowserDialog açýlýr..
        Me.FolderBrowserDialog1.SelectedPath = RootPath

        'Eðer bir klasör seçilir ve OK 'e basýlýrsa..
        If Me.FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Seçilen klasör yolu varsayýlan olarak deðiþkene aktarýlýr..
            RootPath = Me.FolderBrowserDialog1.SelectedPath
            'Seçilen konumdaki tüm dosyalar okunur..
            For Each file As String In System.IO.Directory.GetFiles(Me.FolderBrowserDialog1.SelectedPath)

                'Herbir dosyadan FileDetails objesi yaratýlýr..
                Dim fd As FileDetails = New FileDetails(file)
                'Bu obje ListView 'a eklenir..
                Me.lsvFiles.Items.Add(fd)
            Next

            'ListView'daki nesne sayýsýna göre ListView altdaki StatusStrip de ListView'da kaç nesne olduðunu belirtiyoruz..
            LsvFilesItemCountChanged()
        End If
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        'Listview temizlenir..
        Me.lsvFiles.Items.Clear()
        'ListView'daki nesne bilgisi gösterilir..
        LsvFilesItemCountChanged()
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        'ListView'daki dosyalarýn konumlarý bir XML dosyasýna yazýlarak Taslak olarak kaydedilir..
        Me.SaveFileDialog1.Filter = "XML Files(*.xml)|*.xml"

        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Bir datatable belirtiriz..
            Dim DT As DataTable = New DataTable
            Dim DR As DataRow
            'Dosya Adý ve Dosya Konumu kolonlarý olan..
            DT.Columns.Add("Dosya Adý")
            DT.Columns.Add("Dosya Konumu")

            'Listview 'daki check edilmiþ tüm nesneler bu datatable 'a kaydedilir..
            For Each lsvi As ListViewItem In Me.lsvFiles.CheckedItems
                'Herbir nesne FileDetails nesnesine aktarýlýr.Property'lerine eriþilir..
                Dim fd As FileDetails = CType(lsvi, FileDetails)
                'Yeni satýr oluþturulur..
                DR = DT.NewRow()
                'Oluþturulan satýrdaki ilk kolona Dosya adý yazýlýr..
                DR.Item(0) = fd.Text
                'Oluþturulan ikinci konuma Dosya konumu yazýlýr..
                DR.Item(1) = fd.FilePath
                'Satýr datatable 'a eklenir..
                DT.Rows.Add(DR)
            Next

            'Burada daha önceden yazdýðýmýz DLL dosyasýný kullanýyoruz..Bu DLL komutlarýna ulaþmak için önceki makalemizi okuyabilirsiniz..(Makale ismi:DataTable'dan XML dosya Oluþturma ve XML dosyadan DataTable Oluþturma..)
            Dim SaveXml As WinCreatingXMLFileFromDataTable.XMLFileCreating = New WinCreatingXMLFileFromDataTable.XMLFileCreating

            'Bu DLL deki CreateXMLFile metodunu kullanarak DataTable'ýmýzý XML olarak kaydediyoruz..
            SaveXml.CreateXMLFile(DT, Me.SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub OpenSaveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenSaveFile.Click
        'Daha önce kaydedilmiþ taslaklarý açma..
        'OpenFileDialog'un Filter özelliði ile sadece .xml uzantýlý dosyalrýn grünmesini saðlýyoruz..
        Me.OpenFileDialog1.Filter = "XML Files(*.xml)|*.xml"

        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Daha önceden kaydedilmiþ taslak dosyasý seçilir..Seçilen XML Doc nesnesine yüklenir..Olduðu gibi hafýzaya alýnýr..
            Dim Doc As XmlDocument = New XmlDocument
            Doc.Load(Me.OpenFileDialog1.FileName)

            'Root node elde edilir..
            Dim root As XmlElement = Doc.DocumentElement

            'Root node'ýn tüm child node'larý için okuma yapýlýr..
            For Each child As XmlElement In root.ChildNodes
                'Eðer childnode 'ýn Dosyakonumu alaný boþ deðilse..
                If Not child.ChildNodes(1).InnerText Is Nothing Then
                    'ChildNode 'dan FileDetails nesneis oluþturulur..
                    'Dosya adý ve konumu bu nesnenin property'lerine new metodu ile yazýlýr..
                    Dim fd As FileDetails = New FileDetails(child.ChildNodes(1).InnerText)
                    'ListView 'a nesne eklenir..
                    Me.lsvFiles.Items.Add(fd)
                End If
            Next

            'XMl dökümani hafýzadan silinir..
            Doc = Nothing
        End If
    End Sub

    Private Sub AddFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFile.Click
        Me.OpenFileDialog1.Filter = "Tüm Dosyalar(*.*)|*.*"
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.FileName = ""
        Me.OpenFileDialog1.InitialDirectory = RootPath

        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RootPath = Me.OpenFileDialog1.FileName.Substring(0, Me.OpenFileDialog1.FileName.LastIndexOf("\"))
            For Each file As String In Me.OpenFileDialog1.FileNames
                Dim fd As FileDetails = New FileDetails(file)
                Me.lsvFiles.Items.Add(fd)
            Next
        End If
    End Sub

    Private Sub SimgeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimgeToolStripMenuItem.Click
        'Eðer simge þeklinde listeleme türü seçilirse..ListView 'in View özelliði ona göre ayarlanýr.Yani LargeIcon modunda ve "ToolStripDropDownButton1" 'in image özelliðine "SimgeToolStripMenuItem" 'ýn image 'ý eklenir..Görsellik olsun biraz demi!!
        Me.lsvFiles.View = View.LargeIcon
        Me.ToolStripDropDownButton1.Image = Me.SimgeToolStripMenuItem.Image
    End Sub

    Private Sub ListeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListeToolStripMenuItem.Click
        'Eðer liste þeklinde listeleme türü seçilirse..ListView 'in View özelliði ona göre ayarlanýr.Yani List modunda ve "ToolStripDropDownButton1" 'in image özelliðine "ListeToolStripMenuItem" 'ýn image 'ý eklenir..Görsellik yapýyoz..
        Me.lsvFiles.View = View.List
        Me.ToolStripDropDownButton1.Image = Me.ListeToolStripMenuItem.Image
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        'ListView'dan seçili nesnelerin silinmesi iþlemi..Seçili her bir listviewItem için "Remove" metodu kullanýlýr..
        For Each lsvi As ListViewItem In Me.lsvFiles.CheckedItems
            lsvi.Remove()
        Next
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        'ListView'da bulunan fakat dosya sabit diskte bulunmuyorsa,bu nesneler silinir.Bu nesnelerin imageIndex'ini 19 olarak eklettiðimiz için kolayca ulaþýyoruz..
        For Each lsvi As ListViewItem In Me.lsvFiles.Items
            If lsvi.ImageIndex = 19 Then
                lsvi.Remove()
            End If
        Next
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click

        If Not System.IO.Directory.Exists(Application.StartupPath & "\apps\SourceData") = True Then
            MkDir(Application.StartupPath & "\apps\SourceData")
        End If

        Dim DT As DataTable = New DataTable
        Dim DR As DataRow

        DT.Columns.Add("Dosya Adý")
        DT.Columns.Add("Dosya Konumu")

        For Each lsvi As ListViewItem In Me.lsvFiles.CheckedItems
            Dim fd As FileDetails = CType(lsvi, FileDetails)

            DR = DT.NewRow()
            DR.Item(0) = fd.Text
            DR.Item(1) = fd.FilePath

            DT.Rows.Add(DR)
        Next

        Dim SaveXml As WinCreatingXMLFileFromDataTable.XMLFileCreating = New WinCreatingXMLFileFromDataTable.XMLFileCreating

        SaveXml.CreateXMLFile(DT, Application.StartupPath & "\apps\SourceData\Dosyalar.xml")

        MessageBox.Show("Lütfen tablolar kýsmýndan tablonuzu seçiniz..Gerekli düzenlemeden sonra " & Chr(34) & "Kaydet" & Chr(34) & " yaparak oluþan dosyayý yazdýrabilirsiniz..", "Yazdýrma", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Process.Start(Application.StartupPath & "\apps\WinHtmlTableOptionsForm.exe")
    End Sub

    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripButton.Click
        Dim frm As frmHakkinda = New frmHakkinda
        frm.Show()
    End Sub
#End Region


    Private Sub lsvFiles_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsvFiles.ItemChecked
        If Not Me.lsvFiles.CheckedItems.Count = 0 Then
            Me.tssCheckedItemsCount.Text = Me.lsvFiles.CheckedItems.Count & " adet dosya seçilmiþtir.."
        Else
            Me.tssCheckedItemsCount.Text = ""
        End If
    End Sub

    Private Sub lsvFiles_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsvFiles.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete
                ToolStripButton2_Click(sender, e)
            Case Keys.PageUp
                Me.lsvFiles.Items(Me.lsvFiles.Items.Count - 1).Focused = True
            Case Keys.PageDown
                Me.lsvFiles.Items(0).Focused = True
        End Select
    End Sub

    Private Sub lsvFiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvFiles.SelectedIndexChanged

        'MsgBox(Me.lsvFiles.FocusedItem.Index)
        Dim fd As FileDetails
        fd = CType(Me.lsvFiles.FocusedItem, FileDetails)

        Me.txtFileName.Text = fd.Text
        Me.txtFilePath.Text = fd.FilePath.ToString

        If fd.ImageIndex = 7 OrElse fd.ImageIndex = 8 OrElse fd.ImageIndex = 9 Then
            Me.PictureBox1.Image = Image.FromFile(fd.FilePath)
        Else
            Me.PictureBox1.Image = Image.FromFile(Application.StartupPath & "\Empty.bmp")
        End If
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        For i As Integer = 0 To Me.lsvFiles.Items.Count - 1
            Me.lsvFiles.Items(i).Checked = True
        Next
    End Sub

    Private Sub btnDeselectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeselectAll.Click
        For i As Integer = 0 To Me.lsvFiles.Items.Count - 1
            Me.lsvFiles.Items(i).Checked = False
        Next
    End Sub

    Private Sub btnCopyFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyFile.Click
        'Bu kýsýmdaki kodlar dosyalarý taþýma ile aynýdýr..Tek farký taþýma iþleminde dosyayý kopyaladýktan sonra eski kopyalanan dosyayý silmek gerekmektedir..(Bu iki kýsým tek sub olarak yazýlabilir.)
        If Me.FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Kopyalanan As Integer = 0
            Dim Kopyalanamayan As Integer = 0
            Dim KopyalanmayanRapor As String = ""
            Dim rapor As String = "...::: Dosya Kopyalama Raporu :::..." & vbCrLf & "====================================" & vbCrLf & vbCrLf

            'Checked edilen item kadar dön..
            For i As Integer = 0 To Me.lsvFiles.CheckedItems.Count - 1
                'Checked edilen item FileDetails objesine dönüþtürülerek property'lerine ulaþýlýr..
                Dim fd As FileDetails = CType(Me.lsvFiles.CheckedItems(i), FileDetails)
                'Eðer iþaretlenmiþ dosya belirtilen konumda ise,yani varsa.
                If System.IO.File.Exists(fd.FilePath) = True Then
                    'Dosya kopyalanýr..
                    FileCopy(fd.FilePath, Me.FolderBrowserDialog1.SelectedPath & "\" & fd.FilePath.Substring(fd.FilePath.LastIndexOf("\") + 1))
                    'Kopyalanan dosya adetini elde etmek için..
                    Kopyalanan += 1
                Else
                    'Eðer kopyalanacak dosya belirtilen konumda bulunamazsa; kopyalanamayanRapor deðiþkenine kaydedilir..Ayrýca kopyalanamayan dosya adeti elde etmek için Kopyalanamayan deðiþkeni kullanýyoruz..
                    KopyalanmayanRapor &= Chr(34) & fd.Text & Chr(34) & vbCrLf
                    Kopyalanamayan += 1
                End If
            Next

            'Rapor metni oluþturulur..
            KopyalanmayanRapor &= vbCrLf & "   Yukardaki dosyalar bulunamadýðý ya da kullanýmda olduðu için kopyalanamamýþtýr.." & vbCrLf
            rapor &= "Kopyalanan Dosya Adeti : " & Kopyalanan & vbCrLf

            'Eðer Kopyalanamayan dosya varsa "Kopyalanamayan Dosya adeti" metni eklenir..
            If Kopyalanamayan <> 0 Then
                rapor &= "Kopyalanamayan Dosya Adeti : " & Kopyalanamayan & vbCrLf & vbCrLf & KopyalanmayanRapor
            End If

            'Rapor Görüntülenir..
            MessageBox.Show(rapor, "RAPOR !", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Programda yapýlan ayarlar program kapanýrken kaydedilir..
        'Form'un width,height 'i, klasör ekleme veya dosya ekleme butonlarýna basýlýnca açýlacak varsayýlan konum ve listemele türü kaydedilir..
        WriteConfig()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Programda yapýlan ayarlar program baþlarken okunur..
        'Form'un width,height 'i, klasör ekleme veya dosya ekleme butonlarýna basýlýnca açýlacak varsayýlan konum ve listemele türü okunur..
        ReadConfig(sender, e)
    End Sub

    Private Sub btnSelectFileMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectFileMove.Click
        'Bu kýsýmdaki kodlar dosyalarý kopyalama ile aynýdýr..Tek farký taþýma iþleminde dosyayý kopyaladýktan sonra eski kopyalanan dosyayý silmek gerekmektedir..Bu iki kýsým tek sub olarak yazýlabilir.
        If Me.FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Tasinan As Integer = 0
            Dim Tasinamayan As Integer = 0
            Dim TasinamayanRapor As String = ""
            Dim rapor As String = "...::: Dosya Taþýma Raporu :::..." & vbCrLf & "====================================" & vbCrLf & vbCrLf

            'Checked edilen item kadar dön..
            For i As Integer = 0 To Me.lsvFiles.CheckedItems.Count - 1
                'Checked edilen item FileDetails objesine dönüþtürülerek property'lerine ulaþýlýr..
                Dim fd As FileDetails = CType(Me.lsvFiles.CheckedItems(i), FileDetails)
                'Eðer iþaretlenmiþ dosya belirtilen konumda ise,yani varsa.
                If System.IO.File.Exists(fd.FilePath) = True Then
                    'Dosya kopyalanýr..
                    FileCopy(fd.FilePath, Me.FolderBrowserDialog1.SelectedPath & "\" & fd.FilePath.Substring(fd.FilePath.LastIndexOf("\") + 1))
                    'Dosyalarý kopyalama yapmayýp kesme yapmanýn farký..
                    'Kopyalanan dosya silinerek taþýma iþlemi o dosya için tamamlanýr..
                    Kill(fd.FilePath)
                    'Taþýnan dosya adetini elde etmek için..
                    Tasinan += 1
                Else
                    'Eðer taþýnacak dosya belirtilen konumda bulunamazsa; taþýnamayan dosya ismi kaydedilir..Ayrýca taþýnamayan dosya adeti elde etmek için taþýnamayan deðiþkeni kullanýyoruz..
                    TasinamayanRapor &= Chr(34) & fd.Text & Chr(34) & vbCrLf
                    Tasinamayan += 1
                End If
            Next

            'Rapor metni oluþturulur..
            TasinamayanRapor &= vbCrLf & "   Yukardaki dosyalar bulunamadýðý ya da kullanýmda olduðu için taþýnamamýþtýr.." & vbCrLf
            rapor &= "Taþýnan Dosya Adeti : " & Tasinan & vbCrLf

            'Eðer taþýnamayan dosya varsa "Taþýnamayan Dosya adeti" metni eklenir..
            If Tasinamayan <> 0 Then
                rapor &= "Taþýnamayan Dosya Adeti : " & Tasinamayan & vbCrLf & vbCrLf & TasinamayanRapor
            End If

            'Rapor Görüntülenir..
            MessageBox.Show(rapor, "RAPOR !", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub
End Class
