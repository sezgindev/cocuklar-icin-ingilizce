using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobsVoice : MonoBehaviour {

    public AudioSource[] sesler = new AudioSource[23];
    int i = 0;
    int b = 0; // voice buttonu için değişken
    // Use this for initialization
    void Start()
    {
        sesler[0].volume = 1; //baslangıç sesi 
        sesler[0].Play();
    }

    public void ses()
    {
        sesler[i].volume = 1;   //ileri bastıkça çıkan ses
        sesler[i].Play();

    }
    public void yukselt()   //ileri basınca ses dizisini bir arttırır
    {
        i += 1;
        b += 1;
    }
    public void sesci()                 //geri basınca çıkan ses
    {
        sesler[i ].volume = 1;
        sesler[i ].Play();

    }
    public void sesazalt()      //geri basınca ses dizisini azalt
    {
        i -= 1;
        b -= 1;
    }
    public void voicebutton()
    {
        sesler[b].volume = 1;
        sesler[b].Play();
    }
}
