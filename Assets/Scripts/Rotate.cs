using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [TooltipAttribute("Change in degrees per second")]
    public Vector3 rotation;
	
	void Update ()
    {
        transform.Rotate(rotation * Time.deltaTime);
	}
}
