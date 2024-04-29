using BaursakRun.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace BaursakRun.Controllers
{
    public class ObstController : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;
        [SerializeField] private List<Transform> _spawnPoints;
        
        
        private void Start()
        {
            StartCoroutine(Spawn());
           
        }

        public IEnumerator Spawn()
        {
            while (true)
            {
                var pointIndex = Random.Range(0, _spawnPoints.Count);
               var objectIndex = Random.Range(0, _objects.Length);

                Instantiate(_objects[objectIndex], _spawnPoints[pointIndex].transform.position, Quaternion.identity);             

                yield return new WaitForSeconds(Random.Range(1, 2.5f));
            }
        }
    }
}

