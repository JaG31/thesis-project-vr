using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breadboard : MonoBehaviour
{
    // Start is called before the first frame update

    public bool circuitCompleted = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Transform child in transform) {
            Column column = child.GetComponent<Column>();
            if (column.collisionInColumn != null) {
				// if (column.collisionInColumn.name == "Connector1") {
				// 	Wire wire = column.collisionInColumn.GetComponent<Connector1>().wire;
				// }
				// else if (column.collisionInColumn.name == "Connector2") {
				// 	Wire wire = column.collisionInColumn.GetComponent<Connector2>().wire;
				// }
				// else if (column.collisionInColumn.name == "Anode") {
				// 	LED led = column.collisionInColumn.GetComponent<Anode>().LED;
				// }
				// else if (column.collisionInColumn.name == "Cathode") {
				// 	LED led = column.collisionInColumn.GetComponent<Cathode>().LED;
				// }

				
            }
        }
    }

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
}
