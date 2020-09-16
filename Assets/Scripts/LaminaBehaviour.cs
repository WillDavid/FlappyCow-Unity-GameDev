using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaminaBehaviour : MonoBehaviour
{
   
    private float speed = 2f;
    private float x;
    void Update()
    {
        rotationTrap();
        transform.position = transform.position + Vector3.left * speed * Time.deltaTime;
    }


    private void rotationTrap(){
        x = x + Time.deltaTime * 1000;
        transform.rotation=Quaternion.Euler(0,0,x);
    }
}
