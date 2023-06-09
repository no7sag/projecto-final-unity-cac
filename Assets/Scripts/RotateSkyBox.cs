using UnityEngine;

public class RotateSkyBox : MonoBehaviour
{
    [SerializeField] float _rotateRate = 1.1f;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * _rotateRate);
    }

    void OnDisable()
    {
        RenderSettings.skybox.SetFloat("_Rotation", 0);
    }
}
