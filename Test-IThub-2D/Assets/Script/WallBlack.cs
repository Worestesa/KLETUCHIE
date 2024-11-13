using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBlack : MonoBehaviour
{
    [SerializeField] GameObject blakWall;

    bool playerInCollider = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerInCollider = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerInCollider = false;
    }

    private void Update()
    {
        if(playerInCollider == true)
        {
            blakWall.SetActive(true);
        }
        else
        {
            blakWall.SetActive(false);
        }
    }
}
