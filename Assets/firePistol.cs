using UnityEngine;
using System.Collections;

public class firePistol : MonoBehaviour {

	bool gathering = false;
	int gatheringtime;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
				RaycastHit hit;
				Ray playerSight = new Ray (transform.position, transform.forward); 
				if (Physics.Raycast (playerSight, out hit, 2)) {
						if (gathering == false) {
								if (Input.GetButton ("Use")) {
										if (hit.collider.tag == "Trees") {
												gathering = true;
												gatherTree() ;
												if (
										}
								}
						}
				}

		if (Input.GetButtonUp ("Use")) {
			gathering = false;
				}
		}


	void gatherTree() {
		gatheringtime = Random.Range (10, 30);
		for (int time = gatheringtime; time >= 0; --time);



		}

						void OnGUI() {
							GUI.Box(new Rect(0, 0, Screen.width, Screen.height), gatheringtime.ToString());
							
						}
	
}


//gatheringtime = Random.Range (10, 30);
//for (int time = gatheringtime; time >= 0; --time) 