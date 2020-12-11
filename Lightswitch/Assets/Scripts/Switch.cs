using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject dayTime, nightTime; //references to the day and nighttime gameobjects which i had to create and put the enemys as children

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
    {
            LightswitchOnOff(); //space to switch
            SoundScript.PlaySound(); // call the SoundScript to play the sound
        }
    }

    public void LightswitchOnOff()
    {
        if (dayTime.activeInHierarchy) //if daytime is active and we press, disable daytime and enable nighttime
        {
            dayTime.SetActive(false);
            nightTime.SetActive(true);
        }
        else //if daytime is inactive and we press, enable daytime and disable nighttime
        {
            dayTime.SetActive(true);
            nightTime.SetActive(false);
        }
    }

    //just copied that code from dannys gdd and hey, it worked

}
