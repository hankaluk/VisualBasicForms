

Module mdMain
    Public progressMax As Integer
    Sub Main()

        Dim formular As frMain
        formular = New frMain

        progressMax = CInt(Val(InputBox("Zadejte počet vteřin větší než 5: ")))

        If IsNumeric(progressMax) And progressMax > 5 Then
            formular.ShowDialog()
        Else
            MsgBox("Chyba! Zadali jste špatnou hodnotu.")
        End If



    End Sub

End Module
