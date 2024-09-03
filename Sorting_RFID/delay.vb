Module delay
    Sub delayy(ByVal dblsec As Double)
        Const onesec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblwaitil As Date
        Now.AddSeconds(onesec)
        dblwaitil = Now.AddSeconds(onesec).AddSeconds(dblsec)
        Do Until Now > dblwaitil
            Application.DoEvents()
        Loop
    End Sub
End Module
