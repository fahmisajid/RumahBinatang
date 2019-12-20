using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
     public GameObject parent_puzzle,losebt;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseUp(){
    Debug.Log("EXIT");
    drag.on_tempel = false;
    drag.on_pos = false;
    parent_puzzle.transform.GetChild (0).position = parent_puzzle.transform.GetChild (0).GetComponent<drag>().pos_awal;
    parent_puzzle.transform.GetChild (0).localScale = parent_puzzle.transform.GetChild (0).GetComponent<drag>().scale_awal;  
    losebt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
