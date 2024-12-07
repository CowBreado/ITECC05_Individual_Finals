<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        DBConnect_Button = New Button()
        Panel1 = New Panel()
        Display_Employee_Name_Label = New Label()
        PictureBox2 = New PictureBox()
        Logout_Button = New Button()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Label3 = New Label()
        My_Profile_Button = New Button()
        Label4 = New Label()
        Nian_Panel = New Panel()
        Label14 = New Label()
        Button3 = New Button()
        Label13 = New Label()
        BirthDate_TextBox = New TextBox()
        Label12 = New Label()
        Email_TextBox = New TextBox()
        Label11 = New Label()
        EmployeeID_TextBox = New TextBox()
        Label8 = New Label()
        MiddleName_TextBox = New TextBox()
        Label9 = New Label()
        LastName_TextBox = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        FirstName_TextBox = New TextBox()
        Label5 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Nian_Panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' DBConnect_Button
        ' 
        DBConnect_Button.BackColor = Color.DimGray
        DBConnect_Button.FlatAppearance.BorderSize = 0
        DBConnect_Button.FlatStyle = FlatStyle.Flat
        DBConnect_Button.ForeColor = Color.White
        DBConnect_Button.Location = New Point(0, 509)
        DBConnect_Button.Name = "DBConnect_Button"
        DBConnect_Button.Size = New Size(104, 75)
        DBConnect_Button.TabIndex = 0
        DBConnect_Button.Text = "CHECK DATABASE CONNECTION"
        DBConnect_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.Controls.Add(Display_Employee_Name_Label)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Logout_Button)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1102, 99)
        Panel1.TabIndex = 13
        ' 
        ' Display_Employee_Name_Label
        ' 
        Display_Employee_Name_Label.BackColor = Color.DimGray
        Display_Employee_Name_Label.Font = New Font("Sylfaen", 15.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Display_Employee_Name_Label.ForeColor = Color.Transparent
        Display_Employee_Name_Label.Location = New Point(653, 18)
        Display_Employee_Name_Label.Name = "Display_Employee_Name_Label"
        Display_Employee_Name_Label.Size = New Size(369, 25)
        Display_Employee_Name_Label.TabIndex = 19
        Display_Employee_Name_Label.Text = "LastName, FirstName, MiddleName"
        Display_Employee_Name_Label.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1024, 11)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(65, 52)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' Logout_Button
        ' 
        Logout_Button.BackColor = Color.DimGray
        Logout_Button.FlatAppearance.BorderSize = 0
        Logout_Button.FlatStyle = FlatStyle.Flat
        Logout_Button.Font = New Font("Microsoft Sans Serif", 8.25F)
        Logout_Button.ForeColor = Color.White
        Logout_Button.Location = New Point(1005, 62)
        Logout_Button.Name = "Logout_Button"
        Logout_Button.Size = New Size(100, 37)
        Logout_Button.TabIndex = 19
        Logout_Button.Text = "Sign out"
        Logout_Button.UseMnemonic = False
        Logout_Button.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(77, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sylfaen", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(109, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(361, 27)
        Label2.TabIndex = 1
        Label2.Text = "EMPLOYEE MANAGEMENT SYSTEM"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 33.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(101, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(375, 58)
        Label1.TabIndex = 0
        Label1.Text = "RHODES ISLAND"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DimGray
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(DBConnect_Button)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(My_Profile_Button)
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 99)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(100, 564)
        Panel2.TabIndex = 14
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DimGray
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Microsoft Sans Serif", 8.25F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(0, 110)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 41)
        Button2.TabIndex = 17
        Button2.Text = "My Profile"
        Button2.UseMnemonic = False
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DimGray
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 8.25F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(0, 72)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 41)
        Button1.TabIndex = 18
        Button1.Text = "My Profile"
        Button1.UseMnemonic = False
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.DimGray
        Label3.Font = New Font("Sylfaen", 15.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(12, 5)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 26)
        Label3.TabIndex = 17
        Label3.Text = "Menu"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' My_Profile_Button
        ' 
        My_Profile_Button.BackColor = Color.DimGray
        My_Profile_Button.FlatAppearance.BorderSize = 0
        My_Profile_Button.FlatStyle = FlatStyle.Flat
        My_Profile_Button.Font = New Font("Microsoft Sans Serif", 8.25F)
        My_Profile_Button.ForeColor = Color.White
        My_Profile_Button.Location = New Point(0, 36)
        My_Profile_Button.Name = "My_Profile_Button"
        My_Profile_Button.Size = New Size(100, 41)
        My_Profile_Button.TabIndex = 16
        My_Profile_Button.Text = "My Profile"
        My_Profile_Button.UseMnemonic = False
        My_Profile_Button.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(4, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 26)
        Label4.TabIndex = 15
        Label4.Text = "_____________________"
        ' 
        ' Nian_Panel
        ' 
        Nian_Panel.BackgroundImageLayout = ImageLayout.Zoom
        Nian_Panel.Controls.Add(Label14)
        Nian_Panel.Controls.Add(Button3)
        Nian_Panel.Controls.Add(Label13)
        Nian_Panel.Controls.Add(BirthDate_TextBox)
        Nian_Panel.Controls.Add(Label12)
        Nian_Panel.Controls.Add(Email_TextBox)
        Nian_Panel.Controls.Add(Label11)
        Nian_Panel.Controls.Add(EmployeeID_TextBox)
        Nian_Panel.Controls.Add(Label8)
        Nian_Panel.Controls.Add(MiddleName_TextBox)
        Nian_Panel.Controls.Add(Label9)
        Nian_Panel.Controls.Add(LastName_TextBox)
        Nian_Panel.Controls.Add(Label7)
        Nian_Panel.Controls.Add(Label6)
        Nian_Panel.Controls.Add(FirstName_TextBox)
        Nian_Panel.Controls.Add(Label5)
        Nian_Panel.Dock = DockStyle.Fill
        Nian_Panel.Location = New Point(100, 99)
        Nian_Panel.Name = "Nian_Panel"
        Nian_Panel.Size = New Size(1002, 564)
        Nian_Panel.TabIndex = 15
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Sylfaen", 15.0F)
        Label14.Location = New Point(491, 210)
        Label14.Name = "Label14"
        Label14.Size = New Size(118, 26)
        Label14.TabIndex = 35
        Label14.Text = "Edit Profile?"
        Label14.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(653, 210)
        Button3.Name = "Button3"
        Button3.Size = New Size(300, 34)
        Button3.TabIndex = 34
        Button3.Text = "Update Account"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.BackColor = Color.Transparent
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(3, 43)
        Label13.Name = "Label13"
        Label13.Size = New Size(415, 26)
        Label13.TabIndex = 19
        Label13.Text = "_________________________________________________________________________________________________________"
        ' 
        ' BirthDate_TextBox
        ' 
        BirthDate_TextBox.Font = New Font("Sylfaen", 15.0F)
        BirthDate_TextBox.Location = New Point(653, 158)
        BirthDate_TextBox.Name = "BirthDate_TextBox"
        BirthDate_TextBox.Size = New Size(300, 34)
        BirthDate_TextBox.TabIndex = 33
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Sylfaen", 15.0F)
        Label12.Location = New Point(502, 158)
        Label12.Name = "Label12"
        Label12.Size = New Size(107, 26)
        Label12.TabIndex = 32
        Label12.Text = "BirthDate: "
        Label12.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Email_TextBox
        ' 
        Email_TextBox.Font = New Font("Sylfaen", 15.0F)
        Email_TextBox.Location = New Point(653, 106)
        Email_TextBox.Name = "Email_TextBox"
        Email_TextBox.Size = New Size(300, 34)
        Email_TextBox.TabIndex = 29
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Sylfaen", 15.0F)
        Label11.Location = New Point(535, 109)
        Label11.Name = "Label11"
        Label11.Size = New Size(74, 26)
        Label11.TabIndex = 28
        Label11.Text = "Email: "
        Label11.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' EmployeeID_TextBox
        ' 
        EmployeeID_TextBox.Font = New Font("Sylfaen", 15.0F)
        EmployeeID_TextBox.Location = New Point(175, 260)
        EmployeeID_TextBox.Name = "EmployeeID_TextBox"
        EmployeeID_TextBox.Size = New Size(300, 34)
        EmployeeID_TextBox.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Sylfaen", 15.0F)
        Label8.Location = New Point(33, 256)
        Label8.Name = "Label8"
        Label8.Size = New Size(134, 26)
        Label8.TabIndex = 26
        Label8.Text = "Employee ID: "
        Label8.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' MiddleName_TextBox
        ' 
        MiddleName_TextBox.Font = New Font("Sylfaen", 15.0F)
        MiddleName_TextBox.Location = New Point(175, 205)
        MiddleName_TextBox.Name = "MiddleName_TextBox"
        MiddleName_TextBox.Size = New Size(300, 34)
        MiddleName_TextBox.TabIndex = 25
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Sylfaen", 15.0F)
        Label9.Location = New Point(29, 204)
        Label9.Name = "Label9"
        Label9.Size = New Size(140, 26)
        Label9.TabIndex = 24
        Label9.Text = "Middle Name: "
        Label9.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LastName_TextBox
        ' 
        LastName_TextBox.Font = New Font("Sylfaen", 15.0F)
        LastName_TextBox.Location = New Point(175, 154)
        LastName_TextBox.Name = "LastName_TextBox"
        LastName_TextBox.Size = New Size(300, 34)
        LastName_TextBox.TabIndex = 23
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sylfaen", 15.0F)
        Label7.Location = New Point(56, 158)
        Label7.Name = "Label7"
        Label7.Size = New Size(109, 26)
        Label7.TabIndex = 22
        Label7.Text = "Last Name:"
        Label7.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sylfaen", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(418, 43)
        Label6.TabIndex = 21
        Label6.Text = "ACCOUNT INFORMATION"
        ' 
        ' FirstName_TextBox
        ' 
        FirstName_TextBox.Font = New Font("Sylfaen", 15.0F)
        FirstName_TextBox.Location = New Point(175, 103)
        FirstName_TextBox.Name = "FirstName_TextBox"
        FirstName_TextBox.Size = New Size(300, 34)
        FirstName_TextBox.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sylfaen", 15.0F)
        Label5.Location = New Point(51, 114)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 26)
        Label5.TabIndex = 0
        Label5.Text = "First Name: "
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HighlightText
        ClientSize = New Size(1102, 663)
        Controls.Add(Nian_Panel)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Rhodes Island Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Nian_Panel.ResumeLayout(False)
        Nian_Panel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DBConnect_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Logout_Button As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents My_Profile_Button As Button
    Friend WithEvents Display_Employee_Name_Label As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Nian_Panel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents FirstName_TextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BirthDate_TextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Email_TextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents EmployeeID_TextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MiddleName_TextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LastName_TextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label13 As Label

End Class
