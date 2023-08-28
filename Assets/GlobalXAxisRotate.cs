using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalXAxisRotate : MonoBehaviour
{
    [SerializeField] private float spinSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var moveSpeed = this.spinSpeed * Time.deltaTime;
        transform.rotation *= Quaternion.AngleAxis(moveSpeed, Vector3.right);
    }
}
