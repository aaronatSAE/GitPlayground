using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretEasterEgg : MonoBehaviour
{
    private Camera cam;
    private void Start()
    {
        cam = FindObjectOfType<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("You discovered the secret easter egg!!!");
            cam.backgroundColor = Random.ColorHSV();
        }
    }
}
