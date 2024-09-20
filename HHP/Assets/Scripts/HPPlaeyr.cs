using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HPPlaeyr : MonoBehaviour
{
    public Playr playr;

    Image HPbar;
    public float maxHealth = 100f;
    void Start()
    {
        HPbar = GetComponent<Image>();
        maxHealth = playr.HP;
    }

    void Update()
    {
        HPbar.fillAmount = playr.HP / maxHealth;
    }

}