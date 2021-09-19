using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class changeText : MonoBehaviour
{
    public TextMeshPro m_object;
    private System.Random rand;
    public String[] array; 
    public bool Case;
    // Start is called before the first frame update
    void Start()
    {
        m_object = GetComponent<TextMeshPro>();
        transform.SetParent(transform);
        rand = new System.Random();
        array = new String[20];
        array[0] = "It is Certain";
        array[1] = "It is decidedly so";
        array[2] = "Without a doubt";
        array[3] = "Yes definitely";
        array[4] = "You may rely on it";
        array[5] = "As I see it, yes";
        array[6] = "Most likely";
        array[7] = "OutLook Good";
        array[8] = "Yes";
        array[9] = "Signs point to yes";
        array[10] = "Reply hazy, try again";
        array[11] = "Ask again later";
        array[12] = "Better not tell you now";
        array[13] = "Cannot predict now";
        array[14] = "Concentrate and ask again";
        array[15] = "Don't count on it";
        array[16] = "My reply is no ";
        array[17] = "My sources say no";
        array[18] = "Outlook not so good";
        array[19] = "Very doubtful";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.parent.localEulerAngles.z);
        Debug.Log(Case);
        if((transform.parent.localEulerAngles.z > 0 && transform.parent.localEulerAngles.z <5) || (transform.parent.localEulerAngles.z >350)){
            if(Case){
                var next = rand.Next(0,19);
                m_object.SetText(array[next]);
                Case = false; 
            }
        }
        if(transform.parent.localEulerAngles.z< 180 && transform.parent.localEulerAngles.z > 169){
                Case = true; 
            }
    }
}
