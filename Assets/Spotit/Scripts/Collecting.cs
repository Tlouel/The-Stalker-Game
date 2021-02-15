using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collecting : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip collected;
    
   
   void OnTriggerEnter(Collider other) 
   {
       Score.theScore += 1;
       sound.PlayOneShot(collected);
       
       Destroy(gameObject);
   }

}
