using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public int click;
    public GameObject Text1;
    public GameObject Text2;
    public Text mia;
    // Start is called before the first frame update
    void Start()
    {
        click = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            click++;
        }
        if(click == 0)
        {
            Text1.SetActive(true);
            Text2.SetActive(false);
        }
        if(click == 1)
        {
            Text1.SetActive(false);
            Text2.SetActive(true);
        }
        if(click == 2)
        {
            mia.text = "Game End....?";
        }
        if(click == 3)
        {
            SceneManager.LoadScene("GameStart");
        }
    }
}
