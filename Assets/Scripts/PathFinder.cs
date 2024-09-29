using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour
{
    Dictionary<Vector2Int, WayPoint> grid = new Dictionary<Vector2Int, WayPoint>();

    [SerializeField] WayPoint startPoint, endPoint;

    Vector2Int[] directions =
    {
        Vector2Int.up,
        Vector2Int.right,
        Vector2Int.down,
        Vector2Int.left
    };

    void Start()
    {
        LoadBlock();
        SetColorStartAndEnd();
        ExploreNearPoints();
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadBlock()
    {
        var wayPoints = FindObjectsOfType<WayPoint>();
        foreach(WayPoint wayPoint in wayPoints)
        {
            Vector2Int gridPos = wayPoint.GetGridPos();
            if (grid.ContainsKey(gridPos))
            {
                Debug.LogWarning("Повтор блока" + wayPoint);
            }
            else
            {
                grid.Add(wayPoint.GetGridPos(), wayPoint);
               
            }
            
        }
    }
    private void SetColorStartAndEnd()
    {
        startPoint.SetTopColor(Color.green);
        endPoint.SetTopColor(Color.red);
    }

    void ExploreNearPoints()
    {
        foreach(Vector2Int direction in directions)
        {
            Vector2Int nearPointCordinates = startPoint.GetGridPos() + direction;
            try
            {
                grid[nearPointCordinates].SetTopColor(Color.blue);
            }
            catch
            {
                Debug.LogWarning("Блок :" + nearPointCordinates + " отсутствует");
            }
        }
    }
}
