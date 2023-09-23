using UnityEngine;

namespace rogualick
{
    public class Plaer_Move : MonoBehaviour 
    {
        public float speedMove;
        float x_move, z_move;
        CharacterController Player;
        Vector3 moveDerection;

        void Start ()
        {
            Player = GetComponent<CharacterController>();
        }

        void Update ()
        {
            Move();
        }

        void Move()
        {
            x_move = Input.GetAxis("Horizontal");
            z_move = Input.GetAxis("Vertical");
            if (Player.isGrounded)
            {
                moveDerection = new Vector3(x_move, 0f, z_move);
                moveDerection = transform.TransformDirection(moveDerection);
            }
            Player.Move(moveDerection * speedMove * Time.deltaTime);
        }
    }
}
