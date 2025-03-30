Imports MySql.Data.MySqlClient

Public Class ENROLLMENT_STUDENT




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OBJ.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.ExitThread()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try
                ' Ensure that all fields are filled before inserting
                If String.IsNullOrWhiteSpace(txtregnum.Text) OrElse String.IsNullOrWhiteSpace(cmbtrack.Text) OrElse String.IsNullOrWhiteSpace(cmbsection.Text) OrElse String.IsNullOrWhiteSpace(cmbstatus.Text) OrElse String.IsNullOrWhiteSpace(txtname.Text) OrElse String.IsNullOrWhiteSpace(txtlrn.Text) Then
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Handle the session (afternoon or morning)
                Dim session As String = If(RadioButtonafternoon.Checked, "Afternoon", If(RadioButtonmorning.Checked, "Morning", "No session selected"))

            ' Handle the strand checkboxes (1st Year, 2nd Year, etc.)
            Dim yearLevel As String = If(CheckBox1st.Checked, "1st Year", If(CheckBox2nd.Checked, "2nd Year", "No year level selected"))

            ' Handle the strands (ABM, HUMMS, ICT, HE)
            Dim strands As String = String.Join(", ",
                                       New String() {If(CheckBoxabm.Checked, "ABM", ""),
                                                    If(CheckBoxhumms.Checked, "HUMMS", ""),
                                                    If(CheckBoxict.Checked, "ICT", ""),
                                                    If(CheckBoxhe.Checked, "HE", "")}.Where(Function(str) Not String.IsNullOrEmpty(str)))

                ' If no strand is selected, set to "No strand selected"
                If String.IsNullOrEmpty(strands) Then
                    strands = "No strand selected"
                End If

                ' Handle semester (1st or 2nd semester)
                Dim semester As String
                If CheckBox1st.Checked Then
                    semester = "1st Semester"
                ElseIf CheckBox2nd.Checked Then
                    semester = "2nd Semester"
                Else
                    semester = "No semester selected"
                End If

            ' Prepare the SQL query to insert data into the database
            Dim sql As String = "INSERT INTO students (`REGISTRATION_NUMBER`, `TRACK`, `SECTION`, `STATUS`, `SESSION`, `NAME`, `LRN`, `SEMESTER`, `STRANDS`) " &
                        "VALUES (@regNum, @track, @section, @status, @session, @name, @lrn, @semester, @strands)"

            ' Set up the MySQL command object
            Dim cmd As New MySqlCommand(sql, con)

                ' Add parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@regNum", txtregnum.Text)
                cmd.Parameters.AddWithValue("@track", cmbtrack.Text)
                cmd.Parameters.AddWithValue("@section", cmbsection.Text)
                cmd.Parameters.AddWithValue("@status", cmbstatus.Text)
                cmd.Parameters.AddWithValue("@session", session)
                cmd.Parameters.AddWithValue("@name", txtname.Text)
                cmd.Parameters.AddWithValue("@lrn", txtlrn.Text)
                cmd.Parameters.AddWithValue("@semester", semester)
                cmd.Parameters.AddWithValue("@strands", strands)

                ' Execute the query
                Try
                    ' Open the connection
                    con.Open()

                    ' Execute the query
                    cmd.ExecuteNonQuery()

                    ' Success message
                    MessageBox.Show("Successfully added record!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Show OBJ1 form after successfully adding the record



            Catch ex As MySqlException
                    ' Handle MySQL-specific errors
                    MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Catch ex As Exception
                    ' Handle other errors
                    MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    ' Ensure the connection is always closed, even if an error occurs
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End Try

            Catch ex As Exception
                ' Handle errors in the main try block
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try


    End Sub

    Private Sub ENROLLMENT_STUDENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "server=127.0.0.1;user id=root;port=3306;password=050720;database=philtech"

    End Sub
End Class