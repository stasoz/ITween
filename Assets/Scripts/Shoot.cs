using UnityEngine;
public class Shoot : MonoBehaviour {
    public float range = 100f;
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, ray.direction * range);
        RaycastHit hit;
        if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray,out hit))
            {
                if (hit.collider.tag == "Cube") GameManager.goCube = true;
                if (hit.collider.tag == "Sphere") GameManager.goSphere = true;
                if (hit.collider.tag == "Cylinder") GameManager.goCylinder = true;
                if (hit.collider.tag == "Wall") GameManager.goWall = true;

            }
        }
    }
}
