using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botiquin : MonoBehaviour
{
    public int cura;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerController player = collision.gameObject.GetComponent<PlayerController>();

        if(player!= null && player.vidaActual < player.vidaMax)
        {
            player.vidaActual += cura;
            Debug.Log("Te has curado " + cura);
            Destroy(this);
        }
    }
}
