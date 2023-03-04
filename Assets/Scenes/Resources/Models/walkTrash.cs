using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float verticalMovement = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(horizontalMovement, 0, verticalMovement);
    }
}