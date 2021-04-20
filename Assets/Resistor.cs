using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resistor : MonoBehaviour {
    [SerializeField] Transform connector1;
    [SerializeField] Transform connector2;
    [SerializeField] Transform bridge;
    [SerializeField] GameObject connector1Prefab;
    [SerializeField] GameObject connector2Prefab;

    Column connector1Column;
    Column connector2Column;
    Battery connector1Battery;
    Battery connector2Battery;
    public float resistance = 10;

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
            if (bridgeDirection.magnitude*5 > 1) {
                
            }
            else {
                bridge.localScale = new Vector3(1f, 1f, bridgeDirection.magnitude*5);
            }
            
        } else {
            Debug.Log("Some of the required components are null");
        }
    }

    public void leadInserted(string conName,GameObject breadboardHole) {
        if (conName == "Connector1") {
            if (breadboardHole.tag == "Power") {
                connector1Battery = breadboardHole.gameObject.transform.parent.GetComponent<Battery>();
            }
            else {
                connector1Column = breadboardHole.gameObject.transform.parent.GetComponent<Column>();
            }
            
        }
        if (conName == "Connector2") {
            if (breadboardHole.tag == "Power") {
                connector2Battery = breadboardHole.gameObject.transform.parent.GetComponent<Battery>();
            }
            else {
                connector2Column = breadboardHole.gameObject.transform.parent.GetComponent<Column>();
            }
            
            
        }

        if (connector1Column != null && connector2Column != null) {

            for(int i = 0; i < connector1Column.children.Length; i++) {
                GameObject component = connector1Column.children[i].GetComponent<BreadboardHole>().collided;
                if (component != null) {
                    
                }
            }

            if (connector1Column.voltage > connector2Column.voltage) {
                
                connector2Column.voltage = (connector1Column.voltage * connector1Column.current) / resistance;
            }
            else {
                connector1Column.voltage = (connector2Column.voltage * connector2Column.current) / resistance;
            }
        }

        
        if (connector2Column != null && connector1Battery != null) {
            Debug.Log("BATTERY VOLT " + connector1Battery.voltage);
            connector2Column.voltage = connector1Battery.voltage;
        }
        if (connector1Column != null && connector2Battery != null) {
            Debug.Log("BATTERY VOLT " + connector2Battery.voltage);
            connector1Column.voltage = connector2Battery.voltage;
        }
        
        // else if (breadboard.circuitCompleted) {
        //     connector1Column.voltage = connector2Column.voltage;
        // }
    }
}
