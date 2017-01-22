using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover3D : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    // OnMouseExit is called when the mouse is not any longer over the GUIElement or Collider
    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
