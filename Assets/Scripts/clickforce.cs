using UnityEngine;
using System.Collections;

public class clickforce : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void Update () {
	}

	const float Snapp = 45;

	/*float up = 20;
	float accross = 20;*/

	void OnMouseDown() 
	{
		Vector2 angle = new Vector2(Random.Range(0, Snapp), Random.Range(0, Snapp));

		//Vector2 angle = new Vector2(up, accross);
		this.rigidbody2D.AddForce(/*Vector3.up * 1000*/ angle * 100 );
		
	}
}
