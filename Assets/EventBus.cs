using System.Collections.Generic;
using UnityEngine;
using System;

public enum GameState
{
    Play,
    Pause,
    GameOver,
    GameClear
}

public class EventBus : MonoBehaviour
{
    private static readonly Dictionary<GameState, Action> eventDic = new();

    public static void Subscribe(GameState state, Action action)
    {
        if (!eventDic.ContainsKey(state))
        {
            eventDic.Add(state, action);
        }
        else
        {
            eventDic[state] -= action;
        }
    }

    public static void UnSubscribe(GameState state, Action action)
    {
        if (eventDic.ContainsValue(action))
        {
            eventDic[state] -= action;
        }
    }

    public static void Publish(GameState state)
    {
        if (eventDic.ContainsKey(state))
        {
            eventDic[state]?.Invoke();
        }
    }
}