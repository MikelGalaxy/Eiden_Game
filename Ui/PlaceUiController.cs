using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlaceUiController : MonoBehaviour {

    // Use this for initialization
    public GameObject villageNameObj;
	void Awake () {
        villageNameObj = GameObject.Find("PlaceNameTxt");             
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateVillageName(string name)
    {
        var commponent = villageNameObj.GetComponent<TextMeshProUGUI>();
        if(commponent!=null)
        {
            commponent.text = name;
        }           
    }


}
