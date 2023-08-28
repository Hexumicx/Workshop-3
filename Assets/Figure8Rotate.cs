using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure8Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float rotationSpeed;
    private float time = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        var rotationSpeed = this.rotationSpeed * Time.deltaTime;
        float angleX = Mathf.Sin(time) * 45f; // Adjust amplitude and frequency as needed
        float angleZ = Mathf.Cos(time * 2f) * 45f; // Adjust amplitude and frequency as needed

        // Apply rotations to create a figure-eight motion
        Quaternion rotation = Quaternion.Euler(angleX, 0f, angleZ);
        transform.rotation = rotation;
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
