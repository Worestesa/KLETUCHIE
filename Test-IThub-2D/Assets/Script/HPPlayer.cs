using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPPlayer : MonoBehaviour
{
    [SerializeField] private float maxHP;
    float n;
    private void Start()
    {
        n = maxHP;
    }
    void DPSPlayer(float dps)
    {
        n = n - dps;
        if(n <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
