using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private Camera _mainCam;
	private float _minFov = 2.5f;
	private float _maxFov = 5f;

	public float Speed;
	private float _speed { get { return this.Speed; } set { this.Speed = value; } }

	public float ZoomSensitivity;
	private float _zoomSensitivity { get { return this.ZoomSensitivity; } set { this.ZoomSensitivity = value; } }

	// Use this for initialization
	void Start () {
		_mainCam = Camera.main;

	}

	// Update is called once per frame
	void Update () {

		HandleMovement ();
		HandleZoom ();



	}

	private void HandleZoom()
	{
		float fov = _mainCam.orthographicSize;
		fov += Input.GetAxis ("Mouse ScrollWheel") * - _zoomSensitivity;
		fov = Mathf.Clamp (fov, _minFov, _maxFov);
		_mainCam.orthographicSize = fov;
	}

	private void HandleMovement()
	{
		Vector2 input;
		input.x = Input.GetAxisRaw ("Horizontal");
		input.y = Input.GetAxisRaw ("Vertical");
		if (Input.GetKey (KeyCode.D) && !LockedRight())
		{
			_mainCam.transform.Translate (Vector3.right * _speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.Q) && !LockedLeft())
		{
			_mainCam.transform.Translate (Vector3.left * _speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.Z) && !LockedTop())
		{
			_mainCam.transform.Translate (Vector3.up * _speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.S) && !LockedBot())
		{
			_mainCam.transform.Translate (Vector3.down * _speed * Time.deltaTime);
		}
	}


	private bool LockedLeft() 
	{
		Vector3 p = _mainCam.WorldToViewportPoint(new Vector3(0, 0, _mainCam.nearClipPlane));
		if (!isZoomed ())
		{
			if (p.x >= 0.6f)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		else
		{
			if (p.x >= 0.9f)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}

	private bool LockedRight() 
	{
		Vector3 p = _mainCam.WorldToViewportPoint(new Vector3(0, 0, _mainCam.nearClipPlane));
		if (!isZoomed())
		{
			if (p.x <= 0.4f)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		else
		{
			if (p.x <= 0.2f)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}

	private bool LockedTop()
	{
		Vector3 p = _mainCam.WorldToViewportPoint(new Vector3(0, 0, _mainCam.nearClipPlane));
		Debug.Log (p);
		if (!isZoomed ())
		{
			if (p.y <= 0.15f)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		else
		{
			if (p.y <= -0.4f)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}

	private bool LockedBot()
	{
		Vector3 p = _mainCam.WorldToViewportPoint(new Vector3(0, 0, _mainCam.nearClipPlane));
		Debug.Log (p);
		if (!isZoomed ())
		{
			if (p.y >= 0.6f)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		else
		{
			if (p.y >= 0.9f)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}

	private bool isZoomed()
	{
		if (_mainCam.orthographicSize <= 3f)
		{
			return true;
		} 
		else
		{
			return false;
		}
	}
}
