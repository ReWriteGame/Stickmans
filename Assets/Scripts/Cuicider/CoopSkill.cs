﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoopSkill : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CoopSkill>())
        {
            other.GetComponentInParent<Move>().enabled = true;
            other.GetComponentInParent<StickMan>().enabled = true;
        }
    }
}
