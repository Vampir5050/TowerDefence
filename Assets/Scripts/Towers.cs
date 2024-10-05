using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towers : MonoBehaviour
{
    [SerializeField] Transform towerTop;
    [SerializeField] Transform targetEnemy;
   
    void Update()
    {
        towerTop.LookAt(targetEnemy);
    }
}
