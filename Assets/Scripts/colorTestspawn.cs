using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorTestspawn : MonoBehaviour {
    public GameObject[] colors = new GameObject[11];
    // Use this for initialization
    int i = 1;
    void Start () {
        Instantiate(colors[0], transform.position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Spawn()
    {

        Instantiate(colors[i], transform.position, Quaternion.identity);
        Destroy(GameObject.FindWithTag("Player"));

    }
    public void arttir()
    {
        i += 1;
    }
}
