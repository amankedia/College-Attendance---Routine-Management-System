Imports System.Data.OleDb
Module Module1
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public rs As OleDbDataReader
    Public da As OleDbDataAdapter
    Public dt As New DataTable
    Public ds As New DataSet


    Public Sub connection()
        Try
            conn = New OleDbConnection("Provider=MSDAORA;Data Source=XE;User ID=aman;password=jaidadiki1994")
            conn.Open()
        Catch ex As Exception
            Print(ex.ToString())
        End Try

    End Sub
End Module
