﻿using System.ServiceModel;
using WCF.Datas;

namespace WCF.Interfaces
{
    [ServiceContract(Name = "ServerOperatorService",
                     SessionMode = SessionMode.Required,
                     CallbackContract = typeof(IServerCallback))]
    public interface IServerOperator
    {
        [OperationContract(IsOneWay = true, IsInitiating = true, IsTerminating = false)]
        void Join(ClientData client);

        [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = true)]
        void Exit();

        [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
        void Send(string msg);//发送消息
    }
}
