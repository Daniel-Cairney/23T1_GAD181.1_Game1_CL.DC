using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DanCon
{


    public class Damaged : MonoBehaviour
    {


        [SerializeField] private Material flashMaterial;

        [SerializeField] private float duration;

        private SpriteRenderer spriteRenderer;

        private Material origMaterial;

        private Coroutine flashRoutine;

        private void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
            origMaterial = spriteRenderer.material;
        }

        private IEnumerator FlashRoutine()
        {
            spriteRenderer.material = flashMaterial;
            yield return new WaitForSeconds(duration);

            spriteRenderer.material = origMaterial;
            flashRoutine = null;
        }

        public void Flash()
        {

            flashRoutine = StartCoroutine(FlashRoutine());
        }



    }
}
