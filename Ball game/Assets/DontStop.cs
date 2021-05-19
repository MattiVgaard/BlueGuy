using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontStop : MonoBehaviour
{
   void Awake()
   {
      DontDestroyOnLoad(transform.gameObject);
   }
}
