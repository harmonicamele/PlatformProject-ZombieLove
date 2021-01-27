using UnityEditor.Tilemaps;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float walkspeed = 4f;
    [SerializeField] float speed = 4f;
    [SerializeField] float runspeed = 8f;
    bool runing;
    AudioSource walkSound;
    bool isMoving = false;
    private void Awake()
    {
        walkSound = GetComponent<AudioSource>();
    }
    //public bool Run => runing; 
    private void Update()
    {
        if (runing)
        {
            speed = runspeed;

        }
        else
        {
            speed = walkspeed;
            runing = false;
        }
    }

    public void MoveAction(float horizontal)
    {

        transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);
        isMoving = true;
        if (isMoving == true)
        {

            walkSound.Play();

        }
        else
        {
            walkSound.Stop();
        }
    }



}
