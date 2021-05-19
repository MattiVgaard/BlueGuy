using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTeleporting : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject Item;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Item.transform.position = teleportTarget.transform.position;
        }
       
    }
}
