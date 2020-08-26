using StarterKit.Base;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private BaseObject[] baseObjects;
    private int i;

    private void Awake()
    {
        CallBaseObjectAwakes();
    }

    private void Start()
    {
        CallBaseObjectStarts();
    }

    private void Update()
    {
        CallBaseObjectUpdates();
    }

    private void OnDestroy()
    {
        CallBaseObjectDestroys();
    }

    private void CallBaseObjectAwakes()
    {
        for (i = 0; i < baseObjects.Length; i++)
        {
            baseObjects[i].BaseObjectAwake();
        }
    }

    private void CallBaseObjectStarts()
    {
        for (i = 0; i < baseObjects.Length; i++)
        {
            baseObjects[i].BaseObjectStart();
        }
    }

    private void CallBaseObjectUpdates()
    {
        for (i = 0; i < baseObjects.Length; i++)
        {
            baseObjects[i].BaseObjectUpdate();
        }
    }

    private void CallBaseObjectDestroys()
    {
        for (i = 0; i < baseObjects.Length; i++)
        {
            baseObjects[i].BaseObjectDestroy();
        }
    }
}