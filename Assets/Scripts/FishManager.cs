using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
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

    public void Initialize()
    {

    }

    public void UpdateRefresh()
    {

    }
}
