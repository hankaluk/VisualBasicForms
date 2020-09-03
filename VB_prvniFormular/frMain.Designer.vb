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
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.lbA = New System.Windows.Forms.Label()
        Me.lbB = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.lbP = New System.Windows.Forms.Label()
        Me.txtP = New System.Windows.Forms.TextBox()
        Me.btnSpocti = New System.Windows.Forms.Button()
        Me.mm1 = New System.Windows.Forms.Label()
        Me.mm2 = New System.Windows.Forms.Label()
        Me.mmP = New System.Windows.Forms.Label()
        Me.resetbtn = New System.Windows.Forms.Button()
        Me.sbA = New System.Windows.Forms.VScrollBar()
        Me.cbCtverec = New System.Windows.Forms.CheckBox()
        Me.btnKonec = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtA.Location = New System.Drawing.Point(135, 75)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 26)
        Me.txtA.TabIndex = 0
        '
        'lbA
        '
        Me.lbA.AutoSize = True
        Me.lbA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbA.Location = New System.Drawing.Point(38, 75)
        Me.lbA.Name = "lbA"
        Me.lbA.Size = New System.Drawing.Size(70, 20)
        Me.lbA.TabIndex = 1
        Me.lbA.Text = "Strana a"
        '
        'lbB
        '
        Me.lbB.AutoSize = True
        Me.lbB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbB.Location = New System.Drawing.Point(38, 112)
        Me.lbB.Name = "lbB"
        Me.lbB.Size = New System.Drawing.Size(70, 20)
        Me.lbB.TabIndex = 3
        Me.lbB.Text = "Strana b"
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtB.Location = New System.Drawing.Point(135, 112)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 26)
        Me.txtB.TabIndex = 2
        '
        'lbP
        '
        Me.lbP.AutoSize = True
        Me.lbP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbP.Location = New System.Drawing.Point(38, 164)
        Me.lbP.Name = "lbP"
        Me.lbP.Size = New System.Drawing.Size(71, 20)
        Me.lbP.TabIndex = 4
        Me.lbP.Text = "Plocha P"
        '
        'txtP
        '
        Me.txtP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtP.Location = New System.Drawing.Point(135, 164)
        Me.txtP.Name = "txtP"
        Me.txtP.Size = New System.Drawing.Size(100, 26)
        Me.txtP.TabIndex = 5
        '
        'btnSpocti
        '
        Me.btnSpocti.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSpocti.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSpocti.Location = New System.Drawing.Point(135, 251)
        Me.btnSpocti.Name = "btnSpocti"
        Me.btnSpocti.Size = New System.Drawing.Size(100, 43)
        Me.btnSpocti.TabIndex = 6
        Me.btnSpocti.Text = "Spočti"
        Me.btnSpocti.UseVisualStyleBackColor = False
        '
        'mm1
        '
        Me.mm1.AutoSize = True
        Me.mm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.mm1.Location = New System.Drawing.Point(241, 82)
        Me.mm1.Name = "mm1"
        Me.mm1.Size = New System.Drawing.Size(35, 20)
        Me.mm1.TabIndex = 7
        Me.mm1.Text = "mm"
        '
        'mm2
        '
        Me.mm2.AutoSize = True
        Me.mm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.mm2.Location = New System.Drawing.Point(241, 119)
        Me.mm2.Name = "mm2"
        Me.mm2.Size = New System.Drawing.Size(35, 20)
        Me.mm2.TabIndex = 8
        Me.mm2.Text = "mm"
        '
        'mmP
        '
        Me.mmP.AutoSize = True
        Me.mmP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.mmP.Location = New System.Drawing.Point(241, 171)
        Me.mmP.Name = "mmP"
        Me.mmP.Size = New System.Drawing.Size(44, 20)
        Me.mmP.TabIndex = 9
        Me.mmP.Text = "mm2"
        '
        'resetbtn
        '
        Me.resetbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.resetbtn.Location = New System.Drawing.Point(42, 270)
        Me.resetbtn.Name = "resetbtn"
        Me.resetbtn.Size = New System.Drawing.Size(45, 23)
        Me.resetbtn.TabIndex = 10
        Me.resetbtn.Text = "Reset"
        Me.resetbtn.UseVisualStyleBackColor = False
        '
        'sbA
        '
        Me.sbA.LargeChange = 50
        Me.sbA.Location = New System.Drawing.Point(296, 26)
        Me.sbA.Maximum = 1009
        Me.sbA.Name = "sbA"
        Me.sbA.Size = New System.Drawing.Size(34, 318)
        Me.sbA.TabIndex = 14
        '
        'cbCtverec
        '
        Me.cbCtverec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbCtverec.Location = New System.Drawing.Point(135, 196)
        Me.cbCtverec.Name = "cbCtverec"
        Me.cbCtverec.Size = New System.Drawing.Size(100, 37)
        Me.cbCtverec.TabIndex = 15
        Me.cbCtverec.Text = "Čtverec"
        Me.cbCtverec.UseVisualStyleBackColor = True
        '
        'btnKonec
        '
        Me.btnKonec.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKonec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnKonec.Location = New System.Drawing.Point(135, 310)
        Me.btnKonec.Name = "btnKonec"
        Me.btnKonec.Size = New System.Drawing.Size(100, 43)
        Me.btnKonec.TabIndex = 16
        Me.btnKonec.Text = "Konec"
        Me.btnKonec.UseVisualStyleBackColor = False
        '
        'frMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(376, 385)
        Me.Controls.Add(Me.btnKonec)
        Me.Controls.Add(Me.cbCtverec)
        Me.Controls.Add(Me.sbA)
        Me.Controls.Add(Me.resetbtn)
        Me.Controls.Add(Me.mmP)
        Me.Controls.Add(Me.mm2)
        Me.Controls.Add(Me.mm1)
        Me.Controls.Add(Me.btnSpocti)
        Me.Controls.Add(Me.txtP)
        Me.Controls.Add(Me.lbP)
        Me.Controls.Add(Me.lbB)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.lbA)
        Me.Controls.Add(Me.txtA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My first form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtA As Windows.Forms.TextBox
    Friend WithEvents lbA As Windows.Forms.Label
    Friend WithEvents lbB As Windows.Forms.Label
    Friend WithEvents txtB As Windows.Forms.TextBox
    Friend WithEvents lbP As Windows.Forms.Label
    Friend WithEvents txtP As Windows.Forms.TextBox
    Friend WithEvents btnSpocti As Windows.Forms.Button
    Friend WithEvents mm1 As Windows.Forms.Label
    Friend WithEvents mm2 As Windows.Forms.Label
    Friend WithEvents mmP As Windows.Forms.Label
    Friend WithEvents resetbtn As Windows.Forms.Button
    Friend WithEvents sbA As Windows.Forms.VScrollBar
    Friend WithEvents cbCtverec As Windows.Forms.CheckBox
    Friend WithEvents btnKonec As Windows.Forms.Button
End Class
