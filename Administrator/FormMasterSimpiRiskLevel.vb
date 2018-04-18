Imports C1.Win.C1TrueDBGrid
Imports simpi.SimpiMaster
Imports simpi.globalutilities

Public Class FormMasterSimpiRiskLevel
    Public CallerForm As FormMasterSimpi
    Public objSimpiRisk As SimpiRiskLevel
    Public TypeID As Integer
    Dim QuestionNo As Integer = 0

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        QuestionSave()
    End Sub

    Private Sub QuestionSave()
        If IsNumeric(txtQuestionNo.Text) And txtQuestionText.Text.Trim <> "" Then
            objSimpiRisk.Question_Add(TypeID, txtQuestionNo.Text, txtQuestionText.Text)
            If objSimpiRisk.ErrID = 0 Then
                QuestionOld()
                CallerForm.RiskQuestionSearch()
            Else
                ExceptionMessage.Show(objSimpiRisk.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Public Sub QuestionNew()
        DBGAnswer.FetchRowStyles = True
        btnSave.Enabled = True
    End Sub

    Public Sub QuestionOld()
        DBGAnswer.FetchRowStyles = True
        btnSave.Enabled = False
        QuestionNo = txtQuestionNo.Text
        txtQuestionNo.ReadOnly = True
        txtQuestionText.ReadOnly = True
        btnAddAnswer.Enabled = True
        AnswerSearch()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnAddAnswer_Click(sender As Object, e As EventArgs) Handles btnAddAnswer.Click
        AnswerAdd()
    End Sub

    Private Sub AnswerAdd()
        If IsNumeric(txtAnswerNo.Text) And IsNumeric(txtMaximumValue.Text) And txtAnswerText.Text.Trim <> "" Then
            objSimpiRisk.Answer_Add(TypeID, QuestionNo, txtAnswerNo.Text, txtAnswerText.Text, txtMaximumValue.Text)
            If objSimpiRisk.ErrID = 0 Then
                AnswerSearch()
            Else
                ExceptionMessage.Show(objSimpiRisk.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub AnswerSearch()
        Dim tbl As New DataTable
        tbl = objSimpiRisk.Answer_Search(TypeID, QuestionNo)
        If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
            Dim query = From c In tbl.AsEnumerable
                        Order By c.Field(Of Integer)("OptionNo") Ascending
                        Select
                                No = c.Field(Of Integer)("OptionNo"),
                                Answer = c.Field(Of String)("OptionText"),
                                Value = c.Field(Of Integer)("OptionValue")

            With DBGAnswer
                .AllowAddNew = False
                .AllowDelete = False
                .AllowUpdate = False
                .Columns.Clear()
                .DataSource = query.ToList

                For Each column As C1DisplayColumn In DBGAnswer.Splits(0).DisplayColumns
                    column.AutoSize()
                Next

            End With
            AnswerClear()
        Else
            DBGAnswer.Columns.Clear()
        End If
    End Sub

    Private Sub DBGAnswer_FetchRowStyle(sender As Object, e As FetchRowStyleEventArgs) Handles DBGAnswer.FetchRowStyle
        If e.Row Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.LemonChiffon
        End If
    End Sub

    Private Sub AnswerClear()
        txtAnswerNo.Text = ""
        txtAnswerText.Text = ""
        txtMaximumValue.Text = ""
        btnRemoveAnswer.Enabled = False
    End Sub

    Private Sub DBGAnswer_Click(sender As Object, e As EventArgs) Handles DBGAnswer.Click
        With DBGAnswer
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
            End If
        End With
    End Sub

    Private Sub DBGAnswer_DoubleClick(sender As Object, e As EventArgs) Handles DBGAnswer.DoubleClick
        AnswerSelect()
    End Sub

    Private Sub AnswerSelect()
        With DBGAnswer
            If .RowCount > 0 Then
                .MarqueeStyle = MarqueeEnum.HighlightRow
                txtAnswerNo.Text = .Columns("No").Text
                txtAnswerText.Text = .Columns("Answer").Text
                txtMaximumValue.Text = .Columns("Value").Text
                btnRemoveAnswer.Enabled = True
            End If
        End With
    End Sub

    Private Sub btnRemoveAnswer_Click(sender As Object, e As EventArgs) Handles btnRemoveAnswer.Click
        AnswerRemove()
    End Sub

    Private Sub AnswerRemove()
        If IsNumeric(txtAnswerNo.Text) Then
            objSimpiRisk.Answer_Remove(TypeID, QuestionNo, txtAnswerNo.Text)
            If objSimpiRisk.ErrID = 0 Then
                AnswerSearch()
            Else
                ExceptionMessage.Show(objSimpiRisk.ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class