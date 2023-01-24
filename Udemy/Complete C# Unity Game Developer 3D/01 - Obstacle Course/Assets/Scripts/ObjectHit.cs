using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
	[SerializeField] Material secondMaterial;
	private Material defaultMaterial;
	private bool isDefaultMaterial = true;
	// Start is called before the first frame update
	void Start()
	{
		defaultMaterial = GetComponent<MeshRenderer>().material;
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnCollisionEnter(Collision other)
	{
		Debug.Log(gameObject.name + " was crashed into by " + other.gameObject.name);
		// GetComponent<MeshRenderer>().material = secondMaterial;
		isDefaultMaterial = !isDefaultMaterial;
		GetComponent<MeshRenderer>().material = isDefaultMaterial ? defaultMaterial : secondMaterial;

	}
}
