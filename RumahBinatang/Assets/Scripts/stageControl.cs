using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stageControl : MonoBehaviour
{
    public Button stage1, stage2, stage3, stage4, stage5, stage6, stage7, stage8, stage9;
    int stagePassed;
    // Start is called before the first frame update
    void Start()
    {
        stagePassed = PlayerPrefs.GetInt("stagePassed");
        stage2.interactable = false;
        stage3.interactable = false;
        stage4.interactable = false;
        stage5.interactable = false;
        stage6.interactable = false;   
        stage7.interactable = false;  
        stage8.interactable = false; 
        stage9.interactable = false; 

        switch (stagePassed){
            case 2:
                stage2.interactable = true;   
                break;
            case 3:
                stage2.interactable = true;
                stage3.interactable = true;
                break;
            case 4:
                stage2.interactable = true;
                stage3.interactable = true;
                stage4.interactable = true;   
                break;
            case 5:
                stage2.interactable = true;
                stage3.interactable = true;
                stage4.interactable = true;
                stage5.interactable = true;
                break;
            case 6:
                stage2.interactable = true;
                stage3.interactable = true;
                stage4.interactable = true;
                stage5.interactable = true;
                stage6.interactable = true;   
                break;
            case 7:
                stage2.interactable = true;
                stage3.interactable = true;
                stage4.interactable = true;
                stage5.interactable = true;
                stage6.interactable = true;   
                stage7.interactable = true;   
                break;
            case 8:
                stage2.interactable = true;
                stage3.interactable = true;
                stage4.interactable = true;
                stage5.interactable = true;
                stage6.interactable = true;   
                stage7.interactable = true;  
                stage8.interactable = true; 
                break;        
            case 9:
                stage2.interactable = true;
                stage3.interactable = true;
                stage4.interactable = true;
                stage5.interactable = true;
                stage6.interactable = true;   
                stage7.interactable = true;  
                stage8.interactable = true; 
                stage9.interactable = true; 
                break;    
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
