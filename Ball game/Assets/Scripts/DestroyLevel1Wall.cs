using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLevel1Wall : MonoBehaviour
{
    public GameObject Wall;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Destroy(Wall);
        }
    }
}
