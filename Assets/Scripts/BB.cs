using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BB : MonoBehaviour
{
    enum dir
    {
        right,
        left,
        up,
        down
    }
    [SerializeField] dir Dir = dir.right;
}
