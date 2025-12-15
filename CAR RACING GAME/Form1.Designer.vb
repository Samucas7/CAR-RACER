<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        race3 = New PictureBox()
        race2 = New PictureBox()
        race1 = New PictureBox()
        car = New PictureBox()
        RoadMover = New Timer(components)
        RightSide = New Timer(components)
        LeftSide = New Timer(components)
        RaceMover1 = New Timer(components)
        RaceMover2 = New Timer(components)
        RaceMover3 = New Timer(components)
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        UpSide = New Timer(components)
        DownSide = New Timer(components)
        RaceMoverSide1 = New Timer(components)
        RaceMoverSide2 = New Timer(components)
        RaceMoverSide3 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(race3, ComponentModel.ISupportInitialize).BeginInit()
        CType(race2, ComponentModel.ISupportInitialize).BeginInit()
        CType(race1, ComponentModel.ISupportInitialize).BeginInit()
        CType(car, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Location = New Point(107, -54)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(12, 130)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Location = New Point(214, -54)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(12, 130)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.Location = New Point(214, 102)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(12, 130)
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.White
        PictureBox4.Location = New Point(107, 102)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(12, 130)
        PictureBox4.TabIndex = 2
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.White
        PictureBox5.Location = New Point(214, 258)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(12, 130)
        PictureBox5.TabIndex = 5
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.White
        PictureBox6.Location = New Point(107, 258)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(12, 130)
        PictureBox6.TabIndex = 4
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.White
        PictureBox7.Location = New Point(214, 414)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(12, 130)
        PictureBox7.TabIndex = 7
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.White
        PictureBox8.Location = New Point(107, 414)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(12, 130)
        PictureBox8.TabIndex = 6
        PictureBox8.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 24)
        Label1.TabIndex = 8
        Label1.Text = "Score 0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(232, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 24)
        Label2.TabIndex = 9
        Label2.Text = "Speed 0"
        ' 
        ' race3
        ' 
        race3.Image = My.Resources.Resources.greycar
        race3.Location = New Point(268, 173)
        race3.Name = "race3"
        race3.Size = New Size(43, 90)
        race3.SizeMode = PictureBoxSizeMode.Zoom
        race3.TabIndex = 10
        race3.TabStop = False
        ' 
        ' race2
        ' 
        race2.Image = My.Resources.Resources.medik
        race2.Location = New Point(141, 29)
        race2.Name = "race2"
        race2.Size = New Size(58, 124)
        race2.SizeMode = PictureBoxSizeMode.Zoom
        race2.TabIndex = 11
        race2.TabStop = False
        ' 
        ' race1
        ' 
        race1.Image = My.Resources.Resources.yellowcar
        race1.Location = New Point(28, 258)
        race1.Name = "race1"
        race1.Size = New Size(57, 108)
        race1.SizeMode = PictureBoxSizeMode.Zoom
        race1.TabIndex = 12
        race1.TabStop = False
        ' 
        ' car
        ' 
        car.Image = My.Resources.Resources.bugatti1
        car.Location = New Point(141, 356)
        car.Name = "car"
        car.Size = New Size(52, 106)
        car.SizeMode = PictureBoxSizeMode.Zoom
        car.TabIndex = 13
        car.TabStop = False
        ' 
        ' RoadMover
        ' 
        RoadMover.Enabled = True
        RoadMover.Interval = 10
        ' 
        ' RightSide
        ' 
        RightSide.Interval = 10
        ' 
        ' LeftSide
        ' 
        LeftSide.Interval = 10
        ' 
        ' RaceMover1
        ' 
        RaceMover1.Enabled = True
        RaceMover1.Interval = 10
        ' 
        ' RaceMover2
        ' 
        RaceMover2.Enabled = True
        RaceMover2.Interval = 10
        ' 
        ' RaceMover3
        ' 
        RaceMover3.Enabled = True
        RaceMover3.Interval = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Firebrick
        Label3.Location = New Point(45, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(253, 42)
        Label3.TabIndex = 14
        Label3.Text = "GAME OVER"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        Label3.Visible = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Firebrick
        Button1.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(97, 235)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 43)
        Button1.TabIndex = 15
        Button1.Text = "REPLAY"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.UseVisualStyleBackColor = False
        Button1.Visible = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.OliveDrab
        Button2.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(214, 394)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 55)
        Button2.TabIndex = 16
        Button2.Text = "START"
        Button2.UseVisualStyleBackColor = False
        Button2.Visible = False
        ' 
        ' UpSide
        ' 
        UpSide.Interval = 10
        ' 
        ' DownSide
        ' 
        DownSide.Interval = 10
        ' 
        ' RaceMoverSide1
        ' 
        RaceMoverSide1.Enabled = True
        ' 
        ' RaceMoverSide2
        ' 
        RaceMoverSide2.Enabled = True
        RaceMoverSide2.Interval = 10
        ' 
        ' RaceMoverSide3
        ' 
        RaceMoverSide3.Enabled = True
        RaceMoverSide3.Interval = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(334, 461)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(car)
        Controls.Add(race1)
        Controls.Add(race2)
        Controls.Add(race3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        MaximumSize = New Size(350, 500)
        MinimumSize = New Size(350, 500)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(race3, ComponentModel.ISupportInitialize).EndInit()
        CType(race2, ComponentModel.ISupportInitialize).EndInit()
        CType(race1, ComponentModel.ISupportInitialize).EndInit()
        CType(car, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents race3 As PictureBox
    Friend WithEvents race2 As PictureBox
    Friend WithEvents race1 As PictureBox
    Friend WithEvents car As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents RightSide As Timer
    Friend WithEvents LeftSide As Timer
    Friend WithEvents RaceMover1 As Timer
    Friend WithEvents RaceMover2 As Timer
    Friend WithEvents RaceMover3 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents UpSide As Timer
    Friend WithEvents DownSide As Timer
    Friend WithEvents RaceMoverSide1 As Timer
    Friend WithEvents RaceMoverSide2 As Timer
    Friend WithEvents RaceMoverSide3 As Timer

End Class
