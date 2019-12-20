using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsControlButton : MonoBehaviour
{
    public GameObject star1, star2, star3;

    public static int highscore;
    public string stageText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        highscore = PlayerPrefs.GetInt(stageText);
        if (highscore >3)
            highscore = 3;

        switch (highscore){
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
        
        
        
    }
}
