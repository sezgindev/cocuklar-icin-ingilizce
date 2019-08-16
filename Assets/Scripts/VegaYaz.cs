using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VegaYaz : MonoBehaviour
{
    public string[] VegaName = { "Cucumber","Cabbage","Garlic","Broccoli","Carrot","Eggplant","Lemon","Mushroom","Onion","Pea","Pepper","Potato",
    "Pumpkin","Radish","Tomato"};
    public string[] VegaNametr = { "Salatalık","Lahana","Sarımsak","Brokoli","Havuç","Patlıcan","Limon","Mantar","Soğan","Bezelye","Biber","Patates",
    "Kabak","Turp","Domates"};
    int a = 0;
    public Text VegaTxt;
    public Text VegatrText;


    void Update()
    {
        float x = Random.Range(2, 3);
        VegaTxt.text = VegaName[a];
        VegatrText.text = VegaNametr[a];
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