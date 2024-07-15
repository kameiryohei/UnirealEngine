using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Life : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextLife;
    [SerializeField] private TextMeshProUGUI GameOverTitle;
    private int playerLife = 10;
    private bool isGameOver = false;

    public bool IsGameOver { get { return isGameOver; } }

    void Start()
    {
        UpdateLifeText();
    }

    void Update()
    {
        if (isGameOver)
        {
            DisablePlayerInput();
            return;
        }
    }

    void DisablePlayerInput()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            DecreaseLife();
        }
    }

    void DecreaseLife()
    {
        if (playerLife > 0)
        {
            playerLife--;
            UpdateLifeText();
            if (playerLife <= 0)
            {
                isGameOver = true;
                GameOverTitle.text = "Game Over!";
            }
        }
    }

    void UpdateLifeText()
    {
        TextLife.text = string.Format("Life: {0}", playerLife);
    }
}