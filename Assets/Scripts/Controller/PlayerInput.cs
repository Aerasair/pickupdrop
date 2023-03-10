using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Joystick _joystick;
    [SerializeField] private Animator _animator;

    [SerializeField] private float _moveSpeed;

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);

        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            _animator.Play("Run");
        }
        else
            _animator?.SetBool("isRunning", false);
    }

}
