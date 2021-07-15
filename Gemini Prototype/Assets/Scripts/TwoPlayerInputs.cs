﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPlayerInputs : MonoBehaviour
{


    [SerializeField]
    private GameObject Player1;
    [SerializeField]
    private GameObject Player2;
    private float speed = 0.04f;

    private void Movements()
    {

        if (Player1 && Player2)
        {

            Player1.transform.position = new Vector3(Player1.transform.position.x + Input.GetAxis("HorizontalPlayer1") * speed, Player1.transform.position.y, Player1.transform.position.z);

            Player1.transform.position = new Vector3(Player1.transform.position.x, Player1.transform.position.y + Input.GetAxis("VerticalPlayer1") * speed, Player1.transform.position.z);

            Player2.transform.position = new Vector3(Player2.transform.position.x + Input.GetAxis("HorizontalPlayer2") * speed, Player2.transform.position.y, Player2.transform.position.z);

            Player2.transform.position = new Vector3(Player2.transform.position.x, Player2.transform.position.y + Input.GetAxis("VerticalPlayer2") * speed, Player2.transform.position.z);
        }
    }
    void Update()
    {
        Movements();
    }
}
