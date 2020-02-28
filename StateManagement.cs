using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StateManagement : MonoBehaviour
{

    public enum GameState { TitleState, PlayGameState, HelpState, WinState, LostState };
    public GameState currentGameState;

    public GameObject Title;
    public GameObject PlayGame;
    public GameObject Lost;
    public GameObject Win;
    public GameObject Help;
    public InputField pName;


    public string PlayerName;
    public Text tellPlayerHi;
    public Text tellHelp;
    public Text tellLost;
    public Text tellWin;

    // Use this for initialization
    void Start()
    {
        currentGameState = GameState.TitleState;
        ShowScreen(Title);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void ShowScreen(GameObject gameObjectToShow)
    {
        Title.SetActive(false);
        PlayGame.SetActive(false);
        Lost.SetActive(false);
        Win.SetActive(false);
        Help.SetActive(false);

        gameObjectToShow.SetActive(true);
    }

    

    public void PlayLevel()
    { 
        currentGameState = GameState.PlayGameState;
        ShowScreen(PlayGame);
    }
    public void HelpLevel()
    {
        currentGameState = GameState.HelpState;
        ShowScreen(Help);
        tellHelp.text = "You need to listen to those accused rabbits and find out who is the killer.Then push the killer into the fire of Hell, muahahahaha";
    }
    public void LostLoad()
    {
        currentGameState = GameState.LostState;
        tellLost.text = PlayerName + " killed the innocent";
        ShowScreen(Lost);
       
        
    }
        public void WinLoad()
    {
        currentGameState = GameState.WinState;
        tellWin.text = PlayerName + " killed the the killer, justice has been served";
        ShowScreen(Win);
    }

    public void SetGetName()
    {

        PlayerName = pName.text;
        tellPlayerHi.text = "Hi " + PlayerName + ", time to find the killer";
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}