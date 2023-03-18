using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Kolayy_3 : MonoBehaviour
{
    //Doðrular= 1 1 2 1 2 2 1 2 2 1
    public GameObject bir, iki, yandinpanel, gectinpanel, tekrarlapanel, exitpanel;
    public Button buton1, buton2,buton3,buton4;
    float ilk;
    float zaman;
    int skor;
    public Text zaman_text, skor_text;
    public SpriteRenderer a, b;
    public AudioSource[] audios_hayvan;
    public AudioSource[] audios_insan;
    int s_111, s_112, s_113, s_114, s_115, s_116, s_121, s_122, s_123, s_124, s_125, s_126, s_211, s_212, s_213, s_214, s_221, s_222, s_223, s_224;
    public Sprite[] hayvan_sprite;
    public Sprite[] insan_sprite;
    void Start()
    {
        gectinpanel.SetActive(false);yandinpanel.SetActive(false);tekrarlapanel.SetActive(false);exitpanel.SetActive(false);
        skor = 0;
        zaman = 0f;
        s_111 = Random.Range(0, 10); s_121 = Random.Range(0, 10); while (s_111 == s_121) { s_121 = Random.Range(1, 10); }
        s_112 = Random.Range(0, 10); s_122 = Random.Range(0, 10); while (s_112 == s_122) { s_122 = Random.Range(1, 10); }
        s_113 = Random.Range(0, 10); s_123 = Random.Range(0, 10); while (s_113 == s_123) { s_123 = Random.Range(1, 10); }
        s_114 = Random.Range(0, 10); s_124 = Random.Range(0, 10); while (s_114 == s_124) { s_124 = Random.Range(1, 10); }
        s_115 = Random.Range(0, 10); s_125 = Random.Range(0, 10); while (s_115 == s_125) { s_125 = Random.Range(1, 10); }
        s_116 = Random.Range(0, 10); s_126 = Random.Range(0, 10); while (s_116 == s_126) { s_126 = Random.Range(1, 10); }

        s_211 = Random.Range(0, 7); s_221 = Random.Range(0, 7); while (s_211 == s_221) { s_221 = Random.Range(0, 7); }
        s_212 = Random.Range(0, 7); s_222 = Random.Range(0, 7); while (s_212 == s_222) { s_222 = Random.Range(0, 7); }
        s_213 = Random.Range(0, 7); s_223 = Random.Range(0, 7); while (s_213 == s_223) { s_223 = Random.Range(0, 7); }
        s_214 = Random.Range(0, 7); s_224 = Random.Range(0, 7); while (s_214 == s_224) { s_224 = Random.Range(0, 7); }

        audios_hayvan[s_111].PlayDelayed(3.0f); audios_hayvan[s_112+10].PlayDelayed(13.0f); audios_hayvan[s_123+20].PlayDelayed(23.0f); 
        audios_hayvan[s_114+30].PlayDelayed(33.0f);audios_hayvan[s_125+40].PlayDelayed(43.0f); audios_hayvan[s_126+50].PlayDelayed(53.0f); 
        audios_insan[s_211].PlayDelayed(63.0f);audios_insan[s_222+7].PlayDelayed(73.0f); audios_insan[s_223+14].PlayDelayed(83.0f); audios_insan[s_214+21].PlayDelayed(93.0f);
        buton1.onClick.AddListener(button1olay);
        buton2.onClick.AddListener(button2olay);
    }

    // Update is called once per frame
    void Update()
    {
        zaman += Time.deltaTime;
        zaman_text.text= (zaman%10).ToString("F0");
        skor_text.text = skor.ToString();
        if(zaman<=5)
        {
            bir.transform.position = new Vector2(-2+zaman%5, 2);//-
            iki.transform.position = new Vector2(3, 2 - zaman % 5);//-
        }
        else if(zaman<=10 && zaman >5)
        {
            bir.transform.position = new Vector2(3, 2-zaman%5 );//-
            iki.transform.position = new Vector2(3 - zaman % 5, -3);//-
        }
        else if(zaman <= 15 && zaman>10)
        {
            bir.transform.position = new Vector2(3-zaman%5, -3);//-
            iki.transform.position = new Vector2(-2, -3 + zaman % 5);//-
        }
        else if (zaman <= 20 && zaman > 15)
        {
            bir.transform.position = new Vector2(-2, -3+zaman%5);//-
            iki.transform.position = new Vector2(-2 + zaman % 5, 2);//-
        }
        else if (zaman <= 25 && zaman > 20)
        {
            bir.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            iki.transform.position = new Vector2(3, 2 - zaman % 5);//-
        }
        else if (zaman <= 30 && zaman > 25)
        {
            bir.transform.position = new Vector2(3, 2-zaman%5);//-
            iki.transform.position = new Vector2(3 - zaman % 5, -3);//-
        }
        else if (zaman <= 35 && zaman > 30)
        {
            bir.transform.position = new Vector2(3 - zaman%5, -3);//-
            iki.transform.position = new Vector2(-2, -3 + zaman % 5);//-
        }
        else if (zaman <= 40 && zaman > 35)
        {
            bir.transform.position = new Vector2(-2, -3+zaman%5);//-
            iki.transform.position = new Vector2(-2 + zaman % 5, 2);//-
        }
        else if (zaman <= 45 && zaman > 40)
        {
            bir.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            iki.transform.position = new Vector2(3, 2 - zaman % 5);//-
        }
        else if (zaman <= 50 && zaman > 45)
        {
            bir.transform.position = new Vector2(3, 2 - zaman % 5);//-
            iki.transform.position = new Vector2(3 - zaman % 5, -3);//-
        }
        else if (zaman <= 55 && zaman > 50)
        {
            bir.transform.position = new Vector2(3 - zaman % 5, -3);//-
            iki.transform.position = new Vector2(-2, -3 + zaman % 5);//-
        }
        else if (zaman <= 60 && zaman > 55)
        {
            bir.transform.position = new Vector2(-2, -3+zaman%5);//-
            iki.transform.position = new Vector2(-2 + zaman % 5, 2);//-
        }
        else if (zaman <= 65 && zaman > 60)
        {
            bir.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            iki.transform.position = new Vector2(3, 2 - zaman % 5);//-
        }
        else if (zaman <= 70 && zaman > 65)
        {
            bir.transform.position = new Vector2(3 , 2-zaman%5);//-
            iki.transform.position = new Vector2(3 - zaman % 5, -3);//-
        }
        else if (zaman <= 75 && zaman > 70)
        {
            bir.transform.position = new Vector2(3 - zaman % 5, -3);//-
            iki.transform.position = new Vector2(-2, -3 + zaman % 5);//-
        }
        else if (zaman <= 80 && zaman > 75)
        {
            bir.transform.position = new Vector2(-2, -3+zaman%5);//-
            iki.transform.position = new Vector2(-2 + zaman % 5, 2);//-
        }
        else if (zaman <= 85 && zaman > 80)
        {
            bir.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            iki.transform.position = new Vector2(3, 2 - zaman % 5);//-
        }
        else if (zaman <= 90 && zaman > 85)
        {
            bir.transform.position = new Vector2(3, 2-zaman%5);//-
            iki.transform.position = new Vector2(3 - zaman % 5, -3);//-
        }
        else if (zaman <= 95 && zaman > 90)
        {
            bir.transform.position = new Vector2(3 - zaman % 5, -3);//-
            bir.transform.position = new Vector2(-2, -3 + zaman % 5);//
        }
        else if (zaman <= 100 && zaman > 95)
        {
            bir.transform.position = new Vector2(-2, -3+zaman%5);//
            iki.transform.position = new Vector2(-2 + zaman % 5, 2);//-
        }

        if (zaman > 0 && zaman < 10) { a.sprite = hayvan_sprite[s_111]; b.sprite = hayvan_sprite[s_121]; }
        else if(zaman > 10 && zaman < 20) { a.sprite = hayvan_sprite[s_112]; b.sprite = hayvan_sprite[s_122]; }
        else if (zaman > 20 && zaman < 30) { a.sprite = hayvan_sprite[s_113]; b.sprite = hayvan_sprite[s_123]; }
        else if (zaman > 30 && zaman < 40) { a.sprite = hayvan_sprite[s_114]; b.sprite = hayvan_sprite[s_124];}
        else if (zaman > 40 && zaman < 50) { a.sprite = hayvan_sprite[s_115]; b.sprite = hayvan_sprite[s_125]; }
        else if (zaman > 50 && zaman < 60) { a.sprite = hayvan_sprite[s_116]; b.sprite = hayvan_sprite[s_126]; }
        else if (zaman > 60 && zaman < 70) { a.sprite = insan_sprite[s_211]; b.sprite = insan_sprite[s_212]; }
        else if (zaman > 70 && zaman < 80) { a.sprite = insan_sprite[s_212]; b.sprite = insan_sprite[s_222]; }
        else if (zaman > 80 && zaman < 90) { a.sprite = insan_sprite[s_213]; b.sprite = insan_sprite[s_223]; }
        else if (zaman > 90 && zaman < 100) { a.sprite = insan_sprite[s_214]; b.sprite = insan_sprite[s_224]; }
        if (zaman > 100)
        {
            if (skor < 3) { yandinpanel.SetActive(true); }
            else if (skor >= 3 && skor < 7) { tekrarlapanel.SetActive(true); }
            else if (skor >= 7) { gectinpanel.SetActive(true); }
        }
    }
    void button1olay()
    {
        if((zaman>0&&zaman<10)|| (zaman > 10 && zaman < 20) || (zaman > 30 && zaman < 40) || (zaman > 60 && zaman < 70) || (zaman > 90 && zaman < 100))
        {
            skor += 1;
        }
    }
    void button2olay()
    {
        if ((zaman > 20 && zaman < 30) || (zaman > 40 && zaman < 50) || (zaman > 50 && zaman < 60) || (zaman > 70 && zaman < 80) || (zaman > 80 && zaman < 90))
        {
            skor += 1;
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
    public void tekrarla_k1()
    {
        SceneManager.LoadScene("k1");
    }
    public void tekrarla_k2()
    {
        SceneManager.LoadScene("k2");
    }
    public void tekrarla_k3()
    {
        SceneManager.LoadScene("k3");
    }
    public void yenibolum_k1()
    {
        SceneManager.LoadScene("o1");
    }
    public void yenibolum_k2()
    {
        SceneManager.LoadScene("o2");
    }
    public void yenibolum_k3()
    {
        SceneManager.LoadScene("o3");
    }
    public void eskibolum_k2()
    {
        SceneManager.LoadScene("z1");
    }
    public void eskibolum_k3()
    {
        SceneManager.LoadScene("z2");
    }
}
