using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // The 殘影
    public Ghost ghost;

    // 動畫控制器
    private Animator anim;

    // 玩家身體
    private CircleCollider2D myBody;

    // 玩家可待的四個角落
    public GameObject DLpos, DRpos, URpos, ULpos;

    // 攻擊
    public bool AtkBool = true;
    public Transform AttackPoint;
    public Attack_Obj AtkObj;
    public Attack_Obj UpAtkObj;
    public Attack_Obj ChianObj;
    public float AttackSpeed = 50;

    // 玩家定位點
    public bool PosUR, PosUL, PosDR, PosDL;
    public Pos currentPos;

    // 玩家外觀
    private bool FacingLeft = true;

    // 玩家已就定位
    public bool stay = false;

    // 紀錄觸控一開始的座標（用於後面計算拖曳方向）
    private Vector2 startTouchPos;

    // 玩家移動速度
    public float PlayerSpeed = 3;

    // 玩家目標位置
    Pos desPos = Pos.DL;

    public AudioClip SwordSound;
    public AudioClip ChainSound;

    // Start is called before the first frame update
    private void Start()
    {
        // 獲取受傷主體
        myBody = GetComponent<CircleCollider2D>();
        // 獲得動畫控制器
        anim = GetComponent<Animator>();

        Debug.Log("如需用滑鼠滑動控制，請： Window > General > Divice Simulator");
        Debug.Log("將上排工具列第二項（預設應該是 iPad Air ）改為 Google Pixel 2");
        Debug.Log("工具列第五項可讓螢幕旋轉九十度，接下來即可直接用滑鼠操作");

        anim.SetBool("IsBattleStart", true); // 進入戰鬥待機
    }

    // Update is called once per frame
    void Update()
    {
        // 觸控
        Direction touchDir = GetTouchSwipeDirection();
        Direction dir = touchDir;

        // 鍵盤
        if (dir == Direction.None)
        {
            dir = KeyBoardCon();
        }

        // 定位後的動作
        if (stay)
        {
            SwipeDir(dir);
        }
        UpdatePos();
    }

    // 方向控制
    public void SwipeDir(Direction SwipeTo)
    {
        // 移動的方向控制
        if (SwipeTo == Direction.Up)
        {
            if (desPos == Pos.DL)
                desPos = Pos.UL;
            else if (desPos == Pos.DR)
            {
                desPos = Pos.UR;
            }
            if (currentPos == Pos.DL || currentPos == Pos.DR)
            {
                anim.SetTrigger("IsJump");
                anim.ResetTrigger("IsFall");
                ghost.makeGhost = true;
            }
            FacingLeft = false;
        }
        if (SwipeTo == Direction.Down)
        {
            if (desPos == Pos.UL)
                desPos = Pos.DL;
            else if (desPos == Pos.UR)
            {
                desPos = Pos.DR;
            }
            if (currentPos == Pos.UL || currentPos == Pos.UR)
            {
                anim.SetTrigger("IsFall");
                anim.ResetTrigger("IsJump");
                ghost.makeGhost = true;
            }
            FacingLeft = false;
        }
        if (SwipeTo == Direction.Left)
        {
            if (desPos == Pos.DR)
                desPos = Pos.DL;
            else if (desPos == Pos.UR)
            {
                desPos = Pos.UL;
            }
            if (currentPos == Pos.DR || currentPos == Pos.UR)
            {
                anim.SetTrigger("IsSprint");
                ghost.makeGhost = true;
            }
            FacingLeft = true;
        }
        if (SwipeTo == Direction.Right)
        {
            if (desPos == Pos.DL)
                desPos = Pos.DR;
            else if (desPos == Pos.UL)
            {
                desPos = Pos.UR;
            }
            if (currentPos == Pos.DL || currentPos == Pos.UL)
            {
                anim.SetTrigger("IsSprint");
                ghost.makeGhost = true;
            }
            FacingLeft = true;
        }

        // 攻擊的方向控制
        if (SwipeTo == Direction.UpLeft)
        {
            if (desPos == Pos.DR)
            {
                PlayerAttack(Direction.UpLeft);
                FacingLeft = false;
            }
        }
        if (SwipeTo == Direction.UpRight)
        {
            if (desPos == Pos.DL)
            {
                PlayerAttack(Direction.UpRight);
                FacingLeft = false;
            }
        }
        if (SwipeTo == Direction.DownLeft)
        {
            if (desPos == Pos.UR)
            {
                PlayerAttack(Direction.DownLeft);
                FacingLeft = false;
            }
        }
        if (SwipeTo == Direction.DownRight)
        {
            if (desPos == Pos.UL)
            {
                PlayerAttack(Direction.DownRight);
                FacingLeft = false;
            }
        }
    }

    // 角色攻擊動畫
    private void PlayerAttack(Direction AtkDir)
    {
        if (AtkDir == Direction.UpRight)
        {
            anim.SetTrigger("IsAtk");
        }
        if (AtkDir == Direction.UpLeft)
        {
            anim.SetTrigger("IsAtk");
        }
        if (AtkDir == Direction.DownRight)
        {
            anim.SetTrigger("IsAtk");
        }
        if (AtkDir == Direction.DownLeft)
        {
            anim.SetTrigger("IsAtk");
        }
    }

    // 攻擊動畫觸發
    public void ATK()
    {
        if (currentPos == Pos.UL)
        {
            Quaternion rotation = Quaternion.Euler(0, 180, 220);
            AttackPoint.rotation = rotation;
            Soundmanager.instance.PlaySound(SwordSound);
        }
        else if (currentPos == Pos.DL)
        {
            Quaternion rotation = Quaternion.Euler(0, 180, 140);
            AttackPoint.rotation = rotation;
            Soundmanager.instance.PlaySound(SwordSound);
        }
        else if (currentPos == Pos.UR)
        {
            Quaternion rotation = Quaternion.Euler(0, 0, 220);
            AttackPoint.rotation = rotation;
            Soundmanager.instance.PlaySound(SwordSound);
        }
        else if (currentPos == Pos.DR)
        {
            Quaternion rotation = Quaternion.Euler(0, 0, 140);
            AttackPoint.rotation = rotation;
            Soundmanager.instance.PlaySound(SwordSound);
        }
        Attack_Obj atk = Instantiate<Attack_Obj>(AtkObj, AttackPoint.position, AttackPoint.rotation);
        atk.player = this;
        atk.speed = AttackSpeed;
    }

    public void UPATK()
    {
        if (currentPos == Pos.UL)
        {
            Quaternion rotation = Quaternion.Euler(0, 180, 220);
            AttackPoint.rotation = rotation;
            Soundmanager.instance.PlaySound(SwordSound);
        }
        else if (currentPos == Pos.DL)
        {
            Quaternion rotation = Quaternion.Euler(0, 180, 140);
            AttackPoint.rotation = rotation;
            Soundmanager.instance.PlaySound(SwordSound);
        }
        else if (currentPos == Pos.UR)
        {
            Quaternion rotation = Quaternion.Euler(0, 0, 220);
            AttackPoint.rotation = rotation;
            Soundmanager.instance.PlaySound(SwordSound);
        }
        else if (currentPos == Pos.DR)
        {
            Quaternion rotation = Quaternion.Euler(0, 0, 140);
            AttackPoint.rotation = rotation;
            Soundmanager.instance.PlaySound(SwordSound);
        }
        Attack_Obj atk = Instantiate<Attack_Obj>(UpAtkObj, AttackPoint.position, AttackPoint.rotation);
        atk.player = this;
        atk.speed = AttackSpeed;
    }

    public void ChianATK()
    {
        if (currentPos == Pos.UL)
        {
            Soundmanager.instance.PlaySound(SwordSound);
            Quaternion rotation = Quaternion.Euler(0, 180, 220);
            AttackPoint.rotation = rotation;
            
        }
        else if (currentPos == Pos.DL)
        {
            Soundmanager.instance.PlaySound(ChainSound);
            Quaternion rotation = Quaternion.Euler(0, 180, 140);
            AttackPoint.rotation = rotation;
           
        }
        else if (currentPos == Pos.UR)
        {
            Soundmanager.instance.PlaySound(ChainSound);
            Quaternion rotation = Quaternion.Euler(0, 0, 220);
            AttackPoint.rotation = rotation;
            
        }
        else if (currentPos == Pos.DR)
        {
            Soundmanager.instance.PlaySound(ChainSound);
            Quaternion rotation = Quaternion.Euler(0, 0, 140);
            AttackPoint.rotation = rotation;
            
        }
        Attack_Obj atk = Instantiate<Attack_Obj>(ChianObj, AttackPoint.position, AttackPoint.rotation);
        atk.player = this;
        atk.speed = AttackSpeed;
    }

    // 玩家是否就定位
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Platform")
        {
            stay = true;
            if (collision.name == "DL")
            {
                currentPos = Pos.DL;
            }
            if (collision.name == "UL")
            {
                currentPos = Pos.UL;
            }
            if (collision.name == "DR")
            {
                currentPos = Pos.DR;
            }
            if (collision.name == "UR")
            {
                currentPos = Pos.UR;
            }
            Flip();
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Platform")
        {
            AtkBool = false;
            stay = false;
        }
    }

    // 鍵盤控制
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
        {
            return Direction.Up;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            return Direction.Down;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            return Direction.Left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            return Direction.Right;
        }
        return Direction.None;
    }

    // 滑動控制
    private Direction GetTouchSwipeDirection()
    {
        // 如果有觸碰 (touches陣列有內容)
        if (Input.touches.Length > 0)
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

                // 左右 or 斜向滑動
                if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
                {
                    // 向左
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
                    // 向右
                    else
                    {
                        if (delta.y > -200 && delta.y < 200)
                        {
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
                // 上下滑動
                else
                {
                    if (delta.y > 200)
                    {
                        Debug.Log("Down");
                        return Direction.Down;
                    }
                    else if (delta.y < -200)
                    {
                        Debug.Log(delta.y);
                        return Direction.Up;
                    }
                }
            }
        }
        return Direction.None;
    }

    // 角色反轉
    private void Flip()
    {
        if (FacingLeft)
        {
            transform.Rotate(0, 180, 0);
            Debug.Log("flip");
        }
    }

    // 更新玩家位置
    private void UpdatePos()
    {
        // 目標位置 to 座標
        float dx = 0, dy = 0;

        if (desPos == Pos.DL)
        {
            dx = DLpos.transform.position.x; dy = DLpos.transform.position.y;
        }
        if (desPos == Pos.DR)
        {
            dx = DRpos.transform.position.x; dy = DRpos.transform.position.y;
        }
        if (desPos == Pos.UL)
        {
            dx = ULpos.transform.position.x; dy = ULpos.transform.position.y;
        }
        if (desPos == Pos.UR)
        {
            dx = URpos.transform.position.x; dy = URpos.transform.position.y;
        }

        float x = Mathf.Lerp(transform.position.x, dx, PlayerSpeed * Time.deltaTime);
        float y = Mathf.Lerp(transform.position.y, dy, PlayerSpeed * Time.deltaTime);
        float z = transform.position.z + 0.0f;
        transform.position = new Vector3(x, y, z);
    }
}