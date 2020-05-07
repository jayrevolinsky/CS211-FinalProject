﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeeperCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    public float zoomSpeedf = 4f;
    public float yawSpeedf = 100f;
    public float minZoom = 5f;
    public float maxZoom = 15f;
    private float currentZoom = 10f;
    public float pitch = 2f;
    public float currentYaw = 0f;

    private void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeedf;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

        currentYaw -= Input.GetAxis("Horizontal") * yawSpeedf * Time.deltaTime;
    }
    private void LateUpdate()
    {
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + Vector3.up * pitch);

        transform.RotateAround(target.position, Vector3.up, currentYaw);
    }
}
