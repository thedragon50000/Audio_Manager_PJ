﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboradControl : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //todo: 用Enum來代替字串
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // 1.string
            // AudioManager.inst.PlayBGM("Lobby_Main");

            //2.enum to string
            AudioManager.inst.PlayBGM(E_BGM.Lobby_Main.ToString());

            //3.enum
            E_BGM temp = E_BGM.Lobby_Main;
            AudioManager.inst.PlayBGM(temp.ToString());
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            AudioManager.inst.PlayBGM("Game_DT");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            AudioManager.inst.PlaySFX("Btn_01");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            AudioManager.inst.PlaySFX("Btn_02");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            AudioManager.inst.BGMStop();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            AudioManager.inst.SFXStop();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            AudioManager.inst.BGMReset(1);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            AudioManager.inst.SFXReset(1);
        }
    }

    public enum E_BGM
    {
        Lobby_Main,
        Game_DT
    }
}