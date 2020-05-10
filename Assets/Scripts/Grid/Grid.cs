using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour //build grid
{
    [SerializeField]
    private float size = 1f;

    
    public Vector3 GetNearestPointOnGrid(Vector3 position)
    {
        position -= transform.position;

        int xDrawn = Mathf.RoundToInt(position.x / size);
        int yDrawn = Mathf.RoundToInt(position.y / size);
        int zDrawn = Mathf.RoundToInt(position.z / size);

        Vector3 result = new Vector3(
            (float)xDrawn * size,
            (float)yDrawn * size,
            (float)zDrawn * size);

        result += transform.position;

        return result;
    }

    private void OnDrawGizmos() //visualize snapping points on graph
    {
        Gizmos.color = Color.yellow;
        for (float x = 0; x < 40; x += size)
        {
            for (float z = 0; z < 40; z += size)
            {
                var point = GetNearestPointOnGrid(new Vector3(x, 0f, z));
                Gizmos.DrawSphere(point, 0.1f);
            }
        }
    }
}
