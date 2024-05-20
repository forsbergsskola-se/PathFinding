using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    public int health;
    public bool[] walkableGrid = new bool[100];
    public int width = 10;

    public bool IsWalkable(int x, int y)
    {
        return walkableGrid[y * width + x];
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
