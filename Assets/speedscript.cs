using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedscript : MonoBehaviour
{
    public static float speedcount;
  public bool active = false;

    // Use this for initialization
    void Start()
    {

        StartCoroutine(countdown());

    }

    // Update is called once per frame
    void Update()
    {
         if (active)
         {
        speedcount--;
         }
    }


    public IEnumerator countdown(float speedtime = 4)
    {
        speedcount = speedtime;
        while (speedcount > 0)
        {
            Debug.Log("xyz: " + speedcount);
            yield return new WaitForSeconds(1.0f);
            speedtime--;
           
        }


    }




    void OnTriggerEnter2D(Collider2D other)
    {
       active = true;
        Debug.Log(speedcount);
        Destroy(gameObject);
    }



}
