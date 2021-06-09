using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

enum FishType
{
    Eatable,
    NonEatable
}

public class FishManager
{
    #region Singleton
    private FishManager() { }
    private static FishManager _instance;
    public static FishManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new FishManager();
            }
            return _instance;
        }
    }
    #endregion

    private Dictionary<FishType, Enemy> fishPrefabs = new Dictionary<FishType, Enemy>();
    private List<Enemy> allFishes = new List<Enemy>();
    private Transform[] spawnPositions;

    public void Initialize()
    {
        InitializeSpawnPositions();
        InitalizeEnemies();
    }

    public void UpdateRefresh()
    {
        if (allFishes.Count > 0)
        {
            foreach (Enemy fish in allFishes)
            {
                fish.RefreshUpdate();
            }
        }
    }

    private void InitalizeEnemies()
    {
        fishPrefabs.Add(FishType.Eatable, Resources.Load<Enemy>("Prefabs/Eatable"));
        fishPrefabs.Add(FishType.NonEatable, Resources.Load<Enemy>("Prefabs/NonEatable"));

        int spawnCount = GameRuleManager.Instance.fishSpawnCount;
        allFishes = new List<Enemy>();
        
        for (int i = 0; i < spawnCount; i++)
        {
            FishType fishType = (FishType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(FishType)).Length);
            Enemy e = GameObject.Instantiate<Enemy>(fishPrefabs[fishType]);
            Transform newPos = spawnPositions[i];
            e.transform.position = newPos.position;
            e.Initialize(newPos.right);

            allFishes.Add(e);
        }
    }

    private void InitializeSpawnPositions()
    {
        GameObject positionObj = GameObject.Find("FishSpawnPositions");

        spawnPositions = new Transform[positionObj.transform.childCount];

        for (int i = 0; i < positionObj.transform.childCount; i++)
            spawnPositions[i] = positionObj.transform.GetChild(i);
    }
}
