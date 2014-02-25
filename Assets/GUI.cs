using UnityEngine;
using System.Collections.Generic;

public class GUI : MonoBehaviour {
	private bool playing = false;
	PlayerController pp = new PlayerController ();

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
				if (playing == false) {
					GUILayout.BeginArea(new Rect(Screen.width,Screen.height, 100, 100));
					GUILayout.Box();
					GUILayout.EndArea();		
				}
		}

	void Inventory(){

		}

	void HealthBar(){
		GUILayout.BeginArea(new Rect(Screen.width,Screen.height, 100, 100));
		GUILayout.Box();
		GUILayout.EndArea();	
	}


	
	}

	