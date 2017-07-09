Public Class frmNewYearsEveApp

    Private Sub frmNewYearsEveApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFinalTicketCost.Text = ""
        lblTotalCost.Text = ""
        txtEnterNumberOfTickets.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEnterNumberOfTickets.Text = ""
        radFullDinnerCelebration.Checked = True
        radAppetizersOnlyCelebration.Checked = False
        radMilitaryIDFullDinner.Checked = False
        lblFinalTicketCost.Text = ""
        lblTotalCost.Text = ""
        txtEnterNumberOfTickets.Text = ""
        btnCalculate.Enabled = False
    End Sub

    Private Sub grpTicketType_Enter(sender As Object, e As EventArgs) Handles grpTicketType.Enter
        radFullDinnerCelebration.Checked = True
        radAppetizersOnlyCelebration.Checked = False
        radMilitaryIDFullDinner.Checked = False
    End Sub

    Private Sub txtEnterNumberOfTickets_TextChanged(sender As Object, e As EventArgs) Handles txtEnterNumberOfTickets.TextChanged
        txtEnterNumberOfTickets.Focus()
        btnCalculate.Enabled = True
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAmount As Decimal
        Dim decTotalCostPerDinner As Decimal
        Dim decTotalCost As Decimal
        Dim decFullDinnerCost As Decimal = 125D
        Dim decAppetizersOnly As Decimal = 75D
        Dim decMilitaryID As Decimal = 125D

        If IsNumeric(txtEnterNumberOfTickets.Text) Then
            decAmount = Convert.ToDecimal(txtEnterNumberOfTickets.Text)

        If decAmount > 0 Then
            If radFullDinnerCelebration.Checked Then
                decTotalCostPerDinner = decFullDinnerCost
            ElseIf radAppetizersOnlyCelebration.Checked Then
                decTotalCostPerDinner = decAppetizersOnly
            ElseIf radMilitaryIDFullDinner.Checked Then
                decTotalCostPerDinner = decMilitaryID - (0.45 * decFullDinnerCost)
                End If

                decTotalCost = decAmount * decTotalCostPerDinner
                lblFinalTicketCost.Text = "Final Ticket Cost:"
                lblTotalCost.Text = decTotalCost.ToString("C")
            Else
                MsgBox("You need to enter a numeric value of 1 or higher.", 32, "Entry Error")
                txtEnterNumberOfTickets.Text = ""
                txtEnterNumberOfTickets.Focus()
                radFullDinnerCelebration.Checked = True
                radAppetizersOnlyCelebration.Checked = False
                radMilitaryIDFullDinner.Checked = False
            End If
        Else
            MsgBox("You need to enter a numeric value of 1 or higher.", 32, "Entry Error")
            txtEnterNumberOfTickets.Text = ""
            txtEnterNumberOfTickets.Focus()
            radFullDinnerCelebration.Checked = True
            radAppetizersOnlyCelebration.Checked = False
            radMilitaryIDFullDinner.Checked = False
        End If
        
    End Sub
End Class
