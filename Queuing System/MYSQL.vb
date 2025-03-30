Imports MySql.Data.MySqlClient

Module MYSQL


    Public OBJ1 As New Admin
    Public OBJ As New Home_Page_Students
    Public con As MySqlConnection = New MySqlConnection("Server=127.0.0.1;Database=philtech;Uid=root;Pwd=050720;")
    Public ds As New DataSet
    Public cmd As MySqlCommand = New MySqlCommand
    Public dr As MySqlDataReader
    Public adapter As MySqlDataAdapter
    Public Table As DataTable
    Public sql As String
    Public data As New DataSet
    Public da As MySqlDataAdapter


    ' Connection and command execution
    Public Sub connect()
        Try
            ' Set the command text, type, and connection
            cmd.CommandText = sql
            cmd.CommandType = CommandType.Text
            cmd.Connection = con

            ' Open the connection
            con.Open()

            ' Execute the reader
            dr = cmd.ExecuteReader()

            ' Check if data exists in the reader
            If dr.HasRows Then
                While dr.Read()
                    ' Process data row-by-row
                    ' Example: 
                    ' Console.WriteLine(dr("columnName").ToString())
                End While
            Else
                Console.WriteLine("No data found.")
            End If

        Catch ex As MySqlException
            ' Handle MySQL errors
            Console.WriteLine("MySQL Error: " & ex.Message)

        Catch ex As Exception
            ' Handle general errors
            Console.WriteLine("General Error: " & ex.Message)

        Finally
            ' Always close the connection and the reader
            If dr IsNot Nothing Then
                dr.Close()
            End If
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
End Module

