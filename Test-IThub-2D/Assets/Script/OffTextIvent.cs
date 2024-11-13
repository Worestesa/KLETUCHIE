using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffTextIvent:MonoBehaviour
{
    [SerializeField] float coldaunOff;
    [SerializeField] GameObject textIvent;
    [SerializeField] float offTextIventMax;
    // Update is called once per frame
    void Update()
    {
        coldaunOff = coldaunOff - Time.deltaTime;
        if (coldaunOff <= 0)
        {
            textIvent.SetActive(false);
            coldaunOff = offTextIventMax;
        }
    }
}
