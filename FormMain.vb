Imports System
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Management
Imports System.Text.RegularExpressions
Imports System.Collections.Generic
Imports System.Timers
Imports System.Speech.Synthesis
Public Class FormMain
    Dim pics() As String = {"1.jpg", "2.jpg", "3.jpg", "4.jpg"}
    Dim i As Integer = 0

    Const marqueeText As String = "QueueWrite is a complete enterprise software system for customer."
    Dim sb As New System.Text.StringBuilder
    Dim direction As Boolean = False 'true = left to right, false = right to left

    Dim synth As New SpeechSynthesizer
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Timer1.Start()
        PictureBoxSlider.Image = Image.FromFile(Application.StartupPath & "\slider\" + pics(0))

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Set this formula to increment i by 1
        i += 1

        'Set a validation of pictures
        If pics.Length = i Then
            i = 0
        End If


        'Set to Load the image.

        PictureBoxSlider.Image = Image.FromFile(Application.StartupPath & "\slider\" + pics(i))

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        LabelTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub
    Public Sub marquueee()
        If sb.Length = 0 Then sb.Append(marqueeText)
        If direction Then
            sb.Insert(0, sb(sb.Length - 1))
            sb.Remove(sb.Length - 1, 1)
        Else
            sb.Append(sb(0))
            sb.Remove(0, 1)
        End If
        Me.MarqueeLabel.Text = sb.ToString
    End Sub

    Private Sub FormMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                'Admin Log In
                e.SuppressKeyPress = True
                FormDashboard.ShowDialog()
            Case Keys.F2
                'Manual Add attendance
               ' e.SuppressKeyPress = True
                '
            Case Keys.F3
                'Manual Add attendance
            Case Keys.F4
            Case Keys.F5
            Case Keys.F6
            Case Keys.F7
            Case Keys.F8
            Case Keys.F9
            Case Keys.F10
            Case Keys.F11

                ' e.SuppressKeyPress = True
                '  PanelSetting.Visible = True
        End Select
        ' If e.KeyCode = Keys.Escape Then PanelSetting.Visible = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim att As Integer
        For att = 1 To 10

        Next

        Label10.Text = Label10.Text + 1

        If Label10.Text = "2" Then

            LabelCounter3.ForeColor = Color.Red
            synth.SelectVoiceByHints(VoiceGender.Female)
            synth.Speak(" NOW SERVING. " & LabelCounter3.Text & "." & " In Teller 3.")

        ElseIf Label10.Text = "4" Then

            LabelCounter3.ForeColor = Color.Black

        ElseIf Label10.Text = "6" Then

            LabelCounter3.ForeColor = Color.Red

        ElseIf Label10.Text = "8" Then

            LabelCounter3.ForeColor = Color.Black
            synth.SelectVoiceByHints(VoiceGender.Female)
            synth.Speak(" NOW SERVING. " & LabelCounter3.Text & "." & " In Teller 3.")

        ElseIf Label10.Text = "10" Then

            LabelCounter3.ForeColor = Color.Black
            Timer3.Enabled = False
            Label10.Text = "0"
        End If

    End Sub

    Private Sub Timer_1_Tick(sender As Object, e As EventArgs) Handles Timer_1.Tick
        Dim att As Integer
        For att = 1 To 10

        Next

        Label_1.Text = Label_1.Text + 1

        If Label_1.Text = "2" Then

            LabelCounter1.ForeColor = Color.Red
            synth.SelectVoiceByHints(VoiceGender.Female)
            synth.Speak(" NOW SERVING. " & LabelCounter1.Text & "." & " In Teller 1.")

        ElseIf Label_1.Text = "4" Then

            LabelCounter1.ForeColor = Color.Black

        ElseIf Label_1.Text = "6" Then

            LabelCounter1.ForeColor = Color.Red

        ElseIf Label_1.Text = "8" Then

            LabelCounter1.ForeColor = Color.Black
            synth.SelectVoiceByHints(VoiceGender.Female)
            synth.Speak(" NOW SERVING. " & LabelCounter1.Text & "." & " In Teller 1.")

        ElseIf Label_1.Text = "10" Then

            LabelCounter1.ForeColor = Color.Black
            Timer_1.Enabled = False
            Label_1.Text = "0"
        End If
    End Sub

    Private Sub Timer_2_Tick(sender As Object, e As EventArgs) Handles Timer_2.Tick
        Dim att As Integer
        For att = 1 To 10

        Next

        Label_2.Text = Label_2.Text + 1

        If Label_2.Text = "2" Then

            LabelCounter2.ForeColor = Color.Red
            synth.SelectVoiceByHints(VoiceGender.Female)
            synth.Speak(" NOW SERVING. " & LabelCounter2.Text & "." & " In Teller 2.")

        ElseIf Label_2.Text = "4" Then

            LabelCounter2.ForeColor = Color.Black

        ElseIf Label_2.Text = "6" Then

            LabelCounter2.ForeColor = Color.Red

        ElseIf Label_2.Text = "8" Then

            LabelCounter2.ForeColor = Color.Black
            synth.SelectVoiceByHints(VoiceGender.Female)
            synth.Speak(" NOW SERVING. " & LabelCounter2.Text & "." & " In Teller 2.")

        ElseIf Label_2.Text = "10" Then

            LabelCounter2.ForeColor = Color.Black
            Timer_2.Enabled = False
            Label_2.Text = "0"
        End If
    End Sub

    Private Sub Timer_4_Tick(sender As Object, e As EventArgs) Handles Timer_4.Tick
        Dim att As Integer
        For att = 1 To 10

        Next

        Label_4.Text = Label_4.Text + 1

        If Label_4.Text = "2" Then

            LabelCounter4.ForeColor = Color.Red
            synth.SelectVoiceByHints(VoiceGender.Female)
            synth.Speak(" NOW SERVING. " & LabelCounter4.Text & "." & " In Teller 4.")

        ElseIf Label_4.Text = "4" Then

            LabelCounter4.ForeColor = Color.Black

        ElseIf Label_4.Text = "6" Then

            LabelCounter4.ForeColor = Color.Red

        ElseIf Label_4.Text = "8" Then

            LabelCounter4.ForeColor = Color.Black
            synth.SelectVoiceByHints(VoiceGender.Female)
            synth.Speak(" NOW SERVING. " & LabelCounter4.Text & "." & " In Teller 4.")

        ElseIf Label_4.Text = "10" Then

            LabelCounter4.ForeColor = Color.Black
            Timer_4.Enabled = False
            Label_4.Text = "0"
        End If
    End Sub
End Class
