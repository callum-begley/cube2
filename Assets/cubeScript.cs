using UnityEngine;

public class cubeScript : MonoBehaviour
{
  public float speed = 30f;
  public float gravity = 9.81f;
  private Rigidbody rb;

  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  void FixedUpdate()
  {
    Vector3 force = Vector3.forward * speed * 2f;
    if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
    {
      force += Vector3.right * speed;
    }
    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
    {
      force += Vector3.left * speed;
    }
    rb.AddForce(force);
  }
}