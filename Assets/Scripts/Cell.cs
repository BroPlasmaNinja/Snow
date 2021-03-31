using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] public int dmg = 0;
    [SerializeField] public int speed = 1;
    [SerializeField] [Range(0, 100)] public int chance = 80;
}
