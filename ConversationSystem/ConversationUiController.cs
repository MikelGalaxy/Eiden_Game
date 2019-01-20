using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ConversationUiController : MonoBehaviour
{
    public GameObject textObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    //public void UpdateText(string newText)
    //{
        
    //    StartCoroutine(UpdateTest(newText,2.0f));
    //}

    public IEnumerator UpdateText(string newText,float delay)
    {
        textObject = GameObject.Find("ConversationText");
        yield return new WaitForSeconds(delay);
        textObject.GetComponent<TextMeshProUGUI>().text = newText;
    }
}
