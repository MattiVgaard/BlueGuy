using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject tutorial;

    private void Start()
    {
        tutorial.SetActive(true);
        Invoke("DisableText", 5F);
    }

    void DisableText()
    {
        tutorial.SetActive(false);
    }
}
