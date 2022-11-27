using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	GameObject target;

	public static bool cameraExists;

	// Use this for initialization
	void Start () {
		if (!cameraExists) {
			target = GameObject.FindGameObjectWithTag ("MainCamera");
			cameraExists = true;
			DontDestroyOnLoad (transform.gameObject);
		}
		else {
			Destroy (gameObject);
		}
    }

}