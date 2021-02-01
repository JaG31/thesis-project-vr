using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class BreadboardInsertion : MonoBehaviour
 {
     Throwable _listener;
     public void Initialize(Throwable l)
     {
        _listener = l;
     }
     void OnTriggerStay(Collider collision)
     {
         _listener.OnTriggerStay(collision);
     }
 }
