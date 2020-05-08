using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public Transform cardPrefab;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    void Updated()
    {
        if (countdown <= 0f)
        {

        }
    }

    void SpawnMonster()
    {
        Debug.Log("SpawnMonster");
    }
}
