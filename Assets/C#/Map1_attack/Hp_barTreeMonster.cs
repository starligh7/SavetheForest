using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hp_barTreeMonster : MonoBehaviour
{
    public Transform mob;
    public Slider hpbar;
    public static float maxHp;
    public static float currenthp;
    public GameObject Death;

    void Start()
    {
        maxHp = 40;
        currenthp = maxHp;
    }

    void Update()
    {
       // transform.position = mob.position + new Vector3(0, 0, 0);
        hpbar.value = currenthp / maxHp;
        if(currenthp <= 0)
        {
            Delete.TreeOn = false;
            Death.SetActive(true);
        }
    }
}