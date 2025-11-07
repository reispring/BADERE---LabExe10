Imports System.IO
Imports System.Linq


Public Class Form1
    Private filePath As String = "numbers.txt"
    Private Sub btnWrite_Click(sender As Object, e As EventArgs)
        Try
            Dim input As String = txtNumbers.Text


            ' Check if input is empty
            If String.IsNullOrWhiteSpace(input) Then
                MessageBox.Show("Please enter some numbers first.")
                Return
            End If

            ' Write input to text file
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(input)
            End Using

            MessageBox.Show("Numbers successfully written to file.")
        Catch ex As Exception
            MessageBox.Show("Error writing file: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Try
            ' Check if file exists
            If Not File.Exists(filePath) Then
                MessageBox.Show("File not found. Please write numbers first.")
                Return
            End If

            ' Read numbers from file
            Dim fileContent As String
            Using reader As New StreamReader(filePath)
                fileContent = reader.ReadToEnd()
            End Using

            ' Convert to List of Integers
            Dim numbers As List(Of Integer) = fileContent.Split(" "c).Select(Function(n) Integer.Parse(n.Trim())).ToList()

            ' Sort using LINQ
            Dim sortedNumbers = numbers.OrderBy(Function(n) n).ToList()

            ' Display in ListBox
            Sorted.Items.Clear()
            For Each num In sortedNumbers
                Sorted.Items.Add(num)
            Next

            MessageBox.Show("Numbers read and sorted successfully!")

        Catch ex As FormatException
            MessageBox.Show("Error: Please ensure all inputs are valid numbers separated by commas.")
        Catch ex As Exception
            MessageBox.Show("Error reading file: " & ex.Message)
        End Try
    End Sub
End Class

