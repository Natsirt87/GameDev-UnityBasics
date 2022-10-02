using UnityEngine;

public class MovePlayer : MonoBehaviour {
    [SerializeField]private float acceleration = 10f;
    private Rigidbody2D rb2d;

    public Vector2 movement;

    void Start () {
      rb2d = GetComponent<Rigidbody2D> ();
    }

    void Update () {
        if (Input.GetKey(KeyCode.Space)) {
            moveCharacter(Camera.main.transform.up);
        }
        if (Input.GetKey(KeyCode.D)) {
            moveCharacter(Camera.main.transform.right);
        } 
        if (Input.GetKey(KeyCode.A)) {
            moveCharacter(-Camera.main.transform.right);
        }  
    }

    void moveCharacter(Vector3 direction) {
        rb2d.AddForce(direction * acceleration);
    }
}