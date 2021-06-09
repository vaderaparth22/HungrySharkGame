using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager
{
    #region Singleton
    private TimerManager() { }
    private static TimerManager _instance;
    public static TimerManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new TimerManager();
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
