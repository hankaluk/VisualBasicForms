<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frMainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toolstrSoubor = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtevřítToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UložitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstrIcon = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstrHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.numericbox = New System.Windows.Forms.NumericUpDown()
        Me.txtboxA = New System.Windows.Forms.TextBox()
        Me.txtboxB = New System.Windows.Forms.TextBox()
        Me.lbSoucet = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.lbPosuvnik = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.combBarvy = New System.Windows.Forms.ComboBox()
        Me.chbDelsi = New System.Windows.Forms.CheckBox()
        Me.chbVyssi = New System.Windows.Forms.CheckBox()
        Me.chbHlubsi = New System.Windows.Forms.CheckBox()
        Me.grbMaterial = New System.Windows.Forms.GroupBox()
        Me.radbSklo = New System.Windows.Forms.RadioButton()
        Me.radbPlast = New System.Windows.Forms.RadioButton()
        Me.radbKov = New System.Windows.Forms.RadioButton()
        Me.radbDrevo = New System.Windows.Forms.RadioButton()
        Me.btnKonec = New System.Windows.Forms.Button()
        Me.lbInfo1 = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statbTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstCesta = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbProgress = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbInfo2 = New System.Windows.Forms.Label()
        Me.lbInfo3 = New System.Windows.Forms.Label()
        Me.lbInfo4 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.numericbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbMaterial.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstrSoubor, Me.toolstrIcon, Me.toolstrHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(693, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'toolstrSoubor
        '
        Me.toolstrSoubor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtevřítToolStripMenuItem, Me.UložitToolStripMenuItem})
        Me.toolstrSoubor.Name = "toolstrSoubor"
        Me.toolstrSoubor.Size = New System.Drawing.Size(57, 20)
        Me.toolstrSoubor.Text = "Soubor"
        '
        'OtevřítToolStripMenuItem
        '
        Me.OtevřítToolStripMenuItem.Name = "OtevřítToolStripMenuItem"
        Me.OtevřítToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.OtevřítToolStripMenuItem.Text = "Otevřít"
        '
        'UložitToolStripMenuItem
        '
        Me.UložitToolStripMenuItem.Name = "UložitToolStripMenuItem"
        Me.UložitToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.UložitToolStripMenuItem.Text = "Uložit"
        '
        'toolstrIcon
        '
        Me.toolstrIcon.Image = CType(resources.GetObject("toolstrIcon.Image"), System.Drawing.Image)
        Me.toolstrIcon.Name = "toolstrIcon"
        Me.toolstrIcon.Size = New System.Drawing.Size(28, 20)
        '
        'toolstrHelp
        '
        Me.toolstrHelp.Name = "toolstrHelp"
        Me.toolstrHelp.Size = New System.Drawing.Size(44, 20)
        Me.toolstrHelp.Text = "Help"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(303, 56)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(360, 185)
        Me.TextBox1.TabIndex = 1
        '
        'numericbox
        '
        Me.numericbox.Location = New System.Drawing.Point(199, 100)
        Me.numericbox.Name = "numericbox"
        Me.numericbox.Size = New System.Drawing.Size(78, 20)
        Me.numericbox.TabIndex = 2
        '
        'txtboxA
        '
        Me.txtboxA.Location = New System.Drawing.Point(56, 99)
        Me.txtboxA.Name = "txtboxA"
        Me.txtboxA.Size = New System.Drawing.Size(59, 20)
        Me.txtboxA.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.txtboxA, "Zadejte celé číslo")
        '
        'txtboxB
        '
        Me.txtboxB.Location = New System.Drawing.Point(121, 100)
        Me.txtboxB.Name = "txtboxB"
        Me.txtboxB.Size = New System.Drawing.Size(59, 20)
        Me.txtboxB.TabIndex = 4
        '
        'lbSoucet
        '
        Me.lbSoucet.AutoSize = True
        Me.lbSoucet.Location = New System.Drawing.Point(56, 138)
        Me.lbSoucet.Name = "lbSoucet"
        Me.lbSoucet.Size = New System.Drawing.Size(44, 13)
        Me.lbSoucet.TabIndex = 5
        Me.lbSoucet.Text = "Soucet:"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(56, 179)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(204, 45)
        Me.TrackBar1.TabIndex = 6
        Me.TrackBar1.TickFrequency = 10
        Me.ToolTip.SetToolTip(Me.TrackBar1, "Posuvník až do 100")
        Me.TrackBar1.Value = 1
        '
        'lbPosuvnik
        '
        Me.lbPosuvnik.AutoSize = True
        Me.lbPosuvnik.Location = New System.Drawing.Point(59, 210)
        Me.lbPosuvnik.Name = "lbPosuvnik"
        Me.lbPosuvnik.Size = New System.Drawing.Size(126, 13)
        Me.lbPosuvnik.TabIndex = 7
        Me.lbPosuvnik.Text = "Posuvníkem nastaveno: "
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(56, 279)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(107, 13)
        Me.lbTotal.TabIndex = 8
        Me.lbTotal.Text = "Součet * TrackBar = "
        '
        'combBarvy
        '
        Me.combBarvy.FormattingEnabled = True
        Me.combBarvy.Items.AddRange(New Object() {"hnědá", "červená", "fialová", "zelená", "modrá"})
        Me.combBarvy.Location = New System.Drawing.Point(59, 323)
        Me.combBarvy.Name = "combBarvy"
        Me.combBarvy.Size = New System.Drawing.Size(221, 21)
        Me.combBarvy.TabIndex = 9
        Me.combBarvy.Text = "hnědá"
        '
        'chbDelsi
        '
        Me.chbDelsi.AutoSize = True
        Me.chbDelsi.Location = New System.Drawing.Point(303, 279)
        Me.chbDelsi.Name = "chbDelsi"
        Me.chbDelsi.Size = New System.Drawing.Size(49, 17)
        Me.chbDelsi.TabIndex = 10
        Me.chbDelsi.Text = "delší"
        Me.chbDelsi.UseVisualStyleBackColor = True
        '
        'chbVyssi
        '
        Me.chbVyssi.AutoSize = True
        Me.chbVyssi.Location = New System.Drawing.Point(303, 304)
        Me.chbVyssi.Name = "chbVyssi"
        Me.chbVyssi.Size = New System.Drawing.Size(51, 17)
        Me.chbVyssi.TabIndex = 11
        Me.chbVyssi.Text = "vyšší"
        Me.chbVyssi.UseVisualStyleBackColor = True
        '
        'chbHlubsi
        '
        Me.chbHlubsi.AutoSize = True
        Me.chbHlubsi.Location = New System.Drawing.Point(303, 327)
        Me.chbHlubsi.Name = "chbHlubsi"
        Me.chbHlubsi.Size = New System.Drawing.Size(55, 17)
        Me.chbHlubsi.TabIndex = 12
        Me.chbHlubsi.Text = "hlubší"
        Me.chbHlubsi.UseVisualStyleBackColor = True
        '
        'grbMaterial
        '
        Me.grbMaterial.Controls.Add(Me.radbSklo)
        Me.grbMaterial.Controls.Add(Me.radbPlast)
        Me.grbMaterial.Controls.Add(Me.radbKov)
        Me.grbMaterial.Controls.Add(Me.radbDrevo)
        Me.grbMaterial.Location = New System.Drawing.Point(384, 267)
        Me.grbMaterial.Name = "grbMaterial"
        Me.grbMaterial.Size = New System.Drawing.Size(124, 124)
        Me.grbMaterial.TabIndex = 13
        Me.grbMaterial.TabStop = False
        Me.grbMaterial.Text = "Materiál"
        '
        'radbSklo
        '
        Me.radbSklo.AutoSize = True
        Me.radbSklo.Location = New System.Drawing.Point(7, 90)
        Me.radbSklo.Name = "radbSklo"
        Me.radbSklo.Size = New System.Drawing.Size(44, 17)
        Me.radbSklo.TabIndex = 3
        Me.radbSklo.TabStop = True
        Me.radbSklo.Text = "sklo"
        Me.radbSklo.UseVisualStyleBackColor = True
        '
        'radbPlast
        '
        Me.radbPlast.AutoSize = True
        Me.radbPlast.Location = New System.Drawing.Point(7, 67)
        Me.radbPlast.Name = "radbPlast"
        Me.radbPlast.Size = New System.Drawing.Size(47, 17)
        Me.radbPlast.TabIndex = 2
        Me.radbPlast.TabStop = True
        Me.radbPlast.Text = "plast"
        Me.radbPlast.UseVisualStyleBackColor = True
        '
        'radbKov
        '
        Me.radbKov.AutoSize = True
        Me.radbKov.Location = New System.Drawing.Point(7, 44)
        Me.radbKov.Name = "radbKov"
        Me.radbKov.Size = New System.Drawing.Size(43, 17)
        Me.radbKov.TabIndex = 1
        Me.radbKov.TabStop = True
        Me.radbKov.Text = "kov"
        Me.radbKov.UseVisualStyleBackColor = True
        '
        'radbDrevo
        '
        Me.radbDrevo.AutoSize = True
        Me.radbDrevo.Location = New System.Drawing.Point(7, 20)
        Me.radbDrevo.Name = "radbDrevo"
        Me.radbDrevo.Size = New System.Drawing.Size(53, 17)
        Me.radbDrevo.TabIndex = 0
        Me.radbDrevo.TabStop = True
        Me.radbDrevo.Text = "dřevo"
        Me.radbDrevo.UseVisualStyleBackColor = True
        '
        'btnKonec
        '
        Me.btnKonec.Location = New System.Drawing.Point(537, 267)
        Me.btnKonec.Name = "btnKonec"
        Me.btnKonec.Size = New System.Drawing.Size(117, 46)
        Me.btnKonec.TabIndex = 14
        Me.btnKonec.Text = "Konec"
        Me.ToolTip.SetToolTip(Me.btnKonec, "Ukončení formuláře")
        Me.btnKonec.UseVisualStyleBackColor = True
        '
        'lbInfo1
        '
        Me.lbInfo1.AutoSize = True
        Me.lbInfo1.Location = New System.Drawing.Point(59, 361)
        Me.lbInfo1.Name = "lbInfo1"
        Me.lbInfo1.Size = New System.Drawing.Size(30, 13)
        Me.lbInfo1.TabIndex = 15
        Me.lbInfo1.Text = "číslo"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(59, 423)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(449, 34)
        Me.ProgressBar.TabIndex = 16
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statbTime, Me.toolstCesta})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 503)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(693, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statbTime
        '
        Me.statbTime.Name = "statbTime"
        Me.statbTime.Size = New System.Drawing.Size(74, 17)
        Me.statbTime.Text = "Aktuální čas:"
        '
        'toolstCesta
        '
        Me.toolstCesta.Name = "toolstCesta"
        Me.toolstCesta.Size = New System.Drawing.Size(158, 17)
        Me.toolstCesta.Text = "Naposledy otevřený soubor: "
        '
        'lbProgress
        '
        Me.lbProgress.AutoSize = True
        Me.lbProgress.Location = New System.Drawing.Point(56, 473)
        Me.lbProgress.Name = "lbProgress"
        Me.lbProgress.Size = New System.Drawing.Size(151, 13)
        Me.lbProgress.TabIndex = 18
        Me.lbProgress.Text = "ProgressBar bude běžet ještě: "
        '
        'Timer1
        '
        '
        'btnReset
        '
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.Location = New System.Drawing.Point(515, 423)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(148, 34)
        Me.btnReset.TabIndex = 19
        Me.ToolTip.SetToolTip(Me.btnReset, "Restartuje progress bar")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = """Texty (*.txt)|*.txt|Dokumenty (*.doc;*docx)|*.doc;*docx|Všechny soubory(*.*)|*.*" &
    """ "
        Me.OpenFileDialog1.Multiselect = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.InitialDirectory = "D:/"
        '
        'lbInfo2
        '
        Me.lbInfo2.AutoSize = True
        Me.lbInfo2.Location = New System.Drawing.Point(95, 361)
        Me.lbInfo2.Name = "lbInfo2"
        Me.lbInfo2.Size = New System.Drawing.Size(39, 13)
        Me.lbInfo2.TabIndex = 20
        Me.lbInfo2.Text = "combo"
        '
        'lbInfo3
        '
        Me.lbInfo3.AutoSize = True
        Me.lbInfo3.Location = New System.Drawing.Point(140, 361)
        Me.lbInfo3.Name = "lbInfo3"
        Me.lbInfo3.Size = New System.Drawing.Size(43, 13)
        Me.lbInfo3.TabIndex = 21
        Me.lbInfo3.Text = "material"
        '
        'lbInfo4
        '
        Me.lbInfo4.AutoSize = True
        Me.lbInfo4.Location = New System.Drawing.Point(189, 361)
        Me.lbInfo4.Name = "lbInfo4"
        Me.lbInfo4.Size = New System.Drawing.Size(34, 13)
        Me.lbInfo4.TabIndex = 22
        Me.lbInfo4.Text = "barva"
        '
        'frMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 525)
        Me.Controls.Add(Me.lbInfo4)
        Me.Controls.Add(Me.lbInfo3)
        Me.Controls.Add(Me.lbInfo2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lbProgress)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.lbInfo1)
        Me.Controls.Add(Me.btnKonec)
        Me.Controls.Add(Me.grbMaterial)
        Me.Controls.Add(Me.chbHlubsi)
        Me.Controls.Add(Me.chbVyssi)
        Me.Controls.Add(Me.chbDelsi)
        Me.Controls.Add(Me.combBarvy)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.lbPosuvnik)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.lbSoucet)
        Me.Controls.Add(Me.txtboxB)
        Me.Controls.Add(Me.txtboxA)
        Me.Controls.Add(Me.numericbox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frMainForm"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.numericbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbMaterial.ResumeLayout(False)
        Me.grbMaterial.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents toolstrSoubor As Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstrHelp As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtevřítToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents UložitToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstrIcon As Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents numericbox As Windows.Forms.NumericUpDown
    Friend WithEvents txtboxA As Windows.Forms.TextBox
    Friend WithEvents txtboxB As Windows.Forms.TextBox
    Friend WithEvents lbSoucet As Windows.Forms.Label
    Friend WithEvents TrackBar1 As Windows.Forms.TrackBar
    Friend WithEvents lbPosuvnik As Windows.Forms.Label
    Friend WithEvents lbTotal As Windows.Forms.Label
    Friend WithEvents combBarvy As Windows.Forms.ComboBox
    Friend WithEvents chbDelsi As Windows.Forms.CheckBox
    Friend WithEvents chbVyssi As Windows.Forms.CheckBox
    Friend WithEvents chbHlubsi As Windows.Forms.CheckBox
    Friend WithEvents grbMaterial As Windows.Forms.GroupBox
    Friend WithEvents radbSklo As Windows.Forms.RadioButton
    Friend WithEvents radbPlast As Windows.Forms.RadioButton
    Friend WithEvents radbKov As Windows.Forms.RadioButton
    Friend WithEvents radbDrevo As Windows.Forms.RadioButton
    Friend WithEvents btnKonec As Windows.Forms.Button
    Friend WithEvents lbInfo1 As Windows.Forms.Label
    Friend WithEvents ProgressBar As Windows.Forms.ProgressBar
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents lbProgress As Windows.Forms.Label
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents statbTime As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnReset As Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As Windows.Forms.SaveFileDialog
    Friend WithEvents ToolTip As Windows.Forms.ToolTip
    Friend WithEvents lbInfo2 As Windows.Forms.Label
    Friend WithEvents lbInfo3 As Windows.Forms.Label
    Friend WithEvents lbInfo4 As Windows.Forms.Label
    Friend WithEvents toolstCesta As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer2 As Windows.Forms.Timer
End Class
