/*
    Source File Name: GroundController
    Author's Name: Vishal Guleria 300813391
    Last Modified By: Vishal Guleria 300813391
    Date Last Modified: 25th March 2016
    Program Description: v8
*/
using UnityEngine;
public class GroundController : MonoBehaviour
{

    private GameController _gameController;

    private Vector3 _playerSpawnPoint;
    // Use this for initialization
    void Start()
    {
        this._gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent("GameController") as GameController;
        this._playerSpawnPoint = new Vector3(482f, 67.5f, 2434f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {

        Transform playerTransform = other.gameObject.GetComponent<Transform>();
        playerTransform.position = this._playerSpawnPoint;
        playerTransform.Rotate(0, 167, 0);
        this._gameController.LivesValue--;


    }
}
