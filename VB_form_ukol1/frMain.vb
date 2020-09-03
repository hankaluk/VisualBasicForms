Option Strict On
Option Explicit On


Public Class frMain
    'Progress Bar + aktuální čas on load formuláře
    '-----------------------------------------------------------------------------------------------------
    Private Sub frMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar.Maximum = cislo * 1000
        Me.Timer1.Start()
        Dim DayTimeNow As DateTime = System.DateTime.Now
        statlTime.Text = "Aktuální čas: " + DayTimeNow.ToString("HH:mm")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.ProgressBar.Value += Me.Timer1.Interval
        If Me.ProgressBar.Value = Me.ProgressBar.Maximum Then
            Me.Timer1.Stop()
        End If

    End Sub
    Private Sub tsmenuNovy_Click(sender As Object, e As EventArgs) Handles tsmenuNovy.Click
        Me.ProgressBar.Value = 0
        Me.Timer1.Start()

        Dim DayTimeNow As DateTime = System.DateTime.Now
        statlTime.Text = "Aktuální čas: " + DayTimeNow.ToString("HH:mm")
    End Sub

    'Obrázek
    '--------------------------------------------------------------------------------------------------------
    Private Sub btnSmaz_Click(sender As Object, e As EventArgs) Handles btnSmaz.Click
        Me.pictBox.Visible = False
    End Sub

    Private Sub btnZobraz_Click(sender As Object, e As EventArgs) Handles btnZobraz.Click
        Me.pictBox.Visible = True
    End Sub

    'Menu Bar
    '----------------------------------------------------------------------------------------------------------
    Private Sub tsmenuNapov_Click(sender As Object, e As EventArgs) Handles tsmenuNapov.Click
        MsgBox("Toto je nápověda k tomuto programu.",, "Nápověda")
    End Sub

    Private Sub tsmenuKonec_Click(sender As Object, e As EventArgs) Handles tsmenuKonec.Click
        Me.Close()
    End Sub

    'Ovoce
    '------------------------------------------------------------------------------------------------------------
    Private Sub cboxOvoce_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboxOvoce.SelectedValueChanged
        Ovoce()
    End Sub

    Private Sub cboxOvoce_TextChanged(sender As Object, e As EventArgs) Handles cboxOvoce.TextChanged
        Ovoce()
    End Sub

    Private Sub trbarOvoce_ValueChanged(sender As Object, e As EventArgs) Handles trbarOvoce.ValueChanged
        Ovoce()
    End Sub

    Sub Ovoce()
        Me.lbOvoce.Text = ""
        Me.lbOvoce.Text = Me.cboxOvoce.Text + " " + Me.trbarOvoce.Value.ToString + "kg"

    End Sub

    'Součin a numeric up down
    '------------------------------------------------------------------------------------------------------------------------
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Soucin()
    End Sub
    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        Soucin()
    End Sub

    Sub Soucin()
        Dim A As Integer
        Dim B As Integer
        Dim S As Integer

        A = CInt(NumericUpDown1.Value)
        B = CInt(NumericUpDown2.Value)

        S = A * B

        lbSoucin.Text = "Součin je: " + S.ToString

    End Sub

    'Radio Buttons
    '------------------------------------------------------------------------------------------------------------------
    Private Sub rbtnVariantaA_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnVariantaA.CheckedChanged
        radButton()
    End Sub
    Private Sub rbtnVariantaB_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnVariantaB.CheckedChanged
        radButton()
    End Sub
    Private Sub rbtnVariantaC_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnVariantaC.CheckedChanged
        radButton()
    End Sub

    Sub radButton()
        Dim Jakost As String
        Jakost = ""
        If rbtnVariantaA.Checked Then
            Jakost = ", jakost A"
        ElseIf rbtnVariantaB.Checked Then
            Jakost = ", jakost B"
        ElseIf rbtnVariantaC.Checked Then
            Jakost = ", jakost C"
        Else
            Jakost = ""
        End If
        lbJakost.Text = Jakost

    End Sub
    Private Sub lbOvoce_SizeChanged(sender As Object, e As EventArgs) Handles lbOvoce.SizeChanged
        lbJakost.Left = lbOvoce.Right + 2
        lbJakost.Top = lbJakost.Top
    End Sub

    'CheckBox count
    '......................................................................................................
    Sub PocetCheck()
        Dim Pocet As Integer

        If CheckBox1.Checked Then Pocet += 1
        If CheckBox2.Checked Then Pocet += 1
        If CheckBox3.Checked Then Pocet += 1
        If CheckBox4.Checked Then Pocet += 1
        If CheckBox5.Checked Then Pocet += 1
        If CheckBox6.Checked Then Pocet += 1
        If CheckBox7.Checked Then Pocet += 1

        statlCheck.Text = "Počet zatrhnutých CheckBoxů: " + Pocet.ToString

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        PocetCheck()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        PocetCheck()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        PocetCheck()
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        PocetCheck()
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        PocetCheck()
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        PocetCheck()
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        PocetCheck()
    End Sub


    'Import textu do text boxu
    '----------------------------------------------------------------------------------------------------------
    Private Sub tsmenuOtevrit_Click(sender As Object, e As EventArgs) Handles tsmenuOtevrit.Click
        With OpenFileDialog1
            .Title = "Zvolte soubor"
            .Filter = "Texty (*.txt)|*.txt|Dokumenty (*.doc;*docx)|*.doc;*docx|Všechny soubory (*.*)|*.*"
            .FilterIndex = 2
            .ShowDialog()
        End With
        Dim result As Windows.Forms.DialogResult = OpenFileDialog1.ShowDialog()
        If result.Equals(DialogResult.OK) Then
            FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
            Input(1, TextBox1.Text)
            FileClose(1)
        End If

    End Sub

    Private Sub tsmenuUlozit_Click(sender As Object, e As EventArgs) Handles tsmenuUlozit.Click
        SaveFileDialog1.ShowDialog()
        FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
        Write(1, TextBox1.Text)
        FileClose(1)
    End Sub
End Class