using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalUiController : MonoBehaviour
{

    // Use this for initialization
    public GameObject placeUi;
    public GameObject optionsUi;
    public GameObject conversationUi;
    public GameObject characterUi;

    public Hero hero;


    private OptionsUiController optionsUiController;

    void Start()
    {
        if (optionsUi != null && conversationUi != null && characterUi != null)
        {
            optionsUi.SetActive(false);
            conversationUi.SetActive(false);
            characterUi.SetActive(false);
            //optionsUiController = optionsUi.GetComponent<OptionsUiController>();
        }
        if (!hero)
        {
            hero = GameObject.Find("Hero").GetComponent<Hero>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleShowOptionsUi();
        }
    }

    public void ToggleShowOptionsUi()
    {
        if (optionsUi != null)
        {
            if (optionsUi.activeSelf)
            {
                optionsUi.SetActive(false);
            }
            else
            {
                SwitchOffOtherUi();
                optionsUi.SetActive(true);
            }
        }
    }

    public void ToggleShowCharacterUi()
    {
        if (characterUi != null)
        {
            if (characterUi.activeSelf)
            {
                characterUi.SetActive(false);
            }
            else
            {
                SwitchOffOtherUi();
                characterUi.SetActive(true);
                LoadCharacterToUiControlls();
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

    public void LoadCharacterToUiControlls()
    {
        if (characterUi && hero)
        {
            var controller = characterUi.GetComponent<CharacterUiController>();
            if (controller)
            {
                controller.UpdateLabels(hero);

            }

        }

    }

    public void SwitchOffOtherUi()
    {
        optionsUi.SetActive(false);
        characterUi.SetActive(false);
    }



}
