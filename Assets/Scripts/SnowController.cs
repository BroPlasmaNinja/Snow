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
        if (Input.GetKeyDown(KeyCode.D) && !rotatingR && !rotatingL)
        {
<<<<<<< HEAD
            CurrentAngleY = 0;
            rotatingL = true; // pravo
=======
            Right();
>>>>>>> main
        }

        
        if (Input.GetKeyDown(KeyCode.A) && !rotatingL && !rotatingR)
        {
            CurrentAngleY = 0;
            rotatingR = true; // levo
        }

        if (rotatingL)
        {
            Left();
        }
        if(rotatingR)
        {
            Right();
        }

    }
    private void Left()
    {
<<<<<<< HEAD
        if (!rotatingL || CurrentAngleY >= 90) {
            transform.Rotate(new Vector3(0, 90 - CurrentAngleY, 0));
            rotatingL = false; 
            return; 
            
        }
        float angle = RotationSpeed * Time.deltaTime;
        transform.Rotate(new Vector3(0,  angle, 0));
        CurrentAngleY += angle;
        
    }
    private void Right()
    {
        if (!rotatingR || CurrentAngleY <= -90)
        {
            transform.Rotate(new Vector3(0, -90 - CurrentAngleY, 0));
            rotatingR = false;
            return;

        }
        float angle = -RotationSpeed * Time.deltaTime;
        transform.Rotate(new Vector3(0, angle, 0));
        CurrentAngleY += angle;
=======
        transform.Rotate(0,-90,0);   
    }
    private void Right()
    {
        transform.Rotate(0, 90, 0);
>>>>>>> main
    }
}
