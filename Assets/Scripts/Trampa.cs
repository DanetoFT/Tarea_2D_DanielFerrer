using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trampa : MonoBehaviour
{
    PlayerController player;

    int dmg;

    public TextMeshProUGUI texto;

    public Animator textAnimator;

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
        dmg = Random.Range(1, 3);
        player = other.GetComponent<PlayerController>();
        Damage();
    }

    public void Damage()
    {
        if(player.vidaActual > 0)
        {
            player.animatorPlayer.SetTrigger("Hit");
            player.vidaActual -= dmg;
            texto.text = "-" + dmg.ToString();
            textAnimator.SetTrigger("Damage");
            Debug.Log(player.vidaActual);
        }
        else if(player.vidaActual <= 0)
        {
            player.animatorPlayer.SetTrigger("Death");
            Debug.Log("Has muerto");
        }
    }
}
