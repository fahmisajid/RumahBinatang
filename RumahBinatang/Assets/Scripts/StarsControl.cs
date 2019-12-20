using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsControl : MonoBehaviour
{
    public GameObject star1, star2, star3;

    public static int score, highscore;
    public string stageText;
    // Start is called before the first frame update
    void Start()
    {
        score = healthControl.health;
    }
    public void saveScore(int highscore){
        
    }
    // Update is called once per frame
    void Update()
    {
        if (score >3)
            score = 3;

        switch (score){
            case 3:
            star1.gameObject.SetActive (true);
            star2.gameObject.SetActive (true);
            star3.gameObject.SetActive (true);
            break;
            case 2:
            star1.gameObject.SetActive (true);
            star2.gameObject.SetActive (true);
            star3.gameObject.SetActive (false);
            break;
            case 1:
            star1.gameObject.SetActive (true);
            star2.gameObject.SetActive (false);
            star3.gameObject.SetActive (false);
            break;
            case 0:
            star1.gameObject.SetActive (false);
            star2.gameObject.SetActive (false);
            star3.gameObject.SetActive (false);
            
            break;
        }
        highscore = score;
        PlayerPrefs.SetInt(stageText, highscore);
        
    }
}
