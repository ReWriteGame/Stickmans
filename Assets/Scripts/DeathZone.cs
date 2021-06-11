using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] private Material material;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<EquipmentStickman>())
        {
            if (other.GetComponentInParent<EquipmentStickman>().CurrentEquipmant != material)
                other.GetComponentInParent<StickMan>().destroy();
        }
    }
}
