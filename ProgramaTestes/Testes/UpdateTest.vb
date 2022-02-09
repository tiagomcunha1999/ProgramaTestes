Imports System.Data.SqlClient
Public Class FrameAddTeste
    Private objBanco As New SQLControlador2
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        Try
            If (TestIDTextBox.Text = "") And (FileNameTextBox.Text = "") Then
                MessageBox.Show("Can´t be null")
            Else
                objBanco.Conectar()

                Dim ds As DataSet = objBanco.ExecuteQuery("INSERT INTO dbo.TestsLines(TestID, Temperature,
                       Date, Hour, Operator, Manufacturer, 
                       Model, Size, SampleNo, AnvilShape,
                       PointOfImpact, Conditioning, HeadformSize,
                       HeadformMass, MaxSpeed, MaxPeakLevel, MaxPeakNLevel,
                       L1Level, L2Level, MaxHIC, Height, Speed, Peak,
                       Time1, Time2, HIC, Energy, Friction)
                        VALUES('" & TestIDTextBox.Text & "','" & TemperatureTextBox.Text & "','" & DateTextBox.Text & "',
                       '" & HourTextBox.Text & "','" & OperatorTextBox.Text & "','" & ManufacturerTextBox.Text & "',
                       '" & ModelTextBox.Text & "','" & SizeTextBox.Text & "','" & SampleNoTextBox.Text & "',
                       '" & TextBoxAnvilShape.Text & "','" & PointOfImpactTextBox.Text & "','" & ConditioningTextBox.Text & "',
                       '" & HeadformSizeTextBox.Text & "','" & HeadformMassTextBox.Text & "','" & MaxSpeedTextBox.Text & "','" & MaxPeakLevelTextBox.Text & "',
                       '" & MaxPeakNLevelTextBox.Text & "','" & L1LevelTextBox.Text & "','" & L2LevelTextBox.Text & "',
                       '" & MaxHICTextBox.Text & "','" & HeightTextBox.Text & "','" & SpeedTextBox.Text & "','" & PeakTextBox.Text & "',
                       '" & Time1TextBox.Text & "','" & Time2TextBox.Text & "','" & HICTextBox.Text & "',
                       '" & EnergyTextBox.Text & "','" & FrictionTextBox.Text & "')")

                objBanco.Fechar()

                MessageBox.Show("Test Add")
                Me.Close()

            End If
        Catch ex As Exception
            objBanco.Fechar()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TabelaAddTeste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection

        conn.ConnectionString = ("Data Source = TIAGO\SQLEXPRESS; INITIAL CATALOG = TestesFinal; USER ID = Admin; PASSWORD = Admin;")

        conn.Open()

        Dim strsql As String

        strsql = "Select top (1) ID from dbo.Helmets Order By ID desc"

        Dim cmd As New SqlCommand(strsql, conn)

        Dim myreader As SqlDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()

        LastTestID.Text = myreader("ID")

        'LastTestBox.Text = myreader("TestID")

        'LastModelBox.Text = myreader("Model")

        conn.Close()

    End Sub
    '------------------------------------------------------------------------------------------------------

    Private Sub TestIDTextBox_MouseEnter(sender As Object, e As EventArgs) Handles TestIDTextBox.MouseEnter
        If TestIDTextBox.Text = "Test ID" Then
            TestIDTextBox.Text = ""
            TestIDTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TestIDTextBox_MouseLeave(sender As Object, e As EventArgs) Handles TestIDTextBox.MouseLeave
        If TestIDTextBox.Text = "" Then
            TestIDTextBox.Text = "Test ID"
            TestIDTextBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub LastTestID_TextChanged(sender As Object, e As EventArgs) Handles LastTestID.TextChanged

    End Sub
End Class