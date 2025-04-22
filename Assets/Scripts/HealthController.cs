using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    int maxHealth = 100;

    [SerializeField]
    int currentHealth = 0;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void DamageOn(int damageAmount)
    {
        currentHealth -= damageAmount;
        
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            this.gameObject.SetActive(false);
        }
    }


}
