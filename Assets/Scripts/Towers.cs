using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Towers : MonoBehaviour
{
    [SerializeField] Transform towerTop;
    [SerializeField] Transform targetEnemy;
    [SerializeField] float shotRange;
    [SerializeField] ParticleSystem bulletParticle;
    private void Start()
    {
        

    }
    void Update()
    {
       
        towerTop.LookAt(targetEnemy);
        if (targetEnemy)
        {
            Fire();
        }
        else
        {
            Shoot(false);
        }
        
    }

    private void Fire()
    {
        float distanceToEnemy = Vector3.Distance(targetEnemy.position, transform.position);
        if (distanceToEnemy <= shotRange)
        {
            Shoot(true);
        }
        else
        {
            Shoot(false);
        }
    }

    private void Shoot(bool isActive)
    {
        var emission = bulletParticle.emission;
       emission.enabled = isActive;
     
    }
}
