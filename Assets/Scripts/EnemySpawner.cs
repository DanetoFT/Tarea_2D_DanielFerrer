using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Spawn")]
    public GameObject[] enemyList;
    public Transform[] spawnPoints;
    public GameObject[] spawnedEnemies;
    void Start()
    {
        if (enemyList.Length != spawnPoints.Length)
        {
            Debug.LogError("Los enemigos no coinciden con los spawns");
            return;
        }

        spawnedEnemies = new GameObject[enemyList.Length];

        for (int i = 0; i < enemyList.Length; i++)
        {
            Vector3 spawnPoint = spawnPoints[i].position;
            var objetoInstanciado = Instantiate(enemyList[i], spawnPoint, spawnPoints[i].rotation);

            spawnedEnemies[i] = objetoInstanciado;

            var enemyController = objetoInstanciado.GetComponent<EnemyHealth>();
        }
    }
    public void MostrarEnemigosInstanciados()
    {
        for (int i = 0; i < spawnedEnemies.Length; i++)
        {
            if (spawnedEnemies[i] != null)
            {
                Debug.Log($"Enemigo {i} instanciado: {spawnedEnemies[i].name}");
            }
        }
    }

    public void CambioDamage()
    {
        for(int i = 0; i < spawnedEnemies.Length; i++)
        {
            if (spawnedEnemies[i] != null)
            {
                var enemyHealth = spawnedEnemies[i].GetComponent<EnemyHealth>();

                enemyHealth.ChangeDamage();

                Debug.Log("Daño de " + spawnedEnemies[i] + " aumentado");
            }
        }
    }
}
