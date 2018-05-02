using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gearcontroller : MonoBehaviour
{

    public ParticleSystem Particles;
    public static int cogvalue = 0;
    private bool played;

    void Start()
    {
       



    }

    void Update()
    {
        if (!played)
        {
            Particles.Play();
          

        }

    }


    void OnTriggerEnter2D(Collider2D cog)

    {
        if (cog.tag == "Player") {
            
            Explode();
            
        }
       

    }
   

    void Explode()
    {


        cogvalue++;
        Debug.Log(cogvalue);
        played = true;
        Destroy(gameObject);
        


    }



}
