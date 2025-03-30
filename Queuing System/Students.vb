Imports MySql.Data.MySqlClient

Public Class Students
    ' Define the MySQL connection object globally


    ' Load data into DataGridView when form is loaded
    Private Sub LoadData()
        ' Create SQL query to retrieve data from the students table
        Dim sql As String = "SELECT `REGISTRATION_NUMBER`, `TRACK`, `SECTION`, `STATUS`, `SESSION`, `NAME`, `LRN`, `SEMESTER`, `STRANDS` FROM students"

        ' Create a MySQL DataAdapter to retrieve the data
        da = New MySqlDataAdapter(sql, con)

        ' Create a DataTable to hold the data
        Table = New DataTable()

        Try
            ' Open the connection
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            ' Fill the DataTable with the data from the database
            da.Fill(Table)

            ' Bind the DataTable to the DataGridView
            DataGridView1.DataSource = Table

        Catch ex As MySqlException
            ' Handle MySQL-specific errors
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            ' Handle other general errors
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Ensure the connection is closed, even if an error occurs
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    ' Delete a row based on the selected REGISTRATION_NUMBER
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Check if a row is selected in the DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the REGISTRATION NUMBER of the selected row
            Dim regNumber As String = DataGridView1.SelectedRows(0).Cells("REGISTRATION_NUMBER").Value.ToString()

            ' Confirm deletion with the user
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Try
                    ' Create the SQL query to delete the record using the REGISTRATION NUMBER
                    Dim sql As String = "DELETE FROM students WHERE `REGISTRATION_NUMBER` = @regNumber"

                    ' Create a MySQL command object
                    cmd = New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@regNumber", regNumber)

                    ' Open the connection
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If

                    ' Execute the query to delete the row
                    cmd.ExecuteNonQuery()

                    ' Show a success message
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Refresh the DataGridView
                    LoadData()  ' Call the method to refresh the data in DataGridView

                Catch ex As MySqlException
                    ' Handle MySQL-specific errors
                    MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Catch ex As Exception
                    ' Handle general errors
                    MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    ' Ensure the connection is closed
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End Try
            End If
        Else
            ' If no row is selected, show an error message
            MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Search for a student by NAME
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            ' Open the connection
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            ' Create a query with the LIKE operator to search the "NAME" field
            Dim query As String = "SELECT * FROM students WHERE `NAME` LIKE @searchText"

            ' Create the command with a parameter to avoid SQL injection
            cmd = New MySqlCommand(query, con)

            ' Add the parameter value to search for the entered text in txtSearch
            cmd.Parameters.AddWithValue("@searchText", "%" & txtsearch.Text & "%")

            ' Use a data adapter to fill the filtered data into a DataTable
            da = New MySqlDataAdapter(cmd)
            Table = New DataTable()
            da.Fill(Table)

            ' Set the DataSource of DataGridView to the filtered DataTable
            DataGridView1.DataSource = Table
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    ' Form load event to load data when the form is opened
    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    ' Other button event handlers
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.ExitThread()
    End Sub
End Class
