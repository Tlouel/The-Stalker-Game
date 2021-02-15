using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject Light;
    public bool LightActive;

    public GameObject pressF;
    public bool Press;

    public AudioSource sound;
    public AudioClip clickOn;
    public AudioClip clickOff;

   
    void Start()
    {
        Light.SetActive(false);
        pressF.SetActive(true);
    
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            
            LightActive = !LightActive;

            if(LightActive)
            {
                FlashLightActive();
                sound.PlayOneShot(clickOn);
                pressF.SetActive(false);

                
            }

            if(!LightActive)
            {
                FlashLightInactive();
                sound.PlayOneShot(clickOff);
            }
            
        }
    }

    void FlashLightActive()
    {
        Light.SetActive(true);
        
    }
    void FlashLightInactive()
    {
        Light.SetActive(false);
    }
        
}
