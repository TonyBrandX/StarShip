﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_02 : Enemy
{
    // Start is called before the first frame update
     protected override void Start()
    {
        Debug.Log("Child Start");
        base.Start();     
    }

    // Update is called once per frame
    protected override void Update()
    {
        
    }

    public override void Move()
    {
        base.Move();
    }
}
