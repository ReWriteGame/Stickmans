using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider), typeof(Rigidbody))]
public class Finish : MonoBehaviour
{
    private Transform finish;
    [SerializeField] private ChunkPlacer chunks;
    [SerializeField] private Vector3 shiftCenter = Vector3.zero;
    [SerializeField] private GameObject[] objectForFinish;


    IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        finish = GetComponent<Transform>();
        setFinish();

        yield break;
    }
    void setFinish()
    {
        finish.position = chunks.getPosEndOfChunk(chunks.NumberOfChunk) + shiftCenter;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<StickMan>())
        {
            LevelController.Instance.reStartLevelWrapper();
        }

        foreach (GameObject obj in objectForFinish)
        {
            if (other.gameObject == obj)
                LevelController.Instance.reStartLevelWrapper();
        }
    }
}
