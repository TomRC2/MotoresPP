using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ReceiveDamage : MonoBehaviour
{
    public int health;
    public int damage;
    

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Bullet")) 
        {
            health -= damage;
            

        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnDestroy()
    {
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
        if (scoreManager != null)
        {
            scoreManager.AddPoint();
        }
    }
}
