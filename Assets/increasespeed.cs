using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Timecounter : MonoBehaviour
{
    public static float currCountdownValue;
  
    // Use this for initialization
    void Start()
    {
        


        StartCoroutine(StartCountdown());
    }

    // Update is called once per frame
    void Update()
    {

        

        if (currCountdownValue == 1)
        {
            Debug.Log("End Of Game");
        }
    }
    public IEnumerator StartCountdown(float countdownValue = 60)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            Debug.Log("Countdown: " + currCountdownValue);
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
        }


    }


}
