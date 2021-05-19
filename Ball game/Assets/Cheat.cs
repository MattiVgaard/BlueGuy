using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheat : MonoBehaviour
{
    public GameObject Wall1;
    public GameObject Wall2;
    public GameObject Wall3;
    public GameObject Wall4;
    public GameObject Wall5;
    public GameObject Wall6;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(Wall1);
            Destroy(Wall2);
            Destroy(Wall3);
            Destroy(Wall4);
            Destroy(Wall5);
            Destroy(Wall6);
        }
    }
}
