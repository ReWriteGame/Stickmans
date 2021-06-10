using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEquipment : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EquipmentStickman>())
        {
            other.GetComponent<EquipmentStickman>().Equipmant.Length
        }
    }
}
