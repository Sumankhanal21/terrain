using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform Position;
    public Vector3 distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Position.position - distance;
    }
}
