Imports System.Threading
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI2.WinForms.Helpers.GraphicsHelper
Imports MaterialSkin
Imports MySql.Data.MySqlClient
Public Class FormDashboard
    Dim con As New MySqlConnection("server=localhost;user id=root;Password=;database=queuewrite_db;sslMode=none;Convert Zero Datetime=True;")
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    Dim sql As String
    Dim dt As New DataTable

    Dim tel_1 As Integer = 1
    Dim tel_2 As Integer = 1
    Dim tel_3 As Integer = 1
    Dim tel_4 As Integer = 1


    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE)

        Teller_1()
        Teller_2()
        Teller_3()
        Teller_4()
    End Sub

    Public Sub Teller_1()
        con.Open()
        sql = "SELECT PNO FROM counter_one"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()
        If dt.Rows.Count > 0 Then
            DataGridView1.DataSource = dt
        End If
    End Sub
    Public Sub Teller_2()
        con.Open()
        sql = "SELECT PNO FROM counter_two"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()
        If dt.Rows.Count > 0 Then
            DataGridView2.DataSource = dt
        End If
    End Sub
    Public Sub Teller_3()
        con.Open()
        sql = "SELECT PNO FROM counter_three"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()
        If dt.Rows.Count > 0 Then
            DataGridView3.DataSource = dt
        End If


    End Sub
    Public Sub Teller_4()
        con.Open()
        sql = "SELECT PNO FROM counter_four"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()
        If dt.Rows.Count > 0 Then
            DataGridView4.DataSource = dt
        End If
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        FormMain.Show()
    End Sub

    Private Sub btnFirst1_Click(sender As Object, e As EventArgs) Handles btnFirst1.Click
        con.Open()
        sql = "SELECT * FROM counter_one"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_1 = 0
            FormMain.LabelCounter1.Text = dt.Rows(tel_1)("PNO").ToString()
            Teller1.Text = dt.Rows(tel_1)("PNO").ToString()
            FormMain.Timer_1.Enabled = True

        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        con.Open()
        sql = "SELECT * FROM counter_one"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_1 = tel_1 + 1
            FormMain.LabelCounter1.Text = dt.Rows(tel_1)("PNO").ToString()
            Teller1.Text = dt.Rows(tel_1)("PNO").ToString()
            FormMain.Timer_1.Enabled = True
        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrev1_Click(sender As Object, e As EventArgs) Handles btnPrev1.Click
        con.Open()
        sql = "SELECT * FROM counter_one"
        da = New MySqlDataAdapter(sql, con)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_1 = tel_1 - 1
            FormMain.LabelCounter1.Text = dt.Rows(tel_1)("PNO").ToString()
            Teller1.Text = dt.Rows(tel_1)("PNO").ToString()
            FormMain.Timer_1.Enabled = True

        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLast1_Click(sender As Object, e As EventArgs) Handles btnLast1.Click
        con.Open()
        sql = "SELECT * FROM counter_one"
        da = New MySqlDataAdapter(sql, con)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_1 = dt.Rows.Count - 1
            FormMain.LabelCounter1.Text = dt.Rows(tel_1)("PNO").ToString()
            Teller1.Text = dt.Rows(tel_1)("PNO").ToString()
            FormMain.Timer_1.Enabled = True
        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnFirst2_Click(sender As Object, e As EventArgs) Handles btnFirst2.Click
        con.Open()
        sql = "SELECT * FROM counter_one"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_2 = 0
            FormMain.LabelCounter2.Text = dt.Rows(tel_2)("PNO").ToString()
            Teller2.Text = dt.Rows(tel_2)("PNO").ToString()
            FormMain.Timer_2.Enabled = True

        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        con.Open()
        sql = "SELECT * FROM counter_one"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_2 = tel_2 + 1
            FormMain.LabelCounter2.Text = dt.Rows(tel_2)("PNO").ToString()
            Teller2.Text = dt.Rows(tel_2)("PNO").ToString()
            FormMain.Timer_2.Enabled = True
        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrev2_Click(sender As Object, e As EventArgs) Handles btnPrev2.Click
        con.Open()
        sql = "SELECT * FROM counter_one"
        da = New MySqlDataAdapter(sql, con)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_2 = tel_2 - 1
            FormMain.LabelCounter2.Text = dt.Rows(tel_2)("PNO").ToString()
            Teller2.Text = dt.Rows(tel_2)("PNO").ToString()
            FormMain.Timer_2.Enabled = True

        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLast2_Click(sender As Object, e As EventArgs) Handles btnLast2.Click
        con.Open()
        sql = "SELECT * FROM counter_one"
        da = New MySqlDataAdapter(sql, con)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_2 = dt.Rows.Count - 1
            FormMain.LabelCounter2.Text = dt.Rows(tel_2)("PNO").ToString()
            Teller2.Text = dt.Rows(tel_2)("PNO").ToString()
            FormMain.Timer_2.Enabled = True
        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnFirst3_Click(sender As Object, e As EventArgs) Handles btnFirst3.Click
        con.Open()
        sql = "SELECT * FROM counter_three"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_3 = 0
            FormMain.LabelCounter3.Text = dt.Rows(tel_3)("PNO").ToString()
            Teller3.Text = dt.Rows(tel_3)("PNO").ToString()
            FormMain.Timer3.Enabled = True

        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNext3_Click(sender As Object, e As EventArgs) Handles btnNext3.Click
        con.Open()
        sql = "SELECT * FROM counter_three"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_3 = tel_3 + 1
            FormMain.LabelCounter3.Text = dt.Rows(tel_3)("PNO").ToString()
            Teller3.Text = dt.Rows(tel_3)("PNO").ToString()
            FormMain.Timer3.Enabled = True
        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrev3_Click(sender As Object, e As EventArgs) Handles btnPrev3.Click
        con.Open()
        sql = "SELECT * FROM counter_three"
        da = New MySqlDataAdapter(sql, con)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_3 = tel_3 - 1
            FormMain.LabelCounter3.Text = dt.Rows(tel_3)("PNO").ToString()
            Teller3.Text = dt.Rows(tel_3)("PNO").ToString()
            FormMain.Timer3.Enabled = True

        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLast3_Click(sender As Object, e As EventArgs) Handles btnLast3.Click
        con.Open()
        sql = "SELECT * FROM counter_three"
        da = New MySqlDataAdapter(sql, con)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_3 = dt.Rows.Count - 1
            FormMain.LabelCounter3.Text = dt.Rows(tel_3)("PNO").ToString()
            Teller3.Text = dt.Rows(tel_3)("PNO").ToString()
            FormMain.Timer3.Enabled = True
        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnFirst4_Click(sender As Object, e As EventArgs) Handles btnFirst4.Click
        con.Open()
        sql = "SELECT * FROM counter_four"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_4 = 0
            FormMain.LabelCounter4.Text = dt.Rows(tel_4)("PNO").ToString()
            Teller4.Text = dt.Rows(tel_4)("PNO").ToString()
            FormMain.Timer_4.Enabled = True

        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNext4_Click(sender As Object, e As EventArgs) Handles btnNext4.Click
        con.Open()
        sql = "SELECT * FROM counter_four"
        da = New MySqlDataAdapter(sql, con)
        da.Fill(ds)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_4 = tel_4 + 1
            FormMain.LabelCounter4.Text = dt.Rows(tel_4)("PNO").ToString()
            Teller4.Text = dt.Rows(tel_4)("PNO").ToString()
            FormMain.Timer_4.Enabled = True
        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrev4_Click(sender As Object, e As EventArgs) Handles btnPrev4.Click
        con.Open()
        sql = "SELECT * FROM counter_four"
        da = New MySqlDataAdapter(sql, con)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_4 = tel_4 - 1
            FormMain.LabelCounter4.Text = dt.Rows(tel_4)("PNO").ToString()
            Teller4.Text = dt.Rows(tel_4)("PNO").ToString()
            FormMain.Timer_4.Enabled = True

        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLast4_Click(sender As Object, e As EventArgs) Handles btnLast4.Click
        con.Open()
        sql = "SELECT * FROM counter_four"
        da = New MySqlDataAdapter(sql, con)
        con.Close()
        If dt.Rows.Count > 0 Then
            tel_4 = dt.Rows.Count - 1
            FormMain.LabelCounter4.Text = dt.Rows(tel_4)("PNO").ToString()
            Teller4.Text = dt.Rows(tel_4)("PNO").ToString()
            FormMain.Timer_4.Enabled = True
        Else
            MessageBox.Show("No priority number found", "QUEUE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class