using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public int score = 0;

    public int plusScore = 10;

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 60, 50), "Начать\n снова"))
        {
            print("Start game");
            Application.LoadLevel("scene");

        }

        if (GUI.Button(new Rect(10, 80, 60, 50), "Выход"))
        {
            print("Start game");
            Application.Quit();

        }


    }
}
