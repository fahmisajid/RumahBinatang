using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTotalScore : MonoBehaviour
{
    // Start is called before the first frame update
   
   void FixedUpdate()
    {
        int TotalScore=0;
        
        //PlayerPrefs.SetInt("stage1", 3);
        for (int i = 0; i < 10; i++){
            TotalScore += PlayerPrefs.GetInt("stage" + i);
        }
        //Debug.Log(TotalScore);
        
        
        GetComponent<Text>().text = TotalScore.ToString("x 0");
    }
}
