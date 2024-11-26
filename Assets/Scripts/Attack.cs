using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public EnemyHealth enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Damage");

        enemy.vidaActual--;
        enemy.enemyAnimator.SetTrigger("Hit");

        Debug.Log(enemy.vidaActual.ToString());

        if (enemy.vidaActual <= 0)
        {
            enemy.enemyAnimator.SetTrigger("Death");
        }
    }
}
