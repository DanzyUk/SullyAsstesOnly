using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    //private static MusicPlayer musicmangerinstance;

    public AudioSource gamemusic;//Game music 


    /**void Awake()
    {
        DontDestroyOnLoad(this);

        if (musicmangerinstance == null)
        {
            musicmangerinstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        TEST CODE TO ALLOW GAMEMUSIC TO PLAY ACROSS ALL SCENECES
    }**/
    public void Start()
    {
        gamemusic = GetComponent<AudioSource> ();// getting audio source  
    }
    public void mute()//Mutefunction used in the mainmenu setting to must game music
    {
       gamemusic.mute = !gamemusic.mute;//Muting the audio sorce if toggled

    }
}
