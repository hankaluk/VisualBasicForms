Module mdMainForm

    Sub Main()

        Dim formular As frMainForm
        formular = New frMainForm

        formular.Text = InputBox("Pojmenuj svůj formulář: ")
        If formular.Text = "" Then
            MsgBox("Chyba! Nezadali jste žádný text.")
        Else
            formular.ShowDialog()
        End If



    End Sub

End Module
