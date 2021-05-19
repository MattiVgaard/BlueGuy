using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsRespawn : MonoBehaviour
{
  
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private Transform respawnPoint2;
    [SerializeField] private Transform respawnPoint3;
    [SerializeField] private Transform ball;
    [SerializeField] private Transform ball2;
    [SerializeField] private Transform ball3;
    [SerializeField] private Transform ball4;
    [SerializeField] private Transform ball5;
    [SerializeField] private Transform ball6;
    [SerializeField] private Transform ball7;
    [SerializeField] private Transform ball8;
    [SerializeField] private Transform ball9;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ball.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }if (other.CompareTag("Ball2"))
        {
            ball2.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }if (other.CompareTag("Ball3"))
        {
            ball3.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }if (other.CompareTag("Ball4"))
        {
            ball4.transform.position = respawnPoint2.transform.position;
            Physics.SyncTransforms();
        }if (other.CompareTag("Ball5"))
        {
            ball5.transform.position = respawnPoint2.transform.position;
            Physics.SyncTransforms();
        }if (other.CompareTag("Ball6"))
        {
            ball6.transform.position = respawnPoint2.transform.position;
            Physics.SyncTransforms();
        }if (other.CompareTag("Ball7"))
        {
            ball7.transform.position = respawnPoint3.transform.position;
            Physics.SyncTransforms();
        }if (other.CompareTag("Ball8"))
        {
            ball8.transform.position = respawnPoint3.transform.position;
            Physics.SyncTransforms();
        }if (other.CompareTag("Ball9"))
        {
            ball9.transform.position = respawnPoint3.transform.position;
            Physics.SyncTransforms();
        }
    }
}
