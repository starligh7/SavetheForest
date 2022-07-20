using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tree1 : MonoBehaviour
{
    void Start()
    {
       
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("map1_battle_Treemonster1");
    }
    void Update()
    {
        if (Delete.TreeOn == false)
        {
            gameObject.SetActive(false);
            Player_HP.currenthp += 10;
        }
    }
}
