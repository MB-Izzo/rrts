using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour {

	private static CanvasManager _instance;
	public static CanvasManager Instance { get { return _instance; } }
	private static Rect m_canvasRect;

	// Use this for initialization
	void Start () {
		if (_instance != null && _instance != this)
		{
			Destroy (this.gameObject);
		}
		else
		{
			_instance = this;
		}
		m_canvasRect = this.GetComponentInParent<Canvas> ().GetComponent<RectTransform> ().rect;
	}

	public Vector2 WorldToCanvasPoint (Vector3 a_position) {
		Vector2 viewport = Camera.main.WorldToViewportPoint(a_position);
		return Vector2.right*(viewport.x-0.5f)*m_canvasRect.width+Vector2.up*(viewport.y-0.5f)*m_canvasRect.height;
	}
}
