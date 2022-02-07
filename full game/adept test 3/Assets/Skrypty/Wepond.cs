using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wepond : MonoBehaviour
{
    public Transform fierPoint;

    public GameObject BulletPrefab;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(BulletPrefab, fierPoint.position, fierPoint.rotation);
    }
}
