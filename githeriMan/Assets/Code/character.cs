using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class character : MonoBehaviour {

    private Rigidbody2D myRigidBody;    
    private Animator anim;
    private bool attack;
    private bool slide;
    [SerializeField]
    private float movementSpeed = 5f;

    [SerializeField]
    private Transform[] groundPoints;

    [SerializeField]
    private float groundRadius; //radius to indicate how close player needs to be in the ground before the player is considered grounded
    [SerializeField]
    private LayerMask whatIsGround;
    [SerializeField]
    private float jumpForce;

    private bool jump;
    [SerializeField]
    private bool isgrounded;
    private bool isdead=false;

    private bool doubleJump;

    [SerializeField]
    private float hungerlevel = 100f;
    private float gpoint=5f;
    private float effort=2f;
    

    [SerializeField]
    private Slider hungerSlider;
    public Image hungeralert;
    public Text distance;

    public static float distanceTraveled;
    public float mydistance;

    private float horizontal = 1f;
    private bool onTouch = false;

    //distance variables
    public float normaldistance = 0f;
    public float uniquedistance = 0f;
    public float ultimatedistance = 0f;
    public float finaldistance = 0f;

    public AudioClip run;
    public AudioClip myjump;    

    private AudioSource myaudio;
    public GameObject camRun;    
    private AudioSource mycamrun;   
    

	// Use this for initialization
	void Start () {        
        myaudio = GetComponent<AudioSource>();
        mycamrun = camRun.GetComponent<AudioSource>();       
        myRigidBody = GetComponent<Rigidbody2D>();        
        anim = GetComponent<Animator>();
        hungeralert.enabled = false;

        finaldistance = PlayerPrefs.GetFloat("ultimatedistance");
	}
	
	// Update is called once per frame
	void Update () {      
        
        //decrement hunger level
        hungerSlider.minValue = 0;
        hungerSlider.maxValue = 100;
        hungerlevel -= effort * Time.deltaTime;       
        hungerSlider.value = hungerlevel;

        if (hungerlevel <= 20)
        {
            //show hunger alert
            hungeralert.enabled = true;
        }
        else
        {
            hungeralert.enabled = false;
        }
        if (hungerlevel <= 0)
        {
            onDeath();
        }

        distanceTraveled = transform.localPosition.x;
        mydistance = Mathf.Round(distanceTraveled);
        distance.text = "Distance: " + mydistance;

        if (transform.localPosition.y < -0.2)
        {            
           //load the idle play scene
            onDeath();
        }
        anim.SetBool("dead", isdead);     
	}

    void FixedUpdate() {        
        handleInputs();
        onTouch = false;
        if (isgrounded)
        {
            doubleJump = false;
            mycamrun.enabled = true;
        }
        else if (!isgrounded)
        {
            mycamrun.enabled = false;
        }
          
        isgrounded = isGrounded();        
        handleMovement(horizontal);
    }

    

    private void handleMovement(float horizontal)
    {
        myRigidBody.velocity = new Vector2(horizontal * movementSpeed, myRigidBody.velocity.y);
        //handle jumps
        anim.SetFloat("vSpeed", myRigidBody.velocity.y);
        
    }    
    private void handleInputs()
    {     
        if ((isgrounded || !doubleJump) && onTouch)//Input.GetKeyDown(KeyCode.Space))
        {
            myaudio.clip = myjump;
            myaudio.Play();

            anim.SetBool("grounded", isgrounded);
            myRigidBody.AddForce(new Vector2(0f, jumpForce));                       
            if (!doubleJump && !isgrounded)
            {
                doubleJump = true;
            }
        }
        else
        {                      
            anim.SetBool("grounded", isgrounded);
        }
    }   
    //function checking if player is grounded
    private bool isGrounded()
    {
        if (myRigidBody.velocity.y <= 0)
        {
            foreach (Transform point in groundPoints)
            {
                //contains all the collliders coliding with the player
                Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, whatIsGround);

                for (int i = 0; i < colliders.Length; i++)
                {
                    //if colliders in player is not equivalent to attached, then it's grounded
                    if (colliders[i].gameObject != gameObject)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    //collision with foreground gameobjects
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "gpoint")
        {
            //increament hunger level
            hungerlevel += gpoint;
            
        }

        if (other.transform.tag == "spike")
        {
            onDeath();           
        }

        if (other.transform.tag == "saw")
        {
            onDeath();
        }
        if (other.transform.tag == "stone")
        {
            onDeath();
        }
        if (other.transform.tag == "skeleton")
        {
            onDeath();
        }
        if (other.transform.tag == "direction")
        {
            onDeath();
        }
        if (other.transform.tag == "bush")
        {
            onDeath();
        }
        if (other.transform.tag == "bill")
        {
            onDeath();
        }


    }
   
    void onDeath() {        
        //dead animation and timer for loading the idleplay scene
        isdead = true;
        horizontal = 0f;
        BoxCollider2D mybox = gameObject.GetComponent<BoxCollider2D>();
        mybox.size = new Vector2(0.79f, 0.56f);       
        //save the distanceTravelled
        PlayerPrefs.SetFloat("normaldistance", mydistance);

        if (mydistance > finaldistance)
        {
            uniquedistance = mydistance;
        }else{
            uniquedistance = finaldistance;
        }

        PlayerPrefs.SetFloat("ultimatedistance", uniquedistance);        
        StartCoroutine("loadScene");       
    }

    public void detectTouch()
    {
        onTouch = true;
    }

    IEnumerator loadScene()
    {
        yield return new WaitForSeconds(3);
        //load play idle scene        
        SceneManager.LoadScene("idleplay");
    }
    
 
}
