using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 15f;
    public float damage = 10f;
    public float lifetime = 5f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        
        //Debug.Log(other.gameObject.name);

        //Debug.Log(other.gameObject.name);


        if (other.CompareTag("Enemy"))
        {
            Health health = other.GetComponent<Health>();
            Debug.Log("Enemy Health" + health.currentHealth);
            if (health != null)
            {
                health.TakeDamage(damage);
            }
            Destroy(gameObject);
        }

        //other.GetComponent<Health>()?.TakeDamage(damage);
        //Destroy(gameObject);
    }
}
