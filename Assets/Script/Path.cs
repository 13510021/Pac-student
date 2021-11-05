using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 位置信息
/// </summary>
[Serializable]
public class PointPos
{
    public int X;
    public int Y;
}

public class Path : MonoBehaviour
{
    public List<PointPos> moveEnableGrid;//可以通过的格子
    Dictionary<string, bool> gridInfO;//存储格子是否可以通行

    public int gridX, gridY;//水平 竖直方向的格子数量

    // Start is called before the first frame update
    void Start()
    {
        gridInfO = new Dictionary<string, bool>();
        for (int i = 0; i < moveEnableGrid .Count ; i++)
        {
            gridInfO.Add(moveEnableGrid[i].X + "_" + moveEnableGrid[i].Y, true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    ///  判断格子是否可以通行
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public bool MoveEnable(int x ,int y )
    {
        if(gridInfO .ContainsKey (x +"_"+y))
        {
            return true;
        }else
        {
            return false;
        }
    }
   
}
