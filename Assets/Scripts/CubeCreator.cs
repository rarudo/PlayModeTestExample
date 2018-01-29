using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreator : MonoBehaviour
{
	private GameObject pCube;

	// Use this for initialization
	void Start ()
	{
		pCube = Resources.Load<GameObject>("Prefabs/cube");
		StartCoroutine(CreateCubePerSecond());
	}

	IEnumerator CreateCubePerSecond()
	{
		while (true)
		{
			yield return new WaitForSeconds(1);
			Instantiate(pCube,transform);
		}
	}
}
