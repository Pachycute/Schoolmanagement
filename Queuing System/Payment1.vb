Public Class Payment1
    Private Sub cmbReason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReason.SelectedIndexChanged
        If cmbReason.Text = "TUITION" Then
            txtAmount.Text = "17,500"
        ElseIf cmbReason.Text = "EDUCATIONAL TOUR - ICT" Then
            txtAmount.Text = "2,200"
        ElseIf cmbReason.Text = "EDUCATIONAL TOUR - ABM" Then
            txtAmount.Text = "2,200"
        ElseIf cmbReason.Text = "EDUCATIONAL TOUR - HE" Then
            txtAmount.Text = "3,100"
        ElseIf cmbReason.Text = "EDUCATIONAL TOUR - HUMSS" Then
            txtAmount.Text = "3,100"
        ElseIf cmbReason.Text = "INTRAMS" Then
            txtAmount.Text = "200"
        ElseIf cmbReason.Text = "GALA NIGHT" Then
            txtAmount.Text = "1,500"
        ElseIf cmbReason.Text = "ACQUIANTANCE PARTY" Then
            txtAmount.Text = "1,200"
        ElseIf cmbReason.Text = "ID PAYMENT" Then
            txtAmount.Text = "100"
        ElseIf cmbReason.Text = "UNIFORM" Then
            txtAmount.Text = "1,000"
        ElseIf cmbReason.Text = "EXAM PERMIT" Then
            txtAmount.Text = "100"
        End If

    End Sub







    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Home_Page_Students.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.ExitThread()
    End Sub

    Private Sub cmbMethods_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMethods.SelectedIndexChanged

    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Check if TextBoxes and ComboBoxes have values
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse String.IsNullOrWhiteSpace(cmbMethods.Text) OrElse String.IsNullOrWhiteSpace(cmbReason.Text) OrElse String.IsNullOrWhiteSpace(txtAmount.Text) Then
            MessageBox.Show("Please fill in all fields (Name, Amount, Method, and Reason).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Create and open TICKET form and pass values (including Name)
        Dim ticketForm As New TICKET(txtName.Text, txtAmount.Text, cmbMethods.Text, cmbReason.Text)

        Me.Hide()
        ticketForm.Show()
    End Sub
End Class