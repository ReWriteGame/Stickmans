using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    [SerializeField] private Transform begin;
    [SerializeField] private Transform end;

    public Transform End { get => end; private set => end = value; }
    public Transform Begin { get => begin; private set => begin = value; }

    bool isNull(Object obj, string log = "")
    {
        if (obj == null)
        {
            Debug.LogError("Not Init or Null Error!" + log);
            return true;
        }
        else return false;
    }


    private void Start()
    {
      
        isNull(Begin, "стартовая точка не установленна ");
        isNull(End);
    }

}
