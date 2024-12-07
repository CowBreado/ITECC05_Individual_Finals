Imports MySql.Data.MySqlClient
Imports Login
Public Class Dashboard

    'Creating a bunch of necessary variables to manipulate and use MySql related procedures.
    Dim MySqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Reader As MySqlDataReader

    Dim Current_DB As String = "employeedb"

    Dim FirstName As String
    Dim LastName As String
    Dim MiddleName As String
    Dim BirthDate As DateTime
    Dim EmployeeID As String
    Dim EmailAddress As String


    Public Property email As String
    Public Property password As String


    'This is the button responsible for connecting the database to the visual studio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DBConnect_Button.Click
        'MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")


        Try
            MySqlConn.Open()
            MessageBox.Show($"Connection To MySql Database ({Current_DB}) Successfully Established!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub My_Profile_Button_Click(sender As Object, e As EventArgs) Handles My_Profile_Button.Click
        If Nian_Panel.Visible Then
            Nian_Panel.Visible = False
        Else
            Nian_Panel.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Logout_Button_Click(sender As Object, e As EventArgs) Handles Logout_Button.Click
        Dim Form1 As New Login
        Form1.Show()
        Me.Hide()
    End Sub

    'Display Employee Name, WORK IN PROGRESS # # # #
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Display_Employee_Name_Label.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
        MySqlConn.Open()

        Dim Query As String = $"select FirstName, LastName, MiddleName, BirthDate, Email, EmployeeID from {Current_DB}.employees where email = @email"
        Command = New MySqlCommand(Query, MySqlConn)
        Command.Parameters.AddWithValue("@email", email)
        Reader = Command.ExecuteReader

        If Reader.HasRows Then

            Reader.Read()
            FirstName = Reader("FirstName").ToString()
            LastName = Reader("LastName").ToString()
            MiddleName = Reader("MiddleName").ToString()
            BirthDate = Reader.GetDateTime("BirthDate")
            EmailAddress = Reader("Email").ToString()
            EmployeeID = Reader("EmployeeID").ToString()

            Display_Employee_Name_Label.Text = $"{LastName}, {FirstName}, {MiddleName}"

        End If
        Reader.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles FirstName_TextBox.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Nian_Panel_Paint(sender As Object, e As PaintEventArgs) Handles Nian_Panel.Paint

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
