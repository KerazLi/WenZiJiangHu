using TMPro;
using UnityEngine;
using UnityEngine.UI;
using utilities;


namespace Manager
{
    public class ConnectManager : MonoBehaviour
    {
         public Button buttonConnect;

         private Peer peer = new Peer();
        // Start is called before the first frame update
        void Start()
        {
            buttonConnect.onClick.AddListener(OnButtonConnect);
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
    }
}
