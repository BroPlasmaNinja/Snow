using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    [SerializeField] private GameObject BigCell;
    [SerializeField] int MapSize = 20;
    GameObject[,] MyMap;
    [SerializeField] GameObject[] AllCells;

    private void OnEnable()
    {
        MyMap = new GameObject[MapSize, MapSize];
        Debug.LogWarning("Новый объект");
        for (int i = 0; i < MapSize; i++)
        {
            for (int j = 0; j < MapSize; j++)
            {
                MyMap[i, j] = gg(AllCells);
                float x = 5f * (i - MapSize / 2f) + 2.5f;
                float z = 5f * (j - MapSize / 2f) + 2.5f;
                Instantiate(MyMap[i, j], new Vector3(x + Random.Range(-2, 2), transform.position.y, z + Random.Range(-2, 2)), new Quaternion(0, 0, 0, 0), transform.GetChild(4));
            }
        }
        Debug.LogWarning("КОНЕЦ");

    }


    public void OnBorderEnter(BB.dir Dir)
    {
        /*if(Dir == BB.dir.up && !up)
        {
            GameObject gg = Instantiate(BigCell, new Vector3 (transform.position.x,transform.position.y,transform.position.z + transform.localScale.z*100), new Quaternion(0, 0, 0, 0));
            //StartCoroutine(wherePos(gg.transform.GetChild(3).position));
            up = true;
            gg.GetComponent<MapController>().down = true;
        }
        if(Dir == BB.dir.down && !down)
        {
            GameObject gg = Instantiate(BigCell, new Vector3 (transform.position.x,transform.position.y,transform.position.z - transform.localScale.z*100), new Quaternion(0, 0, 0, 0));
            //StartCoroutine(wherePos(gg.transform.GetChild(2).position));
            down = true;
            gg.GetComponent<MapController>().up = true;
        }
        if(Dir == BB.dir.right && !right)
        {
            GameObject gg = Instantiate(BigCell, new Vector3 (transform.position.x + transform.localScale.x * 100, transform.position.y,transform.position.z), new Quaternion(0, 0, 0, 0));
            //StartCoroutine(wherePos(gg.transform.GetChild(1).position));
            left = true;
            gg.GetComponent<MapController>().left = true;
        }
        if(Dir == BB.dir.left && !left)
        {
            GameObject gg = Instantiate(BigCell, new Vector3 (transform.position.x - transform.localScale.x * 100, transform.position.y,transform.position.z), new Quaternion(0, 0, 0, 0));
            //StartCoroutine(wherePos(gg.transform.GetChild(0).position));
            right = true;
            gg.GetComponent<MapController>().right = true;
        }*/
    }
    IEnumerator wherePos(Vector3 pos)
    {
        while (true)
        {
            Debug.DrawRay(pos, new Vector3(0, 10, 0), Color.green);
            Debug.Log("Draw");
            yield return new WaitForSeconds(0.01f);
        }
    }
    GameObject gg(GameObject[] da)
    {
        int CountOfChance = 0;
        for(int i = 0; i < da.Length; i++)
        {
            CountOfChance += da[i].GetComponent<Cell>().chance;
        }
        CountOfChance = Random.Range(1,CountOfChance+1);
        for (int i = 0;i < da.Length; i++)
        {
            CountOfChance -= da[i].GetComponent<Cell>().chance;
            if (CountOfChance <= 0)
                return da[i];
        }
        Debug.LogWarning("Рандом не зарандомил поэтому дефолт");
        GameObject Def = new GameObject();
        return Def;
    }
}
