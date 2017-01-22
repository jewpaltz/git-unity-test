using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverUI : MonoBehaviour {

    Text textComponent;
	// Use this for initialization
	void Start () {
        textComponent = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {
        textComponent.color = Color.green;
    }

    private void OnMouseExit()
    {
        textComponent.color = Color.red;
    }

    private void OnMouseOver()
    {

    }


}
