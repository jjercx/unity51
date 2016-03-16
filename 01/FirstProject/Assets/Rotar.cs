using UnityEngine;
using System.Collections;

public class Rotar : MonoBehaviour { 
	float t;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frames
	void Update () {
		t += 0.1f;
		transform.Rotate (Mathf.Cos(t), Mathf.Sin(t), Mathf.Sin(t));
	}
}