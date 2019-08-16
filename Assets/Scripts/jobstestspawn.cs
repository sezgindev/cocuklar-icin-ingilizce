using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jobstestspawn : MonoBehaviour {

    public GameObject[] jobbb = new GameObject[28];
    // Use this for initialization
    int i = 1;
    void Start()
    {
        Instantiate(jobbb[0], transform.position, Quaternion.identity);
    }
    public void Spawn()
    {

        Instantiate(jobbb[i], transform.position, Quaternion.identity);
        Destroy(GameObject.FindWithTag("Player"));

    }
    public void arttir()
    {
        i += 1;
    }
}
