using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPlayerGiveUp : MonoBehaviour
{
    public Rigidbody2D _rb2D;
    [Header("Movimiento")]
    private float _MovimientoHorizontal;
    [SerializeField]private float _velocidadMovimiento;
    [Range(0,0.3f)][SerializeField]private float _suavizado;
    private Vector3 _velocidad = Vector3.zero;
    private bool _mirandoDerecha = true;

    [Header("Salto")]
    [SerializeField]private float _fuerzaDeSalto;
    [SerializeField]private LayerMask _queEsSuelo;
    [SerializeField]private Transform _controladorSuelo;
    [SerializeField]private Vector3 _dimensionesCaja;
    
    [SerializeField]private bool _enSuelo = false;
    private bool _salto = false;

    [Header("Animacion")]
    public Animator AnimatorPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _MovimientoHorizontal = Input.GetAxis("Horizontal") * _velocidadMovimiento;

        AnimatorPlayer.SetFloat("Horizontal",Mathf.Abs(_MovimientoHorizontal));

        if (Input.GetButtonDown("Jump"))
        {
            _salto = true;
        }
    }

    void FixedUpdate()
    {
        _enSuelo = Physics2D.OverlapBox(_controladorSuelo.position,_dimensionesCaja,0f,_queEsSuelo);

        AnimatorPlayer.SetBool("enSuelo",_enSuelo);

        Mover(_MovimientoHorizontal*Time.fixedDeltaTime,_salto);

        _salto = false;
    }

    private void Mover(float mover, bool saltar)
    {
        Vector3 _velocidadObjetivo = new Vector2(mover,_rb2D.velocity.y);
        _rb2D.velocity = Vector3.SmoothDamp(_rb2D.velocity,_velocidadObjetivo,ref _velocidad,_suavizado);

        if (mover > 0 && !_mirandoDerecha)
        {
            Girar();
        }
        else if (mover < 0 && _mirandoDerecha)
        {
            Girar();
        }

        if (_enSuelo && saltar)
        {
            _enSuelo = false;
            _rb2D.AddForce(new Vector2(0f,_fuerzaDeSalto));
        }
    }

    private void Girar()
    {
        _mirandoDerecha = !_mirandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x*=-1;
        transform.localScale = escala;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(_controladorSuelo.position,_dimensionesCaja);
    }
}
