using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropScript : MonoBehaviour
{
    public bool fall;

    public AudioClip SoundToPLay;
    public float volume;
    AudioSource sound;
    public bool soundPlayed;

    public Rigidbody body;
    private GlobalScore gameMode;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        body = GetComponentInChildren<Rigidbody>();
        soundPlayed = false;
        gameMode = transform.parent.parent.parent.parent.gameObject.GetComponent<GlobalScore>();
    }

    // Update is called once per frame
    void Update()
    {
        if (body.position.y < 0f && !soundPlayed)
        {
            fall = true;
            sound.PlayOneShot(SoundToPLay, 0.3f);
            soundPlayed = true;
            gameMode.IncrementScore();

            SpringJoint joint = GetComponentInChildren<SpringJoint>();
            if (joint)
            {
                Destroy(joint);
            }
        }
    }
}
