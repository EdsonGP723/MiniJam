using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
   public GameObject[] Asteroids;
    public Transform Spawn;
    public float interval;
    float timer;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            Instantiate(Asteroids[Random.Range(0,4)], Spawn.position, Quaternion.identity);
            timer -= interval;
        }
    }
}
