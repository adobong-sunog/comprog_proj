Public Class Move
    Private name As String
    Private attOrSpAtt As Boolean
    'for above, 0 is attack, 1 is special attack
    Private maxNoOfUses As Integer
    Private power As Integer

    Public Sub New(ByVal namer As String,
                   ByVal attOrSpAtter As Boolean,
                   ByVal maxNoOfUseser As Integer,
                   ByVal powerer As Integer)
        name = namer
        attOrSpAtt = attOrSpAtter
        maxNoOfUses = maxNoOfUseser
        power = powerer
    End Sub

    Public Function getPower() As Integer
        Return power
    End Function
    Public Function getMaxNoOfUses() As Integer
        Return maxNoOfUses
    End Function
    Public Function getAttOrSpAtt() As Boolean
        Return attOrSpAtt
    End Function
    Public Function getName() As String
        Return name
    End Function

    Public Sub setPower(ByRef powerer As Integer)
        power = powerer
    End Sub
    Public Sub setMaxNoOfUses(ByRef maxNoOfUseser As Integer)
        maxNoOfUses = maxNoOfUseser
    End Sub
    Public Sub setAttOrSpAtt(ByRef attOrSpAtter As Boolean)
        attOrSpAtt = attOrSpAtter
    End Sub
    Public Sub setName(ByRef namer As Integer)
        name = namer
    End Sub
End Class
