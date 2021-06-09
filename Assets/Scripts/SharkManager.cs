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

    public void Initialize()
    {

    }

    public void UpdateRefresh()
    {

    }
}
