using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveScrip : MonoBehaviour
{   
    public Rigidbody2D rig;
    public float locationDown;
    public float locationUp;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) == true){
            rig.velocity = Vector2.up *5;
        }
        if(Input.GetKey(KeyCode.RightArrow) == true){
            rig.velocity = Vector2.right *5;
        }
        if(Input.GetKey(KeyCode.LeftArrow) == true){
            rig.velocity = Vector2.left *5;
        }
        
        if(Input.GetKeyDown(KeyCode.DownArrow)== true){
            transform.localScale = new Vector2 (1,2);
            transform.position += new Vector3 (0,locationDown,0);
        }
        if(Input.GetKeyUp(KeyCode.DownArrow)== true){
            transform.localScale = new Vector2 (1,3);
            transform.position -= new Vector3 (0,locationUp,0);
        }
    }
}
