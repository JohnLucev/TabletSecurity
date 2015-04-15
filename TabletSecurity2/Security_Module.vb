Imports System
Imports System.Data.SqlClient


Module Security_Module

    Public Sub SecurityCheck()
        ' current data opens the database and executes the querries
        Dim ConnectionString As String
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim Sql As String

        ConnectionString = "server = nitta-mfg01\ncimes; Database = Taglogs; User ID = mesuser; Password = nc12m3s0k; Integrated Security = False;"
        Sql = ("select RequestPending from HMI where ChannelId ='1'")


        connection = New SqlConnection(ConnectionString)
        Try
            connection.Open()

            command = New SqlCommand(Sql, connection)
            Dim SqlReader As SqlDataReader = command.ExecuteReader()

            While SqlReader.Read()
                Tag_1 = (SqlReader.Item(0)) ' & "-" & SqlReader.Item(1) & "-" & SqlReader.Item(2))
            End While
            SqlReader.Close()


            command.Dispose()
            connection.Close()

        Catch ex As Exception
            MsgBox("Lost connection to database" + ex.Message)

        End Try
        Return
    End Sub


    Public Sub UpdateSecurityCheck()
        ' current data opens the database and executes the querries
        Dim ConnectionString As String
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim Sql As String

        ConnectionString = "server = nitta-mfg01\ncimes; Database = Taglogs; User ID = mesuser; Password = nc12m3s0k; Integrated Security = False;"
        Sql = ("update HMI Set RequestPending = '0' Where ChannelId='1'")

        connection = New SqlConnection(ConnectionString)
        Try

            connection.Open()
            command = New SqlCommand(Sql, connection)
            command.ExecuteNonQuery()
            command.Dispose()
            connection.Close()

        Catch ex As Exception
            MsgBox("Lost connection to database" + ex.Message)

        End Try
        'Return
    End Sub

End Module
