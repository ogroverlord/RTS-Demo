using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking; 


public class MyNetworkManager : NetworkManager {

    public void MyStartHost()
    {
        StartHost();
        Debug.Log(Time.timeSinceLevelLoad + "staring Host."); 
    }

    public override void OnStartHost()
    {
        base.OnStartHost();
        Debug.Log( Time.timeSinceLevelLoad + " Host started");     
    }


    public override void OnStartClient(NetworkClient myClient)
    {
        Debug.Log( Time.timeSinceLevelLoad + " client start requested.");
        InvokeRepeating("Loading", 0f, 0.01f);
    }

    public override void OnClientConnect(NetworkConnection connection)
    {
        CancelInvoke("Loading"); 
        Debug.Log(Time.timeSinceLevelLoad + " Client is connected to IP: " + connection.address);
    }

    public void Loading()
    {
      Debug.Log("...");
    }

}
