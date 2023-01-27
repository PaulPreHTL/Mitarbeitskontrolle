using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //GetKeyDown passiert nur einmal
        //Deshalb GetKey
        
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            Debug.Log("Shift gedrückt");
            transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * 2, 0, Input.GetAxis("Vertical") * speed * 2) * Time.deltaTime;
            //transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * 10, 0, Input.GetAxis("Vertical") * speed * 10) * Time.deltaTime;
            return;
        }
        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed) * Time.deltaTime;
    }
}
