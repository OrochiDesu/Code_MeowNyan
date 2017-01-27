using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class SpawnBall : MonoBehaviour
{
    private Object _ballPrefab;
    private float _ballSpawnInterval = 5;
    private float _currentTime = 0;

	// Use this for initialization
	void Start ()
    {
        _ballPrefab = Resources.Load("Sphere");
	}
	
	// Update is called once per frame
	void Update ()
	{
	    _currentTime += Time.deltaTime;

	    if (_currentTime >= _ballSpawnInterval)
	    {
	        _currentTime = 0;
	        var ball = (GameObject)Instantiate(_ballPrefab);
            ball.transform.SetParent(transform);
	        ball.transform.localPosition = Vector3.zero;

            var rnd = new System.Random();

	        var scale = rnd.Next(8);

            ball.transform.localScale = new Vector3(scale, scale, scale);
	    }
	}
}
