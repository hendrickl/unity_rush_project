using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private GameManager _gameManager;
    public bool PlayerIsAlive;

    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        PlayerIsAlive = true;
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("OnCollisionEnter activated by " + other);
        _gameManager.PlayerIsDead();
        PlayerIsAlive = false;
    }
}
