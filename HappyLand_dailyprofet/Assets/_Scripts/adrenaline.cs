using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adrenaline : MonoBehaviour
{
    VidaPlayer playerVida;

    public int cantidad;
    public float damageTime;
    float currentDamageTime;
    public float _speed = 7.0f;

    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticallInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticallInput);
        Vector3 velocity = direction * _speed;

        //Convertir el vector velocity en world space. Toma los valores de velocity en local space y pasalos a world space y nuevamente asignalos

    }

    void Start()
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<VidaPlayer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            currentDamageTime += Time.deltaTime;
            if (currentDamageTime > damageTime)
            {
                playerVida.vida += cantidad;
                currentDamageTime = 0.0f;
                Destroy(this.gameObject);

            }
        }
    }


}
