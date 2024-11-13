using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemiTeleport : MonoBehaviour
{
    [SerializeField] Transform positioncub;
    [SerializeField] GameObject enemi;
    [SerializeField] IventGame gameiven;
    [SerializeField] Transform gamerposition;

    void Start()
    {
        gameiven.spawenemi.AddListener(enemispawn);
    }

    private void enemispawn()
    {
        GameObject amocloen = Instantiate(enemi);
        amocloen.transform.position = positioncub.position;
        amocloen.GetComponent<ScriptAI>().game = gameiven;
        amocloen.GetComponent<ScriptAI>().target = gamerposition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
