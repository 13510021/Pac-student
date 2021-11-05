using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// λ����Ϣ
/// </summary>
[Serializable]
public class PointPos
{
    public int X;
    public int Y;
}

public class Path : MonoBehaviour
{
    public List<PointPos> moveEnableGrid;//����ͨ���ĸ���
    Dictionary<string, bool> gridInfO;//�洢�����Ƿ����ͨ��

    public int gridX, gridY;//ˮƽ ��ֱ����ĸ�������

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
    ///  �жϸ����Ƿ����ͨ��
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
