Imports System.Drawing.Font


Public Class frMain

    Public DayTimeNow As DateTime
    Dim PuvFont, NovyFont As System.Drawing.Font
    Dim FontStyle As System.Drawing.FontStyle
    'Progress Bar
    '---------------------------------------------------------------------------
    Private Sub frMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.progBar.Maximum = progressMax * 1000
        Me.Timer1.Start()
        Me.Timer2.Start()

        'Font
        PuvFont = Me.lbSoucet.Font
        NovyFont = New System.Drawing.Font(lbSoucet.Font.SystemFontName, 9, FontStyle.Bold)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.progBar.Value += Me.Timer1.Interval
        If Me.progBar.Value = Me.progBar.Maximum Then Me.Timer1.Stop()

        Dim Progress As Integer
        Progress = progressMax
        Progress -= Me.progBar.Value / 1000
        lbProgress.Text = "Instalace probíhá, čekejte... " + Progress.ToString
    End Sub
    'Hodiny
    '---------------------------------------------------------------------------
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.DayTimeNow = System.DateTime.Now
        Me.lbstatTime.Text = DayTimeNow.ToString("HH:mm:ss")
    End Sub
    'Menu nabídka
    '---------------------------------------------------------------------------
    Private Sub tlstrNapoveda_Click(sender As Object, e As EventArgs) Handles tlstrNapoveda.Click
        MsgBox("Nápověda k formuláři Nábytek.",, "Nápověda")
    End Sub

    Private Sub tlstrOtevrit_Click(sender As Object, e As EventArgs) Handles tlstrOtevrit.Click
        With OpenFile
            .Title = "Zvolte soubor"
            .Filter = "Texty (*.txt)|*.txt|Dokumenty (*.doc;*docx)|*.doc;*docx|Všechny soubory (*.*)|*.*"
            .FilterIndex = 1
            '.ShowDialog()
        End With
        Dim result As Windows.Forms.DialogResult = OpenFile.ShowDialog()
        If result.Equals(DialogResult.OK) Then
            FileOpen(1, OpenFile.FileName, OpenMode.Input)
            Input(1, txtBox.Text)
            FileClose(1)
        End If
    End Sub

    Private Sub tlstrUlozit_Click(sender As Object, e As EventArgs) Handles tlstrUlozit.Click
        With SaveFile
            .Title = "Uložte jako"
            .Filter = "Texty (*.txt)|*.txt|Dokumenty (*.doc;*docx)|*.doc;*docx|Všechny soubory (*.*)|*.*"
            .FilterIndex = 1
            '.ShowDialog()
        End With
        SaveFile.ShowDialog()
        FileOpen(1, SaveFile.FileName, OpenMode.Output)
        Write(1, txtBox.Text)
        FileClose(1)
    End Sub
    'Ukončení formuláře stiskem tlačítka
    '---------------------------------------------------------------------------
    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Me.Close()
    End Sub
    'Combobox typ výrobku
    '---------------------------------------------------------------------------
    Private Sub combTyp_TextChanged(sender As Object, e As EventArgs) Handles combTyp.TextChanged
        lbResult2.Text = combTyp.Text
    End Sub

    Private Sub combTyp_SelectedValueChanged(sender As Object, e As EventArgs) Handles combTyp.SelectedValueChanged
        lbResult2.Text = combTyp.Text
    End Sub
    'Radiobuttons
    '---------------------------------------------------------------------------
    Private Sub radbtnKov_CheckedChanged(sender As Object, e As EventArgs) Handles radbtnKov.CheckedChanged
        If radbtnKov.Checked Then lbResult3.Text = "materiál kov"
    End Sub

    Private Sub radbtnDrevo_CheckedChanged(sender As Object, e As EventArgs) Handles radbtnDrevo.CheckedChanged
        If radbtnDrevo.Checked Then lbResult3.Text = "materiál dřevo"
    End Sub

    Private Sub radbtnPlast_CheckedChanged(sender As Object, e As EventArgs) Handles radbtnPlast.CheckedChanged
        If radbtnPlast.Checked Then lbResult3.Text = "materiál plast"
    End Sub
    'Sčítání
    '---------------------------------------------------------------------------
    Sub Secti()
        Dim A As Integer
        Dim B As Integer
        Dim S As Integer

        A = CInt(Val(txtbCisloA.Text))
        B = CInt(Val(txtbCisloB.Text))
        S = A + B

        lbSoucet.Text = S.ToString
        If S > 0 Then
            lbSoucet.Font = NovyFont
        Else
            lbSoucet.Font = PuvFont
        End If

    End Sub
    Private Sub txtbCisloA_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtbCisloA.KeyPress
        If Not (IsNumeric(e.KeyChar) Or e.KeyChar = "-") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbCisloB_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtbCisloB.KeyPress
        If Not (IsNumeric(e.KeyChar) Or e.KeyChar = "-") Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSecti_Click(sender As Object, e As EventArgs) Handles btnSecti.Click
        Secti()
    End Sub
    'Lesklý checkbox
    '---------------------------------------------------------------------------
    Private Sub volba_CheckedChanged(sender As Object, e As EventArgs) Handles volba.CheckedChanged
        lbResult4.Visible = False
        If volba.Checked Then lbResult4.Visible = True
    End Sub
    'NumUpDown Kusy
    '---------------------------------------------------------------------------
    Private Sub numKusy_ValueChanged(sender As Object, e As EventArgs) Handles numKusy.ValueChanged
        lbResult1.Text = numKusy.Value.ToString + " ks"
    End Sub
    'Resize labely
    '---------------------------------------------------------------------------
    Sub LableSize()
        lbResult2.Left = lbResult1.Right
        lbResult3.Left = lbResult2.Right
        lbResult4.Left = lbResult3.Right
    End Sub

    Private Sub lbResult1_SizeChanged(sender As Object, e As EventArgs) Handles lbResult1.SizeChanged
        LableSize()
    End Sub
    Private Sub lbResult2_SizeChanged(sender As Object, e As EventArgs) Handles lbResult2.SizeChanged
        LableSize()
    End Sub
    Private Sub lbResult3_SizeChanged(sender As Object, e As EventArgs) Handles lbResult3.SizeChanged
        LableSize()
    End Sub
    'TrackBar
    '---------------------------------------------------------------------------
    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged
        lbstatPosuvnik.Text = TrackBar1.Value.ToString
    End Sub
End Class