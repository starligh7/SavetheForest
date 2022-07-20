using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Slime1 : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("map1_battle_Slime1");
    }
    void Update()
    {
        if(Delete.SlimeOn == false)
        {
            gameObject.SetActive(false);
            Player_HP.currenthp += 10;
        }
    }
}
