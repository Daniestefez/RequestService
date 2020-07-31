﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ConnectionBroker
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ConnectionBroker.IDataManager")>  _
    Public Interface IDataManager
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/OpenConnection", ReplyAction:="http://tempuri.org/IDataManager/OpenConnectionResponse")>  _
        Function OpenConnection() As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/OpenConnection", ReplyAction:="http://tempuri.org/IDataManager/OpenConnectionResponse")>  _
        Function OpenConnectionAsync() As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/ExecuteCommand", ReplyAction:="http://tempuri.org/IDataManager/ExecuteCommandResponse")>  _
        Function ExecuteCommand(ByVal SQLStatement As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/ExecuteCommand", ReplyAction:="http://tempuri.org/IDataManager/ExecuteCommandResponse")>  _
        Function ExecuteCommandAsync(ByVal SQLStatement As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/GetDataSet", ReplyAction:="http://tempuri.org/IDataManager/GetDataSetResponse")>  _
        Function GetDataSet(ByVal lstrSQLStatement As String, ByVal lstrDataSetName As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/GetDataSet", ReplyAction:="http://tempuri.org/IDataManager/GetDataSetResponse")>  _
        Function GetDataSetAsync(ByVal lstrSQLStatement As String, ByVal lstrDataSetName As String) As System.Threading.Tasks.Task(Of System.Data.DataSet)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/SetConnectionString", ReplyAction:="http://tempuri.org/IDataManager/SetConnectionStringResponse")>  _
        Sub SetConnectionString(ByVal ConnectionString As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/SetConnectionString", ReplyAction:="http://tempuri.org/IDataManager/SetConnectionStringResponse")>  _
        Function SetConnectionStringAsync(ByVal ConnectionString As String) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/SetApplicationName", ReplyAction:="http://tempuri.org/IDataManager/SetApplicationNameResponse")>  _
        Sub SetApplicationName(ByVal ApplicationName As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/SetApplicationName", ReplyAction:="http://tempuri.org/IDataManager/SetApplicationNameResponse")>  _
        Function SetApplicationNameAsync(ByVal ApplicationName As String) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/SetReturnIdentity", ReplyAction:="http://tempuri.org/IDataManager/SetReturnIdentityResponse")>  _
        Sub SetReturnIdentity(ByVal ReturnIdentity As Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/SetReturnIdentity", ReplyAction:="http://tempuri.org/IDataManager/SetReturnIdentityResponse")>  _
        Function SetReturnIdentityAsync(ByVal ReturnIdentity As Boolean) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/GetIdentityValue", ReplyAction:="http://tempuri.org/IDataManager/GetIdentityValueResponse")>  _
        Function GetIdentityValue() As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/GetIdentityValue", ReplyAction:="http://tempuri.org/IDataManager/GetIdentityValueResponse")>  _
        Function GetIdentityValueAsync() As System.Threading.Tasks.Task(Of Integer)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/SetColumnFormat", ReplyAction:="http://tempuri.org/IDataManager/SetColumnFormatResponse")>  _
        Sub SetColumnFormat(ByVal CaseFormat As Microsoft.VisualBasic.VbStrConv)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/SetColumnFormat", ReplyAction:="http://tempuri.org/IDataManager/SetColumnFormatResponse")>  _
        Function SetColumnFormatAsync(ByVal CaseFormat As Microsoft.VisualBasic.VbStrConv) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/Finalize", ReplyAction:="http://tempuri.org/IDataManager/FinalizeResponse")>  _
        Sub Finalize()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDataManager/Finalize", ReplyAction:="http://tempuri.org/IDataManager/FinalizeResponse")>  _
        Function FinalizeAsync() As System.Threading.Tasks.Task
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IDataManagerChannel
        Inherits ConnectionBroker.IDataManager, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class DataManagerClient
        Inherits System.ServiceModel.ClientBase(Of ConnectionBroker.IDataManager)
        Implements ConnectionBroker.IDataManager
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function OpenConnection() As Boolean Implements ConnectionBroker.IDataManager.OpenConnection
            Return MyBase.Channel.OpenConnection
        End Function
        
        Public Function OpenConnectionAsync() As System.Threading.Tasks.Task(Of Boolean) Implements ConnectionBroker.IDataManager.OpenConnectionAsync
            Return MyBase.Channel.OpenConnectionAsync
        End Function
        
        Public Function ExecuteCommand(ByVal SQLStatement As String) As Boolean Implements ConnectionBroker.IDataManager.ExecuteCommand
            Return MyBase.Channel.ExecuteCommand(SQLStatement)
        End Function
        
        Public Function ExecuteCommandAsync(ByVal SQLStatement As String) As System.Threading.Tasks.Task(Of Boolean) Implements ConnectionBroker.IDataManager.ExecuteCommandAsync
            Return MyBase.Channel.ExecuteCommandAsync(SQLStatement)
        End Function
        
        Public Function GetDataSet(ByVal lstrSQLStatement As String, ByVal lstrDataSetName As String) As System.Data.DataSet Implements ConnectionBroker.IDataManager.GetDataSet
            Return MyBase.Channel.GetDataSet(lstrSQLStatement, lstrDataSetName)
        End Function
        
        Public Function GetDataSetAsync(ByVal lstrSQLStatement As String, ByVal lstrDataSetName As String) As System.Threading.Tasks.Task(Of System.Data.DataSet) Implements ConnectionBroker.IDataManager.GetDataSetAsync
            Return MyBase.Channel.GetDataSetAsync(lstrSQLStatement, lstrDataSetName)
        End Function
        
        Public Sub SetConnectionString(ByVal ConnectionString As String) Implements ConnectionBroker.IDataManager.SetConnectionString
            MyBase.Channel.SetConnectionString(ConnectionString)
        End Sub
        
        Public Function SetConnectionStringAsync(ByVal ConnectionString As String) As System.Threading.Tasks.Task Implements ConnectionBroker.IDataManager.SetConnectionStringAsync
            Return MyBase.Channel.SetConnectionStringAsync(ConnectionString)
        End Function
        
        Public Sub SetApplicationName(ByVal ApplicationName As String) Implements ConnectionBroker.IDataManager.SetApplicationName
            MyBase.Channel.SetApplicationName(ApplicationName)
        End Sub
        
        Public Function SetApplicationNameAsync(ByVal ApplicationName As String) As System.Threading.Tasks.Task Implements ConnectionBroker.IDataManager.SetApplicationNameAsync
            Return MyBase.Channel.SetApplicationNameAsync(ApplicationName)
        End Function
        
        Public Sub SetReturnIdentity(ByVal ReturnIdentity As Boolean) Implements ConnectionBroker.IDataManager.SetReturnIdentity
            MyBase.Channel.SetReturnIdentity(ReturnIdentity)
        End Sub
        
        Public Function SetReturnIdentityAsync(ByVal ReturnIdentity As Boolean) As System.Threading.Tasks.Task Implements ConnectionBroker.IDataManager.SetReturnIdentityAsync
            Return MyBase.Channel.SetReturnIdentityAsync(ReturnIdentity)
        End Function
        
        Public Function GetIdentityValue() As Integer Implements ConnectionBroker.IDataManager.GetIdentityValue
            Return MyBase.Channel.GetIdentityValue
        End Function
        
        Public Function GetIdentityValueAsync() As System.Threading.Tasks.Task(Of Integer) Implements ConnectionBroker.IDataManager.GetIdentityValueAsync
            Return MyBase.Channel.GetIdentityValueAsync
        End Function
        
        Public Sub SetColumnFormat(ByVal CaseFormat As Microsoft.VisualBasic.VbStrConv) Implements ConnectionBroker.IDataManager.SetColumnFormat
            MyBase.Channel.SetColumnFormat(CaseFormat)
        End Sub
        
        Public Function SetColumnFormatAsync(ByVal CaseFormat As Microsoft.VisualBasic.VbStrConv) As System.Threading.Tasks.Task Implements ConnectionBroker.IDataManager.SetColumnFormatAsync
            Return MyBase.Channel.SetColumnFormatAsync(CaseFormat)
        End Function
        
        Public Sub Finalize() Implements ConnectionBroker.IDataManager.Finalize
            MyBase.Channel.Finalize
        End Sub
        
        Public Function FinalizeAsync() As System.Threading.Tasks.Task Implements ConnectionBroker.IDataManager.FinalizeAsync
            Return MyBase.Channel.FinalizeAsync
        End Function
    End Class
End Namespace
