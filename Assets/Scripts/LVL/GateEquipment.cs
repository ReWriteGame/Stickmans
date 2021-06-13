using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateEquipment : MonoBehaviour
{
    [SerializeField] private Material equipmantGate;

    public Material EquipmantGate { get => equipmantGate; private set => equipmantGate = value; }
}
