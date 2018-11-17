Public Class FrmControlPanel



    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        pnlSubject.Visible = False
        pnlStudent.Visible = False
        pnlClass.Visible = False
        pnlLessons.Visible = False
        pnlQuery.Visible = False
        pnlQuestions.Visible = False
        pnlHome.Visible = True
        pnlYear.Visible = False
        pnlUser.Visible = False

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        pnlSubject.Visible = False
        pnlStudent.Visible = True
        pnlClass.Visible = False
        pnlLessons.Visible = False
        pnlQuery.Visible = False
        pnlQuestions.Visible = False
        pnlHome.Visible = False
        pnlYear.Visible = False
        pnlUser.Visible = False
        getControl(StudentUC.Inestant)
    End Sub

    Private Sub btnSubject_Click(sender As Object, e As EventArgs) Handles btnSubject.Click
        pnlSubject.Visible = True
        pnlStudent.Visible = False
        pnlClass.Visible = False
        pnlLessons.Visible = False
        pnlQuery.Visible = False
        pnlQuestions.Visible = False
        pnlHome.Visible = False
        pnlYear.Visible = False
        pnlUser.Visible = False
    End Sub

    Private Sub btnLessons_Click(sender As Object, e As EventArgs) Handles btnLessons.Click
        pnlSubject.Visible = False
        pnlStudent.Visible = False
        pnlClass.Visible = False
        pnlLessons.Visible = True
        pnlQuery.Visible = False
        pnlQuestions.Visible = False
        pnlHome.Visible = False
        pnlYear.Visible = False
        pnlUser.Visible = False
    End Sub

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        pnlSubject.Visible = False
        pnlStudent.Visible = False
        pnlClass.Visible = True
        pnlLessons.Visible = False
        pnlQuery.Visible = False
        pnlQuestions.Visible = False
        pnlHome.Visible = False
        pnlYear.Visible = False
        pnlUser.Visible = False
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        pnlSubject.Visible = False
        pnlStudent.Visible = False
        pnlClass.Visible = False
        pnlLessons.Visible = False
        pnlQuery.Visible = False
        pnlQuestions.Visible = False
        pnlHome.Visible = False
        pnlYear.Visible = False
        pnlUser.Visible = True
    End Sub

    Private Sub btnQuestions_Click(sender As Object, e As EventArgs) Handles btnQuestions.Click
        pnlSubject.Visible = False
        pnlStudent.Visible = False
        pnlClass.Visible = False
        pnlLessons.Visible = False
        pnlQuery.Visible = False
        pnlQuestions.Visible = True
        pnlHome.Visible = False
        pnlYear.Visible = False
        pnlUser.Visible = False
    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        pnlSubject.Visible = False
        pnlStudent.Visible = False
        pnlClass.Visible = False
        pnlLessons.Visible = False
        pnlQuery.Visible = True
        pnlQuestions.Visible = False
        pnlHome.Visible = False
        pnlYear.Visible = False
        pnlUser.Visible = False
    End Sub

    Private Sub btnYears_Click(sender As Object, e As EventArgs) Handles btnYears.Click
        pnlSubject.Visible = False
        pnlStudent.Visible = False
        pnlClass.Visible = False
        pnlLessons.Visible = False
        pnlQuery.Visible = False
        pnlQuestions.Visible = False
        pnlHome.Visible = False
        pnlYear.Visible = True
        pnlUser.Visible = False
    End Sub

    Private Sub FrmControlPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        getControl(MainUC.Inestant)
    End Sub
    Private Sub getControl(instans As UserControl)
        If PnlContent.Controls.Count = 0 Then
            PnlContent.Controls.Add(instans)
            instans.Dock = DockStyle.Fill
            instans.Show()
            Exit Sub
        End If
        For Each item As UserControl In PnlContent.Controls
            If item Is instans.GetType Then
                Dim t = CType(item, UserControl)
                t.Hide()
            End If
            If Not pnlClass.Controls.Contains(instans) Then
                PnlContent.Controls.Clear()
                PnlContent.Controls.Add(instans)
                instans.Dock = DockStyle.Fill
                instans.Show()
            Else
                instans.Show()
            End If

        Next
    End Sub



End Class