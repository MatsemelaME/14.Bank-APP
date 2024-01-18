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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(39, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter your name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter your surname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 15)
        Label3.TabIndex = 2
        Label3.Text = "Enter your Acc number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(39, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(153, 15)
        Label4.TabIndex = 3
        Label4.Text = "Enter your Contact Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(39, 247)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 15)
        Label5.TabIndex = 4
        Label5.Text = "Enter your Pin"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(254, 325)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 7
        Button3.Text = "Close"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(154, 325)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 8
        Button4.Text = "Update"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(223, 60)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 23)
        TextBox1.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(223, 102)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(124, 23)
        TextBox2.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(224, 143)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 23)
        TextBox3.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(224, 191)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(122, 23)
        TextBox4.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(224, 239)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(114, 23)
        TextBox5.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(254, -1)
        Label6.Name = "Label6"
        Label6.Size = New Size(261, 45)
        Label6.TabIndex = 14
        Label6.Text = "Online Banking"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(406, 78)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(382, 345)
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(48, 325)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 23)
        Button1.TabIndex = 16
        Button1.Text = "Log in"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Pink
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(Label6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = " "
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button

End Class
