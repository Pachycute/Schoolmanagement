Imports MySql.Data.MySqlClient

Public Class PAYMENT_ADMIN
    Dim Table As New DataTable

    ' MySQL Connection object
    Dim con As New MySqlConnection("server=127.0.0.1;user id=root;password=050720;database=philtech")

    ' This method will be called when the form is loaded
    Private Sub TICKET_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call LoadData to populate the DataGridView
        LoadData()
    End Sub

    ' Method to load data into DataGridView
    Private Sub LoadData()
        Try
            ' Open connection to MySQL database
            con.Open()

            ' Create an SQL query to fetch data from the ticket table
            Dim sql As String = "SELECT * FROM ticket" ' Modify the query based on your table and required data

            ' Create a MySqlDataAdapter to fetch the data
            Dim adapter As New MySqlDataAdapter(sql, con)

            ' Create a DataTable to store the data from the database
            Dim dt As New DataTable()

            ' Fill the DataTable with data from the database
            adapter.Fill(dt)

            ' Set the DataGridView's DataSource to the DataTable to display the data
            DataGridView1.DataSource = dt

        Catch ex As MySqlException
            ' Handle MySQL-specific errors (e.g., connection problems, query issues)
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            ' Handle general exceptions
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Ensure the connection is always closed, even if an error occurred
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            ' Open the connection
            con.Open()

            ' Create a query with the LIKE operator to search the "NAME" field
            Dim query As String = "SELECT * FROM ticket WHERE `NAME` LIKE @searchText"

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
            con.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow = DataGridView1.SelectedRows(0)

            ' Get the ID of the selected row (assuming the ID is in the first column)
            Dim name As String = selectedRow.Cells("NAME").Value

            ' Ask for confirmation before deleting the row
            Dim result = MessageBox.Show("Are you sure you want to delete this ticket?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Try
                    ' Open connection to MySQL database
                    con.Open()

                    ' Create an SQL query to delete the record based on the ID
                    Dim sql = "DELETE FROM ticket WHERE NAME = @Name"

                    ' Create a MySQL command object and add the parameter
                    Dim cmd As New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@Name", name)

                    ' Execute the delete query
                    cmd.ExecuteNonQuery()

                    ' Show a message indicating successful deletion
                    MessageBox.Show("Ticket deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Refresh the DataGridView to reflect the changes
                    con.Close()
                    LoadData()

                Catch ex As MySqlException
                    ' Handle MySQL-specific errors
                    MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Catch ex As Exception
                    ' Handle other general errors
                    MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    ' Ensure the connection is always closed
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                End Try
            End If
        Else
            MessageBox.Show("Please select a ticket to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim commandtext As String

        commandtext = "SELECT * FROM ticket"
        Try
            adapter = New MySqlDataAdapter(commandtext, con)
            Table = New DataTable
            adapter.Fill(Table)
            DataGridView1.DataSource = Table
        Catch ex As Exception

        End Try
    End Sub

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class