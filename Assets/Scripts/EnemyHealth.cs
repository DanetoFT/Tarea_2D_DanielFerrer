using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int vidaMax;
    public int vidaActual;
    public Animator enemyAnimator;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaMax;
    }

    public void ChangeDamage()
    {
        damage++;
    }

    public int getDamage()
    {
        return damage;
    }
}
