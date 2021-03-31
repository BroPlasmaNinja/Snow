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
    [SerializeField] GameObject BigCell;
    [SerializeField] dir Dir = dir.right;
    public bool Job;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log(Dir + "\n" + other.name);
            if (Dir == BB.dir.up && !Job)
            {
                GameObject gg = Instantiate(BigCell, new Vector3(transform.position.x, transform.position.y, transform.GetComponentInParent<Transform>().position.z + 100 - 43.5f), new Quaternion(0, 0, 0, 0));
                //StartCoroutine(wherePos(gg.transform.GetChild(3).position));
                Job = true;
                gg.transform.GetChild(3).GetComponent<BB>().Job = true;
            }
            if (Dir == BB.dir.down && !Job)
            {
                GameObject gg = Instantiate(BigCell, new Vector3(transform.position.x, transform.position.y, transform.GetComponentInParent<Transform>().position.z - 100 + 43.5f), new Quaternion(0, 0, 0, 0));
                //StartCoroutine(wherePos(gg.transform.GetChild(2).position));
                Job = true;
                gg.transform.GetChild(2).GetComponent<BB>().Job = true;
            }
            if (Dir == BB.dir.right && !Job)
            {
                GameObject gg = Instantiate(BigCell, new Vector3(transform.GetComponentInParent<Transform>().position.x + 100 - 43.5f, transform.position.y, transform.position.z), new Quaternion(0, 0, 0, 0));
                //StartCoroutine(wherePos(gg.transform.GetChild(1).position));
                Job = true;
                gg.transform.GetChild(1).GetComponent<BB>().Job = true;
            }
            if (Dir == BB.dir.left && !Job)
            {
                GameObject gg = Instantiate(BigCell, new Vector3(transform.GetComponentInParent<Transform>().position.x - 100 + 43.5f, transform.position.y, transform.position.z), new Quaternion(0, 0, 0, 0));
                //StartCoroutine(wherePos(gg.transform.GetChild(0).position));
                Job = true;
                gg.transform.GetChild(0).GetComponent<BB>().Job = true;
            }
        }
    }
}
