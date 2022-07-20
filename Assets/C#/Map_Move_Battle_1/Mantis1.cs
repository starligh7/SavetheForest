using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mantis1 : MonoBehaviour
{
    void Start()
    {
       
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("map1_battle_Mantis1");
    }
    void Update()
    {
        if (Delete.MantisOn == false)
        {
            gameObject.SetActive(false);
            Player_HP.currenthp += 10;
        }
    }
}
