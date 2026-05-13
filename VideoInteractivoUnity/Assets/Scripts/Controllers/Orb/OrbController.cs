using UnityEngine;
using UnityEngine.EventSystems;

public class OrbController :MonoBehaviour, IPointerClickHandler

{
    public GlitchController glitchController;

    public float clearAmount = 0.33f;

    public void OnPointerClick(PointerEventData eventData)
    {
        glitchController.ReduceGlitch(clearAmount);

        Destroy(gameObject);
    }
}