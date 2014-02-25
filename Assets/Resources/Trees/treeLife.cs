using UnityEngine;
using System.Collections;

public class treeLife : MonoBehaviour {

	public GameObject player;
	public float treeHealth;
	// Use this for initialization
	void Start () {
		treeHealth = Random.Range (3, 6);
		Component numberOfLogs = player.GetComponent ("INventory");
	}
	
	// Update is called once per frame
	void Update () {

	if (treeHealth <= 0) {
			Destroy (gameObject);
				}
	}

	void takedmg() {
		treeHealth -= 1;
		numberOfLogs.Logs += 1;
	}

	void OnGUI () {
		GUI.Box(new Rect(50,50,40,20), treeHealth.ToString());
		}
}
