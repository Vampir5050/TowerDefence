using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CubeEditor : MonoBehaviour
{
    const int gridSize = 10;

    void Update()
    {
        SnapToGrid();    
    }

    private void SnapToGrid()
    {
        transform.position = new Vector3(GetGridPos().x*gridSize, 0f, GetGridPos().y*gridSize);
    }

    public Vector2Int GetGridPos()
    {
        return new Vector2Int(
        Mathf.RoundToInt(transform.position.x / gridSize),
        Mathf.RoundToInt(transform.position.z / gridSize)
        );
    }


}
