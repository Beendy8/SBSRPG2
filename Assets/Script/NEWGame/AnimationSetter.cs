using UnityEngine;

public class AnimationSetter : MonoBehaviour
{
    [SerializeField] private CharacterControllerList characterControllers;

    public void Set(string animName)
    {
        foreach (var controller in characterControllers)
            controller.SetAnimation(animName);
    }


}
