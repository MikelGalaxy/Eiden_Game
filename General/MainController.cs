using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

    // Use this for initialization
    public Hero mainHero;
    public GlobalUiController mainUiController;

	void Awake () {

        //LoadCharacterToControlls();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //void LoadCharacterToControlls()
    //{
    //    //mainHero
    //    if(mainHero!=null && mainUiController!=null)
    //    {
    //        mainUiController.LoadCharacterToUiControlls(mainHero);
    //    }
    //}
}
