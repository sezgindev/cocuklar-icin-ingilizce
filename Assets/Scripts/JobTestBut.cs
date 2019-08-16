using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class JobTestBut : MonoBehaviour {
    public Text but1;
    public Text but2;
    public Text but3;
    public Text truetext,falsetext;
    public Button b1, b2, b3,b4,b5;
    private ColorBlock theColor;
    int d = 0;
    public int i;
    public  GameObject truePng;
    public  GameObject falsePng;
    int trueVar=0, falseVar=0;
    
    public String [] jobjob={"Driver", "Fireman", "Musician", "Pilot", "Farmer", "Police","Postman", "Scientist", "Gardener", "Soldier",
        "Veterinary", "Baker", "Carpenter", "Cook","Dentist", "Doctor", "Engineer", "Fisherman", "Hairdresser", "Judge", "Lawyer", "Nurse",
        "Teacher", "Photographer", "Painter", "Singer", "Tailor", "Architect","finalss"};

     void Start()
    {
        rndbuttontext();
          
    }


   public void rndbuttontext()
    {
        int x = Random.Range(0, 27);
        while (x == d)
        {
            x = Random.Range(0, 27);
        }
        int y = Random.Range(0, 27);
        while (x == y)
        {
             y = Random.Range(0, 27);
        }
        while (y == d)
        {
            y = Random.Range(0, 27);
        }

        //dogru cevabı random bi texte attık
         i = Random.Range(1,4);
        switch (i)
        {
            case 1:
                but1.text = jobjob[d];      //a buttonunda dogru cevap
                but2.text = jobjob[x];
                but3.text = jobjob[y];
                break;
            case 2:
                but2.text = jobjob[d];      //b buttonunda 
                but1.text = jobjob[x];
                but3.text = jobjob[y];
                break;
            case 3:
                but3.text = jobjob[d];      //c buttonunda
                but2.text = jobjob[x];
                but1.text = jobjob[y];
                break;

        }

    }



   public void darttır()
    {
        if (d < 29)
        {
            d += 1;
        }
        b1.image.color = Color.white;
        b2.image.color = Color.white;
        b3.image.color = Color.white;
        b1.gameObject.SetActive(true);
        b2.gameObject.SetActive(true);
        b3.gameObject.SetActive(true);
        truePng.gameObject.SetActive(false);
        falsePng.gameObject.SetActive(false);
        if (d == 28)
        {
            b1.gameObject.SetActive(false);
            b2.gameObject.SetActive(false);
            b3.gameObject.SetActive(false);
            b4.gameObject.SetActive(false);
            Destroy(GameObject.FindWithTag("Player"));
            b5.gameObject.SetActive(true);
            truetext.gameObject.SetActive(true);
            falsetext.gameObject.SetActive(true);
            truetext.text = "Doğru Sayısı:" + trueVar.ToString();
            falsetext.text = "Yanlış Sayısı:" + falseVar.ToString();
        }

    }
  


    public void Asıkkı()
    {
        b2.gameObject.SetActive(false);
        b3.gameObject.SetActive(false);
        if (but1.text == jobjob[d])
        {
            Debug.Log("doğru");
            b1.image.color = Color.green;
            truePng.gameObject.SetActive(true);
            trueVar += 1;
        }
        else
        {
            falseVar += 1;
            b1.image.color = Color.red;
            falsePng.gameObject.SetActive(true);
                if(but2.text == jobjob[d])
            {
                b2.gameObject.SetActive(true);
                b2.image.color = Color.green;

            }
            if (but3.text == jobjob[d])
            {
                b3.gameObject.SetActive(true);
                b3.image.color = Color.green;

            }
        }
    }
    public void Bsıkkı()
    {
        b1.gameObject.SetActive(false);
        b3.gameObject.SetActive(false);
        if (but2.text == jobjob[d])
        {
            Debug.Log("doğru");
            b2.image.color = Color.green;
            truePng.gameObject.SetActive(true);
            trueVar += 1;
        }
        else
        {
            falseVar += 1;
            b2.image.color = Color.red;
            falsePng.gameObject.SetActive(true);

            if (but1.text == jobjob[d])
            {
                b1.gameObject.SetActive(true);
                b1.image.color = Color.green;

            }
            if (but3.text == jobjob[d])
            {
                b3.gameObject.SetActive(true);
                b3.image.color = Color.green;

            }

        }
    }
    public void Csıkkı()
    {
        b1.gameObject.SetActive(false);
        b2.gameObject.SetActive(false);
        if (but3.text == jobjob[d])
        {
            Debug.Log("doğru");
            b3.image.color = Color.green;
            truePng.gameObject.SetActive(true);
            trueVar += 1;
        }
        else
        {
            falseVar += 1;
            b3.image.color = Color.red;
            falsePng.gameObject.SetActive(true);

            if (but1.text == jobjob[d])
            {
                b1.gameObject.SetActive(true);
                b1.image.color = Color.green;

            }
            if (but2.text == jobjob[d])
            {
                b2.gameObject.SetActive(true);
                b2.image.color = Color.green;

            }
        }
    }

    public void Update()
    {

     }

}


