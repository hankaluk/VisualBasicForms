<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbstatPosuvnik = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbstatTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progBar = New System.Windows.Forms.ProgressBar()
        Me.lbProgress = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.tlstrNapoveda = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstrSoubor = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstrOtevrit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstrUlozit = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.txtBox = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.btnEsc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combTyp = New System.Windows.Forms.ComboBox()
        Me.lbTyp = New System.Windows.Forms.Label()
        Me.lbResult1 = New System.Windows.Forms.Label()
        Me.lbVystup = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radbtnPlast = New System.Windows.Forms.RadioButton()
        Me.radbtnDrevo = New System.Windows.Forms.RadioButton()
        Me.radbtnKov = New System.Windows.Forms.RadioButton()
        Me.lbResult2 = New System.Windows.Forms.Label()
        Me.txtbCisloA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbCisloB = New System.Windows.Forms.TextBox()
        Me.btnSecti = New System.Windows.Forms.Button()
        Me.lbSoucet = New System.Windows.Forms.Label()
        Me.volba = New System.Windows.Forms.CheckBox()
        Me.numKusy = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbResult3 = New System.Windows.Forms.Label()
        Me.lbResult4 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.menuStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numKusy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbstatPosuvnik, Me.lbstatTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 605)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(566, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbstatPosuvnik
        '
        Me.lbstatPosuvnik.Name = "lbstatPosuvnik"
        Me.lbstatPosuvnik.Size = New System.Drawing.Size(13, 17)
        Me.lbstatPosuvnik.Text = "0"
        '
        'lbstatTime
        '
        Me.lbstatTime.Name = "lbstatTime"
        Me.lbstatTime.Size = New System.Drawing.Size(33, 17)
        Me.lbstatTime.Text = "Time"
        '
        'progBar
        '
        Me.progBar.Location = New System.Drawing.Point(25, 506)
        Me.progBar.Name = "progBar"
        Me.progBar.Size = New System.Drawing.Size(140, 25)
        Me.progBar.TabIndex = 1
        '
        'lbProgress
        '
        Me.lbProgress.AutoSize = True
        Me.lbProgress.Location = New System.Drawing.Point(22, 550)
        Me.lbProgress.Name = "lbProgress"
        Me.lbProgress.Size = New System.Drawing.Size(140, 13)
        Me.lbProgress.TabIndex = 2
        Me.lbProgress.Text = "Instalace probíhá, čekejte..."
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'menuStrip
        '
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlstrNapoveda, Me.tlstrSoubor})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(566, 24)
        Me.menuStrip.TabIndex = 3
        Me.menuStrip.Text = "MenuStrip1"
        '
        'tlstrNapoveda
        '
        Me.tlstrNapoveda.Name = "tlstrNapoveda"
        Me.tlstrNapoveda.Size = New System.Drawing.Size(73, 20)
        Me.tlstrNapoveda.Text = "Nápověda"
        '
        'tlstrSoubor
        '
        Me.tlstrSoubor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlstrOtevrit, Me.tlstrUlozit})
        Me.tlstrSoubor.Name = "tlstrSoubor"
        Me.tlstrSoubor.Size = New System.Drawing.Size(57, 20)
        Me.tlstrSoubor.Text = "Soubor"
        '
        'tlstrOtevrit
        '
        Me.tlstrOtevrit.Name = "tlstrOtevrit"
        Me.tlstrOtevrit.Size = New System.Drawing.Size(129, 22)
        Me.tlstrOtevrit.Text = "Otevřít"
        '
        'tlstrUlozit
        '
        Me.tlstrUlozit.Name = "tlstrUlozit"
        Me.tlstrUlozit.Size = New System.Drawing.Size(129, 22)
        Me.tlstrUlozit.Text = "Uložit jako"
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFileDialog1"
        '
        'txtBox
        '
        Me.txtBox.Location = New System.Drawing.Point(37, 220)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtBox.Size = New System.Drawing.Size(205, 190)
        Me.txtBox.TabIndex = 4
        Me.txtBox.Text = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(566, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'btnEsc
        '
        Me.btnEsc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEsc.Image = CType(resources.GetObject("btnEsc.Image"), System.Drawing.Image)
        Me.btnEsc.Location = New System.Drawing.Point(60, 67)
        Me.btnEsc.Name = "btnEsc"
        Me.btnEsc.Size = New System.Drawing.Size(60, 55)
        Me.btnEsc.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnEsc, "Ukončení formuláře")
        Me.btnEsc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tlačítko ukončení"
        '
        'combTyp
        '
        Me.combTyp.FormattingEnabled = True
        Me.combTyp.Items.AddRange(New Object() {"židle", "skříň", "police"})
        Me.combTyp.Location = New System.Drawing.Point(34, 184)
        Me.combTyp.Name = "combTyp"
        Me.combTyp.Size = New System.Drawing.Size(121, 21)
        Me.combTyp.TabIndex = 8
        '
        'lbTyp
        '
        Me.lbTyp.AutoSize = True
        Me.lbTyp.Location = New System.Drawing.Point(50, 168)
        Me.lbTyp.Name = "lbTyp"
        Me.lbTyp.Size = New System.Drawing.Size(89, 13)
        Me.lbTyp.TabIndex = 9
        Me.lbTyp.Text = "Zvol typ výrobku:"
        '
        'lbResult1
        '
        Me.lbResult1.AutoSize = True
        Me.lbResult1.Location = New System.Drawing.Point(34, 458)
        Me.lbResult1.Name = "lbResult1"
        Me.lbResult1.Size = New System.Drawing.Size(18, 13)
        Me.lbResult1.TabIndex = 10
        Me.lbResult1.Text = "ks"
        '
        'lbVystup
        '
        Me.lbVystup.AutoSize = True
        Me.lbVystup.Location = New System.Drawing.Point(34, 435)
        Me.lbVystup.Name = "lbVystup"
        Me.lbVystup.Size = New System.Drawing.Size(101, 13)
        Me.lbVystup.TabIndex = 11
        Me.lbVystup.Text = "Váš výsledný výběr:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radbtnPlast)
        Me.GroupBox1.Controls.Add(Me.radbtnDrevo)
        Me.GroupBox1.Controls.Add(Me.radbtnKov)
        Me.GroupBox1.Location = New System.Drawing.Point(179, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(111, 118)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Zvolte materiál: "
        '
        'radbtnPlast
        '
        Me.radbtnPlast.AutoSize = True
        Me.radbtnPlast.Location = New System.Drawing.Point(6, 86)
        Me.radbtnPlast.Name = "radbtnPlast"
        Me.radbtnPlast.Size = New System.Drawing.Size(59, 17)
        Me.radbtnPlast.TabIndex = 2
        Me.radbtnPlast.TabStop = True
        Me.radbtnPlast.Text = "PLAST"
        Me.radbtnPlast.UseVisualStyleBackColor = True
        '
        'radbtnDrevo
        '
        Me.radbtnDrevo.AutoSize = True
        Me.radbtnDrevo.Location = New System.Drawing.Point(6, 62)
        Me.radbtnDrevo.Name = "radbtnDrevo"
        Me.radbtnDrevo.Size = New System.Drawing.Size(63, 17)
        Me.radbtnDrevo.TabIndex = 1
        Me.radbtnDrevo.TabStop = True
        Me.radbtnDrevo.Text = "DŘEVO"
        Me.radbtnDrevo.UseVisualStyleBackColor = True
        '
        'radbtnKov
        '
        Me.radbtnKov.AutoSize = True
        Me.radbtnKov.Location = New System.Drawing.Point(6, 38)
        Me.radbtnKov.Name = "radbtnKov"
        Me.radbtnKov.Size = New System.Drawing.Size(47, 17)
        Me.radbtnKov.TabIndex = 0
        Me.radbtnKov.TabStop = True
        Me.radbtnKov.Text = "KOV"
        Me.radbtnKov.UseVisualStyleBackColor = True
        '
        'lbResult2
        '
        Me.lbResult2.AutoSize = True
        Me.lbResult2.Location = New System.Drawing.Point(62, 458)
        Me.lbResult2.Name = "lbResult2"
        Me.lbResult2.Size = New System.Drawing.Size(21, 13)
        Me.lbResult2.TabIndex = 13
        Me.lbResult2.Text = "typ"
        '
        'txtbCisloA
        '
        Me.txtbCisloA.Location = New System.Drawing.Point(328, 87)
        Me.txtbCisloA.Name = "txtbCisloA"
        Me.txtbCisloA.Size = New System.Drawing.Size(48, 20)
        Me.txtbCisloA.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(383, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "+"
        '
        'txtbCisloB
        '
        Me.txtbCisloB.Location = New System.Drawing.Point(402, 87)
        Me.txtbCisloB.Name = "txtbCisloB"
        Me.txtbCisloB.Size = New System.Drawing.Size(48, 20)
        Me.txtbCisloB.TabIndex = 16
        '
        'btnSecti
        '
        Me.btnSecti.Location = New System.Drawing.Point(456, 80)
        Me.btnSecti.Name = "btnSecti"
        Me.btnSecti.Size = New System.Drawing.Size(32, 30)
        Me.btnSecti.TabIndex = 17
        Me.btnSecti.Text = "="
        Me.ToolTip1.SetToolTip(Me.btnSecti, "Výsledek součtu")
        Me.btnSecti.UseVisualStyleBackColor = True
        '
        'lbSoucet
        '
        Me.lbSoucet.AutoSize = True
        Me.lbSoucet.Location = New System.Drawing.Point(494, 89)
        Me.lbSoucet.Name = "lbSoucet"
        Me.lbSoucet.Size = New System.Drawing.Size(49, 13)
        Me.lbSoucet.TabIndex = 18
        Me.lbSoucet.Text = "vysledek"
        '
        'volba
        '
        Me.volba.AutoSize = True
        Me.volba.Location = New System.Drawing.Point(328, 149)
        Me.volba.Name = "volba"
        Me.volba.Size = New System.Drawing.Size(98, 17)
        Me.volba.TabIndex = 19
        Me.volba.Text = "Lesklý povrch?"
        Me.volba.UseVisualStyleBackColor = True
        '
        'numKusy
        '
        Me.numKusy.Location = New System.Drawing.Point(328, 184)
        Me.numKusy.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.numKusy.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numKusy.Name = "numKusy"
        Me.numKusy.Size = New System.Drawing.Size(30, 20)
        Me.numKusy.TabIndex = 20
        Me.numKusy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(364, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Kolik kusů? (max 3)"
        '
        'lbResult3
        '
        Me.lbResult3.AutoSize = True
        Me.lbResult3.Location = New System.Drawing.Point(89, 458)
        Me.lbResult3.Name = "lbResult3"
        Me.lbResult3.Size = New System.Drawing.Size(43, 13)
        Me.lbResult3.TabIndex = 22
        Me.lbResult3.Text = "materiál"
        '
        'lbResult4
        '
        Me.lbResult4.AutoSize = True
        Me.lbResult4.Location = New System.Drawing.Point(137, 458)
        Me.lbResult4.Name = "lbResult4"
        Me.lbResult4.Size = New System.Drawing.Size(69, 13)
        Me.lbResult4.TabIndex = 23
        Me.lbResult4.Text = "lesklý povrch"
        Me.lbResult4.Visible = False
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(328, 254)
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(160, 45)
        Me.TrackBar1.TabIndex = 24
        Me.TrackBar1.Value = 1
        '
        'frMain
        '
        Me.AcceptButton = Me.btnSecti
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnEsc
        Me.ClientSize = New System.Drawing.Size(566, 627)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.lbResult4)
        Me.Controls.Add(Me.lbResult3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numKusy)
        Me.Controls.Add(Me.volba)
        Me.Controls.Add(Me.lbSoucet)
        Me.Controls.Add(Me.btnSecti)
        Me.Controls.Add(Me.txtbCisloB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbCisloA)
        Me.Controls.Add(Me.lbResult2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbVystup)
        Me.Controls.Add(Me.lbResult1)
        Me.Controls.Add(Me.lbTyp)
        Me.Controls.Add(Me.combTyp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEsc)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtBox)
        Me.Controls.Add(Me.lbProgress)
        Me.Controls.Add(Me.progBar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.menuStrip)
        Me.MainMenuStrip = Me.menuStrip
        Me.Name = "frMain"
        Me.Text = "Nábytek"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numKusy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents progBar As Windows.Forms.ProgressBar
    Friend WithEvents lbProgress As Windows.Forms.Label
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents Timer2 As Windows.Forms.Timer
    Friend WithEvents lbstatTime As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbstatPosuvnik As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menuStrip As Windows.Forms.MenuStrip
    Friend WithEvents tlstrNapoveda As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlstrSoubor As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlstrOtevrit As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlstrUlozit As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFile As Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFile As Windows.Forms.SaveFileDialog
    Friend WithEvents txtBox As Windows.Forms.RichTextBox
    Friend WithEvents ToolStrip1 As Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As Windows.Forms.ToolStripButton
    Friend WithEvents btnEsc As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents combTyp As Windows.Forms.ComboBox
    Friend WithEvents lbTyp As Windows.Forms.Label
    Friend WithEvents lbResult1 As Windows.Forms.Label
    Friend WithEvents lbVystup As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents radbtnPlast As Windows.Forms.RadioButton
    Friend WithEvents radbtnDrevo As Windows.Forms.RadioButton
    Friend WithEvents radbtnKov As Windows.Forms.RadioButton
    Friend WithEvents lbResult2 As Windows.Forms.Label
    Friend WithEvents txtbCisloA As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtbCisloB As Windows.Forms.TextBox
    Friend WithEvents btnSecti As Windows.Forms.Button
    Friend WithEvents lbSoucet As Windows.Forms.Label
    Friend WithEvents volba As Windows.Forms.CheckBox
    Friend WithEvents numKusy As Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents lbResult3 As Windows.Forms.Label
    Friend WithEvents lbResult4 As Windows.Forms.Label
    Friend WithEvents TrackBar1 As Windows.Forms.TrackBar
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
End Class
