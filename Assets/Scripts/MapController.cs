using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    [SerializeField] int MapSize = 20;
    GameObject[,] MyMap;
    [SerializeField] GameObject[] AllCells;

    private void OnEnable()
    {
        Random.InitState((int)Time.realtimeSinceStartup);
        MyMap = new GameObject[MapSize, MapSize];
        Debug.LogWarning("Новый объект");
        for (int i = 0; i < MapSize; i++)
        {
            for (int j = 0; j < MapSize; j++)
            {
                MyMap[i, j] = gg(AllCells);
                float x = 5f * (i - MapSize / 2f) + 2.5f + transform.position.x;
                float z = 5f * (j - MapSize / 2f) + 2.5f + transform.position.z;
                Instantiate(MyMap[i, j], new Vector3(x + Random.Range(-2, 2), transform.position.y, z + Random.Range(-2, 2)), new Quaternion(0, 0, 0, 0), transform.GetChild(4));
            }
        }
        Debug.LogWarning("КОНЕЦ");
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
