using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    public int Id;
    public string Name;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Debug.Log($"{Name}");
        var globalUi = GameObject.Find("MainCanvas").GetComponent<GlobalUiController>();
        if(globalUi)
        {
            globalUi.ShowConversation();
            Debug.Log($"Works");
        }

    }
}
