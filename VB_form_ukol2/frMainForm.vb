Public Class frMainForm
    Dim DayTimeNow As DateTime
    Private Sub frMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar.Maximum = 10000
        Me.Timer1.Start()
        Me.statbTime.Text = "Aktuální čas: " + DayTimeNow.ToString("HH:mm:ss")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim progress As Integer
        progress = Me.ProgressBar.Maximum / 1000
        Me.DayTimeNow = System.DateTime.Now
        Me.statbTime.Text = "Aktuální čas: " + DayTimeNow.ToString("HH:mm:ss")
        Me.ProgressBar.Value += Me.Timer1.Interval

        progress -= Me.ProgressBar.Value / 1000
        lbProgress.Text = "ProgressBar bude běžet ještě: " + progress.ToString

        If Me.ProgressBar.Value = Me.ProgressBar.Maximum Then
            Me.Timer1.Stop()
        End If

    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.ProgressBar.Value = 0
        Me.Timer1.Start()
        Me.DayTimeNow = System.DateTime.Now
        Me.statbTime.Text = "Aktuální čas: " + DayTimeNow.ToString("HH:mm:ss")
    End Sub

    'Výběr barvy
    '............................................................................................
    Private Sub combBarvy_SelectedValueChanged(sender As Object, e As EventArgs) Handles combBarvy.SelectedValueChanged
        lbInfo4.Text = "barva " + combBarvy.Text
    End Sub
    Private Sub combBarvy_TextChanged(sender As Object, e As EventArgs) Handles combBarvy.TextChanged
        lbInfo4.Text = "barva " + combBarvy.Text
    End Sub

    'Ukončení tlačítkem Konec
    '---------------------------------------------------------------------------------------
    Private Sub btnKonec_Click(sender As Object, e As EventArgs) Handles btnKonec.Click
        Me.Close()
    End Sub

    'Sčítání hodnot
    '-------------------------------------------------------------------------------------------------

    Private Sub txtboxA_TextChanged(sender As Object, e As EventArgs) Handles txtboxA.TextChanged
        Secti()
    End Sub
    Private Sub txtboxA_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtboxA.KeyPress
        If Not (IsNumeric(e.KeyChar) Or e.KeyChar = "-") Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtboxB_TextChanged(sender As Object, e As EventArgs) Handles txtboxB.TextChanged
        Secti()
    End Sub
    Private Sub txtboxB_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtboxB.KeyPress
        If Not (IsNumeric(e.KeyChar) Or e.KeyChar = "-") Then
            e.Handled = True
        End If
    End Sub
    Private Sub numericbox_ValueChanged(sender As Object, e As EventArgs) Handles numericbox.ValueChanged
        Secti()
    End Sub

    Sub Secti()
        Dim A As Integer
        Dim B As Integer
        Dim C As Integer
        Dim S As Integer
        Dim Total As Integer

        A = CInt(Val(txtboxA.Text))
        B = CInt(Val(txtboxB.Text))
        C = numericbox.Value

        S = A + B + C

        lbSoucet.Text = "Součet: " + S.ToString()

        Total = S * TrackBar1.Value
        lbTotal.Text = "Součet * TrackBar = " + Total.ToString
        lbInfo1.Text = Total.ToString

    End Sub
    'TrackBar
    '----------------------------------------------------------------------------------------------------
    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged
        Dim pos As Integer
        pos = TrackBar1.Value
        lbPosuvnik.Text = "Posuvníkem nastaveno: " + pos.ToString
        Secti()
    End Sub
    'Práce se soubory
    '--------------------------------------------------------------------------------------------------------------------
    Private Sub OtevřítToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtevřítToolStripMenuItem.Click
        Dim path As String
        With OpenFileDialog1
            .Title = "Zvolte soubor"
            .Filter = "Texty (*.txt)|*.txt|Dokumenty (*.doc;*docx)|*.doc;*docx|Všechny soubory (*.*)|*.*"
            .FilterIndex = 2
            .ShowDialog()
        End With
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
        path = OpenFileDialog1.FileName.ToString
        Input(1, TextBox1.Text)
        FileClose(1)
        toolstCesta.Text = "Naposledy otevřený soubor: " + path
    End Sub

    Private Sub UložitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UložitToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
        Write(1, TextBox1.Text)
        FileClose(1)
    End Sub

    Private Sub toolstrHelp_Click(sender As Object, e As EventArgs) Handles toolstrHelp.Click
        MsgBox("Toto je nápověda...")
    End Sub
    'Resize
    '-----------------------------------------------------------------------------------------------
    Sub ResizeLabel()
        lbInfo2.Left = lbInfo1.Right
        lbInfo3.Left = lbInfo2.Right
        lbInfo4.Left = lbInfo3.Right

    End Sub

    Private Sub lbInfo1_SizeChanged(sender As Object, e As EventArgs) Handles lbInfo1.SizeChanged
        ResizeLabel()
    End Sub
    Private Sub lbInfo2_SizeChanged(sender As Object, e As EventArgs) Handles lbInfo2.SizeChanged
        ResizeLabel()
    End Sub
    Private Sub lbInfo3_SizeChanged(sender As Object, e As EventArgs) Handles lbInfo3.SizeChanged
        ResizeLabel()
    End Sub

    'Checkbox
    '----------------------------------------------------------------------------------------------------------
    Sub Stav()
        lbInfo2.Text = ""
        If chbDelsi.Checked Then lbInfo2.Text += "delší "
        If chbHlubsi.Checked Then lbInfo2.Text += "hlubší "
        If chbVyssi.Checked Then lbInfo2.Text += "vyšší "
    End Sub
    Private Sub chbDelsi_CheckedChanged(sender As Object, e As EventArgs) Handles chbDelsi.CheckedChanged
        Stav()
    End Sub

    Private Sub chbVyssi_CheckedChanged(sender As Object, e As EventArgs) Handles chbVyssi.CheckedChanged
        Stav()
    End Sub

    Private Sub chbHlubsi_CheckedChanged(sender As Object, e As EventArgs) Handles chbHlubsi.CheckedChanged
        Stav()
    End Sub

    'radiobutton
    '-----------------------------------------------------------------------------------------------------
    Private Sub radbDrevo_CheckedChanged(sender As Object, e As EventArgs) Handles radbDrevo.CheckedChanged
        If radbDrevo.Checked Then lbInfo3.Text = "dřevo "
    End Sub

    Private Sub radbKov_CheckedChanged(sender As Object, e As EventArgs) Handles radbKov.CheckedChanged
        If radbKov.Checked Then lbInfo3.Text = "kov "
    End Sub

    Private Sub radbPlast_CheckedChanged(sender As Object, e As EventArgs) Handles radbPlast.CheckedChanged
        If radbPlast.Checked Then lbInfo3.Text = "plast "
    End Sub

    Private Sub radbSklo_CheckedChanged(sender As Object, e As EventArgs) Handles radbSklo.CheckedChanged
        If radbSklo.Checked Then lbInfo3.Text = "sklo "
    End Sub


End Class