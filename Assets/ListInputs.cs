using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class ListInputs : MonoBehaviour {


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        for (int c = 0; c < 20; c++)
        {
            SteamVR_Controller.Device device = SteamVR_Controller.Input(c);
            bool buttons = device.GetPress(0xffff);
            Vector2 axis = device.GetAxis(EVRButtonId.k_EButton_Axis0);
            Vector2 axis2 = device.GetAxis(EVRButtonId.k_EButton_Axis1);
            if (axis.x != 0 || axis.y != 0)
            {

                print(c + ":" + axis.x + "," + axis.y + ":" + axis2.x + "," + axis2.y + "[" + buttons + "]");
            }
        }

    }
}
