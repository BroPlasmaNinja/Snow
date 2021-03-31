using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        GameObject obj = other.gameObject;
        FindObjectOfType<UIController>().score += 2;
        obj.transform.localScale += new Vector3(0.01f, 0, 0.01f);
        obj.transform.GetChild(0).GetComponent<Camera>().orthographicSize += 0.01f ;
        Destroy(gameObject);
        
    }
}
