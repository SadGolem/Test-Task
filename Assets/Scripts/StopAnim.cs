using UnityEngine;

public class StopAnim : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void StopAnimation()
    {
        _animator.enabled = false;
    }
}
