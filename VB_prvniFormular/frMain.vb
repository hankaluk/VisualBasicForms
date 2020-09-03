Option Strict On

Public Class frMain

    Private Sub btnSpocti_Click(sender As Object, e As EventArgs) Handles btnSpocti.Click
        Spocti()
    End Sub

    Sub Spocti()
        Dim A As Integer
        Dim B As Integer
        Dim P As Integer

        'Val zabrání načtení textu, udělá z něj nulu nebo vezme čísla v řetězci, CInt přetypování double na integer
        'Val vrací double
        A = CInt(Val(Me.txtA.Text))
        B = CInt(Val(Me.txtB.Text))

        P = A * CInt(IIf(cbCtverec.Checked, A, B))
        'výsledek je typu object, proto strict on hlásí chybu

        Me.txtP.Text = P.ToString


    End Sub

    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        Me.txtA.Text = ""
        Me.txtB.Text = ""
        Me.txtP.Text = ""
        cbCtverec.Checked = False
    End Sub

    Private Sub txtA_TextChanged(sender As Object, e As EventArgs) Handles txtA.TextChanged
        Spocti()
    End Sub

    Private Sub txtB_TextChanged(sender As Object, e As EventArgs) Handles txtB.TextChanged
        Spocti()
    End Sub

    Private Sub txtA_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtA.KeyPress
        'vznikne, když uživatel stiskne skoro každou klávesu
        'sender = instance, která to vyvolala
        'parametr KeyPressEventArgs = objektová třída
        Dim Znak As String
        Znak = e.KeyChar
        e.Handled = Znak < "0" Or Znak > "9"
    End Sub

    Private Sub txtB_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtB.KeyPress
        Dim Znak As String
        Znak = e.KeyChar
        e.Handled = Znak < "0" Or Znak > "9"
    End Sub

    Private Sub txtP_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtP.KeyPress
        Dim Znak As String
        Znak = e.KeyChar
        e.Handled = True
    End Sub

    Private Sub sbA_Scroll(sender As Object, e As Windows.Forms.ScrollEventArgs) Handles sbA.Scroll

        Me.txtA.Text = Me.sbA.Value.ToString

    End Sub

    Private Sub cbCtverec_CheckedChanged(sender As Object, e As EventArgs) Handles cbCtverec.CheckedChanged
        If cbCtverec.Checked Then
            Me.txtB.Visible = False
            Me.lbB.Visible = False
            Me.mm2.Visible = False
            Spocti()
        Else
            Me.txtB.Visible = True
            Me.lbB.Visible = True
            Me.mm2.Visible = True
            Spocti()
        End If

    End Sub

    Private Sub btnKonec_Click(sender As Object, e As EventArgs) Handles btnKonec.Click
        Me.Close()
        'pokud nechci předávat informaci o tom, jak byl formulář zavřen
    End Sub
End Class