﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    void Start()
    {
        Screen.SetResolution(PlayerPrefs.GetInt("Width", 1280), PlayerPrefs.GetInt("Height", 720), FullScreenMode.FullScreenWindow);
        int x = PlayerPrefs.GetInt("TATuSEEsRaRSx1rd0AADexrW7leKZGrqEs", 1);
        if (x == 1)
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.SetInt("TATuSEEsRaRSx1rd0AADexrW7leKZGrqEs", 0);
        }
    }
}