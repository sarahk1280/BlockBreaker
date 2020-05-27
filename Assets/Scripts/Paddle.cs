using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    private float mousePosXInUnits;
    private Vector2 paddlePos;


    // Update is called once per frame
    void Update()
    {
        mousePosXInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosXInUnits, minX, maxX);
        transform.position = paddlePos;
    }
}
