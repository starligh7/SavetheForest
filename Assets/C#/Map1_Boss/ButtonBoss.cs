using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonBoss : MonoBehaviour
{
    public GameObject EnemySelect;
    public GameObject Selbu;
    public GameObject Gobu;

    //플레이어
    public int Playerultimate;
    public GameObject NOSkill;
    public static bool barrierOn = false;
    //애니메이션
    public Animator anim;
    public static bool FS;
    public static bool SS;
    public static bool TS;
    public static bool FourS;


    void Awake()
    {

    }

    void Start()
    {
        Playerultimate = 0;
        FS = false;
        SS = false;
        TS = false;
        FourS = false;
    }

    public void EnemySelectButton()
    {
        EnemySelect.SetActive(true);
    }
    public void EnemySelectButtonok()
    {
        Skill_Count.skillcount = Skill_Count.maxcount;
        EnemySelect.SetActive(false);
        Selbu.SetActive(false);
        Gobu.SetActive(true);
    }
    public void GO()
    {
        if (AtkButton.a1 > 0)
        {
            anim.SetBool("FS", true);
            Invoke("fs", 0.25f);
            barrierOn = true;
            FS = true;
            Invoke("RERE", 1f);
        }
        if (AtkButton.a2 > 0)
        {
            barrierOn = true;
            Invoke("RERE", 1f);
        }
        if (AtkButton.a3 > 0)
        {
            anim.SetBool("TS", true);
            Invoke("ts", 0.6f);
            TS = true;
            Invoke("RERE", 1f);
        }
        if (AtkButton.a4 > 0)
        {

            if (Playerultimate < 1)
            {
                anim.SetBool("FouSkill", true);
                Invoke("fours", 0.5f);
                Playerultimate++;
                FourS = true;
                Invoke("RERE", 1f);
            }
            else
            {
                NOSkill.SetActive(true);
                Invoke("NOskilloff", 1f);
                Skill_Count.skillcount = 1;
                Selbu.SetActive(false);
                Gobu.SetActive(true);
            }
        }
    }
    void EnemyTurn()
    {
        SceneManager.LoadScene("map1_Boss_Stage_Battle_BossTurn");
    }

    void Restart()
    {
        AtkButton.a1 = 0;
        AtkButton.a2 = 0;
        AtkButton.a3 = 0;
        AtkButton.a4 = 0;
        Selbu.SetActive(true);
        Gobu.SetActive(false);
    }

    public void DeathRePlayButton()
    {
        SceneManager.LoadScene("map1_Boss_Stage_move");
    }

    void NOskilloff()
    {
        NOSkill.SetActive(false);
    }

    void RERE()
    {
        Restart();
        EnemyTurn();
    }

    void fs()
    {
        anim.SetBool("FS", false);
        Hp_bar_Boss.currenthp -= 4f;
    }
    //void ss()
    //{
    //    anim.SetBool("SS", false);
    //}
    void ts()
    {
        anim.SetBool("TS", false);
        Hp_bar_Boss.currenthp -= 7f;
    }
    void fours()
    {
        anim.SetBool("FouSkill", false);
        Hp_bar_Boss.currenthp -= 10f;
    }
}