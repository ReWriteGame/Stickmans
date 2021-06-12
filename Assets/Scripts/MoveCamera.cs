using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [Range(0,10)][SerializeField] private float speed = 0;

    private Transform obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
