using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollower : MonoBehaviour {

	public Transform obj_to_follow;
	private RectTransform _rect;

	// Use this for initialization
	void Start () {
		_rect = GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update () {
		this._rect.anchoredPosition = CanvasManager.Instance.WorldToCanvasPoint (obj_to_follow.position);
	}
}
