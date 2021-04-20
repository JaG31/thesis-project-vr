using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    // Start is called before the first frame update
    public float voltage = 5f;
    public bool positiveCollisionDetected;
    public bool negativeCollisionDetected;
    public void CollisionDetected(BatteryHole childScript, string terminal) {
        if (terminal == "Positive") {
            positiveCollisionDetected = true;
        }
        else if (terminal == "Negative") {
            negativeCollisionDetected = true;
        }
        
    }

    public void CollisionUnDetected(BatteryHole childScript, string terminal) {
        if (terminal == "Positive") {
            positiveCollisionDetected = false;
        }
        else if (terminal == "Negative") {
            negativeCollisionDetected = false;
        }
        
    }
}
