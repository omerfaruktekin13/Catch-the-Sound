using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Orta_33 : MonoBehaviour
{
    public GameObject bir, iki,uc,dort, yandinpanel, gectinpanel, tekrarlapanel, exitpanel;
    public Button buton1, buton2,buton3,buton4;
    float zaman;
    int skor;
    public Text zaman_text, skor_text;
    public SpriteRenderer a, b,c,d;
    public AudioSource[] audios_doga;
    public AudioSource[] audios_muzik;
    int s_111, s_112, s_113, s_114, s_115, s_116, s_121, s_122, s_123, s_124, s_125, s_126, s_131, s_132, s_133, s_134, s_135, s_136, s_141, s_142, s_143, s_144, s_145, s_146,
        s_211, s_212, s_213, s_214, s_221, s_222, s_223, s_224,s_231,s_232,s_233,s_234,s_241,s_242,s_243,s_244;
    public Sprite[] doga_sprite;
    public Sprite[] muzik_sprite;
    void Start()
    {
        gectinpanel.SetActive(false); yandinpanel.SetActive(false); tekrarlapanel.SetActive(false); exitpanel.SetActive(false);
        //1 3 2 4 1 4 3 2 1 4
        s_111 = Random.Range(0, 10); s_121 = Random.Range(0, 10); while (s_111 == s_121) { s_121 = Random.Range(0, 10); } s_131 = Random.Range(0, 10); while (s_121 == s_131|| s_111 == s_131) { s_131 = Random.Range(0, 10); }s_141 = Random.Range(0, 10); while (s_131 == s_141 || s_111 == s_141 || s_121 == s_141) { s_141 = Random.Range(0, 10); }
        s_112 = Random.Range(0, 10); s_122 = Random.Range(0, 10); while (s_112 == s_122) { s_122 = Random.Range(0, 10); } s_132 = Random.Range(0, 10); while (s_122 == s_132|| s_112 == s_132) { s_132 = Random.Range(0, 10); }s_142 = Random.Range(0, 10); while (s_132 == s_142 || s_112 == s_142 || s_122 == s_142) { s_142 = Random.Range(0, 10); }
        s_113 = Random.Range(0, 10); s_123 = Random.Range(0, 10); while (s_113 == s_123) { s_123 = Random.Range(0, 10); } s_133 = Random.Range(0, 10); while (s_123 == s_133|| s_113 == s_133) { s_133 = Random.Range(0, 10); }s_143 = Random.Range(0, 10); while (s_133 == s_143 || s_113 == s_143 || s_123 == s_143) { s_143 = Random.Range(0, 10); }
        s_114 = Random.Range(0, 10); s_124 = Random.Range(0, 10); while (s_114 == s_124) { s_124 = Random.Range(0, 10); } s_134 = Random.Range(0, 10); while (s_124 == s_134|| s_114 == s_134) { s_134 = Random.Range(0, 10); }s_144 = Random.Range(0, 10); while (s_134 == s_144 || s_114 == s_144 || s_124 == s_144) { s_144 = Random.Range(0, 10); }
        s_115 = Random.Range(0, 10); s_125 = Random.Range(0, 10); while (s_115 == s_125) { s_125 = Random.Range(0, 10); } s_135 = Random.Range(0, 10); while (s_125 == s_135|| s_115 == s_135) { s_135 = Random.Range(0, 10); }s_145 = Random.Range(0, 10); while (s_135 == s_145 || s_115 == s_145 || s_125 == s_145) { s_145 = Random.Range(0, 10); }
        s_116 = Random.Range(0, 10); s_126 = Random.Range(0, 10); while (s_116 == s_126) { s_126 = Random.Range(0, 10); } s_136 = Random.Range(0, 10); while (s_126 == s_136|| s_116 == s_136) { s_136 = Random.Range(0, 10); }s_146 = Random.Range(0, 10); while (s_136 == s_146 || s_116 == s_146 || s_126 == s_146) { s_146 = Random.Range(0, 10); }



        s_211 = Random.Range(0, 7); s_221 = Random.Range(0, 7); while (s_211 == s_221) { s_221 = Random.Range(0, 7); }s_231 = Random.Range(0, 7); while (s_221 == s_231|| s_211 == s_231) { s_231 = Random.Range(0, 7); }s_241 = Random.Range(0, 7); while (s_231 == s_241 || s_211 == s_241 || s_221 == s_241) { s_241 = Random.Range(0, 7); }
        s_212 = Random.Range(0, 7); s_222 = Random.Range(0, 7); while (s_212 == s_222) { s_222 = Random.Range(0, 7); }s_232 = Random.Range(0, 7); while (s_222 == s_232|| s_212 == s_232) { s_232 = Random.Range(0, 7); }s_242 = Random.Range(0, 7); while (s_232 == s_242 || s_212 == s_242 || s_222 == s_242) { s_242 = Random.Range(0, 7); }
        s_213 = Random.Range(0, 7); s_223 = Random.Range(0, 7); while (s_213 == s_223) { s_223 = Random.Range(0, 7); }s_233 = Random.Range(0, 7); while (s_223 == s_233|| s_213 == s_233) { s_233 = Random.Range(0, 7); }s_243 = Random.Range(0, 7); while (s_233 == s_243 || s_213 == s_243 || s_223 == s_243) { s_243 = Random.Range(0, 7); }
        s_214 = Random.Range(0, 7); s_224 = Random.Range(0, 7); while (s_214 == s_224) { s_224 = Random.Range(0, 7); }s_234 = Random.Range(0, 7); while (s_224 == s_234|| s_214 == s_234) { s_234 = Random.Range(0, 7); }s_244 = Random.Range(0, 7); while (s_234 == s_244 || s_214 == s_244 || s_224 == s_244) { s_244 = Random.Range(0, 7); }

        audios_doga[s_111].PlayDelayed(3.0f); audios_doga[s_132].PlayDelayed(13.0f); audios_doga[s_123].PlayDelayed(23.0f);
        audios_doga[s_144].PlayDelayed(33.0f); audios_doga[s_115].PlayDelayed(43.0f); audios_doga[s_146].PlayDelayed(53.0f);
        audios_muzik[s_231].PlayDelayed(63.0f); audios_muzik[s_222].PlayDelayed(73.0f); audios_muzik[s_213].PlayDelayed(83.0f); audios_muzik[s_244].PlayDelayed(93.0f);
        buton1.onClick.AddListener(button1olay);
        buton2.onClick.AddListener(button2olay);
        buton3.onClick.AddListener(button3olay);
        buton4.onClick.AddListener(button4olay);
       
    }

    // Update is called once per frame
    void Update()
    {
        zaman += Time.deltaTime;
        zaman_text.text = (zaman % 10).ToString("F0");
        skor_text.text = skor.ToString();
        if (zaman <= 5)//1
        {
            bir.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            iki.transform.position = new Vector2(3, 2 - zaman % 5);//-
            uc.transform.position = new Vector2(3 - zaman % 5, -3);//-
            dort.transform.position = new Vector2(-2, -3 + zaman % 5);//-
        }
        else if (zaman <= 10 && zaman > 5)//2
        {
            bir.transform.position = new Vector2(3, 2 - zaman % 5);//-
            iki.transform.position = new Vector2(3 - zaman % 5, -3);//-
            uc.transform.position = new Vector2(-2, -3+ zaman % 5);//-
            dort.transform.position = new Vector2(-2 + zaman % 5,2);//-
        }
        else if (zaman <= 15 && zaman > 10)//3
        {
            bir.transform.position = new Vector2(3 - zaman % 5, -3);//-
            iki.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            uc.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            dort.transform.position = new Vector2(3, 2-zaman%5);//-
        }
        else if (zaman <= 20 && zaman > 15)//4
        {
            bir.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            iki.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            uc.transform.position = new Vector2(3, 2-zaman%5);//-
            dort.transform.position = new Vector2(3-zaman%5, -3);//-
        }
        else if (zaman <= 25 && zaman > 20)//5
        {
            bir.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            iki.transform.position = new Vector2(3, 2 - zaman % 5);//-
            uc.transform.position = new Vector2(3 - zaman % 5, -3);//-
            dort.transform.position = new Vector2(-2, -3 + zaman % 5);//-
        }
        else if (zaman <= 30 && zaman > 25)//6
        {
            bir.transform.position = new Vector2(3, 2 - zaman % 5);//-
            iki.transform.position = new Vector2(3 - zaman % 5, -3);//-
            uc.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            dort.transform.position = new Vector2(-2 + zaman % 5, 2);//-
        }
        else if (zaman <= 35 && zaman > 30)//7
        {
            bir.transform.position = new Vector2(3 - zaman % 5, -3);//-
            iki.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            uc.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            dort.transform.position = new Vector2(3, 2 - zaman % 5);//-
        }
        else if (zaman <= 40 && zaman > 35)//8
        {
            bir.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            iki.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            uc.transform.position = new Vector2(3, 2 - zaman % 5);//-
            dort.transform.position = new Vector2(3 - zaman % 5, -3);//-
        }
        else if (zaman <= 45 && zaman > 40)//9
        {
            bir.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            iki.transform.position = new Vector2(3, 2 - zaman % 5);//-
            uc.transform.position = new Vector2(3 - zaman % 5, -3);//-
            dort.transform.position = new Vector2(-2, -3 + zaman % 5);//-
        }
        else if (zaman <= 50 && zaman > 45)//10
        {
            bir.transform.position = new Vector2(3, 2 - zaman % 5);//-
            iki.transform.position = new Vector2(3 - zaman % 5, -3);//-
            uc.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            dort.transform.position = new Vector2(-2 + zaman % 5, 2);//-
        }
        else if (zaman <= 55 && zaman > 50)//11
        {
            bir.transform.position = new Vector2(3 - zaman % 5, -3);//-
            iki.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            uc.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            dort.transform.position = new Vector2(3, 2 - zaman % 5);//-
        }
        else if (zaman <= 60 && zaman > 55)//12
        {
            bir.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            iki.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            uc.transform.position = new Vector2(3, 2 - zaman % 5);//-
            dort.transform.position = new Vector2(3 - zaman % 5, -3);//-
        }
        else if (zaman <= 65 && zaman > 60)//13
        {
            bir.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            iki.transform.position = new Vector2(3, 2 - zaman % 5);//-
            uc.transform.position = new Vector2(3 - zaman % 5, -3);//-
            dort.transform.position = new Vector2(-2, -3 + zaman % 5);//-
        }
        else if (zaman <= 70 && zaman > 65)//14
        {
            bir.transform.position = new Vector2(3, 2 - zaman % 5);//-
            iki.transform.position = new Vector2(3 - zaman % 5, -3);//-
            uc.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            dort.transform.position = new Vector2(-2 + zaman % 5, 2);//-
        }
        else if (zaman <= 75 && zaman > 70)//15
        {
            bir.transform.position = new Vector2(3 - zaman % 5, -3);//-
            iki.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            uc.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            dort.transform.position = new Vector2(3, 2 - zaman % 5);//-
        }
        else if (zaman <= 80 && zaman > 75)//16
        {
            bir.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            iki.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            uc.transform.position = new Vector2(3, 2 - zaman % 5);//-
            dort.transform.position = new Vector2(3 - zaman % 5, -3);//-
        }
        else if (zaman <= 85 && zaman > 80)//17
        {
            bir.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            iki.transform.position = new Vector2(3, 2 - zaman % 5);//-
            uc.transform.position = new Vector2(3 - zaman % 5, -3);//-
            dort.transform.position = new Vector2(-2, -3 + zaman % 5);//-
        }
        else if (zaman <= 90 && zaman > 85)//18
        {
            bir.transform.position = new Vector2(3, 2 - zaman % 5);//-
            iki.transform.position = new Vector2(3 - zaman % 5, -3);//-
            uc.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            dort.transform.position = new Vector2(-2 + zaman % 5, 2);//-
        }
        else if (zaman <= 95 && zaman > 90)//19
        {
            bir.transform.position = new Vector2(3 - zaman % 5, -3);//-
            bir.transform.position = new Vector2(-2, -3 + zaman % 5);//
            uc.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            dort.transform.position = new Vector2(3, 2 - zaman % 5);//-
        }
        else if (zaman <= 100 && zaman > 95)//20
        {
            bir.transform.position = new Vector2(-2, -3 + zaman % 5);//
            iki.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            uc.transform.position = new Vector2(3, 2 - zaman % 5);//-
            dort.transform.position = new Vector2(3 - zaman % 5, -3);//-
        }

        if (zaman > 0 && zaman < 10) { a.sprite = doga_sprite[s_111]; b.sprite = doga_sprite[s_121]; c.sprite=doga_sprite[s_131]; d.sprite= doga_sprite[s_141]; }
        else if (zaman > 10 && zaman < 20) { a.sprite = doga_sprite[s_112]; b.sprite = doga_sprite[s_122]; c.sprite = doga_sprite[s_132]; d.sprite =  doga_sprite[s_142]; }
        else if (zaman > 20 && zaman < 30) { a.sprite = doga_sprite[s_113]; b.sprite = doga_sprite[s_123]; c.sprite = doga_sprite[s_133]; d.sprite = doga_sprite[s_143]; }
        else if (zaman > 30 && zaman < 40) { a.sprite = doga_sprite[s_114]; b.sprite = doga_sprite[s_124]; c.sprite = doga_sprite[s_134]; d.sprite = doga_sprite[s_144]; }
        else if (zaman > 40 && zaman < 50) { a.sprite = doga_sprite[s_115]; b.sprite = doga_sprite[s_125]; c.sprite = doga_sprite[s_135]; d.sprite = doga_sprite[s_145]; }
        else if (zaman > 50 && zaman < 60) { a.sprite = doga_sprite[s_116]; b.sprite = doga_sprite[s_126]; c.sprite = doga_sprite[s_136]; d.sprite = doga_sprite[s_146]; }
        else if (zaman > 60 && zaman < 70) { a.sprite = muzik_sprite[s_211]; b.sprite = muzik_sprite[s_221];c.sprite= muzik_sprite[s_231]; d.sprite = muzik_sprite[s_241]; }
        else if (zaman > 70 && zaman < 80) { a.sprite = muzik_sprite[s_212]; b.sprite = muzik_sprite[s_222];c.sprite= muzik_sprite[s_232]; d.sprite = muzik_sprite[s_242]; }
        else if (zaman > 80 && zaman < 90) { a.sprite = muzik_sprite[s_213]; b.sprite = muzik_sprite[s_223]; c.sprite = muzik_sprite[s_233]; d.sprite = muzik_sprite[s_243]; }
        else if (zaman > 90 && zaman < 100) { a.sprite = muzik_sprite[s_214]; b.sprite = muzik_sprite[s_224]; c.sprite = muzik_sprite[s_234]; d.sprite = muzik_sprite[s_244]; }
        if (zaman > 100)
        {
            if (skor < 3) { yandinpanel.SetActive(true); }
            else if (skor >= 3 && skor < 7) { tekrarlapanel.SetActive(true); }
            else if (skor >= 7) { gectinpanel.SetActive(true); }
        }
    }
    public void cikis()
    {
        exitpanel.SetActive(true);
    }
    public void anamenu()
    {
        SceneManager.LoadScene("anaekran");
    }
    public void tekrarla_o1()
    {
        SceneManager.LoadScene("o1");
    }
    public void tekrarla_o2()
    {
        SceneManager.LoadScene("o2");
    }
    public void tekrarla_o3()
    {
        SceneManager.LoadScene("o3");
    }
    public void yenibolum_o1()
    {
        SceneManager.LoadScene("z1");
    }
    public void yenibolum_o2()
    {
        SceneManager.LoadScene("z2");
    }
    public void yenibolum_o3()
    {
        SceneManager.LoadScene("z3");
    }
    public void eskibolum_o1()
    {
        SceneManager.LoadScene("k1");
    }
    public void eskibolum_o2()
    {
        SceneManager.LoadScene("k2");
    }
    public void eskibolum_o3()
    {
        SceneManager.LoadScene("k3");
    }
    void button1olay()
    {
        if ((zaman > 0 && zaman < 10) || (zaman > 40 && zaman < 50) || (zaman > 80 && zaman < 90))
        {
            skor += 1;
        }
    }
    void button2olay()
    {
        if ((zaman > 20 && zaman < 30) || (zaman > 70 && zaman < 80) )
        {
            skor += 1;
        }
    }
    void button3olay()
    {
        if ((zaman > 10 && zaman < 20) || (zaman > 60 && zaman < 70) )
        {
            skor += 1;
        }
    }
    void button4olay()
    {
        if ((zaman > 30 && zaman < 40) || (zaman > 50 && zaman < 60) || (zaman > 90 && zaman < 100))
        {
            skor += 1;
        }
    }
}
