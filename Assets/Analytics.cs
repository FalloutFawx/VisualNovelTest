using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Analytics : MonoBehaviour {

	public void LogGameStart()
    {
        AnalyticsEvent.GameStart();
    }

    public void LogGameComplete()
    {
        AnalyticsEvent.GameOver();
    }
}