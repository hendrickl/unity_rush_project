using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _forcePlayer;

    [SerializeField] private float _forceSides;
    [SerializeField] private float _forceCamera;
    [SerializeField] private Transform _camera;
    private Rigidbody _rigidBody;
    private PlayerManager _playerManager;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _playerManager = GetComponent<PlayerManager>();
    }

    void FixedUpdate()
    {
        _rigidBody.AddForce(Vector3.forward * _forcePlayer);
        // if (_playerManager.PlayerIsAlive)
        // {
        // _rigidBody.AddForce(Vector3.forward * _forcePlayer);
        // }
        // else
        // {
        // _rigidBody.velocity = Vector3.zero;
        // }
    }

    public void MoveToLeft()
    {
        _rigidBody.AddForce(Vector3.left * _forceSides, ForceMode.Impulse);
    }

    public void MoveToRight()
    {
        _rigidBody.AddForce(Vector3.right * _forceSides, ForceMode.Impulse);
    }

    public void Boost()
    {
        Debug.Log("Boost pressed");
        _rigidBody.AddForce(_camera.forward * _forceCamera, ForceMode.Impulse);
    }
}
