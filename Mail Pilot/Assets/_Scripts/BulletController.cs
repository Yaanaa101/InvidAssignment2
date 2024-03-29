﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

public class BulletController : MonoBehaviour
{
    public float bulletSpeed = 0.1f;
    public Boundary boundary;

    //TODO: create a reference to the BulletPoolManager
    private BulletPoolManager bulletPool;

    void Start()
    {
        boundary.Top = 2.45f;
        //references bulletpoolmanager
        bulletPool = GetComponent<BulletPoolManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }

    private void Move()
    {
        transform.position += new Vector3(0.0f, bulletSpeed, 0.0f);
    }

    private void CheckBounds()
    {
        if (transform.position.y >= boundary.Top)
        {
            //TODO: This code needs to change to use the BulletPoolManager's
            //TODO: ResetBullet function which will return the bullet to the pool
            //refers to resetbullet
            BulletPoolManager.ResetBullet();

            Destroy(this.gameObject);
        }
    }
}
