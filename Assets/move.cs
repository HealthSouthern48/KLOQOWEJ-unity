using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public float moveSpeed = 10f;
    // Use this for initialization
    void Start () {
   
    }
   
    // Update is called once per frame
    void Update ()
    {
    if(Input.GetKey(KeyCode.LeftArrow)){ // move the object if the .{key} is pressed

        //Moves left (says right bc mirrored view)
            this.transform.Translate(Vector3.right * moveSpeed *Time.deltaTime);  

    }

    if(Input.GetKey(KeyCode.RightArrow)){ // move the object if the .{key} is pressed

        //Moves right (says left bc mirrored view)
            this.transform.Translate(Vector3.left * moveSpeed *Time.deltaTime);  
    }
    }
}
