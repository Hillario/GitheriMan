using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//AP ID:: ca-app-pub-2532705426398982~8854661745

//banner ad unit ID:: ca-app-pub-2532705426398982/6163374631

//video ad id:: ca-app-pub-2532705426398982/3302064114



public class idleplay : MonoBehaviour {

    public Text distance;
    public Text best;

    private float bestdistance;
    private float mydistance;
    public Text mchongoanao;

    private AudioSource myaudio;

    void Awake() {
        randMchongoano();
    }
	// Use this for initialization
	void Start () {
        myaudio = GetComponent<AudioSource>();
        bestdistance = PlayerPrefs.GetFloat("ultimatedistance");
        mydistance = PlayerPrefs.GetFloat("normaldistance");
	}
	
	// Update is called once per frame
	void Update () {
        distance.text = "distance: " + mydistance + "M";
        best.text = "best: " + bestdistance+"M";

        if (Input.GetKeyDown(KeyCode.Escape))
        {            
            SceneManager.LoadScene("mainmenu");
        }
	}

    public void loadGame()
    {
        myaudio.Play();
        StartCoroutine("loadmyscene");       
    }

    public IEnumerator loadmyscene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("main"); 
    }   
    void randMchongoano()
    {
        int rand = Random.Range(1, 90);

        if (rand == 1)
        {
            mchongoanao.text = "Asubuhi Asubuhi avocado na arufu ya vitungu";
        }
        else if (rand == 2)
        {
            mchongoanao.text = "Asubuhi Asubuhi kokoto na kumi kumi";
        }
        else if (rand == 3)
        {
            mchongoanao.text = "Asubuhi Asubuhi Patco na mapera";
        }
        else if (rand == 4)
        {
            mchongoanao.text = "Kwenyu mmesota sana wezi wakiingia wanatoka na experience tu";
        }
        else if (rand == 5)
        {
            mchongoanao.text = "Asubuhi asubuhi goodygoody na makojo ya ngamia";
        }
        else if (rand == 6)
        {
            mchongoanao.text = "Asubuhi asubuhi harufu ya gumboot na BIG G";
        }
        else if (rand == 7)
        {
            mchongoanao.text = "Kwenyu mmesota sana wezi wakiingia wanatoka na experience tu";
        }
        else if (rand == 8)
        {
            mchongoanao.text = "Mmesota hadi nyi hukula ugali na story za nyama";
        }
        else if (rand == 9)
        {
            mchongoanao.text = "Buda ako ni mjinga, first time kupanda ndege alisema shukisha junction";
        }
        else if (rand == 10)
        {
            mchongoanao.text = "We m-ugly, ulipokuwa mtoi masako alikufeed na feya";
        }
        else if (rand == 11)
        {
            mchongoanao.text = "Sistako mshort aneza temebea chini ya bed";
        }
        else if (rand == 12)
        {
            mchongoanao.text = "Kwenu mko wengi hata mkienda dining room mnaingia na gate pass";
        }
        else if (rand == 13)
        {
            mchongoanao.text = "Sistako mshort aneza temebea chini ya bed";
        }
        else if (rand == 14)
        {
            mchongoanao.text = "First time yako ku-buy ball gum shopkeeper alikugei ya green ukasema 'nataka ile imeiva'";
        }
        else if (rand == 15)
        {
            mchongoanao.text = "Nyanyako ni kipofu lakini mwachie kwa kuchagua ngotha za valentine";
        }
        else if (rand == 16)
        {
            mchongoanao.text = "Wewe ni miser mpaka ukiwa kwa KBS back seat ukiitishwa doo unapoint nyuma";
        }
        else if (rand == 17)
        {
            mchongoanao.text = "Wewe ni fala mpaka uikiingia kwa KBS unapiga hodi na unatoa viatu";
        }
        else if (rand == 18)
        {
            mchongoanao.text = "Manzi wako ni mtall mpaka Mungu akiboeka anamsuka matuta";
        }
        else if (rand == 19)
        {
            mchongoanao.text = "Kwenu nyinyi ni wagesi mpaka coackroach zinademonstrate juu ya njaa";
        }
        else if (rand == 20)
        {
            mchongoanao.text = "Nyinyi kwenu ni wa black mkiingia kwa moti yenyu dirisha zinakuwa tinted";
        }
        else if (rand == 21)
        {
            mchongoanao.text = "Mathako ni mshamba mpaka the first time alipanda mathree alitandika vitambaa";
        }
        else if (rand == 22)
        {
            mchongoanao.text = "Ati kwenu nyinyi wachafu mpaka mkimaliza kuoga sabuni inawasengenya";
        }
        else if (rand == 23)
        {
            mchongoanao.text = "Nyinyi m-mesota mpaka mna-kunywanga chai na kifuniko ya Bic";
        }
        else if (rand == 24)
        {
            mchongoanao.text = "Budako ni mjinga mpaka alipoingia kwa buu aliambia konda amshikie chuma ndio atoe pesa";
        }
        else if (rand == 25)
        {
            mchongoanao.text = "TV yenu ndogo na nyinyi ni wengi mpaka mkitaka kuiona nyi wote lazima kila mtu afunge macho moja";
        }
        else if (rand == 26)
        {
            mchongoanao.text = "Budako mugly mbaka anaishia home kutoka zoo na mandizi mob amegeiwa na matourist";
        }
        else if (rand == 27)
        {
            mchongoanao.text = "Wewe ni mblack mpaka ukiwa karibu na makaa ya kuuza, customer anasema niwekee ile kubwa";
        }
        else if (rand == 28)
        {
            mchongoanao.text = "We mfupi mpaka unatoka kwa basi na parachute";
        }
        else if (rand == 29)
        {
            mchongoanao.text = "Unamdomo bigi we hukula avocado kama njugu";
        }
        else if (rand == 30)
        {
            mchongoanao.text = "Wewe ni mrefu mpaka ukivaa trao inaisha fashion kabla ifike kwa waist";
        }
        else if (rand == 31)
        {
            mchongoanao.text = "Wewe ni fala unarewind CD na biro pen";
        }
        else if (rand == 32)
        {
            mchongoanao.text = "Breathe yako sumu ukiyawn asubuhi jogoo hudedi";
        }
        else if (rand == 33)
        {
            mchongoanao.text = "Paka yenu noma mpaka ikishika panya inaitisha chumvi";
        }
        else if (rand == 34)
        {
            mchongoanao.text = "Maskio yako kubwa ukiingia hoteli chai inapoa";
        }
        else if (rand == 35)
        {
            mchongoanao.text = "Kwenu ni kuchafu mpaka mende zenu huvaa slippers";
        }
        else if (rand == 36)
        {
            mchongoanao.text = "Maskio yako kubwa ukiingia hoteli chai inapoa";
        }
        else if (rand == 37)
        {
            mchongoanao.text = "Kwenu muko wadosi mpaka kuku zenu zinafanya aerobics saa kumi na kunywa juice instead ya maji";
        }
        else if (rand == 38)
        {
            mchongoanao.text = "Mapua zako bigi, ukingia class charts zinaanza kudunda";
        }
        else if (rand == 39)
        {
            mchongoanao.text = "Mdomo kubwa kama bakuli ya jela";
        }
        else if (rand == 40)
        {
            mchongoanao.text = "We ni mblack mpaka ukisimama karibu na ukuta ya white watu wanafikiria eti ni shortcut wapitie thru hiyo shimo";
        }
        else if (rand == 41)
        {
            mchongoanao.text = "We mrefu mpaka ukianza kuvaa handa by the time ifike kwa magoti ime rust";
        }
        else if (rand == 42)
        {
            mchongoanao.text = "Paka yenyu imeona mamovie mpaka ikifuata panya inalia tereng! tereng!";
        }
        else if (rand == 43)
        {
            mchongoanao.text = "Uko mweusi mpaka kwa night class unashow meno ndio usimakiwe absent";
        }
        else if (rand == 44)
        {
            mchongoanao.text = "Mathako mnono akikalia kobole Moi hutoa makamasi";
        }
        else if (rand == 45)
        {
            mchongoanao.text = "Fathako mchafu mbaka ana mtaro kwa kifua";
        }
        else if (rand == 46)
        {
            mchongoanao.text = "Budako mblack akilala kwa road madere wanafikiri ni speed bump";
        }
        else if (rand == 47)
        {
            mchongoanao.text = "We ni mrefu mpaka ukichoka kaa unatembea mtaani unajisupport na wire za simu";
        }
        else if (rand == 48)
        {
            mchongoanao.text = "Mlango za gari yenyu huwa zinafungwa na vifungo za shati";
        }
        else if (rand == 49)
        {
            mchongoanao.text = "Budako uhepa gumbaru, anaenda kuangalia tractor ikikata manyasi";
        }
        else if (rand == 50)
        {
            mchongoanao.text = "Wewe ni mshort mpaka ukikalia kwa pavement miguu ina hang kwa hewa";
        }
        else if (rand == 51)
        {
            mchongoanao.text = "Nywele za watoto wenyu ni ngumu mpaka mnazitumianga kama steel wool";
        }
        else if (rand == 52)
        {
            mchongoanao.text = "Wewe ni mrefu mpaka ni wewe huongezea jua makaa";
        }
        else if (rand == 53)
        {
            mchongoanao.text = "Chali yako ni mkonda alibloiwa na wind mpaka S.Africa na hana passport";
        }
        else if (rand == 54)
        {
            mchongoanao.text = "We mchafu mpaka nzi ikikulandia inavaa slippers";
        }
        else if (rand == 55)
        {
            mchongoanao.text = "We ni mweusi hadi mbu ikitaka kukuuma yo huitisha torch";
        }
        else if (rand == 56)
        {
            mchongoanao.text = "Ulimeza cassette ya koffi ukanyamba ndombolo";
        }
        else if (rand == 57)
        {
            mchongoanao.text = "Kwenu muko wengi mpaka mathe hupika chapo mbili zingine anafanya photocopy ndio yeye na fathe wakule original";
        }
        else if (rand == 58)
        {
            mchongoanao.text = "Nyanyako hana meno lakini ni mdedli kwa kufungua chupa ya coke";
        }
        else if (rand == 59)
        {
            mchongoanao.text = "Unamatako kubwa mpaka watu hupata marao na kuidandia kama mathree";
        }
        else if (rand == 60)
        {
            mchongoanao.text = "Nyanyako ni mdedli karate mpaka wasee wa F2 wakamchora ka baunsa";
        }
        else if (rand == 61)
        {
            mchongoanao.text = "Kichwa kama basi ya bed ford ya zamani";
        }
        else if (rand == 62)
        {
            mchongoanao.text = "We ni mrefu mpaka usiku miguu zinalala kwa jirani";
        }
        else if (rand == 63)
        {
            mchongoanao.text = "Una matiti so mpaka we uzitupa kwa mgongo times za kuosha manguo";
        }
        else if (rand == 64)
        {
            mchongoanao.text = "We m-ugly mpaka kipofu anavaa paperbag kukubinja";
        }
        else if (rand == 65)
        {
            mchongoanao.text = "We mrefu mpaka KQ wanakuitia job ya kupanguza dirisha za ndege";
        }
        else if (rand == 66)
        {
            mchongoanao.text = "Budako huhepa job ku-slide na socks";
        }
        else if (rand == 67)
        {
            mchongoanao.text = "Mathako ana matiti makubwa akimaliza kuoga ye huzifunga na shower curtain badala ya bra";
        }
        else if (rand == 68)
        {
            mchongoanao.text = "Kwenu nyi ni ma-miser mpaka price ya colgate ikipanda mnateta na hamna meno";
        }
        else if (rand == 69)
        {
            mchongoanao.text = "We ni mwizi mpaka padlock ikikuona inajifunga";
        }
        else if (rand == 70)
        {
            mchongoanao.text = "Wewe ni mgreedy mpaka mother-ko akiwa na ball yako akipika chapo siku moja, ulichomoa mkono ukasema nigeee!";
        }
        else if (rand == 71)
        {
            mchongoanao.text = "Budako ana mikono ngumu, akishika kobole, inampatia change ya mafeeu";
        }
        else if (rand == 72)
        {
            mchongoanao.text = "Kwenyu muko wengi, ukifungua mlango watu watatu wanadunda inje";
        }
        else if (rand == 73)
        {
            mchongoanao.text = "Kwenyu kuchafu mpaka mende zenu ni oboho, ati wanaambia wale new wakae ridho kwa kitchen";
        }
        else if (rand == 74)
        {
            mchongoanao.text = "Vile nyinyi wagesi, budako akishika ten shillings, ati Moi ana baki na vest";
        }
        else if (rand == 75)
        {
            mchongoanao.text = "Budako uhepa job kwenda kucheza katii na mboch";
        }
        else if (rand == 76)
        {
            mchongoanao.text = "We mzee na danda mbaka ulikuwa naso na onyato ati na ujamada form four bado";
        }
        else if (rand == 77)
        {
            mchongoanao.text = "We mchafu mpaka mahindi zimegrow kwa armpits na ukijikuna zinageuka unga";
        }
        else if (rand == 78)
        {
            mchongoanao.text = "Budako amevaa ngotha moja folong mbaka siku aliitoa ikaanguka halafu ikapasuka kaa nyungu";
        }
        else if (rand == 79)
        {
            mchongoanao.text = "We mblack mpaka ukikutana na mzungu afternoon anakushow Good evening?";
        }
        else if (rand == 80)
        {
            mchongoanao.text = "Mbuyu wako ni mrefu mpaka anauzia wasee wa ndege mahindi ya kuchoma";
        }
        else if (rand == 81)
        {
            mchongoanao.text = "Kwenyu nyinyi wachoyo mpaka mkipika kuku mnakula kama hamjawasha stima";
        }
        else if (rand == 82)
        {
            mchongoanao.text = "Tv yenyu nzee mpaka mkishuta kwa hao wasee wa kbc wanafunga mapua";
        }
        else if (rand == 83)
        {
            mchongoanao.text = "Ngozi ya nyanyako ni tight mpaka aki wink, mguu yake inainuka";
        }
        else if (rand == 84)
        {
            mchongoanao.text = "Dogi yenyu mzee mpaka kauzi aki'come,yumtemea mate";
        }
        else if (rand == 85)
        {
            mchongoanao.text = "Ati ulikuwa na bro wako kejani ukiskiza redio halafu mtangazaji akasema ati tunawapeleka moja";
        }
        else if (rand == 86)
        {
            mchongoanao.text = "kwa moja hadi uwanja wa uhuru park. Ati kuskia hivyo mkadandia redio.";
        }
        else if (rand == 87)
        {
            mchongoanao.text = "Ati huyu jamaa aki na shingo ndefu mpaka iko na elbow";
        }
        else if (rand == 88)
        {
            mchongoanao.text = "Ati ha wasee ni masikini hadi wakihama walienda na takataka";
        }
        else if (rand == 89)
        {
            mchongoanao.text = "Esto yenu hamwezi tumia mulika mwizi, utamulika nani na kila ni mwizi";
        }
        else if (rand == 90)
        {
            mchongoanao.text = "Ati nyanyako ni mzae hadi alisahau handbag yake kwa Noahs’ Ark";
        }
    }
   
}
