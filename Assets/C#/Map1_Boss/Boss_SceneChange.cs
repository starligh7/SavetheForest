using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss_SceneChange : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Invoke("sec3", 2.5f);
    }

    void sec3()
    {
        SceneManager.LoadScene("map1_Boss_Stage_Battle_PlayerTurn");
    }
}
