using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour 
{
	public float paddleSpeed = 1F;
	public Vector3 playerPos = new Vector3(0,0,0);

	void Update()
	{
		float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical") * paddleSpeed);
		playerPos = new Vector3(-20, Mathf.Clamp(yPos, -11, 11), 0);
		gameObject.transform.position = playerPos;
	}
}