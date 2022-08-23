using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zinnia.Action
{
    public class PickUp : Interactables
    {
        public Tilia.Interactions.Interactables.Interactors.GrabInteractorConfigurator interactorR,interactorL;
                
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void pickUp(bool booleansy)
        {
            interactorL.Ungrab();
            interactorR.Ungrab();
           
            StartCoroutine(destroyObjectDelay());
        }

        public override void triggered()
        {
            Destroy(this.transform.parent.gameObject);
        }

        IEnumerator destroyObjectDelay()
        {
            yield return 0;

            Destroy(this.transform.parent.gameObject);

        }
    }

}
