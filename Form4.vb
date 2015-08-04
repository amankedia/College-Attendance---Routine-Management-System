Imports System.Windows.Forms.Form
Imports System.Data.OleDb

Public Class Form4
    Dim x As String
    Dim y As String
    Dim z As String
    Dim w As String
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' TextBox1.Text = ""
        'TextBox2.Text = ""
        'TextBox3.Text = ""
        'TextBox4.Text = ""
        'TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'w = TextBox1.Text
        'x = TextBox2.Text
        'y = TextBox3.Text
        'z = TextBox4.Text

        '        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
        'MsgBox("Please enter all the values", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        'TextBox1.Focus()
        'Exit Sub
        'Else

        'End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("CSE")
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("3RD")
        ComboBox3.Items.Clear()
        ComboBox3.Items.Add("B")
        ComboBox4.Items.Clear()
        ComboBox4.Items.Add("CS603")
        ComboBox4.Items.Add("CS604")

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        x = ComboBox2.SelectedItem.ToString()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        y = ComboBox3.SelectedItem.ToString()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        z = ComboBox4.SelectedItem.ToString()
        Try
            connection()
            cmd = New OleDbCommand("attend_s", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("w", OleDbType.VarChar).Value = w
            cmd.Parameters.Add("x", OleDbType.VarChar).Value = x
            cmd.Parameters.Add("y", OleDbType.VarChar).Value = y
            cmd.Parameters.Add("z", OleDbType.VarChar).Value = z
            da = New OleDbDataAdapter(cmd)
            dt.Load(cmd.ExecuteReader())
            Form7.DataGridView1.DataSource = dt

            Form7.Show()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        w = ComboBox1.SelectedItem.ToString()
    End Sub
End Class