using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_TEXT : MonoBehaviour
{
    public Text HpText;
    void Update()
    {
        HpText.text = "HP " + Hp_barSlime.currenthp +"/"+ Hp_barSlime.maxHp; 
    }
}
