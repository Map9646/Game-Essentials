using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public class BulletBehaviour : MonoBehaviour
    {
        private Rigidbody rBody;
        public float bulletForce;

        private IEnumerator Start() 
        {
            rBody = GetComponent<Rigidbody>();
        
            rBody.AddRelativeForce(Vector3.forward * bulletForce);
            
            yield return new WaitForSeconds(2);
            
            Destroy(gameObject);
        }
    }
}
