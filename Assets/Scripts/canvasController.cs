using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class canvasController : MonoBehaviour
{
    public Transform playerTransform;

    private void Start()
    {
        
    }
    void Update()
    {
        MovementCanvas();
    }

    void MovementCanvas()
    {
        transform.position = playerTransform.position;
    }
}
