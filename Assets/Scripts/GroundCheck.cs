﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public int touches;

    private void OnTriggerEnter2D(Collider2D collision) //om du nuddar marken så kan du hoppa 
    {
        touches++;
    }

    private void OnTriggerExit2D(Collider2D collision) // om du inte nuddar marken så kan du inte hoppa 
    {
        touches--;
    }
}
