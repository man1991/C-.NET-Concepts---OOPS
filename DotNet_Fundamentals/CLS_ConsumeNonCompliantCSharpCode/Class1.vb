Imports CLS_NonCompliantCSharpCode
Public Class MyVbClass
    Public Sub Check()
        Dim obj As New Class1()
        'Assembly violates CLS rule of case sensitive
        'It's not possible to access variable with same name but only change in cases
        'obj.inta;'possible
        'obj.intA;'not possible
        'obj.intx; 'possible

    End Sub
End Class
