﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBasket : MonoBehaviour
{
    public GameObject Door;
    public int y=5;
    public int x=5;
    public int z=5;
   void OnTriggerEnter(Collider other) 
    {
        Door.gameObject.transform.position = new Vector3(x,y,z);
        Destroy(gameObject);
    }
}
