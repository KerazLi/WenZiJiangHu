using System;
using System.Collections.Generic;
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
            Debug.Log("处理服务器相应时代码"+opreationCode);
        }
        
        /// <summary>
        /// 处理事件通知
        /// </summary>
        /// <param name="eventCode">事件代码</param>
        /// <param name="dict">事件数据字典，包含事件相关的数据</param>
        public override void OnEvent(short eventCode, Dictionary<short, object> dict)
        {
            Debug.Log("服务器处理事件"+eventCode);
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
