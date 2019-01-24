using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterUiController : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject lvlTextObject;

    private GameObject hpTextObject;
    private GameObject manaTextObject;

    private GameObject strTextObject;
    private GameObject endTextObject;
    private GameObject agiTextObject;
    private GameObject intTextObject;
    private GameObject wisTextObject;
    private GameObject chaTextObject;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLabels(Hero hero)
    {
        if(hero==null)
        {
            return;
        }
        LoadIntoObjects();
        if (lvlTextObject && hero.LEVEL!=0)
        {
            lvlTextObject.GetComponent<TextMeshProUGUI>().text = hero.LEVEL.ToString();
        }
        if(hpTextObject && hero.CURRENT_HP!=0 && hero.MAX_HP!=0)
        {
            hpTextObject.GetComponent<TextMeshProUGUI>().text = $"{hero.CURRENT_HP}/{hero.MAX_HP}";
        }
        if(manaTextObject && hero.CURRENT_MANA!=0 && hero.MAX_MANA!=0)
        {
            manaTextObject.GetComponent<TextMeshProUGUI>().text = $"{hero.CURRENT_MANA}/{hero.MAX_MANA}";
        }

        #region LoadAttributes

        if (strTextObject && hero.STR != 0)
        {
            strTextObject.GetComponent<TextMeshProUGUI>().text = hero.STR.ToString();
        }
        if (endTextObject && hero.END != 0)
        {
            endTextObject.GetComponent<TextMeshProUGUI>().text = hero.END.ToString();
        }
        if (agiTextObject && hero.AGI != 0)
        {
            agiTextObject.GetComponent<TextMeshProUGUI>().text = hero.AGI.ToString();
        }
        if (intTextObject && hero.INT != 0)
        {
            intTextObject.GetComponent<TextMeshProUGUI>().text = hero.INT.ToString();
        }
        if (wisTextObject && hero.WIS != 0)
        {
            wisTextObject.GetComponent<TextMeshProUGUI>().text = hero.WIS.ToString();
        }
        if (chaTextObject && hero.CHA != 0)
        {
            chaTextObject.GetComponent<TextMeshProUGUI>().text = hero.CHA.ToString();
        }

        #endregion

    }

    private void LoadIntoObjects()
    {
        if (!lvlTextObject)
        {
            lvlTextObject = GameObject.Find("LvlNumberLbl");
        }

        if(!hpTextObject)
        {
            hpTextObject = GameObject.Find("HpLbl");
        }

        if(!manaTextObject)
        {
            manaTextObject = GameObject.Find("ManaLbl");
        }

        if(!strTextObject)
        {
            strTextObject = GameObject.Find("StrLbl");
        }
        if (!endTextObject)
        {
            endTextObject = GameObject.Find("EndLbl");
        }
        if (!agiTextObject)
        {
            agiTextObject = GameObject.Find("AgiLbl");
        }
        if (!intTextObject)
        {
            intTextObject = GameObject.Find("IntLbl");
        }
        if (!wisTextObject)
        {
            wisTextObject = GameObject.Find("WisLbl");
        }
        if (!chaTextObject)
        {
            chaTextObject = GameObject.Find("ChaLbl");
        }
    }

}
