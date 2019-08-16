using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class animyaz : MonoBehaviour {
   public string[] hayvanname = { "Rabbit","Mouse","Lion","Snake","Squirrel","Elephant","Tiger","Bear","Bird","Camel","Cat","Chicken",
    "Cow","Dog","Donkey","Duck","Fish","Goat"," Horse","Monkey","Parrot","Sheep", "Turtle"};
    int a = 0;
    public Text anik;

    

	void Update () {
        float x = Random.Range(2, 3);
        anik.text = hayvanname[a];
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
