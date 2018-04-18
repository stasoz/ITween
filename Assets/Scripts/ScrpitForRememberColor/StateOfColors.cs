using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateOfColors : MonoBehaviour
{
    public GameObject[] objs;
    private int[] randomNumbers;
    private enum Colors:int
    {
        Red,
        Green,
        Blue,
        Yellow
    }
    private void Start()
    {
        SetUpColor();
    }
    void SetUpColor()
    {
        foreach(GameObject g in objs)
        {
            switch((Colors)Random.Range(0, 4))
            {
                case Colors.Red:
                    g.GetComponent<MeshRenderer>().material.color = Color.red;
                    break;
                case Colors.Green:
                    g.GetComponent<MeshRenderer>().material.color = Color.green;
                    break;
                case Colors.Blue:
                    g.GetComponent<MeshRenderer>().material.color = Color.blue;
                    break;
                case Colors.Yellow:
                    g.GetComponent<MeshRenderer>().material.color = Color.yellow;
                    break;
            }
            
        }
    }
}
