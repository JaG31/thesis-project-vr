using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resistor : MonoBehaviour {
    [SerializeField] Transform connector1;
    [SerializeField] Transform connector2;
    [SerializeField] Transform bridge;
    [SerializeField] GameObject connector1Prefab;
    [SerializeField] GameObject connector2Prefab;

    void Update() {
        if (connector1 != null && connector2 != null && bridge != null) {
            // orient the bridge between the two connectors
            Vector3 bridgeDirection = connector2.position - connector1.position;
            bridge.localRotation = Quaternion.LookRotation(bridgeDirection.normalized, Vector3.up);

            // position the bridge in the centre of the two connectors
            bridge.position = (connector1.position + connector2.position) / 2f;

            // increase the height of the bridge to span the distance between the connectors
            Vector3 largeScale = new Vector3(1,1,1);
            //Debug.Log(Vector3.Distance(bridge.localScale, largeScale));
            Debug.Log(bridgeDirection.magnitude*5);
            if (bridgeDirection.magnitude*5 > 1) {
                
            }
            else {
                bridge.localScale = new Vector3(1f, 1f, bridgeDirection.magnitude*5);
            }
            
        } else {
            Debug.Log("Some of the required components are null");
        }
    }
}
