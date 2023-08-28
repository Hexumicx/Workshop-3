using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAxisMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float moveSpeed;
    private bool forward = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var moveSpeed = this.moveSpeed * Time.deltaTime;
        if(transform.position.z > 5.0f){
            forward = false;
        }else if(transform.position.z < -5.0f){
            forward = true;
        }

        if(forward){
            transform.position += new Vector3(0.0f, 0.0f, moveSpeed);
        }
        else{
            transform.position -= new Vector3(0.0f, 0.0f, moveSpeed);
        }
    }
}
