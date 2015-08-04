Imports System.Windows.Forms.Form
Imports System.Data.OleDb

Public Class Form2
    Dim x As String
    Dim y As String
    Dim z As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '    TextBox1.Text = ""
        '   TextBox2.Text = ""
        '  TextBox3.Text = ""
        ' TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' x = TextBox1.Text
        'y = TextBox2.Text
        'z = TextBox3.Text

        'If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
        'MsgBox("Please enter all the values", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        'TextBox1.Focus()
        'Exit Sub
        'Else
        'Try
        'connection()
        'cmd = New OleDbCommand("routine_s", conn)
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("x", OleDbType.VarChar).Value = x
        'cmd.Parameters.Add("y", OleDbType.VarChar).Value = y
        'cmd.Parameters.Add("z", OleDbType.VarChar).Value = z
        'da = New OleDbDataAdapter(cmd)
        'dt.Load(cmd.ExecuteReader())
        'Form5.DataGridView1.DataSource = dt

        'Form5.Show()
        'Me.Close()
        'Catch ex As Exception
        'MsgBox(ex.ToString())
        'End Try
        'conn.Close()
        'End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        x = ComboBox1.SelectedItem.ToString()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        y = ComboBox2.SelectedItem.ToString()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        z = ComboBox3.SelectedItem.ToString()
        Try
            connection()
            cmd = New OleDbCommand("routine_s", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("x", OleDbType.VarChar).Value = x
            cmd.Parameters.Add("y", OleDbType.VarChar).Value = y
            cmd.Parameters.Add("z", OleDbType.VarChar).Value = z
            da = New OleDbDataAdapter(cmd)
            dt.Load(cmd.ExecuteReader())
            Form5.DataGridView1.DataSource = dt

            Form5.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        conn.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("CSE")
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("3RD")
        ComboBox3.Items.Clear()
        ComboBox3.Items.Add("A")
        ComboBox3.Items.Add("B")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class