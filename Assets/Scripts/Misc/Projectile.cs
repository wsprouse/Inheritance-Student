using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed;
    public float duration;
    public ThrownWeapon origin;

    // Start is called before the first frame update
    void Awake()
    {
        duration = origin.attackDuration;
        Invoke("DelayedDestroy", duration);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.GetComponent<Enemy>().TakeDamage(origin.damage);
        }
    }

    public void DelayedDestroy()
    {
        Destroy(gameObject);
    }


}
