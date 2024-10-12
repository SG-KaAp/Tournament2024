using UnityEngine;

public class Bow : MonoBehaviour
{
    private DefaultAction _input;
    [SerializeField] private GameObject _BowArrow;
    [SerializeField] private Vector3 artem;
    private void Awake()
    {
        _input = new DefaultAction();
    }
    private void OnEnable()
    {
        _input.Enable();
    }
    private void OnDisable()
    {
        _input.Disable();
    }
    private void Update()
    {
        if (_input.Player.Attack1.ReadValue<bool>())
        {
            Debug.Log("MamaRastrelat");
        }
    }
}
