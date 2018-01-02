using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour {

    private Vector3 inputValue;
    private const float scale = 0.2f;

	void Start () {
		
	}
	
	void Update () {

        if (!isLocalPlayer)
        {
            return;
        }

        inputValue.x = scale * CrossPlatformInputManager.GetAxis("Horizontal");
        inputValue.y = 0f; 
        inputValue.z = scale * CrossPlatformInputManager.GetAxis("Vertical");

        transform.Translate(inputValue);

    }

    public override void OnStartLocalPlayer()
    {
        GetComponentInChildren<Camera>().enabled = true; 
    }
}
