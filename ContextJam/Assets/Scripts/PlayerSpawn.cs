﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    private void Awake() 
    {
        GameObject.Find("Player").transform.position = this.transform.position;
    }
}