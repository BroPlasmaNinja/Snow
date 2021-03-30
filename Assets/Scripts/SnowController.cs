using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SnowController : MonoBehaviour
{
    [SerializeField] private bool rotatingL;
    [SerializeField] private bool rotatingR;

    [SerializeField] float speed;
    [SerializeField] float RotationSpeed = 90;
    [SerializeField] float CurrentAngleY;
    [SerializeField] float targetDegree = 0;

    [SerializeField] long Direction = 0;
    [SerializeField] float[] Directions;
    [SerializeField] float LookingAt;

    [SerializeField] float lastRotation;

    private void Start()
    {
        Directions = new float[4] { 0, 90, 180, 270 };
    }

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
        if (Input.GetKeyDown(KeyCode.D) && !rotatingR)
        {
            rotatingL = false;
            rotatingR = true;
            Direction++;
            targetDegree = Direction * 90;
        }
        if (Input.GetKeyDown(KeyCode.A) && !rotatingL)
        {
            rotatingL = true;
            rotatingR = false;
            Direction--;
            targetDegree = Direction * 90;
        }
        if (Direction == -1) Direction = 3;
        if (Direction == 4) Direction = 0;
        LookingAt = transform.rotation.eulerAngles.y;



        if(rotatingR)
        {
            Right();
        }
        if(rotatingL)
        {
            Left();
        }
    }
    void Right()
    {
        float ang = RotationSpeed * Time.deltaTime;
        if (LookingAt == Directions[Direction])
        {
            rotatingR = false;
            return;
        }
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(new Vector3(0, Directions[Direction], 0)), ang);


    }
    void Left()
    {
        float ang = RotationSpeed * Time.deltaTime;
        if(LookingAt == Directions[Direction])
        {
            rotatingL = false;
            return;
        }
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(new Vector3(0, Directions[Direction], 0)), ang);
        
    }
}
