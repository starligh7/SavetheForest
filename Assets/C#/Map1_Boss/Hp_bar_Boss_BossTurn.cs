using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hp_bar_Boss_BossTurn : MonoBehaviour
{
    public Slider hpbar;


    void Update()
    {
        hpbar.value = Hp_bar_Boss.currenthp / Hp_bar_Boss.maxHp;
    }
}