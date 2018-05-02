using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Timecounter2 : MonoBehaviour
{
    public static float currCountdownValue;
    private Slider SliderTime;
    // Use this for initialization
    void Start()
    {
        SliderTime = GetComponent<Slider>();
        

        StartCoroutine(StartCountdown());
    }

    // Update is called once per frame
    void Update()
    {
        
        SliderTime.value = currCountdownValue;

        while (currCountdownValue == 1)
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
    