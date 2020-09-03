



Module mdMain

    Sub Main()

        'v první řadě je třeba předložit uživateli formulář
        'instance objektové třídy frMain (formuláře)

        Dim frA As frMain

        'zde mohou být další věci, které se formulářů netýkají

        frA = New frMain

        'formulář má přidělené místo, ale uživatel ho stále ještě nevidí
        'nyní lze měnit vlastnosti formuláře:
        frA.Text = "Spočti plochu"
        'změní text v nadpise okna

        'modální formulář, předloží se uživateli:
        frA.ShowDialog()

        'msgbox je modální formulář:
        'MsgBox("Ok")



    End Sub

End Module
