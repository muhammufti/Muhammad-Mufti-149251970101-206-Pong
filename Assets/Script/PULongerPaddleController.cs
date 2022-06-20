using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PULongerPaddleController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float magnitude;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<BallControl>().transform.localScale += new Vector3(0, 2, 0);
            manager.RemovePowerUp(gameObject);
        }
    }
}
