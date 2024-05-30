using System.Collections;
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
    public Dictionary<GameState, Action> eventDic = new();


}
