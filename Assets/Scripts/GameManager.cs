using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace BaursakRun
{
   public class GameManager : MonoBehaviour
   {
        [SerializeField] private Button _play;
        [SerializeField] private TMP_InputField _userName;
        public void StartGame()
        {
            if (!string.IsNullOrEmpty(_userName.text) && _userName.text.Length >= 4)
            {
                SceneManager.LoadScene("PlayScene", LoadSceneMode.Single);
            }
        }
    }

}

