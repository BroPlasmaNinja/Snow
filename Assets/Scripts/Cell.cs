using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] public int dmg;
    [SerializeField] public int speed = 1;
    [SerializeField] public float reSize = 0.01f;
    [SerializeField] public float cumReSize = 0.01f;
    [SerializeField] [Range(0, 100)] public int chance = 80;

    int NumToBoolBad(float num)
    {
        if(num <= 0)
        {
            return -1;
        } else
        {
            return 1;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        GameObject obj = other.gameObject;


        FindObjectOfType<UIController>().score -= dmg;
        obj.GetComponent<SnowController>().speed += speed;

        int k = -NumToBoolBad(dmg);

        obj.transform.localScale += new Vector3(1f, 0, 1f) * reSize * k;
        obj.transform.GetChild(0).GetComponent<Camera>().orthographicSize += cumReSize * k;
        Destroy(gameObject);

    }



}
