using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player1 player1;
    public Player2 player2;
    public int level;
    public Image left;
    public Image right;
    private Sprite first;
    private Sprite second;
    // Start is called before the first frame update
    void Start() {
        level = 0;
        left = GameObject.FindWithTag("PositionLeft").GetComponent<Image>();
        right = GameObject.FindWithTag("PositionRight").GetComponent<Image>();
        first = Resources.Load<Sprite>("1st");
        second = Resources.Load<Sprite>("2nd");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)){
            SceneManager.LoadScene("MainMenu");
        }
        if (SceneManager.GetActiveScene().name == "LEVEL1") level = 1;
        else if (SceneManager.GetActiveScene().name == "LEVEL2") level = 2;
        else if (SceneManager.GetActiveScene().name == "LEVEL3") level = 3;
        else if (SceneManager.GetActiveScene().name == "LEVEL4") level = 4;
        else if (SceneManager.GetActiveScene().name == "LEVEL5") level = 5;
        else if (SceneManager.GetActiveScene().name == "LEVEL6") level = 6;
        else level = 0;
        //if (player1.isWinner() || player2.isWinner()) SceneManager.LoadScene("LEVEL"+ (level+1).ToString());
        if (Player1.isWinner() || Player2.isWinner()) SceneManager.LoadScene("DANCE");

        left.transform.position = new Vector3((float)Screen.width / 2 - 70, 40, 0);
        right.transform.position = new Vector3(Screen.width - 70, 40, 0);
        if (player1.getPlayerZ() >= player2.getPlayerZ())
        {
            left.rectTransform.sizeDelta = new Vector2(92, 60);
            right.rectTransform.sizeDelta = new Vector2(112, 60);
            left.sprite = first;
            right.sprite = second;
        }
        else
        {
            left.rectTransform.sizeDelta = new Vector2(112, 60);
            right.rectTransform.sizeDelta = new Vector2(92, 60);
            left.sprite = second;
            right.sprite = first;
        }
    }

    public void SelectScreen(string screenName){
        SceneManager.LoadScene(screenName);
    }

    public void Quit() {
        Application.Quit();
    }
}
