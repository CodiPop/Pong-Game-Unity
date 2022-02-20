
using UnityEngine;
using TMPro;

public class gamemanager : MonoBehaviour
{
    [SerializeField] private TMP_Text Jugador1ScoreText;
    [SerializeField] private TMP_Text Jugador2ScoreText;

    [SerializeField] private Transform jugador1Transform;
    [SerializeField] private Transform jugador2Transform;
    [SerializeField] private Transform ballTransform;

    private int Jugador1Score;
    private int Jugador2Score;

    private static gamemanager instance;

    public static gamemanager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<gamemanager>();
            }
            return instance;
        }
    }

    public void jugador1scored()
    {
        Jugador1Score++;
        Jugador1ScoreText.text = Jugador1Score.ToString();
    }

    public void jugador2scored()
    {
        Jugador2Score++;
        Jugador2ScoreText.text = Jugador2Score.ToString();
    }

    public void restart()
    {
        jugador1Transform.position = new Vector2(jugador1Transform.position.x, 0);
        jugador2Transform.position = new Vector2(jugador2Transform.position.x, 0);
        ballTransform.position = new Vector2(0, 0);
    }
}
