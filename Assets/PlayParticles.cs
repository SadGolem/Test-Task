using UnityEngine;

public class PlayParticles : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particlePrefab;
    [SerializeField] private Transform _parent;

    public void PlayParticle()
    {
        CreateParticle();
    }

    private void CreateParticle()
    {
        var particle = Instantiate(_particlePrefab);
        particle.Play();
    }
}
