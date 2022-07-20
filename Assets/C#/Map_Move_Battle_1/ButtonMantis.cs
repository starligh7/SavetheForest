using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonMantis : MonoBehaviour
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
    public GameObject MantisAttackText;
    public Text MantisAttacklog;
    public int Mantisultimate;

    void Awake()
    {

    }

    void Start()
    {
        Mantisultimate = 0;
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
        MantisAttackText.SetActive(false);
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
        if (Hp_barMantis.currenthp > 0)
        {
            MantisAttackText.SetActive(true);
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
                MantisAttacklog.text = "�縶�Ͱ� ��ī�ο� Į���� �����ߴ�! (ü�� -5)\n" + "���� ���� ü�� : " + Player_HP.currenthp;
            }
            if (number == 1)
            {
                if (def > 8)
                {
                    Player_HP.currenthp -= 0;
                    anim.SetBool("SS", true);
                    Invoke("ss", 0.25f);
                }
                else if (def < 8)
                {
                    Player_HP.currenthp -= (8 - def);
                    anim.SetBool("SS", true);
                    Invoke("ss", 0.25f);
                }
                MantisAttacklog.text = "�縶�Ͱ� �糯�� ġ�ѵ�� �޷������! (ü�� -8)\n" + "���� ���� ü�� : " + Player_HP.currenthp;
            }
            if (number == 2)
            {
                if (def > 9)
                {
                    Player_HP.currenthp -= 0;
                    anim.SetBool("SS", true);
                    Invoke("ss", 0.25f);
                }
                else if (def < 9)
                {
                    Player_HP.currenthp -= (9 - def);
                    anim.SetBool("SS", true);
                    Invoke("ss", 0.25f);
                }
                MantisAttacklog.text = "�縶�Ͱ� ���ƿ����� �÷��̾ ���ƴ�! (ü�� -9)\n" + "���� ���� ü�� : " + Player_HP.currenthp;
            }
            if (number == 3)
            {
                if (Mantisultimate < 1)
                {
                    if (def > 13)
                    {
                        Player_HP.currenthp -= 0;
                        anim.SetBool("SS", true);
                        Invoke("ss", 0.25f);
                    }
                    else if (def < 13)
                    {
                        Player_HP.currenthp -= (13 - def);
                        anim.SetBool("SS", true);
                        Invoke("ss", 0.25f);
                    }
                    MantisAttacklog.text = "�縶�Ͱ� ��ī�ο� Į���� ���� �ֵθ���! (�ñر�) (ü�� -13)\n" + "���� ���� ü�� : " + Player_HP.currenthp;
                    Mantisultimate++;
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
        Hp_barMantis.currenthp -= 4f;
    }
    void ss()
    {
        anim.SetBool("SS", false);
    }
    void ts()
    {
        anim.SetBool("TS", false);
        Hp_barMantis.currenthp -= 7f;
    }
    void fours()
    {
        anim.SetBool("FouSkill", false);
        Hp_barMantis.currenthp -= 10f;
    }
}