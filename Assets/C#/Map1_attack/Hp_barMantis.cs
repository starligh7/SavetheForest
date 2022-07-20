using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hp_barMantis : MonoBehaviour
{
    public Transform mob;
    public Slider hpbar;
    public static float maxHp;
    public static float currenthp;
    public GameObject Death;

    void Start()
    {
        maxHp = 20;
        currenthp = maxHp;
    }

    void Update()
    {
        hpbar.value = currenthp / maxHp;
        if(currenthp <= 0)
        {
            Delete.MantisOn = false;
            Death.SetActive(true);
        }
    }
}