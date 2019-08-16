using System.Collections;
using System.Collections.Generic;

using UnityEngine;
    
public class random : MonoBehaviour {
    public GameObject[] pref = new GameObject[23];
    int randomsayi;
 
    // Use this for initialization
    void Start () {
        Instantiate(pref[Random.RandomRange(0,22)], transform.position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
  
        randomsayi =Random.RandomRange(0, 22);
     
    }
    public void spawn()
    {
        Instantiate(pref[randomsayi], transform.position, Quaternion.identity);
    }
}
