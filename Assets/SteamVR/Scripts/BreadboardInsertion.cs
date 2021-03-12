using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class BreadboardInsertion : MonoBehaviour
 {
     Throwable _listener;
     Quaternion defaultRotation;
     public void Initialize(Throwable l)
     {
        _listener = l;
     }
     void OnTriggerStay(Collider collision)
     {
         if (collision != null) {_listener.OnTriggerStay(collision);}
     }
     

    void Awake()
    {
        defaultRotation = transform.rotation;
    }

    void LateUpdate()
    {
        transform.rotation = defaultRotation;
    }
 }
