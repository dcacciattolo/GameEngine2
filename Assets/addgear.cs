using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addgear : MonoBehaviour
{
    public ParticleSystem Particles;
    private bool played;



    void OnTriggerEnter2D(Collider2D other)
    {

        Destroy(gameObject);
        gearcontroller.cogvalue++;
        Debug.Log(gearcontroller.cogvalue);
        played = true;

    }


    void Update()
    {
        if (!played)
        {
            Particles.Play();


        }
    }
}