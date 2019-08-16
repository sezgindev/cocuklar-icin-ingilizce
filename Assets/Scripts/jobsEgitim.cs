using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jobsEgitim : MonoBehaviour {
    public GameObject[] Jobs = new GameObject[28];
    int i = 1;
    public Button but1, but2, but3, but4, but5, but6;
    public Text jobst,jobsr, last;
    // Use this for initialization
    void Start () {
        Instantiate(Jobs[0], transform.position, Quaternion.identity);
        but3.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        
    }
    public void arttir()
    {
        i += 1;
    }
    public void Spawn()
    {
        if (i > 0)
            but3.gameObject.SetActive(true);
        if (i < 28)
        {
            Instantiate(Jobs[i], transform.position, Quaternion.identity);
            Destroy(GameObject.FindWithTag("Player"));
        }
        if (i >= 28)
        {
            but4.gameObject.SetActive(true);
            but5.gameObject.SetActive(true);
            but6.gameObject.SetActive(true);
            but1.gameObject.SetActive(false);
            but2.gameObject.SetActive(false);
            but3.gameObject.SetActive(false);
            jobst.gameObject.SetActive(false);
            jobsr.gameObject.SetActive(false);
            last.gameObject.SetActive(true);
            Destroy(GameObject.FindWithTag("Player"));
        }
    }
    public void azalt()
    {
        i -= 1;
        if (i == 1)
            but3.gameObject.SetActive(false);
    }
    public void backSpawn()
    {
        Instantiate(Jobs[i - 1], transform.position, Quaternion.identity);
        Destroy(GameObject.FindWithTag("Player"));

    }
}
