using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConversationUiController : MonoBehaviour
{
    public GameObject textObject;

    public IEnumerator UpdateText(string newText, float delay)
    {
        textObject = GameObject.Find("ConversationText");
        yield return new WaitForSeconds(delay);
        if(textObject)
        {
            textObject.GetComponent<TextMeshProUGUI>().text = newText;
        }       
    }
}
