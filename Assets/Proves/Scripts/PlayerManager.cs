using UnityEditor.Animations;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    [SerializeField] private Animator animatorController;

    void Start() {

    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Die");
            animatorController.SetTrigger("Die");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Run");
            animatorController.SetFloat("Speed",1f);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("Idle");
            animatorController.SetFloat("Speed", 0f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Atack");
            animatorController.SetTrigger("Attack");
        }
    }
}