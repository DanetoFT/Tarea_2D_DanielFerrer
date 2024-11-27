using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int vidaMax;
    public int vidaActual;
    public Animator enemyAnimator;

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaMax;
    }
}
