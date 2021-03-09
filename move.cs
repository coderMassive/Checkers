using System.Collections;
using UnityEngine;

public class move1 : MonoBehaviour
{
    public Transform trans;
    public GameObject obj;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                trans = hit.collider.gameObject.transform;
                obj = hit.collider.gameObject;
            }
        }
        if (Input.GetKeyDown(KeyCode.Q) == true)
        {
            trans.position += new Vector3(-1.4f, 1.4f, 0) * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.E) == true)
        {
            trans.position += new Vector3(1.4f, 1.4f, 0) * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            trans.position += new Vector3(-1.4f, -1.4f, 0) * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            trans.position += new Vector3(1.4f, -1.4f, 0) * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Return) == true)
        {
            Destroy(obj);
        }
    }

}
