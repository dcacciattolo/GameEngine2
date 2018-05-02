using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{

    public ParticleSystem Particles;
    private bool played;


    void Update()
    {
        if (!played)
        {
            Particles.Play();


        }
    }

    void OnTriggerEnter2D(Collider2D other)

    {
        played = true;
        Debug.Log("Yo IM A TRIGGER");
        Destroy(gameObject);
        Timecounter2.currCountdownValue -=4;

        
    }
}

