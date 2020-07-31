' NOTE: You can use the "Rename" command on the context menu to change the class name "RequestTransactions" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select RequestTransactions.svc or RequestTransactions.svc.vb at the Solution Explorer and start debugging.
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class RequestTransactions
    Implements IRequestTransactions


    Public Function ExecuteProcess(ByVal json As Stream) As String Implements IRequestTransactions.ExecuteProcess

        Dim lobjUser As ConnectionBroker.DataManagerClient = Nothing
        Dim lstrSQL As String = ""
        Dim ds As DataSet = Nothing
        Dim ldtList As DataTable = Nothing
        Dim strList As String = Nothing
        Dim objRequest As JObject = Nothing
        Dim arrParameters As JArray = Nothing
        Dim objMetadata As JObject = Nothing
        Dim objCheckftp As JObject = Nothing
        Dim checkftp As Boolean = Nothing
        Dim reader As StreamReader = New StreamReader(json)
        Dim ftpresult As String = ""

        'Dim Json As String = "{""metadata"": {""check_ftp"": false,""stored_procedure"": ""CRLease_sp_getdashboard"",""parameters"": [{ ""value"": ""Luis.Jalpilla"",""type"": ""string""}]}}"

        Try
            'Uso del connectionbroker
            lobjUser = New ConnectionBroker.DataManagerClient
            If System.Configuration.ConfigurationManager.AppSettings("DebugMode").ToString = "1" Then
                lobjUser.ClientCredentials.Windows.ClientCredential.UserName = System.Configuration.ConfigurationManager.AppSettings("ServerUser").ToString
                lobjUser.ClientCredentials.Windows.ClientCredential.Password = System.Configuration.ConfigurationManager.AppSettings("ServerPWD").ToString
            End If

            objRequest = JObject.Parse(reader.ReadToEnd())
            objMetadata = objRequest("metadata")
            objCheckftp = objMetadata("check_ftp")
            checkftp = CSng(objCheckftp.GetValue("value"))
            arrParameters = objMetadata.GetValue("parameters")
            'If checkftp Then
            '    ftpresult = FileExist(CStr(objCheckftp.GetValue("name")), CStr(objCheckftp.GetValue("taskid")), CStr(objCheckftp.GetValue("extension")))
            '    'xdxdxd
            '    If ftpresult = "0" Then
            '        Return "Fail to save file"
            '    End If
            'End If

            lstrSQL = "exec [" + CStr(objMetadata.GetValue("stored_procedure")) + "] "
            For Each item As JObject In arrParameters.Children(Of JObject)()
                Select Case CStr(item.GetValue("type"))
                    Case "string", "date", "char"
                        lstrSQL += "'" + CStr(item.GetValue("value")) + "',"
                    Case "boolean"
                        Dim val As String
                        If CSng(item.GetValue("value")) = False Then val = "0" Else val = "1"
                        lstrSQL += "" + val + ","
                    Case Else
                        lstrSQL += "" + CStr(item.GetValue("value")) + ","
                End Select
            Next
            lstrSQL = lstrSQL.TrimEnd(",")

            lobjUser.Open()
            lobjUser.SetConnectionString(System.Configuration.ConfigurationManager.ConnectionStrings("cnxleasetest").ConnectionString)

            'lobjUser.ExecuteCommand(lstrSQL)
            ds = lobjUser.GetDataSet(lstrSQL, "Table")
            lobjUser.Finalize()

            ldtList = ds.Tables(0)
            strList = JsonConvert.SerializeObject(ldtList, Newtonsoft.Json.Formatting.Indented)

            Return strList

        Catch ex As Exception
            If Not lobjUser Is Nothing Then lobjUser.Abort()
            Return ex.InnerException.ToString
            'Return True
        Finally
            If Not lobjUser Is Nothing Then lobjUser.Close()
            lobjUser = Nothing
            lstrSQL = Nothing
            ds = Nothing
            strList = Nothing
            ldtList = Nothing
        End Try

    End Function
End Class
