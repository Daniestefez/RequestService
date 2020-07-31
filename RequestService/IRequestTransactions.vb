' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
Imports System.IO

<ServiceContract()>
Public Interface IRequestTransactions

    <OperationContract(Name:="ExecuteProcess")>
    <WebInvoke(Method:="POST", UriTemplate:="ExecuteProcess")>
    Function ExecuteProcess(ByVal json As Stream) As String

End Interface

