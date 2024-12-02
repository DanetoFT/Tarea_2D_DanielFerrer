using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] listweapon;
    public Transform spawnWeapon;
    public Transform[] spawnArray;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemies()
    {
        int numeroRandom = Random.Range(0, listweapon.Length);
        int spawnRandom = Random.Range(0, spawnArray.Length);

        Instantiate(listweapon[numeroRandom], spawnArray[spawnRandom]);


        for (int i = 0; i < listweapon.Length; i++)
        {
            var objetoInstanciado = Instantiate(listweapon[i], spawnArray[i].position + new Vector3(i, 0, 0), spawnArray[i].rotation);

            objetoInstanciado.GetComponent<EnemyHealth>().randomDamage();
        }
    }
}
