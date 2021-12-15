using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  
    public AudioSource SquidGameSong;       // for background music
    public AudioSource mySong;              // this song is really mine haha :D
    public AudioSource youWin;              // song if you win

    public static int lives = 3;            // number of Doll's lives
    public static int candiesCount = 24;    // Number of enemies

    public static bool playGame = true;     // for pausing enemies   

    public Text livesText;                  // printing Doll's text          
    public Text candiesLivesText;           // printing enemies count
    public Text endScreen;                  // Losing Text!
    public Text infoText;                   // copyright text

    // Start is called before the first frame update
    void Start()
    {
        SquidGameSong.Play();               // Background ON!
        livesText.text = "Lives: " + lives; // Initialising lives in the Text
    

    }

    // Update is called once per frame
    void Update()
    {

        // Updating the number of player's lives and enemies count on the screen
        livesText.text = "♥ = " + lives;
        candiesLivesText.text = "☢  ✖ " + candiesCount;


        // Player Loses
        if (lives == 0)
        {
            musicCheck();
            endScreen.text = "You Lose!\n But don't worry. Now I'm going to tell you THE REAL STORY of Dennis Nielsen (aka The Kindly Killer), a Scottish serial killer and necrophiliac who killed at least twelve young men between 1978 and 1983 in London.";
            infoText.text = "©All Rights Reserved! The song was written in 2018.";
        }

        // Easter Egg Activation!
        if (lives == -2)
        {
            musicCheck();
            endScreen.text = "🥚Easter egg wualla!! haha!🥚";
        }

        // Player wins
        if (candiesCount == 0)
        {
            endScreen.text = "You win!  But, alas, I must disappoint you: it's more fun to lose in my game: give it a shot and see what happens!";
            winningMusic();
        }
    }

    // Toggling between background and myMusic musics
   void musicCheck()
    {
        if (SquidGameSong.isPlaying)
        {
            SquidGameSong.Stop();
            mySong.Play();
        }
    }

    // Toggling between background and winningMusic musics
    void winningMusic()
    {
        if (SquidGameSong.isPlaying)
        {
            SquidGameSong.Stop();
            youWin.Play();
        }
    }
}

