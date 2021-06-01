using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Cam : MonoBehaviour {
	private Transform mario;

	public bool debug;

	// Use this for initialization
	void Start () {
		Screen.SetResolution(256, 340, true, 360);
		mario = GameObject.Find("Mario").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (mario.position.x > transform.position.x || debug) {
			transform.position =  new Vector3(mario.position.x, transform.position.y, -10);
		}
	}
}
