using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField] private float speed=10;
    [SerializeField] private float gravity = 50;
    [SerializeField] private float jumpForce = 30;
    private AudioSource stepsAudio;
    private Animator animator;
    private Vector3 direction;
    private bool isRun;

    void Start() {
        controller = this.gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        // moveHorizontal будет принимать значение -1 если нажата кнопка A, 1 если нажата D, 0 если эти кнопки не нажаты
        float moveHorizontal = Input.GetAxis("Horizontal");
        // moveVertical будет принимать значение -1 если нажата кнопка S, 1 если нажата W, 0 если эти кнопки не нажаты
        float moveVertical = 1;

        if (controller.isGrounded) //проверяем что мы не на земле (тема условий будет дальше)
        {
            direction = new Vector3(moveHorizontal, 0, moveVertical);
            //Дополнительно умноая его на скорость передвижения (преобразуя локальные координаты к глобальным)
            direction = transform.TransformDirection(direction) * speed;



            if (Input.GetKey(KeyCode.Space)) //Проверяем что нажали пробел для прыжка
            {
                // animator.SetTrigger("Jump");
                direction.y = jumpForce;
            }

        }

        direction.y -= gravity * Time.deltaTime;
        controller.Move(direction * Time.deltaTime);
    }
}
