using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossSkill : MonoBehaviour
{
//skills-----------------------------------------
    //First
    public GameObject FirstPattern;
    public GameObject FirstRange;
    public GameObject Ge;
    //Sec
    public GameObject SecondPattern;
    public GameObject SecondRange;
    public GameObject BossAttack;
    //Third
    public GameObject ThirdPattern;
    public GameObject ThirdRange;
    public GameObject ThirdAttack;
    public GameObject DamegeTh;
    //four
    public GameObject FourSkill;
    public GameObject FourRange;
    public GameObject fourAttack;
    //five
    public GameObject FiveSkill;
    public GameObject FiveRange;
    public Transform Player;
    public GameObject FiveGe;
    //------------------------------------------------
    // Start is called before the first frame update
    void Start()
    {
        FirstPattern.SetActive(false);
        SecondPattern.SetActive(false);
        ThirdPattern.SetActive(false);
        FourSkill.SetActive(false);
        int number = Random.Range(1, 6);
        if (Hp_bar_Boss.currenthp > 0)
        {
            if (number == 1)
            {
                FirstPattern.SetActive(true);
                Invoke("First", 2f);
            }
            if (number == 2)
            {
                SecondPattern.SetActive(true);
                Invoke("Sec", 2f);
            }
            if (number == 3)
            {
                ThirdPattern.SetActive(true);
                Invoke("Thrid", 2.5f);
            }
            if (number == 4)
            {
                FourSkill.SetActive(true);
                Invoke("four", 2f);
            }
            if(number == 5)
            {
                FiveSkill.SetActive(true);
                Invoke("Five", 2f);
            }
        }
        else if(Hp_bar_Boss.currenthp <= 0)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        FiveRange.transform.position = new Vector3(Player.position.x, Player.position.y, 0);
    }

    void First()
    {
       
            FirstRange.SetActive(false);
            Ge.SetActive(true);
           Invoke("nextScene", 20f);
        
    }
    void Sec()
    {
        
            SecondRange.SetActive(false);
            BossAttack.SetActive(true);
            Invoke("nextScene", 2f);
        
    }
    void Thrid()
    {
        Invoke("DamegeThrid", 1);
            ThirdRange.SetActive(false);
            ThirdAttack.SetActive(true);
            Invoke("nextScene", 1.5f);
        
    }
    void four()
    {
        
            FourRange.SetActive(false);
            fourAttack.SetActive(true);
            Invoke("nextScene", 0.3f);
        
    }

    void Five()
    {
        FiveGe.SetActive(true);
        Invoke("nextScene", 10f);
    }
    void nextScene()
    {
        SceneManager.LoadScene("map1_Boss_Stage_Battle_PlayerTurn");
        DamegeTh.SetActive(false);
    }

    void DamegeThrid()
    {
        DamegeTh.SetActive(true);
    }
}

