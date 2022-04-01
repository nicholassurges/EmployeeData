Imports System.IO

Public Class Form1



    'Global Variables
    Dim txtFile As StreamWriter
    Dim fileName As String
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the text field details
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtEmployeeNumber.Text = ""
        cboDepartment.SelectedIndex = -1
        txtTelephone.Text = ""
        txtExtension.Text = ""
        txtEmail.Text = ""
        txtFirstName.Focus()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Append the text  file
        txtFile = File.AppendText(fileName)

        'Try block
        Try

            'Write employee first name to a file
            txtFile.WriteLine(txtFirstName.Text)

            'Write employee middle name to a file
            txtFile.WriteLine(txtMiddleName.Text)

            'Write employee last name to a file
            txtFile.WriteLine(txtLastName.Text)

            'Write employee number to a file
            txtFile.WriteLine(Convert.ToInt32(txtEmployeeNumber.Text))

            'Write employee department to a file
            txtFile.WriteLine(cboDepartment.SelectedItem.ToString())

            'Write employee phone number to a file
            txtFile.WriteLine(txtTelephone.Text)

            'Write employee extension to a file
            txtFile.WriteLine(Convert.ToInt32(txtExtension.Text))

            'Write employee email to a file
            txtFile.WriteLine(txtEmail.Text)

            'Close the file
            txtFile.Close()

            'Display the successful Message
            MessageBox.Show("You Have Succefully Saved This Record!")

        Catch ex As Exception

            'If any exception occurst it will display exception details
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get the file name from user
        fileName = InputBox("Enter the File Name:", "File Name")
    End Sub
End Class
