using System.Collections.Generic;
using UnityEngine;
using System;

public enum GameState
{
    Play,
    Pause,
    End
}

public class EventBus : MonoBehaviour
{
    private static readonly Dictionary<GameState, Action> eventDic = new();

    public static void Subscribe(GameState state, Action action)
    {
        if (!eventDic.ContainsValue(action))
        {
            eventDic.Add(state, action);
        }
    }

    public static void UnSubscribe(GameState state, Action action)
    {
        if (eventDic.TryGetValue(state, out Action removeAction))
        {
            eventDic[state] -= removeAction;
        }
    }

    public static void Publish(GameState state)
    {
        if (eventDic.TryGetValue(state, out Action invokeAction))
        {
            invokeAction?.Invoke();
        }
    }
}
