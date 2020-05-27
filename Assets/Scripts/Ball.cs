using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;
    [SerializeField] float velx = 2f;
    [SerializeField] float vely = 10f;
    private Vector2 paddleToBallVector;
    private bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButton(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velx, vely);
            hasStarted = true;
        }

    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x,
                paddle1.transform.position.y);

        transform.position = paddlePos + paddleToBallVector;
    }
}
