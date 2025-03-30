<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAYMENT_STUDENT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PAYMENT_STUDENT))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        cmbReason = New ComboBox()
        Label2 = New Label()
        cmbMethods = New ComboBox()
        PictureBox2 = New PictureBox()
        txtAmount = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button4 = New Button()
        Label6 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.maxresdefault
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(0, 102)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 350)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Location = New Point(-22, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(822, 75)
        Label1.TabIndex = 1
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(774, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(26, 23)
        Button1.TabIndex = 2
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(742, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(26, 23)
        Button2.TabIndex = 3
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Location = New Point(0, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(26, 23)
        Button3.TabIndex = 4
        Button3.UseVisualStyleBackColor = True
        ' 
        ' cmbReason
        ' 
        cmbReason.FormattingEnabled = True
        cmbReason.Items.AddRange(New Object() {"TUITION", "EDUCATIONAL TOUR - ICT", "EDUCATIONAL TOUR - ABM", "EDUCATIONAL TOUR - HE", "EDUCATIONAL TOUR - HUMSS", "INTRAMS", "GALA NIGHT", "ACQUIANTANCE PARTY", "ID PAYMENT", "UNIFORM", "EXAM PERMIT"})
        cmbReason.Location = New Point(240, 49)
        cmbReason.Name = "cmbReason"
        cmbReason.Size = New Size(160, 23)
        cmbReason.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Maroon
        Label2.Location = New Point(63, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 50)
        Label2.TabIndex = 6
        Label2.Text = "PAYMENTS"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmbMethods
        ' 
        cmbMethods.FormattingEnabled = True
        cmbMethods.Items.AddRange(New Object() {"PAYMAYA", "GCASH", "CASH"})
        cmbMethods.Location = New Point(412, 49)
        cmbMethods.Name = "cmbMethods"
        cmbMethods.Size = New Size(160, 23)
        cmbMethods.TabIndex = 7
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(0, 42)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(57, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(608, 49)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(97, 23)
        txtAmount.TabIndex = 9
        txtAmount.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(265, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 15)
        Label3.TabIndex = 10
        Label3.Text = "Reason of Payment"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(430, 75)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 15)
        Label4.TabIndex = 11
        Label4.Text = "Methods of Payment"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(636, 75)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 15)
        Label5.TabIndex = 12
        Label5.Text = "Amount"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.White
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.Black
        Button4.Location = New Point(727, 49)
        Button4.Name = "Button4"
        Button4.Size = New Size(51, 47)
        Button4.TabIndex = 13
        Button4.Text = vbCrLf
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(359, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(32, 15)
        Label6.TabIndex = 14
        Label6.Text = "-----"
        ' 
        ' PAYMENT_STUDENT
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Button4)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtAmount)
        Controls.Add(cmbMethods)
        Controls.Add(cmbReason)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "PAYMENT_STUDENT"
        StartPosition = FormStartPosition.CenterParent
        Text = "d"
        WindowState = FormWindowState.Minimized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents cmbReason As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbMethods As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
End Class
