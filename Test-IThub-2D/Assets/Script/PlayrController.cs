using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayrController : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D Body;
    public float HP;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(Speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, Speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, Speed * Time.deltaTime, 0);
        }
    }
}
