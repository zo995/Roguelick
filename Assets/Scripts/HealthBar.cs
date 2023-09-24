using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Image healthbar;
    public float maxHP = 100;
    public float HP;
    void Start()
    {
        healthbar = GetComponent<Image>();
        HP = maxHP;
    }

    void Update()
    {
        healthbar.fillAmount = HP / maxHP;
    }
}
