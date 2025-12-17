using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{
    [SerializeField] private float jumpAnimationTime = 0.8f;
    
    public void JumpAction(Rigidbody rb, float jumpForce, Animator ani)
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        ani.SetBool("Jump", true);
        
        // Iniciar corrutina para resetear el bool
        StartCoroutine(ResetJumpBool(ani));
    }
    
    IEnumerator ResetJumpBool(Animator ani)
    {
        // Esperar el tiempo de la animación de salto
        yield return new WaitForSeconds(jumpAnimationTime);
        
        // Resetear el bool
        ani.SetBool("Jump", false);
        Debug.Log("Bool Jump reset a false");
    }
}