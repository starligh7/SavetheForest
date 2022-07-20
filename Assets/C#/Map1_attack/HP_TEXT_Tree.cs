using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_TEXT_Tree : MonoBehaviour
{
    public Text HpText;
    void Update()
    {
        HpText.text = "HP " + Hp_barTreeMonster.currenthp +"/"+ Hp_barTreeMonster.maxHp; 
    }
}
