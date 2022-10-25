using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //玩家位置
    public enum Pos
    {
        UR,
        UL,
        DR,
        DL
    }

    public enum Direction
    {
        None,
        Up,
        Down,
        Left,
        Right,
        UpRight,
        UpLeft,
        DownRight,
        DownLeft
    }

    // 紀錄觸控一開始的座標（用於後面計算拖曳方向）
    Vector2 startTouchPos;

    //玩家起始位置
    Pos Start = Pos.DL;

    // Update is called once per frame
    void Update()
    {
        Direction dir = GetTouchSwipeDirection();
    }

    private Direction GetTouchSwipeDirection()
    {
        Touch touch = Input.GetTouch(0);
        //bool isTouchUIElement = EventSystem.current.IsPointerOverGameObject(touch.fingerId);

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
                /*
                Debug.Log("x");
                Debug.Log(delta.x);
                Debug.Log("y");
                Debug.Log(delta.y);
                */

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
}