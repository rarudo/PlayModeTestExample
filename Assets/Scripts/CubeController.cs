using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CubeController : MonoBehaviour
{
	// Update is called once per frame
	void Update () {
		if(transform.position.y < -100)
			CubeManager.OnCubeHell.Invoke();
	}
}
