<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TICKET
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TICKET))
        Panel2 = New Panel()
        Labelname = New Label()
        Label8 = New Label()
        Labelreason = New Label()
        Labelmethod = New Label()
        labelamount = New Label()
        PictureBox2 = New PictureBox()
        Labeltime = New Label()
        Labeldate = New Label()
        Label7 = New Label()
        Label6 = New Label()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Timer1 = New Timer(components)
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.AntiqueWhite
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Labelname)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Labelreason)
        Panel2.Controls.Add(Labelmethod)
        Panel2.Controls.Add(labelamount)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(Labeltime)
        Panel2.Controls.Add(Labeldate)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(PictureBox6)
        Panel2.Controls.Add(PictureBox5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(-1, 34)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(565, 283)
        Panel2.TabIndex = 1
        ' 
        ' Labelname
        ' 
        Labelname.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelname.ForeColor = Color.Maroon
        Labelname.Location = New Point(85, 78)
        Labelname.Name = "Labelname"
        Labelname.Size = New Size(329, 31)
        Labelname.TabIndex = 20
        Labelname.Text = "-----"
        Labelname.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Maroon
        Label8.Location = New Point(3, 78)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 31)
        Label8.TabIndex = 19
        Label8.Text = "Name:"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Labelreason
        ' 
        Labelreason.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelreason.ForeColor = Color.Maroon
        Labelreason.Location = New Point(85, 171)
        Labelreason.Name = "Labelreason"
        Labelreason.Size = New Size(329, 31)
        Labelreason.TabIndex = 14
        Labelreason.Text = "-----"
        Labelreason.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Labelmethod
        ' 
        Labelmethod.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labelmethod.ForeColor = Color.Maroon
        Labelmethod.Location = New Point(85, 140)
        Labelmethod.Name = "Labelmethod"
        Labelmethod.Size = New Size(329, 31)
        Labelmethod.TabIndex = 13
        Labelmethod.Text = "-----"
        Labelmethod.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' labelamount
        ' 
        labelamount.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelamount.ForeColor = Color.Maroon
        labelamount.Location = New Point(85, 109)
        labelamount.Name = "labelamount"
        labelamount.Size = New Size(329, 31)
        labelamount.TabIndex = 12
        labelamount.Text = "-----"
        labelamount.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.printer__1_
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(199, 225)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 35)
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' Labeltime
        ' 
        Labeltime.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labeltime.ForeColor = Color.Maroon
        Labeltime.Location = New Point(68, 251)
        Labeltime.Name = "Labeltime"
        Labeltime.Size = New Size(94, 18)
        Labeltime.TabIndex = 16
        Labeltime.Text = "----"
        Labeltime.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Labeldate
        ' 
        Labeldate.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Labeldate.ForeColor = Color.Maroon
        Labeldate.Location = New Point(68, 233)
        Labeldate.Name = "Labeldate"
        Labeldate.Size = New Size(94, 18)
        Labeldate.TabIndex = 15
        Labeldate.Text = "----"
        Labeldate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Maroon
        Label7.Location = New Point(3, 171)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 31)
        Label7.TabIndex = 11
        Label7.Text = "Reason:"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Maroon
        Label6.Location = New Point(3, 109)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 31)
        Label6.TabIndex = 10
        Label6.Text = "Amount:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(377, 212)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(87, 64)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 8
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(470, 212)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(87, 64)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 7
        PictureBox5.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Maroon
        Label4.Location = New Point(3, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 31)
        Label4.TabIndex = 3
        Label4.Text = "Method:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Maroon
        Label3.Location = New Point(11, 251)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 2
        Label3.Text = "Time:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Maroon
        Label2.Location = New Point(11, 233)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 18)
        Label2.TabIndex = 1
        Label2.Text = "Date:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Trebuchet MS", 33.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Maroon
        Label1.Location = New Point(1, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(563, 51)
        Label1.TabIndex = 0
        Label1.Text = "PAYMENT TICKET"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(199, 222)
        Button1.Name = "Button1"
        Button1.Size = New Size(157, 38)
        Button1.TabIndex = 18
        Button1.Text = "PRINT AND SAVE"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.e798d80f_9969_4fa2_8f0f_f1651e1d0393_removalai_preview
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Location = New Point(564, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(236, 284)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(770, 6)
        Button2.Name = "Button2"
        Button2.Size = New Size(26, 23)
        Button2.TabIndex = 13
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Location = New Point(738, 6)
        Button3.Name = "Button3"
        Button3.Size = New Size(26, 23)
        Button3.TabIndex = 12
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.Location = New Point(2, 6)
        Button4.Name = "Button4"
        Button4.Size = New Size(26, 23)
        Button4.TabIndex = 11
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' TICKET
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 318)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(Button4)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "TICKET"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TICKET"
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Labeltime As Label
    Friend WithEvents Labeldate As Label
    Friend WithEvents Labelreason As Label
    Friend WithEvents Labelmethod As Label
    Friend WithEvents labelamount As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Labelname As Label
    Friend WithEvents Label8 As Label
End Class
