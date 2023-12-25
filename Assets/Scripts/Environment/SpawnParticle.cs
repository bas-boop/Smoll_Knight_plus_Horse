using UnityEngine;

namespace Baz_geluk9.SKPH
{
    public sealed class SpawnParticle : MonoBehaviour
    {
        [SerializeField] private ParticleSystem[] particles;

        public void SpawnParticles(int particleToSpawn)
        {
            ParticleSystem instantiate = Instantiate(particles[particleToSpawn], gameObject.transform);
            instantiate.transform.position = transform.position;
        }
    }
}
