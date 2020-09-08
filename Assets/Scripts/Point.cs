using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public GameController controller;

    void Start() {
        controller = FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        controller.score++;
        controller.scoreText.text = controller.score.ToString();
    }
}
