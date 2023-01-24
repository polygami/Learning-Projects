using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
	private int hitCount = 0;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnCollisionEnter(Collision other)
	{
		hitCount++;
		Debug.Log("You have hit something " + hitCount + " times!");
	}
}