using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rig;

    public bool hitPlayer = true;
    public bool hitEnemy = true;

    public float damage = 1f;

    public GameObject hitFX;

    private void OnTriggerEnter(Collider other)
    {
        if (hitPlayer && other.CompareTag("Player"))
        {
            //other.GetComponet<PlayerContreller>().GetHit(damage);
        }
        if (hitEnemy && other.CompareTag("Enemy"))
        {
            //other.GetComponet<EnemyContreller>().GetHit(damage);  
        }

        if (hitFX) Instantiate(hitFX, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public void LateUpdate()
    {
        if (rig.linearVelocity.sqrMagnitude > 0.01f)
        {
            transform.rotation = Quaternion.LookRotation(rig.linearVelocity);
        }
    }
}
