using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool goCube=false;
    public static bool goSphere = false;
    public static bool goCylinder = false;
    public static bool goWall = false;
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 250, 150), "<color=black><size=20>Click on the object and on the back wall</size></color>");
    }
    public void RestartLevel()
    {
        Application.LoadLevel(0);
    }
}
