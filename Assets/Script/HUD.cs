using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Transform spawnBullet;
    public GameObject miraUI;


    void Update()
    {
        scoreText.text = GlobalVariables.score.ToString();

        Vector2 posScreen = Camera.main.WorldToScreenPoint(spawnBullet.position);
        Vector2 posCenterScreen = new Vector2(Screen.width/2, Screen.height/2);
        Vector2 posMira = posCenterScreen - posScreen;

        if (spawnBullet != null) miraUI.transform.position = posMira; 
    }
}
