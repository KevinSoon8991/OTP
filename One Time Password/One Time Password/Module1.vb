Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Security.Cryptography
Module Module1
    Public gConn As MySqlConnection
    Public gConnstr As String
    Public gcSQL As String
    Public Cmd As MySqlCommand
    Public Const SYMBOL1 As String = "~"
    Public ErrMsg As String
    Public email As String
    Public cCurrentId As String
    Public Sub OpenConn()
        gConnstr = "server = localhost; database = otp; uid = root"
        gConn = New MySqlConnection(gConnstr)
        gConn.Open()
    End Sub

    Public Function EncryptText(ByVal SourceText As System.String) As System.String
        Dim MyKey As String = "cappuchino"
        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
        Dim strResult As System.String = ""

        Try
            Dim bykey() As Byte = System.Text.Encoding.UTF8.GetBytes(Strings.Left(MyKey, 8))
            Dim InputByteArray() As Byte = System.Text.Encoding.UTF8.GetBytes(SourceText)
            Dim des As New DESCryptoServiceProvider
            Dim ms As New MemoryStream
            Dim cs As New CryptoStream(ms, des.CreateEncryptor(bykey, IV), CryptoStreamMode.Write)
            cs.Write(InputByteArray, 0, InputByteArray.Length)
            cs.FlushFinalBlock()
            strResult = Convert.ToBase64String(ms.ToArray())
        Catch ex As Exception
            Throw New Exception
        End Try
        Return strResult
    End Function

    Function ExecSQL(Optional ByVal isoLvl As IsolationLevel = IsolationLevel.RepeatableRead, Optional ByVal ErrorMsgBox As Boolean = True) As Boolean
        If gcSQL = Nothing Then
            MessageBox.Show("GcSQL is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If

        Dim cSplit() As String = Split(gcSQL, SYMBOL1)
        gcSQL = Nothing
        Dim Trans As MySqlTransaction = Nothing
        Try
            Trans = gConn.BeginTransaction(IsolationLevel.RepeatableRead)
            Cmd = gConn.CreateCommand
            For Each eachSplit As String In cSplit
                Cmd.CommandText = eachSplit
                Cmd.Transaction = Trans
                Cmd.ExecuteNonQuery()
            Next
            Trans.Commit()
        Catch ex As Exception
            Trans.Rollback()
            ErrMsg = "Error Message : " & ex.Message & ". Type error: " & ex.GetType.ToString & ""
            If ErrorMsgBox Then MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End Try
        ErrMsg = ""
        Return True
        '----------IMPLEMENTATION-------------------
        'gcSQL = String.Format("delete from barang where kd_brg = '{0}'", kd_brg.Text)
        'gcSQL += String.Format("˘ delete from stok where kd_brg = '{0}'", kd_brg.Text)
        'If ExecuteMySqlTransaction(gcSQL, IsolationLevel.Serializable) = False Then
        '    
        'End If
    End Function

    Function AnyRec() As Boolean
        Try
            Using Cmd As MySqlCommand = New MySqlCommand() With {.Connection = gConn, .CommandType = CommandType.Text, .CommandText = gcSQL}
                Using sdr As MySqlDataReader = Cmd.ExecuteReader
                    If sdr.HasRows Then
                        Return True
                    Else
                        Return False
                    End If
                    sdr.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function ExecDT(Optional ByVal ErrorMsgBox As Boolean = True) As DataTable
        If gcSQL = Nothing Then Return Nothing
        Using da As MySqlDataAdapter = New MySqlDataAdapter(gcSQL, gConn)
            Try
                Dim dt As DataTable = New DataTable

                da.Fill(dt)

                ErrMsg = ""
                Return dt
            Catch ex As Exception
                ErrMsg = "Error Message : " & ex.Message & ". Type error: " & ex.GetType.ToString & ""
                If ErrorMsgBox Then MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return Nothing
            Finally
                gcSQL = Nothing
            End Try
        End Using
    End Function

End Module
