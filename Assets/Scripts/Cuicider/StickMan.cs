using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(Collider))]
public class StickMan : MonoBehaviour
{
    private Rigidbody rb;

    private Move move;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        move = GetComponent<Move>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
            move.vectorDirection(Vector3.right + Vector3.forward);
        
        else if (Input.GetKey(KeyCode.A))
            move.vectorDirection(Vector3.left + Vector3.forward);

        else move.forward();

    }
}
