using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_HP : MonoBehaviour
{
    public Transform mob;
    public Slider hpbar;
    public static float maxHp = 50;
    public static float currenthp = maxHp;

    public GameObject PlayerDeathPanel;
    // �غκ��� ������Ʈĵ����, ���� ĵ���� ���� 
    public GameObject ObjectCanvas;
    public GameObject GameCanvas;

    void Start()
    {
       
    }

    void Update()
    {
        //transform.position = mob.position + new Vector3(0, 0, 0);
        hpbar.value = currenthp / maxHp;
        if(currenthp <= 0)
        {
            PlayerDeathPanel.SetActive(true);
            ObjectCanvas.SetActive(false);
            GameCanvas.SetActive(false);
            Time.timeScale = 0;
        }
    }
}