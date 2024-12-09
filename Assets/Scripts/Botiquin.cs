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

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController player = other.gameObject.GetComponent<PlayerController>();

        if (player.vidaActual < player.vidaMax)
        {
            player.vidaActual += cura;
            Debug.Log("Te has curado " + cura);
            Destroy(gameObject);
        }
    }
}
