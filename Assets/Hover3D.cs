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

    bool isDragging = false;
    private Vector3 screenPoint;
    private Vector3 offset;

    private void OnMouseDown()
    {
        isDragging = true;
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    private void OnMouseDrag()
    {
        if (isDragging) {
            
        }
        var curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }


}
