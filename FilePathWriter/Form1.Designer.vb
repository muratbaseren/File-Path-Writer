<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.OpenSaveFile = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.AddFile = New System.Windows.Forms.ToolStripButton
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.SimgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grpFiles = New System.Windows.Forms.GroupBox
        Me.lsvFiles = New System.Windows.Forms.ListView
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tssFileCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.tssCheckedItemsCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.grpFileDetails = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnCopyFile = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.btnDeselectAll = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnSelectAll = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.txtFilePath = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFileName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.btnSelectFileMove = New System.Windows.Forms.Button
        Me.ToolStrip1.SuspendLayout()
        Me.grpFiles.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.grpFileDetails.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenSaveFile, Me.ToolStripSeparator3, Me.NewToolStripButton, Me.AddFile, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.ToolStripSeparator2, Me.PrintToolStripButton, Me.toolStripSeparator, Me.ToolStripButton2, Me.ToolStripButton1, Me.toolStripSeparator1, Me.HelpToolStripButton, Me.ToolStripSeparator4, Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(8, 8)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(618, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'OpenSaveFile
        '
        Me.OpenSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenSaveFile.Image = CType(resources.GetObject("OpenSaveFile.Image"), System.Drawing.Image)
        Me.OpenSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenSaveFile.Name = "OpenSaveFile"
        Me.OpenSaveFile.Size = New System.Drawing.Size(23, 22)
        Me.OpenSaveFile.Text = "ToolStripButton1"
        Me.OpenSaveFile.ToolTipText = "Kaydedilmiþ Taslak Açar.."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        Me.NewToolStripButton.ToolTipText = "Yeni"
        '
        'AddFile
        '
        Me.AddFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddFile.Image = CType(resources.GetObject("AddFile.Image"), System.Drawing.Image)
        Me.AddFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddFile.Name = "AddFile"
        Me.AddFile.Size = New System.Drawing.Size(23, 22)
        Me.AddFile.Text = "&Open"
        Me.AddFile.ToolTipText = "Seçilen dosyalarý ekler.."
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        Me.OpenToolStripButton.ToolTipText = "Seçilen Klasördeki Dosyalarý Ekler.."
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        Me.SaveToolStripButton.ToolTipText = "Taslak Kaydetmenizi Saðlar.."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
        Me.PrintToolStripButton.ToolTipText = "Yazdýr"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Seçili dosyalarý listeden siler.."
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Bulunamayan dosyalarý siler.."
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        Me.HelpToolStripButton.ToolTipText = "Hakkýnda"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimgeToolStripMenuItem, Me.ListeToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.ToolTipText = "Listeleme Türü"
        '
        'SimgeToolStripMenuItem
        '
        Me.SimgeToolStripMenuItem.Image = CType(resources.GetObject("SimgeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SimgeToolStripMenuItem.Name = "SimgeToolStripMenuItem"
        Me.SimgeToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.SimgeToolStripMenuItem.Text = "Simge"
        Me.SimgeToolStripMenuItem.ToolTipText = "Simge þeklinde listeleme yapar.."
        '
        'ListeToolStripMenuItem
        '
        Me.ListeToolStripMenuItem.Image = CType(resources.GetObject("ListeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListeToolStripMenuItem.Name = "ListeToolStripMenuItem"
        Me.ListeToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ListeToolStripMenuItem.Text = "Liste"
        Me.ListeToolStripMenuItem.ToolTipText = "Liste þeklinde listemeleme yapar.."
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(8, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(618, 10)
        Me.Panel1.TabIndex = 3
        '
        'grpFiles
        '
        Me.grpFiles.Controls.Add(Me.lsvFiles)
        Me.grpFiles.Controls.Add(Me.StatusStrip1)
        Me.grpFiles.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpFiles.Location = New System.Drawing.Point(8, 43)
        Me.grpFiles.Name = "grpFiles"
        Me.grpFiles.Padding = New System.Windows.Forms.Padding(10)
        Me.grpFiles.Size = New System.Drawing.Size(422, 480)
        Me.grpFiles.TabIndex = 4
        Me.grpFiles.TabStop = False
        Me.grpFiles.Text = "File(s)"
        '
        'lsvFiles
        '
        Me.lsvFiles.CheckBoxes = True
        Me.lsvFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvFiles.LargeImageList = Me.imageList1
        Me.lsvFiles.Location = New System.Drawing.Point(10, 23)
        Me.lsvFiles.Name = "lsvFiles"
        Me.lsvFiles.Size = New System.Drawing.Size(402, 425)
        Me.lsvFiles.SmallImageList = Me.imageList1
        Me.lsvFiles.TabIndex = 2
        Me.lsvFiles.UseCompatibleStateImageBehavior = False
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "imgZipRar")
        Me.imageList1.Images.SetKeyName(1, "imgWmv")
        Me.imageList1.Images.SetKeyName(2, "imgWma")
        Me.imageList1.Images.SetKeyName(3, "imgWav")
        Me.imageList1.Images.SetKeyName(4, "imgMp3")
        Me.imageList1.Images.SetKeyName(5, "imgIni")
        Me.imageList1.Images.SetKeyName(6, "imgBat")
        Me.imageList1.Images.SetKeyName(7, "imgJpg")
        Me.imageList1.Images.SetKeyName(8, "imgBmp")
        Me.imageList1.Images.SetKeyName(9, "imgGif")
        Me.imageList1.Images.SetKeyName(10, "imgTxt")
        Me.imageList1.Images.SetKeyName(11, "imgDll")
        Me.imageList1.Images.SetKeyName(12, "imgCs")
        Me.imageList1.Images.SetKeyName(13, "imgHtml")
        Me.imageList1.Images.SetKeyName(14, "imgXls")
        Me.imageList1.Images.SetKeyName(15, "imgDoc")
        Me.imageList1.Images.SetKeyName(16, "imgPpt")
        Me.imageList1.Images.SetKeyName(17, "imgVb")
        Me.imageList1.Images.SetKeyName(18, "imgOther")
        Me.imageList1.Images.SetKeyName(19, "imgNoFile")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssFileCount, Me.tssCheckedItemsCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(10, 448)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(402, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssFileCount
        '
        Me.tssFileCount.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssFileCount.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tssFileCount.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tssFileCount.Name = "tssFileCount"
        Me.tssFileCount.Size = New System.Drawing.Size(4, 17)
        '
        'tssCheckedItemsCount
        '
        Me.tssCheckedItemsCount.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssCheckedItemsCount.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tssCheckedItemsCount.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tssCheckedItemsCount.Name = "tssCheckedItemsCount"
        Me.tssCheckedItemsCount.Size = New System.Drawing.Size(4, 17)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(430, 43)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(10, 480)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
        '
        'grpFileDetails
        '
        Me.grpFileDetails.Controls.Add(Me.PictureBox1)
        Me.grpFileDetails.Controls.Add(Me.Panel2)
        Me.grpFileDetails.Controls.Add(Me.Panel3)
        Me.grpFileDetails.Controls.Add(Me.Panel7)
        Me.grpFileDetails.Controls.Add(Me.txtFilePath)
        Me.grpFileDetails.Controls.Add(Me.Label2)
        Me.grpFileDetails.Controls.Add(Me.txtFileName)
        Me.grpFileDetails.Controls.Add(Me.Label1)
        Me.grpFileDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpFileDetails.Location = New System.Drawing.Point(440, 43)
        Me.grpFileDetails.Name = "grpFileDetails"
        Me.grpFileDetails.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.grpFileDetails.Size = New System.Drawing.Size(186, 480)
        Me.grpFileDetails.TabIndex = 7
        Me.grpFileDetails.TabStop = False
        Me.grpFileDetails.Text = "File Detail"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(10, 164)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(10, 282)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(166, 10)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(10, 292)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel3.Size = New System.Drawing.Size(166, 178)
        Me.Panel3.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnCopyFile)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(3, 100)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel6.Size = New System.Drawing.Size(158, 37)
        Me.Panel6.TabIndex = 4
        '
        'btnCopyFile
        '
        Me.btnCopyFile.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCopyFile.Location = New System.Drawing.Point(10, 10)
        Me.btnCopyFile.Name = "btnCopyFile"
        Me.btnCopyFile.Size = New System.Drawing.Size(138, 27)
        Me.btnCopyFile.TabIndex = 4
        Me.btnCopyFile.Text = "Seçili Olanlarý Kopyala"
        Me.btnCopyFile.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnDeselectAll)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 65)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel5.Size = New System.Drawing.Size(158, 35)
        Me.Panel5.TabIndex = 3
        '
        'btnDeselectAll
        '
        Me.btnDeselectAll.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDeselectAll.Location = New System.Drawing.Point(10, 10)
        Me.btnDeselectAll.Name = "btnDeselectAll"
        Me.btnDeselectAll.Size = New System.Drawing.Size(138, 23)
        Me.btnDeselectAll.TabIndex = 4
        Me.btnDeselectAll.Text = "Hiçbirini Seçme"
        Me.btnDeselectAll.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSelectAll)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel4.Size = New System.Drawing.Size(158, 37)
        Me.Panel4.TabIndex = 2
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSelectAll.Location = New System.Drawing.Point(10, 10)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(138, 23)
        Me.btnSelectAll.TabIndex = 4
        Me.btnSelectAll.Text = "Hepsini Seç"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "GÖREVLER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(10, 154)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(166, 10)
        Me.Panel7.TabIndex = 5
        '
        'txtFilePath
        '
        Me.txtFilePath.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFilePath.Location = New System.Drawing.Point(10, 83)
        Me.txtFilePath.Multiline = True
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFilePath.Size = New System.Drawing.Size(166, 71)
        Me.txtFilePath.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(10, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dosya Konumu :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtFileName
        '
        Me.txtFileName.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFileName.Location = New System.Drawing.Point(10, 38)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(166, 20)
        Me.txtFileName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dosya Adý :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.btnSelectFileMove)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(3, 137)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel8.Size = New System.Drawing.Size(158, 35)
        Me.Panel8.TabIndex = 5
        '
        'btnSelectFileMove
        '
        Me.btnSelectFileMove.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSelectFileMove.Location = New System.Drawing.Point(10, 10)
        Me.btnSelectFileMove.Name = "btnSelectFileMove"
        Me.btnSelectFileMove.Size = New System.Drawing.Size(138, 23)
        Me.btnSelectFileMove.TabIndex = 4
        Me.btnSelectFileMove.Text = "Seçili Olanlarý Taþý"
        Me.btnSelectFileMove.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 531)
        Me.Controls.Add(Me.grpFileDetails)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.grpFiles)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.Text = "File Path Writer & Reader"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpFiles.ResumeLayout(False)
        Me.grpFiles.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.grpFileDetails.ResumeLayout(False)
        Me.grpFileDetails.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grpFiles As System.Windows.Forms.GroupBox
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lsvFiles As System.Windows.Forms.ListView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssFileCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssCheckedItemsCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenSaveFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddFile As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SimgeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents grpFileDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnCopyFile As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnDeselectAll As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnSelectFileMove As System.Windows.Forms.Button

End Class
