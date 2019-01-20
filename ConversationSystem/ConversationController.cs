using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationController : MonoBehaviour
{

    private bool ConversationStatus;
    private ConversationUiController uiController;
    // Start is called before the first frame update
    void Awake()
    {
        uiController = gameObject.GetComponent<ConversationUiController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartConversation()
    {
        Debug.Log("Conversation started");
        if(uiController)
        {
            uiController.StartCoroutine(uiController.UpdateText("Hello there!", 0.0f));
            uiController.StartCoroutine(uiController.UpdateText("General Kenobi! I've been expecting you...", 2.0f));
            StartCoroutine(HideConversation(5.0f));
            //uiController.UpdateText();
            //uiController.UpdateText("Helo there");
        }
        
    }

    public IEnumerator HideConversation(float delay)
    {
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
    }
}
