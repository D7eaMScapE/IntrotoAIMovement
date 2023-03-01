using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 20f;
	
	void Update() //Why the empty bracets?
	{
		if(Input.GetKey(KeyCode.W)) //Up
		{
			Vector3 playerPosition = transform.position;
			playerPosition.y += speed * Time.deltaTime;
			transform.position = playerPosition;
		}
		if(Input.GetKey(KeyCode.S)) //Down
		{
			Vector3 playerPosition = transform.position;
			playerPosition.y -= speed * Time.deltaTime;
			transform.position = playerPosition;
		}
		if(Input.GetKey(KeyCode.A)) //Left
		{
			Vector3 playerPosition = transform.position;
			playerPosition.x -= speed * Time.deltaTime;
			transform.position = playerPosition;
		}
		if(Input.GetKey(KeyCode.D)) //Right
		{
			Vector3 playerPosition = transform.position;
			playerPosition.x += speed * Time.deltaTime;
			transform.position = playerPosition;
		}
			if(Input.GetKey(KeyCode.Q)) //Forward
		{
			Vector3 playerPosition = transform.position;
			playerPosition.z += speed * Time.deltaTime;
			transform.position = playerPosition;
		}
		if(Input.GetKey(KeyCode.E)) //Backward
		{
			Vector3 playerPosition = transform.position;
			playerPosition.z -= speed * Time.deltaTime;
			transform.position = playerPosition;
		}
		
	}
}
