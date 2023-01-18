using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
	[SerializeField] float MoveSpeed = 1;
	enum Direction { x, y, z };
	Vector3 directionVector = Vector3.zero;
	[SerializeField] Direction direction;

	// Start is called before the first frame update
	void Start()
	{
		directionVector[(int)direction] = MoveSpeed;
	}

	// Update is called once per frame
	void Update()
	{
		transform.Translate(directionVector * Time.deltaTime);
	}
}
