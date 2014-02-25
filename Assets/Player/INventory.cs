using UnityEngine;
using System.Collections;

public class INventory : MonoBehaviour {

	private int Logs;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getInventory (){
		return Logs;
	}

	public int setlogs(int x) {
		Logs += x;
		return Logs;
	}
	
}
