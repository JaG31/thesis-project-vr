using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    public float voltage;
    public float current;
    private Collider collider;
    public GameObject collisionInColumn = null;
    public Transform[] children;
    private void Start() {

    }

    private void Update() {

    }

    public void CollisionDetected(GameObject childScript) {
        collisionInColumn = childScript;
    }

    public void CollisionUnDetected(GameObject childScript) {
        collisionInColumn = null;
    }

    public void PowerColumn(BreadboardHole childScript) {
        //Debug.Log(this.gameObject.name + " is powered");
    }

    private void OnTriggerStay(Collider other) {
        
    }
}