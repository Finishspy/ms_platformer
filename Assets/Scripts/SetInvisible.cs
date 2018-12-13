using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvisible : MonoBehaviour
{
    // Use this for initialization 
    void Start()
    { // gör objekt osynliga när man startar spelet
        GetComponent<SpriteRenderer>().enabled = false; 
    }
}
