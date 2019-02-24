using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    #region Properties

    [SerializeField]
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    [SerializeField]
    private string _title;
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }


    [SerializeField]
    private int _str;
    public int STR
    {
        get { return _str; }
        set { _str = value; }
    }

    [SerializeField]
    private int _agi;
    public int AGI
    {
        get { return _agi; }
        set { _agi = value; }
    }

    [SerializeField]
    private int _int;
    public int INT
    {
        get { return _int; }
        set { _int = value; }
    }

    [SerializeField]
    private int _wis;
    public int WIS
    {
        get { return _wis; }
        set { _wis = value; }
    }

    [SerializeField]
    private int _cha;
    public int CHA
    {
        get { return _cha; }
        set { _cha = value; }
    }

    [SerializeField]
    private int _end;
    public int END
    {
        get { return _end; }
        set { _end = value; }
    }

    [SerializeField]
    private int _maxHp;
    public int MAX_HP
    {
        get { return _maxHp; }
        set { _maxHp = value; }
    }

    [SerializeField]
    private int _maxMana;
    public int MAX_MANA
    {
        get { return _maxMana; }
        set { _maxMana = value; }
    }

    [SerializeField]
    private int _lvl;
    public int LEVEL
    {
        get { return _lvl; }
        set { _lvl = value; }
    }

    [SerializeField]
    private int _currHp;
    public int CURRENT_HP
    {
        get { return _currHp; }
        set { _currHp = value; }
    }

    [SerializeField]
    private int _currMana;
    public int CURRENT_MANA
    {
        get { return _currMana; }
        set { _currMana = value; }
    }



    #endregion

    void Awake ()
    {
        SetTestCharacter();
    }


    private void SetTestCharacter()
    {
        Name = "Eiden";
        Title = "The Noob";
        LEVEL = 1;
        STR = 4;
        AGI = 4;
        INT = 6;
        WIS = 6;
        CHA = 3;
        END = 4;
        MAX_HP = 100;
        MAX_MANA = 100;
        CURRENT_HP = MAX_HP;
        CURRENT_MANA = MAX_MANA;
    }


}
