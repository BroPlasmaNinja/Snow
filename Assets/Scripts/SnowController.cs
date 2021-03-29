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
            rotatingR = true;
            Right();
        }
        if (Input.GetKeyDown(KeyCode.A) || rotatingL)
        {
            
            rotatingL = true;
            Left();
        }

    }
    private void Left()
    {
        if (!rotatingL || CurrentAngleY >= 90) { rotatingL = false; return; }
        float angle = RotationSpeed * Time.deltaTime;
        Debug.Log($"dEBUG {transform.rotation.eulerAngles.y + RotationSpeed * Time.deltaTime}");
        transform.Rotate(new Vector3(0,  angle, 0));
        CurrentAngleY += angle;
        
    }
    private void Right()
    {
        /*if (!rotatingL || transform.rotation.eulerAngles.y == 90) { Debug.Log("g"); rotatingL = false; return; }
        Debug.Log($"dEBUG {transform.rotation.eulerAngles.y + RotationSpeed * Time.deltaTime}");
        transform.Rotate(new Vector3(0, -RotationSpeed * Time.deltaTime, 0));*/
    }
}
