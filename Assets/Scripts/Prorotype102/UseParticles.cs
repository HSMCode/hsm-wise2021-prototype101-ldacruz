using UnityEngine;

namespace Assets.Scripts
{
    public class UseParticles : MonoBehaviour
    {
        public ParticleSystem playParticleSystem;
        public ParticleSystem emitParticleSystem;

        public void PlayingParticles(bool on)
        {
            if (on)
            {
                playParticleSystem.Play();                 
            } 
            else if(!on)
            {
                playParticleSystem.Stop();
            }
        }
        
        public void EmitParticles()
        {
            emitParticleSystem.Emit(5);
        }
    }
}
