using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(WayPoint))]
public class CubeEditor : MonoBehaviour
{
    TextMesh labale;
    string labelName;

    Vector3 gridPos;

    WayPoint wayPoint;

    private void Awake()
    {
        labale = GetComponentInChildren<TextMesh>();
        wayPoint = GetComponent<WayPoint>();
    }

    void Update()
    {
        SnapToGrid();

        UpdateLabel();
    }

    private void SnapToGrid()
    {
        int gridSize = wayPoint.GetGridSize();
        transform.position = new Vector3(wayPoint.GetGridPos().x*gridSize, 0f, wayPoint.GetGridPos().y*gridSize);
    }

    private void UpdateLabel()
    {
        int gridSize = wayPoint.GetGridSize();
        labelName = wayPoint.GetGridPos().x  + "," + wayPoint.GetGridPos().y;
        labale.text = labelName;
        gameObject.name = labelName;
    }
}
