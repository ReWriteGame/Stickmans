using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentStickman : MonoBehaviour
{
    [SerializeField] private Material[] equipmant;

    private Material currentEquipmant;

    public Material[] Equipmant { get => equipmant; private set => equipmant = value; }

    public void setEquipmant()
    {
        currentEquipmant = equipmant[Random.Range(0, equipmant.Length)];
    }


}
