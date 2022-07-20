using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_TEXT_Mantis : MonoBehaviour
{
    public Text HpText;
    void Update()
    {
        HpText.text = "HP " + Hp_barMantis.currenthp +"/"+ Hp_barMantis.maxHp; 
    }
}
