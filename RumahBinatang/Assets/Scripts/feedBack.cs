using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feedBack : MonoBehaviour
{
    public GameObject buttonNext, winCanvas;
    public static bool selesai = false;
    public int stagePassed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void cek(){
        
        if (drag.on_tempel==true){
            selesai = true;
        }else{
            selesai = false;
        }
       
        if (selesai){
            //feedback canvas
            
            if(control.urutan < 2 ){
                buttonNext.SetActive (true);
            }
            if(control.urutan == 2){
                winCanvas.SetActive (true);
                PlayerPrefs.SetInt("stagePassed", stagePassed);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(!selesai){
            cek();
        }
    }
}
