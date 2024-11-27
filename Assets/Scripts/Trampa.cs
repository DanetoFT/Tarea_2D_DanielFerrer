using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    PlayerController player;

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
        player = other.GetComponent<PlayerController>();
        Damage();
    }

    public void Damage()
    {
        if(player.vidaActual <= 0)
        {
            Debug.Log("Has Muerto");
        }
        else
        {
            player.vidaActual -= dmg;
            Debug.Log(player.vidaActual);
        }
    }
}
