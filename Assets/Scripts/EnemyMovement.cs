using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    [SerializeField] List<WayPoint> wayPoints;
    
    void Start()
    {
        Movement();
        StartCoroutine(Movement());
        
    }

    IEnumerator Movement()
    {
        foreach(WayPoint wayPoint in wayPoints)
        {
            transform.LookAt(wayPoint.transform);
            transform.position = wayPoint.transform.position;
            yield return new WaitForSeconds(1);
        }
    }
}
