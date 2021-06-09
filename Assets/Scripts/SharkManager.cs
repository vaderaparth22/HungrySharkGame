using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkManager
{
    #region Singleton
    private SharkManager() { }
    private static SharkManager _instance;
    public static SharkManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SharkManager();
            }
            return _instance;
        }
    }
    #endregion

    private PlayerShark sharkPrefab;
    private PlayerShark playerShark;

    public void Initialize()
    {
        sharkPrefab = Resources.Load<PlayerShark>("Prefabs/Shark");
        playerShark = GameObject.Instantiate<PlayerShark>(sharkPrefab);
    }
}
