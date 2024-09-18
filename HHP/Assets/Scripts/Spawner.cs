using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] float radius = 50;
    [SerializeField] float cooldown = 0.5f;

    void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    void Spawn()
    {
        GameObject buf = Instantiate(prefab);
        float x = Random.Range(-radius, radius);
        float y = Random.Range(-radius, radius);
        buf.transform.position = transform.position + new Vector3(x, y, 0);
    }

    IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(cooldown);
        }
    }
}