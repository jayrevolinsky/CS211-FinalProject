using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPlacement : MonoBehaviour
{
    public GameObject EnemyPrefabList;
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

        GameObject spawn = Instantiate(EnemyPrefabList) as GameObject;
    }
}
