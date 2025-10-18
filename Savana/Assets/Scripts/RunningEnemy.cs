using UnityEngine;

public class RunningEnemy : MonoBehaviour
{
    [SerializeField] private float animalSpeed = 10;
    [SerializeField] private float animalHealth = 10;
    [SerializeField] private float healthDamageMultiplier = 1;
    [SerializeField] private float speedDamageMultiplier = 1;
    [SerializeField] private Rigidbody2D animalRigidBody;
    [SerializeField] private Collider2D animalCollider;
    [SerializeField] private Animator animator;
    [SerializeField] private string deathAnimName;
    [SerializeField] private string runningAnimName;

    [SerializeField] private Sprite animalSprite;

    private float damage;

    void Start()
    {
        animator.SetTrigger(runningAnimName);
        animalRigidBody.linearVelocityX = animalSpeed;
    }



    private void OnCollisionEnter2D(Collision2D collision) //CHANGE OUT CLUB FOR ACTUAL COMPONENT
    {

        /*Club clubComponent = collision.gameObject.GetComponent<Club>
         {
            if (clubComponent != null)
            {
                damage = collision.relativeVelocity.magnitude;
                animalHealth -= damage * healthDamageMultiplier;
                animalSpeed -= damage * speedDamageMultiplier;
                if (animalSpeed < 0) { animalSpeed = 0}
                animalRigidBody.linearVelocityX = animalSpeed;

                if (animalHealth <= 0)
                {
                    animalRigidBody.linearVelocityX = 0;
                    animator.SetTrigger(deathAnimName);
                    GameManager.Instance.SetKill();
                    animalCollider.enabled = false;

                }
            }
        }
        */


    }

    public void Death()
    {
        Destroy(gameObject);
    }


}
