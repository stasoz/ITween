using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourObjects : MonoBehaviour
{
    public GameObject[] objs;
    public GameObject[] points;
    private void Update()
    {
        ChangeObjects();
    }
    void ChangeObjects()
    {
        if (GameManager.goSphere)
        {
            iTween.ColorTo(objs[0], iTween.Hash("color", Color.red, "time", 2));
            iTween.MoveTo(objs[0], iTween.Hash("position", points[0].transform.position, "time", 4, "easytype", iTween.EaseType.easeInOutElastic));
            GameManager.goSphere = false;
        }
        if (GameManager.goCube)
        {
            iTween.RotateFrom(objs[1], iTween.Hash("y", 90.0f, "time", 3, "easetype", iTween.EaseType.easeInExpo, "looktarget", objs[0]));
            iTween.ScaleTo(objs[1], new Vector3(2, 2, 2), 3);
            GameManager.goCube = false;
        }
        if (GameManager.goCylinder)
        {
            iTween.ShakeRotation(objs[2], new Vector3(10, 3, 3), 2f);
            GameManager.goCylinder = false;
        }
        if (GameManager.goWall)
        {
            iTween.ShakePosition(Camera.main.gameObject, iTween.Hash("x", 0.7f, "y", 0.3f, "time", 0.8f, "delay", 0.2f));
            GameManager.goWall = false;
        }
    }
}
