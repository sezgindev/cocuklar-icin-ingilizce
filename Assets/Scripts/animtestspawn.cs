using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animtestspawn : MonoBehaviour {
    int i = 1;
    public GameObject[] pref = new GameObject[23];
    // Use this for initialization
    void Start () {
        Instantiate(pref[0], transform.position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Spawn()
    {
       
          Instantiate(pref[i], transform.position, Quaternion.identity);
            Destroy(GameObject.FindWithTag("Player"));
      
    }
    public void arttir()
    {
        i += 1;
    }
}
