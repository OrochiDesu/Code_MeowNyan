using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMe : MonoBehaviour
{
    private Rigidbody _body;
    private int _rotateSpeed = 5;
    private int _force = 200;

	void Start ()
	{
	    _body = GetComponent<Rigidbody>();
	}

	void Update ()
	{
	    var rot = 0;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rot = 1;
            _body.angularVelocity = Vector3.zero;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rot = -1; 
            _body.angularVelocity = Vector3.zero;
        }

	    transform.Rotate(new Vector3(0, 0, rot * _rotateSpeed));

	    if (Input.GetKey(KeyCode.Space))
	    {
	        _body.AddForce(transform.up * _force);
	    }

	    if (Input.GetKeyDown(KeyCode.Return))
	    {
	        transform.position = Vector3.zero;
            transform.rotation = Quaternion.identity;
	        _body.velocity = new Vector3(0, 10, 0);
            _body.angularVelocity = Vector3.zero;
	    }
	}
}
