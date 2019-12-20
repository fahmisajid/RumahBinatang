using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class halamanManager : MonoBehaviour
{
    public string nameScenes;
    public Button btnstage1, btnstage2, btnstage3, btnstage4, btnstage5, btnstage6, btnstage7, btnstage8, btnstage9;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MainMenu(){
        SceneManager.LoadScene ("MainMenu");
        //Debug.Log("Scene MainMenu");
    }
    public void reset () {
        for (int i = 0; i < 10; i++){   
            PlayerPrefs.SetInt("stage" + i, 0);
        }
        btnstage2.interactable = false;
        btnstage3.interactable = false;
        btnstage4.interactable = false;
        btnstage5.interactable = false;
        btnstage6.interactable = false;   
        btnstage7.interactable = false;  
        btnstage8.interactable = false; 
        btnstage9.interactable = false; 
    }
    public void NexttoMapMenu(){
        SceneManager.LoadScene ("MapMode");
        //Debug.Log("Scene Map Mode");
        
    }
    public void DeletePrefs(){
        PlayerPrefs.DeleteAll();
    }
    public void stage1(){
        SceneManager.LoadScene ("Stage1");
        //Debug.Log("Stage 1");
        control.urutan=0;
        feedBack.selesai = false;
        drag.on_pos =false;
        drag.on_tempel=false;
    }
    public void stage2(){
        SceneManager.LoadScene ("Stage2");
        control.urutan=0;
        feedBack.selesai = false;
        drag.on_pos =false;
        drag.on_tempel=false;
    }
    public void stage3(){
        SceneManager.LoadScene ("Stage3");
        control.urutan=0;
        feedBack.selesai = false;
        drag.on_pos =false;
        drag.on_tempel=false;
    }
     public void stage4(){
        SceneManager.LoadScene ("Stage4");
        control.urutan=0;
        feedBack.selesai = false;
        drag.on_pos =false;
        drag.on_tempel=false;
    }
     public void stage5(){
        SceneManager.LoadScene ("Stage5");
        control.urutan=0;
        feedBack.selesai = false;
        drag.on_pos =false;
        drag.on_tempel=false;
    }
     public void stage6(){
        SceneManager.LoadScene ("Stage6");
        control.urutan=0;
        feedBack.selesai = false;
        drag.on_pos =false;
        drag.on_tempel=false;
    }
     public void stage7(){
        SceneManager.LoadScene ("Stage7");
        control.urutan=0;
        feedBack.selesai = false;
        drag.on_pos =false;
        drag.on_tempel=false;
    }
     public void stage8(){
        SceneManager.LoadScene ("Stage8");
        control.urutan=0;
        feedBack.selesai = false;
        drag.on_pos =false;
        drag.on_tempel=false;
    }
     public void stage9(){
        SceneManager.LoadScene ("Stage9");
        control.urutan=0;
        feedBack.selesai = false;
        drag.on_pos =false;
        drag.on_tempel=false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
