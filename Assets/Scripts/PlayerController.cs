using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

	public float speed = 3;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		transform.Translate(Vector3.right * horizontal * (Time.deltaTime * speed));
		transform.Translate(Vector3.forward * vertical * (Time.deltaTime * speed));

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Attack();
		}
	}

	private void Attack()
	{
		RaycastHit[] raycastHits = Physics.SphereCastAll(transform.position, 0.5f, Vector3.right, 0.8f);

		foreach (RaycastHit hit in raycastHits) {
			Debug.DrawLine(transform.position, hit.transform.position, Color.red, 5);
			Debug.Log(hit.transform.name);
		}
	}

	/*if (Input.GetKeyDown("joystick button 0"))
	 {
		 Debug.Log("Button 0");
	 }

	 if (Input.GetKeyDown("joystick button 1"))
	 {
		 Debug.Log("Button 1");
	 }

	 if (Input.GetKeyDown("joystick button 2"))
	 {
		 Debug.Log("Button 2");
	 }

	 if (Input.GetKeyDown("joystick button 3"))
	 {
		 Debug.Log("Button 3");
	 }*/
}
