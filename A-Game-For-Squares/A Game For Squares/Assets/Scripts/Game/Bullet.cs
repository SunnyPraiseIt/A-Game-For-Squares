﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float BulletSpeed;

	void Start ()
    {
        if (BulletSpeed <= 0)
            BulletSpeed = 10.2f;
	}
	
	void Update ()
    {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, BulletSpeed * Time.deltaTime, 0);
        pos += transform.rotation * velocity;
        transform.position = pos;

        if (transform.position.x >= 13 || transform.position.x <= -13 || transform.position.y >= 13 || transform.position.y <= -13)
            Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Bullet")
            Destroy(gameObject);
    }
}
