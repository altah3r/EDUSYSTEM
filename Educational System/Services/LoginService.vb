Imports Educational_System.DTOs

Namespace services
    Public Class LoginService

        Public Function loginUser(userName As String, password As String) As Boolean

            Using con = New ContextEDU
                Dim result = con.Users.SingleOrDefault(Function(f) f.UserName = userName AndAlso f.USERPassword = password)
                If result Is Nothing Then
                    Return False
                End If
                LoginDTO.InserPre = result.InserPre
                LoginDTO.DeletePre = result.DeletePre
                LoginDTO.ManegmentClass = result.ManegmentClass
                LoginDTO.ManegmentQuestions = result.ManegmentQuestions
                LoginDTO.manegmentStudent = result.manegmentStudent
                LoginDTO.ManegmentUsers = result.ManegmentUsers
                LoginDTO.ManegmentYears = result.ManegmentYears
                LoginDTO.MangmentSubject = result.MangmentSubject
                LoginDTO.UpdatePre = result.UpdatePre
                LoginDTO.USERAdminRight = result.USERAdminRight
                LoginDTO.USERID = result.USERID
                LoginDTO.userName = result.UserName

            End Using

            Return True

        End Function
    End Class
End Namespace

