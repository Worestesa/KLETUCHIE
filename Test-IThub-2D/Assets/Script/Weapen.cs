using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapen : MonoBehaviour
{
    [SerializeField] Vector2 spavnAmo;
    [SerializeField] GameObject Amo;
    [SerializeField] float speedAmo;
    public bool takinweapen;
    // Update is called once per frame
    void Update()
    {
        if(takinweapen == true)
        {

            if (Input.GetMouseButtonDown(0))
            {
                Vector3 VectorMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                VectorMouse.z = 0;
                Vector2 NaprovlenieAmo = (Vector2)VectorMouse - ((Vector2)transform.position + spavnAmo);
                GameObject amocloen = Instantiate(Amo);
                amocloen.transform.position = spavnAmo + (Vector2)transform.position;
                amocloen.GetComponent<Rigidbody2D>().velocity = NaprovlenieAmo.normalized * speedAmo;
            }
        }
        
    }
}
