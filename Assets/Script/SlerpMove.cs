using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlerpMove : MonoBehaviour
{
    public float moveSpeed = 1;
    public Vector3 targetPos;
    public bool arrived = false;//�Ƿ񵽴�Ŀ���
    public float precision = 0.1f;//���㾫��
    private float rate;//����
    public float size = 2;//��ɫ�ߴ�
    // Start is called before the first frame update
    void Start()
    {
        targetPos = transform.position;
        arrived = true;
    }

    // Update is called once per frame
    void Update()
    {
        RayCheck(); 
        if (Vector3.Distance(transform.position, targetPos) < precision)
        {
            arrived = true;
            rate = 0;
        }else
        {
            rate += Time.deltaTime * moveSpeed;
            transform.position = Vector3.Slerp(startpos, targetPos, rate);
        }
        
    }
    private Vector3 startpos;
    //private void GridMove()
    //{

    //    if (Input.GetKey(KeyCode.A) && arrived)
    //    {
    //        gridX -= 1;
    //        arrived = false;
    //        if (path.MoveEnable(gridX, gridY))
    //        {
    //            startpos = targetPos;
    //               targetPos += Vector3.left * size;
    //        }
    //    }
    //    else if (Input.GetKey(KeyCode.D) && arrived)
    //    {
    //        gridX += 1;
    //        arrived = false;
    //        if (path.MoveEnable(gridX, gridY))
    //        {
    //            startpos = targetPos;
    //            targetPos += Vector3.right * size;
    //        }
    //    }
    //    else if (Input.GetKey(KeyCode.W) && arrived)
    //    {
    //        gridY += 1;
    //        arrived = false;
    //        if (path.MoveEnable(gridX, gridY))
    //        {
    //            startpos = targetPos;
    //            targetPos += Vector3.up * size;
    //        }
    //    }
    //    else if (Input.GetKey(KeyCode.S) && arrived)
    //    {
    //        gridY -= 1;
    //        arrived = false;
    //        if (path.MoveEnable(gridX, gridY))
    //        {
    //            startpos = targetPos;
    //            targetPos += Vector3.down * size;
    //        }
    //    }
       
    //}

    public LayerMask wallLayer;
    private void RayCheck()
    {
        if (Input.GetKey(KeyCode.A) && arrived)
        {
            if (CheckHorizontal(Vector3.left))
            {
                startpos = targetPos;
                targetPos += Vector3.left * size;
                arrived = false;
            }
        }
        else if (Input.GetKey(KeyCode.D) && arrived)
        {
            if (CheckHorizontal (Vector3.right ))
            {
                startpos = targetPos;
                targetPos += Vector3.right  * size;
                arrived = false;
            }
        }
        else if (Input.GetKey(KeyCode.W) && arrived)
        {
            if (CheckVertical(Vector3.up ))
            {
                startpos = targetPos;
                targetPos += Vector3.up  * size;
                arrived = false;
            }
        }
        else if (Input.GetKey(KeyCode.S) && arrived)
        {
            if (CheckVertical (Vector3 .down ))
            {
                startpos = targetPos;
                targetPos += Vector3.down  * size;
                arrived = false;
            }
        }
       
    }
    /// <summary>
    /// ��ⷽ�������
    /// </summary>
    public Transform[] horcheckTr;
    public Transform[] vercheckTr;

    public float checkH_Dis,checkV_Dis;
    /// <summary>
    /// ˮƽ��� ֻ�����е�ˮƽ�����϶�δ������ǽ����ͨ��
    /// </summary>
    /// <returns></returns>
    bool CheckHorizontal(Vector3 dir)
    {
        for (int i = 0; i < horcheckTr.Length ; i++)
        {
            if (Physics2D.Raycast(horcheckTr[i].position, dir, checkH_Dis, wallLayer))
            {
                return false;
            }
        }
        Debug.Log("keyi");
        return true;
    }
    //��ֱ����
    bool CheckVertical(Vector3 dir)
    {
        for (int i = 0; i < vercheckTr .Length; i++)
        {
            if (Physics2D.Raycast(vercheckTr[i].position, dir, checkV_Dis, wallLayer))
            {
                return false;
            }
        }
        Debug.Log("keyi");
        return true;
    }
}
