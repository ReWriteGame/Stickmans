using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class EquipmentStickman : MonoBehaviour
{
    private Material currentEquipmant;
    private MeshRenderer meshRenderer;

    public Material CurrentEquipmant { get => currentEquipmant; private set => currentEquipmant = value; }

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<GateEquipment>())
        {
            currentEquipmant = other.GetComponent<GateEquipment>().EquipmantGate;
            meshRenderer.material = currentEquipmant;
        }
    }

  
    
}
