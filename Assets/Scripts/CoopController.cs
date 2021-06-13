using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoopController : MonoBehaviour
{
    static public CoopController Instance { get; private set; }

    private Vector3 directionMove;

    public Vector3 DirectionMove { get => directionMove; private set => directionMove = value; }


    void Start()
    {
        Instance = this;
        directionMove = Vector3.forward;
    }




    public void forwardMove()
    {
        directionMove += Vector3.forward;
    }
    public void backMove()
    {
        directionMove += Vector3.back;
    }
    public void rightMove()
    {
        directionMove += Vector3.right;
    }
    public void leftMove()
    {
        directionMove += Vector3.left;
    }

    public void stopMove()
    {
        directionMove = Vector3.zero;
    }
}
