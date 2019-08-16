using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JobsYaz : MonoBehaviour {
    int a=0 ;
    int b = 0;
    public Text xyz;
    public Text zzz;
    public string[] jobsname = { "Driver", "Fireman", "Musician", "Pilot", "Farmer", "Police","Postman", "Scientist", "Gardener", "Soldier",
        "Veterinary", "Baker", "Carpenter", "Cook","Dentist", "Doctor", "Engineer", "Fisherman", "Hairdresser", "Judge", "Lawyer", "Nurse",
        "Teacher", "Photographer", "Painter", "Singer", "Tailor", "Architect"};
    public string[] jobsname2 = { "Şoför", "İtfayeci", "Müzisyen", "Pilot", "Çitfçi", "Polis","Postacı", "Bilim Adamı", "Bahçıvan", "Asker",
        "Veteriner", "Fırıncı", "Marangoz", "Aşçı","Diş Hekimi", "Doktor", "Mühendis", "Balıkçı", "Kuaför", "Hakim", "Avukat", "Hemşire",
        "Öğretmen", "Fotoğrafçı", "Ressam", "Şarkıcı", "Terzi", "Mimar"};
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        xyz.text = jobsname[a];
        zzz.text = jobsname2[b];
     

    }
    public void arttırmacık()
    {
        a += 1;
        b += 1;
    }
    public void eksiltmecik()
    {
        a -= 1;
        b -= 1;
    }
}
