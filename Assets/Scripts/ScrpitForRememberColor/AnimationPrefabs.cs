using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPrefabs : MonoBehaviour {
    public void OnMouseDown()
    {
       if(GameManage.CanTap) iTween.MoveFrom(this.gameObject, new Vector3(transform.position.x,-2,transform.position.z),0.5f);
    }
}
