# Grupa5-eSchedule
Tema: raspored

## Tim "Kontrola Magičnih sistema"
-----
Članovi tima:
- Kenan Omić
- Seid Korać
- Miralem Memić

-------------------------------------------------------------------------------

**"eSchedule"** je aplikacija osmišljena od strane tima studenata Elektrotehničkog fakulteta u Sarajevu, prvenstveno za svrhu predmeta *"Objektno orjentisana analiza i dizajn"*, ali i u svrhu pomaganja studentima i nastavnom osoblju fakulteta. Motivisani idejama, te stvarima za koje mislimo da su potrebne prije svega nama kao studentima, zatim i nastavnom osoblju, koristimo svoje stečeno znanje rada u C# i ASP.NET kako bi kreirali ovu aplikaciju.

Cilj aplikacije je da studentu ili uposleniku fakulteta pruži sve potrebne informacije o tome gdje i kada, dotična osoba mora da bude prisutna na fakultetu. Aplikacija koristi kreirani raspored fakulteta, te na osnovu njega pruža informacije korisniku.

-------------------------------------------------------------------------------

## Funkcionalnosti

Svaka osoba dobija informacije u zavisnosti od toga koji je tip korisnika. Na osnovu toga se također, određuju i privilegije koje posjedujete kao korisnik.

### Student
- Informacije o vremenu i lokaciji:
  - Predavanja
  - Vježbi
  - Ispita
- Mogućnost odabir laboratorijskih grupa ako ista nije popunjena
- Mogućnost slanja zahtjeva za zamjenu grupe drugim studentima
- Dobijanje notifikacija vezane za predmete koje student trenutno sluša

### Nastavno osoblje
- Informacije o vremenu:
  - Predavanja
  - Vježbi
  - Ispita
- Praćenje prisustva na predavanjima i vježbama
- Admin panel za administraciju predmeta
  - Objava novosti studentima vezanih za predmet
  - Davanje pravo pristupa asistentima i demonstratorima
  - Pomjeranje termina predavanja i vježbi uz slanje notifikacije studentima
  - Praćenje sastava laboratorijskih grupa
  - Kreiranje opisa predavanja i vježbi sa posebnim napomenama ako vježba zahtijeva pripremu, ako je potrebna pročitati određene materijale prije vježbe i slično.

Aplikacija ima mogucnost praćenja prisustva pomoću QR kodova koji se prikazuju na predavanju/vježbama.

Aplikacija posjeduje Google Maps integraciju da bi se pratila lokacija predavanja.
### Administrator
Osoba zadužena za održavanje aplikacije i dodjele predmeta profesorima
- Dodjela predmeta profesorima
- Verifikacija pohađanja predmeta za koje se studenti prijave
- Kreiranje i implementacija radnih i prototipnih verzija rasporeda
- Kreiranje eksternih događaja (radionice, takmičenja, predavanja, itd.) i slanje notifikacije o istim ostalim korisnicima
- Upisivanje praznika u sistem i pisanje čestitki za iste koje će se slati ostalim korisnicima
- Uvođenje neradnih dana u raspored i kreiranje rasporeda za vanredne situacije

### Funkcionalnosti planirane za kasnije faze razvoja
- QR scanner prisustva studenata
- Google maps integracija za praćenje lokacije
- Kreiranje algoritma za stvaranje rasporeda koji uzima sve ili većinu faktora u obzir pri stvaranju prototipskih verzija rasporeda
-------------------------------------------------------------------------------
## Akteri
- Student
- Nastavno osoblje
  - Profesor
  - Asistent
  - Demonstrator
- Administrator

---------------------------------
Aplikacija je autentična i isključivo plod mašte tima "Kontrola magičnih sistema".

Kontrola magičnih sistema

Link za repozitorij na GitHubu:
https://github.com/ooad-2019-2020/Grupa5-eSchedule

