using UnityEngine;
using System.Collections;

public class firePistol : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
				RaycastHit hit;
				Ray playerSight = new Ray (transform.position, transform.forward); 
				if (Physics.Raycast (playerSight, out hit, 2)) {
						if (hit.collider.tag == "Trees") {
							if (Input.GetKeyDown (KeyCode.E)){
								hit.transform.SendMessage ("takedmg", SendMessageOptions.DontRequireReceiver);
		}


		}

		

}
}
}

//gatheringtime = Random.Range (10, 30);
//for (int time = gatheringtime; time >= 0; --time) 