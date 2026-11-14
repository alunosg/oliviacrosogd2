using UnityEngine;

public class CatAnimator : MonoBehaviour
{
    private Animator anim;
    public float pose = 7;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetFloat("Pose", pose);
    }
}
