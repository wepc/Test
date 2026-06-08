using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    PlayerCore CharacterData;
    bool isOnGround;
    Rigidbody rb;
    Animator animator;
    private void OnEnable()
    {
        CharacterData = GetComponent<PlayerCore>();
        rb = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;

    }
    private void OnCollisionExit(Collision collision)
    {
        isOnGround = false;
        animator.SetBool("IsJump", false);

    }
    private void Update()
    {

        switch (Input.GetAxis("Horizontal"))
        {
            case not 0f:
                animator.SetBool("IsWalk", true);
                break;
            default:
                animator.SetBool("IsWalk", false);
                break;


        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(1,0,0) * CharacterData.Speed * Time.deltaTime;
            animator.SetFloat("Vector", 1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position -= new Vector3(1, 0, 0) * CharacterData.Speed * Time.deltaTime;
            animator.SetFloat("Vector", -1f);


        }
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(new Vector3 (0,8,0), ForceMode.Impulse);
            animator.SetBool("IsJump", true);
            
        }

    }

}
