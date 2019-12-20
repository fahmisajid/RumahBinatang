using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    public GameObject parent_puzzle, buttonNext, losebt;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseUp(){
    
    losebt.SetActive(false);
    //drag.on_tempel = false;
    //drag.on_pos = false;
    //parent_puzzle.transform.GetChild (0).position = parent_puzzle.transform.GetChild (0).GetComponent<drag>().pos_awal;
    //parent_puzzle.transform.GetChild (0).localScale = parent_puzzle.transform.GetChild (0).GetComponent<drag>().scale_awal;  
    
    //feedBack.selesai = false;
    //buttonNext.SetActive (false);
    //for (int i = 1; i < parent_puzzle.transform.childCount; i++){
    //        parent_puzzle.transform.GetChild (i).gameObject.SetActive (false);
    //    }
    //parent_puzzle.transform.GetChild (0).gameObject.SetActive (false);
    
    
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
