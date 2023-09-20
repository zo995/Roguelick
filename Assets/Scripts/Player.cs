using UnityEngine;

namespace rogualick
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float rotetionSpeed;

        private Rigidbody rb;

        private void Start ()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            Vector3 moveInput = new Vector3(x: Input.GetAxis("Horizontal"), y: 0, z: Input.GetAxis("Vertical"));

            Quaternion rotation = Quaternion.LookRotation(moveInput);
            rotation.x = 0;
            rotation.z = 0;
            transform.rotation = Quaternion.Lerp(a:transform.rotation, b:rotation, t:rotetionSpeed * Time.deltaTime);

            rb.AddForce(moveInput *  speed);
        }
    }
}
