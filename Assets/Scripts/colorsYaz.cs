using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class colorsYaz : MonoBehaviour {

    int a = 0;
    
    public Text xyz;
    
    public string[] colorsname = { "Black","Pink","Blue","Brown","Green","Grey","Orange","Yellow","Purple","Red","White"};
   
    void Start()
    {
        xyz.text = colorsname[a];
       
    }

    // Update is called once per frame
    void Update()
    {
        xyz.text = colorsname[a];
     
    }
    public void arttırmacık()
    {
        a += 1;
       
    }
    public void eksiltmecik()
    {
        a -= 1;
  
    }
}
