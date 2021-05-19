using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    private Vector3 _velocity = Vector3.zero;

    void LateUpdate () 
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.position + offset, ref _velocity, smoothSpeed * Time.deltaTime);
    }
}
