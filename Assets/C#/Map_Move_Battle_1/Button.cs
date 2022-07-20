using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject EnemySelect;
    public GameObject Selbu;
    public GameObject Gobu;

    //�÷��̾�
    public int Playerultimate;
    public GameObject NOSkill;
    public int def = 0;
    //�ִϸ��̼�
    public Animator anim;
    public static bool FS;
    public static bool SS;
    public static bool TS;
    public static bool FourS;

    //��� ��
    public GameObject GameCanvas;
    public GameObject EnemyTurnCanvas;
    public GameObject SlimeAttackText;
    public Text SlimeAttacklog;
    public int slimeultimate;

    void Awake()
    {
        
    }

    void Start()
    {
        slimeultimate = 0;
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
        SlimeAttackText.SetActive(false);
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
        if (Hp_barSlime.currenthp > 0)
        {

            SlimeAttackText.SetActive(true);
            int number;
            number = Random.Range(0, 4);
            if (number == 0)
            {
                if(def > 4)
                {
                    Player_HP.currenthp -= 0;
                    anim.SetBool("SS", true);
                    Invoke("ss", 0.25f);
                }
                else if(def < 4)
                {
                    Player_HP.currenthp -= (4 - def);
                    anim.SetBool("SS", true);
                    Invoke("ss", 0.25f);
                }
                SlimeAttacklog.text = "�������� ���� Ƣ�� �ö� �÷��̾ ���ƴ�! (ü�� -4)\n" + "���� ���� ü�� : " + Player_HP.currenthp;
            }
            if (number == 1)
            {
                if (def > 5)
                {
                    Player_HP.currenthp -= 0;
                    anim.SetBool("SS", true);
                    Invoke("ss", 0.25f);
                }
                else if (def < 5)
                {
                    Player_HP.currenthp -= (4 - def);
                    anim.SetBool("SS", true);
                    Invoke("ss", 0.25f);
                }
                SlimeAttacklog.text = "�������� �ڽ��� ���� �и��ؼ� �÷��̾�� ������! (ü�� -5)\n" + "���� ���� ü�� : " + Player_HP.currenthp;
            }
            if (number == 2)
            {
                Hp_barSlime.currenthp += 5;
                SlimeAttacklog.text = "�������� ������ ���� �ڽŵ��� ������ �Ծ� ü���� ȸ���ߴ� (������ ü�� +5)\n" + "���� ���� ü�� : " + Player_HP.currenthp;
            }
            if (number == 3)
            {
                if (slimeultimate < 1)
                {
                    if (def > 10)
                    {
                        Player_HP.currenthp -= 0;
                        anim.SetBool("SS", true);
                        Invoke("ss", 0.25f);
                    }
                    else if (def < 10)
                    {
                        Player_HP.currenthp -= (10 - def);
                        anim.SetBool("SS", true);
                        Invoke("ss", 0.25f);
                    }
                    SlimeAttacklog.text = "�������� ���� �پ�ö� �÷��̾ ��ƹ��ڴ�!(�ñر�) (ü�� -10)\n" + "���� ���� ü�� : " + Player_HP.currenthp;
                    slimeultimate++;
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
       Hp_barSlime.currenthp -= 4f;
   }
   void ss()
   {
       anim.SetBool("SS", false);
   }
   void ts()
   {
       anim.SetBool("TS", false);
       Hp_barSlime.currenthp -= 7f;
   }
   void fours()
   {
       anim.SetBool("FouSkill", false);
       Hp_barSlime.currenthp -= 10f;
   }
}