using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {

	private LineRenderer line;
	public Transform a;
	public Transform b;

	// Use this for initialization
	void Start () {
		line = GetComponent<LineRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		line.positionCount = 2;
		line.startColor = Color.white;
		line.endColor = Color.white;
		line.startWidth = 0.025f;
		line.endWidth = 0.025f;
		line.SetPosition (0, new Vector3 (a.transform.position.x, a.transform.position.y, a.transform.position.z));
		line.SetPosition (1, new Vector3 (b.transform.position.x, b.transform.position.y, b.transform.position.z));
			
	}
}
