using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPlacement : MonoBehaviour
{
    private Grid grid;

    private void Awake()
    {
        grid = FindObjectOfType<Grid>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitInfo))
            {
                SpawnObject(hitInfo.point);
            }
        }
    }

    private void SpawnObject(Vector3 spawnPoint)
    {
        var finalPosition = grid.GetNearestPointOnGrid(spawnPoint);
        //var instance : GameObject = Instantiate(Resources.Load("Enemy")); //buggy script for loading in monsters
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = finalPosition;
    }
}
