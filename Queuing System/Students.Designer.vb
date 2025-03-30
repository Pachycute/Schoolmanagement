<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Students
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Students))
        Button1 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        Button3 = New Button()
        Button5 = New Button()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        txtsearch = New TextBox()
        Button4 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(771, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(26, 23)
        Button1.TabIndex = 10
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(739, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(26, 23)
        Button2.TabIndex = 9
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 26)
        Panel1.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(35, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 23)
        Label1.TabIndex = 11
        Label1.Text = "STUDENTS"
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Location = New Point(3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(26, 23)
        Button3.TabIndex = 8
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Image = My.Resources.Resources.reload__1___1_
        Button5.ImageAlign = ContentAlignment.MiddleRight
        Button5.Location = New Point(12, 409)
        Button5.Name = "Button5"
        Button5.Size = New Size(39, 41)
        Button5.TabIndex = 21
        Button5.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(174, 61)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(22, 23)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.e798d80f_9969_4fa2_8f0f_f1651e1d0393_removalai_preview
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(12, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(127, 112)
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 150)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(776, 253)
        DataGridView1.TabIndex = 15
        ' 
        ' txtsearch
        ' 
        txtsearch.Location = New Point(174, 61)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(548, 23)
        txtsearch.TabIndex = 19
        txtsearch.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button4
        ' 
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Image = My.Resources.Resources.trash_can__2_
        Button4.ImageAlign = ContentAlignment.MiddleRight
        Button4.Location = New Point(70, 409)
        Button4.Name = "Button4"
        Button4.Size = New Size(39, 41)
        Button4.TabIndex = 22
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Students
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Panel1)
        Controls.Add(Button5)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(DataGridView1)
        Controls.Add(txtsearch)
        FormBorderStyle = FormBorderStyle.None
        Name = "Students"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Students"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
End Class
