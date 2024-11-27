using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trampa : MonoBehaviour
{
    PlayerController player;

    int dmg;

    public TextMeshProUGUI texto;

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
        dmg = Random.Range(1, 5);
        player = other.GetComponent<PlayerController>();
        Damage();
    }

    public void Damage()
    {
        if(player.vidaActual <= 0)
        {
            player.isDead = true;
            player.animatorPlayer.SetTrigger("Death");
            Debug.Log("Has Muerto");
        }
        else
        {
            player.animatorPlayer.SetTrigger("Hit");
            player.vidaActual -= dmg;
            Debug.Log(player.vidaActual);
        }
    }
}
