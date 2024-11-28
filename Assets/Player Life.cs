using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] AudioSource deathSound;
    bool dead = false;

    public GameObject deathScreenCanvas;
    public GameObject coinsText;

    private void Update()
    {
        if (transform.position.y < -1f && !dead)
        {
            Die();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Body"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<PlayerMovement>().enabled = false;
            Die();
        }
    }
    void Die()
    {
        Invoke(nameof(ReloadLevel), 1.3f);
        dead = true;
        deathSound.Play();
        deathScreenCanvas.SetActive(true);

        coinsText.SetActive(false);

        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
    }
    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
