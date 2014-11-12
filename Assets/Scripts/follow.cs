using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	public GameObject player;


	// Use this for initialization
	void Start () {
	
	}

	float xmin = 0;
	float xmax = 100;
	//still not working
	void LateUpdate() {
		transform.position = new Vector3(Mathf.Clamp(player.transform.position.x, xmin, xmax), Mathf.Clamp(player.transform.position.y, xmin, xmax), transform.position.z);
	}

}
