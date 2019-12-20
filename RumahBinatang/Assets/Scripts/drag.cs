using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    public GameObject detector, pos_scale, parent;
    public Vector3 pos_awal, scale_awal;
    public static bool on_pos = false;
    public static bool  on_tempel = false;
    
    // Start is called before the first frame update
    void Start()
    {
        pos_awal = transform.position;
        scale_awal = transform.localScale;

    }

    void OnMouseDrag(){
        Vector3 pos_mouse = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));

        transform.position = new Vector3 (pos_mouse.x, pos_mouse.y, pos_awal.z);

        transform.localScale = new Vector2 (pos_scale.transform.localScale.x, pos_scale.transform.localScale.y);
    }
    void  OnMouseUp()
    {
        if(on_pos){
            transform.position = detector.transform.position;
            transform.localScale = new Vector2 (pos_scale.transform.localScale.x, pos_scale.transform.localScale.y);
            on_tempel = true;   
            parent.transform.GetChild (1).position = new Vector3 (pos_awal.x, pos_awal.y, 5f);//hilang
            parent.transform.GetChild (2).position = new Vector3 (pos_awal.x, pos_awal.y, 5f);//hilang
            parent.transform.GetChild (1).localScale = new Vector2 (0.1f, 0.1f);//hilang
            parent.transform.GetChild (2).localScale = new Vector2 (0.1f, 0.1f);//hilang
            
        }else{
            transform.position = pos_awal;
            transform.localScale = scale_awal;
            on_tempel = false;
 
            healthControl.health -=1;
        }
    }
    void OnTriggerStay2D(Collider2D objek)
    {
        if (objek.gameObject == detector){
            on_pos = true;
        }
    }
    void OnTriggerExit2D(Collider2D objek)
    {
        if (objek.gameObject == detector){
            on_pos = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
      
    }
}
