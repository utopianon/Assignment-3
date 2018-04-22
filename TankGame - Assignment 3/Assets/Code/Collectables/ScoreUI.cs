using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TankGame
{

    public class ScoreUI : MonoBehaviour
    {
        [SerializeField]
        Text scoreText;

        [SerializeField]
        Text lives;

        [SerializeField]
        PlayerUnit player;

        private void Awake()
        {
            scoreText = GetComponent<Text>();
        }
        private void Update()
        {
            scoreText.text = "Score: " + player.Score;
            lives.text = "Lives: " + player.Life;
        }

    }
}
