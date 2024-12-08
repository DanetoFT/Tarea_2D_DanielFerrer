using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int dmg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Damage");
        EnemyHealth enemy = other.GetComponent<EnemyHealth>();

        enemy.vidaActual -= dmg;
        enemy.enemyAnimator.SetTrigger("Hit");

        Debug.Log("Vida del enemigo: " + enemy.vidaActual.ToString());

        if (enemy.vidaActual <= 0)
        {
            enemy.enemyAnimator.SetTrigger("Death");
        }
    }
}
