Imports MySql.Data.MySqlClient

Public Class AdminSignup
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If String.IsNullOrWhiteSpace(txtusername.Text) OrElse String.IsNullOrWhiteSpace(txtpassword.Text) Then
            ' Display a message to the user if either username or password is empty
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the method or prevent further execution
        End If
        Try
            sql = "INSERT INTO account_admin (`NAME`,`PASSWORD`) VALUES ('" & txtusername.Text & "','" & txtpassword.Text & "')"
            connect()
            MsgBox("Succesfully added Record")



            OBJ1.Show()
            Me.Hide()
            txtusername.Clear()
            txtpassword.Clear()
        Catch ex As Exception
            MsgBox("Invalid username/password")
            con.Close()

        End Try
        con.Close()
    End Sub

    Private Sub AdminSignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "server=127.0.0.1;user id=root;port=3306;password=050720;database=philtech"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim con As New MySqlConnection("server=127.0.0.1;user id=root;password=050720;database=philtech")


        ' Check if username or password is empty
        If String.IsNullOrWhiteSpace(txtusername.Text) OrElse String.IsNullOrWhiteSpace(txtpassword.Text) Then
            ' Display a message to the user if either username or password is empty
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit the method or prevent further execution
        End If

        ' Create the SQL query with parameters, using BINARY for case-sensitive comparison
        Dim sql As String = "SELECT * FROM account_admin WHERE BINARY `NAME` = @username AND BINARY `PASSWORD` = @password"

        ' Create a MySQL command object
        Dim cmd As New MySqlCommand(sql, con)

        ' Add parameters to the command to prevent SQL injection
        cmd.Parameters.AddWithValue("@username", txtusername.Text)
        cmd.Parameters.AddWithValue("@password", txtpassword.Text)

        Try
            ' Open the connection
            con.Open()

            ' Execute the query
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Process the data as needed
            If reader.HasRows Then
                ' Logic if data is found (login successful)
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Logic to move to the next form or take any other actions
                ' For example:

                OBJ1.Show()
                Me.Hide()
            Else
                ' Logic if no data is found (invalid username/password)
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Close the reader
            reader.Close()

        Catch ex As MySqlException
            ' Handle MySQL-specific errors, such as connection issues
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            ' Handle other general errors
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Ensure the connection is always closed, even if an error occurs
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            ' Clear the textboxes after the login attempt
            txtusername.Clear()
            txtpassword.Clear()
        End Try




    End Sub

    Private Sub Buttonshow_Click(sender As Object, e As EventArgs) Handles Buttonshow.Click
        txtpassword.UseSystemPasswordChar = False
        Buttonhide.Show()
        Buttonshow.Hide()
    End Sub

    Private Sub Buttonhide_Click(sender As Object, e As EventArgs) Handles Buttonhide.Click
        txtpassword.UseSystemPasswordChar = True
        ' Show the show button and hide the hide button
        Buttonhide.Hide()
        Buttonshow.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Signup.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.ExitThread()
    End Sub
End Class