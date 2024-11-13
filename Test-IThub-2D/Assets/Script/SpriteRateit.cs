using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpriteRateit : MonoBehaviour
{
    [SerializeField]SpriteRenderer spriteRenderer;
    [SerializeField] Transform gamer;
    void Update()
    {
        Vector3 VectorMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(gamer.position.x < VectorMouse.x)
        {
            spriteRenderer.flipX = false;
        }
        if (gamer.position.x > VectorMouse.x)
        {
            spriteRenderer.flipX = true;
        }

    }
}
