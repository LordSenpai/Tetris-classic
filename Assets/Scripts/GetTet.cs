﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTet : MonoBehaviour
{
    public GameObject[] Tetblock = new GameObject[7];
    //public GameObject todes;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Tetblock[Random.Range(0, 6)], transform.position, Quaternion.identity);
        GameObject.Find("NextTile").GetComponent<GetRandom>().GetBlock();
        
    }

    // Update is called once per frame
    public void spawnblock()
    {
        int num= FindObjectOfType<GetRandom>().GetRnum();
        Instantiate(Tetblock[num], transform.position, Quaternion.identity);
        FindObjectOfType<GetRandom>().GetBlock();

        // Destroy(FindObjectOfType<GetRandom>().created);


    }
}
