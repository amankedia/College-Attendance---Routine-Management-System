Imports System.Windows.Forms.Form
Imports System.Data.OleDb
Imports System.Data
Public Class Form3
    Dim x As String

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'TextBox1.Text = ""
        'TextBox1.Focus()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("SAPTARSI GOSWAMI")
        ComboBox1.Items.Add("NILANJANA DUTTA ROY")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        x = ComboBox1.SelectedItem.ToString()
        '   If TextBox1.Text = "" Then
        '("Please enter all the values", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        'TextBox1.Focus()
        ' Sub
        ' Else
        Try
            Form6.DataGridView1.Refresh()
            connection()
            cmd = New OleDbCommand("routine_t", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("x", OleDbType.VarChar).Value = x
            da = New OleDbDataAdapter(cmd)
            dt.Load(cmd.ExecuteReader())
            Form6.DataGridView1.DataSource = dt

            Form6.Show()
            Me.Close()


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        conn.Close()
        'End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class