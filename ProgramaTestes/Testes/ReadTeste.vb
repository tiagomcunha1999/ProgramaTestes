Imports System.IO

Public Class ReadTeste

    Private Sub AdiocionarTeste_Click(sender As Object, e As EventArgs) Handles AdiocionarTeste.Click

        Dim ValidKeys() As String = {"Temperature", "Date", "Hour", "Operator", "Manufacturer", "Model", "Size",
            "SampleNo", "AnvilShape", "PointOfImpact", "Conditioning", "HeadformSize", "HeadformMass", "MaxSpeed",
            "MaxPeakLevel", "MaxPeakNLevel", "L1Level", "L2Level", "MaxHIC", "Height", "Speed", "Peak", "Time1", "Time2",
            "HIC", "Energy", "Friction%"}
        Dim ValuesObject As New Dictionary(Of String, String)
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            For Each line As String In File.ReadLines(OpenFileDialog1.FileName)
                Dim SplitStringArray() As String = Split(line, " ")
                If ValidKeys.Contains(SplitStringArray(0)) Then
                    'Console.WriteLine(line)
                    ValuesObject.Add(SplitStringArray(0), SplitStringArray(1))
                End If
            Next line
        End If

        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)

        FrameAddTeste.FileNameTextBox.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        FrameAddTeste.TemperatureTextBox.Text = ValuesObject("Temperature")
        FrameAddTeste.DateTextBox.Text = ValuesObject("Date")
        FrameAddTeste.HourTextBox.Text = ValuesObject("Hour")
        FrameAddTeste.OperatorTextBox.Text = ValuesObject("Operator")
        FrameAddTeste.ManufacturerTextBox.Text = ValuesObject("Manufacturer")
        FrameAddTeste.ModelTextBox.Text = ValuesObject("Model")
        FrameAddTeste.SizeTextBox.Text = ValuesObject("Size")
        FrameAddTeste.SampleNoTextBox.Text = ValuesObject("SampleNo")
        FrameAddTeste.TextBoxAnvilShape.Text = ValuesObject("AnvilShape")
        FrameAddTeste.PointOfImpactTextBox.Text = ValuesObject("PointOfImpact")
        FrameAddTeste.ConditioningTextBox.Text = ValuesObject("Conditioning")
        FrameAddTeste.HeadformSizeTextBox.Text = ValuesObject("HeadformSize")
        FrameAddTeste.HeadformMassTextBox.Text = ValuesObject("HeadformMass")
        FrameAddTeste.MaxSpeedTextBox.Text = ValuesObject("MaxSpeed")
        FrameAddTeste.MaxPeakLevelTextBox.Text = ValuesObject("MaxPeakLevel")
        FrameAddTeste.MaxPeakNLevelTextBox.Text = ValuesObject("MaxPeakNLevel")
        FrameAddTeste.L1LevelTextBox.Text = ValuesObject("L1Level")
        FrameAddTeste.L2LevelTextBox.Text = ValuesObject("L2Level")
        FrameAddTeste.MaxHICTextBox.Text = ValuesObject("MaxHIC")
        FrameAddTeste.HeightTextBox.Text = ValuesObject("Height")
        FrameAddTeste.SpeedTextBox.Text = ValuesObject("Speed")
        FrameAddTeste.PeakTextBox.Text = ValuesObject("Peak")
        FrameAddTeste.Time1TextBox.Text = ValuesObject("Time1")
        FrameAddTeste.Time2TextBox.Text = ValuesObject("Time2")
        FrameAddTeste.HICTextBox.Text = ValuesObject("HIC")
        FrameAddTeste.EnergyTextBox.Text = ValuesObject("Energy")
        FrameAddTeste.FrictionTextBox.Text = ValuesObject("Friction%")
        FrameAddTeste.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddTeste_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        AddTest.Show()
    End Sub
End Class