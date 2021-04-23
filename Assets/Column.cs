using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    public float voltage;
    public float current;
    private Collider collider;
    public List<GameObject> collisionsInColumn = null;
    public Transform[] children;
    private void Start() {

    }

    private void Update() {

    }

    public void CollisionDetected(GameObject child) {
        if (!collisionsInColumn.Contains(child)) {
            collisionsInColumn.Add(child);
        }
        
    }

    public void CollisionUnDetected(GameObject child) {
        collisionsInColumn.Remove(child);
        
    }

    public void PowerColumn(BreadboardHole childScript) {
        //Debug.Log(this.gameObject.name + " is powered");
    }

    private void OnTriggerStay(Collider other) {
        
    }
}