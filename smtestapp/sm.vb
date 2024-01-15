Imports System
Imports SMScriptBox
Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Net
Imports System.Text

<Serializable()> Public Class Script
	Sub New()
	End Sub
    Shared Sub Main()
        Try
            FlowContext.SetResult(1)
            Dim phoneNumber As String = FlowContext.GetSystemVariable("@@MediaLib.ANI")
            FlowContext.Print("#### Phonenumber: " + phoneNumber)
            phoneNumber = "+46" + phoneNumber.Substring(1)
            FlowContext.SetVariable("@IntPhoneNumber", phoneNumber)
            FlowContext.SetResult(2)

        Catch ex As Exception
            FlowContext.Print("### Error:" & ex.Message)
            FlowContext.SetResult(9)
        End Try
    End Sub


End Class
