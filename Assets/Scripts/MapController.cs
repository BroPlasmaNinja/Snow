using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    GameObject BigCell;
    bool right, left, up, down;
    private void Start()
    {
        BigCell = gameObject;
    }
    public void OnBorderEnter(BB.dir Dir)
    {
        if(Dir == BB.dir.up && !up)
        {
            GameObject gg = Instantiate(BigCell, new Vector3 (transform.position.x,transform.position.y,transform.position.z + transform.localScale.z*10), new Quaternion(0, 0, 0, 0));
            StartCoroutine(Da(gg.transform.GetChild(3).position));
            up = true;
            gg.GetComponent<MapController>().down = true;
        }
        if(Dir == BB.dir.down && !down)
        {
            GameObject gg = Instantiate(BigCell, new Vector3 (transform.position.x,transform.position.y,transform.position.z - transform.localScale.z*10), new Quaternion(0, 0, 0, 0));
            StartCoroutine(Da(gg.transform.GetChild(2).position));
            down = true;
            gg.GetComponent<MapController>().up = true;
        }
        if(Dir == BB.dir.right && !right)
        {
            GameObject gg = Instantiate(BigCell, new Vector3 (transform.position.x + transform.localScale.x * 10, transform.position.y,transform.position.z), new Quaternion(0, 0, 0, 0));
            StartCoroutine(Da(gg.transform.GetChild(1).position));
            left = true;
            gg.GetComponent<MapController>().left = true;
        }
        if(Dir == BB.dir.left && !left)
        {
            GameObject gg = Instantiate(BigCell, new Vector3 (transform.position.x - transform.localScale.x * 10, transform.position.y,transform.position.z), new Quaternion(0, 0, 0, 0));
            StartCoroutine(Da(gg.transform.GetChild(0).position));
            right = true;
            gg.GetComponent<MapController>().right = true;
        }
    }
    IEnumerator Da(Vector3 pos)
    {
        while (true)
        {
            Debug.DrawRay(pos, new Vector3(0, 10, 0), Color.green);
            Debug.Log("Draw");
            yield return new WaitForSeconds(0.01f);
        }
    }
}
