using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using BaursakRun.Controllers;

namespace BaursakRun
{
   public class GameOver : MonoBehaviour
   {
        [SerializeField] private GameObject _gameOverPanel;
        [SerializeField] private Image _img;
        [SerializeField] private TMP_Text _score;
        [SerializeField] private Button _restart;
        [SerializeField] private ObstController _controller;
        [SerializeField] private BaursakController _baursak;

      
     
   }
}

