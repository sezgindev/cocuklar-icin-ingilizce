using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VegaTestSpawn : MonoBehaviour
{

    public GameObject[] Vegaa = new GameObject[15];
    // Use this for initialization
    int i = 1;
    void Start()
    {
        Instantiate(Vegaa[0], transform.position, Quaternion.identity);
    }
    public void Spawn()
    {

        Instantiate(Vegaa[i], transform.position, Quaternion.identity);
        Destroy(GameObject.FindWithTag("Player"));

    }
    public void arttir()
    {
        i += 1;
    }
}
