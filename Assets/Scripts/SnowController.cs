using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowController : MonoBehaviour
{
    [SerializeField] private bool rotatingL;
    [SerializeField] private bool rotatingR;

    [SerializeField] float speed;
    [SerializeField] float RotationSpeed = 90;
    [SerializeField] float CurrentAngleY;
    void Update()
    {


        transform.position += transform.forward * Time.deltaTime * speed;
        if (Input.GetKeyDown(KeyCode.D) || rotatingR)
        {
            Right();
        }
        if (Input.GetKeyDown(KeyCode.A) || rotatingL)
        {
            Left();
        }

    }
    private void Left()
    {
        transform.Rotate(0,-90,0);   
    }
    private void Right()
    {
        transform.Rotate(0, 90, 0);
    }
}
