using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 5f;
    //public float input;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime*speed);
        //input = Input.GetAxis("Horizontal");
       // GetComponent<Rigidbody>().velocity = new Vector3(input * 3, GetComponent<Rigidbody>().velocity.y, 0);
       // GetComponent<Rigidbody>().AddForce(Vector3.forward, ForceMode.VelocityChange);
    }
}
