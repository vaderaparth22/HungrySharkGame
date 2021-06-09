using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlow : MonoBehaviour
{
    private void Awake()
    {
        SharkManager.Instance.Initialize();
        FishManager.Instance.Initialize();
        CollectibleManager.Instance.Initialize();
        TimerManager.Instance.Initialize();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
