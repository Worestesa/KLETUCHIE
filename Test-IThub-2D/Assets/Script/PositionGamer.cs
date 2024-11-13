using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGamer : MonoBehaviour
{
    [SerializeField] IventGame gamerPosition;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gamerPosition.DeadPlayr = false;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        gamerPosition.DeadPlayr = true;
    }
}
