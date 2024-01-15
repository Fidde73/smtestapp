
Public Class FlowContext
    Shared varibles As New Dictionary(Of String, String)
    Public Shared Sub Print(txt As String)
        Console.WriteLine(txt)
    End Sub
    Public Shared Sub SetResult(i As Integer)
        Console.WriteLine("result: " + i.ToString())
    End Sub

    Public Shared Function GetSystemVariable(varible As String) As String
        Try
            Return varibles(varible)
        Catch
            Console.WriteLine("The varible do not exist: " + varible)
            Return ""
        End Try
    End Function
    Public Shared Function GetVariable(varible As String) As String
        Try
            Return varibles(varible)
        Catch
            Console.WriteLine("The varible do not exist: " + varible)
            Return ""
        End Try
    End Function
    Public Shared Sub SetVariable(varible As String, value As String)
        Console.WriteLine("Varible set: " + varible + " to: " + value)
        If varibles.ContainsKey(varible) Then
            varibles(varible) = value
        Else
            varibles.Add(varible, value)
        End If
    End Sub
    Shared Sub AddDebugVaibles()
        With varibles
            .Add("@@MediaLib.ANI", "0708111222")
            .Add("@@MediaLib.CallID", "1234")
        End With
    End Sub
End Class


<Serializable()> Public Class Startup

    Shared Sub Main()
        FlowContext.AddDebugVaibles()
        Script.Main()
        Console.ReadLine()
    End Sub

End Class
