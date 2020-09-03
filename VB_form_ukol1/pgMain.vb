Option Strict On
Option Explicit On

Module mdMain
    Public cislo As Byte
    Sub Main()

        Dim frA As frMain
        frA = New frMain
        frA.Text = "Form A"

        'Počet vteřin na progress baru
        'Dim cislo As Byte
        cislo = CByte(Val(InputBox("Zadej počet vteřin, který poběží na progress bar.")))

        'Kontrola zadání
        If cislo > 0 Then
            frA.ShowDialog()
        Else
            MsgBox("Chyba! Špatně zadáno.")
        End If





    End Sub

End Module
