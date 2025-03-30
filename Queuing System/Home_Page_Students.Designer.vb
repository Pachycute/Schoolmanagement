<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_Page_Students
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home_Page_Students))
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        Button1 = New Button()
        Panel1 = New Panel()
        Button5 = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.maxresdefault
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(0, 106)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(851, 449)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Maroon
        Label3.Location = New Point(721, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 3
        Label3.Text = "PAYMENT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Maroon
        Label2.Location = New Point(535, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 23)
        Label2.TabIndex = 2
        Label2.Text = "ENROLLMENT"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(80, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(387, 37)
        Label1.TabIndex = 1
        Label1.Text = "STUDENTS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.e798d80f_9969_4fa2_8f0f_f1651e1d0393_removalai_preview
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(0, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(77, 79)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = My.Resources.Resources.window_minimize
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(769, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(29, 25)
        Button2.TabIndex = 8
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources.button
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(807, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(34, 25)
        Button1.TabIndex = 7
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(0, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(851, 80)
        Panel1.TabIndex = 5
        ' 
        ' Button5
        ' 
        Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), Image)
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.Location = New Point(12, 0)
        Button5.Name = "Button5"
        Button5.Size = New Size(29, 25)
        Button5.TabIndex = 12
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Home_Page_Students
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(851, 554)
        ControlBox = False
        Controls.Add(Button5)
        Controls.Add(PictureBox2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Home_Page_Students"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
End Class
