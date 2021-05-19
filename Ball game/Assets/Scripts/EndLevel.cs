using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
 public GameObject completeLevelUI;
 
 private void OnTriggerEnter(Collider other)
 {
  if (other.CompareTag("Player"))
  {
   completeLevelUI.SetActive(true);
  }
 }
}
