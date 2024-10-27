using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
    public GameObject HudShooter;
    public GameObject LosePanel;
    public void Lose() 
    { 
            LosePanel.SetActive(true);
            HudShooter.SetActive(false);
            Time.timeScale = 0f;
    }
}
