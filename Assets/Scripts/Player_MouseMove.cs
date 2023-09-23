using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_MouseMove : MonoBehaviour
{
    float xRotetion, yRotetion;
    public Camera player;
    public GameObject playerGameObject;
    public float sensivity = 5f;

    private void Update()
    {
        mauseMove();
    }

    void mauseMove()
    {
        xRotetion += Input.GetAxis("Mouse X") * sensivity;
        yRotetion += Input.GetAxis("Mouse Y") * sensivity;
        player.transform.rotation = Quaternion.Euler(-yRotetion, xRotetion, 0f);
        playerGameObject.transform.rotation = Quaternion.Euler(0f, xRotetion, 0f);
    }
}
