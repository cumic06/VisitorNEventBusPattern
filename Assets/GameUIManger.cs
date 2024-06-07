using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUIManger : MonoBehaviour
{
    [SerializeField] private Text gameOverText;

    private void Awake()
    {
        EventBus.Subscribe(GameState.GameOver, () => gameOverText.gameObject.SetActive(true));
    }
}
