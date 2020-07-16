﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(PlayerInputManager))]
public class MultiplayerManager : MonoBehaviour
{
    // Instance for singleton
    public static MultiplayerManager Instance { get; private set; }
    // Number of players to be instantiated at the start of the scene, need to be at least 1 and no more then available devices
    public static int NumberOfPlayers { get; set; } = 0;
    
    public GameObject[] PlayerPrefabs = { };
    public event Action<int> onGameOver;

    [SerializeField] private PlayerUI[] _playerUIs = { };
    [SerializeField] private int _playerCount = 0;

    private Dictionary<ReadOnlyArray<InputDevice>, int> _indexUI;
    private List<PlayerInput> _players;

    //Make it Singleton
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
        _playerCount = 0;
        _players = new List<PlayerInput>();
        _indexUI = new Dictionary<ReadOnlyArray<InputDevice>, int>();
        
        //InstantiatePlayers();
        InstantiatePlayersWithSetDevices();
    }

    public void InstantiatePlayers()
    {
        PlayerInputManager manager = GetComponent<PlayerInputManager>();
        for (int i = 0; i < NumberOfPlayers; i++)
        {
            if (i < PlayerPrefabs.Length)
            {
                manager.playerPrefab = PlayerPrefabs[i];
            }
            manager.JoinPlayer(i);
        }
    }

    public void InstantiatePlayersWithSetDevices()
    {
        NumberOfPlayers = PlayerPrefs.GetInt("Number of Players");
        PlayerInputManager manager = GetComponent<PlayerInputManager>();
        string devicePath = null; 
        for (int i = 0; i < NumberOfPlayers; i++)
        {
            if((devicePath = PlayerPrefs.GetString($"Player_{i}_device", null)) != null)
            {
                manager.playerPrefab = PlayerPrefabs[PlayerPrefs.GetInt($"Player_{i}_element", 0)];
                manager.JoinPlayer(i, pairWithDevice: InputSystem.GetDevice(devicePath));
            }
        }
    }

    /// <summary>
    /// Called when a new player input is instantiated
    /// Makes him a child of this gameObject and activate its UI
    /// </summary>
    /// <param name="player"></param>
    public void OnPlayerJoined(PlayerInput player)
    {
        Debug.Log("Joined: " + player.gameObject.name);
        player.transform.SetParent(this.transform);
        _players.Add(player);
        if (!_indexUI.ContainsKey(player.devices))
        {
            _indexUI.Add(player.devices, _playerCount);
            _playerCount++;
        }

        int index = _indexUI[player.devices];
        _playerUIs[index].gameObject.SetActive(true);
        _playerUIs[index].Setup(player.gameObject);

        player.GetComponent<HealthSystem>().onDeath += HandlePlayer_onDeath;
    }

    public void OnPlayerLeft(PlayerInput player)
    {
        int index = _indexUI[player.devices];
        _playerUIs[index].gameObject.SetActive(false);
        _players.Remove(player);
    }


    private void HandlePlayer_onDeath()
    {
        _playerCount--;
        if(_playerCount <= 1)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        //Calculate winner
        int winner = -1;
        foreach (var p in _players)
        {
            if (p.gameObject.activeInHierarchy)
            {
                winner = p.playerIndex;
                break;
            }
        }

        onGameOver?.Invoke(winner);
        //Reload active Scene
        //Invoke("ReloadScene", 1f);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

}
