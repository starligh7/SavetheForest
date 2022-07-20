using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstGameStart : MonoBehaviour
{
    public GameObject Infor_Panel;
    public GameObject Char_Panel;

    void Start()
    {
        Infor_Panel.SetActive(false);   
    }

    public void Gamego()
    {
        SceneManager.LoadScene("map1_move");
    }

    public void GameStartCharPanel()
    {
        Char_Panel.SetActive(true);
    }

    public void informationpanel()
    {
        Infor_Panel.SetActive(true);
    }

    public void InformationPanelOut()
    {
        Infor_Panel.SetActive(false);
    }

    public void AppOut()
    {
        Application.Quit();
    }
}
