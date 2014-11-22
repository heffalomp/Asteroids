using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Transform Missile;
	public float Speed = 5.0f;
	// Use this for initialization
	void Start () 
	{
		transform.position = new Vector3 (0,0,0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (Vector3.right * Input.GetAxis("Horizontal") * Speed * Time.deltaTime);
		transform.Translate (Vector3.up * Input.GetAxis("Vertical") * Speed * Time.deltaTime);

		if (Input.GetKey ("e")) 
			{
				transform.Rotate (Vector3.up);
			}

		if (Input.GetKey ("q")) 
		{
			transform.Rotate (Vector3.down);
		}

		if (Input.GetKey ("space")) 
			{
			Transform missile = Instantiate(Missile, transform.position, Quaternion.identity) as Transform;
			missile.rigidbody.AddForce(transform.forward * 1000);
			missile.rotation = transform.rotation;
			}
	}

}
