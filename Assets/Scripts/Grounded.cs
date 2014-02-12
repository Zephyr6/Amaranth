using UnityEngine;
using System.Collections;

public class Grounded : MonoBehaviour {
    public Transform groundCheck;
    public bool IsGrounded = false;

	void Update () {
        IsGrounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        if(!IsGrounded)
            IsGrounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Squamp"));
	}
}
