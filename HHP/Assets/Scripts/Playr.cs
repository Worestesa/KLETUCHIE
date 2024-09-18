using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Playr : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D Body;
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
