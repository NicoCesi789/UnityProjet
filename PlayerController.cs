using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float MoveSpeed;
    public Vector3 jumpSpeed;
    CapsuleCollider playerCollider;
     // Start is called before the first frame update
    void Start()
    {
        playerCollider = gameObject.GetComponent<CapsuleCollider>();
    }



    // Update is called once per frame
    private void Update()
    {
    Vector3 movement = Vector3.zero;
        if(Input.GetKey(KeyCode.LeftArrow))
            {
            movement.x = -MoveSpeed * Time.deltaTime;
            }
        else if (Input.GetKey(KeyCode.RightArrow))
            {
            movement.x = MoveSpeed * Time.deltaTime;
            }
        if (Input.GetKey(KeyCode.UpArrow))
            {
            movement.z = MoveSpeed * Time.deltaTime;
            }
        else if (Input.GetKey(KeyCode.DownArrow))
            {
            movement.z = -MoveSpeed * Time.deltaTime;
            }
        transform.position += movement;
    }
}