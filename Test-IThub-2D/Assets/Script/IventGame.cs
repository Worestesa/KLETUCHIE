using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class IventGame : MonoBehaviour
{
    [SerializeField] float coldaunIvent;
    [SerializeField] float timeIvent;
    [SerializeField] TMP_Text textTimeIvent;
    [SerializeField] GameObject textIvent;
    public UnityEvent spawenemi;
    public bool CanKill()
    {
        return coldaunTime > timeIvent && _startWaitTime < 0;
    }

    public bool DeadPlayr = true;

    private float coldaunTime = 1000000000;

    private float _startWaitTime = 15;
    private int spawned = 0;

    // Update is called once per frame
    void Update()
    {
        if (_startWaitTime < 0)
        {

            coldaunTime = Time.deltaTime + coldaunTime;
            if (coldaunTime > coldaunIvent + timeIvent)
            {
                coldaunTime = 0;
                textIvent.SetActive(true);
            }
            textTimeIvent.text = $"Ивент скоро начнеться: {Mathf.Max(0, timeIvent - coldaunTime)}";
            if (coldaunTime > timeIvent)
            {
                if (DeadPlayr == true)
                {
                    SceneManager.LoadScene("SampleScene");
                }
                if (spawned == 0)
                {
                    spawenemi.Invoke();
                    spawned++;
                }
            }
            else
            {
                spawned = 0;
            }
        }

        _startWaitTime = _startWaitTime - Time.deltaTime;   
    }
}
