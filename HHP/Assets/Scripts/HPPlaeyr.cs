using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HPPlaeyr : MonoBehaviour
{
    [SerializeField] private float HP = 100;
    [SerializeField] private Image HPBar;
    public void damage(float DPS)
    {
        HP = HP - DPS;
        HPBar.fillAmount = HP / 100;
        if (HP <= 0)
        {
            Dead();
        }
    }
    private void Dead()
    {
        SceneManager.LoadScene("SampleScene");
    }
}