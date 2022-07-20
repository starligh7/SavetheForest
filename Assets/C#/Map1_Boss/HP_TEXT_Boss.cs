using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_TEXT_Boss : MonoBehaviour
{
    public Text HpText;
    void Update()
    {
        HpText.text = "HP " + Hp_bar_Boss.currenthp +"/"+ Hp_bar_Boss.maxHp; 
    }
}
