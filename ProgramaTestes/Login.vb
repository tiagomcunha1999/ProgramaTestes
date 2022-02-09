Imports System.Data
Imports System.Data.SqlClient
Public Class Login
    Private Sub TextBoxPass_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPass.TextChanged

    End Sub

    Dim pass = False
    Dim user = False
    Dim adminpass = False
    Dim admin = False

    Private objBanco As New SQLControlador
    Private Sub ButtonTestes_Click(sender As Object, e As EventArgs) Handles ButtonTestes.Click
        If TextBoxName.Text = My.Settings.Username Then
            admin = True
        End If
        If TextBoxPass.Text = My.Settings.Password Then
            adminpass = True

        End If
        If TextBoxName.Text = My.Settings.Username2 Then
            user = True
        End If
        If TextBoxPass.Text = My.Settings.Password2 Then
            pass = True

        End If


        If admin = True And adminpass = True Then
            ''MsgBox("Login Successful", MsgBoxStyle.Information)
            MainForm.Show()
            Me.Hide()

        ElseIf user = True And pass = True Then
            ''MsgBox("Login Successful", MsgBoxStyle.Information)
            MainForm2.Show()
            Me.Hide()
        ElseIf admin = True And adminpass = False Then
            MsgBox("Password is not valid", MsgBoxStyle.Exclamation)
            admin = False
            pass = False
            user = False

        ElseIf admin = False And adminpass = True Then
            MsgBox("Username is not valid", MsgBoxStyle.Exclamation)
            adminpass = False
            pass = False
            user = False
        ElseIf user = True And pass = False Then
            MsgBox("Password is not valid", MsgBoxStyle.Exclamation)
            user = False
            adminpass = False
            user = False

        ElseIf user = False And pass = True Then
            MsgBox("Username is not valid", MsgBoxStyle.Exclamation)
            adminpass = False
            admin = False
            user = False
        Else
            MsgBox("Username and Password are incorrect", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class