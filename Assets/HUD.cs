using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour {

    public GUISkin layout;
    int[] currentscore = new int[] { 0, 0 };

    public void setscore(int[] score)
    {currentscore = score;

    }

    void Start()
    { }
    void OnGUI()
    {
        
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + currentscore[1]);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + currentscore[0]);

       
        }
    }
