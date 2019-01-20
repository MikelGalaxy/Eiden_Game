using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{

    public string Name { get; set; }
    public int STR { get; set; }
    public int AGI { get; set; }
    public int INT { get; set; }
    public int WIS { get; set; }
    public int CHA { get; set; }
    public int END { get; set; }

    public int MAX_HP { get; set; }
    public int MAX_MANA { get; set; }

	void Awake ()
    {
        SetTestCharacter();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void SetTestCharacter()
    {
        Name = "Eiden";
        STR = 5;
        AGI = 5;
        INT = 5;
        WIS = 5;
        CHA = 5;
        END = 5;
        MAX_HP = 100;
        MAX_MANA = 100;
    }


}
