<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signup_form))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label2 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        txtpassword = New TextBox()
        Button1 = New Button()
        Button5 = New Button()
        Label5 = New Label()
        txtusername = New TextBox()
        PictureBox3 = New PictureBox()
        PictureBox5 = New PictureBox()
        Button4 = New Button()
        Buttonhide = New Button()
        Buttonshow = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.e798d80f_9969_4fa2_8f0f_f1651e1d0393_removalai_preview
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(0, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(61, 60)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(60, 29)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(328, 60)
        Panel1.TabIndex = 13
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(54, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(231, 30)
        Label2.TabIndex = 10
        Label2.Text = "SIGN UP AS STUDENT"
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = My.Resources.Resources.window_minimize
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(316, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(29, 25)
        Button2.TabIndex = 12
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = My.Resources.Resources.button
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Location = New Point(354, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(34, 25)
        Button3.TabIndex = 11
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.maxresdefault
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Location = New Point(0, 92)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(388, 455)
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Firebrick
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 23)
        Label1.TabIndex = 16
        Label1.Text = "NAME:"
        ' 
        ' txtpassword
        ' 
        txtpassword.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        txtpassword.Location = New Point(12, 225)
        txtpassword.Multiline = True
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = "•"c
        txtpassword.Size = New Size(333, 37)
        txtpassword.TabIndex = 19
        txtpassword.TextAlign = HorizontalAlignment.Center
        txtpassword.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(12, 293)
        Button1.Name = "Button1"
        Button1.Size = New Size(214, 51)
        Button1.TabIndex = 21
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), Image)
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.Location = New Point(11, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(29, 25)
        Button5.TabIndex = 22
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Firebrick
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 199)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 23)
        Label5.TabIndex = 24
        Label5.Text = "PASSWORD:"
        ' 
        ' txtusername
        ' 
        txtusername.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        txtusername.Location = New Point(12, 148)
        txtusername.Multiline = True
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(333, 37)
        txtusername.TabIndex = 23
        txtusername.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.user
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.Location = New Point(11, 148)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(37, 37)
        PictureBox3.TabIndex = 25
        PictureBox3.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = My.Resources.Resources.lock
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.BorderStyle = BorderStyle.FixedSingle
        PictureBox5.Location = New Point(11, 225)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(37, 37)
        PictureBox5.TabIndex = 27
        PictureBox5.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(12, 372)
        Button4.Name = "Button4"
        Button4.Size = New Size(214, 51)
        Button4.TabIndex = 28
        Button4.Text = "SIGN UP "
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Buttonhide
        ' 
        Buttonhide.BackgroundImage = My.Resources.Resources.eye
        Buttonhide.BackgroundImageLayout = ImageLayout.Stretch
        Buttonhide.Location = New Point(305, 230)
        Buttonhide.Name = "Buttonhide"
        Buttonhide.Size = New Size(31, 28)
        Buttonhide.TabIndex = 29
        Buttonhide.UseVisualStyleBackColor = True
        ' 
        ' Buttonshow
        ' 
        Buttonshow.BackgroundImage = My.Resources.Resources.hidden
        Buttonshow.BackgroundImageLayout = ImageLayout.Stretch
        Buttonshow.Location = New Point(305, 230)
        Buttonshow.Name = "Buttonshow"
        Buttonshow.Size = New Size(31, 28)
        Buttonshow.TabIndex = 30
        Buttonshow.UseVisualStyleBackColor = True
        ' 
        ' Signup_form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(388, 530)
        ControlBox = False
        Controls.Add(Buttonshow)
        Controls.Add(Buttonhide)
        Controls.Add(Button4)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox3)
        Controls.Add(Label5)
        Controls.Add(txtusername)
        Controls.Add(Button5)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(txtpassword)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Signup_form"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button4 As Button
    Public WithEvents txtusername As TextBox
    Public WithEvents Button1 As Button
    Friend WithEvents Buttonhide As Button
    Friend WithEvents Buttonshow As Button
End Class
