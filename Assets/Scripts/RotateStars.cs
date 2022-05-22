using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStars : MonoBehaviour
{
    public float rotateSpeed = 2.5f;

	void Update () {
        RenderSettings.skybox.SetFloat("_Rotation", rotateSpeed * Time.time);
	}
}
