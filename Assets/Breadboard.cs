using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breadboard : MonoBehaviour
{
    // Start is called before the first frame update

    public bool circuitCompleted = false;
	public Column[] columnPath;
	public Battery battery;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (battery.negativeCollision != null && battery.positiveCollision != null) {
			circuitCompleted = checkForCircuit(battery.positiveCollision);
		}
    }

	public bool checkForCircuit(GameObject current) {
		Debug.Log("CURRENT " + current.name);
		Debug.Log("POS BATTERY " + battery.positiveCollision.name);
		Debug.Log("NEG BATTERY " + battery.negativeCollision.name);
		//Base case
		if (current == battery.negativeCollision) {
			return true;
		}
		if (current.name == "Connector1") {
			Wire wire = current.GetComponent<Connector1>().wire;
			if (wire.connector2Column != null && wire.connector2Column.collisionsInColumn != null) {
				Debug.Log("IN HERE");
				for (int i=0; i < wire.connector2Column.collisionsInColumn.Count; i++) {
					if (wire.connector2Column != current) {
						Debug.Log("RECURSED");
						checkForCircuit(wire.connector2Column.collisionsInColumn[i]);
					}
				}
			}
			else {
				return false;
			}
			
		}
		if (current.name == "Connector2") {
			Wire wire = current.GetComponent<Connector2>().wire;
			if (wire.connector1Column != null && wire.connector1Column.collisionsInColumn != null) {
				Debug.Log("IN HERE");
				for (int i=0; i < wire.connector1Column.collisionsInColumn.Count; i++) {
					if (wire.connector1Column.collisionsInColumn[i] != current) {
						Debug.Log("RECURSED");
						checkForCircuit(wire.connector1Column.collisionsInColumn[i]);
					}
					
				}
			}
			else {
				return false;
			}
			
		}
		return false;
	}


	// POSSIBLE SOLUTION ARCHIVE

    // public static List<Column> Depthwise(Column start, Column end) { 

	// 	Stack<Column> work = new Stack<Column> ();
	// 	List<Column> visited = new List<Column> ();

	// 	work.Push (start);
	// 	visited.Add (start);
	// 	start.history = new List<Column> ();

	// 	while(work.Count > 0){

	// 		Column current = work.Pop ();
	// 		if (current == end) {
	// 			List<Column> result = current.history;
	// 			result.Add (current);
	// 			return result;
	// 		} else {
			
	// 			for(int i = 0; i < current.neighbors.Length; i++){

	// 				Column currentChild = current.neighbors [i];
	// 				if(!visited.Contains(currentChild)){

	// 					work.Push (currentChild);
	// 					visited.Add (currentChild);
	// 					currentChild.history = new List<Column> (current.history);
	// 					currentChild.history.Add (current);
	// 				}
	// 			}	
	// 		}
	// 	}

	// 	return null; 
	
	// }



	// Wire wire1 = null;
	// Wire wire2 = null;
	// int i = 0;
	// foreach(Transform child in transform) {
	// 	Column column = child.GetComponent<Column>();
	// 	if (column.collisionInColumn != null) {
	// 		if (column.collisionInColumn.name == "Connector1") {
	// 			wire1 = column.collisionInColumn.GetComponent<Connector1>().wire;
	// 		}
	// 		if (column.collisionInColumn.name == "Connector2") {
	// 			wire2 = column.collisionInColumn.GetComponent<Connector2>().wire;
	// 		}

			

	// 		if (wire1 != null && wire2 != null && wire1.name == wire2.name) {
	// 			columnPath[i] = wire1.connnected()[0];
	// 			columnPath[i+1] = wire1.connnected()[1];
	// 			i++;
	// 		}
	// 		// else if (column.collisionInColumn.name == "Anode") {
	// 		// 	LED led = column.collisionInColumn.GetComponent<Anode>().LED;
	// 		// }
	// 		// else if (column.collisionInColumn.name == "Cathode") {
	// 		// 	LED led = column.collisionInColumn.GetComponent<Cathode>().LED;
	// 		// }

			
	// 	}
		
	//}
}
