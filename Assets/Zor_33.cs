using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Zor_33 : MonoBehaviour
{
    public GameObject bir, iki, uc, dort,bes,alti, yandinpanel, gectinpanel, tekrarlapanel, exitpanel;
    public Button buton1, buton2, buton3, buton4,buton5,buton6;
    float zaman;
    int skor;
    public Text zaman_text, skor_text;
    public SpriteRenderer a, b, c, d,e,f;
    public AudioSource[] audios_doga;
    public AudioSource[] audios_hayvan;
    public AudioSource[] audios_muzik;
    public AudioSource[] audios_insan;
    int s_111, s_112, s_113, s_121, s_122, s_123, s_131, s_132, s_133, s_141, s_142, s_143,s_151,s_152, s_153,s_161,s_162,s163, s_163,
        s_211, s_212, s_221, s_222,  s_231, s_232, s_241, s_242, s_251, s_252, s_261, s_262,
        s_311,s_312,s_313,s_321,s_322,s_323,s_331,s_332,s_333,s_341,s_342,s_343,s_351,s_352,s_353,s_361,s_362,s_363,
        s_411,s_412,s_421,s_422,s_431,s_432,s_441,s_442,s_451,s_452,s_461,s_462;
    public Sprite[] doga_sprite;
    public Sprite[] hayvan_sprite;
    public Sprite[] muzik_sprite;
    public Sprite[] insan_sprite;
    void Start()
    {
        
        gectinpanel.SetActive(false); yandinpanel.SetActive(false); tekrarlapanel.SetActive(false); exitpanel.SetActive(false);
        s_111 = Random.Range(0, 8); s_121 = Random.Range(0, 8); while (s_111 == s_121) { s_121 = Random.Range(0, 8); }
        s_131 = Random.Range(0, 8); while (s_121 == s_131 || s_111 == s_131) { s_131 = Random.Range(0, 8); }
        s_141 = Random.Range(0, 8); while (s_131 == s_141 || s_111 == s_141 || s_121 == s_141) { s_141 = Random.Range(0, 8); }
        s_151 = Random.Range(0, 8); while (s_131 == s_151 || s_111 == s_151 || s_121 == s_151|| s_141 == s_151) { s_151 = Random.Range(0, 8); }
        s_161 = Random.Range(0, 8); while (s_131 == s_161 || s_111 == s_161 || s_121 == s_161 || s_141 == s_161 || s_151 == s_161) { s_161 = Random.Range(0, 8); }

        s_112 = Random.Range(0, 8); s_122 = Random.Range(0, 8); while (s_112 == s_122) { s_122 = Random.Range(0, 8); }
        s_132 = Random.Range(0, 8); while (s_122 == s_132 || s_112 == s_132) { s_132 = Random.Range(0, 8); }
        s_142 = Random.Range(0, 8); while (s_132 == s_142 || s_112 == s_142 || s_122 == s_142) { s_142 = Random.Range(0, 8); }
        s_152 = Random.Range(0, 8); while (s_132 == s_152 || s_112 == s_152 || s_122 == s_152 || s_142 == s_152) { s_152 = Random.Range(0, 8); }
        s_162 = Random.Range(0, 8); while (s_132 == s_162 || s_112 == s_162 || s_122 == s_162 || s_142 == s_162 || s_152 == s_162) { s_162 = Random.Range(0, 8); }

        s_113 = Random.Range(0, 8); s_123 = Random.Range(0, 8); while (s_113 == s_123) { s_123 = Random.Range(0, 8); }
        s_133 = Random.Range(0, 8); while (s_123 == s_133 || s_113 == s_133) { s_133 = Random.Range(0, 8); }
        s_143 = Random.Range(0, 8); while (s_133 == s_143 || s_113 == s_143 || s_123 == s_143) { s_143 = Random.Range(0, 8); }
        s_153 = Random.Range(0, 8); while (s_133 == s_153 || s_113 == s_153 || s_123 == s_153 || s_143 == s_153) { s_153 = Random.Range(0, 8); }
        s_163 = Random.Range(0, 8); while (s_133 == s_163 || s_113 == s_163 || s_123 == s_163 || s_143 == s_163 || s_153 == s_163) { s_163 = Random.Range(0, 8); }

        s_211 = Random.Range(0, 8); s_221 = Random.Range(0, 8); while (s_211 == s_221) { s_221 = Random.Range(0, 8); }
        s_231 = Random.Range(0, 8); while (s_221 == s_231 || s_211 == s_231) { s_231 = Random.Range(0, 8); }
        s_241 = Random.Range(0, 8); while (s_231 == s_241 || s_211 == s_241 || s_221 == s_241) { s_241 = Random.Range(0, 8); }
        s_251 = Random.Range(0, 8); while (s_231 == s_251 || s_211 == s_251 || s_221 == s_251 || s_241 == s_251) { s_251 = Random.Range(0, 8); }
        s_261 = Random.Range(0, 8); while (s_231 == s_261 || s_211 == s_261 || s_221 == s_261 || s_241 == s_261 || s_251 == s_261) { s_261 = Random.Range(0, 8); }

        s_212 = Random.Range(0, 8); s_222 = Random.Range(0, 8); while (s_212 == s_222) { s_222 = Random.Range(0, 8); }
        s_232 = Random.Range(0, 8); while (s_222 == s_232 || s_212 == s_232) { s_232 = Random.Range(0, 8); }
        s_242 = Random.Range(0, 8); while (s_232 == s_242 || s_212 == s_242 || s_222 == s_242) { s_242 = Random.Range(0, 8); }
        s_252 = Random.Range(0, 8); while (s_232 == s_252 || s_212 == s_252 || s_222 == s_252 || s_242 == s_252) { s_252 = Random.Range(0, 8); }
        s_262 = Random.Range(0, 8); while (s_232 == s_262 || s_212 == s_262 || s_222 == s_262 || s_242 == s_262 || s_252 == s_262) { s_262 = Random.Range(0, 8); }

        s_311 = Random.Range(0, 8); s_321 = Random.Range(0, 8); while (s_311 == s_321) { s_321 = Random.Range(0, 8); }
        s_331 = Random.Range(0, 8); while (s_321 == s_331 || s_311 == s_331) { s_331 = Random.Range(0, 8); }
        s_341 = Random.Range(0, 8); while (s_331 == s_341 || s_311 == s_341 || s_321 == s_341) { s_341 = Random.Range(0, 8); }
        s_351 = Random.Range(0, 8); while (s_331 == s_351 || s_311 == s_351 || s_321 == s_351 || s_341 == s_351) { s_351 = Random.Range(0, 8); }
        s_361 = Random.Range(0, 8); while (s_331 == s_361 || s_311 == s_361 || s_321 == s_361 || s_341 == s_361 || s_351 == s_361) { s_361 = Random.Range(0, 8); }
          
        s_312 = Random.Range(0, 8); s_322 = Random.Range(0, 8); while (s_312 == s_322) { s_322 = Random.Range(0, 8); }
        s_332 = Random.Range(0, 8); while (s_322 == s_332 || s_312 == s_332) { s_332 = Random.Range(0, 8); }
        s_342 = Random.Range(0, 8); while (s_332 == s_342 || s_312 == s_342 || s_322 == s_342) { s_342 = Random.Range(0, 8); }
        s_352 = Random.Range(0, 8); while (s_332 == s_352 || s_312 == s_352 || s_322 == s_352 || s_342 == s_352) { s_352 = Random.Range(0, 8); }
        s_362 = Random.Range(0, 8); while (s_332 == s_362 || s_312 == s_362 || s_322 == s_362 || s_342 == s_362 || s_352 == s_362) { s_362 = Random.Range(0, 8); }

        s_313 = Random.Range(0, 8); s_323 = Random.Range(0, 8); while (s_313 == s_323) { s_321 = Random.Range(0, 8); }
        s_333 = Random.Range(0, 8); while (s_123 == s_333 || s_313 == s_333) { s_333 = Random.Range(0, 8); }
        s_343 = Random.Range(0, 8); while (s_133 == s_343 || s_313 == s_343 || s_323 == s_343) { s_343 = Random.Range(0, 8); }
        s_353 = Random.Range(0, 8); while (s_133 == s_353 || s_313 == s_353 || s_323 == s_353 || s_343 == s_353) { s_353 = Random.Range(0, 8); }
        s_363 = Random.Range(0, 8); while (s_133 == s_363 || s_313 == s_363 || s_323 == s_363 || s_343 == s_363 || s_353 == s_363) { s_363 = Random.Range(0, 8); }

        s_411 = Random.Range(0, 8); s_421 = Random.Range(0, 8); while (s_411 == s_421) { s_421 = Random.Range(0, 8); }
        s_431 = Random.Range(0, 8); while (s_421 == s_431 || s_411 == s_431) { s_431 = Random.Range(0, 8); }
        s_441 = Random.Range(0, 8); while (s_431 == s_441 || s_411 == s_441 || s_421 == s_441) { s_441 = Random.Range(0, 8); }
        s_451 = Random.Range(0, 8); while (s_431 == s_451 || s_411 == s_451 || s_421 == s_451 || s_441 == s_451) { s_451 = Random.Range(0, 8); }
        s_461 = Random.Range(0, 8); while (s_431 == s_461 || s_411 == s_461 || s_421 == s_461 || s_441 == s_461 || s_451 == s_461) { s_461 = Random.Range(0, 8); }

        s_412 = Random.Range(0, 8); s_422 = Random.Range(0, 8); while (s_412 == s_422) { s_422 = Random.Range(0, 8); }
        s_432 = Random.Range(0, 8); while (s_422 == s_432 || s_412 == s_432) { s_432 = Random.Range(0, 8); }
        s_442 = Random.Range(0, 8); while (s_432 == s_442 || s_412 == s_442 || s_422 == s_442) { s_442 = Random.Range(0, 8); }
        s_452 = Random.Range(0, 8); while (s_432 == s_452 || s_412 == s_452 || s_422 == s_452 || s_442 == s_452) { s_452 = Random.Range(0, 8); }
        s_462 = Random.Range(0, 8); while (s_432 == s_462 || s_412 == s_462 || s_422 == s_462 || s_442 == s_462 || s_452 == s_462) { s_462 = Random.Range(0, 8); }
        //2 4 3 5 1      6 2 3 4 3
        audios_doga[s_121].PlayDelayed(3.0f); audios_doga[s_142+8].PlayDelayed(13.0f); audios_doga[s_133+16].PlayDelayed(23.0f);
        audios_hayvan[s_251].PlayDelayed(33.0f); audios_hayvan[s_212+8].PlayDelayed(43.0f); 
        audios_muzik[s_361].PlayDelayed(53.0f); audios_muzik[s_322 + 8].PlayDelayed(63.0f); audios_muzik[s_333+16].PlayDelayed(73.0f);
        audios_insan[s_441].PlayDelayed(83.0f); audios_insan[s_432 + 8].PlayDelayed(93.0f);
        buton1.onClick.AddListener(button1olay);
        buton2.onClick.AddListener(button2olay);
        buton3.onClick.AddListener(button3olay);
        buton4.onClick.AddListener(button4olay);
        buton5.onClick.AddListener(button5olay);
        buton6.onClick.AddListener(button6olay);
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
            bes.transform.position = new Vector2(-2 + zaman % 5, 0 );//-
            alti.transform.position = new Vector2(3- zaman % 5, 0);//-
        }
        else if (zaman <= 10 && zaman > 5)//2
        {
            bir.transform.position = new Vector2(3, 2 - zaman % 5);//-
            iki.transform.position = new Vector2(3 - zaman % 5, -3);//-
            uc.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            dort.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            bes.transform.position = new Vector2(3- zaman % 5, 0);//-
            alti.transform.position = new Vector2(-2+ zaman % 5, 0);//-
        }
        else if (zaman <= 15 && zaman > 10)//3
        {
            bir.transform.position = new Vector2(3 - zaman % 5, -3);//-
            iki.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            uc.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            dort.transform.position = new Vector2(3, 2 - zaman % 5);//-
            bes.transform.position = new Vector2(-2 + zaman % 5, 0);//-
            alti.transform.position = new Vector2(3 - zaman % 5, 0);//-
        }
        else if (zaman <= 20 && zaman > 15)//4
        {
            bir.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            iki.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            uc.transform.position = new Vector2(3, 2 - zaman % 5);//-
            dort.transform.position = new Vector2(3 - zaman % 5, -3);//-
            bes.transform.position = new Vector2(3 - zaman % 5, 0);//-
            alti.transform.position = new Vector2(-2 + zaman % 5, 0);//-
        }
        else if (zaman <= 25 && zaman > 20)//5
        {
            bir.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            iki.transform.position = new Vector2(3, 2 - zaman % 5);//-
            uc.transform.position = new Vector2(3 - zaman % 5, -3);//-
            dort.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            bes.transform.position = new Vector2(-2 + zaman % 5, 0);//-
            alti.transform.position = new Vector2(3 - zaman % 5, 0);//-
        }
        else if (zaman <= 30 && zaman > 25)//6
        {
            bir.transform.position = new Vector2(3, 2 - zaman % 5);//-
            iki.transform.position = new Vector2(3 - zaman % 5, -3);//-
            uc.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            dort.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            bes.transform.position = new Vector2(3 - zaman % 5, 0);//-
            alti.transform.position = new Vector2(-2 + zaman % 5, 0);//-
        }
        else if (zaman <= 35 && zaman > 30)//7
        {
            bir.transform.position = new Vector2(3 - zaman % 5, -3);//-
            iki.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            uc.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            dort.transform.position = new Vector2(3, 2 - zaman % 5);//-
            bes.transform.position = new Vector2(-2 + zaman % 5, 0);//-
            alti.transform.position = new Vector2(3 - zaman % 5, 0);//-
        }
        else if (zaman <= 40 && zaman > 35)//8
        {
            bir.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            iki.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            uc.transform.position = new Vector2(3, 2 - zaman % 5);//-
            dort.transform.position = new Vector2(3 - zaman % 5, -3);//-
            bes.transform.position = new Vector2(3 - zaman % 5, 0);//-
            alti.transform.position = new Vector2(-2 + zaman % 5, 0);//-
        }
        else if (zaman <= 45 && zaman > 40)//9
        {
            bir.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            iki.transform.position = new Vector2(3, 2 - zaman % 5);//-
            uc.transform.position = new Vector2(3 - zaman % 5, -3);//-
            dort.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            bes.transform.position = new Vector2(-2 + zaman % 5, 0);//-
            alti.transform.position = new Vector2(3 - zaman % 5, 0);//-
        }
        else if (zaman <= 50 && zaman > 45)//10
        {
            bir.transform.position = new Vector2(3, 2 - zaman % 5);//-
            iki.transform.position = new Vector2(3 - zaman % 5, -3);//-
            uc.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            dort.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            bes.transform.position = new Vector2(3 - zaman % 5, 0);//-
            alti.transform.position = new Vector2(-2 + zaman % 5, 0);//-
        }
        else if (zaman <= 55 && zaman > 50)//11
        {
            bir.transform.position = new Vector2(3 - zaman % 5, -3);//-
            iki.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            uc.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            dort.transform.position = new Vector2(3, 2 - zaman % 5);//-
            bes.transform.position = new Vector2(-2 + zaman % 5, 0);//-
            alti.transform.position = new Vector2(3 - zaman % 5, 0);//-
        }
        else if (zaman <= 60 && zaman > 55)//12
        {
            bir.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            iki.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            uc.transform.position = new Vector2(3, 2 - zaman % 5);//-
            dort.transform.position = new Vector2(3 - zaman % 5, -3);//-
            bes.transform.position = new Vector2(3 - zaman % 5, 0);//-
            alti.transform.position = new Vector2(-2 + zaman % 5, 0);//-
        }
        else if (zaman <= 65 && zaman > 60)//13
        {
            bir.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            iki.transform.position = new Vector2(3, 2 - zaman % 5);//-
            uc.transform.position = new Vector2(3 - zaman % 5, -3);//-
            dort.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            bes.transform.position = new Vector2(-2 + zaman % 5, 0);//-
            alti.transform.position = new Vector2(3 - zaman % 5, 0);//-
        }
        else if (zaman <= 70 && zaman > 65)//14
        {
            bir.transform.position = new Vector2(3, 2 - zaman % 5);//-
            iki.transform.position = new Vector2(3 - zaman % 5, -3);//-
            uc.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            dort.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            bes.transform.position = new Vector2(3 - zaman % 5, 0);//-
            alti.transform.position = new Vector2(-2 + zaman % 5, 0);//-
        }
        else if (zaman <= 75 && zaman > 70)//15
        {
            bir.transform.position = new Vector2(3 - zaman % 5, -3);//-
            iki.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            uc.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            dort.transform.position = new Vector2(3, 2 - zaman % 5);//-
            bes.transform.position = new Vector2(-2 + zaman % 5, 0);//-
            alti.transform.position = new Vector2(3 - zaman % 5, 0);//-
        }
        else if (zaman <= 80 && zaman > 75)//16
        {
            bir.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            iki.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            uc.transform.position = new Vector2(3, 2 - zaman % 5);//-
            dort.transform.position = new Vector2(3 - zaman % 5, -3);//-
            bes.transform.position = new Vector2(3 - zaman % 5, 0);//-
            alti.transform.position = new Vector2(-2 + zaman % 5, 0);//-
        }
        else if (zaman <= 85 && zaman > 80)//17
        {
            bir.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            iki.transform.position = new Vector2(3, 2 - zaman % 5);//-
            uc.transform.position = new Vector2(3 - zaman % 5, -3);//-
            dort.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            bes.transform.position = new Vector2(-2 + zaman % 5, 0);//-
            alti.transform.position = new Vector2(3 - zaman % 5, 0);//-
        }
        else if (zaman <= 90 && zaman > 85)//18
        {
            bir.transform.position = new Vector2(3, 2 - zaman % 5);//-
            iki.transform.position = new Vector2(3 - zaman % 5, -3);//-
            uc.transform.position = new Vector2(-2, -3 + zaman % 5);//-
            dort.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            bes.transform.position = new Vector2(3 - zaman % 5, 0);//-
            alti.transform.position = new Vector2(-2 + zaman % 5, 0);//-
        }
        else if (zaman <= 95 && zaman > 90)//19
        {
            bir.transform.position = new Vector2(3 - zaman % 5, -3);//-
            bir.transform.position = new Vector2(-2, -3 + zaman % 5);//
            uc.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            dort.transform.position = new Vector2(3, 2 - zaman % 5);//-
            bes.transform.position = new Vector2(-2 + zaman % 5, 0);//-
            alti.transform.position = new Vector2(3 - zaman % 5, 0);//-
        }
        else if (zaman <= 100 && zaman > 95)//20
        {
            bir.transform.position = new Vector2(-2, -3 + zaman % 5);//
            iki.transform.position = new Vector2(-2 + zaman % 5, 2);//-
            uc.transform.position = new Vector2(3, 2 - zaman % 5);//-
            dort.transform.position = new Vector2(3 - zaman % 5, -3);//-
            bes.transform.position = new Vector2(3 - zaman % 5, 0);//-
            alti.transform.position = new Vector2(-2 + zaman % 5, 0);//-
        }
        if (zaman > 0 && zaman < 10) { a.sprite = doga_sprite[s_111]; b.sprite = doga_sprite[s_121]; c.sprite = doga_sprite[s_131]; d.sprite = doga_sprite[s_141]; e.sprite = doga_sprite[s_151]; f.sprite = doga_sprite[s_161]; }
        else if (zaman > 10 && zaman < 20) { a.sprite = doga_sprite[s_112]; b.sprite = doga_sprite[s_122]; c.sprite = doga_sprite[s_132]; d.sprite = doga_sprite[s_142]; e.sprite = doga_sprite[s_152]; f.sprite = doga_sprite[s_162]; }
        else if (zaman > 20 && zaman < 30) { a.sprite = doga_sprite[s_113]; b.sprite = doga_sprite[s_123]; c.sprite = doga_sprite[s_133]; d.sprite = doga_sprite[s_143]; e.sprite = doga_sprite[s_153]; f.sprite = doga_sprite[s_163]; }
        else if (zaman > 30 && zaman < 40) { a.sprite = hayvan_sprite[s_211]; b.sprite = hayvan_sprite[s_221]; c.sprite = hayvan_sprite[s_231]; d.sprite = hayvan_sprite[s_241]; e.sprite = hayvan_sprite[s_251]; f.sprite = hayvan_sprite[s_261]; }
        else if (zaman > 40 && zaman < 50) { a.sprite = hayvan_sprite[s_212]; b.sprite = hayvan_sprite[s_222]; c.sprite = hayvan_sprite[s_232]; d.sprite = hayvan_sprite[s_242]; e.sprite = hayvan_sprite[s_252]; f.sprite = hayvan_sprite[s_262]; }
        else if (zaman > 50 && zaman < 60) { a.sprite = muzik_sprite[s_311]; b.sprite = muzik_sprite[s_321]; c.sprite = muzik_sprite[s_331]; d.sprite = muzik_sprite[s_341]; e.sprite = muzik_sprite[s_351]; f.sprite = muzik_sprite[s_361]; }
        else if (zaman > 60 && zaman < 70) { a.sprite = muzik_sprite[s_312]; b.sprite = muzik_sprite[s_322]; c.sprite = muzik_sprite[s_332]; d.sprite = muzik_sprite[s_342]; e.sprite = muzik_sprite[s_352]; f.sprite = muzik_sprite[s_362]; }
        else if (zaman > 70 && zaman < 80) { a.sprite = muzik_sprite[s_313]; b.sprite = muzik_sprite[s_323]; c.sprite = muzik_sprite[s_333]; d.sprite = muzik_sprite[s_343]; e.sprite = muzik_sprite[s_353]; f.sprite = muzik_sprite[s_363]; }
        else if (zaman > 80 && zaman < 90) { a.sprite = insan_sprite[s_111]; b.sprite = insan_sprite[s_121]; c.sprite = insan_sprite[s_131]; d.sprite = insan_sprite[s_141]; e.sprite = insan_sprite[s_151]; f.sprite = insan_sprite[s_161]; }
        else if (zaman > 90 && zaman < 100) { a.sprite = insan_sprite[s_112]; b.sprite = insan_sprite[s_122]; c.sprite = insan_sprite[s_132]; d.sprite = insan_sprite[s_142]; e.sprite = insan_sprite[s_152]; f.sprite = insan_sprite[s_162]; }
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
    public void tekrarla_z1()
    {
        SceneManager.LoadScene("z1");
    }
    public void tekrarla_z2()
    {
        SceneManager.LoadScene("z2");
    }
    public void tekrarla_z3()
    {
        SceneManager.LoadScene("z3");
    }
    public void yenibolum_z1()
    {
        SceneManager.LoadScene("k2");
    }
    public void yenibolum_z2()
    {
        SceneManager.LoadScene("k3");
    }
    
    public void eskibolum_z1()
    {
        SceneManager.LoadScene("o1");
    }
    public void eskibolum_z2()
    {
        SceneManager.LoadScene("o2");
    }
    public void eskibolum_z3()
    {
        SceneManager.LoadScene("o3");
    }
    //2 4 3 5 1      6 2 3 4 3
    void button1olay()
    {
        if ((zaman > 40 && zaman < 50) )
        {
            skor += 1;
        }
    }
    void button2olay()
    {
        if ((zaman > 0 && zaman < 10) || (zaman > 60 && zaman < 70))
        {
            skor += 1;
        }
    }
    void button3olay()
    {
        if ((zaman > 20 && zaman < 30) || (zaman > 70 && zaman < 80) || (zaman > 90 && zaman < 100))
        {
            skor += 1;
        }
    }
    void button4olay()
    {
        if ((zaman > 10 && zaman < 20) || (zaman > 80 && zaman < 90) )
        {
            skor += 1;
        }
    }
    void button5olay()
    {
        if ((zaman > 30 && zaman < 40) )
        {
            skor += 1;
        }
    }
    void button6olay()
    {
        if ((zaman > 50 && zaman < 60) )
        {
            skor += 1;
        }
    }
}
