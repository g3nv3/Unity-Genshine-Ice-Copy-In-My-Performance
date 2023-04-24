using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CinemachineFreeLook _cinemachineFreeLook;
    [SerializeField] private float _sensivityZoom;

    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") != 0f){
            _cinemachineFreeLook.m_Orbits[0].m_Height = Mathf.Clamp(_cinemachineFreeLook.m_Orbits[0].m_Height - Input.GetAxis("Mouse ScrollWheel") * _sensivityZoom * Time.deltaTime, 2f, 12f);

            _cinemachineFreeLook.m_Orbits[1].m_Height = Mathf.Clamp(_cinemachineFreeLook.m_Orbits[1].m_Height - Input.GetAxis("Mouse ScrollWheel") * _sensivityZoom * Time.deltaTime, -2f, 8.7f);
            _cinemachineFreeLook.m_Orbits[1].m_Radius = Mathf.Clamp(_cinemachineFreeLook.m_Orbits[1].m_Radius - Input.GetAxis("Mouse ScrollWheel") * _sensivityZoom * Time.deltaTime, 6f, 16.7f) ;

            _cinemachineFreeLook.m_Orbits[2].m_Height = Mathf.Clamp(_cinemachineFreeLook.m_Orbits[2].m_Height - Input.GetAxis("Mouse ScrollWheel") * _sensivityZoom * Time.deltaTime, -11.5f, -0.8f);
            _cinemachineFreeLook.m_Orbits[2].m_Radius = Mathf.Clamp(_cinemachineFreeLook.m_Orbits[2].m_Radius - Input.GetAxis("Mouse ScrollWheel") * _sensivityZoom * Time.deltaTime, 4f, 14.7f);
        }
        
    }
}
