<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewYearsEveApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCelebrateNYE = New System.Windows.Forms.Label()
        Me.lblNumOfTickets = New System.Windows.Forms.Label()
        Me.grpTicketType = New System.Windows.Forms.GroupBox()
        Me.radMilitaryIDFullDinner = New System.Windows.Forms.RadioButton()
        Me.radAppetizersOnlyCelebration = New System.Windows.Forms.RadioButton()
        Me.radFullDinnerCelebration = New System.Windows.Forms.RadioButton()
        Me.lblFinalTicketCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtEnterNumberOfTickets = New System.Windows.Forms.TextBox()
        Me.picCelebration = New System.Windows.Forms.PictureBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.grpTicketType.SuspendLayout()
        CType(Me.picCelebration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCelebrateNYE
        '
        Me.lblCelebrateNYE.AutoSize = True
        Me.lblCelebrateNYE.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelebrateNYE.Location = New System.Drawing.Point(316, 35)
        Me.lblCelebrateNYE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelebrateNYE.Name = "lblCelebrateNYE"
        Me.lblCelebrateNYE.Size = New System.Drawing.Size(262, 25)
        Me.lblCelebrateNYE.TabIndex = 0
        Me.lblCelebrateNYE.Text = "Celebrate New Year's Eve"
        '
        'lblNumOfTickets
        '
        Me.lblNumOfTickets.AutoSize = True
        Me.lblNumOfTickets.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfTickets.Location = New System.Drawing.Point(342, 72)
        Me.lblNumOfTickets.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumOfTickets.Name = "lblNumOfTickets"
        Me.lblNumOfTickets.Size = New System.Drawing.Size(158, 21)
        Me.lblNumOfTickets.TabIndex = 1
        Me.lblNumOfTickets.Text = "Number of Tickets:"
        '
        'grpTicketType
        '
        Me.grpTicketType.BackColor = System.Drawing.Color.White
        Me.grpTicketType.Controls.Add(Me.radMilitaryIDFullDinner)
        Me.grpTicketType.Controls.Add(Me.radAppetizersOnlyCelebration)
        Me.grpTicketType.Controls.Add(Me.radFullDinnerCelebration)
        Me.grpTicketType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTicketType.Location = New System.Drawing.Point(329, 113)
        Me.grpTicketType.Margin = New System.Windows.Forms.Padding(4)
        Me.grpTicketType.Name = "grpTicketType"
        Me.grpTicketType.Padding = New System.Windows.Forms.Padding(4)
        Me.grpTicketType.Size = New System.Drawing.Size(236, 115)
        Me.grpTicketType.TabIndex = 2
        Me.grpTicketType.TabStop = False
        Me.grpTicketType.Text = "Ticket Type:  Select One"
        '
        'radMilitaryIDFullDinner
        '
        Me.radMilitaryIDFullDinner.AutoSize = True
        Me.radMilitaryIDFullDinner.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMilitaryIDFullDinner.Location = New System.Drawing.Point(23, 83)
        Me.radMilitaryIDFullDinner.Margin = New System.Windows.Forms.Padding(4)
        Me.radMilitaryIDFullDinner.Name = "radMilitaryIDFullDinner"
        Me.radMilitaryIDFullDinner.Size = New System.Drawing.Size(163, 23)
        Me.radMilitaryIDFullDinner.TabIndex = 2
        Me.radMilitaryIDFullDinner.TabStop = True
        Me.radMilitaryIDFullDinner.Text = "Military ID Full Dinner"
        Me.radMilitaryIDFullDinner.UseVisualStyleBackColor = True
        '
        'radAppetizersOnlyCelebration
        '
        Me.radAppetizersOnlyCelebration.AutoSize = True
        Me.radAppetizersOnlyCelebration.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAppetizersOnlyCelebration.Location = New System.Drawing.Point(23, 54)
        Me.radAppetizersOnlyCelebration.Margin = New System.Windows.Forms.Padding(4)
        Me.radAppetizersOnlyCelebration.Name = "radAppetizersOnlyCelebration"
        Me.radAppetizersOnlyCelebration.Size = New System.Drawing.Size(199, 23)
        Me.radAppetizersOnlyCelebration.TabIndex = 1
        Me.radAppetizersOnlyCelebration.TabStop = True
        Me.radAppetizersOnlyCelebration.Text = "Appetizers Only Celebration"
        Me.radAppetizersOnlyCelebration.UseVisualStyleBackColor = True
        '
        'radFullDinnerCelebration
        '
        Me.radFullDinnerCelebration.AutoSize = True
        Me.radFullDinnerCelebration.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFullDinnerCelebration.Location = New System.Drawing.Point(23, 25)
        Me.radFullDinnerCelebration.Margin = New System.Windows.Forms.Padding(4)
        Me.radFullDinnerCelebration.Name = "radFullDinnerCelebration"
        Me.radFullDinnerCelebration.Size = New System.Drawing.Size(167, 23)
        Me.radFullDinnerCelebration.TabIndex = 0
        Me.radFullDinnerCelebration.TabStop = True
        Me.radFullDinnerCelebration.Text = "Full Dinner Celebration"
        Me.radFullDinnerCelebration.UseVisualStyleBackColor = True
        '
        'lblFinalTicketCost
        '
        Me.lblFinalTicketCost.AutoSize = True
        Me.lblFinalTicketCost.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalTicketCost.Location = New System.Drawing.Point(326, 247)
        Me.lblFinalTicketCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFinalTicketCost.Name = "lblFinalTicketCost"
        Me.lblFinalTicketCost.Size = New System.Drawing.Size(149, 21)
        Me.lblFinalTicketCost.TabIndex = 3
        Me.lblFinalTicketCost.Text = "Final Ticket Cost:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Enabled = False
        Me.btnCalculate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(329, 287)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 28)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(465, 287)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtEnterNumberOfTickets
        '
        Me.txtEnterNumberOfTickets.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterNumberOfTickets.Location = New System.Drawing.Point(508, 69)
        Me.txtEnterNumberOfTickets.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEnterNumberOfTickets.Name = "txtEnterNumberOfTickets"
        Me.txtEnterNumberOfTickets.Size = New System.Drawing.Size(47, 28)
        Me.txtEnterNumberOfTickets.TabIndex = 6
        Me.txtEnterNumberOfTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picCelebration
        '
        Me.picCelebration.Image = Global.NewYearsEveApplication.My.Resources.Resources.NYE
        Me.picCelebration.Location = New System.Drawing.Point(8, 36)
        Me.picCelebration.Margin = New System.Windows.Forms.Padding(4)
        Me.picCelebration.Name = "picCelebration"
        Me.picCelebration.Size = New System.Drawing.Size(300, 279)
        Me.picCelebration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCelebration.TabIndex = 7
        Me.picCelebration.TabStop = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(477, 247)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 21)
        Me.lblTotalCost.TabIndex = 8
        '
        'frmNewYearsEveApp
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(584, 356)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.picCelebration)
        Me.Controls.Add(Me.txtEnterNumberOfTickets)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblFinalTicketCost)
        Me.Controls.Add(Me.grpTicketType)
        Me.Controls.Add(Me.lblNumOfTickets)
        Me.Controls.Add(Me.lblCelebrateNYE)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNewYearsEveApp"
        Me.Text = "Join Us for an Exclusive New Year's Eve Celebration"
        Me.grpTicketType.ResumeLayout(False)
        Me.grpTicketType.PerformLayout()
        CType(Me.picCelebration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCelebrateNYE As System.Windows.Forms.Label
    Friend WithEvents lblNumOfTickets As System.Windows.Forms.Label
    Friend WithEvents grpTicketType As System.Windows.Forms.GroupBox
    Friend WithEvents radMilitaryIDFullDinner As System.Windows.Forms.RadioButton
    Friend WithEvents radAppetizersOnlyCelebration As System.Windows.Forms.RadioButton
    Friend WithEvents radFullDinnerCelebration As System.Windows.Forms.RadioButton
    Friend WithEvents lblFinalTicketCost As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtEnterNumberOfTickets As System.Windows.Forms.TextBox
    Friend WithEvents picCelebration As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label

End Class
