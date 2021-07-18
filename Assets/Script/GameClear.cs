using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    public Text score_txt;
    public Button ok_btn;

    int score;

    // Start is called before the first frame update
    public void SetUp(int _score)
    {
       score_txt.text = score + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickClear()
    {
        SceneManager.LoadScene("Start");
    }
}
