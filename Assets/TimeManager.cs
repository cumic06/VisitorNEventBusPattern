using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private void Awake()
    {
        EventBus.Subscribe(GameState.Pause, TimePause);
        EventBus.Subscribe(GameState.Play, TimePlay);
        EventBus.Subscribe(GameState.GameOver, TimePause);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EventBus.Publish(GameState.Pause);
            Debug.Log("Pause");
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            EventBus.Publish(GameState.Play);
            Debug.Log("Play");
        }
    }

    public static void TimePause()
    {
        Time.timeScale = 0;
    }

    public static void TimePlay()
    {
        Time.timeScale = 1;
    }
}