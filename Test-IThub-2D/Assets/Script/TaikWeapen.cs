using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaikWeapen : MonoBehaviour
{
    [SerializeField] Vector2 positionWeapen;
    [SerializeField] Vector3 rotetionWeapen;
    [SerializeField] Weapen nameweapen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.transform.GetComponentInParent<PlayerTag>() == null)
        {
            return;
        }
        transform.SetParent(collision.transform);
        transform.localPosition = positionWeapen;
        transform.localEulerAngles = rotetionWeapen;
        Destroy(transform.GetComponent<TaikWeapen>());
        nameweapen.takinweapen = true;
    }
}
