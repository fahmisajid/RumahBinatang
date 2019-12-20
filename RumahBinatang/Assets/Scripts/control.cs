using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public GameObject parent, buttonNext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static int urutan = 0;
    public void aktif(int a){
        urutan +=a;
        
        if (urutan < 3){
            buttonNext.SetActive (false);
            drag.on_tempel = false;
            feedBack.selesai = false;
        }
        
        for (int i = 0; i < parent.transform.childCount; i++){
            parent.transform.GetChild (i).gameObject.SetActive (false);
        }
        parent.transform.GetChild (urutan).gameObject.SetActive (true);
        
    }
    void OnMouseUp(){   
        if (gameObject.name == "next"){
            aktif (1);
        }else
        {
            aktif(-1);
        }
    }   
    // Update is called once per frame
    void Update()
    {
        
    }
}
