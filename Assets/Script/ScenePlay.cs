using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScenePlay : MonoBehaviour
{
    public GameObject hero;
    // Start is called before the first frame update
    public GameObject monster;
    public Transform[] spawn;
    public Text score_txt;
    public Slider hp_slider;
    public GameClear gameClear;
    public GameOver gameOver;
    public GameObject gamePause;
    bool bGameClear = false;
    bool bGameOver = false;
    public int score = 0;
    public Text timer;
    public float playtime;
    public float starttime;

    Hero sc;

    void Start()
    {
        sc = hero.GetComponent<Hero>();
        InvokeRepeating("MonsterSpawn", 2, 3);
        starttime = Time.time;
        playtime = 0;
    }


    // Update is called once per frame
    void Update()
    {
        playtime = Time.time - starttime;
        score_txt.text = score + "";
        timer.text = playtime.ToString("0.00");
        hp_slider.value = sc.hp_cur / (float)sc.hp_max;

        if(score >= 10 && bGameClear == false)
        {
            bGameClear = true;
            gameClear.gameObject.SetActive(true);
            gameClear.SetUp(score);
        }
        else if(!bGameOver && sc.hp_cur<=0 || playtime > 30)
        {
            bGameOver = true;
            gameOver.gameObject.SetActive(true);
        }
    }
    public void MonsterSpawn()
    {

        GameObject go = Instantiate(monster);
        int rand = UnityEngine.Random.Range(0, 4);
        go.transform.position = spawn[rand].position;
        go.transform.LookAt(hero.transform);
    }
    public void OnClick_pause()
    {
        Time.timeScale = 0.0f;
        gamePause.SetActive(true);
    }
    public void OnClick_pause_ok()
    {
        Time.timeScale = 1.0f;
        gamePause.SetActive(false);
    }
}
