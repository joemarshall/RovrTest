using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class SimpleMoveScript : MonoBehaviour {

    public Camera cam;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SteamVR_Controller.Device device = SteamVR_Controller.Input(1);
        Vector2 axis = device.GetAxis(EVRButtonId.k_EButton_Axis0);
        Vector3 move = cam.transform.forward * axis.y*Time.deltaTime*10f;
        move= Vector3.ProjectOnPlane(move, Vector3.up);
        transform.position += move;

    }
}
