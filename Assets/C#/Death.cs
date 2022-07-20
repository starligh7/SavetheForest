using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public void DeathPlayer()
    {
        Time.timeScale = 1f;
        Player_HP.currenthp = Player_HP.maxHp;
        Hp_bar_Boss.currenthp = Hp_bar_Boss.maxHp;
        SceneManager.LoadScene("map1_Boss_Stage_move");
        
    }
    
}
