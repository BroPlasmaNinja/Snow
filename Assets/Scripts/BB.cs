using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BB : MonoBehaviour
{
    public enum dir
    {
        right,
        left,
        up,
        down
    }
    [SerializeField] dir Dir = dir.right;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponentInParent<MapController>().OnBorderEnter(Dir);
            Debug.Log(Dir + "\n" + other.name);
        }

    }
}
