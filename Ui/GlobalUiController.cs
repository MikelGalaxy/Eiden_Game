using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalUiController : MonoBehaviour {

    // Use this for initialization
    public GameObject placeUi;
    public GameObject optionsUi;
    public GameObject conversationUi;

    private OptionsUiController optionsUiController;

	void Start () {
		if(optionsUi!=null && conversationUi!=null)
        {
            optionsUi.SetActive(false);
            conversationUi.SetActive(false);
            //optionsUiController = optionsUi.GetComponent<OptionsUiController>();
        }
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleShowOptionsUi();
        }
	}

    public void ToggleShowOptionsUi()
    {
        if(optionsUi != null)
        {
            if(optionsUi.activeSelf)
            {
                optionsUi.SetActive(false);
            }
            else
            {
                optionsUi.SetActive(true);
            }
            
        }
    }

    public void ShowConversation()
    {
        conversationUi.SetActive(true);
        conversationUi.GetComponent<ConversationController>()?.StartConversation();
    }

    public void CloseConversation()
    {

    }


}
