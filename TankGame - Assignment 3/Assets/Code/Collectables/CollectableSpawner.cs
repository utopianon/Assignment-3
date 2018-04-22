using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    public class CollectableSpawner : MonoBehaviour
    {
        [SerializeField]
        GameObject collectable;

        [SerializeField]
        float timer;

        //center of the spawning area
        [SerializeField]
        Vector3 center;
        //size of the spawning area
        [SerializeField]
        Vector3 size;

        void Start()
        {
            InvokeRepeating("SpawnCollectables", 0.2f, timer);
        }

        void SpawnCollectables()
        {
            Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), size.y, Random.Range(-size.z / 2, size.z / 2));

            Instantiate(collectable, pos, Quaternion.identity);
        }
      
    }
}
