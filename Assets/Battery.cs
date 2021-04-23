using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    // Start is called before the first frame update
    public float voltage = 5f;
    public GameObject positiveCollision = null;
    public GameObject negativeCollision = null;
    public void CollisionDetected(BatteryHole childScript, string terminal, GameObject obj) {
        if (terminal == "Positive") {
            positiveCollision = obj;
        }
        else if (terminal == "Negative") {
            negativeCollision = obj;
        }
        
    }

    public void CollisionUnDetected(BatteryHole childScript, string terminal, GameObject obj) {
        if (terminal == "Positive") {
            positiveCollision = null;
        }
        else if (terminal == "Negative") {
            negativeCollision = null;
        }
        
    }
}
