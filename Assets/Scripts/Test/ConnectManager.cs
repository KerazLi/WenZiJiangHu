using System.Collections.Generic;
using Test;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using utilities;


namespace Manager
{
    public class ConnectManager : MonoBehaviour
    {
         public Button buttonConnect,sendMessage,sendBuyThing;

         private Peer peer = new Peer();
        // Start is called before the first frame update
        void Start()
        {
            buttonConnect.onClick.AddListener(OnButtonConnect);
            sendMessage.onClick.AddListener(OnButtonSendMessage);
            sendBuyThing.onClick.AddListener(OnButtonSendBuyThing);

        }

        // Update is called once per frame
        void Update()
        {
            peer.Service();
        }

        public void OnButtonConnect()
        {
            string address="127.0.0.1";
            int port = 4499;
            peer.Connect(address, port);
        }
        public void OnButtonSendMessage()
        {
            Dictionary<short, object> dict = new Dictionary<short, object>();
            dict.Add(0, "你好我是客服端");
            peer.SendRequest((short)OpCode.Dialog, dict);
        }
        public void OnButtonSendBuyThing()
        {
            Dictionary<short, object> dict = new Dictionary<short, object>();
            dict.Add(1, "你好我来买东西");
            peer.SendRequest((short)OpCode.BuyThing, dict);
        }
    }
}
