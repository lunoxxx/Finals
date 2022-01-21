using UnityEngine;

public class FireBall : MonoBehaviour
{
    public GameObject damageEffect;
    public int damageAmount = 100;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Instantiate(damageEffect, transform.position, damageEffect.transform.rotation);
            other.GetComponent<Enemy>().TakeDamage(damageAmount);
            Destroy(gameObject);
        }
    }
}
