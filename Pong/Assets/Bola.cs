using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    [SerializeField] private float Velocidadincial = 4.5f;
    private Rigidbody2D pelotaRb;

    void Start()
    {
        pelotaRb = GetComponent<Rigidbody2D>();
        Launch();
    }

    private void Launch()
    {
        float xVelocidad = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocidad = Random.Range(0, 2) == 0 ? 1 : -1;
        pelotaRb.velocity = new Vector2(xVelocidad, yVelocidad) * Velocidadincial;
    }


    void Update()
    {

    }
}
