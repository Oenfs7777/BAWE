using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Player1 : MonoBehaviour
{
    public GameObject Player, attackObj;

    // 紀錄觸控一開始的座標（用於後面計算拖曳方向）
    Vector2 startTouchPos;

    //玩家目標位置
    Pos desPos = Pos.DL;

    // Update is called once per frame
    void Update()
    {
        //觸控
        Direction dir = GetTouchSwipeDirection();

        //鍵盤
        if (dir == Direction.None)
            dir = KeyBoardCon();

        //控制方向
        if (dir == Direction.Up)
            GoU();
        if (dir == Direction.Down)
            GoD();
        if (dir == Direction.Left)
            GoL();
        if (dir == Direction.Right)
            GoR();

        if (dir == Direction.UpRight)
            attack();
        if (dir == Direction.UpLeft)
            attack();
        if (dir == Direction.DownRight)
            attack();
        if (dir == Direction.DownLeft)
            attack();

        UpdatePos();
    }

    //鍵盤控制
    private Direction KeyBoardCon()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            return Direction.UpLeft;
        if (Input.GetKeyDown(KeyCode.Z))
            return Direction.DownLeft;
        if (Input.GetKeyDown(KeyCode.E))
            return Direction.UpRight;
        if (Input.GetKeyDown(KeyCode.C))
            return Direction.DownRight;
        if (Input.GetKeyDown(KeyCode.W))
            return Direction.Up;
        if (Input.GetKeyDown(KeyCode.X))
            return Direction.Down;
        if (Input.GetKeyDown(KeyCode.A))
            return Direction.Left;
        if (Input.GetKeyDown(KeyCode.D))
            return Direction.Right;
        return Direction.None;
    }

    //滑動控制
    private Direction GetTouchSwipeDirection()
    {
        //Touch touch = Input.GetTouch(0);

        // 如果有觸碰 (touches陣列有內容)
        if (EventSystem.current.currentSelectedGameObject == null & Input.touches.Length > 0)
        {
            // 觸碰開始（只執行一次）
            if ((Input.touches[0]).phase == TouchPhase.Began)
            {
                // 紀錄觸碰座標
                startTouchPos = Input.touches[0].position;
            }

            // 觸碰結束（只執行一次）
            if (Input.touches[0].phase == TouchPhase.Ended)
            {
                // 計算觸碰滑動距離
                Vector2 delta = startTouchPos - Input.touches[0].position;

                //左右 or 斜向滑動
                if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
                {
                    //Debug.Log("touched");
                    //向左
                    if (delta.x > 0)
                    {
                        if (delta.y > -200 && delta.y < 200)
                        {
                            Debug.Log("Left");
                            return Direction.Left;
                        }
                        else if (delta.y < -200)
                        {
                            Debug.Log("UpL");
                            return Direction.UpLeft;
                        }
                        else if (delta.y > 200)
                        {
                            Debug.Log("DownL");
                            return Direction.DownLeft;
                        }
                    }
                    //向右
                    else
                    {
                        if (delta.y > -200 && delta.y < 200)
                        {
                            Debug.Log("Right");
                            return Direction.Right;
                        }
                        else if (delta.y < -200)
                        {
                            Debug.Log("UpR");
                            return Direction.UpRight;
                        }
                        else if (delta.y > 200)
                        {
                            Debug.Log("DownR");
                            return Direction.DownRight;
                        }
                    }
                }
                //上下滑動
                else
                {
                    if (delta.y > 0)
                    {
                        Debug.Log("Down");
                        return Direction.Down;
                    }
                    else
                    {
                        Debug.Log("Up");
                        return Direction.Up;
                    }
                }
            }
        }
        return Direction.None;
    }

    //更新玩家位置
    private void UpdatePos()
    {
        //目標位置 to 座標
        float dx = 5, dy = -3;
        if (desPos == Pos.DL)
        {
            dx = -5; dy = -3;
        }
        if (desPos == Pos.DR)
        {
            dx = 7.5f; dy = -3;
        }
        if (desPos == Pos.UL)
        {
            dx = -5; dy = 3;
        }
        if (desPos == Pos.UR)
        {
            dx = 7.5f; dy = 3;
        }

        float x = Mathf.Lerp(transform.position.x, dx, 0.05f);
        float y = Mathf.Lerp(transform.position.y, dy, 0.05f);
        float z = transform.position.z + 0.05f;
        transform.position = new Vector3(x, y, z);
    }

    private void attack()
    {
        GameObject a = Instantiate(attackObj);
        a.transform.position = new Vector3(Player.transform.position.x + 2, Player.transform.position.y + 2, Player.transform.position.z);
    }

    //前往的方向控制
    private void GoU()
    {
        if (desPos == Pos.DL)
            desPos = Pos.UL;
        else if (desPos == Pos.DR)
            desPos = Pos.UR;
    }
    private void GoD()
    {
        if (desPos == Pos.UL)
            desPos = Pos.DL;
        else if (desPos == Pos.UR)
            desPos = Pos.DR;
    }
    private void GoL()
    {
        if (desPos == Pos.DR)
            desPos = Pos.DL;
        else if (desPos == Pos.UR)
            desPos = Pos.UL;
    }
    private void GoR()
    {
        if (desPos == Pos.DL)
            desPos = Pos.DR;
        else if (desPos == Pos.UL)
            desPos = Pos.UR;
    }
    private void GoUR()
    {
        if (desPos == Pos.DL)
            desPos = Pos.UR;
    }
    private void GoUL()
    {
        if (desPos == Pos.DR)
            desPos = Pos.UL;
    }
    private void GoDR()
    {
        if (desPos == Pos.UL)
            desPos = Pos.DR;
    }
    private void GoDL()
    {
        if (desPos == Pos.UR)
            desPos = Pos.DL;
    }
}