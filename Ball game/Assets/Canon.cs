using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
   [SerializeField] private Animator myAnimationController;
   [SerializeField] private Animator Ball;
   
   
   private void OnTriggerEnter(Collider other)
   {
      myAnimationController.SetBool("shoot", true);
      Ball.SetBool("shoot",true);
   }
   
   
}
