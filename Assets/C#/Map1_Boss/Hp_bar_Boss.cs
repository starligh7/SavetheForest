using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hp_bar_Boss : MonoBehaviour
{
    public Transform Dragon;
    public GameObject GameClearPanel;
    public Slider hpbar;
    public static float maxHp = 210;
    public static float currenthp = maxHp;

    void Update()
    {
       // transform.position = mob.position + new Vector3(0, 0, 0);
        hpbar.value = currenthp / maxHp;
        if(currenthp <= 0)
        {
            SceneManager.LoadScene("GameClearEnding");
        }
    }
}