﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lives : MonoBehaviour {
    public static float life;
   



    void Start()
    {
        
        life = 4;

    }   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bounderies")
        {
            
            life--;
            Debug.Log(life);
            transform.position = new Vector3 (17,9,0);



        }


    }
}
