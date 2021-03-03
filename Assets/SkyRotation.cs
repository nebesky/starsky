using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class SkyRotation : MonoBehaviour
{
	public float hourOffset = 0;
	public float speed = 1;

	public IEnumerator SetTime()
	{
		while (true)
        {
            yield return new WaitForSeconds(0.2f);
            
            var gameObj = gameObject;

	        float timeF = (24 * 60 * 60);
	        float timeO = 360f;
	        float timeOffset = timeO / timeF;
	        
	        var timeLapse = DateTime.Now.Hour * 60 * 60 + DateTime.Now.Minute * 60 + 
	        DateTime.Now.Second;

	        gameObj.transform.eulerAngles = new Vector3(
	            gameObj.transform.eulerAngles.x,
	            gameObj.transform.eulerAngles.y,
	            timeLapse * timeOffset
	        );

        }
	}

	void Start()
    {
        StartCoroutine(SetTime());
    }
}
