using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.SceneManagement;

public class Playr : MonoBehaviour
{
    private Camera cam;
    public float Speed;
    public Rigidbody2D Body;
    public PauseGame pg;
    public float HP;
    void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (!pg.isPaused)
        {
            mousePos.z = transform.position.z;
            transform.up = mousePos - transform.position;
        }
        

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
        if (HP <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            HP -= 20;
        }
    }

}
