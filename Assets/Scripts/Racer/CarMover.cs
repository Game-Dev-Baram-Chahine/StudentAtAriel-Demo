using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMover : MonoBehaviour
{
    [SerializeField] public float speed = 5.0f; // The speed at which the car moves
    [SerializeField] float despawnPoint = -13.0f;

    void Update()
    {
        // Move the car to the right
        //transform.Translate(-speed * Time.deltaTime, 0.0f, 0.0f);
        transform.Translate(0.0f, 0.0f, speed * Time.deltaTime);
        // If the car has exited the screen, destroy it
        speed = (speed - (10*Time.deltaTime));
        if (transform.position.x < despawnPoint)
        {
            Destroy(gameObject);
            Score.AddScore(Score.pointsForCar);
            int index = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(index);
        }
    }
}
