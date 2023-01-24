using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
	[SerializeField] float MoveSpeed;

	// Start is called before the first frame update
	void Start()
	{
		PrintInstructions();
	}

	// Update is called once per frame
	void Update()
	{
		MovePlayer();
	}

	private void MovePlayer()
	{
		float xInput = Input.GetAxis("Horizontal");
		float zInput = Input.GetAxis("Vertical");
		Vector3 translation = new Vector3(xInput, 0, Input.GetAxis("Vertical"));
		transform.Translate(translation * MoveSpeed * Time.deltaTime);
	}

	void PrintInstructions()
	{
		Debug.Log("Move using the WASD keys");
	}


}
