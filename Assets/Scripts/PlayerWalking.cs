using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerWalking : MonoBehaviour
{
    AudioSource AudioManager;
    public AudioClip[] Sounds;
    public Transform footTransform;
    public SoundFolder grass;
    public SoundFolder gravel;
    public SoundFolder wood;
    public SoundFolder tile;
    public SoundFolder rock;
    public SoundFolder mud;
    public SoundFolder metal;

    Dictionary<string,SoundFolder> sFolders = new Dictionary<string, SoundFolder>();


    
    Ray floorRay;
    RaycastHit hit;
    string floorName = "DefaultName";
    // Start is called before the first frame update
    void Start()
    {
        AudioManager = GetComponent<AudioSource>();
        sFolders.Add("Gravel",gravel);
        sFolders.Add("Grass",grass);
        sFolders.Add("Wood", wood);
        sFolders.Add("Tile", tile);
        sFolders.Add("Rock", rock);
        sFolders.Add("Mud", mud);
        sFolders.Add("Metal", metal);
    }

    void UpdatePlayerSound(SoundType type)
    {
        floorRay = new Ray(footTransform.position, -transform.up);
        if (Physics.Raycast(floorRay, out hit, 1, ~6))
        {
            floorName = hit.transform.gameObject.tag;
            floorName = floorName.Replace("ground", "");

            //Debug.LogError(floorName);

            foreach (KeyValuePair<string, SoundFolder> kvp in sFolders)
            {
                if (kvp.Key == floorName)
                {
                    if (type == SoundType.Walking)
                    {
                        Sounds = kvp.Value.walkClips;
                    }
                    else if (type == SoundType.Running)
                    {
                        Sounds = kvp.Value.runClips;
                    }
                    else if (type == SoundType.JumpingStart)
                    {
                        Sounds = kvp.Value.JumpStartClips;
                    }
                    else if (type == SoundType.JumpingEnd)
                    {
                        Sounds = kvp.Value.JumpEndClips;
                    }
                }
                //else
                //{
                //    if (gravel.walkClips != null)
                //    {
                //        Sounds = gravel.walkClips;

                //    }
                //    else
                //    {
                //        Sounds = Resources.LoadAll<AudioClip>("Sounds");
                //        Debug.LogError("Player Sounds Failed To Load! Using Backup File Instead");
                //    }
                //}
            }
        }
    }
   
    //void ChangeSound()
    //{
    //    floorRay = new Ray(footTransform.position, -transform.up);
    //    if (Physics.Raycast(floorRay, out hit, 1, ~6))
    //    {
    //        floorName = hit.transform.gameObject.tag;
    //        floorName = floorName.Replace("ground", "");
    //        Debug.LogError(floorName);
    //        walkSounds = Resources.LoadAll<AudioClip>($"Sounds/Footsteps_{floorName}/Walk");
    //        runSounds = Resources.LoadAll<AudioClip>($"Sounds/Footsteps_{floorName}/Run");
    //        jumpSounds = Resources.LoadAll<AudioClip>($"Sounds/Footsteps_{floorName}/Jump");
    //    }
    //    else
    //    {
    //        walkSounds = Resources.LoadAll<AudioClip>("Sounds/Footsteps/Footsteps_Grass/Walk");
    //        runSounds = Resources.LoadAll<AudioClip>("Sounds/Footsteps/Footsteps_Grass/Run");
    //        jumpSounds = Resources.LoadAll<AudioClip>("Sounds/Footsteps/Footsteps_Grass/Jump");
            
    //    }
    //}

    

    // Update is called once per frame
    void Update()   
    {
        Debug.DrawRay(footTransform.position, -transform.up, Color.blue);

    }

    public void PlayWalkSound()
    {
        UpdatePlayerSound(SoundType.Walking);
        int amount = Random.Range(0, Sounds.Length);
        Debug.Log($"Played Walking sound number {amount}");
        if (!AudioManager.isPlaying)
        {
            AudioManager.PlayOneShot(Sounds[amount]);
        }
    }

    public void PlayRunSound()
    {
        UpdatePlayerSound(SoundType.Running);
        int amount = Random.Range(0, Sounds.Length);
        Debug.Log($"Played Walking sound Number {amount}");
        if (!AudioManager.isPlaying)
        {
            AudioManager.PlayOneShot(Sounds[amount]);
        }
    }

    public void PlayJumpStartSound()
    {
        UpdatePlayerSound(SoundType.JumpingStart);
        int amount = Random.Range(0, Sounds.Length);
        //AudioManager.Stop();
        if (!AudioManager.isPlaying)
        {
            AudioManager.PlayOneShot(Sounds[amount]);
        }
    }

    public void PlayJumpEndSound()
    {
        UpdatePlayerSound(SoundType.JumpingEnd);
        int amount = Random.Range(0, Sounds.Length);
        //AudioManager.Stop();
        if (!AudioManager.isPlaying)
        {
            AudioManager.PlayOneShot(Sounds[amount]);
        }
    }

    enum SoundType
    {
        Walking,
        Running,
        JumpingStart,
        JumpingEnd,
        Sliding
    }
}
