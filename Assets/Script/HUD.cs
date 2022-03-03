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
        if(spawnBullet != null) miraUI.transform.position = Camera.main.WorldToScreenPoint(spawnBullet.position);
    }
}
