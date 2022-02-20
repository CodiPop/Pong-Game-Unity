using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugadores : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    [SerializeField] private bool isjugador1;
    float movement;
    private float yBound = 3.8f;
    // Update is called once per frame
    void Update()
    {

        if(isjugador1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }


        Vector2 jugadorPosition = transform.position;
        jugadorPosition.y = Mathf.Clamp(jugadorPosition.y + movement * speed * Time.deltaTime, -yBound, yBound);
        transform.position = jugadorPosition;
    }
}
