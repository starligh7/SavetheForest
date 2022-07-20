using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonTreemonster : MonoBehaviour
{
    public GameObject EnemySelect;
    public GameObject Selbu;
    public GameObject Gobu;

    //플레이어
    public int Playerultimate;
    public GameObject NOSkill;
    public int def = 0;
    //애니메이션
    public Animator anim;
    public static bool FS;
    public static bool SS;
    public static bool TS;
    public static bool FourS;

    //상대 턴
    public GameObject GameCanvas;
    public GameObject EnemyTurnCanvas;
    public GameObject TreeAttackText;
    public Text TreeAttacklog;
    public int Treeultimate;

    void Awake()
    {

    }

    void Start()
    {
        Treeultimate = 0;
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
            def = 3;
            FS = true;
            Invoke("RERE", 1f);
        }
        if (AtkButton.a2 > 0)
        {
            def = 11;
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
        GameCanvas.SetActive(false);
        EnemyTurnCanvas.SetActive(true);
        TreeAttackText.SetActive(false);
        Invoke("EnemySkill", 0.1f);
        Invoke("GameCanvasOn", 3);
    }

    void Restart()
    {
        AtkButton.a1 = 0;
        AtkButton.a2 = 0;
        AtkButton.a3 = 0;
        AtkButton.a4 = 0;
        def = 0;
        Selbu.SetActive(true);
        Gobu.SetActive(false);
    }

    public void DeathRePlayButton()
    {
        SceneManager.LoadScene("map1_move");
    }

    void GameCanvasOn()
    {
        GameCanvas.SetActive(true);
        EnemyTurnCanvas.SetActive(false);

    }

    void NOskilloff()
    {
        NOSkill.SetActive(false);
    }

    void EnemySkill()
    {
        if (Hp_barTreeMonster.currenthp > 0)
        {
            TreeAttackText.SetActive(true);
            int number;
            number = Random.Range(0, 4);
            if (number == 0)
            {
                if (def > 5)
                {
                    Player_HP.currenthp -= 0;
                    anim.SetBool("SS", true);
                    Invoke("ss", 0.25f);
                }
                else if (def < 5)
                {
                    Player_HP.currenthp -= (5 - def);
                    anim.SetBool("SS", true);
                    Invoke("ss", 0.25f);
                }
                TreeAttacklog.text = "바닥에서 뿌리가 올라왔다! (체력 -5)\n" + "나의 현재 체력 : " + Player_HP.currenthp;
            }
            if (number == 1)
            {
                if (def > 6)
                {
                    Player_HP.currenthp -= 0;
                    anim.SetBool("SS", true);
                    Invoke("ss", 0.25f);
                }
                else if (def < 6)
                {
                    Player_HP.currenthp -= (6 - def);
                    anim.SetBool("SS", true);
                    Invoke("ss", 0.25f);
                }
                TreeAttacklog.text = "나무괴물이 몸통 박치기를 시전했다! (체력 -6)\n" + "나의 현재 체력 : " + Player_HP.currenthp;
            }
            if (number == 2)
            {
                Hp_barTreeMonster.currenthp += 5;
                TreeAttacklog.text = "나무괴물이 자신의 열매를 섭취했다! (나무괴물 체력 +5)\n" + "나의 현재 체력 : " + Player_HP.currenthp;
            }
            if (number == 3)
            {
                if (Treeultimate < 1)
                {
                    if (def > 15)
                    {
                        Player_HP.currenthp -= 0;
                        anim.SetBool("SS", true);
                        Invoke("ss", 0.25f);
                    }
                    else if (def < 15)
                    {
                        Player_HP.currenthp -= (15 - def);
                        anim.SetBool("SS", true);
                        Invoke("ss", 0.25f);
                    }
                    TreeAttacklog.text = "나무괴물이 나뭇가지를 휘둘러 극심한 피해를 입혔다!(궁극기) (체력 -15)\n" + "나의 현재 체력 : " + Player_HP.currenthp;
                    Treeultimate++;
                }
            }
        }
    }

    void RERE()
    {
        Restart();
        EnemyTurn();
    }

    void fs()
    {
        anim.SetBool("FS", false);
        Hp_barTreeMonster.currenthp -= 4f;
    }
    void ss()
    {
        anim.SetBool("SS", false);
    }
    void ts()
    {
        anim.SetBool("TS", false);
        Hp_barTreeMonster.currenthp -= 7f;
    }
    void fours()
    {
        anim.SetBool("FouSkill", false);
        Hp_barTreeMonster.currenthp -= 10f;
    }
}