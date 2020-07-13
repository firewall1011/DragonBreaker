﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectionUI : MonoBehaviour
{
    [SerializeField] private Image _deviceImage = null;
    [SerializeField] private GameObject _playerImage = null;

    public void SetupJoinedPlayer(Sprite sprite)
    {
        _deviceImage.sprite = sprite;
        _playerImage.SetActive(true);
    }

    public void SetupLeftPlayer(Sprite sprite)
    {
        _deviceImage.sprite = sprite;
        _playerImage.SetActive(false);
    }
}