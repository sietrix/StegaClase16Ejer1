using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothing; // velocidad de seguimiento que va a tener la camara (hacia el player)

    Vector3 offset; // distancia inicial entre player y cámara
    void Start()
    {
        // el offset es igual a la posición de la cámara menos la del player,
        // realmente es el vector que une ambos
        offset = transform.position - player.position;
    }

    void Update()
    {
        Vector3 camPos = player.position + offset;

        transform.position = Vector3.Lerp(transform.position, camPos, smoothing * Time.deltaTime);
    }
}

