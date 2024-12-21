using System;
using System.Collections.Generic;
using Test;
using TGClient;
using UnityEngine;

namespace utilities
{
    public class Peer : PeerBase
    {
        /// <summary>
        /// 处理连接成功事件
        /// </summary>
        /// <param name="message">连接成功消息</param>
        public override void OnConnected(string message)
        {
            Debug.Log("服务器连接成功"+message);
        }
        
        /// <summary>
        /// 处理操作响应
        /// </summary>
        /// <param name="opreationCode">操作代码</param>
        /// <param name="response">响应对象，包含服务器的响应数据</param>
        public override void OnOperationResponse(short opreationCode, ReceiveResponse response)
        {
            OpCode code = (OpCode)opreationCode;
            switch (code)
            {
                case OpCode.Dialog:
                {
                    string message=(string)response.parameters[2];
                    Debug.Log("收到服务器响应代码，响应代码为： "+opreationCode+"收到的retuenCode"+response.returnCode+"携带的信息为："+message);
                }
                    break;
                case OpCode.BuyThing:
                {
                    string message=(string)response.parameters[3];
                    Debug.Log("收到服务器响应代码，响应代码为： " + opreationCode + "收到的retuenCode" + response.returnCode + "携带的信息为：" +
                              message); 
                }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            //Debug.Log("处理服务器相应时代码"+opreationCode);
            /*if (opreationCode==0)
            {
                string message=(string)response.parameters[2];
                Debug.Log("收到服务器响应代码，响应代码为： "+opreationCode+"收到的retuenCode"+response.returnCode+"携带的信息为："+message);
            }else if (opreationCode==1)
            {
                string message=(string)response.parameters[3];
                Debug.Log("收到服务器响应代码，响应代码为： " + opreationCode + "收到的retuenCode" + response.returnCode + "携带的信息为：" +
                          message);
            }*/
        }
        
        /// <summary>
        /// 处理事件通知
        /// </summary>
        /// <param name="eventCode">事件代码</param>
        /// <param name="dict">事件数据字典，包含事件相关的数据</param>
        public override void OnEvent(short eventCode, Dictionary<short, object> dict)
        {
            EventCode code = (EventCode)eventCode;
            switch (code)
            {
                case EventCode.GetAge:
                {
                    string message=(string)dict[ParameterCode.Age];
                    Debug.Log("收到服务器事件代码，事件代码为： "+eventCode+"携带的信息为："+message);
                }
                    break;
                case EventCode.SendThingName:
                {
                    string message=(string)dict[ParameterCode.ThingName];
                    Debug.Log("收到服务器事件代码，事件代码为： "+eventCode+"携带的信息为："+message);
                }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
        }
        
        /// <summary>
        /// 处理异常事件
        /// </summary>
        /// <param name="exception">发生的异常</param>
        public override void OnException(Exception exception)
        {
            Debug.Log("服务器异常"+exception);
        }
        
        /// <summary>
        /// 处理断开连接事件
        /// </summary>
        /// <param name="connectException">导致断开连接的异常</param>
        public override void OnDisConnect(Exception connectException)
        {
            Debug.Log("服务器断开连接"+connectException);
        }
        
        
    }
}
