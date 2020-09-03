<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frMain))
        Me.msSoubor = New System.Windows.Forms.MenuStrip()
        Me.tsmenuSoubor = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmenuNovy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmenuOtevrit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmenuUlozit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmenuKonec = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmenuNastav = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmenuFormat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmenuData = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmenuNapov = New System.Windows.Forms.ToolStripMenuItem()
        Me.statsBar = New System.Windows.Forms.StatusStrip()
        Me.statlTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statlCheck = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnVariantaC = New System.Windows.Forms.RadioButton()
        Me.rbtnVariantaA = New System.Windows.Forms.RadioButton()
        Me.rbtnVariantaB = New System.Windows.Forms.RadioButton()
        Me.cboxOvoce = New System.Windows.Forms.ComboBox()
        Me.trbarOvoce = New System.Windows.Forms.TrackBar()
        Me.lbOvoce = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.lbSoucin = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.btnSmaz = New System.Windows.Forms.Button()
        Me.btnZobraz = New System.Windows.Forms.Button()
        Me.pictBox = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbJakost = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.msSoubor.SuspendLayout()
        Me.statsBar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.trbarOvoce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msSoubor
        '
        Me.msSoubor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmenuSoubor, Me.tsmenuNastav, Me.tsmenuFormat, Me.tsmenuData, Me.tsmenuNapov})
        Me.msSoubor.Location = New System.Drawing.Point(0, 0)
        Me.msSoubor.Name = "msSoubor"
        Me.msSoubor.Size = New System.Drawing.Size(898, 25)
        Me.msSoubor.TabIndex = 1
        Me.msSoubor.Text = "MenuStrip1"
        '
        'tsmenuSoubor
        '
        Me.tsmenuSoubor.BackColor = System.Drawing.SystemColors.Menu
        Me.tsmenuSoubor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmenuNovy, Me.tsmenuOtevrit, Me.tsmenuUlozit, Me.tsmenuKonec})
        Me.tsmenuSoubor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tsmenuSoubor.Name = "tsmenuSoubor"
        Me.tsmenuSoubor.Size = New System.Drawing.Size(63, 21)
        Me.tsmenuSoubor.Text = "Soubor"
        '
        'tsmenuNovy
        '
        Me.tsmenuNovy.Name = "tsmenuNovy"
        Me.tsmenuNovy.Size = New System.Drawing.Size(115, 22)
        Me.tsmenuNovy.Text = "Nový"
        '
        'tsmenuOtevrit
        '
        Me.tsmenuOtevrit.Name = "tsmenuOtevrit"
        Me.tsmenuOtevrit.Size = New System.Drawing.Size(115, 22)
        Me.tsmenuOtevrit.Text = "Otevřít"
        '
        'tsmenuUlozit
        '
        Me.tsmenuUlozit.Name = "tsmenuUlozit"
        Me.tsmenuUlozit.Size = New System.Drawing.Size(180, 22)
        Me.tsmenuUlozit.Text = "Uložit"
        '
        'tsmenuKonec
        '
        Me.tsmenuKonec.Name = "tsmenuKonec"
        Me.tsmenuKonec.Size = New System.Drawing.Size(115, 22)
        Me.tsmenuKonec.Text = "Konec"
        '
        'tsmenuNastav
        '
        Me.tsmenuNastav.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tsmenuNastav.Name = "tsmenuNastav"
        Me.tsmenuNastav.Size = New System.Drawing.Size(77, 21)
        Me.tsmenuNastav.Text = "Nastavení"
        '
        'tsmenuFormat
        '
        Me.tsmenuFormat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tsmenuFormat.Name = "tsmenuFormat"
        Me.tsmenuFormat.Size = New System.Drawing.Size(61, 21)
        Me.tsmenuFormat.Text = "Formát"
        '
        'tsmenuData
        '
        Me.tsmenuData.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tsmenuData.Name = "tsmenuData"
        Me.tsmenuData.Size = New System.Drawing.Size(47, 21)
        Me.tsmenuData.Text = "Data"
        '
        'tsmenuNapov
        '
        Me.tsmenuNapov.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tsmenuNapov.Name = "tsmenuNapov"
        Me.tsmenuNapov.Size = New System.Drawing.Size(81, 21)
        Me.tsmenuNapov.Text = "Nápověda"
        '
        'statsBar
        '
        Me.statsBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statlTime, Me.statlCheck})
        Me.statsBar.Location = New System.Drawing.Point(0, 592)
        Me.statsBar.Name = "statsBar"
        Me.statsBar.Size = New System.Drawing.Size(898, 22)
        Me.statsBar.TabIndex = 2
        Me.statsBar.Text = "StatusStrip1"
        '
        'statlTime
        '
        Me.statlTime.Name = "statlTime"
        Me.statlTime.Size = New System.Drawing.Size(74, 17)
        Me.statlTime.Text = "Aktuální čas:"
        '
        'statlCheck
        '
        Me.statlCheck.Name = "statlCheck"
        Me.statlCheck.Size = New System.Drawing.Size(168, 17)
        Me.statlCheck.Text = "Počet zatrhnutých CheckBoxů:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnVariantaC)
        Me.GroupBox1.Controls.Add(Me.rbtnVariantaA)
        Me.GroupBox1.Controls.Add(Me.rbtnVariantaB)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(538, 31)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.GroupBox1.Size = New System.Drawing.Size(334, 41)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Volba variant:"
        '
        'rbtnVariantaC
        '
        Me.rbtnVariantaC.AutoSize = True
        Me.rbtnVariantaC.Location = New System.Drawing.Point(192, 16)
        Me.rbtnVariantaC.Name = "rbtnVariantaC"
        Me.rbtnVariantaC.Size = New System.Drawing.Size(91, 23)
        Me.rbtnVariantaC.TabIndex = 6
        Me.rbtnVariantaC.TabStop = True
        Me.rbtnVariantaC.Text = "Varianta C"
        Me.rbtnVariantaC.UseVisualStyleBackColor = True
        '
        'rbtnVariantaA
        '
        Me.rbtnVariantaA.AutoSize = True
        Me.rbtnVariantaA.Location = New System.Drawing.Point(8, 15)
        Me.rbtnVariantaA.Name = "rbtnVariantaA"
        Me.rbtnVariantaA.Size = New System.Drawing.Size(91, 23)
        Me.rbtnVariantaA.TabIndex = 4
        Me.rbtnVariantaA.TabStop = True
        Me.rbtnVariantaA.Text = "Varianta A"
        Me.rbtnVariantaA.UseVisualStyleBackColor = True
        '
        'rbtnVariantaB
        '
        Me.rbtnVariantaB.AutoSize = True
        Me.rbtnVariantaB.Location = New System.Drawing.Point(99, 16)
        Me.rbtnVariantaB.Name = "rbtnVariantaB"
        Me.rbtnVariantaB.Size = New System.Drawing.Size(90, 23)
        Me.rbtnVariantaB.TabIndex = 5
        Me.rbtnVariantaB.TabStop = True
        Me.rbtnVariantaB.Text = "Varianta B"
        Me.rbtnVariantaB.UseVisualStyleBackColor = True
        '
        'cboxOvoce
        '
        Me.cboxOvoce.FormattingEnabled = True
        Me.cboxOvoce.Items.AddRange(New Object() {"Jahody", "Maliny", "Borůvky", "Ostružiny", "Rybíz"})
        Me.cboxOvoce.Location = New System.Drawing.Point(199, 51)
        Me.cboxOvoce.Name = "cboxOvoce"
        Me.cboxOvoce.Size = New System.Drawing.Size(204, 21)
        Me.cboxOvoce.TabIndex = 4
        Me.cboxOvoce.Text = "Jahody"
        '
        'trbarOvoce
        '
        Me.trbarOvoce.Location = New System.Drawing.Point(199, 89)
        Me.trbarOvoce.Maximum = 20
        Me.trbarOvoce.Name = "trbarOvoce"
        Me.trbarOvoce.Size = New System.Drawing.Size(204, 45)
        Me.trbarOvoce.TabIndex = 5
        '
        'lbOvoce
        '
        Me.lbOvoce.AutoSize = True
        Me.lbOvoce.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbOvoce.Location = New System.Drawing.Point(194, 127)
        Me.lbOvoce.Name = "lbOvoce"
        Me.lbOvoce.Size = New System.Drawing.Size(73, 25)
        Me.lbOvoce.TabIndex = 6
        Me.lbOvoce.Text = "Jahody"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(45, 531)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(786, 36)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(45, 226)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(338, 299)
        Me.TextBox1.TabIndex = 8
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(389, 228)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(389, 251)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(389, 274)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox3.TabIndex = 11
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(389, 297)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox4.TabIndex = 12
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(389, 320)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox5.TabIndex = 13
        Me.CheckBox5.Text = "CheckBox5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(389, 343)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox6.TabIndex = 14
        Me.CheckBox6.Text = "CheckBox6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(389, 366)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox7.TabIndex = 15
        Me.CheckBox7.Text = "CheckBox7"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'lbSoucin
        '
        Me.lbSoucin.AutoSize = True
        Me.lbSoucin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbSoucin.Location = New System.Drawing.Point(331, 199)
        Me.lbSoucin.Name = "lbSoucin"
        Me.lbSoucin.Size = New System.Drawing.Size(63, 17)
        Me.lbSoucin.TabIndex = 16
        Me.lbSoucin.Text = "Součin je:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(45, 200)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(137, 20)
        Me.NumericUpDown1.TabIndex = 17
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(188, 200)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(137, 20)
        Me.NumericUpDown2.TabIndex = 18
        '
        'btnSmaz
        '
        Me.btnSmaz.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSmaz.Location = New System.Drawing.Point(485, 142)
        Me.btnSmaz.Name = "btnSmaz"
        Me.btnSmaz.Size = New System.Drawing.Size(151, 64)
        Me.btnSmaz.TabIndex = 19
        Me.btnSmaz.Text = "Smaž obrázek"
        Me.btnSmaz.UseVisualStyleBackColor = True
        '
        'btnZobraz
        '
        Me.btnZobraz.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnZobraz.Location = New System.Drawing.Point(695, 142)
        Me.btnZobraz.Name = "btnZobraz"
        Me.btnZobraz.Size = New System.Drawing.Size(136, 64)
        Me.btnZobraz.TabIndex = 20
        Me.btnZobraz.Text = "Zobraz obrázek kytičky"
        Me.btnZobraz.UseVisualStyleBackColor = True
        '
        'pictBox
        '
        Me.pictBox.Image = CType(resources.GetObject("pictBox.Image"), System.Drawing.Image)
        Me.pictBox.ImageLocation = ""
        Me.pictBox.Location = New System.Drawing.Point(485, 226)
        Me.pictBox.Name = "pictBox"
        Me.pictBox.Size = New System.Drawing.Size(346, 299)
        Me.pictBox.TabIndex = 21
        Me.pictBox.TabStop = False
        '
        'Timer1
        '
        '
        'lbJakost
        '
        Me.lbJakost.AutoSize = True
        Me.lbJakost.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbJakost.Location = New System.Drawing.Point(262, 127)
        Me.lbJakost.Name = "lbJakost"
        Me.lbJakost.Size = New System.Drawing.Size(63, 25)
        Me.lbJakost.TabIndex = 22
        Me.lbJakost.Text = "jakost"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 614)
        Me.Controls.Add(Me.lbJakost)
        Me.Controls.Add(Me.pictBox)
        Me.Controls.Add(Me.btnZobraz)
        Me.Controls.Add(Me.btnSmaz)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.lbSoucin)
        Me.Controls.Add(Me.CheckBox7)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.lbOvoce)
        Me.Controls.Add(Me.trbarOvoce)
        Me.Controls.Add(Me.cboxOvoce)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.statsBar)
        Me.Controls.Add(Me.msSoubor)
        Me.MainMenuStrip = Me.msSoubor
        Me.Name = "frMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form"
        Me.msSoubor.ResumeLayout(False)
        Me.msSoubor.PerformLayout()
        Me.statsBar.ResumeLayout(False)
        Me.statsBar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.trbarOvoce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msSoubor As Windows.Forms.MenuStrip
    Friend WithEvents tsmenuSoubor As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmenuNovy As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmenuOtevrit As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmenuUlozit As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmenuKonec As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmenuNastav As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmenuFormat As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmenuData As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmenuNapov As Windows.Forms.ToolStripMenuItem
    Friend WithEvents statsBar As Windows.Forms.StatusStrip
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents rbtnVariantaC As Windows.Forms.RadioButton
    Friend WithEvents rbtnVariantaA As Windows.Forms.RadioButton
    Friend WithEvents rbtnVariantaB As Windows.Forms.RadioButton
    Friend WithEvents cboxOvoce As Windows.Forms.ComboBox
    Friend WithEvents trbarOvoce As Windows.Forms.TrackBar
    Friend WithEvents lbOvoce As Windows.Forms.Label
    Friend WithEvents ProgressBar As Windows.Forms.ProgressBar
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As Windows.Forms.CheckBox
    Friend WithEvents lbSoucin As Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown2 As Windows.Forms.NumericUpDown
    Friend WithEvents btnSmaz As Windows.Forms.Button
    Friend WithEvents btnZobraz As Windows.Forms.Button
    Friend WithEvents pictBox As Windows.Forms.PictureBox
    Friend WithEvents statlTime As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statlCheck As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents lbJakost As Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As Windows.Forms.SaveFileDialog
End Class
