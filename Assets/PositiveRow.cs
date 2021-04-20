using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositiveRow : MonoBehaviour
{
    public float voltage;
    private Collider collider;
    private void Start() {
        
    }

    private void Update() {
        
    }

    public void CollisionDetected(BreadboardHole childScript) {
        
    }

    public void PowerColumn(BreadboardHole childScript) {
        //Debug.Log(this.gameObject.name + " is powered");
    }

    private void OnTriggerStay(Collider other) {
        
    }
}