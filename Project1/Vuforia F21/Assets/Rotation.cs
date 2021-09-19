using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float angle = 0.0f;
    private float rotationAmount = 0.0f;
    bool m_play;
    bool toogle; 

    AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
          
            if(transform.localEulerAngles.z< 180 && transform.localEulerAngles.z > 169){
                audioSource.Play();
            }
            
            
            
           
        
      
    }
}
